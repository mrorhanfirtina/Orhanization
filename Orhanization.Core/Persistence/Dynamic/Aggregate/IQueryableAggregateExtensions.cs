using System.Linq.Dynamic.Core;

namespace Orhanization.Core.Persistence.Dynamic.Aggregate
{
    public static class IQueryableAggregateExtensions
    {
        private const int MAX_LIMIT = 500;

        public static IQueryable ToDynamicAggregate(this IQueryable source, AggregateQuery aq)
        {
            // 1) SADECE FİLTRE (erken sort YOK)
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

                // 5) SORT (alias/çıktı alanları ÜZERİNDE)
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
                var alias = ToSafeAlias(g);
                selects.Add($"Key.{alias} as {alias}");
            }

            // Aggregates (tek bir ortak üretici ile)
            foreach (var a in aggs)
            {
                var expr = BuildAggregateExpression(a);
                var alias = ToSafeAlias(a.As);
                selects.Add($"{expr} as {alias}");
            }

            return $"new ({string.Join(", ", selects)})";
        }

        private static string BuildFlatProjection(IEnumerable<string> select)
        {
            var parts = select.Select(s =>
            {
                var alias = ToSafeAlias(s);
                return $"{s} as {alias}";
            });
            return $"new ({string.Join(", ", parts)})";
        }

        private static string BuildOrder(IEnumerable<Sort> sort)
        {
            var items = sort.Select(s =>
            {
                var field = ToSafeAlias(s.Field);
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

                // Alias ile eşleşiyorsa SELECT'te üretilen aynı aggregate ifadesini kullan
                string left;
                var alias = aggs.FirstOrDefault(a => a.As.Equals(h.Field, StringComparison.OrdinalIgnoreCase));
                if (alias is not null)
                {
                    left = BuildAggregateExpression(alias);
                }
                else
                {
                    // doğrudan fonksiyon yazıldıysa (örn. "SelectMany(ReceiptItems).Count()")
                    left = h.Field;
                }

                parts.Add($"{left} {op} @{vals.Count}");
                vals.Add(h.Value ?? "");
            }

            return new HavingExpr(string.Join(" and ", parts), vals.ToArray());
        }

        // ------------------- AGG builder -------------------

        private static string BuildAggregateExpression(Aggregate a)
        {
            var type = (a.Type ?? "").Trim().ToLowerInvariant();
            var raw = NormalizeField(a.Field);

            return type switch
            {
                "count" => BuildCountExpr(raw),
                "sum" => BuildNumericExpr("Sum", raw),
                "avg" or "average" => BuildNumericExpr("Average", raw),
                "min" => BuildNumericExpr("Min", raw),
                "max" => BuildNumericExpr("Max", raw),
                _ => throw new ArgumentException($"Unsupported aggregate: {a.Type}")
            };
        }

        private static string BuildCountExpr(string field)
        {
            // count() — grup satırı sayısı
            if (string.IsNullOrWhiteSpace(field))
                return "Count()";

            // "ReceiptItems.Select(1)" gibi → SelectMany(ReceiptItems).Count()
            if (LooksLikeSelectChain(field))
                return $"{FixSelectChain(field)}.Count()";

            // "SelectMany(ReceiptItems)" zaten verilmişse
            if (LooksLikeSelectManyChain(field))
                return $"{field}.Count()";

            // "ReceiptItems" gibi yalın koleksiyon adı → SelectMany(ReceiptItems).Count()
            if (IsBareIdentifier(field))
                return $"SelectMany({field}).Count()";

            // Başka bir şey yazıldıysa aynen Count üstüne çevir (güvenli varsayılan)
            return $"{field}.Count()";
        }

        private static string BuildNumericExpr(string fn, string field)
        {
            if (string.IsNullOrWhiteSpace(field))
                throw new ArgumentException($"'{fn}' aggregate requires a field.");

            // "ReceiptItems.Select(Value)" → SelectMany(ReceiptItems).Select(Value).Fn()
            if (LooksLikeSelectChain(field))
                return $"{FixSelectChain(field)}.{fn}()";

            // "SelectMany(ReceiptItems).Select(Value)" → ... .Fn()
            if (LooksLikeSelectManyChain(field))
                return $"{field}.{fn}()";

            // "ReceiptItems.ExpectedQuantity" → SelectMany(ReceiptItems).Select(ExpectedQuantity).Fn()
            if (LooksLikeSimpleDotPath(field))
            {
                var (head, tail) = SplitFirst(field);
                return $"SelectMany({head}).Select({tail}).{fn}()";
            }

            // "OrderItems.Sum(Quantity)" gibi içte zaten aggregate varsa
            if (ContainsAny(field, "Sum(", "Average(", "Min(", "Max(", "Count("))
                return $"{fn}({field})"; // üst seviye grup toplamı

            // Aksi halde element scalar alanı → Fn(Field)
            return $"{fn}({field})";
        }

        // ------------------- küçük yardımcılar -------------------

        private static string NormalizeField(string? raw)
            => string.IsNullOrWhiteSpace(raw) ? "" : raw.Replace("[]", "").Trim();

        private static bool LooksLikeSelectChain(string s)
            => s.Contains(".Select(", StringComparison.Ordinal);

        private static bool LooksLikeSelectManyChain(string s)
            => s.StartsWith("SelectMany(", StringComparison.Ordinal) || s.Contains(".SelectMany(", StringComparison.Ordinal);

        private static bool LooksLikeSimpleDotPath(string s)
            => s.Contains(".") && !s.Contains("(", StringComparison.Ordinal);

        private static bool IsBareIdentifier(string s)
            => !s.Contains(".") && !s.Contains("(", StringComparison.Ordinal) && !string.IsNullOrWhiteSpace(s);

        private static (string head, string tail) SplitFirst(string path)
        {
            var idx = path.IndexOf('.');
            if (idx < 0) return (path, "");
            var head = path.Substring(0, idx);
            var tail = path[(idx + 1)..];
            return (head, tail);
        }

        private static bool ContainsAny(string s, params string[] needles)
            => needles.Any(n => s.Contains(n, StringComparison.Ordinal));

        /// <summary>
        /// "ReceiptItems.Select(Value)" → "SelectMany(ReceiptItems).Select(Value)"
        /// Diğer durumlarda olduğu gibi bırakır.
        /// </summary>
        private static string FixSelectChain(string s)
        {
            // Başta SelectMany/Select varsa aynen bırak
            if (s.StartsWith("SelectMany(", StringComparison.Ordinal) || s.StartsWith("Select(", StringComparison.Ordinal))
                return s;

            // "X.Select(" kalıbı → "SelectMany(X).Select("
            var dot = s.IndexOf(".Select(", StringComparison.Ordinal);
            if (dot > 0)
            {
                var head = s.Substring(0, dot);       // X
                var tail = s.Substring(dot + 1);      // Select(...)

                head = head.Replace("[]", "");
                return $"SelectMany({head}).{tail}";
            }

            return s;
        }
    }
}
