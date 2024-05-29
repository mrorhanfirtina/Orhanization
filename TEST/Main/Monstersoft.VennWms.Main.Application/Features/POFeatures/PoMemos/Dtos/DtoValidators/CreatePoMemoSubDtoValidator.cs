using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.DtoValidators;

public class CreatePoMemoSubDtoValidator : AbstractValidator<CreatePoMemoSubDto>
{
    public CreatePoMemoSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}


