using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class AddressSeed : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasData(

            new Address
            {
                Id = Guid.Parse("1224c606-3856-4a03-bb00-ed897ce47098"),
                City = "Istanbul",
                Country = "Turkey",
                CreatedDate = DateTime.Now,
                Province = "Kadikoy",
                Description = "Kadikoy Main",
                AddressText = "Istanbul",
                ZipCode = "34710"
            });
    }
}
