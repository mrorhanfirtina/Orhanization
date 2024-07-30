namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.ResponseDtos;

public class SerialSerialHierarchyResponseDto
{
    public Guid ChildSerialId { get; set; }
    public SerialChildSerialResponseDto? ChildSerial { get; set; }
}
