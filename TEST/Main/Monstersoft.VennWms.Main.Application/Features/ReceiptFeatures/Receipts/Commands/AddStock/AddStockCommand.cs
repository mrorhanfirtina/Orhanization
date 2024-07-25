using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants.ReceiptOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.AddStock;

public class AddStockCommand : IRequest<AddedStockResponse>, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public Guid ReceiptItemId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }


    public string[] Roles => [Admin, ReceiptOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }



    public class AddStockCommandHandler : IRequestHandler<AddStockCommand, AddedStockResponse>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly IReceiptItemRepository _receiptItemRepository;
        private readonly IStockRepository _stockRepository;
        private readonly IItemUnitRepository _itemUnitRepository;
        private readonly IProductRepository _productRepository;

        public AddStockCommandHandler(IReceiptRepository receiptRepository, IReceiptItemRepository receiptItemRepository, IStockRepository stockRepository, IItemUnitRepository itemUnitRepository, IProductRepository productRepository)
        {
            _receiptRepository = receiptRepository;
            _receiptItemRepository = receiptItemRepository;
            _stockRepository = stockRepository;
            _itemUnitRepository = itemUnitRepository;
            _productRepository = productRepository;
        }

        public async Task<AddedStockResponse> Handle(AddStockCommand request, CancellationToken cancellationToken)
        {
            return new AddedStockResponse();
            //Önce teslim alma kalemini al. Teslim almaya uygun ürün var mı bak. Eğer yoksa parametrelerden ForbidExcess parametresine göre işlem yap.
        }
    }
}
