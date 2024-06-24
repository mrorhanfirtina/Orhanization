using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features;

public class DeleteOrderValidator : AbstractValidator<DeleteOrderCommand>
{
    public DeleteOrderValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
