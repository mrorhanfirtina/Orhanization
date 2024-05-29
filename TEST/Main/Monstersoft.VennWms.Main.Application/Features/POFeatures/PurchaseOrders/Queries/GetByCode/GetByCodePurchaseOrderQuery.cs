using AutoMapper;
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
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants.PurchaseOrderOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetByCode;

public class GetByCodePurchaseOrderQuery : IRequest<GetByCodePurchaseOrderResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }
    public PurchaseOrderDetailLevel DetailLevel { get; set; }


    public class GetByCodePurchaseOrderQueryHandler : IRequestHandler<GetByCodePurchaseOrderQuery, GetByCodePurchaseOrderResponse>
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        private readonly PurchaseOrderBusinessRules _purchaseOrderBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodePurchaseOrderQueryHandler(IPurchaseOrderRepository purchaseOrderRepository, IMapper mapper, PurchaseOrderBusinessRules purchaseOrderBusinessRules)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
            _mapper = mapper;
            _purchaseOrderBusinessRules = purchaseOrderBusinessRules;
        }

        public async Task<GetByCodePurchaseOrderResponse> Handle(GetByCodePurchaseOrderQuery request, CancellationToken cancellationToken)
        {
            _purchaseOrderBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodePurchaseOrderResponse>(await _purchaseOrderRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByCodePurchaseOrderResponse>(await _purchaseOrderRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
