using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Services.Abstract.ReceiptServices;

public interface IReceiptService
{
    public Task CancelReceiptItem(Guid[] receiptItemIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Teslim alma kalemini iptal etmek için.
    public Task CancelReceiptItemWithQuantity(Guid[] receiptItemIds, decimal quantity, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Teslim alma kalemini kısmi iptal etmek için.
    public Task<Stock> AddStock(Guid receiptItemId, decimal quantity, Guid productId, Guid itemUnitId, Guid stockContainerId, Guid locationId, List<StockAttribute> stockAttributes, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stok eklemek için.
    public Task<Stock> AddNotExpectedStock(Guid receiptId, decimal quantity, Guid itemUnitId, Guid stockContainerId, List<StockAttribute> stockAttributes, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stok eklemek için.
}
