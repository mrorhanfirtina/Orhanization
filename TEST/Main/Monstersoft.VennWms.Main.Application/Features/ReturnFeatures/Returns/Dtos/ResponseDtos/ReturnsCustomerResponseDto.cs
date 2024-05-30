namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.ResponseDtos;

public class ReturnsCustomerResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public Guid AddressId { get; set; }
    public ReturnsAddressResponseDto? Address { get; set; }
    public ReturnsCompanyResponseDto? Company { get; set; }
}