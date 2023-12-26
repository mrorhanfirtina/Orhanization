using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Orhanization.Core.CrossCuttingConcerns.Serilog.ConfigurationModels;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.CrossCuttingConcerns.Serilog.Loggers;

public class MongoDbLogger : LoggerServiceBase
{
    public MongoDbLogger(IConfiguration configuration)
    {
        const string configurationSection = "SeriLogConfigurations:MongoDbConfiguration";
        MongoDbConfiguration logConfiguration =
            configuration.GetSection(configurationSection).Get<MongoDbConfiguration>()
            ?? throw new NullReferenceException($"\"{configurationSection}\" section cannot found in configuration.");

        Logger = new LoggerConfiguration().WriteTo
            .MongoDBBson(cfg =>
            {
                MongoClient client = new(logConfiguration.ConnectionString);
                IMongoDatabase? mongoDbInstance = client.GetDatabase(logConfiguration.Collection);
                cfg.SetMongoDatabase(mongoDbInstance);
            })
            .CreateLogger();
    }
}
