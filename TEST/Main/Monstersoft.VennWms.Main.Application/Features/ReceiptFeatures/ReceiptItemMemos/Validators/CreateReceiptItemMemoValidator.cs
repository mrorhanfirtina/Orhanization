using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Validators;

public class CreateReceiptItemMemoValidator : AbstractValidator<CreateReceiptItemMemoCommand>
{
    public CreateReceiptItemMemoValidator()
    {
        RuleFor(x => x.ReceiptItemMemo).SetValidator(new CreateReceiptItemMemoDtoValidator());
    }
}
