using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReturnDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;

public class UpdateReturnDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid CustomerId { get; set; }
    public int StatusId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid ReturnTypeId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public UpdateCustomerSubDto? Customer { get; set; }
    public ICollection<UpdateReturnAttributeValueSubDto> ReturnAttributeValues { get; set; }
    public ICollection<UpdateReturnItemSubDto> ReturnItems { get; set; }
    public ICollection<UpdateReturnMemoSubDto> ReturnMemos { get; set; }

}

