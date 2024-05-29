using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants.LocationDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Queries.GetById;

public class GetByIdLocationDepositorQuery : IRequest<GetByIdLocationDepositorResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public LocationDepositorDetailLevel DetailLevel { get; set; }

    public class GetByIdLocationDepositorQueryHandler : IRequestHandler<GetByIdLocationDepositorQuery, GetByIdLocationDepositorResponse>
    {
        private readonly ILocationDepositorRepository _locationDepositorRepository;
        private readonly LocationDepositorBusinessRules _locationDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationDepositorQueryHandler(ILocationDepositorRepository locationDepositorRepository, IMapper mapper, LocationDepositorBusinessRules locationDepositorBusinessRules)
        {
            _locationDepositorRepository = locationDepositorRepository;
            _mapper = mapper;
            _locationDepositorBusinessRules = locationDepositorBusinessRules;
        }

        public async Task<GetByIdLocationDepositorResponse> Handle(GetByIdLocationDepositorQuery request, CancellationToken cancellationToken)
        {
            _locationDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdLocationDepositorResponse>(await _locationDepositorRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<LocationDepositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);
                    }

                    var includableQuery = query as IIncludableQueryable<LocationDepositor, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdLocationDepositorResponse>(await _locationDepositorRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}

