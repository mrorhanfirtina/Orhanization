using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReturnDtos;

public class UpdateReturnItemDtoValidator : AbstractValidator<UpdateReturnItemDto>
{
    public UpdateReturnItemDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.ActualQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.StatusId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleForEach(x => x.ReturnItemMemos).SetValidator(new UpdateReturnItemMemoSubDtoValidator());
        RuleForEach(x => x.ReturnItmStockAttrValues).SetValidator(new UpdateReturnItmStockAttrValueSubDtoValidator());
    }
}



