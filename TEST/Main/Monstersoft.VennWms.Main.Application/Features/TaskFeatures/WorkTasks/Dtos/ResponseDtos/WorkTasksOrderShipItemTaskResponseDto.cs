namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Dtos.ResponseDtos;

public class WorkTasksOrderShipItemTaskResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderShipItemId { get; set; }
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
}