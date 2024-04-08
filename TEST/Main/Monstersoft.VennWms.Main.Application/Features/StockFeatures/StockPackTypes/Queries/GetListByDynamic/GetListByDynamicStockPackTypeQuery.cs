using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants.StockPackTypeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Queries.GetListByDynamic;

public class GetListByDynamicStockPackTypeQuery : IRequest<GetListResponse<GetListByDynamicStockPackTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicStockPackTypeQueryHandler : IRequestHandler<GetListByDynamicStockPackTypeQuery, GetListResponse<GetListByDynamicStockPackTypeListItemDto>>
    {
        private readonly IStockPackTypeRepository _stockPackTypeRepository;
        private readonly StockPackTypeBusinessRules _stockPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockPackTypeQueryHandler(IStockPackTypeRepository stockPackTypeRepository, IMapper mapper, StockPackTypeBusinessRules stockPackTypeBusinessRules)
        {
            _stockPackTypeRepository = stockPackTypeRepository;
            _stockPackTypeBusinessRules = stockPackTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockPackTypeListItemDto>> Handle(GetListByDynamicStockPackTypeQuery request, CancellationToken cancellationToken)
        {
            _stockPackTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<StockPackType> stockPackTypeList = await _stockPackTypeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicStockPackTypeListItemDto>>(stockPackTypeList);
        }
    }

}

