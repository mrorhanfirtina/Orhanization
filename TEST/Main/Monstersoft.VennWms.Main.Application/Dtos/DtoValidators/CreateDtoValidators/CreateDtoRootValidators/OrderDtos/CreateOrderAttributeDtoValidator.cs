using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.OrderDtos;

public class CreateOrderAttributeDtoValidator : AbstractValidator<CreateOrderAttributeDto>
{
    public CreateOrderAttributeDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.AttributeInputTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsNecessary).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.IsItemAttribte).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



