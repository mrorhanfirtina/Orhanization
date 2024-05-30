using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetById;

public class GetByIdReceiptTypeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<ReceiptTypesReceiptResponseDto>? Receipts { get; set; }
    public ReceiptTypesDepositorCompanyResponseDto? DepositorCompany { get; set; }
}

