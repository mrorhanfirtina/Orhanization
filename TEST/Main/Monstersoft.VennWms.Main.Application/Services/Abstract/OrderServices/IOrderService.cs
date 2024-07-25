namespace Monstersoft.VennWms.Main.Application.Services.Abstract.OrderServices;

public interface IOrderService
{
    public Task CalculateOrderShipmentStatus(Guid orderShipmentId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Siparişin gönderim statülerinin kontrol etmek ve hesaplamak için.
    public Task CalculateOrderStatus(Guid orderId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Siparişin statülerinin kontrol etmek ve hesaplamak için.
    public Task CancelOrder(Guid[] orderIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Siparişi iptal etmek için.
    public Task CancelOrderItem(Guid[] orderItemIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş kalemini iptal etmek için.
    public Task CancelOrderShipment(Guid[] orderShipmentIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderimini iptal etmek için.
    public Task CancelOrderShipItem(Guid[] orderShipItemIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderim kalemini iptal etmek için.
    public Task ChangeOrderItemUnit(Guid orderItemId, int targetItemUnitId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş kaleminin birimini değiştirmek için.
    public Task CreateReplenishmentPendingOrder(Guid[] orderIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Beklemedeki siparişlere ikmal görevi oluşturmak için.
    public Task HardDeallocateOrderShipItem(Guid[] orderShipItemIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderim kalemini iptal etmek için.
    public Task HardDeallocateOrderItem(Guid[] orderItemIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş kalemini iptal etmek için.
    public Task HardDeallocateOrder(Guid[] orderIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Siparişi iptal etmek için.
    public Task HardDeAllocateOrderShipment(Guid[] orderShipmentIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderimini iptal etmek için.
    public Task SoftDeAllocationOrderShipItems(Guid[] orderShipItemIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderim kalemlerini iptal etmek için.
    public Task SortOrderShipItem(Guid orderShipItemId, decimal quantity, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderim kalemini dağıtmak için.
}