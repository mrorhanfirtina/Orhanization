using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants.OrderShipItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Queries.GetListByDynamic;

public class GetListByDynamicOrderShipItemQuery : IRequest<GetListResponse<GetListByDynamicOrderShipItemListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderShipItemQueryHandler : IRequestHandler<GetListByDynamicOrderShipItemQuery, GetListResponse<GetListByDynamicOrderShipItemListItemDto>>
    {
        private readonly IOrderShipItemRepository _orderShipItemRepository;
        private readonly OrderShipItemBusinessRules _orderShipItemBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderShipItemQueryHandler(IOrderShipItemRepository orderShipItemRepository, IMapper mapper, OrderShipItemBusinessRules orderShipItemBusinessRules)
        {
            _orderShipItemRepository = orderShipItemRepository;
            _orderShipItemBusinessRules = orderShipItemBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderShipItemListItemDto>> Handle(GetListByDynamicOrderShipItemQuery request, CancellationToken cancellationToken)
        {
            _orderShipItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderShipItem> orderShipItemList = await _orderShipItemRepository.GetListByDynamicAsync(
            include: x => x.Include(y => y.OrderShipItemTasks)
                           .Include(y => y.OrderShipItemTasks).ThenInclude(m => m.OrderShipItemStocks),
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderShipItemListItemDto>>(orderShipItemList);
        }
    }

}
