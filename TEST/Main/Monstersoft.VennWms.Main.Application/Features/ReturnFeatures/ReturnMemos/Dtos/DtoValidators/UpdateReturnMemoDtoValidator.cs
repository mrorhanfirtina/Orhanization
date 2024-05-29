﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.DtoValidators;

public class UpdateReturnMemoDtoValidator : AbstractValidator<UpdateReturnMemoDto>
{
    public UpdateReturnMemoDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}



