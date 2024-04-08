using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Validators;

public class DeleteItemPackTypeValidator : AbstractValidator<DeleteItemPackTypeCommand>
{
    public DeleteItemPackTypeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
