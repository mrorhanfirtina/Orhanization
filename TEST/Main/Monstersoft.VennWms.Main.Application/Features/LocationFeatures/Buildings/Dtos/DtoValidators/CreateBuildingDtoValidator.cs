using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BuildingDimensions.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.DtoValidators;

public class CreateBuildingDtoValidator : AbstractValidator<CreateBuildingDto>
{
    public CreateBuildingDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.SiteId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(120);
        RuleFor(p => p.Province).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.City).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.Country).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.AddressText).NotEmpty().NotNull().MaximumLength(250);
        RuleFor(p => p.ZipCode).NotEmpty().NotNull().MaximumLength(10);
        RuleFor(p => p.Longitude).PrecisionScale(11, 7, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
        RuleFor(p => p.Latitude).PrecisionScale(11, 7, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
        RuleFor(p => p.BuildingDimension).SetValidator(new CreateBuildingDimensionSubDtoValidator());
    }
}



