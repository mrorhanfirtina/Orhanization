using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Validators;

public class UpdateExpectedSerialHierarchyValidator : AbstractValidator<UpdateExpectedSerialHierarchyCommand>
{
    public UpdateExpectedSerialHierarchyValidator()
    {
        RuleFor(x => x.ExpectedSerialHierarchy).SetValidator(new UpdateExpectedSerialHierarchyDtoValidator());
    }
}
