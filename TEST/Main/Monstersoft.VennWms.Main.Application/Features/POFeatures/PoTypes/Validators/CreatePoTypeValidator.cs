using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Validators;

public class CreatePoTypeValidator : AbstractValidator<CreatePoTypeCommand>
{
    public CreatePoTypeValidator()
    {
        RuleFor(x => x.PoType).SetValidator(new CreatePoTypeDtoValidator());
    }
}
