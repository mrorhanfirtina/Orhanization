using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ReceiptDtos;

public class CreateReceiptItemSubDtoValidator : AbstractValidator<CreateReceiptItemSubDto>
{
    public CreateReceiptItemSubDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.ActualQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleForEach(x => x.ReceiptItemMemos).SetValidator(new CreateReceiptItemMemoSubDtoValidator());
        RuleForEach(x => x.ReceiptItmStockAttrValues).SetValidator(new CreateReceiptItmStockAttrValueSubDtoValidator());
    }
}


