using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LocationDtos;

public class CreateLocationCodeFormatSubDtoValidator : AbstractValidator<CreateLocationCodeFormatSubDto>
{
    public CreateLocationCodeFormatSubDtoValidator()
    {
        RuleFor(p => p.Sector).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.SectorCode).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Column).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.ColumnCode).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Level).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.LevelCode).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Side).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.SideCode).MaximumLength(30);
        RuleFor(p => p.SubLevel).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.SubLevelCode).MaximumLength(30);
        RuleFor(p => p.SubColumn).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.SubColumnCode).MaximumLength(30);
        RuleFor(p => p.SubPositionCode).MaximumLength(30);
    }
}
