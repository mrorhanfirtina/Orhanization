using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Create;

public class CreatedLocationUnitConstraintResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
    public DateTime CreatedDate { get; set; }
    public LocationUnitConstraintLocationResponseDto? Location { get; set; }
    public LocationUnitConstraintUnitResponseDto? Unit { get; set; }
}

