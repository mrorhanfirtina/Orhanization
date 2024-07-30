using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Validators;

public class CreateSerialHierarchyValidator : AbstractValidator<CreateSerialHierarchyCommand>
{
    public CreateSerialHierarchyValidator()
    {
        RuleFor(x => x.SerialHierarchy).SetValidator(new CreateSerialHierarchyDtoValidator());
    }
}
