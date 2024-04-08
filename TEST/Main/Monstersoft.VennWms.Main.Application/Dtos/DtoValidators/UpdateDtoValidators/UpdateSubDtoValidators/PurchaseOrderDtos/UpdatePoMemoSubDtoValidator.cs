using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.PurchaseOrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.PurchaseOrderDtos;

public class UpdatePoMemoSubDtoValidator : AbstractValidator<UpdatePoMemoSubDto>
{
    public UpdatePoMemoSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}


