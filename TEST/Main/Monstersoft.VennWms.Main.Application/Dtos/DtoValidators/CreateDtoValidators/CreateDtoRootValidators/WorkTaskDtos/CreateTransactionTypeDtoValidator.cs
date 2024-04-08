using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.WorkTaskDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.WorkTaskDtos;

public class CreateTransactionTypeDtoValidator : AbstractValidator<CreateTransactionTypeDto>
{
    public CreateTransactionTypeDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(10);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsLogging).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



