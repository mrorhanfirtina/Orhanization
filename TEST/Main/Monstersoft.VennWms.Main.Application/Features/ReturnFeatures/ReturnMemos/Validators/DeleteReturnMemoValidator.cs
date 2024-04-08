using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Validators;

public class DeleteReturnMemoValidator : AbstractValidator<DeleteReturnMemoCommand>
{
    public DeleteReturnMemoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
