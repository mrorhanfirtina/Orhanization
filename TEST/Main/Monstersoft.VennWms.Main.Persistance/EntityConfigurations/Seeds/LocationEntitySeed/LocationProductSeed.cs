using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationProductSeed : IEntityTypeConfiguration<LocationProduct>
{
    public void Configure(EntityTypeBuilder<LocationProduct> builder)
    {
        builder.HasData(
            new LocationProduct
            {
                Id = Guid.Parse("9b9a99c5-007b-4a66-bcb2-5e605a7a598a"),
                LocationId = Guid.Parse("D603B2F4-70DC-4C9F-944F-79CA587E1E38"),
                ProductId = Guid.Parse("71DE705A-489C-480A-9A03-8E112B787307"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationProduct
            {
                Id = Guid.Parse("20769d34-d996-4670-b9c7-1e27149dc8a5"),
                LocationId = Guid.Parse("DA36052E-DA7E-4581-8EE7-B9358F11A0B2"),
                ProductId = Guid.Parse("02369CE6-745F-471D-9862-976C6344927B"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationProduct
            {
                Id = Guid.Parse("bb5b1a3f-2d4d-462c-8f54-428495ae4599"),
                LocationId = Guid.Parse("E034AC20-2865-4466-9022-ACA88E52D372"),
                ProductId = Guid.Parse("84974822-B09E-4AE5-A793-AE8D52091647"),
                IsForbid = false,
                CreatedDate = DateTime.Now,
            },
            new LocationProduct
            {
                Id = Guid.Parse("f916ef91-25e4-4e21-9796-18ced5c9bd9a"),
                LocationId = Guid.Parse("F1C732A2-2F5E-412F-A04B-96825E0E3015"),
                ProductId = Guid.Parse("D11CD853-1D91-46AE-95B4-B6F9F183E5CB"),
                IsForbid = true,
                CreatedDate = DateTime.Now,
            }

        );
    }
}
