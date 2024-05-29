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
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants.LocationLockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Queries.GetListByDynamic;

public class GetListByDynamicLocationLockReasonQuery : IRequest<GetListResponse<GetListByDynamicLocationLockReasonListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public LocationLockReasonDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicLocationLockReasonQueryHandler : IRequestHandler<GetListByDynamicLocationLockReasonQuery, GetListResponse<GetListByDynamicLocationLockReasonListItemDto>>
    {
        private readonly ILocationLockReasonRepository _locationLockReasonRepository;
        private readonly LocationLockReasonBusinessRules _locationLockReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationLockReasonQueryHandler(ILocationLockReasonRepository locationLockReasonRepository, IMapper mapper, LocationLockReasonBusinessRules locationLockReasonBusinessRules)
        {
            _locationLockReasonRepository = locationLockReasonRepository;
            _locationLockReasonBusinessRules = locationLockReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationLockReasonListItemDto>> Handle(GetListByDynamicLocationLockReasonQuery request, CancellationToken cancellationToken)
        {
            _locationLockReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);



            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<LocationLockReason> locationLockReasonList = await _locationLockReasonRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
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
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationLockReasonListItemDto>>(locationLockReasonList);
            }
            else
            {
                Paginate<LocationLockReason> locationLockReasonList = await _locationLockReasonRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationLockReasonListItemDto>>(locationLockReasonList);
            }
        }
    }
}


