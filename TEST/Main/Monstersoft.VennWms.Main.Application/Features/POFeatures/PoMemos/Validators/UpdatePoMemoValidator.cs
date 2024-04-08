using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Validators;

public class UpdatePoMemoValidator : AbstractValidator<UpdatePoMemoCommand>
{
    public UpdatePoMemoValidator()
    {
        RuleFor(x => x.PoMemo).SetValidator(new UpdatePoMemoDtoValidator());
    }
}
