using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants.StockInboundOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Queries.GetListByDynamic;

public class GetListByDynamicStockInboundQuery : IRequest<GetListResponse<GetListByDynamicStockInboundListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public StockInboundsDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicStockInboundQueryHandler : IRequestHandler<GetListByDynamicStockInboundQuery, GetListResponse<GetListByDynamicStockInboundListItemDto>>
    {
        private readonly IStockInboundRepository _stockInboundRepository;
        private readonly StockInboundBusinessRules _stockInboundBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockInboundQueryHandler(IStockInboundRepository stockInboundRepository, IMapper mapper, StockInboundBusinessRules stockInboundBusinessRules)
        {
            _stockInboundRepository = stockInboundRepository;
            _stockInboundBusinessRules = stockInboundBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockInboundListItemDto>> Handle(GetListByDynamicStockInboundQuery request, CancellationToken cancellationToken)
        {
            _stockInboundBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<StockInbound> stockInboundList = await _stockInboundRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<StockInbound> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(y => y.Receipt);
                    }

                    if (detailLevel.IncludeReturn)
                    {
                        query = query.Include(y => y.Return);
                    }

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.CuItemUnit);

                        var itemUnitDetailLevel = detailLevel.ItemUnitDetailLevel;

                        if (itemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.CuItemUnit).ThenInclude(m => m.Unit);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<StockInbound, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockInboundListItemDto>>(stockInboundList);
            }
            else
            {
                Paginate<StockInbound> stockInboundList = await _stockInboundRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockInboundListItemDto>>(stockInboundList);
            }
        }
    }
}
