namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReceiptDtos;

public class UpdateReceiptAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReceiptAttributeId { get; set; }
    public string Value { get; set; }
}

