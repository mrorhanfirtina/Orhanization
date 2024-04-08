using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Validators;

public class UpdateReceiptMemoValidator : AbstractValidator<UpdateReceiptMemoCommand>
{
    public UpdateReceiptMemoValidator()
    {
        RuleFor(x => x.ReceiptMemo).SetValidator(new UpdateReceiptMemoDtoValidator());
    }
}
