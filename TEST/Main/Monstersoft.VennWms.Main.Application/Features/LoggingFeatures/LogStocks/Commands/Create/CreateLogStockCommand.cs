using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
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


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Create;

public class CreateLogStockCommand : IRequest<CreatedLogStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTransactionLogs";

    public CreateLogStockDto LogStock { get; set; }
    public LogStockDetailLevel DetailLevel { get; set; }


    public class CreateLogStockCommandHandler : IRequestHandler<CreateLogStockCommand, CreatedLogStockResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILogStockRepository _logStockRepository;
        private readonly LogStockBusinessRules _logStockBusinessRules;

        public CreateLogStockCommandHandler(IMapper mapper, ILogStockRepository logStockRepository, LogStockBusinessRules logStockBusinessRules)
        {
            _mapper = mapper;
            _logStockRepository = logStockRepository;
            _logStockBusinessRules = logStockBusinessRules;
        }

        public async Task<CreatedLogStockResponse> Handle(CreateLogStockCommand request, CancellationToken cancellationToken)
        {
            _logStockBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            LogStock? logStock = _mapper.Map<LogStock>(request.LogStock);

            logStock.CreatedDate = DateTime.Now;
            logStock.Id = Guid.NewGuid();

            logStock.LogStockAttributeValues?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            logStock.LogStockContainers?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            logStock.LogStockReserveReasons?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            logStock.LogStockUnsuitReasons?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });

            await _logStockRepository.AddAsync(logStock);

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

                return _mapper.Map<CreatedLogStockResponse>(response);
            }
            else
            {
                var response = await _logStockRepository.GetAsync(predicate: x => x.Id == logStock.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLogStockResponse>(response);
            }  
        }
    }
}

