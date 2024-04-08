using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

public class UpdateShipmentSubDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DistributorId { get; set; }
    public Guid BranchId { get; set; }
    public Guid ShipmentTypeId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public UpdateDistributorSubDto? Distributor { get; set; }
    public UpdateBranchSubDto? Branch { get; set; }
    public UpdateShipmentTypeSubDto? ShipmentType { get; set; }
    public ICollection<UpdateShipmentAttributeValueSubDto> ShipmentAttributeValues { get; set; }
    public ICollection<UpdateShipmentMemoSubDto> ShipmentMemos { get; set; }
    public ICollection<UpdateOrderShipItemSubDto> OrderShipItems { get; set; }

}

