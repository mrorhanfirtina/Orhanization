using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Validators;

public class DeleteLocationProductCategoryValidator : AbstractValidator<DeleteLocationProductCategoryCommand>
{
    public DeleteLocationProductCategoryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

