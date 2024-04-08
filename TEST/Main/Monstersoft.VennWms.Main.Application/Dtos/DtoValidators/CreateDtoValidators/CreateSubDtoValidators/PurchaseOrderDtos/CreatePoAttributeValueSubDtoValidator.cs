using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.PurchaseOrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.PurchaseOrderDtos;

public class CreatePoAttributeValueSubDtoValidator : AbstractValidator<CreatePoAttributeValueSubDto>
{
    public CreatePoAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.PoAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


