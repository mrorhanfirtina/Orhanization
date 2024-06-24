using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.DtoValidators;

public class CreateOrderPrioritySubDtoValidator : AbstractValidator<CreateOrderPrioritySubDto>
{
    public CreateOrderPrioritySubDtoValidator()
    {
        RuleFor(p => p.PriorityId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
