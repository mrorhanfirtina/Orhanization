using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Validators;

public class DeleteReturnTypeValidator : AbstractValidator<DeleteReturnTypeCommand>
{
    public DeleteReturnTypeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
