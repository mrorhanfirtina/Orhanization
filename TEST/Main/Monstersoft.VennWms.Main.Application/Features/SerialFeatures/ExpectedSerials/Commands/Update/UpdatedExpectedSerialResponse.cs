using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Update;

public class UpdatedExpectedSerialResponse
{
    public Guid ItemUnitId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReceiptItemId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
    public ExpectedSerialItemUnitResponseDto? ItemUnit { get; set; }
    public ExpectedSerialDepositorResponseDto? Depositor { get; set; }
    public ExpectedSerialDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ExpectedSerialReceiptResponseDto? Receipt { get; set; }
    public ExpectedSerialReceiptItemResponseDto? ReceiptItem { get; set; }
}
