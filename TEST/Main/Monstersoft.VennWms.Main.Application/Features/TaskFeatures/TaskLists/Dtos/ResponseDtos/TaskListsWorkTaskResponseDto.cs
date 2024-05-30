namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.ResponseDtos;

public class TaskListsWorkTaskResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid TaskListId { get; set; }
    public Guid StockId { get; set; }
    public Guid FromLocationId { get; set; }
    public Guid ToLocationId { get; set; }
    public int StatusId { get; set; }
    public int TransactionTypeId { get; set; }
    public decimal Quantity { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
}