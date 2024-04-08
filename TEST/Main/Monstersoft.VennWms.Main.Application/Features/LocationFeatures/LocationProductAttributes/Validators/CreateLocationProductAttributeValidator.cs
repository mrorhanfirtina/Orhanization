using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Validators;

public class CreateLocationProductAttributeValidator : AbstractValidator<CreateLocationProductAttributeCommand>
{
    public CreateLocationProductAttributeValidator()
    {
        RuleFor(x => x.LocationProductAttribute).SetValidator(new CreateLocationProductAttributeDtoValidator());
    }
}
