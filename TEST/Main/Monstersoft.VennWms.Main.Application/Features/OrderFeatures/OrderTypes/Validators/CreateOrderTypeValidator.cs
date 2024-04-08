using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Validators;

public class CreateOrderTypeValidator : AbstractValidator<CreateOrderTypeCommand>
{
    public CreateOrderTypeValidator()
    {
        RuleFor(x => x.OrderType).SetValidator(new CreateOrderTypeDtoValidator());
    }
}
