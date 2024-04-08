using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Validators;

public class UpdateDepositorCompanyValidator : AbstractValidator<UpdateDepositorCompanyCommand>
{
    public UpdateDepositorCompanyValidator()
    {
        RuleFor(x => x.DepositorCompany).SetValidator(new UpdateDepositorCompanyDtoValidator());
    }
}
