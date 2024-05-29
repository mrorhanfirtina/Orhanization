using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.DtoValidators;

public class UpdateOrderMemoSubDtoValidator : AbstractValidator<UpdateOrderMemoSubDto>
{
    public UpdateOrderMemoSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}


