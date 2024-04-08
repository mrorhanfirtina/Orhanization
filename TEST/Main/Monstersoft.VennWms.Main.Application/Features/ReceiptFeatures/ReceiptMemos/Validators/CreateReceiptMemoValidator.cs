using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Validators;

public class CreateReceiptMemoValidator : AbstractValidator<CreateReceiptMemoCommand>
{
    public CreateReceiptMemoValidator()
    {
        RuleFor(x => x.ReceiptMemo).SetValidator(new CreateReceiptMemoDtoValidator());
    }
}
