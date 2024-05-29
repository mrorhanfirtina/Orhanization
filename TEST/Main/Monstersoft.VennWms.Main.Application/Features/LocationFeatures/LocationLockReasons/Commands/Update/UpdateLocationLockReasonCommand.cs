using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants.LocationLockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Update;

public class UpdateLocationLockReasonCommand : IRequest<UpdatedLocationLockReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationLockReasonOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationLockReasons";

    public UpdateLocationLockReasonDto LocationLockReason { get; set; }
    public LocationLockReasonDetailLevel DetailLevel { get; set; }

    public class UpdateLocationLockReasonCommandHandler : IRequestHandler<UpdateLocationLockReasonCommand, UpdatedLocationLockReasonResponse>
    {
        private readonly ILocationLockReasonRepository _locationLockReasonRepository;
        private readonly LocationLockReasonBusinessRules _locationLockReasonBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationLockReasonCommandHandler(ILocationLockReasonRepository locationLockReasonRepository, LocationLockReasonBusinessRules locationLockReasonBusinessRules, IMapper mapper)
        {
            _locationLockReasonRepository = locationLockReasonRepository;
            _locationLockReasonBusinessRules = locationLockReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationLockReasonResponse> Handle(UpdateLocationLockReasonCommand request, CancellationToken cancellationToken)
        {
            _locationLockReasonBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationLockReason? currentLocationLockReason = await _locationLockReasonRepository.GetAsync(predicate: x => x.Id == request.LocationLockReason.Id);

            LocationLockReason? locationLockReason = _mapper.Map(request.LocationLockReason, currentLocationLockReason);
            locationLockReason.UpdatedDate = DateTime.Now;

            await _locationLockReasonRepository.UpdateAsync(locationLockReason);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationLockReasonRepository.GetAsync(predicate: x => x.Id == locationLockReason.Id,
                include: x =>
                {
                    IQueryable<LocationLockReason> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeLockReason)
                    {
                        query = query.Include(y => y.LockReason);
                    }


                    var includableQuery = query as IIncludableQueryable<LocationLockReason, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationLockReasonResponse>(response);
            }
            else
            {
                var response = await _locationLockReasonRepository.GetAsync(predicate: x => x.Id == locationLockReason.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationLockReasonResponse>(response);
            }
        }
    }
}


