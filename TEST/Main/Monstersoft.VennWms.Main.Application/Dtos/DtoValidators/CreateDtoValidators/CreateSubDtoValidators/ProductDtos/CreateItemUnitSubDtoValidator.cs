using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ProductDtos;

public class CreateItemUnitSubDtoValidator : AbstractValidator<CreateItemUnitSubDto>
{
    public CreateItemUnitSubDtoValidator()
    {
        RuleFor(p => p.UnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsCustomerUnit).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleForEach(x => x.ItemPackTypes).SetValidator(new CreateItemPackTypeSubDtoValidator());
    }
}


