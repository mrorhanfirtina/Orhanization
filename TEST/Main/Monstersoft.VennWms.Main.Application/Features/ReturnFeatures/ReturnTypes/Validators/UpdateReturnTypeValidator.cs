using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Validators;

public class UpdateReturnTypeValidator : AbstractValidator<UpdateReturnTypeCommand>
{
    public UpdateReturnTypeValidator()
    {
        RuleFor(x => x.ReturnType).SetValidator(new UpdateReturnTypeDtoValidator());
    }
}
