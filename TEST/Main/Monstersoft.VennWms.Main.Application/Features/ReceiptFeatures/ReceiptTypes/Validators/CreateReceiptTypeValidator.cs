using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Validators;

public class CreateReceiptTypeValidator : AbstractValidator<CreateReceiptTypeCommand>
{
    public CreateReceiptTypeValidator()
    {
        RuleFor(x => x.ReceiptType).SetValidator(new CreateReceiptTypeDtoValidator());
    }
}
