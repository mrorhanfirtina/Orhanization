using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants.TransactionLogOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetList;

public class GetListTransactionLogQuery : IRequest<GetListResponse<GetListTransactionLogListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListTransactionLogQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetTransactionLogs";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListTransactionLogQueryHandler : IRequestHandler<GetListTransactionLogQuery, GetListResponse<GetListTransactionLogListItemDto>>
    {
        private readonly ITransactionLogRepository _transactionLogRepository;
        private readonly TransactionLogBusinessRules _transactionLogBusinessRules;
        private readonly IMapper _mapper;

        public GetListTransactionLogQueryHandler(ITransactionLogRepository transactionLogRepository, IMapper mapper, TransactionLogBusinessRules transactionLogBusinessRules)
        {
            _transactionLogRepository = transactionLogRepository;
            _mapper = mapper;
            _transactionLogBusinessRules = transactionLogBusinessRules;
        }

        public async Task<GetListResponse<GetListTransactionLogListItemDto>> Handle(GetListTransactionLogQuery request, CancellationToken cancellationToken)
        {
            _transactionLogBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<TransactionLog> transactionLogList = await _transactionLogRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x => x.Include(y => y.DepositorCompany)
                               .Include(y => y.Depositor)
                               .Include(y => y.User)
                               .Include(y => y.LogStocks)
                               .Include(y => y.LogStocks).ThenInclude(m => m.Product)
                               .Include(y => y.LogStocks).ThenInclude(m => m.FromLocation)
                               .Include(y => y.LogStocks).ThenInclude(m => m.ToLocation)
                               .Include(y => y.LogStocks).ThenInclude(m => m.TransactionType)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockReserveReasons)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockReserveReasons).ThenInclude(y => y.FromReason)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockReserveReasons).ThenInclude(y => y.ToReason)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockUnsuitReasons)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockUnsuitReasons).ThenInclude(y => y.FromReason)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockUnsuitReasons).ThenInclude(y => y.ToReason)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockAttributeValues)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockAttributeValues).ThenInclude(y => y.StockAttribute)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockContainers)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockContainers).ThenInclude(y => y.FromContainerUnit)
                               .Include(y => y.LogStocks).ThenInclude(m => m.LogStockContainers).ThenInclude(y => y.ToContainerUnit),
                orderBy: x => x.OrderByDescending(m => m.CreatedDate),
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListTransactionLogListItemDto>>(transactionLogList);

        }
    }
}
