using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Validators;

public class UpdateCompanyValidator : AbstractValidator<UpdateCompanyCommand>
{
    public UpdateCompanyValidator()
    {
        RuleFor(x => x.Company).SetValidator(new UpdateCompanyDtoValidator());
    }
}
