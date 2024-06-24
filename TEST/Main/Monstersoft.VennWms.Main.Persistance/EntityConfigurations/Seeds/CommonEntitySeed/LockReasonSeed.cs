using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class LockReasonSeed : IEntityTypeConfiguration<LockReason>
{
    public void Configure(EntityTypeBuilder<LockReason> builder)
    {
        builder.HasData(
                new LockReason
                {
                    Id = 1,
                    Code = "COUNT",
                    Description = "Counting",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },
                new LockReason
                {
                    Id = 2,
                    Code = "CR",
                    Description = "Customer Request",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },
                new LockReason
                {
                    Id = 3,
                    Code = "QCH",
                    Description = "Quality Control Hold",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },
                new LockReason
                {
                    Id = 4,
                    Code = "Quarantine",
                    Description = "Quarantine",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },
                new LockReason
                {
                    Id = 5,
                    Code = "SA",
                    Description = "Space Allocation",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                },
                new LockReason
                {
                    Id = 6,
                    Code = "LCO",
                    Description = "Legal or Contractual Obligations",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    CreatedDate = DateTime.Now,
                }
            );
    }
}

