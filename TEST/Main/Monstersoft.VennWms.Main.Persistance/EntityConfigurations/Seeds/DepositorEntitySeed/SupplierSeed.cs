using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class SupplierSeed : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.HasData(
            new Supplier
            {
                Id = Guid.Parse("12f10a2f-bd9e-4822-8989-6c96c9d30bb4"),
                Code = "20414",
                Name = "Pixonyx",
                CompanyId = Guid.Parse("4484da07-52db-4fb3-b453-b312d4a9c56d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("c5119dae-6a3b-402e-9e88-79551cf86b80"),
                CreatedDate = DateTime.Now
            },

            new Supplier
            {
                Id = Guid.Parse("1c37bf6b-f339-46f1-90dd-90ebb9dd4ede"),
                Code = "33648",
                Name = "Babblestorm",
                CompanyId = Guid.Parse("608abfba-ab92-4fb5-a2cc-31e3603b8094"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("21b1bd76-a1f9-4094-a734-d016f23500bb"),
                CreatedDate = DateTime.Now
            },

            new Supplier
            {
                Id = Guid.Parse("52196cdb-6b73-46fa-b5b6-0cefbd92d9f1"),
                Code = "32025",
                Name = "Dabjam",
                CompanyId = Guid.Parse("e67e09ee-355f-457b-aa2e-e35165b45355"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("d6e6cd52-cdcf-49f5-9ee7-ef374facaff2"),
                CreatedDate = DateTime.Now
            },

            new Supplier
            {
                Id = Guid.Parse("99eb6d09-f61f-4f6d-9335-6f569df2241f"),
                Code = "34068",
                Name = "Divanoodle",
                CompanyId = Guid.Parse("fb76815d-8288-4919-9cde-04f4701ab99e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("13a8cffa-ff13-4ab0-9ee4-40e834a221cf"),
                CreatedDate = DateTime.Now
            },

            new Supplier
            {
                Id = Guid.Parse("a0ef044f-d6a2-4d28-94a6-def250511182"),
                Code = "34265",
                Name = "Minyx",
                CompanyId = Guid.Parse("fd477cbb-dbef-400d-8193-26bcf35a3403"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("54d3dbf2-2d6a-4222-9c29-81f17ca6d8c5"),
                CreatedDate = DateTime.Now
            },

            new Supplier
            {
                Id = Guid.Parse("c447aec7-67d4-4dcb-9194-431d4cfec230"),
                Code = "31564",
                Name = "Oba",
                CompanyId = Guid.Parse("fba018ff-62de-4a0e-ab1a-bdcff8982b30"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("ecf88e85-43af-4536-b3d2-a5a865dec1df"),
                CreatedDate = DateTime.Now
            },

            new Supplier
            {
                Id = Guid.Parse("d09a7aee-fd18-4ed7-8c26-63387fec682c"),
                Code = "27724",
                Name = "Tambee",
                CompanyId = Guid.Parse("26be9beb-f4dc-47bd-b682-6c9b216446a8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("e409cda7-a8a6-4019-8fda-9af53839715f"),
                CreatedDate = DateTime.Now
            },

            new Supplier
            {
                Id = Guid.Parse("d4d7c251-a970-4b57-b659-c3b2b75e6794"),
                Code = "29124",
                Name = "Chatterbridge",
                CompanyId = Guid.Parse("85f54b14-e554-40de-bee8-5363fe291085"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("fac641c9-7635-41e2-b884-483f161bf440"),
                CreatedDate = DateTime.Now
            },

            new Supplier
            {
                Id = Guid.Parse("e0491418-188a-498a-a84a-b03b7d76a611"),
                Code = "28250",
                Name = "Jaxworks",
                CompanyId = Guid.Parse("20622618-5b1e-4cf3-a976-ec0ef7ede585"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("be1a65c2-717c-4b63-a65c-6c89c5eed280"),
                CreatedDate = DateTime.Now
            },

            new Supplier
            {
                Id = Guid.Parse("f4259a2c-f416-40f7-96af-b03c41671ffa"),
                Code = "21044",
                Name = "Yodel",
                CompanyId = Guid.Parse("9851bd4a-8bef-44ab-a209-73650f97d9fa"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("59e90322-5bcb-40bb-ac45-2e61c72fd703"),
                CreatedDate = DateTime.Now
            }
            );
    }
}
