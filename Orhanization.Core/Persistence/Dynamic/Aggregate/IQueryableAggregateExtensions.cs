using System.Linq.Dynamic.Core;

namespace Orhanization.Core.Persistence.Dynamic.Aggregate
{
    public static class IQueryableAggregateExtensions
    {
        private const int MAX_LIMIT = 500;

        public static IQueryable ToDynamicAggregate(this IQueryable source, AggregateQuery aq)
        {
            // 1) Base (mevcut) Filter + Sort — tip bağımsız uygula
            if (aq.Base is not null)
                source = ApplyBaseDynamicNonGeneric(source, aq.Base);

            bool hasGroup = aq.GroupBy is { } && aq.GroupBy.Any();
            bool hasAgg = aq.Aggregates is { } && aq.Aggregates.Any();

            if (hasGroup || hasAgg)
            {
                // 2) GROUP BY (Dynamic LINQ new(...) kalıbı)
                var groupKey = BuildGroupKey(aq.GroupBy);
                var grouped = source.GroupBy(groupKey);

                // 3) HAVING (opsiyonel) — GroupBy üstünde
                if (aq.Having is { } && aq.Having.Any())
                {
                    var having = BuildHaving(aq.Having, aq.Aggregates ?? Enumerable.Empty<Aggregate>());
                    if (!string.IsNullOrWhiteSpace(having.Expression))
                        grouped = grouped.Where(having.Expression, having.Values);
                }

                // 4) SELECT (key + aggregates)
                var selectExpr = BuildAggregateProjection(aq.GroupBy, aq.Aggregates ?? Enumerable.Empty<Aggregate>());
                var projected = grouped.Select(selectExpr);

                // 5) SORT (Base.Sort alias/alanlarıyla)
                if (aq.Base?.Sort is { } && aq.Base.Sort.Any())
                    projected = projected.OrderBy(BuildOrder(aq.Base.Sort));

                // 6) LIMIT
                var take = Math.Min(aq.Limit ?? MAX_LIMIT, MAX_LIMIT);
                return projected.Take(take);
            }
            else
            {
                // Grup yoksa düz projeksiyon + sort + limit
                if (aq.Select is { } && aq.Select.Any())
                {
                    var selectExpr = BuildFlatProjection(aq.Select);
                    source = source.Select(selectExpr);
                }

                if (aq.Base?.Sort is { } && aq.Base.Sort.Any())
                    source = source.OrderBy(BuildOrder(aq.Base.Sort));

                var take = Math.Min(aq.Limit ?? MAX_LIMIT, MAX_LIMIT);
                return source.Take(take);
            }
        }

        // ---------------- Base Filter + Sort'u tip bağımsız uygulayan yardımcı ----------------
        private static IQueryable ApplyBaseDynamicNonGeneric(IQueryable source, DynamicQuery baseQuery)
        {
            // FILTER
            if (baseQuery.Filter is not null)
            {
                var filters = IQueryableDynamicFilterExtensions.GetAllFilters(baseQuery.Filter);
                var values = filters.Select(f => f.Value).ToArray();
                var where = IQueryableDynamicFilterExtensions.Transform(baseQuery.Filter, filters);

                if (!string.IsNullOrWhiteSpace(where))
                    source = source.Where(where, values); // non-generic Where (Dynamic LINQ)
            }

            // SORT
            if (baseQuery.Sort is not null && baseQuery.Sort.Any())
            {
                var ordering = string.Join(",",
                    baseQuery.Sort.Select(s =>
                    {
                        var dir = string.IsNullOrWhiteSpace(s.Direction) ? "asc" : s.Direction.ToLowerInvariant();
                        if (dir != "asc" && dir != "desc") dir = "asc";
                        return $"{s.Field} {dir}";
                    }));

                source = source.OrderBy(ordering); // non-generic OrderBy (Dynamic LINQ)
            }

            return source;
        }
        // --------------------------------------------------------------------------------------

        // -------- helpers --------

        private static string BuildGroupKey(IEnumerable<string>? groupBy)
        {
            if (groupBy is null || !groupBy.Any())
                return "new (1 as DummyKey)"; // boş kalmasın

            // new (Customer.Name as Customer_Name, DepositorCode as DepositorCode)
            var parts = groupBy.Select(g =>
            {
                var alias = ToSafeAlias(g);
                return $"{g} as {alias}";
            });
            return $"new ({string.Join(", ", parts)})";
        }

        private static string BuildAggregateProjection(IEnumerable<string>? groupBy, IEnumerable<Aggregate> aggs)
        {
            var selects = new List<string>();

            foreach (var g in groupBy ?? Enumerable.Empty<string>())
            {
                var alias = ToSafeAlias(g); // Customer.Name -> Customer_Name
                selects.Add($"Key.{alias} as {alias}");
            }

            foreach (var a in aggs)
            {
                var alias = ToSafeAlias(a.As);
                var expr = a.Type.ToLowerInvariant() switch
                {
                    "count" => "Count()",
                    "sum" => $"Sum({a.Field})",
                    "avg" => $"Average({a.Field})",
                    "min" => $"Min({a.Field})",
                    "max" => $"Max({a.Field})",
                    _ => throw new ArgumentException($"Unsupported aggregate: {a.Type}")
                };
                selects.Add($"{expr} as {alias}");
            }

            return $"new ({string.Join(", ", selects)})";
        }

        private static string BuildFlatProjection(IEnumerable<string> select)
        {
            // new (Customer.Name as Customer_Name, CreatedAt as CreatedAt, TotalQty as TotalQty)
            var parts = select.Select(s =>
            {
                var alias = ToSafeAlias(s);
                return $"{s} as {alias}";
            });
            return $"new ({string.Join(", ", parts)})";
        }

        private static string BuildOrder(IEnumerable<Sort> sort)
        {
            // "Customer_Name asc, OrderCount desc"
            var items = sort.Select(s =>
            {
                var field = ToSafeAlias(s.Field); // aggregate alias veya path alan
                var dir = string.IsNullOrWhiteSpace(s.Direction) ? "asc" : s.Direction.ToLowerInvariant();
                if (dir != "asc" && dir != "desc") dir = "asc";
                return $"{field} {dir}";
            });
            return string.Join(", ", items);
        }

        private static string ToSafeAlias(string name)
            => name.Replace(".", "_").Replace(" ", "_");

        private record HavingExpr(string Expression, object[] Values);

        private static HavingExpr BuildHaving(IEnumerable<Having> having, IEnumerable<Aggregate> aggs)
        {
            var vals = new List<object>();
            var parts = new List<string>();

            foreach (var h in having)
            {
                var op = h.Op.ToLowerInvariant() switch
                {
                    "eq" => "==",
                    "neq" => "!=",
                    "gt" => ">",
                    "gte" => ">=",
                    "lt" => "<",
                    "lte" => "<=",
                    _ => throw new ArgumentException($"Unsupported having op: {h.Op}")
                };

                // Alias -> fonksiyon map’i (OrderCount -> Count())
                string left;
                var alias = aggs.FirstOrDefault(a => a.As.Equals(h.Field, StringComparison.OrdinalIgnoreCase));
                if (alias is not null)
                {
                    left = alias.Type.ToLowerInvariant() switch
                    {
                        "count" => "Count()",
                        "sum" => $"Sum({alias.Field})",
                        "avg" => $"Average({alias.Field})",
                        "min" => $"Min({alias.Field})",
                        "max" => $"Max({alias.Field})",
                        _ => throw new ArgumentException("Unsupported agg type")
                    };
                }
                else
                {
                    // Doğrudan fonksiyon yazıldıysa (örn. "Sum(TotalQty)")
                    left = h.Field;
                }

                parts.Add($"{left} {op} @{vals.Count}");
                vals.Add(h.Value ?? "");
            }

            return new HavingExpr(string.Join(" and ", parts), vals.ToArray());
        }
    }
}
