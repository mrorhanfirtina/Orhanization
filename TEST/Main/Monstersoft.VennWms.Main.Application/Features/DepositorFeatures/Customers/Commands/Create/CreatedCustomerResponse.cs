﻿using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Create;

public class CreatedCustomerResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public Guid AddressId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public CustomerDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public CustomerAddressResponseDto? Address { get; set; }
    public CustomerCompanyResponseDto? Company { get; set; }
    public ICollection<CustomerReceiverResponseDto>? Receivers { get; set; }

}
