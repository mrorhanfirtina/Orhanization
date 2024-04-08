using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Validators;

public class UpdateItemPackTypeValidator : AbstractValidator<UpdateItemPackTypeCommand>
{
    public UpdateItemPackTypeValidator()
    {
        RuleFor(x => x.ItemPackType).SetValidator(new UpdateItemPackTypeDtoValidator());
    }
}
