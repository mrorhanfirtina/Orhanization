using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.UpdateDtos;

public class UpdateReceiptSubDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public Guid SupplierId { get; set; }
    public UpdateReceiptTypeSubDto? ReceiptType { get; set; }
    public ICollection<UpdateReceiptAttributeValueSubDto> ReceiptAttributeValues { get; set; }
    public ICollection<UpdateReceiptItemSubDto> ReceiptItems { get; set; }
    public ICollection<UpdateReceiptMemoSubDto> ReceiptMemos { get; set; }

}

