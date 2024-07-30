using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetList;

public class GetListTaskListListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public TaskListsDepositorResponseDto Depositor { get; set; }
    public TaskListsDepositorCompanyResponseDto DepositorCompany { get; set; }
}

