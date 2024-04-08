using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Validators;

public class DeleteLocationStockAttributeValidator : AbstractValidator<DeleteLocationStockAttributeCommand>
{
    public DeleteLocationStockAttributeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
