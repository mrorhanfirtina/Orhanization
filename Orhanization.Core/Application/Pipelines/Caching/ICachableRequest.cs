using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.Application.Pipelines.Caching;

public interface ICachableRequest
{
    public string CacheKey { get; }
    bool ByPassCache { get; }
    public string? CacheGroupKey { get; }
    TimeSpan? SlidingExpiration { get; }
}
