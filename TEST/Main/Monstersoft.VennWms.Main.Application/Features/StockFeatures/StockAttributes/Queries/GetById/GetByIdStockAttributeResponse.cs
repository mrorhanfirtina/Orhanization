using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetById;

public class GetByIdStockAttributeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsNecessary { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public StockAttributesAttributeInputTypeResponseDto? AttributeInputType { get; set; }
    public StockAttributesDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
