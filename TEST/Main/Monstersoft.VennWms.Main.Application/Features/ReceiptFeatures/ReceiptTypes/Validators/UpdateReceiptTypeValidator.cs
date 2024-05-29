using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Validators;

public class UpdateReceiptTypeValidator : AbstractValidator<UpdateReceiptTypeCommand>
{
    public UpdateReceiptTypeValidator()
    {
        RuleFor(x => x.ReceiptType).SetValidator(new UpdateReceiptTypeDtoValidator());
    }
}
