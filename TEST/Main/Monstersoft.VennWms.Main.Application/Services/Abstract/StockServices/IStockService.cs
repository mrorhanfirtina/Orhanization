using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Services.Abstract.StockServices;

public interface IStockService
{
    public Task BreakPallet(Guid containerId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Paleti bozma işlemi için.
    public Task ChangePackTypeQuantity(Guid packTypeId, decimal quantity, decimal quantityFree, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Paket tipi miktarını değiştirmek için.
    public Task ChangeStockQuantity(Guid stockId, decimal quantity, decimal quantityFree, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stok miktarını değiştirmek için.
    public Task ChangeStockPackType(Guid stockPackTypeId, int targetItemUnitId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stok paket tipini değiştirmek için.
    public Task ContainerPut(Guid stockContainerId, Guid locationId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Yerleştirme işlemini tamamlamak için.
    public Task<StockContainer> CreateEmptyContainer(int containerUnitId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Boş konteyner oluşturmak için.
    public Task<ICollection<WorkTask>> CreateTaskByStock(Guid stockId, decimal quantity, Guid toLocationId, int createUserId, string transactionCode, bool createTaskList, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stok üzerinden görev oluşturmak için.
    public Task<ICollection<WorkTask>> CreateTaskByContainer(Guid containerId, decimal quantity, Guid toLocationId, int createUserId, string transactionCode, bool createTaskList, int userId, Guid depositorCompanyId, Guid? depositorId = null); //SSCC üzerinden görev oluşturmak için.
    public Task DeleteStockFromLocation(Guid locationID, int userId, Guid depositorCompanyId, Guid? depositorId = null); // Lokasyondaki stokları silmek için.
    public Task DeleteStockFromContainer(Guid containerId, int userId, Guid depositorCompanyId, Guid? depositorId = null); // Konteynerdeki stokları silmek için.
    public Task DeleteStock(Guid stockId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stok silmek için.
    public Task DeleteStockPackType(Guid stockPackTypeId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stok paket tipini silmek için.
    public Task DeleteStockContainer(Guid containerId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Konteyner silmek için.
    public Task InnerMoveContainer(Guid fromContainerId, Guid targetContainerId, Guid? targetLocationId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //SSCC'den SSCC'ye taşıma işlemi için.
    public Task InnerMoveLocation(Guid fromLocationId, Guid targetLocationId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Lokasyon taşıma işlemi için.
    public Task InnerMoveLocationToContainer(Guid fromLocationId, Guid targetContainerId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Lokasyondaki malzemeleri konteynere taşıma işlemi için.
    public Task InnerMovePackType(Guid fromPackTypeId, double quantity, double quantityFree, Guid targetLocationId, Guid? targetContainerId, bool createNewContainer, int? containerUnitId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Paket tipi taşıma işlemi için.
    public Task PackLocationToContainer(Guid locationId, Guid? targetContainerId, Guid targetLocationId, bool createNewContainer, int? containerUnitId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Lokasyondaki malzemeleri SSCC'ye paketleme işlemi için.
    public Task PackStocksToContainer(Guid[] stockIds, Guid? targetContainerId, Guid targetLocationId, bool createNewContainer, int? containerUnitId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stokları SSCC'ye paketleme işlemi için.
    public Task PackContainer(Guid[] containerIds, Guid locationId, Guid? targetContainerId, bool createNewContainer, int? containerUnitId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //SSCC'leri paketleme işlemi için.
    public Task SplitStock(Guid stockId, decimal quantity, decimal quantityFree, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stok bölme işlemi için.
}
