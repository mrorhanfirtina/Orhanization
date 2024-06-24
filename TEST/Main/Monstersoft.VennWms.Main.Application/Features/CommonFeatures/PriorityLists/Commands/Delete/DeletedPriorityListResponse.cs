namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Delete;

public class DeletedPriorityListResponse
{
    public int Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}



