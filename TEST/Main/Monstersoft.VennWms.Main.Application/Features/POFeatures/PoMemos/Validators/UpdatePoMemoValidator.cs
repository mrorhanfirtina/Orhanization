using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Validators;

public class UpdatePoMemoValidator : AbstractValidator<UpdatePoMemoCommand>
{
    public UpdatePoMemoValidator()
    {
        RuleFor(x => x.PoMemo).SetValidator(new UpdatePoMemoDtoValidator());
    }
}
