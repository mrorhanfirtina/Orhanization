using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants.StockContainerOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetListByDynamic;

public class GetListByDynamicStockContainerQuery : IRequest<GetListResponse<GetListByDynamicStockContainerListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public StockContainersDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicStockContainerQueryHandler : IRequestHandler<GetListByDynamicStockContainerQuery, GetListResponse<GetListByDynamicStockContainerListItemDto>>
    {
        private readonly IStockContainerRepository _stockContainerRepository;
        private readonly StockContainerBusinessRules _stockContainerBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockContainerQueryHandler(IStockContainerRepository stockContainerRepository, IMapper mapper, StockContainerBusinessRules stockContainerBusinessRules)
        {
            _stockContainerRepository = stockContainerRepository;
            _stockContainerBusinessRules = stockContainerBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockContainerListItemDto>> Handle(GetListByDynamicStockContainerQuery request, CancellationToken cancellationToken)
        {
            _stockContainerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<StockContainer> stockContainerList = await _stockContainerRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<StockContainer> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeContainerUnit)
                    {
                        query = query.Include(y => y.ContainerUnit);
                    }

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stocks);

                        var stockDetailLevel = detailLevel.StockDetailLevel;

                        if (stockDetailLevel.IncludeStockAttributeValue)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.StockAttributeValues);

                            var stockAttributeValueDetailLevel = stockDetailLevel.StockAttributeValueDetailLevel;

                            if (stockAttributeValueDetailLevel.IncludeStockAttribute)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.StockAttributeValues).ThenInclude(y => y.StockAttribute);

                                var stockAttributeDetailLevel = stockAttributeValueDetailLevel.StockAttributeDetailLevel;

                                if (stockAttributeDetailLevel.IncludeAttributeInputType)
                                {
                                    query = query.Include(y => y.Stocks).ThenInclude(m => m.StockAttributeValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                                }
                            }
                        }

                        if (stockDetailLevel.IncludeStockMemo)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.StockMemos);
                        }

                        if (stockDetailLevel.IncludeStockReserveReason)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.StockReserveReasons);

                            var stockReserveReasonDetailLevel = stockDetailLevel.StockReserveReasonDetailLevel;

                            if (stockReserveReasonDetailLevel.IncludeReserveReason)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.StockReserveReasons).ThenInclude(y => y.ReserveReason);
                            }
                        }

                        if (stockDetailLevel.IncludeStockUnsuitReason)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.StockUnsuitReasons);

                            var stockUnsuitReasonDetailLevel = stockDetailLevel.StockUnsuitReasonDetailLevel;

                            if (stockUnsuitReasonDetailLevel.IncludeUnsuitReason)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.StockUnsuitReasons).ThenInclude(y => y.UnsuitReason);
                            }
                        }

                        if (stockDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.Product);
                        }

                        if (stockDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.Depositor);

                            if (stockDetailLevel.DepositorDetailLevel.IncludeCompany)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.Depositor).ThenInclude(y => y.Company);
                            }
                        }

                        if (stockDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.DepositorCompany);
                        }

                        if (stockDetailLevel.IncludeLocation)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.Location);
                        }

                        if (stockDetailLevel.IncludeCuItemUnit)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.CuItemUnit);

                            var cuItemUnitDetailLevel = stockDetailLevel.CuItemUnitDetailLevel;

                            if (cuItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.CuItemUnit).ThenInclude(y => y.Unit);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<StockContainer, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockContainerListItemDto>>(stockContainerList);
            }
            else
            {
                Paginate<StockContainer> stockContainerList = await _stockContainerRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockContainerListItemDto>>(stockContainerList);
            }
        }
    }
}
