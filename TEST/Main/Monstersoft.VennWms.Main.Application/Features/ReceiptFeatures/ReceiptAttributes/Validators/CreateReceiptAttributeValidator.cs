using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Validators;

public class CreateReceiptAttributeValidator : AbstractValidator<CreateReceiptAttributeCommand>
{
    public CreateReceiptAttributeValidator()
    {
        RuleFor(x => x.ReceiptAttribute).SetValidator(new CreateReceiptAttributeDtoValidator());
    }
}
