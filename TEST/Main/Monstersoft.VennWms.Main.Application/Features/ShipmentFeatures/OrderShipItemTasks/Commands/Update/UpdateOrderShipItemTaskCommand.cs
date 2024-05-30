using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Update;

public class UpdateOrderShipItemTaskCommand : IRequest<UpdatedOrderShipItemTaskResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderShipItemTaskOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipItemTasks";

    public UpdateOrderShipItemTaskDto OrderShipItemTask { get; set; }
    public OrderShipItemTasksDetailLevel? DetailLevel { get; set; }


    public class UpdateOrderShipItemTaskCommandHandler : IRequestHandler<UpdateOrderShipItemTaskCommand, UpdatedOrderShipItemTaskResponse>
    {
        private readonly IOrderShipItemTaskRepository _orderShipItemTaskRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipItemTaskBusinessRules _orderShipItemTaskBusinessRules;

        public UpdateOrderShipItemTaskCommandHandler(IOrderShipItemTaskRepository orderShipItemTaskRepository, IMapper mapper, OrderShipItemTaskBusinessRules orderShipItemTaskBusinessRules)
        {
            _orderShipItemTaskRepository = orderShipItemTaskRepository;
            _mapper = mapper;
            _orderShipItemTaskBusinessRules = orderShipItemTaskBusinessRules;
        }

        public async Task<UpdatedOrderShipItemTaskResponse> Handle(UpdateOrderShipItemTaskCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemTaskBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderShipItemTask.Id);

            OrderShipItemTask? currentOrderShipItemTask = await _orderShipItemTaskRepository.GetAsync(predicate: x => x.Id == request.OrderShipItemTask.Id,
            include: x => x.Include(y => y.OrderShipItemStocks),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            OrderShipItemTask? orderShipItemTask = _mapper.Map(request.OrderShipItemTask, currentOrderShipItemTask);
            orderShipItemTask.UpdatedDate = DateTime.Now;

            orderShipItemTask.OrderShipItemStocks.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
                x.CreatedDate = orderShipItemTask.CreatedDate;
            });

            await _orderShipItemTaskRepository.UpdateAsync(orderShipItemTask);

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

                return _mapper.Map<UpdatedOrderShipItemTaskResponse>(response);
            }
            else
            {
                var response = await _orderShipItemTaskRepository.GetAsync(predicate: x => x.Id == orderShipItemTask.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderShipItemTaskResponse>(response);
            }
        }
    }
}
