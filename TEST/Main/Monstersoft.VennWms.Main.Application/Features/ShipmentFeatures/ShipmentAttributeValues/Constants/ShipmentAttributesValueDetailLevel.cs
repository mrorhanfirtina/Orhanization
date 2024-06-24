namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Constants;

public class ShipmentAttributesValueDetailLevel
{
    public bool IncludeShipment { get; set; } = false;
    public bool IncludeShipmentAttribute { get; set; } = false;
    public ShipmentAttributeValuesShipmentAttributeSubDetailLevel ShipmentAttributeDetailLevel { get; set; } = new ShipmentAttributeValuesShipmentAttributeSubDetailLevel();
    public class ShipmentAttributeValuesShipmentAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
