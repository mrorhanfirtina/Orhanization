namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.WorkTaskDtos;

public class UpdateWorkTaskSubDto
{
    public string Code { get; set; }
    public Guid StockId { get; set; }
    public Guid FromLocationId { get; set; }
    public Guid ToLocationId { get; set; }
    public int StatusId { get; set; }
    public int TransactionTypeId { get; set; }
    public decimal Quantity { get; set; }
    public Guid DepositorId { get; set; }
}

