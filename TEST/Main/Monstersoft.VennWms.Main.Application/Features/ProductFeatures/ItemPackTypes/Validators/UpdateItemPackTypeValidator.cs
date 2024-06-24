using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Validators;

public class UpdateItemPackTypeValidator : AbstractValidator<UpdateItemPackTypeCommand>
{
    public UpdateItemPackTypeValidator()
    {
        RuleFor(x => x.ItemPackType).SetValidator(new UpdateItemPackTypeDtoValidator());
    }
}
