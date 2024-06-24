using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Validators;

public class CreateWorkTaskValidator : AbstractValidator<CreateWorkTaskCommand>
{
    public CreateWorkTaskValidator()
    {
        RuleFor(x => x.WorkTask).SetValidator(new CreateWorkTaskDtoValidator());
    }
}
