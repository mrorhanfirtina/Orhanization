using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Validators;

public class CreateSupplierValidator : AbstractValidator<CreateSupplierCommand>
{
    public CreateSupplierValidator()
    {
        RuleFor(x => x.Supplier).SetValidator(new CreateSupplierDtoValidator());
    }
}
