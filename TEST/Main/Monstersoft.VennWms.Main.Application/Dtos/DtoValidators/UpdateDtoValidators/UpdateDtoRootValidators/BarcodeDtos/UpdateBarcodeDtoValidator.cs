using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.BarcodeDtos;

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



