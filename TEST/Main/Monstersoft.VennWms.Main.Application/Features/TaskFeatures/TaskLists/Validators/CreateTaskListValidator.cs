using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Validators;

public class CreateTaskListValidator : AbstractValidator<CreateTaskListCommand>
{
    public CreateTaskListValidator()
    {
        RuleFor(x => x.TaskList).SetValidator(new CreateTaskListDtoValidator());
    }
}
