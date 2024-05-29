using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Validators;

public class CreateLocationProductAttributeValidator : AbstractValidator<CreateLocationProductAttributeCommand>
{
    public CreateLocationProductAttributeValidator()
    {
        RuleFor(x => x.LocationProductAttribute).SetValidator(new CreateLocationProductAttributeDtoValidator());
    }
}
