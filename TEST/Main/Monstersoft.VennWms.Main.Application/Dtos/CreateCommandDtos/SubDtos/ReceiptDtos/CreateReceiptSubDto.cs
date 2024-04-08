namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ReceiptDtos;

public class CreateReceiptSubDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public CreateReceiptTypeSubDto? ReceiptType { get; set; }
    public ICollection<CreateReceiptAttributeValueSubDto> ReceiptAttributeValues { get; set; }
    public ICollection<CreateReceiptItemSubDto> ReceiptItems { get; set; }
    public ICollection<CreateReceiptMemoSubDto> ReceiptMemos { get; set; }

}

