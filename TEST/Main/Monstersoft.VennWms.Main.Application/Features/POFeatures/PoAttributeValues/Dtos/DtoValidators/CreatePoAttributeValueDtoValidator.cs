using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.DtoValidators;

public class CreatePoAttributeValueDtoValidator : AbstractValidator<CreatePoAttributeValueDto>
{
    public CreatePoAttributeValueDtoValidator()
    {
        RuleFor(p => p.PurchaseOrderId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.PoAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}



