using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Validators;

public class UpdateStorageSystemValidator : AbstractValidator<UpdateStorageSystemCommand>
{
    public UpdateStorageSystemValidator()
    {
        RuleFor(x => x.StorageSystem).SetValidator(new UpdateStorageSystemDtoValidator());
    }
}
