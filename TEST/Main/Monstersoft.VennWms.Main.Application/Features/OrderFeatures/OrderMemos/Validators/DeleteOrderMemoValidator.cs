using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Validators;

public class DeleteOrderMemoValidator : AbstractValidator<DeleteOrderMemoCommand>
{
    public DeleteOrderMemoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
