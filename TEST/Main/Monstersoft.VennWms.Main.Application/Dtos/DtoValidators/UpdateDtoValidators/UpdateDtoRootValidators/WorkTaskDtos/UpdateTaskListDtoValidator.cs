using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.WorkTaskDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.WorkTaskDtos;

public class UpdateTaskListDtoValidator : AbstractValidator<UpdateTaskListDto>
{
    public UpdateTaskListDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.WorkTasks).SetValidator(new UpdateWorkTaskSubDtoValidator());
    }
}



