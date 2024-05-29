using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Validators;

public class UpdateWorkTaskValidator : AbstractValidator<UpdateWorkTaskCommand>
{
    public UpdateWorkTaskValidator()
    {
        RuleFor(x => x.WorkTask).SetValidator(new UpdateWorkTaskDtoValidator());
    }
}
