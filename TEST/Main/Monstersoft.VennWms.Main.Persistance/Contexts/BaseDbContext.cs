using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

    //Common Entities
    public DbSet<AttributeInputType> AttributeInputTypes { get; set; }
    public DbSet<ContainerUnit> ContainerUnits { get; set; }
    public DbSet<ProgressStatus> ProgressStatuses { get; set; }
    public DbSet<ReserveReason> ReserveReasons { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<UnsuitReason> UnsuitReasons { get; set;}

    //Depositor Entities
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<DepositorCompany> DepositorCompanies { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Depositor> Depositors { get; set;}
    public DbSet<Disturbitor> Disturbitors { get; set; }
    public DbSet<Receiver> Receivers { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }

    //Location Entities
    public DbSet<Building> Buildings { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Site> Sites { get; set; }
    public DbSet<StorageSystem> StorageSystems { get; set; }

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

    //Task Entities
    public DbSet<TaskList> TaskLists { get; set; }
    public DbSet<TransactionType> TransactionTypes { get; set; }
    public DbSet<WorkTask> WorkTasks { get; set; }

    //Authentication Entities
    public DbSet<EmailAuthenticator> EmailAuthenticators { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<OtpAuthenticator> OtpAuthenticators { get; set; }
}
