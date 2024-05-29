using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Validators;

public class CreateReceiptAttributeValidator : AbstractValidator<CreateReceiptAttributeCommand>
{
    public CreateReceiptAttributeValidator()
    {
        RuleFor(x => x.ReceiptAttribute).SetValidator(new CreateReceiptAttributeDtoValidator());
    }
}
