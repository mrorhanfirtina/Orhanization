namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants;

public class ItemPackTypeDetailLevel
{
    public bool IncludeLenghtUnit { get; set; } = false;
    public bool IncludeVolumeUnit { get; set; } = false;
    public bool IncludeWeightUnit { get; set; } = false;
    public bool IncludeItemUnit { get; set; } = false;
    public ItemPackTypeItemUnitDetailLevel ItemUnitDetailLevel { get; set; } = new ItemPackTypeItemUnitDetailLevel();
    public class ItemPackTypeItemUnitDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeUnit { get; set; } = false;
    }
}
