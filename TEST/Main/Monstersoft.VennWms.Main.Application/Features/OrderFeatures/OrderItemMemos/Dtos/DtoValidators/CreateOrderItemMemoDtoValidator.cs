using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.DtoValidators;

public class CreateOrderItemMemoDtoValidator : AbstractValidator<CreateOrderItemMemoDto>
{
    public CreateOrderItemMemoDtoValidator()
    {
        RuleFor(p => p.OrderItemId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}



