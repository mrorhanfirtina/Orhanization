using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants.OrderItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Update;

public class UpdateOrderItemMemoCommand : IRequest<UpdatedOrderItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderItemMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderItemMemos"];

    public UpdateOrderItemMemoDto OrderItemMemo { get; set; }
    public OrderItemMemosDetailLevel DetailLevel { get; set; }


    public class UpdateOrderItemMemoCommandHandler : IRequestHandler<UpdateOrderItemMemoCommand, UpdatedOrderItemMemoResponse>
    {
        private readonly IOrderItemMemoRepository _orderItemMemoRepository;
        private readonly OrderItemMemoBusinessRules _orderItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public UpdateOrderItemMemoCommandHandler(IOrderItemMemoRepository orderItemMemoRepository, OrderItemMemoBusinessRules orderItemMemoBusinessRules, IMapper mapper)
        {
            _orderItemMemoRepository = orderItemMemoRepository;
            _orderItemMemoBusinessRules = orderItemMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedOrderItemMemoResponse> Handle(UpdateOrderItemMemoCommand request, CancellationToken cancellationToken)
        {
            _orderItemMemoBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderItemMemo.Id)
            .CheckOrderItemIdExistence(request.OrderItemMemo.OrderItemId);

            OrderItemMemo? currentOrderItemMemo = await _orderItemMemoRepository.GetAsync(predicate: x => x.Id == request.OrderItemMemo.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            OrderItemMemo? orderItemMemo = _mapper.Map(request.OrderItemMemo, currentOrderItemMemo);
            orderItemMemo.UpdatedDate = DateTime.Now;

            await _orderItemMemoRepository.UpdateAsync(orderItemMemo);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderItemMemoRepository.GetAsync(predicate: x => x.Id == orderItemMemo.Id,
                include: x =>
                {
                    IQueryable<OrderItemMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrderItem)
                    {
                        query = query.Include(y => y.OrderItem);

                        if (detailLevel.OrderItemDetailLevel.IncludeOrder)
                        {
                            query = query.Include(y => y.OrderItem).ThenInclude(m => m.Order);

                            if (detailLevel.OrderItemDetailLevel.OrderDetailLevel.IncludeCustomer)
                            {
                                query = query.Include(y => y.OrderItem).ThenInclude(m => m.Order).ThenInclude(n => n.Customer);
                            }

                            if (detailLevel.OrderItemDetailLevel.OrderDetailLevel.IncludeDepositor)
                            {
                                query = query.Include(y => y.OrderItem).ThenInclude(m => m.Order).ThenInclude(n => n.Depositor);
                            }

                            if (detailLevel.OrderItemDetailLevel.OrderDetailLevel.IncludeReceiver)
                            {
                                query = query.Include(y => y.OrderItem).ThenInclude(m => m.Order).ThenInclude(n => n.Receiver);
                            }
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<OrderItemMemo, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderItemMemoResponse>(response);
            }
            else
            {
                var response = await _orderItemMemoRepository.GetAsync(predicate: x => x.Id == orderItemMemo.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderItemMemoResponse>(response);
            }
        }
    }
}

