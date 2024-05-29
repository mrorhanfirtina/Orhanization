using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Validators;

public class CreateOrderAttributeValueValidator : AbstractValidator<CreateOrderAttributeValueCommand>
{
    public CreateOrderAttributeValueValidator()
    {
        RuleFor(x => x.OrderAttributeValue).SetValidator(new CreateOrderAttributeValueDtoValidator());
    }
}
