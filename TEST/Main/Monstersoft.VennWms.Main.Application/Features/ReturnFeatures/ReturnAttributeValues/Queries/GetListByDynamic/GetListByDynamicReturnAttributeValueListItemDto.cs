using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicReturnAttributeValueListItemDto
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public Guid ReturnAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ReturnAttributeValuesReturnAttributeResponseDto? ReturnAttribute { get; set; }
    public ReturnAttributeValuesReturnResponseDto? Return { get; set; }
}

