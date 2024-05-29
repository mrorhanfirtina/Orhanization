using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.DtoValidators;

public class UpdateStorageSystemDtoValidator : AbstractValidator<UpdateStorageSystemDto>
{
    public UpdateStorageSystemDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.BuildingId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}



