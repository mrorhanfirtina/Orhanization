using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Validators;

public class DeleteBarcodeAreaValidator : AbstractValidator<DeleteBarcodeAreaCommand>
{
    public DeleteBarcodeAreaValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
