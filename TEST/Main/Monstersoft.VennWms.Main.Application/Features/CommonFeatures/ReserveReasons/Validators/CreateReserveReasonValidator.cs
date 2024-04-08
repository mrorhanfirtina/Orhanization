using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Validators;

public class CreateReserveReasonValidator : AbstractValidator<CreateReserveReasonCommand>
{
    public CreateReserveReasonValidator()
    {
        RuleFor(x => x.ReserveReason).SetValidator(new CreateReserveReasonDtoValidator());
    }
}
