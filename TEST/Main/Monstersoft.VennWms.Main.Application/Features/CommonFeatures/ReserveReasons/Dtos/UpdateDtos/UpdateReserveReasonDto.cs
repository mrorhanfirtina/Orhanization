namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.UpdateDtos;

public class UpdateReserveReasonDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsBlocked { get; set; }
}

