using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCodeFormats.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationFeatures.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.DtoValidators;

public class UpdateLocationDtoValidator : AbstractValidator<UpdateLocationDto>
{
    public UpdateLocationDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(120);
        RuleFor(p => p.StorageSystemId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.LocationStockAttributes).SetValidator(new UpdateLocationStockAttributeSubDtoValidator());
        RuleForEach(x => x.LocationZones).SetValidator(new UpdateLocationZoneSubDtoValidator());
        RuleForEach(x => x.Products).SetValidator(new UpdateLocationProductSubDtoValidator());
        RuleForEach(x => x.LocationProductAttributes).SetValidator(new UpdateLocationProductAttributeSubDtoValidator());
        RuleFor(x => x.LocationLockReason).SetValidator(new UpdateLocationLockReasonSubDtoValidator());
        RuleFor(x => x.LocationPickingType).SetValidator(new UpdateLocationPickingTypeSubDtoValidator());
        RuleFor(x => x.LocationDimension).SetValidator(new UpdateLocationDimensionSubDtoValidator());
        RuleFor(x => x.LocationFeature).SetValidator(new UpdateLocationFeatureSubDtoValidator());
        RuleFor(x => x.LocationPriority).SetValidator(new UpdateLocationPrioritySubDtoValidator());
        RuleFor(x => x.LocationCodeFormat).SetValidator(new UpdateLocationCodeFormatSubDtoValidator());
        RuleFor(x => x.LocationCoordinate).SetValidator(new UpdateLocationCoordinateSubDtoValidator());
        RuleForEach(x => x.LocationUnitConstraints).SetValidator(new UpdateLocationUnitConstraintSubDtoValidator());
        RuleForEach(x => x.LocationProductConstraints).SetValidator(new UpdateLocationProductConstraintSubDtoValidator());
        RuleForEach(x => x.LocationDepositors).SetValidator(new UpdateLocationDepositorSubDtoValidator());
        RuleForEach(x => x.LocationProductCategories).SetValidator(new UpdateLocationProductCategorySubDtoValidator());
        RuleForEach(x => x.LocationProductAbcCategories).SetValidator(new UpdateLocationProductAbcCategorySubDtoValidator());
    }
}



