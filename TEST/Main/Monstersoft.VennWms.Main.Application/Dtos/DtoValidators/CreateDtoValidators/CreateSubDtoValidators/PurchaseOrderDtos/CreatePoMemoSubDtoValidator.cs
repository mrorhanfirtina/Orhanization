using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.PurchaseOrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.PurchaseOrderDtos;

public class CreatePoMemoSubDtoValidator : AbstractValidator<CreatePoMemoSubDto>
{
    public CreatePoMemoSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}


