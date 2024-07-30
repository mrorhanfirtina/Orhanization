using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.CreateDtos;
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
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants.TransactionLogOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Create;

public class CreateTransactionLogCommand : IRequest<CreatedTransactionLogResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetTransactionLogs"];

    public CreateTransactionLogDto TransactionLog { get; set; }
    public TransactionLogsDetailLevel DetailLevel { get; set; }


    public class CreateTransactionLogCommandHandler : IRequestHandler<CreateTransactionLogCommand, CreatedTransactionLogResponse>
    {
        private readonly ITransactionLogRepository _transactionLogRepository;
        private readonly IMapper _mapper;
        private readonly TransactionLogBusinessRules _transactionLogBusinessRules;

        public CreateTransactionLogCommandHandler(ITransactionLogRepository transactionLogRepository, IMapper mapper, TransactionLogBusinessRules transactionLogBusinessRules)
        {
            _transactionLogRepository = transactionLogRepository;
            _mapper = mapper;
            _transactionLogBusinessRules = transactionLogBusinessRules;
        }

        public async Task<CreatedTransactionLogResponse> Handle(CreateTransactionLogCommand request, CancellationToken cancellationToken)
        {
            _transactionLogBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            TransactionLog? transactionLog = _mapper.Map<TransactionLog>(request.TransactionLog);

            transactionLog.CreatedDate = DateTime.Now;
            transactionLog.LogDateTime = DateTime.Now;
            transactionLog.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);
            transactionLog.Id = Guid.NewGuid();

            transactionLog.LogStocks.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;

                x.LogStockAttributeValues?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now;});
                x.LogStockContainers?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now;});
                x.LogStockReserveReasons?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now;});
                x.LogStockUnsuitReasons?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now;});
            });

            await _transactionLogRepository.AddAsync(transactionLog);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _transactionLogRepository.GetAsync(predicate: x => x.Id == transactionLog.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedTransactionLogResponse>(response);
            }
            else
            {
                var response = await _transactionLogRepository.GetAsync(predicate: x => x.Id == transactionLog.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedTransactionLogResponse>(response);
            }
        }
    }
}
