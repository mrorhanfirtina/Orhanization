using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Create;

public class CreatedReceiptTypeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public ICollection<Receipt> Receipts { get; set; }

}

