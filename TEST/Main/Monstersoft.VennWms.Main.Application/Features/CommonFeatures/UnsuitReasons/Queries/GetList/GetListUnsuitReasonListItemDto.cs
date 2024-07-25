using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetList;

public class GetListUnsuitReasonListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsBlocked { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public UnsuitReasonDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
