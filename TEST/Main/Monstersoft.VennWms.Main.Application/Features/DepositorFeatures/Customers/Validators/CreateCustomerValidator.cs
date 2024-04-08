using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Validators;

public class CreateCustomerValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerValidator()
    {
        RuleFor(x => x.Customer).SetValidator(new CreateCustomerDtoValidator());
    }
}
