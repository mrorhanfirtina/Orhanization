using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Validators;

public class DeleteOrderAttributeValueValidator : AbstractValidator<DeleteOrderAttributeValueCommand>
{
    public DeleteOrderAttributeValueValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
