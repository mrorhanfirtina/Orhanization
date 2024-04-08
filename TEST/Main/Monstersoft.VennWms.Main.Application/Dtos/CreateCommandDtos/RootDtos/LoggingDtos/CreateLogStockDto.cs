using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LoggingDtos;

public class CreateLogStockDto
{
    public Guid TransactionLogId { get; set; }
    public Guid StockId { get; set; }
    public Guid ProductId { get; set; }
    public Guid FromLocaitonId { get; set; }
    public Guid ToLocationId { get; set; }
    public decimal Quantity { get; set; }
    public int TransactionTypeId { get; set; }
    public ICollection<CreateLogStockAttributeValueSubDto> LogStockAttributeValues { get; set; }
    public ICollection<CreateLogStockContainerSubDto> LogStockContainers { get; set; }
    public ICollection<CreateLogStockReserveReasonSubDto> LogStockReserveReasons { get; set; }
    public ICollection<CreateLogStockUnsuitReasonSubDto> LogStockUnsuitReasons { get; set; }

}

