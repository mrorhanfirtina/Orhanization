using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetByCode;

public class GetByCodeUnsuitReasonResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public UnsuitReasonDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public bool IsBlocked { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
