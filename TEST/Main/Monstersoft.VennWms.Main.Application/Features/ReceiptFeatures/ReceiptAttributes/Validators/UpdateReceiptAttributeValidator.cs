using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Validators;

public class UpdateReceiptAttributeValidator : AbstractValidator<UpdateReceiptAttributeCommand>
{
    public UpdateReceiptAttributeValidator()
    {
        RuleFor(x => x.ReceiptAttribute).SetValidator(new UpdateReceiptAttributeDtoValidator());
    }
}
