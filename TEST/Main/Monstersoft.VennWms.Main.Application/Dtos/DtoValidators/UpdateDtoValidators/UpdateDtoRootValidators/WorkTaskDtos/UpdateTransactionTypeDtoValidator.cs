using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.WorkTaskDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.WorkTaskDtos;

public class UpdateTransactionTypeDtoValidator : AbstractValidator<UpdateTransactionTypeDto>
{
    public UpdateTransactionTypeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(10);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsLogging).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



