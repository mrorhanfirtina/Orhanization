using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class DepositorCompanySeed : IEntityTypeConfiguration<DepositorCompany>
{
    public void Configure(EntityTypeBuilder<DepositorCompany> builder)
    {
        builder.HasData(
                new DepositorCompany
                {
                    Id = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Code = "MAIN",
                    CreatedDate = DateTime.Now,
                    FaxNumber = "123456789101",
                    PhoneNumber = "905432044767",
                    TaxNumber = "123456789",
                    TaxOffice = "Istanbul Anadolu Kurumlar VD",
                    Description = "Main Company",
                    Name = "Main Company LTD."
                }
            );
    }
}
