namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.UpdateDtos;

public class UpdateLockReasonDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
}
