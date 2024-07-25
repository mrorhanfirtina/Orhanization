using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Validators;

public class UpdateSerialHierarchyValidator : AbstractValidator<UpdateSerialHierarchyCommand>
{
    public UpdateSerialHierarchyValidator()
    {
        RuleFor(x => x.SerialHierarchy).SetValidator(new UpdateSerialHierarchyDtoValidator());
    }
}
