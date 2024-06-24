using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Validators;

public class UpdateDepositorCompanyValidator : AbstractValidator<UpdateDepositorCompanyCommand>
{
    public UpdateDepositorCompanyValidator()
    {
        RuleFor(x => x.DepositorCompany).SetValidator(new UpdateDepositorCompanyDtoValidator());
    }
}
