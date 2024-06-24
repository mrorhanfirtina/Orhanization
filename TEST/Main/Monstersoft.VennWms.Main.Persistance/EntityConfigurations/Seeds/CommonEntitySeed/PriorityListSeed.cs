using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class PriorityListSeed : IEntityTypeConfiguration<PriorityList>
{
    public void Configure(EntityTypeBuilder<PriorityList> builder)
    {
        builder.HasData(
            new PriorityList
            {
                Id = 1,
                Code = "Emergency",
                Description = "Emergency Shipments",
                Priority = 1,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new PriorityList
            {
                Id = 2,
                Code = "High-Value",
                Description = "High-Value Shipments",
                Priority = 2,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new PriorityList
            {
                Id = 3,
                Code = "COUDR",
                Description = "Customer Orders with Urgent Delivery Requests",
                Priority = 3,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new PriorityList
            {
                Id = 4,
                Code = "Backlogged",
                Description = "Backlogged Shipments",
                Priority = 4,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new PriorityList
            {
                Id = 5,
                Code = "Regular",
                Description = "Regular Shipments",
                Priority = 5,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new PriorityList
            {
                Id = 6,
                Code = "Pending",
                Description = "Pending Shipments",
                Priority = 6,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            }
        );
    }
}
