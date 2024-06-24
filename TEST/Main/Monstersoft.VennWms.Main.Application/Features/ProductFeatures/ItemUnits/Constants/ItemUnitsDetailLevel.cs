namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants;

public class ItemUnitsDetailLevel
{
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeUnit { get; set; } = false;
    public bool IncludeItemPackType { get; set; } = false;
    public bool IncludeItemUnitConversion { get; set; } = false;
    public ItemUnitsItemPackTypeSubDetailLevel ItemPackTypeDetailLevel { get; set; } = new ItemUnitsItemPackTypeSubDetailLevel();
    public class ItemUnitsItemPackTypeSubDetailLevel
    {
        public bool IncludeLenghtUnit { get; set; } = false;
        public bool IncludeVolumeUnit { get; set; } = false;
        public bool IncludeWeightUnit { get; set; } = false;
    }

    public ItemUnitsItemUnitConversionSubDetailLevel ItemUnitConversionDetailLevel { get; set; } = new ItemUnitsItemUnitConversionSubDetailLevel();
    public class ItemUnitsItemUnitConversionSubDetailLevel
    {
        public bool IncludeConvertedItemUnit { get; set; } = false;

        public ItemUnitsConvertedItemUnitSubDetailLevel ConvertedItemUnitDetailLevel { get; set; } = new ItemUnitsConvertedItemUnitSubDetailLevel();
        public class ItemUnitsConvertedItemUnitSubDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }
}
