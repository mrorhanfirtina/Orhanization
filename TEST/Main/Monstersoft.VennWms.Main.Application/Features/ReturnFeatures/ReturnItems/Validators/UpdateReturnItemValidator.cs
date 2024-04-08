using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Validators;

public class UpdateReturnItemValidator : AbstractValidator<UpdateReturnItemCommand>
{
    public UpdateReturnItemValidator()
    {
        RuleFor(x => x.ReturnItem).SetValidator(new UpdateReturnItemDtoValidator());
    }
}
