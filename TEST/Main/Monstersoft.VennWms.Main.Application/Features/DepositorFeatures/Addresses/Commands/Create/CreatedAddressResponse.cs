namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Create;

public class CreatedAddressResponse
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string AddressText { get; set; }
    public string ZipCode { get; set; }
    public DateTime CreatedDate { get; set; }

}

