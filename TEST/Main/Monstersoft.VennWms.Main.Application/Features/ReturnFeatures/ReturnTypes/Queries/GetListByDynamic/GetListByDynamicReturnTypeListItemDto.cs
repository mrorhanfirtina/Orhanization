using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetListByDynamic;

public class GetListByDynamicReturnTypeListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsCodeGenerate { get; set; }
    public int Counter { get; set; }
    public string Format { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<Return> Returns { get; set; }

}
