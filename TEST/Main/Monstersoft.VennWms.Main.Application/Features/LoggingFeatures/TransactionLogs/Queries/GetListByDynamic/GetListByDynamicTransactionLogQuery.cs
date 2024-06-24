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
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants.TransactionLogOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetListByDynamic;

public class GetListByDynamicTransactionLogQuery : IRequest<GetListResponse<GetListByDynamicTransactionLogListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public TransactionLogsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicTransactionLogQueryHandler : IRequestHandler<GetListByDynamicTransactionLogQuery, GetListResponse<GetListByDynamicTransactionLogListItemDto>>
    {
        private readonly ITransactionLogRepository _transactionLogRepository;
        private readonly TransactionLogBusinessRules _transactionLogBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicTransactionLogQueryHandler(ITransactionLogRepository transactionLogRepository, IMapper mapper, TransactionLogBusinessRules transactionLogBusinessRules)
        {
            _transactionLogRepository = transactionLogRepository;
            _transactionLogBusinessRules = transactionLogBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicTransactionLogListItemDto>> Handle(GetListByDynamicTransactionLogQuery request, CancellationToken cancellationToken)
        {
            _transactionLogBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<TransactionLog> transactionLogList = await _transactionLogRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
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

                return _mapper.Map<GetListResponse<GetListByDynamicTransactionLogListItemDto>>(transactionLogList);
            }
            else
            {
                Paginate<TransactionLog> transactionLogList = await _transactionLogRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicTransactionLogListItemDto>>(transactionLogList);
            }
        }
    }

}
