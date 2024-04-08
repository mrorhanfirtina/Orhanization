using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;

public class UpdateOrderTypeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public ICollection<UpdateOrderSubDto>? Orders { get; set; }
}

