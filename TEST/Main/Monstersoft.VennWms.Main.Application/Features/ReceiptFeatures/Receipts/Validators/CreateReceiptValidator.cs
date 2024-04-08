﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateReceiptValidator : AbstractValidator<CreateReceiptCommand>
{
    public CreateReceiptValidator()
    {
        RuleFor(x => x.Receipt).SetValidator(new CreateReceiptDtoValidator());
    }
}
