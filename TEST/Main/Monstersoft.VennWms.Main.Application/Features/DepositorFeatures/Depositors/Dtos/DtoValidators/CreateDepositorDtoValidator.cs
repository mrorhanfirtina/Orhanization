using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.DtoValidators;

public class CreateDepositorDtoValidator : AbstractValidator<CreateDepositorDto>
{
    public CreateDepositorDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.CompanyId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.DepositorFeature).NotNull().SetValidator(new CreateDepositorFeatureSubDtoValidator());
    }
}



