using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class StorageSystemSeed : IEntityTypeConfiguration<StorageSystem>
{
    public void Configure(EntityTypeBuilder<StorageSystem> builder)
    {
        builder.HasData(
            new StorageSystem
            {
                Id = Guid.Parse("08e7fbd9-bb1c-4a3f-8a9e-1e161fca9c8d"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "TRG",
                Description = "Target Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("3e63c2f7-f0be-4413-8024-0ee6a0fd2a44"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "PC",
                Description = "Picking Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("3f76b75f-c909-46aa-a713-55b82bb3906d"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "PICK",
                Description = "Picking Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("631c1980-10e8-487b-886b-93dff019e594"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "RM",
                Description = "Ramp Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("6ece26f8-f22e-4e76-9f0a-b5991a18b552"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "PCK",
                Description = "Picking Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("879378bd-1034-4c2e-b091-db40e826accf"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "TARG",
                Description = "Target Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("92d19a84-2664-414a-b054-f99baa277d33"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "STK",
                Description = "Stock Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("a1478658-87a3-4428-8857-c47711fd1475"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "TARG",
                Description = "Target Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("a4e3035f-ec86-439f-b1f0-191e42afe9c5"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "RAMP",
                Description = "Ramp Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("c24765cc-4a25-4f3a-a93f-369956c4ecc0"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "STC",
                Description = "Stock Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("c4a88404-9f26-4bea-808b-35999ccc8122"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "P",
                Description = "Picking Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("cc9555a6-9b60-43b5-9ca4-689bb3a13a37"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "RMP",
                Description = "Ramp Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("ce1b7212-ce95-4843-bc0d-66670914c75c"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "TR",
                Description = "Target Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("da300ea2-f6d8-4946-a452-9004156d536e"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "ST",
                Description = "Stock Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("dd652221-9b7c-4622-8cdd-af96ec1c7027"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "R",
                Description = "Ramp Area",
                CreatedDate = DateTime.Now
            },
            new StorageSystem
            {
                Id = Guid.Parse("e69ddbed-4b9b-4a48-a410-ab73cb0c9eef"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                Code = "STOCK",
                Description = "Stock Area",
                CreatedDate = DateTime.Now
            }


        );
    }
}
