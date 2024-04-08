using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants.OrderOperationClaims;



namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetById;

public class GetByIdOrderQuery : IRequest<GetByIdOrderResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQuery, GetByIdOrderResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly OrderBusinessRules _orderBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderQueryHandler(IOrderRepository orderRepository, IMapper mapper, OrderBusinessRules orderBusinessRules)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _orderBusinessRules = orderBusinessRules;
        }

        public async Task<GetByIdOrderResponse> Handle(GetByIdOrderQuery request, CancellationToken cancellationToken)
        {
            _orderBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdOrderResponse>(await _orderRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.OrderMemos).Include(x => x.OrderAttributeValues).Include(x => x.Customer)
                .Include(x => x.OrderItems).ThenInclude(oi => oi.OrderItemMemos)
                .Include(x => x.OrderItems).ThenInclude(oi => oi.OrderItemStockAttrValues)
                .Include(x => x.OrderItems).ThenInclude(oi => oi.OrderShipItems),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
