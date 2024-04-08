using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
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
    public string? CacheGroupKey => "GetOrderItemMemos";

    public CreateOrderItemMemoDto OrderItemMemo { get; set; }


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

            return _mapper.Map<CreatedOrderItemMemoResponse>(await _orderItemMemoRepository.AddAsync(orderItemMemo));
        }
    }

}

