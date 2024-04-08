using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Validators;

public class CreateOrderMemoValidator : AbstractValidator<CreateOrderMemoCommand>
{
    public CreateOrderMemoValidator()
    {
        RuleFor(x => x.OrderMemo).SetValidator(new CreateOrderMemoDtoValidator());
    }
}
