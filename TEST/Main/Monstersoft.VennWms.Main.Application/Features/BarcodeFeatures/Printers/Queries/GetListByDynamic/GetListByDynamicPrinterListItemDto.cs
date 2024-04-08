namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetListByDynamic;

public class GetListByDynamicPrinterListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string PrinterAddress { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
