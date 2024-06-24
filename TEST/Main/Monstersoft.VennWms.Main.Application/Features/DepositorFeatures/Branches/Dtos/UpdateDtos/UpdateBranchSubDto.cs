﻿using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures;

public class UpdateBranchSubDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid DistributorId { get; set; }
    public Guid AddressId { get; set; }
    public virtual UpdateAddressSubDto? Address { get; set; }
}


