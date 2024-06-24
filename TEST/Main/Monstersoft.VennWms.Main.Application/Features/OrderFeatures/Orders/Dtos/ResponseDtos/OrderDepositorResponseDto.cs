namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;

public class OrderDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid CompanyId { get; set; }
    public OrderCompanyResponseDto? Company { get; set; }
}
