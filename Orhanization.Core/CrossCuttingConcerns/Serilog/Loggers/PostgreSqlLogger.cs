using Microsoft.Extensions.Configuration;
using NpgsqlTypes;
using Orhanization.Core.CrossCuttingConcerns.Serilog.ConfigurationModels;
using Orhanization.Core.CrossCuttingConcerns.Serilog.Messages;
using Serilog.Sinks.PostgreSQL;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.CrossCuttingConcerns.Serilog.Loggers;

public class PostgreSqlLogger : LoggerServiceBase
{
    public PostgreSqlLogger(IConfiguration configuration)
    {
        PostgreSqlConfiguration postgreConfiguration =
            configuration.GetSection("SeriLogConfigurations:PostgreConfiguration").Get<PostgreSqlConfiguration>()
            ?? throw new Exception(SerilogMessages.NullOptionsMessage);

        IDictionary<string, ColumnWriterBase> columnWriters = new Dictionary<string, ColumnWriterBase>
        {
            { "message", new RenderedMessageColumnWriter() },
            { "message_template", new MessageTemplateColumnWriter() },
            { "level", new LevelColumnWriter(renderAsText: true, NpgsqlDbType.Varchar) },
            { "raise_date", new TimestampColumnWriter() },
            { "exception", new ExceptionColumnWriter() },
            { "properties", new LogEventSerializedColumnWriter() },
            { "props_test", new PropertiesColumnWriter() },
            { "machine_name", new SinglePropertyColumnWriter(propertyName: "MachineName", format: "l") }
        };

        global::Serilog.Core.Logger loggerConfiguration = new LoggerConfiguration().WriteTo
            .PostgreSQL(
                postgreConfiguration.ConnectionString,
                postgreConfiguration.TableName,
                columnWriters,
                needAutoCreateTable: postgreConfiguration.NeedAutoCreateTable
            )
            .CreateLogger();
        Logger = loggerConfiguration;
    }
}
