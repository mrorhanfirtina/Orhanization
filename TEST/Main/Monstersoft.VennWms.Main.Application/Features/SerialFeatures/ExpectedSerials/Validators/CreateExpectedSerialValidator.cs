using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Validators;

public class CreateExpectedSerialValidator : AbstractValidator<CreateExpectedSerialCommand>
{
    public CreateExpectedSerialValidator()
    {
        RuleFor(x => x.ExpectedSerial).SetValidator(new CreateExpectedSerialDtoValidator());
    }
}
