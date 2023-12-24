using Microsoft.Extensions.Configuration;
using Orhanization.Core.CrossCuttingConcerns.Serilog.ConfigurationModels;
using Orhanization.Core.CrossCuttingConcerns.Serilog.Messages;
using Serilog.Sinks.MSSqlServer;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.CrossCuttingConcerns.Serilog.Loggers;

public class MsSqlLogger : LoggerServiceBase
{
    public MsSqlLogger(IConfiguration configuration)
    {
        MsSqlConfiguration logConfig = configuration.GetSection("SeriLogConfigurations:MsSqlLogConfiguration").Get<MsSqlConfiguration>() ?? throw new Exception(SerilogMessages.NullOptionsMessage);

        MSSqlServerSinkOptions sinkOptions = new()
        {
            TableName = logConfig.TableName,
            AutoCreateSqlTable = logConfig.AutoCreateSqlTable,
        };

        ColumnOptions columnOptions = new();

        global::Serilog.Core.Logger seriLogger = new LoggerConfiguration().WriteTo.MSSqlServer(logConfig.ConnectionString, sinkOptions, columnOptions: columnOptions).CreateLogger();

        Logger = seriLogger;
    }
}
