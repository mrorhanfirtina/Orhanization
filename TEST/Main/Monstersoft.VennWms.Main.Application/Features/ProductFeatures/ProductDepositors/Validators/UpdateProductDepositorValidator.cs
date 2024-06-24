using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.DtoValidators;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Validators;

public class UpdateProductDepositorValidator : AbstractValidator<UpdateProductDepositorCommand>
{
    public UpdateProductDepositorValidator()
    {
        RuleFor(x => x.ProductDepositor).SetValidator(new UpdateProductDepositorDtoValidator());
    }
}


