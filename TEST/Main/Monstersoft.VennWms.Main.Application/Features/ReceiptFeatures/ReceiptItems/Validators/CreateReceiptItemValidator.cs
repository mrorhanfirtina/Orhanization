using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateReceiptItemValidator : AbstractValidator<CreateReceiptItemCommand>
{
    public CreateReceiptItemValidator()
    {
        RuleFor(x => x.ReceiptItem).SetValidator(new CreateReceiptItemDtoValidator());
    }
}
