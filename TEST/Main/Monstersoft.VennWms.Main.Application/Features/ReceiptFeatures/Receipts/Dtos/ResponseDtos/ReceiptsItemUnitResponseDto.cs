namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.ResponseDtos;

public class ReceiptsItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public ReceiptsUnitResponseDto? Unit { get; set; }
}

