using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Validators;

public class UpdateUnsuitReasonValidator : AbstractValidator<UpdateUnsuitReasonCommand>
{
    public UpdateUnsuitReasonValidator()
    {
        RuleFor(x => x.UnsuitReason).SetValidator(new UpdateUnsuitReasonDtoValidator());
    }
}
