using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Validators;

public class UpdateSerialValidator : AbstractValidator<UpdateSerialCommand>
{
    public UpdateSerialValidator()
    {
        RuleFor(x => x.Serial).SetValidator(new UpdateSerialDtoValidator());
    }
}
