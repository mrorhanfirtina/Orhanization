using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Validators;

public class CreateOrderTypeValidator : AbstractValidator<CreateOrderTypeCommand>
{
    public CreateOrderTypeValidator()
    {
        RuleFor(x => x.OrderType).SetValidator(new CreateOrderTypeDtoValidator());
    }
}
