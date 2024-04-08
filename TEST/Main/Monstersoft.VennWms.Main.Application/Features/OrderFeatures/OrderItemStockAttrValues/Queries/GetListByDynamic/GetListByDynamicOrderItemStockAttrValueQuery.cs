using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants.OrderItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Queries.GetListByDynamic;

public class GetListByDynamicOrderItemStockAttrValueQuery : IRequest<GetListResponse<GetListByDynamicOrderItemStockAttrValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderItemStockAttrValueQueryHandler : IRequestHandler<GetListByDynamicOrderItemStockAttrValueQuery, GetListResponse<GetListByDynamicOrderItemStockAttrValueListItemDto>>
    {
        private readonly IOrderItemStockAttrValueRepository _orderItemStockAttrValueRepository;
        private readonly OrderItemStockAttrValueBusinessRules _orderItemStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderItemStockAttrValueQueryHandler(IOrderItemStockAttrValueRepository orderItemStockAttrValueRepository, IMapper mapper, OrderItemStockAttrValueBusinessRules orderItemStockAttrValueBusinessRules)
        {
            _orderItemStockAttrValueRepository = orderItemStockAttrValueRepository;
            _orderItemStockAttrValueBusinessRules = orderItemStockAttrValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderItemStockAttrValueListItemDto>> Handle(GetListByDynamicOrderItemStockAttrValueQuery request, CancellationToken cancellationToken)
        {
            _orderItemStockAttrValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderItemStockAttrValue> orderItemStockAttrValueList = await _orderItemStockAttrValueRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderItemStockAttrValueListItemDto>>(orderItemStockAttrValueList);
        }
    }

}
