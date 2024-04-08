using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ContainerUnit : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string FirstDigit { get; set; }
    public string CountryCode { get; set; }
    public string ProducerCode { get; set; }
    public string Counter { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public ContainerUnit()
    {
        
    }

    public ContainerUnit(int id, string code, string description, string firstDigit, string countryCode, string producerCode, string counter, Guid depositorCompanyId):this()
    {
        Id = id;
        Code = code;
        Description = description;
        FirstDigit = firstDigit;
        CountryCode = countryCode;
        ProducerCode = producerCode;
        Counter = counter;
        DepositorCompanyId = depositorCompanyId;
    }
}



