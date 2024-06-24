using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Validators;

public class CreateStorageSystemValidator : AbstractValidator<CreateStorageSystemCommand>
{
    public CreateStorageSystemValidator()
    {
        RuleFor(x => x.StorageSystem).SetValidator(new CreateStorageSystemDtoValidator());
    }
}
