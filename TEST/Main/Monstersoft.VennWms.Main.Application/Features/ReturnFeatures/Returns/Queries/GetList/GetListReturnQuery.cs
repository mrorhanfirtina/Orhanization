using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants.ReturnOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetList;

public class GetListReturnQuery : IRequest<GetListResponse<GetListReturnListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListReturnQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetReturns";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public ReturnsDetailLevel? DetailLevel { get; set; }


    public class GetListReturnQueryHandler : IRequestHandler<GetListReturnQuery, GetListResponse<GetListReturnListItemDto>>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly ReturnBusinessRules _returnBusinessRules;
        private readonly IMapper _mapper;

        public GetListReturnQueryHandler(IReturnRepository returnRepository, IMapper mapper, ReturnBusinessRules returnBusinessRules)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
            _returnBusinessRules = returnBusinessRules;
        }

        public async Task<GetListResponse<GetListReturnListItemDto>> Handle(GetListReturnQuery request, CancellationToken cancellationToken)
        {
            _returnBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Return> returnList = await _returnRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<Return> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturnMemo)
                    {
                        query = query.Include(y => y.ReturnMemos);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeStatus)
                    {
                        query = query.Include(y => y.Status);
                    }

                    if (detailLevel.IncludeCustomer)
                    {
                        query = query.Include(y => y.Customer);

                        var customerDetailLevel = detailLevel.CustomerDetailLevel;

                        if (customerDetailLevel.IncludeAddress)
                        {
                            query = query.Include(y => y.Customer.Address);
                        }

                        if (customerDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Customer.Company);
                        }
                    }

                    if (detailLevel.IncludeReturnType)
                    {
                        query = query.Include(y => y.ReturnType);
                    }

                    if (detailLevel.IncludeReturnAttributeValue)
                    {
                        query = query.Include(y => y.ReturnAttributeValues);

                        var returnAttributeValueDetailLevel = detailLevel.ReturnAttributeValueDetailLevel;

                        if (returnAttributeValueDetailLevel.IncludeReturnAttribute)
                        {
                            query = query.Include(y => y.ReturnAttributeValues).ThenInclude(y => y.ReturnAttribute);

                            var returnAttributeDetailLevel = returnAttributeValueDetailLevel.ReturnAttributeDetailLevel;

                            if (returnAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.ReturnAttributeValues).ThenInclude(y => y.ReturnAttribute).ThenInclude(y => y.AttributeInputType);
                            }
                        }
                    }

                    if (detailLevel.IncludeReturnItem)
                    {
                        query = query.Include(y => y.ReturnItems);

                        var returnItemDetailLevel = detailLevel.ReturnItemDetailLevel;

                        if (returnItemDetailLevel.IncludeReturnItemMemo)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ReturnItemMemos);
                        }

                        if (returnItemDetailLevel.IncludeStatus)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.Status);
                        }

                        if (returnItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.Product);
                        }

                        if (returnItemDetailLevel.IncludeReturnItmStockAttrValue)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ReturnItmStockAttrValues);

                            var returnItmStockAttrValueDetailLevel = returnItemDetailLevel.ReturnItmStockAttrValueDetailLevel;

                            if (returnItmStockAttrValueDetailLevel.IncludeStockAttribute)
                            {
                                query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ReturnItmStockAttrValues).ThenInclude(y => y.StockAttribute);

                                var stockAttributeDetailLevel = returnItmStockAttrValueDetailLevel.StockAttributeDetailLevel;

                                if (stockAttributeDetailLevel.IncludeAttributeInputType)
                                {
                                    query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ReturnItmStockAttrValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                                }
                            }
                        }

                        if (returnItemDetailLevel.IncludeItemUnit)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ItemUnit);

                            var itemUnitDetailLevel = returnItemDetailLevel.ItemUnitDetailLevel;

                            if (itemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ItemUnit).ThenInclude(y => y.Unit);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<Return, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListReturnListItemDto>>(returnList);
            }
            else
            {
                Paginate<Return> returnList = await _returnRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListReturnListItemDto>>(returnList);
            }
        }
    }

}
