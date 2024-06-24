using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.DtoValidators;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Validators;

public class CreateProductDepositorValidator : AbstractValidator<CreateProductDepositorCommand>
{
    public CreateProductDepositorValidator()
    {
        RuleFor(x => x.ProductDepositor).SetValidator(new CreateProductDepositorDtoValidator());
    }
}


