﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.DtoValidators;

public class CreateDepositorFeatureSubDtoValidator : AbstractValidator<CreateDepositorFeatureSubDto>
{
    public CreateDepositorFeatureSubDtoValidator()
    {
        RuleFor(p => p.GenerateSsccLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.OrderModifyLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ForbidNewReceiptLineLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.AllowDuplicateBarcodeLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ForceTaskStockLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ForbidTransferReservedLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ChangeStockWithTaskLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ManualReceiptCompletionLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ManualReturnCompletionLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}
