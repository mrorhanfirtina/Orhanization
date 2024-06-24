using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Validators;

public class UpdateReturnItemMemoValidator : AbstractValidator<UpdateReturnItemMemoCommand>
{
    public UpdateReturnItemMemoValidator()
    {
        RuleFor(x => x.ReturnItemMemo).SetValidator(new UpdateReturnItemMemoDtoValidator());
    }
}
