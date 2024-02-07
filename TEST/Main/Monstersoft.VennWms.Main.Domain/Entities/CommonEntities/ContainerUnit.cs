using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ContainerUnit : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string FirstDigit { get; set; }
    public string CountryCode { get; set; }
    public string ProducerCode { get; set; }
    public string Counter { get; set; }
    public Guid DepositorId { get; set; }

    public ContainerUnit()
    {
        
    }

    public ContainerUnit(int id, string code, string description, string firstDigit, string countryCode, string producerCode, string counter, Guid depositorId):this()
    {
        Id = id;
        Code = code;
        Description = description;
        FirstDigit = firstDigit;
        CountryCode = countryCode;
        ProducerCode = producerCode;
        Counter = counter;
        DepositorId = depositorId;
    }
}



