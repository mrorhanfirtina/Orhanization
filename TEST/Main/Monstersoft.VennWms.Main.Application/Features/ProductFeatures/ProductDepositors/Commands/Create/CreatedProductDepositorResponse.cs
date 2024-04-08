namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Create;

public class CreatedProductDepositorResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime CreatedDate { get; set; }
}


