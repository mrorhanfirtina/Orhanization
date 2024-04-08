using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Validators;

public class UpdateAddressValidator : AbstractValidator<UpdateAddressCommand>
{
    public UpdateAddressValidator()
    {
        RuleFor(x => x.Address).SetValidator(new UpdateAddressDtoValidator());
    }
}
