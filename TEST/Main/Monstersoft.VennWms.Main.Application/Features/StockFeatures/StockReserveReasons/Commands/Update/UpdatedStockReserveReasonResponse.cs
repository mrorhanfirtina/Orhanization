namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Update;

public class UpdatedStockReserveReasonResponse
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid ReserveReasonId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

