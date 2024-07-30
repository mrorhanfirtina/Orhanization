using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
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

            Paginate<PurchaseOrder> purchaseOrderList = await _purchaseOrderRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: m => m.Include(x => x.PoType)
                               .Include(x => x.Status)
                               .Include(x => x.Depositor)
                               .Include(x => x.Depositor).ThenInclude(m => m.Company)
                               .Include(x => x.DepositorCompany)
                               .Include(x => x.Supplier)
                               .Include(x => x.Supplier).ThenInclude(m => m.Address)
                               .Include(x => x.Supplier).ThenInclude(m => m.Company)
                               .Include(x => x.PoAttributeValues)
                               .Include(x => x.PoAttributeValues).ThenInclude(m => m.PoAttribute)
                               .Include(x => x.PoAttributeValues).ThenInclude(m => m.PoAttribute).ThenInclude(d => d.AttributeInputType)
                               .Include(x => x.PoMemos),
                orderBy: x => x.OrderByDescending(m => m.CreatedDate),
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListPurchaseOrderListItemDto>>(purchaseOrderList);
        }
    }

}
