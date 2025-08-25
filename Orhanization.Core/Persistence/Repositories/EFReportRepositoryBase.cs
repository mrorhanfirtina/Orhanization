using Microsoft.EntityFrameworkCore;
using Orhanization.Core.Persistence.Dynamic.Aggregate;
using System.Reflection;

namespace Orhanization.Core.Persistence.Repositories;

/// <summary>
/// Non-generic raporlama/aggregate repository (paginate yok, max 500 ToDynamicAggregate içinde).
/// </summary>
public class EFReportRepositoryBase<TContext> : IAsyncReportRepository where TContext : DbContext
{
    protected readonly TContext Context;
    public EFReportRepositoryBase(TContext context) => Context = context;

    /// <summary>
    /// Entity tipini vererek aggregate/raporlama yapar.
    /// includePaths: "Customer", "OrderItems.Product" gibi string Include yolları
    /// </summary>
    public async Task<List<object>> GetAggregateAsync(
        Type entityType,
        AggregateQuery aq,
        IEnumerable<string>? includePaths = null,
        bool withDeleted = false,
        bool enableTracking = true,
        bool autoInclude = false,
        CancellationToken cancellationToken = default)
    {
        // 1) DbSet<TEntity> → IQueryable
        IQueryable source = GetSetAsQueryable(entityType);

        // 2) Tracking / QueryFilters / AutoIncludes
        if (!enableTracking)
            source = AsNoTrackingNonGeneric(source);

        if (withDeleted)
            source = IgnoreQueryFiltersNonGeneric(source);

        if (!autoInclude)
            source = IgnoreAutoIncludesNonGeneric(source);

        // 3) Include(string)
        if (includePaths is not null)
        {
            foreach (var path in includePaths)
                source = IncludeStringNonGeneric(source, path);
        }

        // 4) Aggregate pipeline (GroupBy/Agg/Having/Select/Sort/Limit(≤500))
        IQueryable aggregated = source.ToDynamicAggregate(aq);

        // 5) Materialize (paginate yok → direkt liste)
        var items = await ToListAsyncNonGeneric(aggregated, cancellationToken);
        return items.Cast<object>().ToList();
    }

    /// <summary>
    /// DbSet adıyla çağırmak istersen (örn: "Orders")
    /// </summary>
    public Task<List<object>> GetAggregateAsync(
        string dbSetName,
        AggregateQuery aq,
        IEnumerable<string>? includePaths = null,
        bool withDeleted = false,
        bool enableTracking = true,
        bool autoInclude = false,
        CancellationToken cancellationToken = default)
    {
        var setProp = Context.GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .FirstOrDefault(p =>
                p.PropertyType.IsGenericType &&
                p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) &&
                string.Equals(p.Name, dbSetName, StringComparison.OrdinalIgnoreCase));

        if (setProp is null)
            throw new InvalidOperationException($"DbSet '{dbSetName}' bulunamadı.");

        var entityType = setProp.PropertyType.GetGenericArguments()[0];
        return GetAggregateAsync(entityType, aq, includePaths, withDeleted, enableTracking, autoInclude, cancellationToken);
    }

    // -------------------- Helpers: DbSet/IQueryable üretimi --------------------

    private IQueryable GetSetAsQueryable(Type entityType)
    {
        // Context.Set<TEntity>()
        var mi = typeof(DbContext).GetMethod(nameof(DbContext.Set), Type.EmptyTypes)!;
        var closed = mi.MakeGenericMethod(entityType);
        var dbSet = closed.Invoke(Context, null)!; // DbSet<TEntity>
        return (IQueryable)dbSet;
    }

    // -------------------- Helpers: EF Core generic extension çağrıları --------------------

    private static IQueryable AsNoTrackingNonGeneric(IQueryable q)
    {
        var mi = typeof(EntityFrameworkQueryableExtensions).GetMethods()
            .First(m => m.Name == nameof(EntityFrameworkQueryableExtensions.AsNoTracking)
                        && m.IsGenericMethodDefinition
                        && m.GetParameters().Length == 1);
        var closed = mi.MakeGenericMethod(q.ElementType);
        return (IQueryable)closed.Invoke(null, new object[] { q })!;
    }

    private static IQueryable IgnoreQueryFiltersNonGeneric(IQueryable q)
    {
        var mi = typeof(EntityFrameworkQueryableExtensions).GetMethods()
            .First(m => m.Name == nameof(EntityFrameworkQueryableExtensions.IgnoreQueryFilters)
                        && m.IsGenericMethodDefinition
                        && m.GetParameters().Length == 1);
        var closed = mi.MakeGenericMethod(q.ElementType);
        return (IQueryable)closed.Invoke(null, new object[] { q })!;
    }

    private static IQueryable IgnoreAutoIncludesNonGeneric(IQueryable q)
    {
        var mi = typeof(EntityFrameworkQueryableExtensions).GetMethods()
            .First(m => m.Name == nameof(EntityFrameworkQueryableExtensions.IgnoreAutoIncludes)
                        && m.IsGenericMethodDefinition
                        && m.GetParameters().Length == 1);
        var closed = mi.MakeGenericMethod(q.ElementType);
        return (IQueryable)closed.Invoke(null, new object[] { q })!;
    }

    private static IQueryable IncludeStringNonGeneric(IQueryable q, string path)
    {
        // EF Core string Include: Include<T>(IQueryable<T>, string)
        var mi = typeof(EntityFrameworkQueryableExtensions).GetMethods()
            .First(m => m.Name == nameof(EntityFrameworkQueryableExtensions.Include)
                        && m.IsGenericMethodDefinition
                        && m.GetParameters().Length == 2
                        && m.GetParameters()[1].ParameterType == typeof(string));
        var closed = mi.MakeGenericMethod(q.ElementType);
        return (IQueryable)closed.Invoke(null, new object[] { q, path })!;
    }

    private static async Task<System.Collections.IList> ToListAsyncNonGeneric(IQueryable q, CancellationToken ct)
    {
        var mi = typeof(EntityFrameworkQueryableExtensions).GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name == nameof(EntityFrameworkQueryableExtensions.ToListAsync)
                     && m.IsGenericMethodDefinition
                     && m.GetParameters().Length == 2);
        var closed = mi.MakeGenericMethod(q.ElementType);
        var task = (Task)closed.Invoke(null, new object[] { q, ct })!;
        await task.ConfigureAwait(false);
        return (System.Collections.IList)task.GetType().GetProperty("Result")!.GetValue(task)!;
    }
}
