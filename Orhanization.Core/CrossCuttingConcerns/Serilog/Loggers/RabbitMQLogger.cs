using Microsoft.Extensions.Configuration;
using Orhanization.Core.CrossCuttingConcerns.Serilog.ConfigurationModels;
using Serilog;
using Serilog.Formatting.Json;
using Serilog.Sinks.RabbitMQ;

namespace Orhanization.Core.CrossCuttingConcerns.Serilog.Loggers;

public class RabbitMQLogger : LoggerServiceBase
{
    public RabbitMQLogger(IConfiguration configuration)
    {
        const string configurationSection = "SeriLogConfigurations:RabbitMQConfiguration";
        RabbitMQConfiguration rabbitMQConfiguration =
            configuration.GetSection(configurationSection).Get<RabbitMQConfiguration>()
            ?? throw new NullReferenceException($"\"{configurationSection}\" section cannot found in configuration.");

        Logger = new LoggerConfiguration().WriteTo
            .RabbitMQ(
                hostnames: rabbitMQConfiguration.Hostnames.ToArray(),
                username: rabbitMQConfiguration.Username,
                password: rabbitMQConfiguration.Password,
                port: rabbitMQConfiguration.Port,
                exchange: rabbitMQConfiguration.Exchange,
                exchangeType: rabbitMQConfiguration.ExchangeType,
                deliveryMode: RabbitMQDeliveryMode.Durable,
                routingKey: rabbitMQConfiguration.RouteKey,
                formatter: new JsonFormatter()
            )
            .CreateLogger();
    }
}
