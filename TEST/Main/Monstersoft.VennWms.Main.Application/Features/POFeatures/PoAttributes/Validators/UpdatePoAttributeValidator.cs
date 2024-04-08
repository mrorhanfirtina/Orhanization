using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Validators;

public class UpdatePoAttributeValidator : AbstractValidator<UpdatePoAttributeCommand>
{
    public UpdatePoAttributeValidator()
    {
        RuleFor(x => x.PoAttribute).SetValidator(new UpdatePoAttributeDtoValidator());
    }
}
