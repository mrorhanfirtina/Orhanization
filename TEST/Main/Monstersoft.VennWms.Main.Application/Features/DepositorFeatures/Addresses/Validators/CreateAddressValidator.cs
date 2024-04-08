using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Validators;

public class CreateAddressValidator : AbstractValidator<CreateAddressCommand>
{
    public CreateAddressValidator()
    {
        RuleFor(x => x.Address).SetValidator(new CreateAddressDtoValidator());
    }
}
