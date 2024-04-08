using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateReceiptItemValidator : AbstractValidator<UpdateReceiptItemCommand>
{
    public UpdateReceiptItemValidator()
    {
        RuleFor(x => x.ReceiptItem).SetValidator(new UpdateReceiptItemDtoValidator());
    }
}
