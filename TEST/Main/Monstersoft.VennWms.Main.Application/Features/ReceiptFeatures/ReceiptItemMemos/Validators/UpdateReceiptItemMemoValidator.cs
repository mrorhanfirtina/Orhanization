using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Validators;

public class UpdateReceiptItemMemoValidator : AbstractValidator<UpdateReceiptItemMemoCommand>
{
    public UpdateReceiptItemMemoValidator()
    {
        RuleFor(x => x.ReceiptItemMemo).SetValidator(new UpdateReceiptItemMemoDtoValidator());
    }
}
