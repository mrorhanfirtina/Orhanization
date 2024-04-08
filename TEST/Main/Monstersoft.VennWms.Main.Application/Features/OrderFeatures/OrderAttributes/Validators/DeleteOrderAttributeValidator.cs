using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Validators;

public class DeleteOrderAttributeValidator : AbstractValidator<DeleteOrderAttributeCommand>
{
    public DeleteOrderAttributeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
