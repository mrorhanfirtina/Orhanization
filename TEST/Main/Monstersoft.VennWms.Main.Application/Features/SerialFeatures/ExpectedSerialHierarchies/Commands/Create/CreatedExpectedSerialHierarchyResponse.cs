using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Create;

public class CreatedExpectedSerialHierarchyResponse
{
    public Guid Id { get; set; }
    public Guid RootSerialId { get; set; }
    public Guid ChildSerialId { get; set; }
    public ExpectedSerialHierarchyRootSerialResponseDto? RootSerial { get; set; }
    public ExpectedSerialHierarchyChildSerialResponseDto? ChildSerial { get; set; }
}
