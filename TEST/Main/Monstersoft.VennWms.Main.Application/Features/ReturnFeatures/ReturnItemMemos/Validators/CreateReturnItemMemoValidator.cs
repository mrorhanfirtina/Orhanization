using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Validators;

public class CreateReturnItemMemoValidator : AbstractValidator<CreateReturnItemMemoCommand>
{
    public CreateReturnItemMemoValidator()
    {
        RuleFor(x => x.ReturnItemMemo).SetValidator(new CreateReturnItemMemoDtoValidator());
    }
}
