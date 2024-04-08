using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Validators;

public class CreateUnitValidator : AbstractValidator<CreateUnitCommand>
{
    public CreateUnitValidator()
    {
        RuleFor(x => x.Unit).SetValidator(new CreateUnitDtoValidator());
    }
}
