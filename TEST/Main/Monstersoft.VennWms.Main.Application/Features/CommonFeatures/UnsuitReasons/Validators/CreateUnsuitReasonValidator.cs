using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Validators;

public class CreateUnsuitReasonValidator : AbstractValidator<CreateUnsuitReasonCommand>
{
    public CreateUnsuitReasonValidator()
    {
        RuleFor(x => x.UnsuitReason).SetValidator(new CreateUnsuitReasonDtoValidator());
    }
}
