using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.DtoValidators;

public class UpdateItemUnitDtoValidator : AbstractValidator<UpdateItemUnitDto>
{
    public UpdateItemUnitDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.UnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsConsumerUnit).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.HasSerial).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleForEach(x => x.ItemPackTypes).SetValidator(new UpdateItemPackTypeSubDtoValidator());
        RuleForEach(x => x.ItemUnitConversions).SetValidator(new UpdateItemUnitConversionSubDtoValidator());
    }
}



