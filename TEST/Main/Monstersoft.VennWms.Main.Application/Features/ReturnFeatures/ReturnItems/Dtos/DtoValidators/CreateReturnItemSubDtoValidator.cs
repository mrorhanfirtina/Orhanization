﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.DtoValidators;

public class CreateReturnItemSubDtoValidator : AbstractValidator<CreateReturnItemSubDto>
{
    public CreateReturnItemSubDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.ActualQuantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.StatusId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleForEach(x => x.ReturnItemMemos).SetValidator(new CreateReturnItemMemoSubDtoValidator());
        RuleForEach(x => x.ReturnItmStockAttrValues).SetValidator(new CreateReturnItmStockAttrValueSubDtoValidator());
    }
}


