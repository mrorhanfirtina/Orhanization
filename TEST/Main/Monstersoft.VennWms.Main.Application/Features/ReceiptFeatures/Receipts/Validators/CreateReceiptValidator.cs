using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class CreateReceiptValidator : AbstractValidator<CreateReceiptCommand>
{
    public CreateReceiptValidator()
    {
        RuleFor(x => x.Receipt).SetValidator(new CreateReceiptDtoValidator());
    }
}
