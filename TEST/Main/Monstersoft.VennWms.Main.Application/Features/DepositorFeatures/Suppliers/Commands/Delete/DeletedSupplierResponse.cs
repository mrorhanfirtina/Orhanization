namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Delete;

public class DeletedSupplierResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

