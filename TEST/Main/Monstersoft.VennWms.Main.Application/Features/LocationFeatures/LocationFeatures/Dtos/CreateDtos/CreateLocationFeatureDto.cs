namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationFeatures.Dtos.CreateDtos;

public class CreateLocationFeatureDto
{
    public Guid LocationId { get; set; }
    public bool StockControlLed { get; set; }
    public bool ReceivingLed { get; set; }
    public bool SendingLed { get; set; }
    public bool DamagedLed { get; set; }
    public bool ReturnsLed { get; set; }
    public bool PackingLed { get; set; }
    public bool SortingLed { get; set; }
    public bool PickingLed { get; set; }
    public bool RepackingLed { get; set; }
    public bool ReplenishSourceLed { get; set; }
    public bool ReplenishTargetLed { get; set; }
    public bool NoStockMergeLed { get; set; }
    public bool SingleProductLed { get; set; }
    public bool SinglePackTypeLed { get; set; }
}
