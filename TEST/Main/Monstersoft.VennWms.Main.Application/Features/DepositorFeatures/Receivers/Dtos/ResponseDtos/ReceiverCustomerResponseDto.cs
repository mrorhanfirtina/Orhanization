namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.ResponseDtos;

public class ReceiverCustomerResponseDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public ReceiverCompanyResponseDto? Company { get; set; }
}
