using Microsoft.Extensions.Configuration;
using Orhanization.Core.CrossCuttingConcerns.Serilog.ConfigurationModels;
using Serilog.Formatting.Elasticsearch;
using Serilog.Sinks.Elasticsearch;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.CrossCuttingConcerns.Serilog.Loggers;

public class ElasticSearchLogger : LoggerServiceBase
{
    public ElasticSearchLogger(IConfiguration configuration)
    {
        const string configurationSection = "SeriLogConfigurations:ElasticSearchConfiguration";
        ElasticSearchConfiguration logConfiguration =
            configuration.GetSection(configurationSection).Get<ElasticSearchConfiguration>()
            ?? throw new NullReferenceException($"\"{configurationSection}\" section cannot found in configuration.");

        Logger = new LoggerConfiguration().WriteTo
            .Elasticsearch(
                new ElasticsearchSinkOptions(new Uri(logConfiguration.ConnectionString))
                {
                    AutoRegisterTemplate = true,
                    AutoRegisterTemplateVersion = AutoRegisterTemplateVersion.ESv6,
                    CustomFormatter = new ExceptionAsObjectJsonFormatter(renderMessage: true)
                }
            )
            .CreateLogger();
    }
}