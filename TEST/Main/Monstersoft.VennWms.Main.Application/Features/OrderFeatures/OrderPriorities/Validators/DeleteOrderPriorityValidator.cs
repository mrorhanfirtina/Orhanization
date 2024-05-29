using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Validators;

public class DeleteOrderPriorityValidator : AbstractValidator<DeleteOrderPriorityCommand>
{
    public DeleteOrderPriorityValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


