using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.CreateDtos;

public class CreateReturnTypeDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public int Counter { get; set; }
    public string Format { get; set; }
    public ICollection<CreateReturnSubDto> Returns { get; set; }
}

