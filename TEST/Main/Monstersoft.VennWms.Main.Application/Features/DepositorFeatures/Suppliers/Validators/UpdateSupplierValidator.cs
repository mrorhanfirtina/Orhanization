using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Validators;

public class UpdateSupplierValidator : AbstractValidator<UpdateSupplierCommand>
{
    public UpdateSupplierValidator()
    {
        RuleFor(x => x.Supplier).SetValidator(new UpdateSupplierDtoValidator());
    }
}
