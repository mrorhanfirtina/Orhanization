using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Validators;

public class CreateUnitValidator : AbstractValidator<CreateUnitCommand>
{
    public CreateUnitValidator()
    {
        RuleFor(x => x.Unit).SetValidator(new CreateUnitDtoValidator());
    }
}
