using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Queries.GetById;

public class GetByIdLocationProductResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public bool IsForbid { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public LocationProductLocationResponseDto? Location { get; set; }
    public LocationProductProductResponseDto? Product { get; set; }

}
