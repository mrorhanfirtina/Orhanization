using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.DtoValidators;

public class UpdateProductDtoValidator : AbstractValidator<UpdateProductDto>
{
    public UpdateProductDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(120);
        RuleFor(p => p.AlternativeCode).MaximumLength(30);
        RuleFor(p => p.DepositorCompanyId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.ProductAttributeValues).SetValidator(new UpdateProductAttributeValueSubDtoValidator());
        RuleForEach(x => x.ProductBarcodes).SetValidator(new UpdateProductBarcodeSubDtoValidator());
        RuleForEach(x => x.ItemUnits).SetValidator(new UpdateItemUnitSubDtoValidator());
        RuleForEach(x => x.ProductAttributeValues).SetValidator(new UpdateProductAttributeValueSubDtoValidator());
        RuleForEach(x => x.ProductDepositors).SetValidator(new UpdateProductDepositorSubDtoValidator());
        RuleFor(x => x.ProductAbcCategory).SetValidator(new UpdateProductAbcCategorySubDtoValidator());
        RuleFor(x => x.ProductCategory).SetValidator(new UpdateProductCategorySubDtoValidator());
    }
}



