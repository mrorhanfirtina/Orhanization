namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants;

public class StockContainerHierarchiesDetailLevel
{
    public bool IncludeParentContainer { get; set; } = false;
    public ContainerHierarchiesParentContainerSubDetailLevel ParentContainerDetailLevel { get; set; } = new ContainerHierarchiesParentContainerSubDetailLevel();
    public class ContainerHierarchiesParentContainerSubDetailLevel
    {
        public bool IncludeContainerUnit { get; set; } = false;
        public bool IncludeStock { get; set; } = false;

        public ContainerHierarchiesParentStockSubDetailLevel ParentStockDetailLevel { get; set; } = new ContainerHierarchiesParentStockSubDetailLevel();
        public class ContainerHierarchiesParentStockSubDetailLevel
        {
            public bool IncludeProduct { get; set; } = false;
            public bool IncludeDepositor { get; set; } = false;
            public bool IncludeDepositorCompany { get; set; } = false;
            public bool IncludeLocation { get; set; } = false;
            public bool IncludeCuItemUnit { get; set; } = false;

            public ContainerHierarchiesParentUnitSubDetailLevel ParentUnitDetailLevel { get; set; } = new ContainerHierarchiesParentUnitSubDetailLevel();
            public class ContainerHierarchiesParentUnitSubDetailLevel
            {
                public bool IncludeUnit { get; set; } = false;
            }
        }
    }
    public bool IncludeChildContainer { get; set; } = false;
    public ContainerHierarchiesChildContainerSubDetailLevel ChildContainerDetailLevel { get; set; } = new ContainerHierarchiesChildContainerSubDetailLevel();
    public class ContainerHierarchiesChildContainerSubDetailLevel
    {
        public bool IncludeContainerUnit { get; set; } = false;
        public bool IncludeStock { get; set; } = false;

        public ContainerHierarchiesChildStockSubDetailLevel ChildStockDetailLevel { get; set; } = new ContainerHierarchiesChildStockSubDetailLevel();
        public class ContainerHierarchiesChildStockSubDetailLevel
        {
            public bool IncludeProduct { get; set; } = false;
            public bool IncludeDepositor { get; set; } = false;
            public bool IncludeDepositorCompany { get; set; } = false;
            public bool IncludeLocation { get; set; } = false;
            public bool IncludeCuItemUnit { get; set; } = false;

            public ContainerHierarchiesChildUnitSubDetailLevel ChildUnitDetailLevel { get; set; } = new ContainerHierarchiesChildUnitSubDetailLevel();
            public class ContainerHierarchiesChildUnitSubDetailLevel
            {
                public bool IncludeUnit { get; set; } = false;
            }
        }
    }
}
