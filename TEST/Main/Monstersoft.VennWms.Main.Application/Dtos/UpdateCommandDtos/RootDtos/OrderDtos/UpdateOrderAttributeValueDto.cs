namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;

public class UpdateOrderAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid OrderAttributeId { get; set; }
    public string Value { get; set; }

}

