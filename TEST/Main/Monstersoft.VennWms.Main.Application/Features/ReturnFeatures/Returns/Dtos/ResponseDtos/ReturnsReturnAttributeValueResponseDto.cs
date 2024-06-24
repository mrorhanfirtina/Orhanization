namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.ResponseDtos;

public class ReturnsReturnAttributeValueResponseDto
{
    public Guid Id { get; set; }
    public Guid ReturnAttributeId { get; set; }
    public string Value { get; set; }
    public ReturnsReturnAttributeResponseDto? ReturnAttribute { get; set; }
}