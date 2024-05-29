using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class BuildingSeed : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.HasData(
                new Building
                {
                    Id = Guid.Parse("6b94bdfe-4158-4e98-816e-a3422816b2a3"),
                    Code = "MAINWH",
                    Country = "Turkey",
                    City = "Istanbul",
                    AddressText = "Orhanlı, 13. Yol, Deri Osb",
                    Province = "Tuzla",
                    CreatedDate = DateTime.Now,
                    Description = "Main Warehouse",
                    ZipCode = "34956",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    SiteId = Guid.Parse("f769e1ec-71cd-450b-80aa-1b863e518a26"),
                    Latitude = 40.878017m,
                    Longitude = 29.365147m
                },
                new Building
                {
                    Id = Guid.Parse("acc4558e-9492-4eec-9b31-9bdf31844740"),
                    Code = "SECONDWH",
                    Country = "Turkey",
                    City = "Istanbul",
                    AddressText = "Bolluca, Nene Hatun Cad./ova Sok. No:1",
                    Province = "Arnavutköy",
                    CreatedDate = DateTime.Now,
                    Description = "Second Warehouse",
                    ZipCode = "34287",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    SiteId = Guid.Parse("f769e1ec-71cd-450b-80aa-1b863e518a26"),
                    Latitude = 41.201105m,
                    Longitude = 28.766061m
                },
                new Building
                {
                    Id = Guid.Parse("2ce97c33-78f5-46a9-94b8-668c53fbe49e"),
                    Code = "THIRDWH",
                    Country = "Turkey",
                    City = "Istanbul",
                    AddressText = "Esentepe, Kartal Oto Sanayi Sitesi",
                    Province = "Kartal",
                    CreatedDate = DateTime.Now,
                    Description = "Third Warehouse",
                    ZipCode = "34870",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    SiteId = Guid.Parse("2cde8f81-f01b-4e40-ad08-62e105ab0712"),
                    Latitude = 40.908827m,
                    Longitude = 29.192633m
                },
                new Building
                {
                    Id = Guid.Parse("0d240376-68a1-4f9c-904b-7ae8a4ce5150"),
                    Code = "FOURTHWH",
                    Country = "Turkey",
                    City = "Kocaeli",
                    AddressText = "Deniz, Sanayi Cd. No:27",
                    Province = "Derince",
                    CreatedDate = DateTime.Now,
                    Description = "Fourth Warehouse",
                    ZipCode = "41900",
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    SiteId = Guid.Parse("47c488ad-1a7b-4d9d-97c1-838eb01e510e"),
                    Latitude = 40.757308m,
                    Longitude = 29.845680m
                }
            );
    }
}
