using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.DtoValidators;

public class CreateItemUnitDtoValidator : AbstractValidator<CreateItemUnitDto>
{
    public CreateItemUnitDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.UnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsConsumerUnit).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleForEach(x => x.ItemPackTypes).SetValidator(new CreateItemPackTypeSubDtoValidator());
        RuleForEach(x => x.ItemUnitConversions).SetValidator(new CreateItemUnitConversionSubDtoValidator());
    }
}



