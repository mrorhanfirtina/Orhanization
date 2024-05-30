using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants.ReturnItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Queries.GetListByDynamic;

public class GetListByDynamicReturnItmStockAttrValueQuery : IRequest<GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ReturnItmStockAttrValuesDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicReturnItmStockAttrValueQueryHandler : IRequestHandler<GetListByDynamicReturnItmStockAttrValueQuery, GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>>
    {
        private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
        private readonly ReturnItmStockAttrValueBusinessRules _returnItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReturnItmStockAttrValueQueryHandler(IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, IMapper mapper, ReturnItmStockAttrValueBusinessRules returnItmStockAttrValueBusinessRules)
        {
            _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
            _returnItmStockAttrValueBusinessRules = returnItmStockAttrValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>> Handle(GetListByDynamicReturnItmStockAttrValueQuery request, CancellationToken cancellationToken)
        {
            _returnItmStockAttrValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ReturnItmStockAttrValue> returnItmStockAttrValueList = await _returnItmStockAttrValueRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ReturnItmStockAttrValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturnItem)
                    {
                        query = query.Include(y => y.ReturnItem);

                        var returnItemDetailLevel = detailLevel.ReturnItemDetailLevel;

                        if (returnItemDetailLevel.IncludeReturn)
                        {
                            query = query.Include(y => y.ReturnItem).ThenInclude(y => y.Return);
                        }

                        if (returnItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReturnItem).ThenInclude(y => y.Product);
                        }
                    }

                    if (detailLevel.IncludeStockAttribute)
                    {
                        query = query.Include(y => y.StockAttribute);

                        var stockAttributeDetailLevel = detailLevel.StockAttributeDetailLevel;

                        if (stockAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnItmStockAttrValue, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>>(returnItmStockAttrValueList);
            }
            else
            {
                Paginate<ReturnItmStockAttrValue> returnItmStockAttrValueList = await _returnItmStockAttrValueRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>>(returnItmStockAttrValueList);
            }
        }
    }

}

