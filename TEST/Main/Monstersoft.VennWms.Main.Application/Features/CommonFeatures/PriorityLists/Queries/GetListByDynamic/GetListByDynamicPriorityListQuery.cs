using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants.PriorityListOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetListByDynamic;

public class GetListByDynamicPriorityListQuery : IRequest<GetListResponse<GetListByDynamicPriorityListListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public PriorityListsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicPriorityListQueryHandler : IRequestHandler<GetListByDynamicPriorityListQuery, GetListResponse<GetListByDynamicPriorityListListItemDto>>
    {
        private readonly IPriorityListRepository _priorityListRepository;
        private readonly PriorityListBusinessRules _priorityListBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicPriorityListQueryHandler(IPriorityListRepository priorityListRepository, IMapper mapper, PriorityListBusinessRules priorityListBusinessRules)
        {
            _priorityListRepository = priorityListRepository;
            _priorityListBusinessRules = priorityListBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicPriorityListListItemDto>> Handle(GetListByDynamicPriorityListQuery request, CancellationToken cancellationToken)
        {
            _priorityListBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<PriorityList> priorityListList = await _priorityListRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<PriorityList> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<PriorityList, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicPriorityListListItemDto>>(priorityListList);
            }
            else
            {
                Paginate<PriorityList> priorityListList = await _priorityListRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicPriorityListListItemDto>>(priorityListList);
            }
        }
    }
}



