using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Validators;

public class CreateLocationStockAttributeValidator : AbstractValidator<CreateLocationStockAttributeCommand>
{
    public CreateLocationStockAttributeValidator()
    {
        RuleFor(x => x.LocationStockAttribute).SetValidator(new CreateLocationStockAttributeDtoValidator());
    }
}
