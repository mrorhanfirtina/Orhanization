using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class DistributorSeed : IEntityTypeConfiguration<Distributor>
{
    public void Configure(EntityTypeBuilder<Distributor> builder)
    {
        builder.HasData(
            new Distributor
            {
                Id = Guid.Parse("0d24736d-6e5d-46a2-8ebc-3c92b3ba71f9"),
                Code = "53808",
                Name = "Crona-Davis",
                CompanyId = Guid.Parse("024f9d3f-90c4-43fe-b5f4-1a418a0f1067"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("a1e2998c-9c91-4002-a58c-18fe7f585aa8"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("1f7cb3b7-5cef-4f45-ba6e-3e20f585f024"),
                Code = "60929",
                Name = "Smith-Gibson",
                CompanyId = Guid.Parse("3de5fc99-7bfa-4f96-b49c-93e94f53cc0b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("0a5711ef-36b6-4fab-bb16-9eddb85740fb"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("326bfee6-ed36-4e76-96d1-2d866871d32e"),
                Code = "86775",
                Name = "Hickle-Monahan",
                CompanyId = Guid.Parse("3de5fc99-7bfa-4f96-b49c-93e94f53cc0b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("decd1596-bcba-478a-b8f3-0ba1243d0ced"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("34a51115-698d-46fd-8bb0-0c25c52947c2"),
                Code = "60497",
                Name = "Adams, Braun and Bechtelar",
                CompanyId = Guid.Parse("b990cf60-ea2f-4951-a523-b28f18cc0a1a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("ff90032b-647e-466c-b143-b6c0eee9652b"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("3b42941e-104c-42ae-8ee2-aa302fc635fe"),
                Code = "80350",
                Name = "Jacobi-Davis",
                CompanyId = Guid.Parse("1558c239-22e9-431a-bce6-3d8f2d076151"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("50d5b675-9b6a-481e-be9e-a2ef64d79125"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("500c9695-f9b2-4711-a27e-845053946d33"),
                Code = "55972",
                Name = "Renner-Rippin",
                CompanyId = Guid.Parse("03c2eac3-0b4a-4e61-9095-a7a64f0bf5d2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("7d896232-affb-406c-b2ed-c60a97685675"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("57e192b8-0d75-4f73-a9fb-810c64e3832b"),
                Code = "46787",
                Name = "Wuckert and Sons",
                CompanyId = Guid.Parse("0f968ae8-6dd0-47a1-8235-a13210c20cb7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("97c33e9c-1454-4996-94bc-e9147529a202"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("7c2c5ab7-cb4c-4895-a912-332caf8a89e3"),
                Code = "53869",
                Name = "Hauck-Feest",
                CompanyId = Guid.Parse("a6bf5d8a-bf77-490b-b797-83400ed5bec3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("96a9a8a2-1d5f-455f-b22d-50d382f82b52"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("a6115a72-2ca7-4c46-a128-5da98960c735"),
                Code = "86553",
                Name = "Hauck Inc",
                CompanyId = Guid.Parse("fddc81ff-866b-408c-86c3-bb43b18c556b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("dcfe2448-1d99-45c3-841a-cb8090df25dd"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("c51690c7-e357-469d-be49-bb59a0a96612"),
                Code = "60400",
                Name = "Kreiger LLC",
                CompanyId = Guid.Parse("5b1baf2b-f44d-4c93-b9da-578605f19a26"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("43e6aa4d-1152-4737-803d-af8c5887c43b"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("d41a5916-e0e2-4100-9256-2594c81b7d76"),
                Code = "82243",
                Name = "Friesen, Koepp and Mann",
                CompanyId = Guid.Parse("45ccd43b-b187-4e25-aa5f-dc723b429a3f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("8de661d7-c8a1-47a7-bdbd-f48e87824735"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("d84837b4-e806-4874-b901-284eaf2b2fd7"),
                Code = "80291",
                Name = "Brown-Reinger",
                CompanyId = Guid.Parse("dbfa5faa-fdc6-4aae-80d2-0a218a13f64f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("d6396c04-3f35-401c-b39d-e071ef59da2a"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("d84b5f55-35b6-48dc-8075-e7727aca51c0"),
                Code = "88122",
                Name = "Batz, Hackett and Lindgren",
                CompanyId = Guid.Parse("f00689d9-ad10-49e4-8746-5f31b38a7c89"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("2d4a8ebf-1d35-461c-ac03-04049f49be62"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("dffcb779-f3bc-4bd6-898b-9fb6151398c8"),
                Code = "82798",
                Name = "Muller-Predovic",
                CompanyId = Guid.Parse("19144cba-6104-4217-b260-233e3e294988"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("d1e044ed-59f1-4ea4-bdd3-ca8e7daada23"),
                CreatedDate = DateTime.Now,
            },

            new Distributor
            {
                Id = Guid.Parse("f13c8ed2-d97e-4913-8981-fafb93e8b29d"),
                Code = "55824",
                Name = "Maggio LLC",
                CompanyId = Guid.Parse("c3ea73fe-ffa4-4f12-9586-7f2cfc58dc30"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("a2ca3e6a-57a7-4555-805d-339807edff7f"),
                CreatedDate = DateTime.Now,
            }



            );
    }
}
