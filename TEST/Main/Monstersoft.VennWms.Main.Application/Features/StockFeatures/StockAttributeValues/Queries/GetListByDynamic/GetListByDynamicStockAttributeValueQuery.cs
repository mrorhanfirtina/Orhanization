using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants.StockAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicStockAttributeValueQuery : IRequest<GetListResponse<GetListByDynamicStockAttributeValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicStockAttributeValueQueryHandler : IRequestHandler<GetListByDynamicStockAttributeValueQuery, GetListResponse<GetListByDynamicStockAttributeValueListItemDto>>
    {
        private readonly IStockAttributeValueRepository _stockAttributeValueRepository;
        private readonly StockAttributeValueBusinessRules _stockAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockAttributeValueQueryHandler(IStockAttributeValueRepository stockAttributeValueRepository, IMapper mapper, StockAttributeValueBusinessRules stockAttributeValueBusinessRules)
        {
            _stockAttributeValueRepository = stockAttributeValueRepository;
            _stockAttributeValueBusinessRules = stockAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockAttributeValueListItemDto>> Handle(GetListByDynamicStockAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _stockAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<StockAttributeValue> stockAttributeValueList = await _stockAttributeValueRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicStockAttributeValueListItemDto>>(stockAttributeValueList);
        }
    }

}

