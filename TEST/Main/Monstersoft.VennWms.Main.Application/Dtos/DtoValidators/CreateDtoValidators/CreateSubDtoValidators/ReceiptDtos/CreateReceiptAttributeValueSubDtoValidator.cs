using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ReceiptDtos;

public class CreateReceiptAttributeValueSubDtoValidator : AbstractValidator<CreateReceiptAttributeValueSubDto>
{
    public CreateReceiptAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ReceiptAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


