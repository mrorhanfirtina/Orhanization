namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.ResponseDtos;

public class BranchDistributorResponseDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public BranchCompanyResponseDto? Company { get; set; }
}
