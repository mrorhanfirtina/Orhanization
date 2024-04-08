using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Validators;

public class UpdateBarcodeAreaValidator : AbstractValidator<UpdateBarcodeAreaCommand>
{
    public UpdateBarcodeAreaValidator()
    {
        RuleFor(x => x.BarcodeArea).SetValidator(new UpdateBarcodeAreaDtoValidator());
    }
}

