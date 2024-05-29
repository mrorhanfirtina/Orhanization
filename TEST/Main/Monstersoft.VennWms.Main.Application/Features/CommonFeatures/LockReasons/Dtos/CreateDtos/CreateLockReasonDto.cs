namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.CreateDtos;

public class CreateLockReasonDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
}
