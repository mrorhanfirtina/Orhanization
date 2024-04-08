using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Validators;

public class UpdateLocationProductValidator : AbstractValidator<UpdateLocationProductCommand>
{
    public UpdateLocationProductValidator()
    {
        RuleFor(x => x.LocationProduct).SetValidator(new UpdateLocationProductDtoValidator());
    }
}
