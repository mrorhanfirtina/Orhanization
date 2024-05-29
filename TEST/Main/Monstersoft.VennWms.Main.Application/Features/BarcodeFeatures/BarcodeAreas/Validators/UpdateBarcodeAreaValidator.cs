using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Validators;

public class UpdateBarcodeAreaValidator : AbstractValidator<UpdateBarcodeAreaCommand>
{
    public UpdateBarcodeAreaValidator()
    {
        RuleFor(x => x.BarcodeArea).SetValidator(new UpdateBarcodeAreaDtoValidator());
    }
}

