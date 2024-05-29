using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Validators;

public class UpdateTaskListValidator : AbstractValidator<UpdateTaskListCommand>
{
    public UpdateTaskListValidator()
    {
        RuleFor(x => x.TaskList).SetValidator(new UpdateTaskListDtoValidator());
    }
}
