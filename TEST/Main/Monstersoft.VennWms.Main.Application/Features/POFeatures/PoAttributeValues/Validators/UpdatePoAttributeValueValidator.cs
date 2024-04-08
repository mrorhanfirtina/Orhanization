using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Validators;

public class UpdatePoAttributeValueValidator : AbstractValidator<UpdatePoAttributeValueCommand>
{
    public UpdatePoAttributeValueValidator()
    {
        RuleFor(x => x.PoAttributeValue).SetValidator(new UpdatePoAttributeValueDtoValidator());
    }
}
