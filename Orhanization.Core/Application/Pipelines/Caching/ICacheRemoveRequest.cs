namespace Orhanization.Core.Application.Pipelines.Caching;

public interface ICacheRemoveRequest
{
    public string? CacheKey { get; }
    bool ByPassCache { get; }
    public string[]? CacheGroupKey { get; }
}
