using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants.OrderShipItemTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Create;

public class CreateOrderShipItemTaskCommand : IRequest<CreatedOrderShipItemTaskResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipItemTasks";

    public CreateOrderShipItemTaskDto OrderShipItemTask { get; set; }
    public OrderShipItemTasksDetailLevel? DetailLevel { get; set; }

    public class CreateOrderShipItemTaskCommandHandler : IRequestHandler<CreateOrderShipItemTaskCommand, CreatedOrderShipItemTaskResponse>
    {
        private readonly IOrderShipItemTaskRepository _orderShipItemTaskRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipItemTaskBusinessRules _orderShipItemTaskBusinessRules;

        public CreateOrderShipItemTaskCommandHandler(IOrderShipItemTaskRepository orderShipItemTaskRepository, IMapper mapper, OrderShipItemTaskBusinessRules orderShipItemTaskBusinessRules)
        {
            _orderShipItemTaskRepository = orderShipItemTaskRepository;
            _mapper = mapper;
            _orderShipItemTaskBusinessRules = orderShipItemTaskBusinessRules;
        }

        public async Task<CreatedOrderShipItemTaskResponse> Handle(CreateOrderShipItemTaskCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemTaskBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            OrderShipItemTask? orderShipItemTask = _mapper.Map<OrderShipItemTask>(request.OrderShipItemTask);

            orderShipItemTask.CreatedDate = DateTime.Now;

            orderShipItemTask.OrderShipItemStocks.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            await _orderShipItemTaskRepository.AddAsync(orderShipItemTask);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderShipItemTaskRepository.GetAsync(predicate: x => x.Id == orderShipItemTask.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderShipItemTaskResponse>(response);
            }
            else
            {
                var response = await _orderShipItemTaskRepository.GetAsync(predicate: x => x.Id == orderShipItemTask.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderShipItemTaskResponse>(response);
            }
        }
    }
}
