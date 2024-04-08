using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Validators;

public class UpdateStorageSystemValidator : AbstractValidator<UpdateStorageSystemCommand>
{
    public UpdateStorageSystemValidator()
    {
        RuleFor(x => x.StorageSystem).SetValidator(new UpdateStorageSystemDtoValidator());
    }
}
