using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Validators;

public class CreateExpectedSerialHierarchyValidator : AbstractValidator<CreateExpectedSerialHierarchyCommand>
{
    public CreateExpectedSerialHierarchyValidator()
    {
        RuleFor(x => x.ExpectedSerialHierarchy).SetValidator(new CreateExpectedSerialHierarchyDtoValidator());
    }
}
