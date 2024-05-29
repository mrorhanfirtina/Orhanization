using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.DtoValidators;

public class CreateTaskListDtoValidator : AbstractValidator<CreateTaskListDto>
{
    public CreateTaskListDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.WorkTasks).SetValidator(new CreateWorkTaskSubDtoValidator());
    }
}



