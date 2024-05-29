﻿using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BuildingDimensions.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.CreateDtos;

public class CreateBuildingDto
{
    public string Code { get; set; }
    public Guid SiteId { get; set; }
    public string Description { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string AddressText { get; set; }
    public string ZipCode { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public virtual CreateBuildingDimensionSubDto? BuildingDimension { get; set; }
}

