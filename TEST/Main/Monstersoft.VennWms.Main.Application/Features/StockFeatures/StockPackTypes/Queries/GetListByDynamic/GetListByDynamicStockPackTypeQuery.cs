using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants.StockPackTypeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Queries.GetListByDynamic;

public class GetListByDynamicStockPackTypeQuery : IRequest<GetListResponse<GetListByDynamicStockPackTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public StockPackTypesDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicStockPackTypeQueryHandler : IRequestHandler<GetListByDynamicStockPackTypeQuery, GetListResponse<GetListByDynamicStockPackTypeListItemDto>>
    {
        private readonly IStockPackTypeRepository _stockPackTypeRepository;
        private readonly StockPackTypeBusinessRules _stockPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockPackTypeQueryHandler(IStockPackTypeRepository stockPackTypeRepository, IMapper mapper, StockPackTypeBusinessRules stockPackTypeBusinessRules)
        {
            _stockPackTypeRepository = stockPackTypeRepository;
            _stockPackTypeBusinessRules = stockPackTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockPackTypeListItemDto>> Handle(GetListByDynamicStockPackTypeQuery request, CancellationToken cancellationToken)
        {
            _stockPackTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<StockPackType> stockPackTypeList = await _stockPackTypeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<StockPackType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);

                        var itemUnitDetailLevel = detailLevel.ItemUnitDetailLevel;

                        if (itemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Unit);
                        }
                    }

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);

                        var stockDetailLevel = detailLevel.StockDetailLevel;

                        if (stockDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.Product);
                        }

                        if (stockDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.DepositorCompany);
                        }

                        if (stockDetailLevel.IncludeLocation)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.Location);
                        }

                        if (stockDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.Depositor);

                            var depositorDetailLevel = stockDetailLevel.DepositorDetailLevel;

                            if (depositorDetailLevel.IncludeCompany)
                            {
                                query = query.Include(y => y.Stock).ThenInclude(m => m.Depositor).ThenInclude(m => m.Company);
                            }
                        }

                        if (stockDetailLevel.IncludeCuItemUnit)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.CuItemUnit);

                            var cuItemUnitDetailLevel = stockDetailLevel.ItemUnitDetailLevel;

                            if (cuItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.Stock).ThenInclude(m => m.CuItemUnit).ThenInclude(m => m.Unit);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<StockPackType, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockPackTypeListItemDto>>(stockPackTypeList);
            }
            else
            {
                Paginate<StockPackType> stockPackTypeList = await _stockPackTypeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockPackTypeListItemDto>>(stockPackTypeList);
            }
        }
    }

}

