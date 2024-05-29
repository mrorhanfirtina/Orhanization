using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.DtoValidators;

public class UpdateDepositorDtoValidator : AbstractValidator<UpdateDepositorDto>
{
    public UpdateDepositorDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.CompanyId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.DepositorFeature).NotNull().SetValidator(new UpdateDepositorFeatureSubDtoValidator());
    }
}



