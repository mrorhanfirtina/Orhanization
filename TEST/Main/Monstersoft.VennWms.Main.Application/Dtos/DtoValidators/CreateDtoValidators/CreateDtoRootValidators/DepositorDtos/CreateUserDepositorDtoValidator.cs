using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.DepositorDtos;

public class CreateUserDepositorDtoValidator : AbstractValidator<CreateUserDepositorDto>
{
    public CreateUserDepositorDtoValidator()
    {
        RuleFor(p => p.UserId).NotEmpty().NotEmpty().InclusiveBetween(1, int.MaxValue);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}