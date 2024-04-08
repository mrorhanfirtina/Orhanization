using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Update;

public class UpdateOrderItemMemoCommand : IRequest<UpdatedOrderItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderItemMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderItemMemos";

    public UpdateOrderItemMemoDto OrderItemMemo { get; set; }


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

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedOrderItemMemoResponse>(await _orderItemMemoRepository.UpdateAsync(orderItemMemo));
        }
    }
}

