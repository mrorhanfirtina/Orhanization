using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Validators;

public class UpdateCustomerValidator : AbstractValidator<UpdateCustomerCommand>
{
    public UpdateCustomerValidator()
    {
        RuleFor(x => x.Customer).SetValidator(new UpdateCustomerDtoValidator());
    }
}
