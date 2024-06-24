namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants;

public class ShipmentsDetailLevel
{
    public bool IncludeShipmentType { get; set; } = false;
    public bool IncludeShipmentMemo { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;

    public bool IncludeDistributor { get; set; } = false;
    public ShipmentsDistributorSubDetailLevel DistributorDetailLevel { get; set; } = new ShipmentsDistributorSubDetailLevel();
    public class ShipmentsDistributorSubDetailLevel
    {
        public bool IncludeAddress { get; set; } = false;
        public bool IncludeCompany { get; set; } = false;
    }

    public bool IncludeBranch { get; set; } = false;
    public ShipmentsBranchSubDetailLevel BranchDetailLevel { get; set; } = new ShipmentsBranchSubDetailLevel();
    public class ShipmentsBranchSubDetailLevel
    {
        public bool IncludeAddress { get; set; } = false;
    }

    public bool IncludeDepositor { get; set; } = false;
    public ShipmentsDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new ShipmentsDepositorSubDetailLevel();
    public class ShipmentsDepositorSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }


    public bool IncludeShipmentAttributeValue { get; set; } = false;
    public ShipmentsShipmentAttributeValueSubDetailLevel ShipmentAttributeValueDetailLevel { get; set; } = new ShipmentsShipmentAttributeValueSubDetailLevel();
    public class ShipmentsShipmentAttributeValueSubDetailLevel
    {
        public bool IncludeShipmentAttribute { get; set; } = false;
        public ShipmentsShipmentAttributeSubDetailLevel ShipmentAttributeDetailLevel { get; set; } = new ShipmentsShipmentAttributeSubDetailLevel();
        public class ShipmentsShipmentAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

    public bool IncludeOrderShipment { get; set; } = false;
    public ShipmentsOrderShipmentSubDetailLevel OrderShipmentDetailLevel { get; set; } = new ShipmentsOrderShipmentSubDetailLevel();
    public class ShipmentsOrderShipmentSubDetailLevel
    {
        public bool IncludeOrder { get; set; } = false;
        public bool IncludeDepositorCompany { get; set; } = false;
        public bool IncludeProgressStatus { get; set; } = false;
        public bool IncludeOrderShipItems { get; set; } = false;
        public ShipmentsOrderShipItemSubDetailLevel OrderShipItemDetailLevel { get; set; } = new ShipmentsOrderShipItemSubDetailLevel();
        public class ShipmentsOrderShipItemSubDetailLevel
        {
            public bool IncludeProgressStatus { get; set; } = false;
            public bool IncludeOrderItem { get; set; } = false;
            public ShipmentsOrderItemSubDetailLevel OrderItemDetailLevel { get; set; } = new ShipmentsOrderItemSubDetailLevel();
            public class ShipmentsOrderItemSubDetailLevel
            {
                public bool IncludeProduct { get; set; } = false;
                public bool IncludeItemUnit { get; set; } = false;
                public ShipmentsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new ShipmentsItemUnitSubDetailLevel();
                public class ShipmentsItemUnitSubDetailLevel
                {
                    public bool IncludeUnit { get; set; } = false;
                }
            }
            public bool IncludeOrderShipItemTasks { get; set; } = false;
            public ShipmentsOrderShipItemTaskSubDetailLevel OrderShipItemTaskDetailLevel { get; set; } = new ShipmentsOrderShipItemTaskSubDetailLevel();
            public class ShipmentsOrderShipItemTaskSubDetailLevel
            {
                public bool IncludeOrderShipItemStock { get; set; } = false;
                public ShipmentsOrderShipItemStockSubDetailLevel OrderShipItemStockDetailLevel { get; set; } = new ShipmentsOrderShipItemStockSubDetailLevel();
                public class ShipmentsOrderShipItemStockSubDetailLevel
                {
                    public bool IncludeStock { get; set; } = false;
                    public bool IncludeStockPackType { get; set; } = false;
                }
            }
        }
    }
}
