using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Validators;

public class UpdatePoTypeValidator : AbstractValidator<UpdatePoTypeCommand>
{
    public UpdatePoTypeValidator()
    {
        RuleFor(x => x.PoType).SetValidator(new UpdatePoTypeDtoValidator());
    }
}
