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
    public TransactionLogsDetailLevel DetailLevel { get; set; }


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

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<TransactionLog> transactionLogList = await _transactionLogRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<TransactionLog> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);
                    }

                    if (detailLevel.IncludeUser)
                    {
                        query = query.Include(y => y.User);
                    }

                    if (detailLevel.IncludeLogStock)
                    {
                        query = query.Include(y => y.LogStocks);

                        if (detailLevel.LogStockDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.LogStocks).ThenInclude(y => y.Product);
                        }

                        if (detailLevel.LogStockDetailLevel.IncludeFromLocation)
                        {
                            query = query.Include(y => y.LogStocks).ThenInclude(y => y.FromLocation);
                        }

                        if (detailLevel.LogStockDetailLevel.IncludeToLocation)
                        {
                            query = query.Include(y => y.LogStocks).ThenInclude(y => y.ToLocation);
                        }

                        if (detailLevel.LogStockDetailLevel.IncludeTransactionType)
                        {
                            query = query.Include(y => y.LogStocks).ThenInclude(y => y.TransactionType);
                        }

                        if (detailLevel.LogStockDetailLevel.IncludeLogStockReserveReason)
                        {
                            query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockReserveReasons);

                            if (detailLevel.LogStockDetailLevel.LogStockReserveReasonDetailLevel.IncludeFromReason)
                            {
                                query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockReserveReasons).ThenInclude(y => y.FromReason);
                            }

                            if (detailLevel.LogStockDetailLevel.LogStockReserveReasonDetailLevel.IncludeToReason)
                            {
                                query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockReserveReasons).ThenInclude(y => y.ToReason);
                            }
                        }

                        if (detailLevel.LogStockDetailLevel.IncludeLogStockAttributeValue)
                        {
                            query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockAttributeValues);

                            if (detailLevel.LogStockDetailLevel.LogStockAttributeDetailLevel.IncludeStockAttribute)
                            {
                                query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockAttributeValues).ThenInclude(y => y.StockAttribute);
                            }
                        }

                        if (detailLevel.LogStockDetailLevel.IncludeLogStockContainer)
                        {
                            query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockContainers);

                            if (detailLevel.LogStockDetailLevel.LogStockContainerDetailLevel.IncludeFromContainerUnit)
                            {
                                query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockContainers).ThenInclude(y => y.FromContainerUnit);
                            }

                            if (detailLevel.LogStockDetailLevel.LogStockContainerDetailLevel.IncludeToContainerUnit)
                            {
                                query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockContainers).ThenInclude(y => y.ToContainerUnit);
                            }
                        }

                        if (detailLevel.LogStockDetailLevel.IncludeLogStockUnsuitReason)
                        {
                            query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockUnsuitReasons);

                            if (detailLevel.LogStockDetailLevel.LogStockUnsuitReasonDetailLevel.IncludeFromReason)
                            {
                                query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockUnsuitReasons).ThenInclude(y => y.FromReason);
                            }

                            if (detailLevel.LogStockDetailLevel.LogStockUnsuitReasonDetailLevel.IncludeToReason)
                            {
                                query = query.Include(y => y.LogStocks).ThenInclude(y => y.LogStockUnsuitReasons).ThenInclude(y => y.ToReason);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<TransactionLog, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListTransactionLogListItemDto>>(transactionLogList);
            }
            else
            {
                Paginate<TransactionLog> transactionLogList = await _transactionLogRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListTransactionLogListItemDto>>(transactionLogList);
            }
        }
    }
}
