namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants;

public class ItemUnitDetailLevel
{
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeUnit { get; set; } = false;
    public bool IncludeItemPackType { get; set; } = false;
    public bool IncludeItemUnitConversion { get; set; } = false;
    public ItemUnitItemPackTypeDetailLevel ItemPackTypeDetailLevel { get; set; } = new ItemUnitItemPackTypeDetailLevel();
    public class ItemUnitItemPackTypeDetailLevel
    {
        public bool IncludeLenghtUnit { get; set; } = false;
        public bool IncludeVolumeUnit { get; set; } = false;
        public bool IncludeWeightUnit { get; set; } = false;
    }

    public ItemUnitItemUnitConversionDetailLevel ItemUnitConversionDetailLevel { get; set; } = new ItemUnitItemUnitConversionDetailLevel();
    public class ItemUnitItemUnitConversionDetailLevel
    {
        public bool IncludeConvertedItemUnit { get; set; } = false;

        public ItemUnitConvertedItemUnitDetailLevel ConvertedItemUnitDetailLevel { get; set; } = new ItemUnitConvertedItemUnitDetailLevel();
        public class ItemUnitConvertedItemUnitDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }
}
