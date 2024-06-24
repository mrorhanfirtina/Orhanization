using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Validators;

public class CreateReturnItemValidator : AbstractValidator<CreateReturnItemCommand>
{
    public CreateReturnItemValidator()
    {
        RuleFor(x => x.ReturnItem).SetValidator(new CreateReturnItemDtoValidator());
    }
}
