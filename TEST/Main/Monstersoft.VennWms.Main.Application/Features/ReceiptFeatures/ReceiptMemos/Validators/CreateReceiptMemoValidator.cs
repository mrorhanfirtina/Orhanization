using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Validators;

public class CreateReceiptMemoValidator : AbstractValidator<CreateReceiptMemoCommand>
{
    public CreateReceiptMemoValidator()
    {
        RuleFor(x => x.ReceiptMemo).SetValidator(new CreateReceiptMemoDtoValidator());
    }
}
