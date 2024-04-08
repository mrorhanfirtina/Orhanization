using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LoggingDtos;

public class UpdateLogStockDto
{
    public Guid Id { get; set; }
    public Guid TransactionLogId { get; set; }
    public Guid StockId { get; set; }
    public Guid ProductId { get; set; }
    public Guid FromLocaitonId { get; set; }
    public Guid ToLocationId { get; set; }
    public decimal Quantity { get; set; }
    public int TransactionTypeId { get; set; }
    public ICollection<UpdateLogStockAttributeValueSubDto> LogStockAttributeValues { get; set; }
    public ICollection<UpdateLogStockContainerSubDto> LogStockContainers { get; set; }
    public ICollection<UpdateLogStockReserveReasonSubDto> LogStockReserveReasons { get; set; }
    public ICollection<UpdateLogStockUnsuitReasonSubDto> LogStockUnsuitReasons { get; set; }

}

