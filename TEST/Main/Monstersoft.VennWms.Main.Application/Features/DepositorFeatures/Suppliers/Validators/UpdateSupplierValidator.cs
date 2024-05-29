using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Validators;

public class UpdateSupplierValidator : AbstractValidator<UpdateSupplierCommand>
{
    public UpdateSupplierValidator()
    {
        RuleFor(x => x.Supplier).SetValidator(new UpdateSupplierDtoValidator());
    }
}
