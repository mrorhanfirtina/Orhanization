﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants.PurchaseOrderOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetList;

public class GetListPurchaseOrderQuery : IRequest<GetListResponse<GetListPurchaseOrderListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListPurchaseOrderQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetPurchaseOrders";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public PurchaseOrdersDetailLevel DetailLevel { get; set; }


    public class GetListPurchaseOrderQueryHandler : IRequestHandler<GetListPurchaseOrderQuery, GetListResponse<GetListPurchaseOrderListItemDto>>
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        private readonly PurchaseOrderBusinessRules _purchaseOrderBusinessRules;
        private readonly IMapper _mapper;

        public GetListPurchaseOrderQueryHandler(IPurchaseOrderRepository purchaseOrderRepository, IMapper mapper, PurchaseOrderBusinessRules purchaseOrderBusinessRules)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
            _mapper = mapper;
            _purchaseOrderBusinessRules = purchaseOrderBusinessRules;
        }

        public async Task<GetListResponse<GetListPurchaseOrderListItemDto>> Handle(GetListPurchaseOrderQuery request, CancellationToken cancellationToken)
        {
            _purchaseOrderBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<PurchaseOrder> purchaseOrderList = await _purchaseOrderRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                include: x =>
                {
                    IQueryable<PurchaseOrder> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeStatus)
                    {
                        query = query.Include(y => y.Status);
                    }

                    if (detailLevel.IncludePoType)
                    {
                        query = query.Include(y => y.PoType);
                    }

                    if (detailLevel.IncludePoMemo)
                    {
                        query = query.Include(y => y.PoMemos);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        if (detailLevel.DepositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(m => m.Company);
                        }
                    }

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(y => y.Receipts);

                        if (detailLevel.ReceiptDetailLevel.IncludeStatus)
                        {
                            query = query.Include(y => y.Receipts).ThenInclude(m => m.Status);
                        }
                    }

                    if (detailLevel.IncludeSupplier)
                    {
                        query = query.Include(y => y.Supplier);

                        if (detailLevel.SupplierDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Supplier).ThenInclude(m => m.Company);
                        }

                        if (detailLevel.SupplierDetailLevel.IncludeAddress)
                        {
                            query = query.Include(y => y.Supplier).ThenInclude(m => m.Address);
                        }
                    }

                    if (detailLevel.IncludePoAttributeValue)
                    {
                        query = query.Include(y => y.PoAttributeValues);

                        if (detailLevel.PoAttributeValueDetailLevel.IncludePoAttribute)
                        {
                            query = query.Include(y => y.PoAttributeValues).ThenInclude(m => m.PoAttribute);

                            if (detailLevel.PoAttributeValueDetailLevel.PoAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.PoAttributeValues).ThenInclude(m => m.PoAttribute).ThenInclude(n => n.AttributeInputType);
                            }
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<PurchaseOrder, object>;
                    return includableQuery;
                },
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListPurchaseOrderListItemDto>>(purchaseOrderList);
            }
            else
            {
                Paginate<PurchaseOrder> purchaseOrderList = await _purchaseOrderRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListPurchaseOrderListItemDto>>(purchaseOrderList);
            }
        }
    }

}
