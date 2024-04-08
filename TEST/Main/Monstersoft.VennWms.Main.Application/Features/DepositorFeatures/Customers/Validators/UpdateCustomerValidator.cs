using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Validators;

public class UpdateCustomerValidator : AbstractValidator<UpdateCustomerCommand>
{
    public UpdateCustomerValidator()
    {
        RuleFor(x => x.Customer).SetValidator(new UpdateCustomerDtoValidator());
    }
}
