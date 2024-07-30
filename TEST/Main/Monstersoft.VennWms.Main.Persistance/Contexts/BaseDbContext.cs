using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Security.Entities;
using System.Reflection;

namespace Monstersoft.VennWms.Main.Persistance.Contexts;

public class BaseDbContext : DbContext
{ 
    protected IConfiguration Configuration { get; set; }

    public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
        //Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    //Barcode Entities
    public DbSet<Barcode> Barcodes { get; set; }
    public DbSet<BarcodeArea> BarcodeAreas { get; set; }
    public DbSet<Printer> Printers { get; set; }
    public DbSet<BarcodePrinter> BarcodePrinters { get; set; }


    //Common Entities
    public DbSet<AttributeInputType> AttributeInputTypes { get; set; }
    public DbSet<ContainerUnit> ContainerUnits { get; set; }
    public DbSet<ProgressStatus> ProgressStatuses { get; set; }
    public DbSet<ReserveReason> ReserveReasons { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<UnitConversion> UnitConversions { get; set; }
    public DbSet<UnsuitReason> UnsuitReasons { get; set;}
    public DbSet<LockReason> LockReasons { get; set;}
    public DbSet<PickingType> PickingTypes { get; set;}
    public DbSet<LocationCodeComponent> LocationCodeComponents { get; set;}
    public DbSet<AbcCategoryList> AbcCategoryLists { get; set; }
    public DbSet<PriorityList> PriorityLists { get; set; }
    public DbSet<ActionParameter> ActionParameters { get; set; }
    public DbSet<ActionParameterCategory> ActionParameterCategories { get; set; }
    public DbSet<ActionParameterDepositor> ActionParameterDepositors { get; set; }
    public DbSet<ActionParameterUser> ActionParameterUsers { get; set; }
    public DbSet<ActionParameterDefault> ActionParameterDefaults { get; set; }

    //Depositor Entities
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<DepositorCompany> DepositorCompanies { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Depositor> Depositors { get; set;}
    public DbSet<DepositorFeature> DepositorFeatures { get; set;}
    public DbSet<UserDepositor> UserDepositors { get; set;}
    public DbSet<Distributor> Distributors { get; set; }
    public DbSet<Receiver> Receivers { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Address> Addresses { get; set; }

    //Location Entities
    public DbSet<Building> Buildings { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Site> Sites { get; set; }
    public DbSet<StorageSystem> StorageSystems { get; set; }
    public DbSet<LocationProduct> LocationProducts { get; set; }
    public DbSet<LocationStockAttribute> LocationStockAttributes { get; set; }
    public DbSet<LocationProductAttribute> LocationProductAttributes { get; set; }
    public DbSet<LocationZone> LocationZones { get; set; }
    public DbSet<Zone> Zones { get; set; }
    public DbSet<SiteDepositor> SiteDepositors { get; set; }
    public DbSet<LocationLockReason> LocationLockReasons { get; set; }
    public DbSet<LocationPickingType> LocationPickingTypes { get; set; }
    public DbSet<LocationUnitConstraint> LocationUnitConstraints { get; set; }
    public DbSet<LocationProductConstraint> LocationProductConstraints { get; set; }
    public DbSet<LocationDimension> LocationDimensions { get; set; }
    public DbSet<LocationFeature> LocationFeatures { get; set; }
    public DbSet<LocationPriority> LocationPriorities { get; set; }
    public DbSet<LocationDepositor> LocationDepositors { get; set; }
    public DbSet<LocationCodeFormat> LocationCodeFormats { get; set; }
    public DbSet<BuildingDimension> BuildingDimensions { get; set; }
    public DbSet<LocationCoordinate> LocationCoordinates { get; set; }
    public DbSet<LocationProductCategory> LocationProductCategories { get; set; }
    public DbSet<LocationProductAbcCategory> LocationProductAbcCategories { get; set; }
    public DbSet<BufferLocation> BufferLocations { get; set; }


    //Logging Entities
    public DbSet<LogStock> LogStocks { get; set; }
    public DbSet<LogStockAttributeValue> LogStockAttributeValues { get; set; }
    public DbSet<LogStockContainer> LogStockContainers { get; set; }
    public DbSet<LogStockReserveReason> LogStockReserveReasons { get; set;}
    public DbSet<LogStockUnsuitReason> LogStockUnsuitReasons { get; set; }
    public DbSet<TransactionLog> TransactionLogs { get; set; }

    //Order Entities
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderAttribute> OrderAttributes { get; set; }
    public DbSet<OrderAttributeValue> OrderAttributeValues { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<OrderItemMemo> OrderItemMemos { get; set; }
    public DbSet<OrderItemStockAttrValue> OrderItemStockAttrValues { get; set;}
    public DbSet<OrderMemo> OrderMemos { get; set; }
    public DbSet<OrderType> OrderTypes { get; set; }
    public DbSet<OrderPriority> OrderPriorities { get; set; }

    //PO Entities
    public DbSet<PoAttribute> PoAttributes { get; set; }
    public DbSet<PoAttributeValue> PoAttributeValues { get; set; }
    public DbSet<PoMemo> PoMemos { get; set; }
    public DbSet<PoType> PoTypes { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set;}

    //Product Entities
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductAttribute> ProductAttributes { get; set; }
    public DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
    public DbSet<ProductBarcode> ProductBarcodes { get; set; }
    public DbSet<BarcodeSupplier> BarcodeSuppliers { get; set; }
    public DbSet<ItemUnit> ItemUnits { get; set; }
    public DbSet<ItemUnitConversion> ItemUnitConversions { get; set; }
    public DbSet<ItemPackType> ItemPackTypes { get; set; }
    public DbSet<ProductStockAttribute> ProductStockAttributes { get; set; }
    public DbSet<ProductDepositor> ProductDepositors { get; set; }
    public DbSet<ProductCategoryList> ProductCategoryLists { get; set; }
    public DbSet<ProductAbcCategory> ProductAbcCategories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }



    //Receipt Entities
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<ReceiptAttribute> ReceiptAttributes { get;set; }
    public DbSet<ReceiptAttributeValue> ReceiptAttributeValues { get; set;}
    public DbSet<ReceiptItem> ReceiptItems { get; set; }
    public DbSet<ReceiptItemMemo> ReceiptItemMemos { get; set;}
    public DbSet<ReceiptItmStockAttrValue> ReceiptItmStockAttrValues { get; set; }
    public DbSet<ReceiptMemo> ReceiptMemos { get; set; }
    public DbSet<ReceiptType> ReceiptTypes { get; set; }

    //Return Entities
    public DbSet<Return> Returns { get; set; }
    public DbSet<ReturnAttribute> ReturnAttributes { get; set; }
    public DbSet<ReturnAttributeValue> ReturnAttributeValues { get; set; }
    public DbSet<ReturnItem> ReturnItems { get; set; }
    public DbSet<ReturnItemMemo> ReturnItemMemos { get; set; }
    public DbSet<ReturnItmStockAttrValue> ReturnItmStockAttrValues { get; set; }
    public DbSet<ReturnMemo> ReturnMemos { get; set; }
    public DbSet<ReturnType> ReturnTypes { get; set; }

    //Shipment Entities
    public DbSet<OrderShipItem> OrderShipItems { get; set; }
    public DbSet<OrderShipItemStock> OrderShipItemStocks { get; set; }
    public DbSet<OrderShipItemTask> OrderShipItemTasks { get; set;}
    public DbSet<OrderShipment> OrderShipments { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
    public DbSet<ShipmentAttribute> ShipmentAttributes { get; set; }
    public DbSet<ShipmentAttributeValue> ShipmentAttributeValues { get; set; }
    public DbSet<ShipmentMemo> ShipmentMemos { get; set; }
    public DbSet<ShipmentType> ShipmentTypes { get; set; }

    //Stock Entities
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<StockAttribute> StockAttributes { get; set; }
    public DbSet<StockAttributeValue> StockAttributeValues { get; set;}
    public DbSet<StockContainer> StockContainers { get; set; }
    public DbSet<StockMemo> StockMemos { get; set;}
    public DbSet<StockReserveReason> StockReserveReasons { get; set;}
    public DbSet<StockUnsuitReason> StockUnsuitReasons { get;set; }
    public DbSet<TaskStock> TaskStocks { get; set; }
    public DbSet<StockPackType> StockPackTypes { get; set; }
    public DbSet<StockInbound> StockInbounds { get; set; }
    public DbSet<StockContainerHierarchy> StockContainerHierarchies { get; set; }

    //Task Entities
    public DbSet<TaskList> TaskLists { get; set; }
    public DbSet<TransactionType> TransactionTypes { get; set; }
    public DbSet<WorkTask> WorkTasks { get; set; }
    public DbSet<TaskCodeFormat> TaskCodeFormats { get; set; }

    //Authentication Entities
    public DbSet<EmailAuthenticator> EmailAuthenticators { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<OtpAuthenticator> OtpAuthenticators { get; set; }

    //Serial Entities
    public DbSet<ExpectedSerial> ExpectedSerials { get; set; }
    public DbSet<ExpectedSerialHierarchy> ExpectedSerialHierarchies { get; set; }
    public DbSet<Serial> Serials { get; set; }
    public DbSet<SerialHierarchy> SerialHierarchies { get; set; }
    public DbSet<SerialLog> SerialLogs { get; set; }
}
