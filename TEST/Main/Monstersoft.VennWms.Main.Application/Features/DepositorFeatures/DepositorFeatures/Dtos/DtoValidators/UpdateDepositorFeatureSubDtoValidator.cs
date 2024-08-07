﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.DtoValidators;

public class UpdateDepositorFeatureSubDtoValidator : AbstractValidator<UpdateDepositorFeatureSubDto>
{
    public UpdateDepositorFeatureSubDtoValidator()
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
