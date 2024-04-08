using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

public class Printer : Entity<Guid>
{
    public string Code { get; set; }
    public string PrinterAddress { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public Printer()
    {

    }

    public Printer(Guid id,string code, Guid depositorCompanyId , string printerAddress): this()
    {
        Id = id;
        Code = code;
        DepositorCompanyId = depositorCompanyId;
        PrinterAddress = printerAddress;
    }
}
