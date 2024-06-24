using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Validators;

public class UpdateOrderAttributeValidator : AbstractValidator<UpdateOrderAttributeCommand>
{
    public UpdateOrderAttributeValidator()
    {
        RuleFor(x => x.OrderAttribute).SetValidator(new UpdateOrderAttributeDtoValidator());
    }
}
