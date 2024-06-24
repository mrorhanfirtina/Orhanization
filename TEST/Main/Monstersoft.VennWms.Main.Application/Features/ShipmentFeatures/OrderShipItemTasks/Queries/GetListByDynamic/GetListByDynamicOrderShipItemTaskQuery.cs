using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants.OrderShipItemTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Queries.GetListByDynamic;

public class GetListByDynamicOrderShipItemTaskQuery : IRequest<GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public OrderShipItemTasksDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicOrderShipItemTaskQueryHandler : IRequestHandler<GetListByDynamicOrderShipItemTaskQuery, GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>>
    {
        private readonly IOrderShipItemTaskRepository _orderShipItemTaskRepository;
        private readonly OrderShipItemTaskBusinessRules _orderShipItemTaskBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderShipItemTaskQueryHandler(IOrderShipItemTaskRepository orderShipItemTaskRepository, IMapper mapper, OrderShipItemTaskBusinessRules orderShipItemTaskBusinessRules)
        {
            _orderShipItemTaskRepository = orderShipItemTaskRepository;
            _orderShipItemTaskBusinessRules = orderShipItemTaskBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>> Handle(GetListByDynamicOrderShipItemTaskQuery request, CancellationToken cancellationToken)
        {
            _orderShipItemTaskBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<OrderShipItemTask> orderShipItemTaskList = await _orderShipItemTaskRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<OrderShipItemTask> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeWorkTask)
                    {
                        query = query.Include(y => y.WorkTask);
                    }

                    if (detailLevel.IncludeOrderShipItem)
                    {
                        query = query.Include(y => y.OrderShipItem);
                    }

                    if (detailLevel.IncludeOrderShipItemStock)
                    {
                        query = query.Include(y => y.OrderShipItemStocks);

                        if (detailLevel.OrderShipItemStockDetailLevel.IncludeStock)
                        {
                            query = query.Include(y => y.OrderShipItemStocks).ThenInclude(y => y.Stock);
                        }

                        if (detailLevel.OrderShipItemStockDetailLevel.IncludeStockPackType)
                        {
                            query = query.Include(y => y.OrderShipItemStocks).ThenInclude(y => y.StockPackType);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<OrderShipItemTask, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>>(orderShipItemTaskList);
            }
            else
            {
                Paginate<OrderShipItemTask> orderShipItemTaskList = await _orderShipItemTaskRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>>(orderShipItemTaskList);
            }
        }
    }

}
