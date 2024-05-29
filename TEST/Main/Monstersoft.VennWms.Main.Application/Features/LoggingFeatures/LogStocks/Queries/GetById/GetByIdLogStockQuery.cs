using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants.LogStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetById;

public class GetByIdLogStockQuery : IRequest<GetByIdLogStockResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public LogStockDetailLevel DetailLevel { get; set; }


    public class GetByIdLogStockQueryHandler : IRequestHandler<GetByIdLogStockQuery, GetByIdLogStockResponse>
    {
        private readonly ILogStockRepository _logStockRepository;
        private readonly LogStockBusinessRules _logStockBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLogStockQueryHandler(ILogStockRepository logStockRepository, IMapper mapper, LogStockBusinessRules logStockBusinessRules)
        {
            _logStockRepository = logStockRepository;
            _mapper = mapper;
            _logStockBusinessRules = logStockBusinessRules;
        }

        public async Task<GetByIdLogStockResponse> Handle(GetByIdLogStockQuery request, CancellationToken cancellationToken)
        {
            _logStockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdLogStockResponse>(await _logStockRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdLogStockResponse>(await _logStockRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

