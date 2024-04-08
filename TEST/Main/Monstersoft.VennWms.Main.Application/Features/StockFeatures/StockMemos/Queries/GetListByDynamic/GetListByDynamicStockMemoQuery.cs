using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Constants.StockMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Queries.GetListByDynamic;

public class GetListByDynamicStockMemoQuery : IRequest<GetListResponse<GetListByDynamicStockMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicStockMemoQueryHandler : IRequestHandler<GetListByDynamicStockMemoQuery, GetListResponse<GetListByDynamicStockMemoListItemDto>>
    {
        private readonly IStockMemoRepository _stockMemoRepository;
        private readonly StockMemoBusinessRules _stockMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockMemoQueryHandler(IStockMemoRepository stockMemoRepository, IMapper mapper, StockMemoBusinessRules stockMemoBusinessRules)
        {
            _stockMemoRepository = stockMemoRepository;
            _stockMemoBusinessRules = stockMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockMemoListItemDto>> Handle(GetListByDynamicStockMemoQuery request, CancellationToken cancellationToken)
        {
            _stockMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<StockMemo> stockMemoList = await _stockMemoRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicStockMemoListItemDto>>(stockMemoList);
        }
    }

}
