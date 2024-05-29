using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks;

public class CreateLogStockSubDto
{
    public Guid StockId { get; set; }
    public Guid ProductId { get; set; }
    public Guid FromLocationId { get; set; }
    public Guid ToLocationId { get; set; }
    public decimal Quantity { get; set; }
    public int TransactionTypeId { get; set; }
    public ICollection<CreateLogStockAttributeValueSubDto> LogStockAttributeValues { get; set; }
    public ICollection<CreateLogStockContainerSubDto> LogStockContainers { get; set; }
    public ICollection<CreateLogStockReserveReasonSubDto> LogStockReserveReasons { get; set; }
    public ICollection<CreateLogStockUnsuitReasonSubDto> LogStockUnsuitReasons { get; set; }
}

