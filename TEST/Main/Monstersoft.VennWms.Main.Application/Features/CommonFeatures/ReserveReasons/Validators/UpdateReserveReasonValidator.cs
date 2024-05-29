using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Validators;

public class UpdateReserveReasonValidator : AbstractValidator<UpdateReserveReasonCommand>
{
    public UpdateReserveReasonValidator()
    { 
        RuleFor(x => x.ReserveReason).SetValidator(new UpdateReserveReasonDtoValidator());
    }
}
