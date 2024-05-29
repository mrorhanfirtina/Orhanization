using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Validators;

public class UpdateLocationProductValidator : AbstractValidator<UpdateLocationProductCommand>
{
    public UpdateLocationProductValidator()
    {
        RuleFor(x => x.LocationProduct).SetValidator(new UpdateLocationProductDtoValidator());
    }
}
