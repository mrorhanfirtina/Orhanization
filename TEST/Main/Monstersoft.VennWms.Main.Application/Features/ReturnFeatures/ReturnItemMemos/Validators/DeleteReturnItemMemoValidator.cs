using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Validators;

public class DeleteReturnItemMemoValidator : AbstractValidator<DeleteReturnItemMemoCommand>
{
    public DeleteReturnItemMemoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
