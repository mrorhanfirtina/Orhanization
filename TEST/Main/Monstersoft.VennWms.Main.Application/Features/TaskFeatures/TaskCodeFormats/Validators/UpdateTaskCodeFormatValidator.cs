using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Validators;

public class UpdateTaskCodeFormatValidator : AbstractValidator<UpdateTaskCodeFormatCommand>
{
    public UpdateTaskCodeFormatValidator()
    {
        RuleFor(x => x.TaskCodeFormat).SetValidator(new UpdateTaskCodeFormatDtoValidator());
    }
}
