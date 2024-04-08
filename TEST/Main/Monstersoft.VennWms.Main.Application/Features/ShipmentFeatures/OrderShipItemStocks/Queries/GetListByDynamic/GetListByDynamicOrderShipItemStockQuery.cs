using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Constants.OrderShipItemStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Queries.GetListByDynamic;

public class GetListByDynamicOrderShipItemStockQuery : IRequest<GetListResponse<GetListByDynamicOrderShipItemStockListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderShipItemStockQueryHandler : IRequestHandler<GetListByDynamicOrderShipItemStockQuery, GetListResponse<GetListByDynamicOrderShipItemStockListItemDto>>
    {
        private readonly IOrderShipItemStockRepository _orderShipItemStockRepository;
        private readonly OrderShipItemStockBusinessRules _orderShipItemStockBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderShipItemStockQueryHandler(IOrderShipItemStockRepository orderShipItemStockRepository, IMapper mapper, OrderShipItemStockBusinessRules orderShipItemStockBusinessRules)
        {
            _orderShipItemStockRepository = orderShipItemStockRepository;
            _orderShipItemStockBusinessRules = orderShipItemStockBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderShipItemStockListItemDto>> Handle(GetListByDynamicOrderShipItemStockQuery request, CancellationToken cancellationToken)
        {
            _orderShipItemStockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderShipItemStock> orderShipItemStockList = await _orderShipItemStockRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderShipItemStockListItemDto>>(orderShipItemStockList);
        }
    }

}

