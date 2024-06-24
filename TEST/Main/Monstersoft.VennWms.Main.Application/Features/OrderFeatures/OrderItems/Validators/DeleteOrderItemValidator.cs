using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Validators;

public class DeleteOrderItemValidator : AbstractValidator<DeleteOrderItemCommand>
{
    public DeleteOrderItemValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
