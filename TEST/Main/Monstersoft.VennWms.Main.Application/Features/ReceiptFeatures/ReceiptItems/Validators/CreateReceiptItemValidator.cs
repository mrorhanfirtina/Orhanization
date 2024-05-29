using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateReceiptItemValidator : AbstractValidator<CreateReceiptItemCommand>
{
    public CreateReceiptItemValidator()
    {
        RuleFor(x => x.ReceiptItem).SetValidator(new CreateReceiptItemDtoValidator());
    }
}
