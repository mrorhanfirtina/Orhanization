using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Services.Abstract.ReceiptServices;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Services.Concrete.ReceiptServices;

public class ReceiptManager : IReceiptService
{
    private readonly IReceiptRepository _receiptRepository;
    private readonly IReceiptItemRepository _receiptItemRepository;
    private readonly IStockRepository _stockRepository;
    private readonly IItemUnitRepository _itemUnitRepository;
    private readonly IProductRepository _productRepository;
    private readonly ITransactionLogRepository _transactionLogRepository;
    private readonly IActionParameterRepository _actionParameterRepository;
    private readonly ReceiptBusinessRules _receiptBusinessRules;

    public ReceiptManager(IReceiptRepository receiptRepository, IReceiptItemRepository receiptItemRepository, IStockRepository stockRepository,
        IItemUnitRepository itemUnitRepository, IProductRepository productRepository, ITransactionLogRepository transactionLogRepository,
        ReceiptBusinessRules receiptBusinessRules)
    {
        _receiptRepository = receiptRepository;
        _receiptItemRepository = receiptItemRepository;
        _stockRepository = stockRepository;
        _itemUnitRepository = itemUnitRepository;
        _productRepository = productRepository;
        _transactionLogRepository = transactionLogRepository;
        _receiptBusinessRules = receiptBusinessRules;
    }

    public async Task<Stock> AddStock(Guid receiptItemId, decimal quantity, Guid productId, Guid itemUnitId, Guid locationId, Guid stockContainerId, 
        List<StockAttribute> stockAttributes, int userId, Guid depositorCompanyId, Guid? depositorId = null)
    {
        List<ActionParameter> parameters = _actionParameterRepository.GetActionParameters(userId, depositorCompanyId, depositorId);

        var filter = parameters.Where(ap => ap.Name == "KeepSSCC").FirstOrDefault();


        //Önce teslim alma kalemini al. Teslim almaya uygun ürün var mı bak. Eğer yoksa parametrelerden ForbidExcess parametresine göre işlem yap.


        throw new NotImplementedException();
    }
    public Task<Stock> AddNotExpectedStock(Guid receiptId, decimal quantity, Guid itemUnitId, Guid stockContainerId, List<StockAttribute> stockAttributes, int UserId, Guid depositorCompanyId, Guid? depositorId = null)
    {
        throw new NotImplementedException();
    }

    public Task CancelReceiptItem(Guid[] receiptItemIds, int UserId, Guid depositorCompanyId, Guid? depositorId = null)
    {
        throw new NotImplementedException();
    }

    public Task CancelReceiptItemWithQuantity(Guid[] receiptItemIds, decimal quantity, int UserId, Guid depositorCompanyId, Guid? depositorId = null)
    {
        throw new NotImplementedException();
    }

    
}
