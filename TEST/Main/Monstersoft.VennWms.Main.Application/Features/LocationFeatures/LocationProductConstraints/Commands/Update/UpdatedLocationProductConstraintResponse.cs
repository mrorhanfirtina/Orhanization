using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Update;

public class UpdatedLocationProductConstraintResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public LocationProductConstraintItemUnitResponseDto? ItemUnit { get; set; }
    public LocationProductConstraintLocationResponseDto? Location { get; set; }

}

