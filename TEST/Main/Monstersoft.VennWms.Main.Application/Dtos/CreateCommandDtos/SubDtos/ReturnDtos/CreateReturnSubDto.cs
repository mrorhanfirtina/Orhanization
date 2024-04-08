using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ReturnDtos;

public class CreateReturnSubDto
{
    public string Code { get; set; }
    public Guid CustomerId { get; set; }
    public int StatusId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid ReturnTypeId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public CreateCustomerSubDto? Customer { get; set; }
    public ICollection<CreateReturnAttributeValueSubDto> ReturnAttributeValues { get; set; }
    public ICollection<CreateReturnItemSubDto> ReturnItems { get; set; }
    public ICollection<CreateReturnMemoSubDto> ReturnMemos { get; set; }
}

