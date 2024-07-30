using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Create;

public class CreateOrderItemMemoCommand : IRequest<CreatedOrderItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderItemMemos"];

    public CreateOrderItemMemoDto OrderItemMemo { get; set; }
    public OrderItemMemosDetailLevel DetailLevel { get; set; }


    public class CreateOrderItemMemoCommandHandler : IRequestHandler<CreateOrderItemMemoCommand, CreatedOrderItemMemoResponse>
    {
        private readonly IOrderItemMemoRepository _orderItemMemoRepository;
        private readonly OrderItemMemoBusinessRules _orderItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public CreateOrderItemMemoCommandHandler(IOrderItemMemoRepository orderItemMemoRepository, IMapper mapper, OrderItemMemoBusinessRules orderItemMemoBusinessRules)
        {
            _orderItemMemoRepository = orderItemMemoRepository;
            _mapper = mapper;
            _orderItemMemoBusinessRules = orderItemMemoBusinessRules;
        }

        public async Task<CreatedOrderItemMemoResponse> Handle(CreateOrderItemMemoCommand request, CancellationToken cancellationToken)
        {
            _orderItemMemoBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckOrderItemIdExistence(request.OrderItemMemo.OrderItemId);

            OrderItemMemo orderItemMemo = _mapper.Map<OrderItemMemo>(request.OrderItemMemo);
            orderItemMemo.Id = Guid.NewGuid();
            orderItemMemo.CreatedDate = DateTime.Now;

            await _orderItemMemoRepository.AddAsync(orderItemMemo);

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

                return _mapper.Map<CreatedOrderItemMemoResponse>(response);
            }
            else
            {
                var response = await _orderItemMemoRepository.GetAsync(predicate: x => x.Id == orderItemMemo.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderItemMemoResponse>(response);
            }
        }
    }

}

