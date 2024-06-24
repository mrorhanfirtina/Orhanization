using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.DtoValidators;

public class UpdatePoMemoSubDtoValidator : AbstractValidator<UpdatePoMemoSubDto>
{
    public UpdatePoMemoSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}


