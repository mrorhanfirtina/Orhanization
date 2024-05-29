using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.DtoValidators;

public class CreateReturnTypeDtoValidator : AbstractValidator<CreateReturnTypeDto>
{
    public CreateReturnTypeDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsCodeGenerate).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.Counter).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Format).NotEmpty().NotNull().MaximumLength(20);
        RuleForEach(x => x.Returns).SetValidator(new CreateReturnSubDtoValidator());
    }
}



