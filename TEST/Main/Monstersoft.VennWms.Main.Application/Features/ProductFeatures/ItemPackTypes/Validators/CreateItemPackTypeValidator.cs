using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Validators;

public class CreateItemPackTypeValidator : AbstractValidator<CreateItemPackTypeCommand>
{
    public CreateItemPackTypeValidator()
    {
        RuleFor(x => x.ItemPackType).SetValidator(new CreateItemPackTypeDtoValidator());
    }
}
