using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Validators;

public class CreateReturnMemoValidator : AbstractValidator<CreateReturnMemoCommand>
{
    public CreateReturnMemoValidator()
    {
        RuleFor(x => x.ReturnMemo).SetValidator(new CreateReturnMemoDtoValidator());
    }
}
