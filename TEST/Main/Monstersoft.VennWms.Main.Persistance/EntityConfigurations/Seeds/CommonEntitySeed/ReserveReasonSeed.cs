using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class ReserveReasonSeed : IEntityTypeConfiguration<ReserveReason>
{
    public void Configure(EntityTypeBuilder<ReserveReason> builder)
    {
        builder.HasData(
            new ReserveReason
            {
                Id = Guid.Parse("7b59ccb4-d18e-4aec-a6a7-09e62cb904aa"),
                Code = "DAM",
                Description = "Damaged",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            },
            new ReserveReason
            {
                Id = Guid.Parse("3b79fdd3-f33a-4df3-a968-bbcfc70907c8"),
                Code = "EXPIRED",
                Description = "Expired",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            },
            new ReserveReason
            {
                Id = Guid.Parse("009832e6-ed40-46c6-8488-33d7cad03582"),
                Code = "MIS",
                Description = "Mislabelled",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            },
            new ReserveReason
            {
                Id = Guid.Parse("9f424001-332e-4f24-949c-537948d2d426"),
                Code = "OOS",
                Description = "Out of Specification",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            },
            new ReserveReason
            {
                Id = Guid.Parse("79a54cab-ded3-4dcd-85f8-79866d31f375"),
                Code = "OTH",
                Description = "Other",
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                IsBlocked = true
            }
            );
    }
}
