using Microsoft.Extensions.Configuration;
using Orhanization.Core.CrossCuttingConcerns.Serilog.ConfigurationModels;
using Serilog.Sinks.Graylog;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Sinks.Graylog.Core.Transport;

namespace Orhanization.Core.CrossCuttingConcerns.Serilog.Loggers;

public class GraylogLogger : LoggerServiceBase
{
    public GraylogLogger(IConfiguration configuration)
    {
        const string configurationSection = "SeriLogConfigurations:GraylogConfiguration";
        GraylogConfiguration logConfiguration =
            configuration.GetSection(configurationSection).Get<GraylogConfiguration>()
            ?? throw new NullReferenceException($"\"{configurationSection}\" section cannot found in configuration.");

        Logger = new LoggerConfiguration().WriteTo
            .Graylog(
                new GraylogSinkOptions
                {
                    HostnameOrAddress = logConfiguration.HostnameOrAddress,
                    Port = logConfiguration.Port,
                    TransportType = TransportType.Udp
                }
            )
            .CreateLogger();
    }
}
