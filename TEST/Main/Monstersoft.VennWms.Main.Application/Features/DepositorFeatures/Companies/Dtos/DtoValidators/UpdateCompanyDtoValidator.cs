using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Dtos.DtoValidators;

public class UpdateCompanyDtoValidator : AbstractValidator<UpdateCompanyDto>
{
    public UpdateCompanyDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(120);
        RuleFor(p => p.Description).MaximumLength(120);
        RuleFor(p => p.TaxOffice).MaximumLength(30);
        RuleFor(p => p.TaxNumber).MaximumLength(30);
        RuleFor(p => p.PhoneNumber).MaximumLength(15);
        RuleFor(p => p.FaxNumber).MaximumLength(15);
        RuleFor(x => x.Address).SetValidator(new UpdateAddressSubDtoValidator());
    }
}



