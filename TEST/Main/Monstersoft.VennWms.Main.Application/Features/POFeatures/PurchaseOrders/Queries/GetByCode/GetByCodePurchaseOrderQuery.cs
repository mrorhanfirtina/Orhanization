using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
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

            return _mapper.Map<GetByCodePurchaseOrderResponse>(await _purchaseOrderRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Supplier).Include(x => x.PoAttributeValues).Include(x => x.PoMemos).Include(x => x.Receipts),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
