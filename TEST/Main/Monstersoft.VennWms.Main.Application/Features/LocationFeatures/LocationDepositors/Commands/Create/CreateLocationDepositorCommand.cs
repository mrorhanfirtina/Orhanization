using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants.LocationDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Create;

public class CreateLocationDepositorCommand : IRequest<CreatedLocationDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationDepositors";

    public CreateLocationDepositorDto LocationDepositor { get; set; }
    public LocationDepositorsDetailLevel DetailLevel { get; set; }


    public class CreateLocationDepositorCommandHandler : IRequestHandler<CreateLocationDepositorCommand, CreatedLocationDepositorResponse>
    {
        private readonly ILocationDepositorRepository _locationDepositorRepository;
        private readonly LocationDepositorBusinessRules _locationDepositorBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationDepositorCommandHandler(ILocationDepositorRepository locationDepositorRepository, IMapper mapper, LocationDepositorBusinessRules locationDepositorBusinessRules)
        {
            _locationDepositorRepository = locationDepositorRepository;
            _mapper = mapper;
            _locationDepositorBusinessRules = locationDepositorBusinessRules;
        }

        public async Task<CreatedLocationDepositorResponse> Handle(CreateLocationDepositorCommand request, CancellationToken cancellationToken)
        {
            _locationDepositorBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationDepositor locationDepositor = _mapper.Map<LocationDepositor>(request.LocationDepositor);
            locationDepositor.Id = Guid.NewGuid();
            locationDepositor.CreatedDate = DateTime.Now;

            await _locationDepositorRepository.AddAsync(locationDepositor);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationDepositorRepository.GetAsync(predicate: x => x.Id == locationDepositor.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationDepositorResponse>(response);
            }
            else
            {
                var response = await _locationDepositorRepository.GetAsync(predicate: x => x.Id == locationDepositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationDepositorResponse>(response);
            }
        }
    }
}

