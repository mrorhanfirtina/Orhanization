using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Validators;

public class UpdateOrderAttributeValueValidator : AbstractValidator<UpdateOrderAttributeValueCommand>
{
    public UpdateOrderAttributeValueValidator()
    {
        RuleFor(x => x.OrderAttributeValue).SetValidator(new UpdateOrderAttributeValueDtoValidator());
    }
}
