using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.ElasticSearch.Models;

public interface IElasticSearchResult
{
    public bool Success { get; }
    public string? Message { get; }
}
