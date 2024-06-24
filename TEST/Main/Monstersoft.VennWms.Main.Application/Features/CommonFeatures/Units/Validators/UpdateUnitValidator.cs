using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Validators;

public class UpdateUnitValidator : AbstractValidator<UpdateUnitCommand>
{
    public UpdateUnitValidator()
    {
        RuleFor(x => x.Unit).SetValidator(new UpdateUnitDtoValidator());
    }
}
