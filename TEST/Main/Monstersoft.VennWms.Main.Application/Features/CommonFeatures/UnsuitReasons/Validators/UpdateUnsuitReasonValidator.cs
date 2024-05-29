using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Validators;

public class UpdateUnsuitReasonValidator : AbstractValidator<UpdateUnsuitReasonCommand>
{
    public UpdateUnsuitReasonValidator()
    {
        RuleFor(x => x.UnsuitReason).SetValidator(new UpdateUnsuitReasonDtoValidator());
    }
}
