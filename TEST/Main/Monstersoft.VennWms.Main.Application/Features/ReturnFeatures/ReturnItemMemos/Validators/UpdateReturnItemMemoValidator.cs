using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Validators;

public class UpdateReturnItemMemoValidator : AbstractValidator<UpdateReturnItemMemoCommand>
{
    public UpdateReturnItemMemoValidator()
    {
        RuleFor(x => x.ReturnItemMemo).SetValidator(new UpdateReturnItemMemoDtoValidator());
    }
}
