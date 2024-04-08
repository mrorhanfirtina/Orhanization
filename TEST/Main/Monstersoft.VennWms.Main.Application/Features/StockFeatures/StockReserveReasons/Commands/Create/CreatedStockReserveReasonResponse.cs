namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Create;

public class CreatedStockReserveReasonResponse
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid ReserveReasonId { get; set; }
    public DateTime CreatedDate { get; set; }

}

