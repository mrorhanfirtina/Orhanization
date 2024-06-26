﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.DtoValidators;

public class UpdateProductAttributeDtoValidator : AbstractValidator<UpdateProductAttributeDto>
{
    public UpdateProductAttributeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.AttributeInputTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsNecessary).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



