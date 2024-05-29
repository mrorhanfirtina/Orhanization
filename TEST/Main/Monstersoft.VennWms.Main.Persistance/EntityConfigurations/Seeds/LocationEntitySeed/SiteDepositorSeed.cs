using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

internal class SiteDepositorSeed : IEntityTypeConfiguration<SiteDepositor>
{
    public void Configure(EntityTypeBuilder<SiteDepositor> builder)
    {
        builder.HasData(
            new SiteDepositor
            {
                Id = Guid.Parse("44a3e954-bf44-4232-9747-bcaa290c37b5"),
                SiteId = Guid.Parse("f769e1ec-71cd-450b-80aa-1b863e518a26"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new SiteDepositor
            {
                Id = Guid.Parse("a476a785-cbe8-4bf3-b2f0-3d16aa950b6c"),
                SiteId = Guid.Parse("f769e1ec-71cd-450b-80aa-1b863e518a26"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new SiteDepositor
            {
                Id = Guid.Parse("440e26cc-9d61-4636-b0da-8f92ab4f97ad"),
                SiteId = Guid.Parse("2cde8f81-f01b-4e40-ad08-62e105ab0712"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new SiteDepositor
            {
                Id = Guid.Parse("a9225237-adc4-4a79-aa6f-081f33e51344"),
                SiteId = Guid.Parse("47c488ad-1a7b-4d9d-97c1-838eb01e510e"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            }
            );
    }
}
