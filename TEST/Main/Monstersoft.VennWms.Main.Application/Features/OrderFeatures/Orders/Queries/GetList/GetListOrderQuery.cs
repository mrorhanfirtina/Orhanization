﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants.OrderOperationClaims;



namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetList;

public class GetListOrderQuery : IRequest<GetListResponse<GetListOrderListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListOrderQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetOrders";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListOrderQueryHandler : IRequestHandler<GetListOrderQuery, GetListResponse<GetListOrderListItemDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly OrderBusinessRules _orderBusinessRules;
        private readonly IMapper _mapper;

        public GetListOrderQueryHandler(IOrderRepository orderRepository, IMapper mapper, OrderBusinessRules orderBusinessRules)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _orderBusinessRules = orderBusinessRules;
        }

        public async Task<GetListResponse<GetListOrderListItemDto>> Handle(GetListOrderQuery request, CancellationToken cancellationToken)
        {
            _orderBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Order> orderList = await _orderRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.OrderMemos).Include(x => x.OrderAttributeValues).Include(x => x.Customer)
            .Include(x => x.OrderItems).ThenInclude(oi => oi.OrderItemMemos)
            .Include(x => x.OrderItems).ThenInclude(oi => oi.OrderItemStockAttrValues)
            .Include(x => x.OrderItems).ThenInclude(oi => oi.OrderShipItems),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListOrderListItemDto>>(orderList);
        }
    }

}
