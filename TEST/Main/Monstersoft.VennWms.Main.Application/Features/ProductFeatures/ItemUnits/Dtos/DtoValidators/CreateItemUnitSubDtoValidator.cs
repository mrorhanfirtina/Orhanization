using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.DtoValidators;

public class CreateItemUnitSubDtoValidator : AbstractValidator<CreateItemUnitSubDto>
{
    public CreateItemUnitSubDtoValidator()
    {
        RuleFor(p => p.UnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsConsumerUnit).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.HasSerial).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleForEach(x => x.ItemPackTypes).SetValidator(new CreateItemPackTypeSubDtoValidator());
        RuleForEach(x => x.ItemUnitConversions).SetValidator(new CreateItemUnitConversionSubDtoValidator());
    }
}


