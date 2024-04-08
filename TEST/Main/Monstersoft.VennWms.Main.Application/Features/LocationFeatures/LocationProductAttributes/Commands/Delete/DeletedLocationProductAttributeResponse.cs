namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Delete;

public class DeletedLocationProductAttributeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

