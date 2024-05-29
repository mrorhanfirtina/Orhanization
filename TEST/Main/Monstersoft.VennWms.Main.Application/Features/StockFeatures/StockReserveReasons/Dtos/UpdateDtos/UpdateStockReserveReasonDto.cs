namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.UpdateDtos;

public class UpdateStockReserveReasonDto
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid ReserveReasonId { get; set; }
}

