using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Validators;

public class DeleteLocationProductAttributeValidator : AbstractValidator<DeleteLocationProductAttributeCommand>
{
    public DeleteLocationProductAttributeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
