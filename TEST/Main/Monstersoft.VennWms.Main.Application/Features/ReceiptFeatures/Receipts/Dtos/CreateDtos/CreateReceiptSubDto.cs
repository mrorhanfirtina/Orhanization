using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.CreateDtos;

public class CreateReceiptSubDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public Guid SupplierId { get; set; }
    public CreateReceiptTypeSubDto? ReceiptType { get; set; }
    public ICollection<CreateReceiptAttributeValueSubDto> ReceiptAttributeValues { get; set; }
    public ICollection<CreateReceiptItemSubDto> ReceiptItems { get; set; }
    public ICollection<CreateReceiptMemoSubDto> ReceiptMemos { get; set; }

}

