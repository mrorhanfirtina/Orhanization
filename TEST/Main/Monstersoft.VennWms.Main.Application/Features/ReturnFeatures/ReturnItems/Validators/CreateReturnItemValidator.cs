using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Validators;

public class CreateReturnItemValidator : AbstractValidator<CreateReturnItemCommand>
{
    public CreateReturnItemValidator()
    {
        RuleFor(x => x.ReturnItem).SetValidator(new CreateReturnItemDtoValidator());
    }
}
