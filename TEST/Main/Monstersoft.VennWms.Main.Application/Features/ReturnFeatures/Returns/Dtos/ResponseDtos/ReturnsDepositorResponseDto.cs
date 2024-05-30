namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.ResponseDtos;

public class ReturnsDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid CompanyId { get; set; }
    public ReturnsCompanyResponseDto? Company { get; set; }
}