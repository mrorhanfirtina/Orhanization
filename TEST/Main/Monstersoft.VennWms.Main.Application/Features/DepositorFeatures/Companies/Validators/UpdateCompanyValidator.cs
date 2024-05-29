using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Validators;

public class UpdateCompanyValidator : AbstractValidator<UpdateCompanyCommand>
{
    public UpdateCompanyValidator()
    {
        RuleFor(x => x.Company).SetValidator(new UpdateCompanyDtoValidator());
    }
}
