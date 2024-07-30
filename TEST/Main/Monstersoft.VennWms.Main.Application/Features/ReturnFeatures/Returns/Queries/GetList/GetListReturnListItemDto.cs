using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetList;

public class GetListReturnListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid CustomerId { get; set; }
    public int StatusId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReturnTypeId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ReceiveDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ReturnsCustomerResponseDto? Customer { get; set; }
    public ReturnsReturnTypeResponseDto? ReturnType { get; set; }
    public ICollection<ReturnsReturnAttributeValueResponseDto>? ReturnAttributeValues { get; set; }
    public ICollection<ReturnsReturnMemoResponseDto>? ReturnMemos { get; set; }
    public ReturnsDepositorResponseDto Depositor { get; set; }
    public DepositorCompanyResponseDto DepositorCompany { get; set; }
    public ReturnsStatusResponseDto Status { get; set; }
}
