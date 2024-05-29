using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Validators;

public class CreateOrderPriorityValidator : AbstractValidator<CreateOrderPriorityCommand>
{
    public CreateOrderPriorityValidator()
    {
        RuleFor(x => x.OrderPriority).SetValidator(new CreateOrderPriorityDtoValidator());
    }
}


