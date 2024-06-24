using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;

public static class TransactionLogOperationClaims
{
    public const string Admin = "transactionlog.admin";
    public const string User = "transactionlog.user";
    public const string Read = "transactionlog.read";
    public const string Write = "transactionlog.write";
    public const string Add = "transactionlog.add";
    public const string Update = "transactionlog.update";
    public const string Delete = "transactionlog.delete";
}
