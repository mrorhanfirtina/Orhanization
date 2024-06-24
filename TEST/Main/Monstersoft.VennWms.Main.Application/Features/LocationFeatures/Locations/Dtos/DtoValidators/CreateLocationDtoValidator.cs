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
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.DtoValidators;

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
        RuleForEach(x => x.LocationProductCategories).SetValidator(new CreateLocationProductCategorySubDtoValidator());
        RuleForEach(x => x.LocationProductAbcCategories).SetValidator(new CreateLocationProductAbcCategorySubDtoValidator());
    }
}



