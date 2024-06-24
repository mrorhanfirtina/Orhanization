namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants;

public class ItemPackTypesDetailLevel
{
    public bool IncludeLenghtUnit { get; set; } = false;
    public bool IncludeVolumeUnit { get; set; } = false;
    public bool IncludeWeightUnit { get; set; } = false;
    public bool IncludeItemUnit { get; set; } = false;
    public ItemPackTypesItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new ItemPackTypesItemUnitSubDetailLevel();
    public class ItemPackTypesItemUnitSubDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeUnit { get; set; } = false;
    }
}
