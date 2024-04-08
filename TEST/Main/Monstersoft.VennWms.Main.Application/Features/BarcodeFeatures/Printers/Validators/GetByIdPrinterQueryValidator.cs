using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Validators;

public class GetByIdPrinterQueryValidator : AbstractValidator<GetByIdPrinterQuery>
{
    public GetByIdPrinterQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
