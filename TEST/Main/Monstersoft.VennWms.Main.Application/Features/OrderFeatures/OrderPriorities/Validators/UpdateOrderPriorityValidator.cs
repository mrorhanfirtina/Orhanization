using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Validators;

public class UpdateOrderPriorityValidator : AbstractValidator<UpdateOrderPriorityCommand>
{
    public UpdateOrderPriorityValidator()
    {
        RuleFor(x => x.OrderPriority).SetValidator(new UpdateOrderPriorityDtoValidator());
    }
}


