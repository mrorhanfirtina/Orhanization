using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants.PurchaseOrderOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetListByDynamic;

public class GetListByDynamicPurchaseOrderQuery : IRequest<GetListResponse<GetListByDynamicPurchaseOrderListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicPurchaseOrderQueryHandler : IRequestHandler<GetListByDynamicPurchaseOrderQuery, GetListResponse<GetListByDynamicPurchaseOrderListItemDto>>
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        private readonly PurchaseOrderBusinessRules _purchaseOrderBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicPurchaseOrderQueryHandler(IPurchaseOrderRepository purchaseOrderRepository, IMapper mapper, PurchaseOrderBusinessRules purchaseOrderBusinessRules)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
            _purchaseOrderBusinessRules = purchaseOrderBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicPurchaseOrderListItemDto>> Handle(GetListByDynamicPurchaseOrderQuery request, CancellationToken cancellationToken)
        {
            _purchaseOrderBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<PurchaseOrder> purchaseOrderList = await _purchaseOrderRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Supplier).Include(x => x.PoAttributeValues).Include(x => x.PoMemos).Include(x => x.Receipts),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicPurchaseOrderListItemDto>>(purchaseOrderList);
        }
    }

}
