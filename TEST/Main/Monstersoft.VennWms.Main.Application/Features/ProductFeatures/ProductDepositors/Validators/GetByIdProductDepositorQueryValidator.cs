using FluentValidation;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Validators;

public class GetByIdProductDepositorQueryValidator : AbstractValidator<GetByIdProductDepositorQuery>
{
    public GetByIdProductDepositorQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


