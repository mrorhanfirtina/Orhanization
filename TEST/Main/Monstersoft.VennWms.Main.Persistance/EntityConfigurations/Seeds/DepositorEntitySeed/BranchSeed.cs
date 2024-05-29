using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class BranchSeed : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.HasData(
            new Branch
            {
                Id = Guid.Parse("00b0bcb9-968c-419d-bbf4-e45711f3e3df"),
                Code = "651110",
                Name = "Russel LLC",
                DistributorId = Guid.Parse("f13c8ed2-d97e-4913-8981-fafb93e8b29d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("c2483137-9079-4301-9268-bfeac88cfe52"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("01531053-ff84-40ce-921f-106bedec148a"),
                Code = "871668",
                Name = "Kessler-Mertz",
                DistributorId = Guid.Parse("d84837b4-e806-4874-b901-284eaf2b2fd7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("a6cc3703-1dd5-4d82-95aa-8059ca166a88"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("0aa27b5c-35f6-4c28-abb9-b4779df28ac8"),
                Code = "519827",
                Name = "Herzog-Gibson",
                DistributorId = Guid.Parse("d41a5916-e0e2-4100-9256-2594c81b7d76"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("981cf038-2919-4993-81bc-fedaa9cb8384"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("1a806d0c-2a61-4222-8cf5-30a74386ced2"),
                Code = "811359",
                Name = "Durgan, Mraz and Nienow",
                DistributorId = Guid.Parse("d41a5916-e0e2-4100-9256-2594c81b7d76"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("82619502-d1cd-43bd-9502-eb69056ed157"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("1c715acb-9640-4667-84b9-ccfe4a9b44e1"),
                Code = "543115",
                Name = "Hand-Gutmann",
                DistributorId = Guid.Parse("57e192b8-0d75-4f73-a9fb-810c64e3832b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("2af3ecb9-279b-47e9-b1a7-e1e9a54dd412"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("1d1b20d0-77d5-40c3-8c90-7f3e63f0cb7b"),
                Code = "559220",
                Name = "Carroll-Gulgowski",
                DistributorId = Guid.Parse("d84837b4-e806-4874-b901-284eaf2b2fd7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("996828f8-ffda-4975-beae-0f4b620d7243"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("1f66ea15-38a6-4816-8b8d-3a8db7e0621d"),
                Code = "539563",
                Name = "Wuckert Inc",
                DistributorId = Guid.Parse("500c9695-f9b2-4711-a27e-845053946d33"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("b26b937b-837c-4bce-9cd3-ad3dab0ab11e"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("209b8ac8-2df3-4dce-be46-7f258bcb450d"),
                Code = "742866",
                Name = "Deckow-Kassulke",
                DistributorId = Guid.Parse("326bfee6-ed36-4e76-96d1-2d866871d32e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("057fecef-eaf9-4f73-b399-a5a09c45a197"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("231a56b8-aaa2-421e-99e4-811d5aeadd8e"),
                Code = "652296",
                Name = "Streich and Sons",
                DistributorId = Guid.Parse("d84b5f55-35b6-48dc-8075-e7727aca51c0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("6a8aa20a-cdf4-4f98-be07-7add14dcfdc6"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("2460e769-2a1c-4161-80e6-20e4dd087014"),
                Code = "473122",
                Name = "Morar and Sons",
                DistributorId = Guid.Parse("7c2c5ab7-cb4c-4895-a912-332caf8a89e3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("2e2e7392-632c-4985-9dfe-57550bba809a"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("2ef96a3c-3858-4f9d-983a-8820c0c0a11f"),
                Code = "837785",
                Name = "Bechtelar and Sons",
                DistributorId = Guid.Parse("34a51115-698d-46fd-8bb0-0c25c52947c2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("6d1093be-383e-401f-86b0-af3dfe867d76"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("3334ef9e-be80-46b6-9216-fadd7dc9b2ba"),
                Code = "508619",
                Name = "Kovacek, Rath and McClure",
                DistributorId = Guid.Parse("a6115a72-2ca7-4c46-a128-5da98960c735"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("0a719d43-6ede-474c-9427-67ac89363640"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("3d978523-a3f0-4215-bc57-22e6e287f033"),
                Code = "619329",
                Name = "Kozey Group",
                DistributorId = Guid.Parse("3b42941e-104c-42ae-8ee2-aa302fc635fe"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("75f80a41-8749-4703-ac19-dae165ed94d9"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("40d1cd44-2ce3-4607-b30f-69b858bde543"),
                Code = "463670",
                Name = "Howe-Wisoky",
                DistributorId = Guid.Parse("a6115a72-2ca7-4c46-a128-5da98960c735"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("c9b4747c-bdb6-49ba-b57a-61e4a2611b40"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("4bae3a64-fa23-4a5e-8806-65228b0a9d85"),
                Code = "573201",
                Name = "Prosacco LLC",
                DistributorId = Guid.Parse("500c9695-f9b2-4711-a27e-845053946d33"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("56659f7c-ad1f-4dc4-a97a-63ff7b8b09f1"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("5f79c129-b9a4-465e-9f79-0bdc2f7b4fd6"),
                Code = "604193",
                Name = "Kilback LLC",
                DistributorId = Guid.Parse("d84837b4-e806-4874-b901-284eaf2b2fd7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("d0ba6d2c-c317-42cd-ab9f-78273efe46f3"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("5fcbe1f5-b2ec-41c4-85dd-ed13d670c826"),
                Code = "658981",
                Name = "Runolfsdottir Inc",
                DistributorId = Guid.Parse("dffcb779-f3bc-4bd6-898b-9fb6151398c8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("bfa601ce-4e72-465f-aead-4dc3b4334c09"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("6bb6a35d-956d-47e1-ab1e-bee49ccc87f5"),
                Code = "545838",
                Name = "Schmeler, Boyer and Dickens",
                DistributorId = Guid.Parse("3b42941e-104c-42ae-8ee2-aa302fc635fe"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("ef807d91-2b60-40dc-a60a-6c5b1e78286c"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("6cd42fcb-b7c5-48e0-bb10-d0e585437e1d"),
                Code = "672920",
                Name = "Walker-Nikolaus",
                DistributorId = Guid.Parse("d84b5f55-35b6-48dc-8075-e7727aca51c0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("4bbb47b0-d2b7-4363-bae5-abd88b8262c5"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("74461c0c-9529-4e53-8b20-1b005b296bd5"),
                Code = "886025",
                Name = "Corwin, Mraz and Quigley",
                DistributorId = Guid.Parse("dffcb779-f3bc-4bd6-898b-9fb6151398c8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("466ffbbe-d5a7-43d5-9e8f-7d0b1fbd8045"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("83fda7fb-7fca-4806-8f8e-5c4cb9b86ec4"),
                Code = "767791",
                Name = "Walsh-White",
                DistributorId = Guid.Parse("d84837b4-e806-4874-b901-284eaf2b2fd7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("872d0c2b-64bd-4c98-b19d-05eb65ab95b1"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("84f3d42e-b791-4698-9535-ea704b0397b9"),
                Code = "521706",
                Name = "Bogan and Sons",
                DistributorId = Guid.Parse("f13c8ed2-d97e-4913-8981-fafb93e8b29d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("a677664d-848e-441d-b802-2f1b64164892"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("8bcdde34-2904-4a12-b7a8-1849e16b3bf6"),
                Code = "502720",
                Name = "Baumbach, Shields and Friesen",
                DistributorId = Guid.Parse("dffcb779-f3bc-4bd6-898b-9fb6151398c8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("a7a4992f-7fb3-4e3f-bdd8-b058393514cc"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("916e0b76-7c05-4777-972b-a30c836f1bef"),
                Code = "474535",
                Name = "Jacobs-Yundt",
                DistributorId = Guid.Parse("34a51115-698d-46fd-8bb0-0c25c52947c2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("1efbc072-d038-4a08-b9d4-ad03371c2eb2"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("930fb517-a2fe-4688-98b9-61efd48946ba"),
                Code = "805363",
                Name = "Nicolas, Hand and Bartoletti",
                DistributorId = Guid.Parse("326bfee6-ed36-4e76-96d1-2d866871d32e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("a8e883c4-563f-46b2-8e1e-884aaf9987e3"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("9517b317-b35c-4d72-a085-c789fb94d5c5"),
                Code = "472176",
                Name = "Hirthe-Donnelly",
                DistributorId = Guid.Parse("500c9695-f9b2-4711-a27e-845053946d33"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("5068c7a7-eb3d-4453-953b-46293a9a2232"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("996db5e1-f7e0-445f-a60f-bbf7fd13ff61"),
                Code = "708378",
                Name = "Dickens and Sons",
                DistributorId = Guid.Parse("3b42941e-104c-42ae-8ee2-aa302fc635fe"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("de0e49c0-477e-49fd-a8b9-8245d73d1a01"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("9e9ca8a4-2fa4-4a37-be69-d533c3eb4495"),
                Code = "504674",
                Name = "Feeney, Anderson and Hoppe",
                DistributorId = Guid.Parse("0d24736d-6e5d-46a2-8ebc-3c92b3ba71f9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("52699924-e389-4495-a509-56347e49561a"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("a268e274-9208-41be-9783-9201448ffc60"),
                Code = "751374",
                Name = "Lockman-Johnston",
                DistributorId = Guid.Parse("dffcb779-f3bc-4bd6-898b-9fb6151398c8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("01f6b460-e0f2-4415-81cd-d131c562bb96"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("adb61481-2612-4013-aea8-bb9aa025f2c3"),
                Code = "881646",
                Name = "Streich LLC",
                DistributorId = Guid.Parse("a6115a72-2ca7-4c46-a128-5da98960c735"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("a2bf3192-a73b-49f2-94e5-7633be31cb25"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("b7f807f1-9a36-49f4-8d2e-3e399e9c8f1b"),
                Code = "533854",
                Name = "Kovacek-Emard",
                DistributorId = Guid.Parse("34a51115-698d-46fd-8bb0-0c25c52947c2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("1dc76ef3-6be1-4759-b965-c1706927e19d"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("c012f5df-7ff7-4ac2-9f52-2cab0be5da8e"),
                Code = "621865",
                Name = "McClure-Lang",
                DistributorId = Guid.Parse("7c2c5ab7-cb4c-4895-a912-332caf8a89e3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("d9fb36bd-83c4-4edb-b47e-cb50740429d8"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("c2e8716a-f33c-4bb6-8e1c-44f93f1129aa"),
                Code = "495537",
                Name = "Goldner-Johnston",
                DistributorId = Guid.Parse("1f7cb3b7-5cef-4f45-ba6e-3e20f585f024"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("716931f1-2f4c-4a40-9323-8c94f74dca4f"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("c2fd0fea-2277-4cbf-aa3b-012ecc93e438"),
                Code = "557463",
                Name = "Lynch-Hermann",
                DistributorId = Guid.Parse("f13c8ed2-d97e-4913-8981-fafb93e8b29d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("ee4bb937-6e8c-4e7c-9784-e600ebff9f3b"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("c30fd7b5-a149-45ef-98b9-abdf4a85c8ed"),
                Code = "832771",
                Name = "Hermiston Inc",
                DistributorId = Guid.Parse("0d24736d-6e5d-46a2-8ebc-3c92b3ba71f9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("d3110ae5-500d-47db-afaf-d2e30cad13b5"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("cb225a5e-ac2d-47ea-97f8-eaee92562053"),
                Code = "479908",
                Name = "Smith, Dare and Gleason",
                DistributorId = Guid.Parse("d41a5916-e0e2-4100-9256-2594c81b7d76"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("15c657e5-8516-41e1-9aa3-60c949796e38"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("d11bf1ad-64a0-41a8-904f-4c7e76b8b924"),
                Code = "587209",
                Name = "Mitchell-Auer",
                DistributorId = Guid.Parse("57e192b8-0d75-4f73-a9fb-810c64e3832b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("0322111e-295b-4823-ab25-fcf940bcd06c"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("d3dd953e-0342-40d4-937b-df97722c9c6b"),
                Code = "854747",
                Name = "Klocko, O'Kon and Medhurst",
                DistributorId = Guid.Parse("34a51115-698d-46fd-8bb0-0c25c52947c2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("ef8c0bcd-6d38-4789-b519-172378dbfb88"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("ddb41ac3-35c0-43d7-8378-f98bfa62fefa"),
                Code = "572790",
                Name = "Little-Hills",
                DistributorId = Guid.Parse("7c2c5ab7-cb4c-4895-a912-332caf8a89e3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("8bb17f41-ecfd-4a71-9492-4aed0bcb9a34"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("dde07a91-228a-4a21-b91c-60ffb37b1e39"),
                Code = "835766",
                Name = "Kerluke LLC",
                DistributorId = Guid.Parse("f13c8ed2-d97e-4913-8981-fafb93e8b29d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("f5f75d64-367f-4072-9adf-7566310ffec3"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("e1adbbfd-d748-4cd3-b362-ef93f42c1d2f"),
                Code = "597345",
                Name = "Cormier Inc",
                DistributorId = Guid.Parse("c51690c7-e357-469d-be49-bb59a0a96612"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("6c3981aa-5409-467a-adba-fb1ae96e9721"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("e1e1368e-8427-437e-8c2f-79af501952de"),
                Code = "665023",
                Name = "Mills Inc",
                DistributorId = Guid.Parse("1f7cb3b7-5cef-4f45-ba6e-3e20f585f024"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("f5630a8b-bf84-416e-9eab-e1d86d8edb0d"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("e9a3e8dd-2cdc-4782-80d9-b001d2dde087"),
                Code = "801266",
                Name = "Wyman, Hoppe and Ryan",
                DistributorId = Guid.Parse("d84b5f55-35b6-48dc-8075-e7727aca51c0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("25e189ae-3906-4b91-8a9a-504508841b12"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("f01ae047-df7f-475c-aa67-1538581727ac"),
                Code = "764531",
                Name = "Runolfsdottir-Lehner",
                DistributorId = Guid.Parse("a6115a72-2ca7-4c46-a128-5da98960c735"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("5afebc81-436a-420c-9581-6f15384755b1"),
                CreatedDate = DateTime.Now,
            },

            new Branch
            {
                Id = Guid.Parse("fa4bd23d-c923-43f6-9c47-253b20c5bb0e"),
                Code = "861175",
                Name = "Purdy and Sons",
                DistributorId = Guid.Parse("c51690c7-e357-469d-be49-bb59a0a96612"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                AddressId = Guid.Parse("62f52efd-1eb2-4363-ab16-27862d772b16"),
                CreatedDate = DateTime.Now,
            }


            );
    }
}

