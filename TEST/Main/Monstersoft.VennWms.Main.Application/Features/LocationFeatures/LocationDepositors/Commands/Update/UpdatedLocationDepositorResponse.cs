using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Update;

public class UpdatedLocationDepositorResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsForbid { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public LocationDepositorLocationResponseDto? Location { get; set; }
    public LocationDepositorDepositorResponseDto? Depositor { get; set; }

}

