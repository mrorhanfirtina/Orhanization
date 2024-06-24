using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Validators;

public class DeleteReturnValidator : AbstractValidator<DeleteReturnCommand>
{
    public DeleteReturnValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
