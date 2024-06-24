using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Validators;

public class CreateReserveReasonValidator : AbstractValidator<CreateReserveReasonCommand>
{
    public CreateReserveReasonValidator()
    {
        RuleFor(x => x.ReserveReason).SetValidator(new CreateReserveReasonDtoValidator());
    }
}
