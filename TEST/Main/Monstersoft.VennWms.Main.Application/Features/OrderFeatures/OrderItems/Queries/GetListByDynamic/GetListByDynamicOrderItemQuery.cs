using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants.OrderItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetListByDynamic;

public class GetListByDynamicOrderItemQuery : IRequest<GetListResponse<GetListByDynamicOrderItemListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderItemQueryHandler : IRequestHandler<GetListByDynamicOrderItemQuery, GetListResponse<GetListByDynamicOrderItemListItemDto>>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly OrderItemBusinessRules _orderItemBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderItemQueryHandler(IOrderItemRepository orderItemRepository, IMapper mapper, OrderItemBusinessRules orderItemBusinessRules)
        {
            _orderItemRepository = orderItemRepository;
            _orderItemBusinessRules = orderItemBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderItemListItemDto>> Handle(GetListByDynamicOrderItemQuery request, CancellationToken cancellationToken)
        {
            _orderItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderItem> orderItemList = await _orderItemRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            include: m => m.Include(x => x.OrderItemMemos).Include(x => x.OrderItemStockAttrValues),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderItemListItemDto>>(orderItemList);
        }
    }

}
