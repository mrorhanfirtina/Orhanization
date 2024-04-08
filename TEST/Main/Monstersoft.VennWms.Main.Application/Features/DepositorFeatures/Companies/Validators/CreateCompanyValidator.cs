using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Validators;

public class CreateCompanyValidator : AbstractValidator<CreateCompanyCommand>
{
    public CreateCompanyValidator()
    {
        RuleFor(x => x.Company).SetValidator(new CreateCompanyDtoValidator());
    }
}
