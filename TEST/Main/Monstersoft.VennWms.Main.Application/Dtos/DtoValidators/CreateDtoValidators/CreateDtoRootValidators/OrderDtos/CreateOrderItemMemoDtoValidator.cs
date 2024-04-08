using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.OrderDtos;

public class CreateOrderItemMemoDtoValidator : AbstractValidator<CreateOrderItemMemoDto>
{
    public CreateOrderItemMemoDtoValidator()
    {
        RuleFor(p => p.OrderItemId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}



