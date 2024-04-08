using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Validators;

public class DeleteOrderTypeValidator : AbstractValidator<DeleteOrderTypeCommand>
{
    public DeleteOrderTypeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
