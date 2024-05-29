namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.UpdateDtos;

public class UpdateOrderTypeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
}

