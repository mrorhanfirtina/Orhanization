using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Validators;

public class CreateSupplierValidator : AbstractValidator<CreateSupplierCommand>
{
    public CreateSupplierValidator()
    {
        RuleFor(x => x.Supplier).SetValidator(new CreateSupplierDtoValidator());
    }
}
