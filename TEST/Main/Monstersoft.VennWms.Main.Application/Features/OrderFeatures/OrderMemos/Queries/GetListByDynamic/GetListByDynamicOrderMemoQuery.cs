using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Constants.OrderMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Queries.GetListByDynamic;

public class GetListByDynamicOrderMemoQuery : IRequest<GetListResponse<GetListByDynamicOrderMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderMemoQueryHandler : IRequestHandler<GetListByDynamicOrderMemoQuery, GetListResponse<GetListByDynamicOrderMemoListItemDto>>
    {
        private readonly IOrderMemoRepository _orderMemoRepository;
        private readonly OrderMemoBusinessRules _orderMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderMemoQueryHandler(IOrderMemoRepository orderMemoRepository, IMapper mapper, OrderMemoBusinessRules orderMemoBusinessRules)
        {
            _orderMemoRepository = orderMemoRepository;
            _orderMemoBusinessRules = orderMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderMemoListItemDto>> Handle(GetListByDynamicOrderMemoQuery request, CancellationToken cancellationToken)
        {
            _orderMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderMemo> orderMemoList = await _orderMemoRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderMemoListItemDto>>(orderMemoList);
        }
    }

}

