using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Validators;

public class UpdateOrderTypeValidator : AbstractValidator<UpdateOrderTypeCommand>
{
    public UpdateOrderTypeValidator()
    {
        RuleFor(x => x.OrderType).SetValidator(new UpdateOrderTypeDtoValidator());
    }
}
