using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Validators;

public class CreateReturnMemoValidator : AbstractValidator<CreateReturnMemoCommand>
{
    public CreateReturnMemoValidator()
    {
        RuleFor(x => x.ReturnMemo).SetValidator(new CreateReturnMemoDtoValidator());
    }
}
