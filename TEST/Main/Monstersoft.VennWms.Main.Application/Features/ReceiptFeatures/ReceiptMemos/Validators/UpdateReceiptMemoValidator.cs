using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Validators;

public class UpdateReceiptMemoValidator : AbstractValidator<UpdateReceiptMemoCommand>
{
    public UpdateReceiptMemoValidator()
    {
        RuleFor(x => x.ReceiptMemo).SetValidator(new UpdateReceiptMemoDtoValidator());
    }
}
