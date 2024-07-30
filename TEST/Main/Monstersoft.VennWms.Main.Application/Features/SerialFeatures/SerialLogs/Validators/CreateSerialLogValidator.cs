using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Validators;

public class CreateSerialLogValidator : AbstractValidator<CreateSerialLogCommand>
{
    public CreateSerialLogValidator()
    {
        RuleFor(x => x.SerialLog).SetValidator(new CreateSerialLogDtoValidator());
    }
}
