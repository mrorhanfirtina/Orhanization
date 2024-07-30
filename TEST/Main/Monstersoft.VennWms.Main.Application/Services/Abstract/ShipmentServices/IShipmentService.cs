namespace Monstersoft.VennWms.Main.Application.Services.Abstract.ShipmentServices;

public interface IShipmentService
{
    public Task CloseShipment(Guid shipmentId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Gönderimi kapatmak için.
    public Task LoadContainer(Guid[] containerIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Paleti yüklemek için.
    public Task LoadOrderShipItem(Guid[] orderShipItemIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderim kalemini yüklemek için.
    public Task LoadOrderShipment(Guid[] orderShipments, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderimlerini yüklemek için.
    public Task LoadOrderShipmentPartial(Guid orderShipmentId, Guid[] containerIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderimini kısmi yüklemek için.
    public Task LoadShipment(Guid[] shipmentIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Gönderimleri yüklemek için.
    public Task LoadStock(Guid[] stockIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stokları yüklemek için.
    public Task UnloadOrderShipment(Guid[] orderShipmentIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderimlerini boşaltmak için.
    public Task UnloadShipment(Guid[] shipmentIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Gönderimleri boşaltmak için.
    public Task UnloadStock(Guid[] stockIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Stokları boşaltmak için.
    public Task UnloadContainer(Guid[] containerIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Paleti boşaltmak için.
    public Task LockOrderShipment(Guid[] orderShipmentIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Sipariş gönderimlerini kilitlemek için.
}
