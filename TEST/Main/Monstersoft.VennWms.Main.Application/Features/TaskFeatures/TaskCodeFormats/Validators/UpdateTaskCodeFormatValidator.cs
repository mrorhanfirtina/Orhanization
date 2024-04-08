using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Validators;

public class UpdateTaskCodeFormatValidator : AbstractValidator<UpdateTaskCodeFormatCommand>
{
    public UpdateTaskCodeFormatValidator()
    {
        RuleFor(x => x.TaskCodeFormat).SetValidator(new UpdateTaskCodeFormatDtoValidator());
    }
}
