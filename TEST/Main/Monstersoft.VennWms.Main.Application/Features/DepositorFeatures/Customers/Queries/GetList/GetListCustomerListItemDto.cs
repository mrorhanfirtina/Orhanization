using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetList;

public class GetListCustomerListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public CustomerDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public CustomerAddressResponseDto? Address { get; set; }
    public CustomerCompanyResponseDto? Company { get; set; }
    public ICollection<CustomerReceiverResponseDto>? Receivers { get; set; }

}
