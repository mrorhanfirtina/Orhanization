using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Validators;

public class UpdateReturnItemValidator : AbstractValidator<UpdateReturnItemCommand>
{
    public UpdateReturnItemValidator()
    {
        RuleFor(x => x.ReturnItem).SetValidator(new UpdateReturnItemDtoValidator());
    }
}
