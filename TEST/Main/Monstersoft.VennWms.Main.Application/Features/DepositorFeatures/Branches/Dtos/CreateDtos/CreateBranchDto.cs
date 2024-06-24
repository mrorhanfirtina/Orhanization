﻿using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.CreateDtos;

public class CreateBranchDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid DistributorId { get; set; }
    public CreateAddressSubDto Address { get; set; }
}

