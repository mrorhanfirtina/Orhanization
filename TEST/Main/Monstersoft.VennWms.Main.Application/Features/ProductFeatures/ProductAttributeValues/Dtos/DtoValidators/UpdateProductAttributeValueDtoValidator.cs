﻿using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.DtoValidators;

public class UpdateProductAttributeValueDtoValidator : AbstractValidator<UpdateProductAttributeValueDto>
{
    public UpdateProductAttributeValueDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}



