using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Validators;

public class CreateReturnItemMemoValidator : AbstractValidator<CreateReturnItemMemoCommand>
{
    public CreateReturnItemMemoValidator()
    {
        RuleFor(x => x.ReturnItemMemo).SetValidator(new CreateReturnItemMemoDtoValidator());
    }
}
