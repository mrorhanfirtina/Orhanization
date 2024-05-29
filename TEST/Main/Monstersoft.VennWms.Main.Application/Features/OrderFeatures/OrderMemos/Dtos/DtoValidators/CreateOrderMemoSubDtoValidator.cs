using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.DtoValidators;

public class CreateOrderMemoSubDtoValidator : AbstractValidator<CreateOrderMemoSubDto>
{
    public CreateOrderMemoSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}


