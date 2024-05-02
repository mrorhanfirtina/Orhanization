﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Validators;

public class CreateOrderItemMemoValidator : AbstractValidator<CreateOrderItemMemoCommand>
{
    public CreateOrderItemMemoValidator()
    {
        RuleFor(x => x.OrderItemMemo).SetValidator(new CreateOrderItemMemoDtoValidator());
    }
}