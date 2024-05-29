using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationDepositorSeed : IEntityTypeConfiguration<LocationDepositor>
{
    public void Configure(EntityTypeBuilder<LocationDepositor> builder)
    {
        builder.HasData(
            new LocationDepositor
            {
                Id = Guid.Parse("00406025-79c5-44d0-9a8d-4ce2722a64ba"),
                LocationId = Guid.Parse("78D05AC9-89F5-4A31-896D-D1ACF1E92850"),
                DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationDepositor
            {
                Id = Guid.Parse("0044b3a3-5da1-4ebf-bea2-1c546b3ac30d"),
                LocationId = Guid.Parse("35430B56-66B0-427D-9387-6AB9CB65E0E7"),
                DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationDepositor
            {
                Id = Guid.Parse("005d790a-a089-44ad-bb5f-fab42669123a"),
                LocationId = Guid.Parse("8E24BD56-B514-455F-875A-9C08B5FB9420"),
                DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationDepositor
            {
                Id = Guid.Parse("006077a4-97da-4967-b722-9d426d62e64d"),
                LocationId = Guid.Parse("5B7664D8-0B62-490D-A666-CB373490B7DA"),
                DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationDepositor
            {
                Id = Guid.Parse("007a075b-1221-4733-91dc-ef8e38575de5"),
                LocationId = Guid.Parse("8BCE4C38-B993-4064-8B8C-B925F6F3BFAC"),
                DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationDepositor
            {
                Id = Guid.Parse("008ac8a2-8bd8-4653-9dba-0a8771d900c5"),
                LocationId = Guid.Parse("284099B3-1EB8-4BCD-B74D-90EE1CD5F74C"),
                DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationDepositor
            {
                Id = Guid.Parse("009ae4e4-536c-4278-b93c-137b728edacf"),
                LocationId = Guid.Parse("2249D9FE-746F-4BE1-8114-5D6C5BBF16B9"),
                DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationDepositor
            {
                Id = Guid.Parse("009ffd09-2aba-40e1-96f4-5a898b13c847"),
                LocationId = Guid.Parse("CF00F37D-8D90-479D-BD3A-A147479609C4"),
                DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationDepositor
            {
                Id = Guid.Parse("00c4424b-47e8-40e6-bb6f-c8e37383635d"),
                LocationId = Guid.Parse("647EC1B3-3037-42FF-B7C0-0E4210970578"),
                DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            }
        );
    }
}
