using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Validators;

public class CreateBarcodeAreaValidator : AbstractValidator<CreateBarcodeAreaCommand>
{
    public CreateBarcodeAreaValidator()
    {
        RuleFor(x => x.BarcodeArea).SetValidator(new CreateBarcodeAreaDtoValidator());
    }
}

