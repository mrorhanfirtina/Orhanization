using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Validators;

public class CreateStorageSystemValidator : AbstractValidator<CreateStorageSystemCommand>
{
    public CreateStorageSystemValidator()
    {
        RuleFor(x => x.StorageSystem).SetValidator(new CreateStorageSystemDtoValidator());
    }
}
