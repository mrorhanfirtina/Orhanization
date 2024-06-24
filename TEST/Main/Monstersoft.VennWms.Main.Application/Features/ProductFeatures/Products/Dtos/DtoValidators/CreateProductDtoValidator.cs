using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.DtoValidators;

public class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
{
    public CreateProductDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(120);
        RuleFor(p => p.AlternativeCode).MaximumLength(30);
        RuleFor(p => p.DepositorCompanyId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.ProductAttributeValues).SetValidator(new CreateProductAttributeValueSubDtoValidator());
        RuleForEach(x => x.ProductBarcodes).SetValidator(new CreateProductBarcodeSubDtoValidator());
        RuleForEach(x => x.ItemUnits).SetValidator(new CreateItemUnitSubDtoValidator());
        RuleForEach(x => x.ProductAttributeValues).SetValidator(new CreateProductAttributeValueSubDtoValidator());
        RuleForEach(x => x.ProductDepositors).SetValidator(new CreateProductDepositorSubDtoValidator());
        RuleFor(x => x.ProductAbcCategory).SetValidator(new CreateProductAbcCategorySubDtoValidator());
        RuleFor(x => x.ProductCategory).SetValidator(new CreateProductCategorySubDtoValidator());
    }
}



