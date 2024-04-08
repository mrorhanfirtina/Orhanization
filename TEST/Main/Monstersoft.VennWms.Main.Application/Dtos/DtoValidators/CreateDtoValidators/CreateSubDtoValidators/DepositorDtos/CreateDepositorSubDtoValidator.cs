using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.DepositorDtos;

public class CreateDepositorSubDtoValidator : AbstractValidator<CreateDepositorSubDto>
{
    public CreateDepositorSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(x => x.DepositorFeature).NotNull().SetValidator(new CreateDepositorFeatureSubDtoValidator());
    }
}


