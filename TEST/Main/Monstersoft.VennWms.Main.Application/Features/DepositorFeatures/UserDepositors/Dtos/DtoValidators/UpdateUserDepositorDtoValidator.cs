using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.DtoValidators;

public class UpdateUserDepositorDtoValidator : AbstractValidator<UpdateUserDepositorDto>
{
    public UpdateUserDepositorDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.UserId).NotEmpty().NotEmpty().InclusiveBetween(1, int.MaxValue);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
