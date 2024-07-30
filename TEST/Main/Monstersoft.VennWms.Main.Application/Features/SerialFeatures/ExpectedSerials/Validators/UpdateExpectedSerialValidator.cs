using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Validators;

public class UpdateExpectedSerialValidator : AbstractValidator<UpdateExpectedSerialCommand>
{
    public UpdateExpectedSerialValidator()
    {
        RuleFor(x => x.ExpectedSerial).SetValidator(new UpdateExpectedSerialDtoValidator());
    }
}
