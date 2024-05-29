using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.UpdateDtos;

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

