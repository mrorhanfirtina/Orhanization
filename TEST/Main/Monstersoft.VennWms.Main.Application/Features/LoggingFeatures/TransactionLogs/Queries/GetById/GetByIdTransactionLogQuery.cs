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
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants.TransactionLogOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetById;

public class GetByIdTransactionLogQuery : IRequest<GetByIdTransactionLogResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public TransactionLogDetailLevel DetailLevel { get; set; }


    public class GetByIdTransactionLogQueryHandler : IRequestHandler<GetByIdTransactionLogQuery, GetByIdTransactionLogResponse>
    {
        private readonly ITransactionLogRepository _transactionLogRepository;
        private readonly TransactionLogBusinessRules _transactionLogBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdTransactionLogQueryHandler(ITransactionLogRepository transactionLogRepository, IMapper mapper, TransactionLogBusinessRules transactionLogBusinessRules)
        {
            _transactionLogRepository = transactionLogRepository;
            _mapper = mapper;
            _transactionLogBusinessRules = transactionLogBusinessRules;
        }

        public async Task<GetByIdTransactionLogResponse> Handle(GetByIdTransactionLogQuery request, CancellationToken cancellationToken)
        {
            _transactionLogBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdTransactionLogResponse>(await _transactionLogRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdTransactionLogResponse>(await _transactionLogRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
