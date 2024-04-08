using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Validators;

public class CreateLocationProductValidator : AbstractValidator<CreateLocationProductCommand>
{
    public CreateLocationProductValidator()
    {
        RuleFor(x => x.LocationProduct).SetValidator(new CreateLocationProductDtoValidator());
    }
}
