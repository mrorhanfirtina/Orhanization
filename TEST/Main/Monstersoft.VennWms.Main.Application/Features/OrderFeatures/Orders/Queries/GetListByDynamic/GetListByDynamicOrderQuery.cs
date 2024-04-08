using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
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
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants.OrderOperationClaims;



namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetListByDynamic;

public class GetListByDynamicOrderQuery : IRequest<GetListResponse<GetListByDynamicOrderListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderQueryHandler : IRequestHandler<GetListByDynamicOrderQuery, GetListResponse<GetListByDynamicOrderListItemDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly OrderBusinessRules _orderBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderQueryHandler(IOrderRepository orderRepository, IMapper mapper, OrderBusinessRules orderBusinessRules)
        {
            _orderRepository = orderRepository;
            _orderBusinessRules = orderBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderListItemDto>> Handle(GetListByDynamicOrderQuery request, CancellationToken cancellationToken)
        {
            _orderBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Order> orderList = await _orderRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.OrderMemos).Include(x => x.OrderAttributeValues).Include(x => x.Customer)
            .Include(x => x.OrderItems).ThenInclude(oi => oi.OrderItemMemos)
            .Include(x => x.OrderItems).ThenInclude(oi => oi.OrderItemStockAttrValues)
            .Include(x => x.OrderItems).ThenInclude(oi => oi.OrderShipItems),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderListItemDto>>(orderList);
        }
    }

}
