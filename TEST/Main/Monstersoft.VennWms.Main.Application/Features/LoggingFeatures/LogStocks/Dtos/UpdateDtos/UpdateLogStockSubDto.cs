using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.UpdateDtos;

public class UpdateLogStockSubDto
{
    public Guid StockId { get; set; }
    public Guid ProductId { get; set; }
    public Guid FromLocationId { get; set; }
    public Guid ToLocationId { get; set; }
    public decimal Quantity { get; set; }
    public int TransactionTypeId { get; set; }
    public ICollection<UpdateLogStockAttributeValueSubDto> LogStockAttributeValues { get; set; }
    public ICollection<UpdateLogStockContainerSubDto> LogStockContainers { get; set; }
    public ICollection<UpdateLogStockReserveReasonSubDto> LogStockReserveReasons { get; set; }
    public ICollection<UpdateLogStockUnsuitReasonSubDto> LogStockUnsuitReasons { get; set; }
}

