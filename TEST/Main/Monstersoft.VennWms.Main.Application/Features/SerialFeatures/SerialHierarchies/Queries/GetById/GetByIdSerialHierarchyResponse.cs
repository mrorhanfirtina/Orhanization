using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Queries.GetById;

public class GetByIdSerialHierarchyResponse
{
    public Guid Id { get; set; }
    public Guid RootSerialId { get; set; }
    public Guid ChildSerialId { get; set; }
    public SerialHiererchyRootSerialResponseDto? RootSerial { get; set; }
    public SerialHiererchyChildSerialResponseDto? ChildSerial { get; set; }
}
