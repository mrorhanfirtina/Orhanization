using Core.ElasticSearch;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Monstersoft.VennWms.Main.Application.Services.Abstract.AuthenticationServices;
using Monstersoft.VennWms.Main.Application.Services.Concrete.AuthenticationServices;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Pipelines.Validation;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Serilog;
using Orhanization.Core.CrossCuttingConcerns.Serilog.Loggers;
using Orhanization.Core.ElasticSearch;
using Orhanization.Core.Mailing;
using Orhanization.Core.Mailing.MailKitImplementations;
using System.Reflection;

namespace Monstersoft.VennWms.Main.Application.Registrations;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            configuration.AddOpenBehavior(typeof(AuthorizationBehavior<,>));
            configuration.AddOpenBehavior(typeof(RequestValidationBehavior<,>));
            configuration.AddOpenBehavior(typeof(TransactionScopeBehavior<,>));
            configuration.AddOpenBehavior(typeof(CachingBehavior<,>));
            configuration.AddOpenBehavior(typeof(CacheRemovingBehavior<,>));
            configuration.AddOpenBehavior(typeof(LoggingBehavior<,>));
            configuration.AddOpenBehavior(typeof(LocalityBehavior<,>));
        });

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        //services.AddScoped<LoggerServiceBase, FileLogger>();  //Dosya logu icin su anda kapalı sql acık.
        services.AddSingleton<LoggerServiceBase, MsSqlLogger>();

        
        services.AddScoped<IAuthService, AuthManager>();
        services.AddScoped<IAuthenticatorService, AuthenticatorManager>();
        services.AddScoped<IUserService, UserManager>();
        services.AddSingleton<IMailService, MailKitMailService>();
        services.AddSingleton<IElasticSearch, ElasticSearchManager>();

        return services;
    }


    public static IServiceCollection AddSubClassesOfType(
        this IServiceCollection services,
        Assembly assembly,
        Type type,
        Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null
    )
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();

        foreach (var item in types)
        {
            if (addWithLifeCycle == null)
            {
                services.AddScoped(item);
            }
            else
            {
                addWithLifeCycle(services, item);
            }
        }

        return services;

        //Subclass olanları bul IoC ye ekle.
    }
}
