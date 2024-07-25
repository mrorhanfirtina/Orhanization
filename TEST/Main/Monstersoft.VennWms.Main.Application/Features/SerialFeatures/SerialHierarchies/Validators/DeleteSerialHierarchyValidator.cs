using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Validators;

public class DeleteSerialHierarchyValidator : AbstractValidator<DeleteSerialHierarchyCommand>
{
    public DeleteSerialHierarchyValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
