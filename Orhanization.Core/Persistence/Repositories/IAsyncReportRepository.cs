using Orhanization.Core.Persistence.Dynamic.Aggregate;

namespace Orhanization.Core.Persistence.Repositories
{
    public interface IAsyncReportRepository
    {
        Task<List<object>> GetAggregateAsync(
            Type entityType,
            AggregateQuery aq,
            IEnumerable<string>? includePaths = null,
            bool withDeleted = false,
            bool enableTracking = true,
            bool autoInclude = false,
            CancellationToken cancellationToken = default);

        Task<List<object>> GetAggregateAsync(
            string dbSetName,
            AggregateQuery aq,
            IEnumerable<string>? includePaths = null,
            bool withDeleted = false,
            bool enableTracking = true,
            bool autoInclude = false,
            CancellationToken cancellationToken = default);
    }
}
