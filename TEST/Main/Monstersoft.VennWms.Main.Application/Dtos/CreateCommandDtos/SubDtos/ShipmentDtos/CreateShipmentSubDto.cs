﻿using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

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

