using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants.OrderShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetList;

public class GetListOrderShipmentQuery : IRequest<GetListResponse<GetListOrderShipmentListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListOrderShipmentQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetOrderShipments";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListOrderShipmentQueryHandler : IRequestHandler<GetListOrderShipmentQuery, GetListResponse<GetListOrderShipmentListItemDto>>
    {
        private readonly IOrderShipmentRepository _orderShipmentRepository;
        private readonly OrderShipmentBusinessRules _orderShipmentBusinessRules;
        private readonly IMapper _mapper;

        public GetListOrderShipmentQueryHandler(IOrderShipmentRepository orderShipmentRepository, IMapper mapper, OrderShipmentBusinessRules orderShipmentBusinessRules)
        {
            _orderShipmentRepository = orderShipmentRepository;
            _mapper = mapper;
            _orderShipmentBusinessRules = orderShipmentBusinessRules;
        }

        public async Task<GetListResponse<GetListOrderShipmentListItemDto>> Handle(GetListOrderShipmentQuery request, CancellationToken cancellationToken)
        {
            _orderShipmentBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderShipment> orderShipmentList = await _orderShipmentRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.OrderShipItems).ThenInclude(os => os.OrderShipItemTasks).ThenInclude(ot => ot.OrderShipItemStocks),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListOrderShipmentListItemDto>>(orderShipmentList);
        }
    }

}
