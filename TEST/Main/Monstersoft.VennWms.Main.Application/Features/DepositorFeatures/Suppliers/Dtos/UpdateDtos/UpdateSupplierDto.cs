using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures;

public class UpdateSupplierDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public UpdateAddressSubDto Address { get; set; }
}

