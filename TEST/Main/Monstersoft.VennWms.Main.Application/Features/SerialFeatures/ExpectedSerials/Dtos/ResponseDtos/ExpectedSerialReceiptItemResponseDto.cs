namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.ResponseDtos;

public class ExpectedSerialReceiptItemResponseDto
{
    public Guid Id { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
}