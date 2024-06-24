using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Validators;

public class CreateTaskListValidator : AbstractValidator<CreateTaskListCommand>
{
    public CreateTaskListValidator()
    {
        RuleFor(x => x.TaskList).SetValidator(new CreateTaskListDtoValidator());
    }
}
