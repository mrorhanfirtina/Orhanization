namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;

public class ShipmentsDistributorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid AddressId { get; set; }
    public ShipmentsAddressResponseDto? Address { get; set; }
    public ShipmentsCompanyResponseDto? Company { get; set; }
}