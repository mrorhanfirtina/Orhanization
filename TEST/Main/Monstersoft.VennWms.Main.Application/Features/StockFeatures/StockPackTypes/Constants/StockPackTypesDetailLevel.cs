namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants;

public class StockPackTypesDetailLevel
{
    public bool IncludeItemUnit { get; set; } = false;
    public StockPackTypesItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new StockPackTypesItemUnitSubDetailLevel();
    public class StockPackTypesItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
    }
    public bool IncludeStock { get; set; } = false;
    public StockPackTypesStockSubDetailLevel StockDetailLevel { get; set; } = new StockPackTypesStockSubDetailLevel();
    public class StockPackTypesStockSubDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeDepositorCompany { get; set; } = false;
        public bool IncludeLocation { get; set; } = false;
        public bool IncludeDepositor { get; set; } = false;
        public StockPackTypesDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new StockPackTypesDepositorSubDetailLevel();
        public class StockPackTypesDepositorSubDetailLevel
        {
            public bool IncludeCompany { get; set; } = false;
        }
        public bool IncludeCuItemUnit { get; set; } = false;
        public StockPackTypeItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new StockPackTypeItemUnitSubDetailLevel();
        public class StockPackTypeItemUnitSubDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }
}
