namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReceiptDtos;

public class UpdateReceiptSubDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public UpdateReceiptTypeSubDto? ReceiptType { get; set; }
    public ICollection<UpdateReceiptAttributeValueSubDto> ReceiptAttributeValues { get; set; }
    public ICollection<UpdateReceiptItemSubDto> ReceiptItems { get; set; }
    public ICollection<UpdateReceiptMemoSubDto> ReceiptMemos { get; set; }

}

