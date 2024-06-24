using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.DtoValidators;

public class UpdateReceiptAttributeValueSubDtoValidator : AbstractValidator<UpdateReceiptAttributeValueSubDto>
{
    public UpdateReceiptAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ReceiptAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


