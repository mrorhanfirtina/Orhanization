using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class ContainerUnitSeed : IEntityTypeConfiguration<ContainerUnit>
{
    public void Configure(EntityTypeBuilder<ContainerUnit> builder)
    {
        builder.HasData(
                new ContainerUnit { Id = 1, Code = "PAL", FirstDigit = "P", Description = "Pallet", CountryCode = "40", ProducerCode = "1234567", Counter = "101", CreatedDate =DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
                new ContainerUnit { Id = 2, Code = "EUR", FirstDigit = "E", Description = "Euro Pallet", CountryCode = "40", ProducerCode = "1234567", Counter = "201", CreatedDate =DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
                new ContainerUnit { Id = 3, Code = "PCK", FirstDigit = "C", Description = "Packing Pallet", CountryCode = "40", ProducerCode = "1234567", Counter = "301", CreatedDate =DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
                new ContainerUnit { Id = 4, Code = "AMR", FirstDigit = "A", Description = "American Pallet", CountryCode = "40", ProducerCode = "1234567", Counter = "401", CreatedDate =DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") }
            );
    }
}
