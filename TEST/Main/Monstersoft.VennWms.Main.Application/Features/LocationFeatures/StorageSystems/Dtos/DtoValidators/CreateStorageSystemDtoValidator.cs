using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.DtoValidators;

public class CreateStorageSystemDtoValidator : AbstractValidator<CreateStorageSystemDto>
{
    public CreateStorageSystemDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.BuildingId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}



