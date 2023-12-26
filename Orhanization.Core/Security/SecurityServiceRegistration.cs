using Microsoft.Extensions.DependencyInjection;
using Orhanization.Core.Security.EmailAuthenticator;
using Orhanization.Core.Security.JWT;
using Orhanization.Core.Security.OtpAuthenticator.OtpNet;
using Orhanization.Core.Security.OtpAuthenticator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.Security;

public static class SecurityServiceRegistration
{
    public static IServiceCollection AddSecurityServices(this IServiceCollection services)
    {
        services.AddScoped<ITokenHelper, JwtHelper>();
        services.AddScoped<IEmailAuthenticatorHelper, EmailAuthenticatorHelper>();
        services.AddScoped<IOtpAuthenticatorHelper, OtpNetOtpAuthenticatorHelper>();
        return services;
    }
}
