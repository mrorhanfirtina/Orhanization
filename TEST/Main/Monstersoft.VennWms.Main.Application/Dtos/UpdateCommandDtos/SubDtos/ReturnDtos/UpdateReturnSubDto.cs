using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReturnDtos;

public class UpdateReturnSubDto
{
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

