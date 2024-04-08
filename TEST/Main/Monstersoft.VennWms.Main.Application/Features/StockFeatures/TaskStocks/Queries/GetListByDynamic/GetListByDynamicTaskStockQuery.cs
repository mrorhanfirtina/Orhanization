using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants.TaskStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Queries.GetListByDynamic;

public class GetListByDynamicTaskStockQuery : IRequest<GetListResponse<GetListByDynamicTaskStockListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicTaskStockQueryHandler : IRequestHandler<GetListByDynamicTaskStockQuery, GetListResponse<GetListByDynamicTaskStockListItemDto>>
    {
        private readonly ITaskStockRepository _taskStockRepository;
        private readonly TaskStockBusinessRules _taskStockBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicTaskStockQueryHandler(ITaskStockRepository taskStockRepository, IMapper mapper, TaskStockBusinessRules taskStockBusinessRules)
        {
            _taskStockRepository = taskStockRepository;
            _taskStockBusinessRules = taskStockBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicTaskStockListItemDto>> Handle(GetListByDynamicTaskStockQuery request, CancellationToken cancellationToken)
        {
            _taskStockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<TaskStock> taskStockList = await _taskStockRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicTaskStockListItemDto>>(taskStockList);
        }
    }
}
