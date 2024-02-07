using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class ContainerUnitSeed : IEntityTypeConfiguration<ContainerUnit>
{
    public void Configure(EntityTypeBuilder<ContainerUnit> builder)
    {
        builder.HasData(
                new ContainerUnit { Id = 1, Code = "PAL", FirstDigit = "P", Description = "Pallet", CountryCode = "40", ProducerCode = "1234567", Counter = "101", CreatedDate =DateTime.Now, DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa") },
                new ContainerUnit { Id = 2, Code = "EUR", FirstDigit = "E", Description = "Euro Pallet", CountryCode = "40", ProducerCode = "1234567", Counter = "201", CreatedDate =DateTime.Now, DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa") },
                new ContainerUnit { Id = 3, Code = "PCK", FirstDigit = "C", Description = "Packing Pallet", CountryCode = "40", ProducerCode = "1234567", Counter = "301", CreatedDate =DateTime.Now, DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa") },
                new ContainerUnit { Id = 4, Code = "AMR", FirstDigit = "A", Description = "American Pallet", CountryCode = "40", ProducerCode = "1234567", Counter = "401", CreatedDate =DateTime.Now, DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa") }
            );
    }
}
