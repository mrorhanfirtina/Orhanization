namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.UpdateDtos;

public class UpdateSerialHierarchyDto
{
    public Guid Id { get; set; }
    public Guid RootSerialId { get; set; }
    public Guid ChildSerialId { get; set; }
}
