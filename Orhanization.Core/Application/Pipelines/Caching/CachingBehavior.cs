using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Orhanization.Core.Security.Extensions;
using System.Text;
using System.Text.Json;

namespace Orhanization.Core.Application.Pipelines.Caching;

public class CachingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>, ICachableRequest
{
    private readonly CacheSettings _cacheSettings;
    private readonly IDistributedCache _cache;
    private readonly IHttpContextAccessor _httpContextAccessor; //1.0.10

    public CachingBehavior(IDistributedCache cache, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
    {
        _cacheSettings = configuration.GetSection("CacheSettings").Get<CacheSettings>() ?? throw new InvalidOperationException();
        _cache = cache;
        _httpContextAccessor = httpContextAccessor; //1.0.10
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (request.ByPassCache)
        {
            return await next();
        }

        string cacheKey = request.CacheKey;
        if (cacheKey.Contains("$USER"))
        {
            string userId = _httpContextAccessor.HttpContext.User.GetUserId().ToString();
            cacheKey = request.CacheKey.Replace("$USER", userId);
        }

        TResponse response;
        byte[]? cachedResponse = await _cache.GetAsync(cacheKey, cancellationToken);

        if (cachedResponse != null)
        {
            response = JsonSerializer.Deserialize<TResponse>(Encoding.Default.GetString(cachedResponse));
        }
        else
        {
            response = await GetResponseAndAddToCache(request, next, cancellationToken);
        }

        return response;
    }

    private async Task<TResponse?> GetResponseAndAddToCache(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        TResponse response = await next();

        string cacheKey = request.CacheKey;
        if (cacheKey.Contains("$USER"))
        {
            string userId = _httpContextAccessor.HttpContext.User.GetUserId().ToString();
            cacheKey = request.CacheKey.Replace("$USER", userId);
        }

        TimeSpan slidingExpiration = request.SlidingExpiration ?? TimeSpan.FromDays(_cacheSettings.SlidingExpiration);
        DistributedCacheEntryOptions cacheOptions = new() { SlidingExpiration = slidingExpiration };

        byte[] serializeData = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(response));

        await _cache.SetAsync(cacheKey, serializeData, cacheOptions, cancellationToken);

        string cacheGroupKey = request.CacheGroupKey + _httpContextAccessor.HttpContext.User.GetUserLocalityId(); //1.0.10


        if (cacheGroupKey != null)
        {
            await AddCacheKeyToGroup(request, slidingExpiration, cancellationToken);
        }

        return response;
    }

    private async Task AddCacheKeyToGroup(TRequest request, TimeSpan slidingExpiration, CancellationToken cancellationToken)
    {
        string cacheKey = request.CacheKey;
        if (cacheKey.Contains("$USER"))
        {
            string userId = _httpContextAccessor.HttpContext.User.GetUserId().ToString();
            cacheKey = request.CacheKey.Replace("$USER", userId);
        }

        string cacheGroupWithLocality = request.CacheGroupKey + _httpContextAccessor.HttpContext.User.GetUserLocalityId(); //1.0.10

        byte[]? cacheGroupCache = await _cache.GetAsync(key: cacheGroupWithLocality!, cancellationToken); //1.0.10 old: request.CacheGroupKey!
        HashSet<string> cacheKeysInGroup;
        if (cacheGroupCache != null)
        {
            cacheKeysInGroup = JsonSerializer.Deserialize<HashSet<string>>(Encoding.Default.GetString(cacheGroupCache))!;
            if (!cacheKeysInGroup.Contains(cacheKey))
                cacheKeysInGroup.Add(cacheKey);
        }
        else
            cacheKeysInGroup = new HashSet<string>(new[] { cacheKey });
        byte[] newCacheGroupCache = JsonSerializer.SerializeToUtf8Bytes(cacheKeysInGroup);

        byte[]? cacheGroupCacheSlidingExpirationCache = await _cache.GetAsync(
            key: $"{cacheGroupWithLocality}SlidingExpiration",
            cancellationToken
        );
        int? cacheGroupCacheSlidingExpirationValue = null;
        if (cacheGroupCacheSlidingExpirationCache != null)
            cacheGroupCacheSlidingExpirationValue = Convert.ToInt32(Encoding.Default.GetString(cacheGroupCacheSlidingExpirationCache));
        if (cacheGroupCacheSlidingExpirationValue == null || slidingExpiration.TotalSeconds > cacheGroupCacheSlidingExpirationValue)
            cacheGroupCacheSlidingExpirationValue = Convert.ToInt32(slidingExpiration.TotalSeconds);
        byte[] serializeCachedGroupSlidingExpirationData = JsonSerializer.SerializeToUtf8Bytes(cacheGroupCacheSlidingExpirationValue);

        DistributedCacheEntryOptions cacheOptions =
            new() { SlidingExpiration = TimeSpan.FromSeconds(Convert.ToDouble(cacheGroupCacheSlidingExpirationValue)) };

        await _cache.SetAsync(key: cacheGroupWithLocality!, newCacheGroupCache, cacheOptions, cancellationToken);

        await _cache.SetAsync(
            key: $"{cacheGroupWithLocality}SlidingExpiration",
            serializeCachedGroupSlidingExpirationData,
            cacheOptions,
            cancellationToken
        );
    }
}