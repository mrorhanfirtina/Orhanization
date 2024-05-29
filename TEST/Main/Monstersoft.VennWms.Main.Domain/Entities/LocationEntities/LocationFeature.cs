using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationFeature : Entity<Guid>
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
    public virtual Location? Location { get; set; }

    public LocationFeature()
    {
    }

    public LocationFeature(Guid id, Guid locationId, bool stockControlLed, bool receivingLed, bool sendingLed, bool damagedLed, bool returnsLed, bool packingLed, bool sortingLed, bool pickingLed, bool repackingLed, bool replenishSourceLed, bool replenishTargetLed, bool noStockMergeLed, bool singleProductLed, bool singlePackTypeLed) : this()
    {
        Id = id;
        LocationId = locationId;
        StockControlLed = stockControlLed;
        ReceivingLed = receivingLed;
        SendingLed = sendingLed;
        DamagedLed = damagedLed;
        ReturnsLed = returnsLed;
        PackingLed = packingLed;
        SortingLed = sortingLed;
        PickingLed = pickingLed;
        RepackingLed = repackingLed;
        ReplenishSourceLed = replenishSourceLed;
        ReplenishTargetLed = replenishTargetLed;
        NoStockMergeLed = noStockMergeLed;
        SingleProductLed = singleProductLed;
        SinglePackTypeLed = singlePackTypeLed;
    }
}
