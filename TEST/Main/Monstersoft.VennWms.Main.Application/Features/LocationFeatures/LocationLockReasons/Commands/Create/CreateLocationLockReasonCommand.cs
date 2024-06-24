using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants.LocationLockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Create;

public class CreateLocationLockReasonCommand : IRequest<CreatedLocationLockReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationLockReasons";

    public CreateLocationLockReasonDto LocationLockReason { get; set; }
    public LocationLockReasonsDetailLevel DetailLevel { get; set; }


    public class CreateLocationLockReasonCommandHandler : IRequestHandler<CreateLocationLockReasonCommand, CreatedLocationLockReasonResponse>
    {
        private readonly ILocationLockReasonRepository _locationLockReasonRepository;
        private readonly LocationLockReasonBusinessRules _locationLockReasonBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationLockReasonCommandHandler(ILocationLockReasonRepository locationLockReasonRepository, IMapper mapper, LocationLockReasonBusinessRules locationLockReasonBusinessRules)
        {
            _locationLockReasonRepository = locationLockReasonRepository;
            _mapper = mapper;
            _locationLockReasonBusinessRules = locationLockReasonBusinessRules;
        }

        public async Task<CreatedLocationLockReasonResponse> Handle(CreateLocationLockReasonCommand request, CancellationToken cancellationToken)
        {
            _locationLockReasonBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationLockReason locationLockReason = _mapper.Map<LocationLockReason>(request.LocationLockReason);
            locationLockReason.Id = Guid.NewGuid();
            locationLockReason.CreatedDate = DateTime.Now;

            await _locationLockReasonRepository.AddAsync(locationLockReason);

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

                return _mapper.Map<CreatedLocationLockReasonResponse>(response);
            }
            else
            {
                var response = await _locationLockReasonRepository.GetAsync(predicate: x => x.Id == locationLockReason.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationLockReasonResponse>(response);
            }
        }
    }
}


