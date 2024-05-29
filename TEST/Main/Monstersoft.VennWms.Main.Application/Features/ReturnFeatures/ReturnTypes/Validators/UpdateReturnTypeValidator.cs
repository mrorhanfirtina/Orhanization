using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Validators;

public class UpdateReturnTypeValidator : AbstractValidator<UpdateReturnTypeCommand>
{
    public UpdateReturnTypeValidator()
    {
        RuleFor(x => x.ReturnType).SetValidator(new UpdateReturnTypeDtoValidator());
    }
}
