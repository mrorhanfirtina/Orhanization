using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Validators;

public class CreateOrderAttributeValidator : AbstractValidator<CreateOrderAttributeCommand>
{
    public CreateOrderAttributeValidator()
    {
        RuleFor(x => x.OrderAttribute).SetValidator(new CreateOrderAttributeDtoValidator());
    }
}
