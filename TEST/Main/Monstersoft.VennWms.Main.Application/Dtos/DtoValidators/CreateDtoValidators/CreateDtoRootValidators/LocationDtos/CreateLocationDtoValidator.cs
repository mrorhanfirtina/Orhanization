using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;

public class CreateLocationDtoValidator : AbstractValidator<CreateLocationDto>
{
    public CreateLocationDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(120);
        RuleFor(p => p.StorageSystemId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.LocationStockAttributes).SetValidator(new CreateLocationStockAttributeSubDtoValidator());
        RuleForEach(x => x.LocationZones).SetValidator(new CreateLocationZoneSubDtoValidator());
        RuleForEach(x => x.Products).SetValidator(new CreateLocationProductSubDtoValidator());
        RuleForEach(x => x.LocationProductAttributes).SetValidator(new CreateLocationProductAttributeSubDtoValidator());
        RuleFor(x => x.LocationLockReason).SetValidator(new CreateLocationLockReasonSubDtoValidator());
        RuleFor(x => x.LocationPickingType).SetValidator(new CreateLocationPickingTypeSubDtoValidator());
        RuleFor(x => x.LocationDimension).SetValidator(new CreateLocationDimensionSubDtoValidator());
        RuleFor(x => x.LocationFeature).SetValidator(new CreateLocationFeatureSubDtoValidator());
        RuleFor(x => x.LocationPriority).SetValidator(new CreateLocationPrioritySubDtoValidator());
        RuleFor(x => x.LocationCodeFormat).SetValidator(new CreateLocationCodeFormatSubDtoValidator());
        RuleFor(x => x.LocationCoordinate).SetValidator(new CreateLocationCoordinateSubDtoValidator());
        RuleForEach(x => x.LocationUnitConstraints).SetValidator(new CreateLocationUnitConstraintSubDtoValidator());
        RuleForEach(x => x.LocationProductConstraints).SetValidator(new CreateLocationProductConstraintSubDtoValidator());
        RuleForEach(x => x.LocationDepositors).SetValidator(new CreateLocationDepositorSubDtoValidator());
    }
}



