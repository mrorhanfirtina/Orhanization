using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Validators;

public class CreateReceiptAttributeValueValidator : AbstractValidator<CreateReceiptAttributeValueCommand>
{
    public CreateReceiptAttributeValueValidator()
    {
        RuleFor(x => x.ReceiptAttributeValue).SetValidator(new CreateReceiptAttributeValueDtoValidator());
    }
}
