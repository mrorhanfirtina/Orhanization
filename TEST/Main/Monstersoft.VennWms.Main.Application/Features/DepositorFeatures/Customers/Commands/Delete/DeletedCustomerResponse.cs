namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Delete;

public class DeletedCustomerResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
