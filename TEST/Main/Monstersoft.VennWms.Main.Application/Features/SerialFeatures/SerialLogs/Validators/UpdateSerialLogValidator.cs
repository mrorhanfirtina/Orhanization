using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Validators;

public class UpdateSerialLogValidator : AbstractValidator<UpdateSerialLogCommand>
{
    public UpdateSerialLogValidator()
    {
        RuleFor(x => x.SerialLog).SetValidator(new UpdateSerialLogDtoValidator());
    }
}
