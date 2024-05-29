﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Validators;

public class CreateReceiptAttributeValueValidator : AbstractValidator<CreateReceiptAttributeValueCommand>
{
    public CreateReceiptAttributeValueValidator()
    {
        RuleFor(x => x.ReceiptAttributeValue).SetValidator(new CreateReceiptAttributeValueDtoValidator());
    }
}
