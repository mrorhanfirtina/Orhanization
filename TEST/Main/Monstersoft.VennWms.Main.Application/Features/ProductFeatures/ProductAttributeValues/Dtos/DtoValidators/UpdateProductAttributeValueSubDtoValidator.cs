using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.DtoValidators;

public class UpdateProductAttributeValueSubDtoValidator : AbstractValidator<UpdateProductAttributeValueSubDto>
{
    public UpdateProductAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ProductAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


