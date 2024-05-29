using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.DtoValidators;

public class CreateReceiverDtoValidator : AbstractValidator<CreateReceiverDto>
{
    public CreateReceiverDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(120);
        RuleFor(p => p.CustomerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.Address).SetValidator(new CreateAddressSubDtoValidator());

    }
}



