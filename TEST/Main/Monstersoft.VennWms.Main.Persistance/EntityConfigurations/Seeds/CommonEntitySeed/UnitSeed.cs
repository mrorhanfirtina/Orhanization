using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class UnitSeed : IEntityTypeConfiguration<Unit>
{
    public void Configure(EntityTypeBuilder<Unit> builder)
    {
        builder.HasData(
            new Unit { Id = 1, Code = "mm", Description = "Millimeter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 2, Code = "cm", Description = "Centimeter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 3, Code = "dm", Description = "Decimeter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 4, Code = "m", Description = "Meter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 5, Code = "dam", Description = "Decameter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 6, Code = "hm", Description = "Hectometer", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 7, Code = "km", Description = "Kilometer", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 8, Code = "in", Description = "Inch", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 9, Code = "ft", Description = "Feet", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 10, Code = "yd", Description = "Yard", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 11, Code = "mi", Description = "Mile", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },

            new Unit { Id = 12, Code = "bbl", Description = "Barrel", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 13, Code = "cm3", Description = "Cubic centimeter(cc)", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 14, Code = "dm3", Description = "Cubic decimeter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 15, Code = "m3", Description = "Cubic meter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 16, Code = "dl", Description = "Deciliter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 17, Code = "gal", Description = "Gallon", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 18, Code = "L", Description = "Liter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 19, Code = "oz", Description = "Ounce", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },

            new Unit { Id = 20, Code = "g", Description = "Gram", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 21, Code = "kg", Description = "Kilogram", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 22, Code = "lb", Description = "Pound", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 23, Code = "q", Description = "Quintal", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 24, Code = "t", Description = "Ton(Metric)", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 25, Code = "tn", Description = "Tonne", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },

            new Unit { Id = 26, Code = "Acre", Description = "Acre", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 27, Code = "a", Description = "Are", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 28, Code = "ha", Description = "Hectare", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 29, Code = "dam2", Description = "Square decameter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 30, Code = "km2", Description = "Square kilometer", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 31, Code = "m2", Description = "Square meter", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 32, Code = "sq yd", Description = "Square yard", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },

            new Unit { Id = 33, Code = "EA", Description = "Piece", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 34, Code = "BOX", Description = "Box", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 35, Code = "KOL", Description = "Carton", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 36, Code = "PALLET", Description = "Pallet", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") },
            new Unit { Id = 37, Code = "CONTAINER", Description = "Container", CreatedDate = DateTime.Now, DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7") }
            );
    }
}
