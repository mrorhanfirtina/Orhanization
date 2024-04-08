using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Validators;

public class GetByCodePrinterQueryValidator : AbstractValidator<GetByCodePrinterQuery>
{
    public GetByCodePrinterQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

