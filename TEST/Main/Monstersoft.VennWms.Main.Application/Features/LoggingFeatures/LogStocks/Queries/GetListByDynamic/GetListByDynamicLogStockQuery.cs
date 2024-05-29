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
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants.LogStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetListByDynamic;

public class GetListByDynamicLogStockQuery : IRequest<GetListResponse<GetListByDynamicLogStockListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public LogStockDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicLogStockQueryHandler : IRequestHandler<GetListByDynamicLogStockQuery, GetListResponse<GetListByDynamicLogStockListItemDto>>
    {
        private readonly ILogStockRepository _logStockRepository;
        private readonly LogStockBusinessRules _logStockBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLogStockQueryHandler(ILogStockRepository logStockRepository, IMapper mapper, LogStockBusinessRules logStockBusinessRules)
        {
            _logStockRepository = logStockRepository;
            _logStockBusinessRules = logStockBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLogStockListItemDto>> Handle(GetListByDynamicLogStockQuery request, CancellationToken cancellationToken)
        {
            _logStockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<LogStock> logStockList = await _logStockRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
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
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLogStockListItemDto>>(logStockList);
            }
            else
            {
                Paginate<LogStock> logStockList = await _logStockRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLogStockListItemDto>>(logStockList);
            }
        }
    }
}

