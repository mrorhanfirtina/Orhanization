﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.DtoValidators;

public class CreateOrderItemSubDtoValidator : AbstractValidator<CreateOrderItemSubDto>
{
    public CreateOrderItemSubDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Quantity).NotNull().NotEmpty().PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.").GreaterThan(0);
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.OrderItemMemos).SetValidator(new CreateOrderItemMemoSubDtoValidator());
        RuleForEach(x => x.OrderItemStockAttrValues).SetValidator(new CreateOrderItemStockAttrValueSubDtoValidator());
        RuleForEach(x => x.OrderShipItems).SetValidator(new CreateOrderShipItemSubDtoValidator());
    }
}


