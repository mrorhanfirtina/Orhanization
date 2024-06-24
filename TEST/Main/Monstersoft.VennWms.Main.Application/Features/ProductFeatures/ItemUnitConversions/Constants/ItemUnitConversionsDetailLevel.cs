namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;

public class ItemUnitConversionsDetailLevel
{
    public bool IncludeReferenceItemUnit { get; set; } = false;
    public bool IncludeConvertedItemUnit { get; set; } = false;
    public ItemUnitConversionsReferenceItemUnitSubDetailLevel ReferenceItemUnitDetailLevel { get; set; } = new ItemUnitConversionsReferenceItemUnitSubDetailLevel();
    public class ItemUnitConversionsReferenceItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }

    public ItemUnitConversionsConvertedItemUnitSubDetailLevel ConvertedItemUnitDetailLevel { get; set; } = new ItemUnitConversionsConvertedItemUnitSubDetailLevel();
    public class ItemUnitConversionsConvertedItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }
}
