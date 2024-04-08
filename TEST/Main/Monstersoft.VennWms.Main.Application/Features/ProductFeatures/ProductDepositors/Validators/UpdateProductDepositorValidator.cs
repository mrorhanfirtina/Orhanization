using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Update;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Validators;

public class UpdateProductDepositorValidator : AbstractValidator<UpdateProductDepositorCommand>
{
    public UpdateProductDepositorValidator()
    {
        RuleFor(x => x.ProductDepositor).SetValidator(new UpdateProductDepositorDtoValidator());
    }
}


