using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Validators;

public class GetByCodeBarcodeQueryValidator : AbstractValidator<GetByCodeBarcodeQuery>
{
    public GetByCodeBarcodeQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

