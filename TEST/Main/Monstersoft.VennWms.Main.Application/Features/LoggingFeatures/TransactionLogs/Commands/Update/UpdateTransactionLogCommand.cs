using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Update;

public class UpdateTransactionLogCommand : IRequest<UpdatedTransactionLogResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, TransactionLogOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetTransactionLogs"];

    public UpdateTransactionLogDto TransactionLog { get; set; }
    public TransactionLogsDetailLevel DetailLevel { get; set; }


    public class UpdateTransactionLogCommandHandler : IRequestHandler<UpdateTransactionLogCommand, UpdatedTransactionLogResponse>
    {
        private readonly ITransactionLogRepository _transactionLogRepository;
        private readonly IMapper _mapper;
        private readonly TransactionLogBusinessRules _transactionLogBusinessRules;

        public UpdateTransactionLogCommandHandler(ITransactionLogRepository transactionLogRepository, IMapper mapper, TransactionLogBusinessRules transactionLogBusinessRules)
        {
            _transactionLogRepository = transactionLogRepository;
            _mapper = mapper;
            _transactionLogBusinessRules = transactionLogBusinessRules;
        }

        public async Task<UpdatedTransactionLogResponse> Handle(UpdateTransactionLogCommand request, CancellationToken cancellationToken)
        {
            _transactionLogBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.TransactionLog.Id);

            TransactionLog? currentTransactionLog = await _transactionLogRepository.GetAsync(predicate: x => x.Id == request.TransactionLog.Id,
              include: x => x.Include(y => y.LogStocks)
                              .Include(y => y.LogStocks).ThenInclude(z => z.LogStockAttributeValues)
                              .Include(y => y.LogStocks).ThenInclude(z => z.LogStockContainers)
                              .Include(y => y.LogStocks).ThenInclude(z => z.LogStockReserveReasons)
                              .Include(y => y.LogStocks).ThenInclude(z => z.LogStockUnsuitReasons),
              withDeleted: false,
              enableTracking: true,
              cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            TransactionLog? transactionLog = _mapper.Map(request.TransactionLog, currentTransactionLog);
            transactionLog.UpdatedDate = DateTime.Now;

            transactionLog.LogStocks?.ToList().ForEach(x =>
            {
                x.CreatedDate = transactionLog.CreatedDate;
                x.UpdatedDate = DateTime.Now;
                x.LogStockAttributeValues?.ToList().ForEach(y => { y.CreatedDate = transactionLog.CreatedDate; y.UpdatedDate = DateTime.Now; });
                x.LogStockContainers?.ToList().ForEach(y => { y.CreatedDate = transactionLog.CreatedDate; y.UpdatedDate = DateTime.Now; });
                x.LogStockReserveReasons?.ToList().ForEach(y => { y.CreatedDate = transactionLog.CreatedDate; y.UpdatedDate = DateTime.Now; });
                x.LogStockUnsuitReasons?.ToList().ForEach(y => { y.CreatedDate = transactionLog.CreatedDate; y.UpdatedDate = DateTime.Now; });
            });

            await _transactionLogRepository.UpdateAsync(transactionLog);


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

                return _mapper.Map<UpdatedTransactionLogResponse>(response);
            }
            else
            {
                var response = await _transactionLogRepository.GetAsync(predicate: x => x.Id == transactionLog.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedTransactionLogResponse>(response);
            }
        }
    }   
}
