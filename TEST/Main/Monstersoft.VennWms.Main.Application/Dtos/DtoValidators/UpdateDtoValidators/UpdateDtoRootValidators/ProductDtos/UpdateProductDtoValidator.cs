using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;

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
    }
}



