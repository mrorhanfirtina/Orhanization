using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LoggingDtos;

public class CreateLogStockUnsuitReasonSubDtoValidator : AbstractValidator<CreateLogStockUnsuitReasonSubDto>
{
    public CreateLogStockUnsuitReasonSubDtoValidator()
    {
        RuleFor(p => p.FromReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


