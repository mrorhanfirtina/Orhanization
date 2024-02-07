using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.Register.Validators;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(c => c.UserForRegisterDto.FirstName).NotEmpty().MinimumLength(2);
        RuleFor(c => c.UserForRegisterDto.LastName).NotEmpty().MinimumLength(2);
        RuleFor(c => c.UserForRegisterDto.Email).NotEmpty().EmailAddress();
        RuleFor(c => c.UserForRegisterDto.Password).NotEmpty().MinimumLength(4);
    }
}
