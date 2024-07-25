namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.ResponseDtos;

public class SerialStockResponseDto
{
    public Guid Id { get; set; }
    public Guid StockContainerId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public Guid LocationId { get; set; }
    public SerialLocationResponseDto? Location { get; set; }
    public SerialStockContainerResponseDto? StockContainer { get; set; }
}
