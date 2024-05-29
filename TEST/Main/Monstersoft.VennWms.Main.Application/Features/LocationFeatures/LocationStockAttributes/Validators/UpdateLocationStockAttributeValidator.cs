using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Validators;

public class UpdateLocationStockAttributeValidator : AbstractValidator<UpdateLocationStockAttributeCommand>
{
    public UpdateLocationStockAttributeValidator()
    {
        RuleFor(x => x.LocationStockAttribute).SetValidator(new UpdateLocationStockAttributeDtoValidator());
    }
}
