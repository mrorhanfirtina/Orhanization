namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Queries.GetById;

public class GetByIdStockReserveReasonResponse
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid ReserveReasonId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

