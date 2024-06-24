using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Validators;

public class CreateDepositorCompanyValidator : AbstractValidator<CreateDepositorCompanyCommand>
{
    public CreateDepositorCompanyValidator()
    {
        RuleFor(x => x.DepositorCompany).SetValidator(new CreateDepositorCompanyDtoValidator());
    }
}
