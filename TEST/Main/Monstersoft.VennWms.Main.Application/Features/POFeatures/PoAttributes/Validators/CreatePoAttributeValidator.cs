using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Validators;

public class CreatePoAttributeValidator : AbstractValidator<CreatePoAttributeCommand>
{
    public CreatePoAttributeValidator()
    {
        RuleFor(x => x.PoAttribute).SetValidator(new CreatePoAttributeDtoValidator());
    }
}
