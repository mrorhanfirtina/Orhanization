using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.DtoValidators;

public class CreateReceiptAttributeValueSubDtoValidator : AbstractValidator<CreateReceiptAttributeValueSubDto>
{
    public CreateReceiptAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ReceiptAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


