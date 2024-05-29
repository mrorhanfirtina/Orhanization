using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Validators;

public class UpdateReceiverValidator : AbstractValidator<UpdateReceiverCommand>
{
    public UpdateReceiverValidator()
    {
        RuleFor(x => x.Receiver).SetValidator(new UpdateReceiverDtoValidator());
    }
}
