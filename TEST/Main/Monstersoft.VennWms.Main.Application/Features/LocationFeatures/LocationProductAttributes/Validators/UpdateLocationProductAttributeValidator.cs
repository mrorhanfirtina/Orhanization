using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Validators;

public class UpdateLocationProductAttributeValidator : AbstractValidator<UpdateLocationProductAttributeCommand>
{
    public UpdateLocationProductAttributeValidator()
    {
        RuleFor(x => x.LocationProductAttribute).SetValidator(new UpdateLocationProductAttributeDtoValidator());
    }
}
