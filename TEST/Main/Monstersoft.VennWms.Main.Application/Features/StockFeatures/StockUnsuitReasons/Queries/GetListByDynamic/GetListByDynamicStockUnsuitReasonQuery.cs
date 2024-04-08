using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Constants.StockUnsuitReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Queries.GetListByDynamic;

public class GetListByDynamicStockUnsuitReasonQuery : IRequest<GetListResponse<GetListByDynamicStockUnsuitReasonListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicStockUnsuitReasonQueryHandler : IRequestHandler<GetListByDynamicStockUnsuitReasonQuery, GetListResponse<GetListByDynamicStockUnsuitReasonListItemDto>>
    {
        private readonly IStockUnsuitReasonRepository _stockUnsuitReasonRepository;
        private readonly StockUnsuitReasonBusinessRules _stockUnsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockUnsuitReasonQueryHandler(IStockUnsuitReasonRepository stockUnsuitReasonRepository, IMapper mapper, StockUnsuitReasonBusinessRules stockUnsuitReasonBusinessRules)
        {
            _stockUnsuitReasonRepository = stockUnsuitReasonRepository;
            _stockUnsuitReasonBusinessRules = stockUnsuitReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockUnsuitReasonListItemDto>> Handle(GetListByDynamicStockUnsuitReasonQuery request, CancellationToken cancellationToken)
        {
            _stockUnsuitReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<StockUnsuitReason> stockUnsuitReasonList = await _stockUnsuitReasonRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicStockUnsuitReasonListItemDto>>(stockUnsuitReasonList);
        }
    }
}
