using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class DepositorCompanySeed : IEntityTypeConfiguration<DepositorCompany>
{
    public void Configure(EntityTypeBuilder<DepositorCompany> builder)
    {
        builder.HasData(
                new DepositorCompany
                {
                    Id = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Code = "SONY",
                    CreatedDate = DateTime.Now,
                    FaxNumber = "(0)711-5858-488",
                    PhoneNumber = "(0)711-5858-0",
                    TaxNumber = "8975897451",
                    AddressId = Guid.Parse("1224c606-3856-4a03-bb00-ed897ce47098"),
                    TaxOffice = "Tokyo TF",
                    Description = "Sony Corporation",
                    Name = "Sony Corporation"
                }
            );
    }
}
