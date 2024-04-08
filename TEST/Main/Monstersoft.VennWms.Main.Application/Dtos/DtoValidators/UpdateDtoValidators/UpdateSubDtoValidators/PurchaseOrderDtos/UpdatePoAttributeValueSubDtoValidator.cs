using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.PurchaseOrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.PurchaseOrderDtos;

public class UpdatePoAttributeValueSubDtoValidator : AbstractValidator<UpdatePoAttributeValueSubDto>
{
    public UpdatePoAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.PoAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


