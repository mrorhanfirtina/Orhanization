using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants.OrderPriorityOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Queries.GetListByDynamic;

public class GetListByDynamicOrderPriorityQuery : IRequest<GetListResponse<GetListByDynamicOrderPriorityListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public OrderPrioritiesDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicOrderPriorityQueryHandler : IRequestHandler<GetListByDynamicOrderPriorityQuery, GetListResponse<GetListByDynamicOrderPriorityListItemDto>>
    {
        private readonly IOrderPriorityRepository _orderPriorityRepository;
        private readonly OrderPriorityBusinessRules _orderPriorityBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderPriorityQueryHandler(IOrderPriorityRepository orderPriorityRepository, IMapper mapper, OrderPriorityBusinessRules orderPriorityBusinessRules)
        {
            _orderPriorityRepository = orderPriorityRepository;
            _orderPriorityBusinessRules = orderPriorityBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderPriorityListItemDto>> Handle(GetListByDynamicOrderPriorityQuery request, CancellationToken cancellationToken)
        {
            _orderPriorityBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<OrderPriority> orderPriorityList = await _orderPriorityRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<OrderPriority> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Order);
                    }

                    if (detailLevel.IncludePriorityList)
                    {
                        query = query.Include(y => y.Priority);
                    }


                    var includableQuery = query as IIncludableQueryable<OrderPriority, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicOrderPriorityListItemDto>>(orderPriorityList);
            }
            else
            {
                Paginate<OrderPriority> orderPriorityList = await _orderPriorityRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicOrderPriorityListItemDto>>(orderPriorityList);
            }
        }
    }
}


