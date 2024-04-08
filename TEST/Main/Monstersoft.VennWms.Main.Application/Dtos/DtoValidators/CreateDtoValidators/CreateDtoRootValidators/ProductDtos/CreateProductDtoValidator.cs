using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;

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

    }
}



