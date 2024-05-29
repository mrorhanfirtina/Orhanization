using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.DtoValidators;

public class CreateUserDepositorDtoValidator : AbstractValidator<CreateUserDepositorDto>
{
    public CreateUserDepositorDtoValidator()
    {
        RuleFor(p => p.UserId).NotEmpty().NotEmpty().InclusiveBetween(1, int.MaxValue);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}