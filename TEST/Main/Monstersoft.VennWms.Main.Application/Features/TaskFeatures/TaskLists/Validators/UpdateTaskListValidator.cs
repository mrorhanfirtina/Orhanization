using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Validators;

public class UpdateTaskListValidator : AbstractValidator<UpdateTaskListCommand>
{
    public UpdateTaskListValidator()
    {
        RuleFor(x => x.TaskList).SetValidator(new UpdateTaskListDtoValidator());
    }
}
