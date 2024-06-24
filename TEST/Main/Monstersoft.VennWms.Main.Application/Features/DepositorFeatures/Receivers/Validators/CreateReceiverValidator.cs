using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Validators;

public class CreateReceiverValidator : AbstractValidator<CreateReceiverCommand>
{
    public CreateReceiverValidator()
    {
        RuleFor(x => x.Receiver).SetValidator(new CreateReceiverDtoValidator());
    }
}
