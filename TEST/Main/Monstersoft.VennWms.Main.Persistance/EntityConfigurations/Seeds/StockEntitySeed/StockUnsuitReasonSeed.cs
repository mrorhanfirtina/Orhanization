using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.StockEntitySeed;

public class StockUnsuitReasonSeed : IEntityTypeConfiguration<StockUnsuitReason>
{
    public void Configure(EntityTypeBuilder<StockUnsuitReason> builder)
    {
        builder.HasData(
        new StockUnsuitReason
        {
            Id = Guid.Parse("2533d9c2-0fc4-4725-8ea5-5f137ca8c01d"),
            StockId = Guid.Parse("E261F800-03DB-4734-89FD-C49B40335EF4"),
            UnsuitReasonId = Guid.Parse("8C9768E3-725E-4809-B1EF-95CF10BDB120"),
            CreatedDate = DateTime.Now,
        }

        );
    }
}
