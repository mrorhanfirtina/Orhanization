using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ReceiptDtos;

public class UpdateReceiptAttributeValueSubDtoValidator : AbstractValidator<UpdateReceiptAttributeValueSubDto>
{
    public UpdateReceiptAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ReceiptAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


