﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.DtoValidators;

public class CreateLocationDepositorSubDtoValidator : AbstractValidator<CreateLocationDepositorSubDto>
{
    public CreateLocationDepositorSubDtoValidator()
    {
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsForbid).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}
