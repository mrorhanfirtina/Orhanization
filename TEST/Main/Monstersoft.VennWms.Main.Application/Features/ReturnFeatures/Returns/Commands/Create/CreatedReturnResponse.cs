using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Create;

public class CreatedReturnResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid CustomerId { get; set; }
    public int StatusId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReturnTypeId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ReceiveDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public ReturnType ReturnType { get; set; }
    public Customer Customer { get; set; }
    public ICollection<ReturnAttributeValue> ReturnAttributeValues { get; set; }
    public ICollection<ReturnItem> ReturnItems { get; set; }
    public ICollection<ReturnMemo> ReturnMemos { get; set; }

}
