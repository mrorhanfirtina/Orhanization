using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Validators;

public class UpdateReserveReasonValidator : AbstractValidator<UpdateReserveReasonCommand>
{
    public UpdateReserveReasonValidator()
    { 
        RuleFor(x => x.ReserveReason).SetValidator(new UpdateReserveReasonDtoValidator());
    }
}
