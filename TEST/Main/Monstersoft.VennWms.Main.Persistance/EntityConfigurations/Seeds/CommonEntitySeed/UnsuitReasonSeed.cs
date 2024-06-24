using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class UnsuitReasonSeed : IEntityTypeConfiguration<UnsuitReason>
{
    public void Configure(EntityTypeBuilder<UnsuitReason> builder)
    {
        builder.HasData(
            new UnsuitReason
            {
                Id = Guid.Parse("8c9768e3-725e-4809-b1ef-95cf10bdb120"),
                Code = "DAM",
                Description = "Damaged",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            },
            new UnsuitReason
            {
                Id = Guid.Parse("52226adf-40b5-41cc-9a34-50c8acc32731"),
                Code = "EXPIRED",
                Description = "Expired",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            },
            new UnsuitReason
            {
                Id = Guid.Parse("33e65c7d-74f3-432f-8832-a77c84320ed1"),
                Code = "MIS",
                Description = "Mislabelled",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            },
            new UnsuitReason
            {
                Id = Guid.Parse("b3190598-4a69-4f1a-b43c-8bfee50c71eb"),
                Code = "OOS",
                Description = "Out of Specification",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            },
            new UnsuitReason
            {
                Id = Guid.Parse("214d17f3-3030-4ad2-bba7-7fec3044cd49"),
                Code = "OTH",
                Description = "Other",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            }
            );
    }
}
