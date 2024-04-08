using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Validators;

public class CreateLocationStockAttributeValidator : AbstractValidator<CreateLocationStockAttributeCommand>
{
    public CreateLocationStockAttributeValidator()
    {
        RuleFor(x => x.LocationStockAttribute).SetValidator(new CreateLocationStockAttributeDtoValidator());
    }
}
