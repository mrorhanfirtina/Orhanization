using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.DtoValidators;

public class UpdateOrderPrioritySubDtoValidator : AbstractValidator<UpdateOrderPrioritySubDto>
{
    public UpdateOrderPrioritySubDtoValidator()
    {
        RuleFor(p => p.PriorityId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
