using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateReceiptValidator : AbstractValidator<UpdateReceiptCommand>
{
    public UpdateReceiptValidator()
    {
        RuleFor(x => x.Receipt).SetValidator(new UpdateReceiptDtoValidator());
    }
}
