using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Queries.GetListByDynamic;

public class GetListByDynamicLocationProductAttributeListItemDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public bool IsForbid { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public LocationProductAttributeProductAttributeResponseDto? ProductAttribute { get; set; }
    public LocationProductAttributeLocationResponseDto? Location { get; set; }

}

