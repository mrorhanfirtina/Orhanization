using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Validators;

public class CreateReceiverValidator : AbstractValidator<CreateReceiverCommand>
{
    public CreateReceiverValidator()
    {
        RuleFor(x => x.Receiver).SetValidator(new CreateReceiverDtoValidator());
    }
}
