using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.StockDtos;

public class CreateStockUnsuitReasonSubDtoValidator : AbstractValidator<CreateStockUnsuitReasonSubDto>
{
    public CreateStockUnsuitReasonSubDtoValidator()
    {
        RuleFor(p => p.UnsuitReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


