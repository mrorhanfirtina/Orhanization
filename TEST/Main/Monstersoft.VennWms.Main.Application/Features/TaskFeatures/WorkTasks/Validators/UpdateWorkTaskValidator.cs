using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Validators;

public class UpdateWorkTaskValidator : AbstractValidator<UpdateWorkTaskCommand>
{
    public UpdateWorkTaskValidator()
    {
        RuleFor(x => x.WorkTask).SetValidator(new UpdateWorkTaskDtoValidator());
    }
}
