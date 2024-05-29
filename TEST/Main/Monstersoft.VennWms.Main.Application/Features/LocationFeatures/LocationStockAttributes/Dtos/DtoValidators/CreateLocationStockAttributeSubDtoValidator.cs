﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.DtoValidators;

public class CreateLocationStockAttributeSubDtoValidator : AbstractValidator<CreateLocationStockAttributeSubDto>
{
    public CreateLocationStockAttributeSubDtoValidator()
    {
        RuleFor(p => p.StockAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsForbid).NotNull().NotEmpty();
    }
}
