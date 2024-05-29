namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;

public class ItemUnitConversionDetailLevel
{
    public bool IncludeReferenceItemUnit { get; set; } = false;
    public bool IncludeConvertedItemUnit { get; set; } = false;
    public ItemUnitConversionReferenceItemUnitDetailLevel ReferenceItemUnitDetailLevel { get; set; } = new ItemUnitConversionReferenceItemUnitDetailLevel();
    public class ItemUnitConversionReferenceItemUnitDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }

    public ItemUnitConversionConvertedItemUnitDetailLevel ConvertedItemUnitDetailLevel { get; set; } = new ItemUnitConversionConvertedItemUnitDetailLevel();
    public class ItemUnitConversionConvertedItemUnitDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }
}
