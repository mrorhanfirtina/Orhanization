using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.DepositorDtos;

public class UpdateDistributorSubDtoValidator : AbstractValidator<UpdateDistributorSubDto>
{
    public UpdateDistributorSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.CompanyId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.AddressId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.Address).SetValidator(new UpdateAddressSubDtoValidator());
    }
}


