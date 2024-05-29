﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.DtoValidators;

public class CreateLocationProductAttributeDtoValidator : AbstractValidator<CreateLocationProductAttributeDto>
{
    public CreateLocationProductAttributeDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsForbid).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



