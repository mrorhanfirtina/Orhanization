using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants.PurchaseOrderOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Create;

public class CreatePurchaseOrderCommand : IRequest<CreatedPurchaseOrderResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPurchaseOrders";

    public CreatePurchaseOrderDto PurchaseOrder { get; set; }
    public PurchaseOrdersDetailLevel DetailLevel { get; set; }


    public class CreatePurchaseOrderCommandHandler : IRequestHandler<CreatePurchaseOrderCommand, CreatedPurchaseOrderResponse>
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        private readonly IMapper _mapper;
        private readonly PurchaseOrderBusinessRules _purchaseOrderBusinessRules;

        public CreatePurchaseOrderCommandHandler(IPurchaseOrderRepository purchaseOrderRepository, IMapper mapper, PurchaseOrderBusinessRules purchaseOrderBusinessRules)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
            _mapper = mapper;
            _purchaseOrderBusinessRules = purchaseOrderBusinessRules;
        }

        public async Task<CreatedPurchaseOrderResponse> Handle(CreatePurchaseOrderCommand request, CancellationToken cancellationToken)
        {
            _purchaseOrderBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            PurchaseOrder? purchaseOrder = _mapper.Map<PurchaseOrder>(request.PurchaseOrder);

            purchaseOrder.CreatedDate = DateTime.Now;
            purchaseOrder.Id = Guid.NewGuid();
            purchaseOrder.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            purchaseOrder.PoMemos?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            purchaseOrder.PoAttributeValues?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            purchaseOrder.Receipts?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;

                x.ReceiptAttributeValues?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });
                x.ReceiptMemos?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });

                x.ReceiptItems.ToList().ForEach(y =>
                {
                    y.CreatedDate = DateTime.Now;

                    y.ReceiptItemMemos?.ToList().ForEach(z => { z.CreatedDate = DateTime.Now; });
                    y.ReceiptItmStockAttrValues?.ToList().ForEach(z => { z.CreatedDate = DateTime.Now; });
                });
            });

            await _purchaseOrderRepository.AddAsync(purchaseOrder);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _purchaseOrderRepository.GetAsync(predicate: x => x.Id == purchaseOrder.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPurchaseOrderResponse>(response);
            }
            else
            {
                var response = await _purchaseOrderRepository.GetAsync(predicate: x => x.Id == purchaseOrder.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPurchaseOrderResponse>(response);
            }
        }
    }
}
