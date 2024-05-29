namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.UpdateDtos;

public class UpdateUnsuitReasonDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsBlocked { get; set; }
}

