using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Validators;

public class UpdateProductValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductValidator()
    {
        RuleFor(x => x.Product).SetValidator(new UpdateProductDtoValidator());
    }
}
public class UpdateReceiptAttributeValidator : AbstractValidator<UpdateReceiptAttributeCommand>
{
    public UpdateReceiptAttributeValidator()
    {
        RuleFor(x => x.ReceiptAttribute).SetValidator(new UpdateReceiptAttributeDtoValidator());
    }
}
public class CreateReceiptAttributeValidator : AbstractValidator<CreateReceiptAttributeCommand>
{
    public CreateReceiptAttributeValidator()
    {
        RuleFor(x => x.ReceiptAttribute).SetValidator(new CreateReceiptAttributeDtoValidator());
    }
}
public class UpdateReceiptAttributeValueValidator : AbstractValidator<UpdateReceiptAttributeValueCommand>
{
    public UpdateReceiptAttributeValueValidator()
    {
        RuleFor(x => x.ReceiptAttributeValue).SetValidator(new UpdateReceiptAttributeValueDtoValidator());
    }
}
public class CreateReceiptAttributeValueValidator : AbstractValidator<CreateReceiptAttributeValueCommand>
{
    public CreateReceiptAttributeValueValidator()
    {
        RuleFor(x => x.ReceiptAttributeValue).SetValidator(new CreateReceiptAttributeValueDtoValidator());
    }
}
public class UpdateReceiptItemMemoValidator : AbstractValidator<UpdateReceiptItemMemoCommand>
{
    public UpdateReceiptItemMemoValidator()
    {
        RuleFor(x => x.ReceiptItemMemo).SetValidator(new UpdateReceiptItemMemoDtoValidator());
    }
}
public class CreateReceiptItemMemoValidator : AbstractValidator<CreateReceiptItemMemoCommand>
{
    public CreateReceiptItemMemoValidator()
    {
        RuleFor(x => x.ReceiptItemMemo).SetValidator(new CreateReceiptItemMemoDtoValidator());
    }
}
public class UpdateReceiptItemValidator : AbstractValidator<UpdateReceiptItemCommand>
{
    public UpdateReceiptItemValidator()
    {
        RuleFor(x => x.ReceiptItem).SetValidator(new UpdateReceiptItemDtoValidator());
    }
}
public class CreateReceiptItemValidator : AbstractValidator<CreateReceiptItemCommand>
{
    public CreateReceiptItemValidator()
    {
        RuleFor(x => x.ReceiptItem).SetValidator(new CreateReceiptItemDtoValidator());
    }
}
public class UpdateReceiptItmStockAttrValueValidator : AbstractValidator<UpdateReceiptItmStockAttrValueCommand>
{
    public UpdateReceiptItmStockAttrValueValidator()
    {
        RuleFor(x => x.ReceiptItmStockAttrValue).SetValidator(new UpdateReceiptItmStockAttrValueDtoValidator());
    }
}
public class CreateReceiptItmStockAttrValueValidator : AbstractValidator<CreateReceiptItmStockAttrValueCommand>
{
    public CreateReceiptItmStockAttrValueValidator()
    {
        RuleFor(x => x.ReceiptItmStockAttrValue).SetValidator(new CreateReceiptItmStockAttrValueDtoValidator());
    }
}
public class UpdateReceiptMemoValidator : AbstractValidator<UpdateReceiptMemoCommand>
{
    public UpdateReceiptMemoValidator()
    {
        RuleFor(x => x.ReceiptMemo).SetValidator(new UpdateReceiptMemoDtoValidator());
    }
}
public class CreateReceiptMemoValidator : AbstractValidator<CreateReceiptMemoCommand>
{
    public CreateReceiptMemoValidator()
    {
        RuleFor(x => x.ReceiptMemo).SetValidator(new CreateReceiptMemoDtoValidator());
    }
}
public class UpdateReceiptValidator : AbstractValidator<UpdateReceiptCommand>
{
    public UpdateReceiptValidator()
    {
        RuleFor(x => x.Receipt).SetValidator(new UpdateReceiptDtoValidator());
    }
}
public class CreateReceiptValidator : AbstractValidator<CreateReceiptCommand>
{
    public CreateReceiptValidator()
    {
        RuleFor(x => x.Receipt).SetValidator(new CreateReceiptDtoValidator());
    }
}
public class UpdateReceiptTypeValidator : AbstractValidator<UpdateReceiptTypeCommand>
{
    public UpdateReceiptTypeValidator()
    {
        RuleFor(x => x.ReceiptType).SetValidator(new UpdateReceiptTypeDtoValidator());
    }
}
public class CreateReceiptTypeValidator : AbstractValidator<CreateReceiptTypeCommand>
{
    public CreateReceiptTypeValidator()
    {
        RuleFor(x => x.ReceiptType).SetValidator(new CreateReceiptTypeDtoValidator());
    }
}
