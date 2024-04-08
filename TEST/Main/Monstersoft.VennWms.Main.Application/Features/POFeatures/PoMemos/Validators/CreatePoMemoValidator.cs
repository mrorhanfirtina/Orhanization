using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Validators;

public class CreatePoMemoValidator : AbstractValidator<CreatePoMemoCommand>
{
    public CreatePoMemoValidator()
    {
        RuleFor(x => x.PoMemo).SetValidator(new CreatePoMemoDtoValidator());
    }
}
