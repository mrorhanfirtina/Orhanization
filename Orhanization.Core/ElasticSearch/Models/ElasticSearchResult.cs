using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.ElasticSearch.Models;

public class ElasticSearchResult : IElasticSearchResult //todo: refactor
{
    public bool Success { get; }
    public string? Message { get; }

    public ElasticSearchResult()
    {
        Message = string.Empty;
    }

    public ElasticSearchResult(bool success, string? message = null)
    {
        Success = success;
        Message = message;
    }
}
