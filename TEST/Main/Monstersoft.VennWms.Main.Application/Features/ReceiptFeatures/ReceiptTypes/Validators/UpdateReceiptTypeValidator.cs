using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Validators;

public class UpdateReceiptTypeValidator : AbstractValidator<UpdateReceiptTypeCommand>
{
    public UpdateReceiptTypeValidator()
    {
        RuleFor(x => x.ReceiptType).SetValidator(new UpdateReceiptTypeDtoValidator());
    }
}
