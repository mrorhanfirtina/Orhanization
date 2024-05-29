using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class DepositorFeatureSeed : IEntityTypeConfiguration<DepositorFeature>
{
    public void Configure(EntityTypeBuilder<DepositorFeature> builder)
    {
        builder.HasData(
            new DepositorFeature
            {
                Id = Guid.Parse("2c3f6012-1d25-4818-b450-a90460e8d0e4"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                GenerateSsccLed = true,
                OrderModifyLed = false,
                ForbidNewReceiptLineLed = false,
                AllowDuplicateBarcodeLed = false,
                ForceTaskStockLed = false,
                ForbidTransferReservedLed = false,
                ChangeStockWithTaskLed = false,
                ManualReceiptCompletionLed = false,
                ManualReturnCompletionLed = false,
                CreatedDate = DateTime.Now,
            },
            new DepositorFeature
            {
                Id = Guid.Parse("f7f6e037-e932-4041-a883-eb0e76d5aebf"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                GenerateSsccLed = true,
                OrderModifyLed = true,
                ForbidNewReceiptLineLed = false,
                AllowDuplicateBarcodeLed = false,
                ForceTaskStockLed = false,
                ForbidTransferReservedLed = false,
                ChangeStockWithTaskLed = false,
                ManualReceiptCompletionLed = false,
                ManualReturnCompletionLed = false,
                CreatedDate = DateTime.Now,
            });
    }
}
