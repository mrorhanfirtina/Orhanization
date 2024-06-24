using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.CreateDtos;

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

