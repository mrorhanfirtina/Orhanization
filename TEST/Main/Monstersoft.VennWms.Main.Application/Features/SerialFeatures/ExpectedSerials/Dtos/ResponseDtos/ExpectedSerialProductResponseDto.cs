namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.ResponseDtos;

public class ExpectedSerialProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}
