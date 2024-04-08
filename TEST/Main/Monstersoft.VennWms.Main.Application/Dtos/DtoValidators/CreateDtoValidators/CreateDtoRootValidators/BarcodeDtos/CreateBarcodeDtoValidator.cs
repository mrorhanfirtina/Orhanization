using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.BarcodeDtos;

public class CreateBarcodeDtoValidator : AbstractValidator<CreateBarcodeDto>
{
    public CreateBarcodeDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Copy).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Query).NotEmpty().NotNull();
        RuleFor(p => p.Text).NotEmpty().NotNull();
        RuleForEach(x => x.BarcodeAreas).SetValidator(new CreateBarcodeAreaSubDtoValidator());
        RuleForEach(x => x.BarcodePrinters).SetValidator(new CreateBarcodePrinterSubDtoValidator());
    }
}



