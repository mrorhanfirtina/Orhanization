using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants.OrderItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Queries.GetListByDynamic;

public class GetListByDynamicOrderItemMemoQuery : IRequest<GetListResponse<GetListByDynamicOrderItemMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderItemMemoQueryHandler : IRequestHandler<GetListByDynamicOrderItemMemoQuery, GetListResponse<GetListByDynamicOrderItemMemoListItemDto>>
    {
        private readonly IOrderItemMemoRepository _orderItemMemoRepository;
        private readonly OrderItemMemoBusinessRules _orderItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderItemMemoQueryHandler(IOrderItemMemoRepository orderItemMemoRepository, IMapper mapper, OrderItemMemoBusinessRules orderItemMemoBusinessRules)
        {
            _orderItemMemoRepository = orderItemMemoRepository;
            _orderItemMemoBusinessRules = orderItemMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderItemMemoListItemDto>> Handle(GetListByDynamicOrderItemMemoQuery request, CancellationToken cancellationToken)
        {
            _orderItemMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderItemMemo> orderItemMemoList = await _orderItemMemoRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderItemMemoListItemDto>>(orderItemMemoList);
        }
    }

}

