namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.UpdateDtos;

public class UpdateSerialDto
{
    public Guid Id { get; set; }
    public Guid StockPackTypeId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReceiptItemId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
}
