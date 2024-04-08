using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features;

public class UpdateReceiptValidator : AbstractValidator<UpdateReceiptCommand>
{
    public UpdateReceiptValidator()
    {
        RuleFor(x => x.Receipt).SetValidator(new UpdateReceiptDtoValidator());
    }
}
