using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Delete;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Validators;

public class DeleteProductDepositorValidator : AbstractValidator<DeleteProductDepositorCommand>
{
    public DeleteProductDepositorValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


