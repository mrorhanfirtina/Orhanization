using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReceiptEntitySeed;

public class ReceiptTypeSeed : IEntityTypeConfiguration<ReceiptType>
{
    public void Configure(EntityTypeBuilder<ReceiptType> builder)
    {
        builder.HasData(
        new ReceiptType
        {
            Id = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            Code = "RT001",
            Description = "Standart Receipt",
            Format = "{0000000}",
            IsCodeGenerate = false,
            Counter = 1,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        }

        );
    }
}
