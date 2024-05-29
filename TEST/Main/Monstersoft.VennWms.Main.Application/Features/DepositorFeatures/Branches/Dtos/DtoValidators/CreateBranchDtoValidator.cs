using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.DtoValidators;

public class CreateBranchDtoValidator : AbstractValidator<CreateBranchDto>
{
    public CreateBranchDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(120);
        RuleFor(p => p.DistributorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.Address).NotNull().SetValidator(new CreateAddressSubDtoValidator());
    }
}



