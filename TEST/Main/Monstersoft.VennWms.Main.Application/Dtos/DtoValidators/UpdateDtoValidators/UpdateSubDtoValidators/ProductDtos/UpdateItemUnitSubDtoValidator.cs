using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ProductDtos;

public class UpdateItemUnitSubDtoValidator : AbstractValidator<UpdateItemUnitSubDto>
{
    public UpdateItemUnitSubDtoValidator()
    {
        RuleFor(p => p.UnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsCustomerUnit).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleForEach(x => x.ItemPackTypes).SetValidator(new UpdateItemPackTypeSubDtoValidator());
    }
}


