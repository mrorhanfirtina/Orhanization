using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.DtoValidators;

public class CreateOrderTypeDtoValidator : AbstractValidator<CreateOrderTypeDto>
{
    public CreateOrderTypeDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsCodeGenerate).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.Format).NotEmpty().NotNull().MaximumLength(20);
        RuleFor(p => p.Counter).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}



