using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.WorkTaskDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.WorkTaskDtos;

public class UpdateTaskCodeFormatDtoValidator : AbstractValidator<UpdateTaskCodeFormatDto>
{
    public UpdateTaskCodeFormatDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(10);

        RuleFor(p => p.TaskFormat).NotEmpty().NotNull().MaximumLength(20)
            .Matches("^[0-9]*0{0,10}$").WithMessage("{PropertyName} sağdan son 10 rakam sadece sıfır olabilir.");

        RuleFor(p => p.TaskCounter).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.TaskListFormat).NotEmpty().NotNull().MaximumLength(20)
            .Matches("^[0-9]*0{0,10}$").WithMessage("{PropertyName} sağdan son 10 rakam sadece sıfır olabilir.");

        RuleFor(p => p.TaskListCounter).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.TransactionTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
