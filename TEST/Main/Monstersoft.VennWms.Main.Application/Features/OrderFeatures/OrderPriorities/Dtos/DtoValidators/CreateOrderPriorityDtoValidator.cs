using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.DtoValidators;

public class CreateOrderPriorityDtoValidator : AbstractValidator<CreateOrderPriorityDto>
{
    public CreateOrderPriorityDtoValidator()
    {
        RuleFor(p => p.OrderId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.PriorityId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
