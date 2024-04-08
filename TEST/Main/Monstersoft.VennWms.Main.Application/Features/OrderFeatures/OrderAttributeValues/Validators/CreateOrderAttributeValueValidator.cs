using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Validators;

public class CreateOrderAttributeValueValidator : AbstractValidator<CreateOrderAttributeValueCommand>
{
    public CreateOrderAttributeValueValidator()
    {
        RuleFor(x => x.OrderAttributeValue).SetValidator(new CreateOrderAttributeValueDtoValidator());
    }
}
