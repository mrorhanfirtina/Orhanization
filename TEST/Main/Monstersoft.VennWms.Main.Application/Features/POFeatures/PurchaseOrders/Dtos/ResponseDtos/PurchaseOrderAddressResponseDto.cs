﻿namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.ResponseDtos;

public class PurchaseOrderAddressResponseDto
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string AddressText { get; set; }
    public string ZipCode { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }

}
