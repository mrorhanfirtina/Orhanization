using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures;

public class CreateShipmentSubDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DistributorId { get; set; }
    public Guid BranchId { get; set; }
    public Guid ShipmentTypeId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public CreateDistributorSubDto? Distributor { get; set; }
    public CreateBranchSubDto? Branch { get; set; }
    public CreateShipmentTypeSubDto? ShipmentType { get; set; }
    public ICollection<CreateShipmentAttributeValueSubDto> ShipmentAttributeValues { get; set; }
    public ICollection<CreateShipmentMemoSubDto> ShipmentMemos { get; set; }
    public ICollection<CreateOrderShipItemSubDto> OrderShipItems { get; set; }

}


