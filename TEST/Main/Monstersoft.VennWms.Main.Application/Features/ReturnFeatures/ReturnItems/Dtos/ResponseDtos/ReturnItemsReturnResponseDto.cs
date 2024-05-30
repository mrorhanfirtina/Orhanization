namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.ResponseDtos;

public class ReturnItemsReturnResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
}