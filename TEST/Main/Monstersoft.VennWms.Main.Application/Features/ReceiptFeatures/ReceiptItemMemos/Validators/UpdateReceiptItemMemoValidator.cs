using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Validators;

public class UpdateReceiptItemMemoValidator : AbstractValidator<UpdateReceiptItemMemoCommand>
{
    public UpdateReceiptItemMemoValidator()
    {
        RuleFor(x => x.ReceiptItemMemo).SetValidator(new UpdateReceiptItemMemoDtoValidator());
    }
}
