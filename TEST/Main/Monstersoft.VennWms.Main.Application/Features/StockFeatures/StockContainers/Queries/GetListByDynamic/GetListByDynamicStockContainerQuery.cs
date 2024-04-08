using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants.StockContainerOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetListByDynamic;

public class GetListByDynamicStockContainerQuery : IRequest<GetListResponse<GetListByDynamicStockContainerListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicStockContainerQueryHandler : IRequestHandler<GetListByDynamicStockContainerQuery, GetListResponse<GetListByDynamicStockContainerListItemDto>>
    {
        private readonly IStockContainerRepository _stockContainerRepository;
        private readonly StockContainerBusinessRules _stockContainerBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockContainerQueryHandler(IStockContainerRepository stockContainerRepository, IMapper mapper, StockContainerBusinessRules stockContainerBusinessRules)
        {
            _stockContainerRepository = stockContainerRepository;
            _stockContainerBusinessRules = stockContainerBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockContainerListItemDto>> Handle(GetListByDynamicStockContainerQuery request, CancellationToken cancellationToken)
        {
            _stockContainerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<StockContainer> stockContainerList = await _stockContainerRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicStockContainerListItemDto>>(stockContainerList);
        }
    }
}
