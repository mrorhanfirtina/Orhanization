namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.ResponseDtos;

public class ReturnItemsProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}