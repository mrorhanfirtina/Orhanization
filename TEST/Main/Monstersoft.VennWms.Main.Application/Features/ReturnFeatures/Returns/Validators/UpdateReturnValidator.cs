using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Validators;

public class UpdateReturnValidator : AbstractValidator<UpdateReturnCommand>
{
    public UpdateReturnValidator()
    {
        RuleFor(x => x.Return).SetValidator(new UpdateReturnDtoValidator());
    }
}
