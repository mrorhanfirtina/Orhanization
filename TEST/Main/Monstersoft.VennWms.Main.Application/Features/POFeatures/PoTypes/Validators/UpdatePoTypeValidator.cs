using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Validators;

public class UpdatePoTypeValidator : AbstractValidator<UpdatePoTypeCommand>
{
    public UpdatePoTypeValidator()
    {
        RuleFor(x => x.PoType).SetValidator(new UpdatePoTypeDtoValidator());
    }
}
