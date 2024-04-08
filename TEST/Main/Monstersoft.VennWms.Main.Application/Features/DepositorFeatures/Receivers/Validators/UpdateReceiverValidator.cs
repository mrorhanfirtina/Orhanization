using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Validators;

public class UpdateReceiverValidator : AbstractValidator<UpdateReceiverCommand>
{
    public UpdateReceiverValidator()
    {
        RuleFor(x => x.Receiver).SetValidator(new UpdateReceiverDtoValidator());
    }
}
