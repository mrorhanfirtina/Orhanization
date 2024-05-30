namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.ResponseDtos;

public class ReturnItemMemosReturnResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
}