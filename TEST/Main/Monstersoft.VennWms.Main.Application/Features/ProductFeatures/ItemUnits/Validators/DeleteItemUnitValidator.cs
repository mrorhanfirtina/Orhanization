using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features;

public class DeleteItemUnitValidator : AbstractValidator<DeleteItemUnitCommand>
{
    public DeleteItemUnitValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
