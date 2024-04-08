namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;

public class CreateOrderAttributeValueDto
{
    public Guid OrderId { get; set; }
    public Guid OrderAttributeId { get; set; }
    public string Value { get; set; }

}

