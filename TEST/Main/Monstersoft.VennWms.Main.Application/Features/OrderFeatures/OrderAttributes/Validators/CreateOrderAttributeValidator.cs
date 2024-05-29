using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Validators;

public class CreateOrderAttributeValidator : AbstractValidator<CreateOrderAttributeCommand>
{
    public CreateOrderAttributeValidator()
    {
        RuleFor(x => x.OrderAttribute).SetValidator(new CreateOrderAttributeDtoValidator());
    }
}
