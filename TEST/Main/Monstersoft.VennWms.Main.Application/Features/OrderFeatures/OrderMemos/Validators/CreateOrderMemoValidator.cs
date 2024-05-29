using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Validators;

public class CreateOrderMemoValidator : AbstractValidator<CreateOrderMemoCommand>
{
    public CreateOrderMemoValidator()
    {
        RuleFor(x => x.OrderMemo).SetValidator(new CreateOrderMemoDtoValidator());
    }
}
