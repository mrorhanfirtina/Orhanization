using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReturnDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;

public class UpdateReturnTypeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public int Counter { get; set; }
    public string Format { get; set; }
    public ICollection<UpdateReturnSubDto> Returns { get; set; }
}

