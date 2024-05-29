using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Dtos.DtoValidators;

public class UpdateOrderPriorityDtoValidator : AbstractValidator<UpdateOrderPriorityDto>
{
    public UpdateOrderPriorityDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.OrderId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.PriorityId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}







