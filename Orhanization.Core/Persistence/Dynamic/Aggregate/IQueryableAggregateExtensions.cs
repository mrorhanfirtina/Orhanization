using System.Linq.Dynamic.Core;

namespace Orhanization.Core.Persistence.Dynamic.Aggregate
{
    public static class IQueryableAggregateExtensions
    {
        private const int MAX_LIMIT = 500;

        public static IQueryable ToDynamicAggregate(this IQueryable source, AggregateQuery aq)
        {
            // --- 1) SADECE FİLTRE (erken sort YOK!) ---
            if (aq.Base?.Filter is not null)
                source = ApplyFilterOnlyNonGeneric(source, aq.Base.Filter);

            bool hasGroup = aq.GroupBy is { } && aq.GroupBy.Any();
            bool hasAgg = aq.Aggregates is { } && aq.Aggregates.Any();

            if (hasGroup || hasAgg)
            {
                // 2) GROUP BY
                var groupKey = BuildGroupKey(aq.GroupBy);
                var grouped = source.GroupBy(groupKey);

                // 3) HAVING
                if (aq.Having is { } && aq.Having.Any())
                {
                    var having = BuildHaving(aq.Having, aq.Aggregates ?? Enumerable.Empty<Aggregate>());
                    if (!string.IsNullOrWhiteSpace(having.Expression))
                        grouped = grouped.Where(having.Expression, having.Values);
                }

                // 4) SELECT (key + aggregates)
                var selectExpr = BuildAggregateProjection(aq.GroupBy, aq.Aggregates ?? Enumerable.Empty<Aggregate>());
                var projected = grouped.Select(selectExpr);

                // 5) SORT → alias/çıktı alanları ÜZERİNDE (projeksiyondan sonra!)
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

        // ---- yalnızca FILTER uygulayan yardımcı (non-generic Dynamic LINQ) ----
        private static IQueryable ApplyFilterOnlyNonGeneric(IQueryable source, Filter root)
        {
            var filters = IQueryableDynamicFilterExtensions.GetAllFilters(root);
            var values = filters.Select(f => f.Value).ToArray();
            var where = IQueryableDynamicFilterExtensions.Transform(root, filters);

            if (!string.IsNullOrWhiteSpace(where))
                source = source.Where(where, values);

            return source;
        }

        // ---------------- helpers ----------------

        private static string BuildGroupKey(IEnumerable<string>? groupBy)
        {
            if (groupBy is null || !groupBy.Any())
                return "new (1 as DummyKey)";

            // new (Customer.Name as Customer_Name, Code as Code)
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

            // Key alanları
            foreach (var g in groupBy ?? Enumerable.Empty<string>())
            {
                var alias = ToSafeAlias(g); // Customer.Name -> Customer_Name
                selects.Add($"Key.{alias} as {alias}");
            }

            // Aggregates
            foreach (var a in aggs)
            {
                var alias = ToSafeAlias(a.As);
                var expr = a.Type.ToLowerInvariant() switch
                {
                    "count" => "Count()",
                    "sum" => $"Sum({a.Field})",        // örn: OrderItems.Sum(Quantity)
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
            // new (Customer.Name as Customer_Name, CreatedDate as CreatedDate, TotalQty as TotalQty)
            var parts = select.Select(s =>
            {
                var alias = ToSafeAlias(s);
                return $"{s} as {alias}";
            });
            return $"new ({string.Join(", ", parts)})";
        }

        private static string BuildOrder(IEnumerable<Sort> sort)
        {
            // "Customer_Name asc, TotalQuantity desc"
            var items = sort.Select(s =>
            {
                var field = ToSafeAlias(s.Field); // alias veya path
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

                // Alias => fonksiyon map
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
                    // fonksiyon doğrudan yazıldıysa (örn: "Sum(OrderItems.Sum(Quantity))")
                    left = h.Field;
                }

                parts.Add($"{left} {op} @{vals.Count}");
                vals.Add(h.Value ?? "");
            }

            return new HavingExpr(string.Join(" and ", parts), vals.ToArray());
        }
    }
}
