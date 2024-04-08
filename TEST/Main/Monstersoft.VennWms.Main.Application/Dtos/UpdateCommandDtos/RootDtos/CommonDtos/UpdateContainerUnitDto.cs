using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.CommonDtos;

public class UpdateContainerUnitDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string FirstDigit { get; set; }
    public string CountryCode { get; set; }
    public string ProducerCode { get; set; }
    public string Counter { get; set; }
}

