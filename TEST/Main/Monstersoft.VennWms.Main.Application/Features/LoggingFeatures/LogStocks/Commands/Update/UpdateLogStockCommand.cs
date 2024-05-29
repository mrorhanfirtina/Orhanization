using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants.LogStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Update;

public class UpdateLogStockCommand : IRequest<UpdatedLogStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, LogStockOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTransactionLogs";

    public UpdateLogStockDto LogStock { get; set; }
    public LogStockDetailLevel DetailLevel { get; set; }


    public class UpdateLogStockCommandHandler : IRequestHandler<UpdateLogStockCommand, UpdatedLogStockResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILogStockRepository _logStockRepository;
        private readonly LogStockBusinessRules _logStockBusinessRules;

        public UpdateLogStockCommandHandler(IMapper mapper, ILogStockRepository logStockRepository, LogStockBusinessRules logStockBusinessRules)
        {
            _mapper = mapper;
            _logStockRepository = logStockRepository;
            _logStockBusinessRules = logStockBusinessRules;
        }

        public async Task<UpdatedLogStockResponse> Handle(UpdateLogStockCommand request, CancellationToken cancellationToken)
        {
            _logStockBusinessRules.UpdateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            LogStock? currentLogStock = await _logStockRepository.GetAsync(predicate: x => x.Id == request.LogStock.Id,
              include: x => x.Include(z => z.LogStockAttributeValues)
                              .Include(z => z.LogStockContainers)
                              .Include(z => z.LogStockReserveReasons)
                              .Include(z => z.LogStockUnsuitReasons),
              withDeleted: false,
              enableTracking: true,
              cancellationToken: cancellationToken);

            LogStock? logStock = _mapper.Map(request.LogStock, currentLogStock);
            logStock.UpdatedDate = DateTime.Now;

            logStock.LogStockAttributeValues?.ToList().ForEach(x => { x.CreatedDate = logStock.CreatedDate; x.UpdatedDate = DateTime.Now; });
            logStock.LogStockContainers?.ToList().ForEach(x => { x.CreatedDate = logStock.CreatedDate; x.UpdatedDate = DateTime.Now; });
            logStock.LogStockReserveReasons?.ToList().ForEach(x => { x.CreatedDate = logStock.CreatedDate; x.UpdatedDate = DateTime.Now; });
            logStock.LogStockUnsuitReasons?.ToList().ForEach(x => { x.CreatedDate = logStock.CreatedDate; x.UpdatedDate = DateTime.Now; });

            await _logStockRepository.UpdateAsync(logStock);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _logStockRepository.GetAsync(predicate: x => x.Id == logStock.Id,
                include: x =>
                {
                    IQueryable<LogStock> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeTransactionLog)
                    {
                        query = query.Include(y => y.TransactionLog);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    if (detailLevel.IncludeFromLocation)
                    {
                        query = query.Include(y => y.FromLocation);
                    }

                    if (detailLevel.IncludeToLocation)
                    {
                        query = query.Include(y => y.ToLocation);
                    }

                    if (detailLevel.IncludeTransactionType)
                    {
                        query = query.Include(y => y.TransactionType);
                    }

                    if (detailLevel.IncludeLogStockReserveReason)
                    {
                        query = query.Include(y => y.LogStockReserveReasons);
                    }

                    if (detailLevel.IncludeLogStockAttributeValue)
                    {
                        query = query.Include(y => y.LogStockAttributeValues);

                        if (detailLevel.LogStockAttributeDetailLevel.IncludeStockAttribute)
                        {
                            query = query.Include(y => y.LogStockAttributeValues).ThenInclude(y => y.StockAttribute);
                        }
                    }

                    if (detailLevel.IncludeLogStockContainer)
                    {
                        query = query.Include(y => y.LogStockContainers);

                        if (detailLevel.LogStockContainerDetailLevel.IncludeFromContainerUnit)
                        {
                            query = query.Include(y => y.LogStockContainers).ThenInclude(y => y.FromContainerUnit);
                        }

                        if (detailLevel.LogStockContainerDetailLevel.IncludeToContainerUnit)
                        {
                            query = query.Include(y => y.LogStockContainers).ThenInclude(y => y.ToContainerUnit);
                        }
                    }

                    if (detailLevel.IncludeLogLogStockUnsuitReason)
                    {
                        query = query.Include(y => y.LogStockUnsuitReasons);

                        if (detailLevel.LogStockUnsuitReasonDetailLevel.IncludeFromReason)
                        {
                            query = query.Include(y => y.LogStockUnsuitReasons).ThenInclude(y => y.FromReason);
                        }

                        if (detailLevel.LogStockUnsuitReasonDetailLevel.IncludeToReason)
                        {
                            query = query.Include(y => y.LogStockUnsuitReasons).ThenInclude(y => y.ToReason);
                        }
                    }

                    if (detailLevel.IncludeLogLogStockReserveReason)
                    {
                        query = query.Include(y => y.LogStockReserveReasons);

                        if (detailLevel.LogStockReserveReasonDetailLevel.IncludeFromReason)
                        {
                            query = query.Include(y => y.LogStockReserveReasons).ThenInclude(y => y.FromReason);
                        }

                        if (detailLevel.LogStockReserveReasonDetailLevel.IncludeToReason)
                        {
                            query = query.Include(y => y.LogStockReserveReasons).ThenInclude(y => y.ToReason);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<LogStock, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLogStockResponse>(response);
            }
            else
            {
                var response = await _logStockRepository.GetAsync(predicate: x => x.Id == logStock.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLogStockResponse>(response);
            }
        }
    }
}

