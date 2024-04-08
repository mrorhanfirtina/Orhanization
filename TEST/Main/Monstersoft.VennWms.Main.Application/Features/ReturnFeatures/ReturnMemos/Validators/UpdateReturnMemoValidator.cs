using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Validators;

public class UpdateReturnMemoValidator : AbstractValidator<UpdateReturnMemoCommand>
{
    public UpdateReturnMemoValidator()
    {
        RuleFor(x => x.ReturnMemo).SetValidator(new UpdateReturnMemoDtoValidator());
    }
}
