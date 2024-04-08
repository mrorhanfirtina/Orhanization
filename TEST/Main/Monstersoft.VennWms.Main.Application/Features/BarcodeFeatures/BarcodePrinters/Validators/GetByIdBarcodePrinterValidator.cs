using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Validators;

public class GetByIdBarcodePrinterValidator : AbstractValidator<GetByIdBarcodePrinterQuery>
{
    public GetByIdBarcodePrinterValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
