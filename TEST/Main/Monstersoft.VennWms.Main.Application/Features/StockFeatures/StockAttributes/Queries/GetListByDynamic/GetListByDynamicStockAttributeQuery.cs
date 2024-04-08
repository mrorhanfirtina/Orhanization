using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants.StockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetListByDynamic;

public class GetListByDynamicStockAttributeQuery : IRequest<GetListResponse<GetListByDynamicStockAttributeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicStockAttributeQueryHandler : IRequestHandler<GetListByDynamicStockAttributeQuery, GetListResponse<GetListByDynamicStockAttributeListItemDto>>
    {
        private readonly IStockAttributeRepository _stockAttributeRepository;
        private readonly StockAttributeBusinessRules _stockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockAttributeQueryHandler(IStockAttributeRepository stockAttributeRepository, IMapper mapper, StockAttributeBusinessRules stockAttributeBusinessRules)
        {
            _stockAttributeRepository = stockAttributeRepository;
            _stockAttributeBusinessRules = stockAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockAttributeListItemDto>> Handle(GetListByDynamicStockAttributeQuery request, CancellationToken cancellationToken)
        {
            _stockAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<StockAttribute> stockAttributeList = await _stockAttributeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicStockAttributeListItemDto>>(stockAttributeList);
        }
    }

}
