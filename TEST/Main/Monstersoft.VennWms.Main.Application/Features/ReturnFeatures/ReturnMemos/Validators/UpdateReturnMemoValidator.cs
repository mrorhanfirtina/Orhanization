using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Validators;

public class UpdateReturnMemoValidator : AbstractValidator<UpdateReturnMemoCommand>
{
    public UpdateReturnMemoValidator()
    {
        RuleFor(x => x.ReturnMemo).SetValidator(new UpdateReturnMemoDtoValidator());
    }
}
