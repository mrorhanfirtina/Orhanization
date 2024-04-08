namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReceiptDtos;

public class CreateReceiptAttributeValueDto
{
    public Guid ReceiptId { get; set; }
    public Guid ReceiptAttributeId { get; set; }
    public string Value { get; set; }
}

