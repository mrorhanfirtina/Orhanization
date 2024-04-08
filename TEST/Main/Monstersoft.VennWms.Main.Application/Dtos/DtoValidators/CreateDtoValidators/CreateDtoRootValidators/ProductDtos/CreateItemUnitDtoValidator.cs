using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;

public class CreateItemUnitDtoValidator : AbstractValidator<CreateItemUnitDto>
{
    public CreateItemUnitDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.UnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsCustomerUnit).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleForEach(x => x.ItemPackTypes).SetValidator(new CreateItemPackTypeSubDtoValidator());
    }
}



