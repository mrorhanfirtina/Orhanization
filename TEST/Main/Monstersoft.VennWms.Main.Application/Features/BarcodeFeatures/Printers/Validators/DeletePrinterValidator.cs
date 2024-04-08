using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Validators;

public class DeletePrinterValidator : AbstractValidator<DeletePrinterCommand>
{
    public DeletePrinterValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
