using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;

public class CreatedContainerUnitResponse
{
    public int Id { get; set; }
    public string Code { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Description { get; set; }
    public string FirstDigit { get; set; }
    public string CountryCode { get; set; }
    public string ProducerCode { get; set; }
    public string Counter { get; set; }
    public Guid DepositorId { get; set; }
}
