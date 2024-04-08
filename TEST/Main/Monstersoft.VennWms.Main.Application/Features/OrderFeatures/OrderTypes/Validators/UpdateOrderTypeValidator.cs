using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Validators;

public class UpdateOrderTypeValidator : AbstractValidator<UpdateOrderTypeCommand>
{
    public UpdateOrderTypeValidator()
    {
        RuleFor(x => x.OrderType).SetValidator(new UpdateOrderTypeDtoValidator());
    }
}
