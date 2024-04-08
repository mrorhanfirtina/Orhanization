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


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetById;

public class GetByIdPurchaseOrderQuery : IRequest<GetByIdPurchaseOrderResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdPurchaseOrderQueryHandler : IRequestHandler<GetByIdPurchaseOrderQuery, GetByIdPurchaseOrderResponse>
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        private readonly PurchaseOrderBusinessRules _purchaseOrderBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdPurchaseOrderQueryHandler(IPurchaseOrderRepository purchaseOrderRepository, IMapper mapper, PurchaseOrderBusinessRules purchaseOrderBusinessRules)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
            _mapper = mapper;
            _purchaseOrderBusinessRules = purchaseOrderBusinessRules;
        }

        public async Task<GetByIdPurchaseOrderResponse> Handle(GetByIdPurchaseOrderQuery request, CancellationToken cancellationToken)
        {
            _purchaseOrderBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdPurchaseOrderResponse>(await _purchaseOrderRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.Supplier).Include(x => x.PoAttributeValues).Include(x => x.PoMemos).Include(x => x.Receipts),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
