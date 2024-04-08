using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Validators;

public class UpdateOrderAttributeValidator : AbstractValidator<UpdateOrderAttributeCommand>
{
    public UpdateOrderAttributeValidator()
    {
        RuleFor(x => x.OrderAttribute).SetValidator(new UpdateOrderAttributeDtoValidator());
    }
}
