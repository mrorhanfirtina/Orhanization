using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Validators;

public class DeleteBarcodeValidator : AbstractValidator<DeleteBarcodeCommand>
{
    public DeleteBarcodeValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
