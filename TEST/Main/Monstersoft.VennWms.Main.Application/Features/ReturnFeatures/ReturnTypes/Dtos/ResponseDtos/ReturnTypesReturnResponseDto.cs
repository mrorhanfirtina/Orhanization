namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.ResponseDtos;

public class ReturnTypesReturnResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
}