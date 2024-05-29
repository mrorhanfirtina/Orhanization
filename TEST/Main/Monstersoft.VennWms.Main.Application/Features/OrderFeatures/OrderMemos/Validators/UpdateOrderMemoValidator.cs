using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Validators;

public class UpdateOrderMemoValidator : AbstractValidator<UpdateOrderMemoCommand>
{
    public UpdateOrderMemoValidator()
    {
        RuleFor(x => x.OrderMemo).SetValidator(new UpdateOrderMemoDtoValidator());
    }
}
