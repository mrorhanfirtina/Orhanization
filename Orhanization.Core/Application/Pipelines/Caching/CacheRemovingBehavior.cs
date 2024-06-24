using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Orhanization.Core.Security.Extensions;
using System.Text;
using System.Text.Json;

namespace Orhanization.Core.Application.Pipelines.Caching;

public class CacheRemovingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>, ICacheRemoveRequest
{
    private readonly IDistributedCache _cache;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CacheRemovingBehavior(IDistributedCache cache, IHttpContextAccessor httpContextAccessor)
    {
        _cache = cache;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (request.ByPassCache)
        {
            return await next();
        }

        TResponse response = await next();

        foreach (var item in request.CacheGroupKey?.ToList())
        {
            string cacheGroupWithLocality = item + _httpContextAccessor.HttpContext.User.GetUserLocalityId();

            if (cacheGroupWithLocality != null)
            {

                byte[]? cachedGroup = await _cache.GetAsync(cacheGroupWithLocality!, cancellationToken);
                if (cachedGroup != null)
                {
                    HashSet<string> keysInGroup = JsonSerializer.Deserialize<HashSet<string>>(Encoding.Default.GetString(cachedGroup))!;
                    foreach (string key in keysInGroup)
                    {
                        await _cache.RemoveAsync(key, cancellationToken);
                    }

                    await _cache.RemoveAsync(cacheGroupWithLocality, cancellationToken);
                    await _cache.RemoveAsync(key: $"{cacheGroupWithLocality}SlidingExpiration", cancellationToken);
                }
            }

            if (request.CacheKey != null)
            {
                await _cache.RemoveAsync(request.CacheKey, cancellationToken);
            }
        }

        return response;
    }
}

