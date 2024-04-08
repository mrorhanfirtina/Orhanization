using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Validators;

public class UpdateReceiptAttributeValueValidator : AbstractValidator<UpdateReceiptAttributeValueCommand>
{
    public UpdateReceiptAttributeValueValidator()
    {
        RuleFor(x => x.ReceiptAttributeValue).SetValidator(new UpdateReceiptAttributeValueDtoValidator());
    }
}
