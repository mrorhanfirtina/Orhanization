using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Validators;

public class CreateLocationProductValidator : AbstractValidator<CreateLocationProductCommand>
{
    public CreateLocationProductValidator()
    {
        RuleFor(x => x.LocationProduct).SetValidator(new CreateLocationProductDtoValidator());
    }
}
