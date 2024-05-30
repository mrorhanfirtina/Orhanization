namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.ResponseDtos;

public class ReturnItemMemosProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}