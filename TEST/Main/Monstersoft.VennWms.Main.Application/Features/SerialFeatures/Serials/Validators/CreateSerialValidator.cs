using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Validators;

public class CreateSerialValidator : AbstractValidator<CreateSerialCommand>
{
    public CreateSerialValidator()
    {
        RuleFor(x => x.Serial).SetValidator(new CreateSerialDtoValidator());
    }
}
