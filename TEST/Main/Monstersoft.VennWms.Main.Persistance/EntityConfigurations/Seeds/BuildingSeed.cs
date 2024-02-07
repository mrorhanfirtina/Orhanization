using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class BuildingSeed : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.HasData(
                new Building
                {
                    Id = Guid.Parse("6b94bdfe-4158-4e98-816e-a3422816b2a3"),
                    Code = "MAIN",
                    Country = "Turkey",
                    City = "Istanbul",
                    Address = "Deri Org. San. Bolgesi No:26",
                    Province = "Tuzla",
                    CreatedDate = DateTime.Now,
                    Description = "Main Factory",
                    ZipCode = "34953"
                }
            );
    }
}
