using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateReceiptItemValidator : AbstractValidator<UpdateReceiptItemCommand>
{
    public UpdateReceiptItemValidator()
    {
        RuleFor(x => x.ReceiptItem).SetValidator(new UpdateReceiptItemDtoValidator());
    }
}
