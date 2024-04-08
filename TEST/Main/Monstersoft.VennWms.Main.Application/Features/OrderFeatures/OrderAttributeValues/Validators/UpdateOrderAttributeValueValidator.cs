using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Validators;

public class UpdateOrderAttributeValueValidator : AbstractValidator<UpdateOrderAttributeValueCommand>
{
    public UpdateOrderAttributeValueValidator()
    {
        RuleFor(x => x.OrderAttributeValue).SetValidator(new UpdateOrderAttributeValueDtoValidator());
    }
}
