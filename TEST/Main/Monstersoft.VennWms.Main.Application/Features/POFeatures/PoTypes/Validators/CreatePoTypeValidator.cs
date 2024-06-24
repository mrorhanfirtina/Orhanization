using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Validators;

public class CreatePoTypeValidator : AbstractValidator<CreatePoTypeCommand>
{
    public CreatePoTypeValidator()
    {
        RuleFor(x => x.PoType).SetValidator(new CreatePoTypeDtoValidator());
    }
}
