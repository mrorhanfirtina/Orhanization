using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Create;

public class CreatedSerialResponse
{
    public Guid Id { get; set; }
    public Guid StockPackTypeId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReceiptItemId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
    public SerialStockPackTypeResponseDto? StockPackType { get; set; }
    public SerialDepositorResponseDto? Depositor { get; set; }
    public SerialDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public SerialReceiptResponseDto? Receipt { get; set; }
    public SerialReceiptItemResponseDto? ReceiptItem { get; set; }
    public ICollection<SerialSerialHierarchyResponseDto>? SerialHierarchies { get; set; }
}
