using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Rules;
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

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Update;

public class UpdateLocationDepositorCommand : IRequest<UpdatedLocationDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationDepositorOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationDepositors"];

    public UpdateLocationDepositorDto LocationDepositor { get; set; }
    public LocationDepositorsDetailLevel DetailLevel { get; set; }

    public class UpdateLocationDepositorCommandHandler : IRequestHandler<UpdateLocationDepositorCommand, UpdatedLocationDepositorResponse>
    {
        private readonly ILocationDepositorRepository _locationDepositorRepository;
        private readonly LocationDepositorBusinessRules _locationDepositorBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationDepositorCommandHandler(ILocationDepositorRepository locationDepositorRepository, LocationDepositorBusinessRules locationDepositorBusinessRules, IMapper mapper)
        {
            _locationDepositorRepository = locationDepositorRepository;
            _locationDepositorBusinessRules = locationDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationDepositorResponse> Handle(UpdateLocationDepositorCommand request, CancellationToken cancellationToken)
        {
            _locationDepositorBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationDepositor? currentLocationDepositor = await _locationDepositorRepository.GetAsync(predicate: x => x.Id == request.LocationDepositor.Id);

            LocationDepositor? locationDepositor = _mapper.Map(request.LocationDepositor, currentLocationDepositor);
            locationDepositor.UpdatedDate = DateTime.Now;

            await _locationDepositorRepository.UpdateAsync(locationDepositor);

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

                return _mapper.Map<UpdatedLocationDepositorResponse>(response);
            }
            else
            {
                var response = await _locationDepositorRepository.GetAsync(predicate: x => x.Id == locationDepositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationDepositorResponse>(response);
            }
        }
    }
}

