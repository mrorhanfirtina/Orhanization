using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.DtoValidators;

public class UpdateBarcodeDtoValidator : AbstractValidator<UpdateBarcodeDto>
{
    public UpdateBarcodeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Copy).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Query).NotEmpty().NotNull();
        RuleFor(p => p.Text).NotEmpty().NotNull();
        RuleForEach(x => x.BarcodeAreas).SetValidator(new UpdateBarcodeAreaSubDtoValidator());
        RuleForEach(x => x.BarcodePrinters).SetValidator(new UpdateBarcodePrinterSubDtoValidator());
    }
}



