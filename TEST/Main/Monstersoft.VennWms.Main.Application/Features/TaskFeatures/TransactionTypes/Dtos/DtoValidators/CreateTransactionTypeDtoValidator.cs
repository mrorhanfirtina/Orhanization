using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Dtos.DtoValidators;

public class CreateTransactionTypeDtoValidator : AbstractValidator<CreateTransactionTypeDto>
{
    public CreateTransactionTypeDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(10);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsLogging).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.IsTaskType).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.IsOperational).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



