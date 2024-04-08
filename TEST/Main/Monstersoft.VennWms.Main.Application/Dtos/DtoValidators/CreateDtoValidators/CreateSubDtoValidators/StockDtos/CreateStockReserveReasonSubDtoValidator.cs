using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.StockDtos;

public class CreateStockReserveReasonSubDtoValidator : AbstractValidator<CreateStockReserveReasonSubDto>
{
    public CreateStockReserveReasonSubDtoValidator()
    {
        RuleFor(p => p.ReserveReasonId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


