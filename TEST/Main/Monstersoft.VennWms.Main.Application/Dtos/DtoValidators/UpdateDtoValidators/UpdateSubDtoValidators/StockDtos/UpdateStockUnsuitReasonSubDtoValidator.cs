using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.StockDtos;

public class UpdateStockUnsuitReasonSubDtoValidator : AbstractValidator<UpdateStockUnsuitReasonSubDto>
{
    public UpdateStockUnsuitReasonSubDtoValidator()
    {
        RuleFor(p => p.UnsuitReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


