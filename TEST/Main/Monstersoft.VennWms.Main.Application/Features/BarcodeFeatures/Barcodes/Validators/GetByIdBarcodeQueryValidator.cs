using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Validators;

public class GetByIdBarcodeQueryValidator : AbstractValidator<GetByIdBarcodeQuery>
{
    public GetByIdBarcodeQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
