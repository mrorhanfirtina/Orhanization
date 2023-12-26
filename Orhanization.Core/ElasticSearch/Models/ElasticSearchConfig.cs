using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.ElasticSearch.Models;

public class ElasticSearchConfig
{
    public string ConnectionString { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public ElasticSearchConfig()
    {
        ConnectionString = string.Empty;
        UserName = string.Empty;
        Password = string.Empty;
    }

    public ElasticSearchConfig(string connectionString, string userName, string password)
    {
        ConnectionString = connectionString;
        UserName = userName;
        Password = password;
    }
}