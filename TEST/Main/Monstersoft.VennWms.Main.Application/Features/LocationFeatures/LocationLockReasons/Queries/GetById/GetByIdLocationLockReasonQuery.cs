using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants.LocationLockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Queries.GetById;

public class GetByIdLocationLockReasonQuery : IRequest<GetByIdLocationLockReasonResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public LocationLockReasonsDetailLevel DetailLevel { get; set; }

    public class GetByIdLocationLockReasonQueryHandler : IRequestHandler<GetByIdLocationLockReasonQuery, GetByIdLocationLockReasonResponse>
    {
        private readonly ILocationLockReasonRepository _locationLockReasonRepository;
        private readonly LocationLockReasonBusinessRules _locationLockReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationLockReasonQueryHandler(ILocationLockReasonRepository locationLockReasonRepository, IMapper mapper, LocationLockReasonBusinessRules locationLockReasonBusinessRules)
        {
            _locationLockReasonRepository = locationLockReasonRepository;
            _mapper = mapper;
            _locationLockReasonBusinessRules = locationLockReasonBusinessRules;
        }

        public async Task<GetByIdLocationLockReasonResponse> Handle(GetByIdLocationLockReasonQuery request, CancellationToken cancellationToken)
        {
            _locationLockReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdLocationLockReasonResponse>(await _locationLockReasonRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdLocationLockReasonResponse>(await _locationLockReasonRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}


