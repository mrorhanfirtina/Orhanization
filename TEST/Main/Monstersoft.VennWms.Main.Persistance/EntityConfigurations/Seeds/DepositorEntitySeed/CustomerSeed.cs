using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class CustomerSeed : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasData(
            new Customer
            {
                Id = Guid.Parse("059af8fc-a739-4de9-a375-b4ab609baa03"),
                Code = "6753",
                Name = "Pineleng Voonix",
                AddressId = Guid.Parse("1be04f68-5773-460d-8b2f-b1472b27b57b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("34ed5a6a-16b2-4124-a60e-391394cfe2cf")
            },

            new Customer
            {
                Id = Guid.Parse("07798ff4-c448-4701-8375-8aeff6b0e06c"),
                Code = "6307",
                Name = "Liulin Gigaclub",
                AddressId = Guid.Parse("3a493cbb-75da-4826-bff0-42b9ab1becc6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("10a3d9ec-6411-48c4-ae15-62776c9ee8f2"),
                Code = "5031",
                Name = "Kuantan Yakitri",
                AddressId = Guid.Parse("51713fc8-1dd1-44bc-972b-efad9127b800"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("13cf070d-5ff6-4745-9ef7-575af5f35b2b"),
                Code = "5863",
                Name = "Naḩḩālīn Browsebug",
                AddressId = Guid.Parse("51dc24ec-d8bf-426e-9897-61a127025545"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("13f2f8e0-f20e-4b1d-bc24-60dbc82d60d6"),
                Code = "6714",
                Name = "Hưng Yên Dynava",
                AddressId = Guid.Parse("7f744e80-7615-46ee-85d6-f650a5dfd7d1"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("14f2d70d-1880-4de5-8e80-65a4233e5bd0"),
                Code = "6230",
                Name = "Gaopai Vipe",
                AddressId = Guid.Parse("e6ef7275-7641-4c52-84f8-d0edc480ed3f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("15129ab9-882d-456b-af1a-22668ce33a22"),
                Code = "7585",
                Name = "Huifa Zoovu",
                AddressId = Guid.Parse("b4078667-3951-4c38-9b8a-636d7088c746"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("181cb261-3832-4ee7-9c79-727be4a880f6"),
                Code = "5465",
                Name = "Naranjito Digitube",
                AddressId = Guid.Parse("caa0eea6-8ebe-47ea-bdbd-222e4cee5d9a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("1d4d1808-f8dc-42ed-8107-592beb55c4ea"),
                Code = "5735",
                Name = "Villa Serrano Lazz",
                AddressId = Guid.Parse("46921eed-7ef5-471f-85df-1f6eb55ddc2c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("1e36ca18-687b-49a6-9e76-1632136ecd1b"),
                Code = "7603",
                Name = "Ishinomaki Centizu",
                AddressId = Guid.Parse("67811665-9c99-459e-a52e-516e984da037"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("225085b3-a668-4c78-85c7-5653ce668fc0"),
                Code = "6680",
                Name = "Louisville Podcat",
                AddressId = Guid.Parse("864db008-67ba-4bc5-b96e-258f0ffa4e16"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("240351f3-95b1-4124-bac3-eb8d0fca1b7e"),
                Code = "8580",
                Name = "Anggana Gigabox",
                AddressId = Guid.Parse("2e8ed6fc-df1e-4a3e-bded-a3a258499397"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("245ba7b1-9089-48b5-bb3a-1839ccafc2be"),
                Code = "8268",
                Name = "Wodzierady Blognation",
                AddressId = Guid.Parse("86297851-0110-4eab-8bec-8bfcb462c65f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("308733d1-b6f1-433a-9897-33c0b8df51d7"),
                Code = "8184",
                Name = "Stockholm Einti",
                AddressId = Guid.Parse("81055bbc-6552-45fd-877a-d7f1a6f9a00e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("240610da-4cb9-4735-b19e-a13a65c47771")
            },

            new Customer
            {
                Id = Guid.Parse("3283ee28-6a2a-468e-b813-55a330bc39a4"),
                Code = "8791",
                Name = "Tân Hòa Fivespan",
                AddressId = Guid.Parse("0f6c02d0-d6e4-4d51-a58e-1baecd3f2c1f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("34ab1552-c97e-4728-863d-d0b6a455bf8d"),
                Code = "7032",
                Name = "Palotina Zoozzy",
                AddressId = Guid.Parse("69e920c3-3654-453a-af1a-a5b7663b2069"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("35153e46-3435-4261-978f-a6ea1ec09701"),
                Code = "7616",
                Name = "Valbo Edgeblab",
                AddressId = Guid.Parse("69455ac8-557d-4af5-9409-51d72910e252"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("3943f9fe-f31b-4e0d-aab0-c4355a83d28b"),
                Code = "5389",
                Name = "Anjozorobe Twinte",
                AddressId = Guid.Parse("29c4737e-2d24-415a-b98d-a0f1afb4f485"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("3bb9cd5d-39ed-4294-b674-44141f3bafef"),
                Code = "8662",
                Name = "Hearst Eabox",
                AddressId = Guid.Parse("62898a13-30e2-4ae2-8fc5-d3d83bcf8ba8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("3d96e6b6-9528-4fbf-a099-7871a4efffd4"),
                Code = "6211",
                Name = "Xiayang Quinu",
                AddressId = Guid.Parse("b3428fc3-470c-4f3e-b3a3-4bd768807cc0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("3db5de6b-423d-44c1-872c-e493dfba8ea0"),
                Code = "8175",
                Name = "Al Ḩāmūl Vinder",
                AddressId = Guid.Parse("79c61139-a3a0-466f-98a8-5e3c8bf9c639"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("240610da-4cb9-4735-b19e-a13a65c47771")
            },

            new Customer
            {
                Id = Guid.Parse("4015c417-b3ad-4431-ad37-0f692495ac2c"),
                Code = "5237",
                Name = "Kopidlno Brainverse",
                AddressId = Guid.Parse("62e99530-f94f-41b2-88ac-44876d28b8ef"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("240610da-4cb9-4735-b19e-a13a65c47771")
            },

            new Customer
            {
                Id = Guid.Parse("4484aa9b-1cb4-48e6-9861-e2a44e538abb"),
                Code = "5139",
                Name = "Zuya Topicware",
                AddressId = Guid.Parse("ea96345a-01c3-4cdb-8fc3-0fad4833bb2f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("451f87e0-23d5-442a-8826-6e2f1f1f2ac8"),
                Code = "6742",
                Name = "‘Amrān Quinu",
                AddressId = Guid.Parse("d3868b3e-8cda-493a-a08b-c80a02d327d6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("49b8870f-cabb-46a5-95ac-b50552260db6"),
                Code = "5967",
                Name = "Jenzan Oodoo",
                AddressId = Guid.Parse("c7128d7f-9621-42e2-bb42-40c91615e13e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("49a06b5a-f90f-45c1-8bc0-940220657870")
            },

            new Customer
            {
                Id = Guid.Parse("4e313173-56b2-4be0-83d9-8edbed68c7bc"),
                Code = "8995",
                Name = "Laranjal Paulista Eamia",
                AddressId = Guid.Parse("0b8ac0c9-cf50-43e9-99b6-9d9c6368b763"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("51060419-3c9e-4dc5-b13a-d5ccaacb0276"),
                Code = "8473",
                Name = "Szombathely Skiba",
                AddressId = Guid.Parse("757d48cd-6c16-4b22-83bb-2981797544c4"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("34ed5a6a-16b2-4124-a60e-391394cfe2cf")
            },

            new Customer
            {
                Id = Guid.Parse("5223bcf7-3c0b-4001-95e1-3b221de97cca"),
                Code = "5796",
                Name = "Faya-Largeau Myworks",
                AddressId = Guid.Parse("537f807c-6fc2-496f-a01f-ee23b456db5e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("550ee83b-8bc9-49e4-bfbb-ca753abdd735"),
                Code = "6338",
                Name = "Xiaping Fiveclub",
                AddressId = Guid.Parse("477fc83f-120a-4c0d-b7ef-2d36985a37ab"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("55820f2f-28ea-41d5-b978-47c630bc045f"),
                Code = "5096",
                Name = "Gwangjeok Avaveo",
                AddressId = Guid.Parse("36684879-b996-428d-bcd8-6dacc0e67f3a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("59066941-930d-4916-99e6-edeb59e31117"),
                Code = "6256",
                Name = "Gjoçaj Yoveo",
                AddressId = Guid.Parse("486c26b1-7222-4f28-bbb1-a818e81f2ed4"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("f091f2cb-e1a9-411a-95ef-878c571447c2")
            },

            new Customer
            {
                Id = Guid.Parse("5dc8f138-d4db-4514-a2d9-9b8581720970"),
                Code = "8499",
                Name = "Água Retorta Jazzy",
                AddressId = Guid.Parse("5aa52277-f819-4f56-a44e-fdf1d95db911"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("66672f51-767f-48af-be15-65abbeb9a9fd"),
                Code = "6822",
                Name = "Veruela Fliptune",
                AddressId = Guid.Parse("4b51e6b3-1790-4c31-84ce-d689b931200c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("6ccca5e5-27e2-4f03-be82-29a27dbe7f05"),
                Code = "8190",
                Name = "Oneop Skippad",
                AddressId = Guid.Parse("423d2b95-19af-42d8-aab9-4d4fc10cd2b8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("6f90fc99-0ff8-4d69-9f8b-faa72fc6b8cd"),
                Code = "7374",
                Name = "Xinglong Centidel",
                AddressId = Guid.Parse("10a82bf5-fdce-4ff1-9e59-22b8cba9d6dc"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("70578706-855a-42a6-8422-50d45c21841d"),
                Code = "7926",
                Name = "Chemnitz Vidoo",
                AddressId = Guid.Parse("9769802f-564e-4560-ac72-580b73a76405"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("70f3c785-e3d2-4808-a572-0510b703068f"),
                Code = "6412",
                Name = "Anse à Galets Yodoo",
                AddressId = Guid.Parse("9fc2ffac-797c-41aa-80dc-8ada4b5e3268"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("7740204d-b255-46df-8b36-25ef1449f550"),
                Code = "5987",
                Name = "São Paio Merelim Gigabox",
                AddressId = Guid.Parse("b1f94972-6da9-4b98-8baa-f0222dc5722a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("7d025447-65b1-42ac-bc7e-2eb3296e1b46"),
                Code = "7519",
                Name = "Altan-Ovoo Kazio",
                AddressId = Guid.Parse("cedf3806-2a44-44b1-bce0-4e1e05319d00"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("8347ef80-c2d1-4d8d-ad09-a008fc1bb184"),
                Code = "8002",
                Name = "Gubskaya Photojam",
                AddressId = Guid.Parse("a5b5b248-fb20-4859-a017-da8ebfaabc2d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("83580d7e-a3f6-43bf-8847-f99b3e04a26d"),
                Code = "7859",
                Name = "Alhos Vedros Rhybox",
                AddressId = Guid.Parse("c8802699-b296-4f27-a07e-7e82eb6727cc"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("8514324c-dd15-4d06-8998-ee60c9971164"),
                Code = "6077",
                Name = "Rizómilos Lazzy",
                AddressId = Guid.Parse("40c7aa57-0f17-4e2e-a9d9-2ab2d32fef8a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("34ed5a6a-16b2-4124-a60e-391394cfe2cf")
            },

            new Customer
            {
                Id = Guid.Parse("859c3d1f-f33a-4f13-a6e6-8a4d26270a68"),
                Code = "7845",
                Name = "Sendangwaru Zoozzy",
                AddressId = Guid.Parse("03fe453f-c684-4ad8-a7e8-919fa4365ebc"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("8a1222e2-ec4f-4a61-b8bb-178b81209b97"),
                Code = "7325",
                Name = "Vishow Ntags",
                AddressId = Guid.Parse("ddaebdde-84c9-4405-9515-1038152c583e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("8a520f1b-e857-495a-ba68-d3efe0d04513"),
                Code = "6160",
                Name = "Wanmao Mycat",
                AddressId = Guid.Parse("21365c0a-ba0c-4e5a-9782-fea8e05bef87"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("8c760b1e-4834-4fc5-8ab6-767621a799b6"),
                Code = "6880",
                Name = "Granja Shuffledrive",
                AddressId = Guid.Parse("edf465c3-2e42-4c6e-8281-822d9505d30f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57")
            },

            new Customer
            {
                Id = Guid.Parse("8cb8d455-ff46-420c-a5f3-8d45586e3b78"),
                Code = "7059",
                Name = "Zásmuky Oyoyo",
                AddressId = Guid.Parse("8f506ef0-dcb1-4118-bc6a-67d21b409876"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("34ed5a6a-16b2-4124-a60e-391394cfe2cf")
            },

            new Customer
            {
                Id = Guid.Parse("90ed16c5-179b-4213-94c6-945b84ee15dc"),
                Code = "7103",
                Name = "Hudong Blogpad",
                AddressId = Guid.Parse("8fdf671b-cc88-4d3a-962b-29debd0487cd"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("9429b285-9974-4a31-a719-77cd420a083e"),
                Code = "7704",
                Name = "Xintang Centizu",
                AddressId = Guid.Parse("27077033-cb64-4490-a6be-a7f9c9cf77e3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("9536c8eb-8485-449c-b966-36f2b05921a3"),
                Code = "7737",
                Name = "Buena Esperanza Browsebug",
                AddressId = Guid.Parse("05586327-805f-4d18-a758-5fc468bf31c9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("9947af67-db7d-4626-b91c-5b0ba6de9be9"),
                Code = "7522",
                Name = "Pregrada Rhynyx",
                AddressId = Guid.Parse("8eb72077-2a86-4b9d-9a29-5c894b22c3fe"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("9b4502fb-2925-444e-8a6e-e3fef0c064a7"),
                Code = "6514",
                Name = "Zhulan Realbridge",
                AddressId = Guid.Parse("e4128b3d-61e8-4c90-a074-4b8526f7d69b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("a269ada2-6ddc-4acd-9c27-ec9b9e742fcb"),
                Code = "6775",
                Name = "Svay Rieng Feedbug",
                AddressId = Guid.Parse("81f7705b-70e1-467a-aa47-f18130e03b39"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("aaeabf37-11e7-4195-87d6-08957002c8b1"),
                Code = "7800",
                Name = "Ambatolampy InnoZ",
                AddressId = Guid.Parse("452ea8ba-acdb-4e7f-817d-e100d5843467"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("abafe08a-3bb8-46cd-86c9-63b793922a39"),
                Code = "5399",
                Name = "Montijo Abata",
                AddressId = Guid.Parse("509f0c00-fe14-4620-9c2f-ac04f0e2290e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("abe3e8c7-b8d3-4d04-9027-ee7ef2e5ed8e"),
                Code = "5028",
                Name = "Borogontsy Jatri",
                AddressId = Guid.Parse("a0bffa02-bb8c-45ab-9e98-f088741f63f5"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("ae9a67c6-6908-490c-b777-a9e2c03781af"),
                Code = "5783",
                Name = "Huaqiao Trunyx",
                AddressId = Guid.Parse("898edfcd-47bc-4788-be5e-191b2efcdc09"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("af722a07-2934-4171-9e26-9611620a5d4a"),
                Code = "6321",
                Name = "Phú Túc Eire",
                AddressId = Guid.Parse("99bdf581-646d-4635-b7ec-1c85ae21caf5"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("b245d236-015c-4050-aaa4-c586da91f72a"),
                Code = "5139",
                Name = "Phutthaisong Thoughtworks",
                AddressId = Guid.Parse("def2e733-1424-43f0-b6bd-a5b919d5b136"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("b295a3e0-0cf4-4ee2-ae90-0d964f149434"),
                Code = "6124",
                Name = "Matanzas Trilia",
                AddressId = Guid.Parse("309ec385-ff1b-4d6a-9bc5-8e1df2cf1fc7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("b73b96d6-036c-4c25-8726-a00a96f7037d"),
                Code = "8229",
                Name = "Salwá Thoughtsphere",
                AddressId = Guid.Parse("5d062e93-d81d-4b38-824d-330f4dcfc3f7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("ba9c006d-b9dc-4aae-90a3-861027f8bf28"),
                Code = "8778",
                Name = "Cortez Browsedrive",
                AddressId = Guid.Parse("542646ea-5dc8-4b69-906c-f9a351a9b444"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("bba75ae0-fbe9-4083-b887-70236f2da58b"),
                Code = "6442",
                Name = "L'Assomption Buzzdog",
                AddressId = Guid.Parse("35a98089-3d0e-4c5e-8f9b-695a7fd3ec20"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("34ed5a6a-16b2-4124-a60e-391394cfe2cf")
            },

            new Customer
            {
                Id = Guid.Parse("bc23c63d-be8c-4960-a6dc-f5164c9e0a0b"),
                Code = "8943",
                Name = "Vicente Guerrero Livetube",
                AddressId = Guid.Parse("2ca8d613-15fe-40cc-964f-4ae33d840136"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("bc6dac41-b19e-4742-a9a8-aef33933a349"),
                Code = "6686",
                Name = "Vovchans’k Vinder",
                AddressId = Guid.Parse("14f05196-5ed4-4700-95ac-38fe4920bd97"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("bdfdb0ea-9991-4ed7-a174-7a359f21438c"),
                Code = "6526",
                Name = "Chusovoy Brainbox",
                AddressId = Guid.Parse("5a02f8f1-3ee1-476b-a02a-f4a6e973993a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("c1decd45-dfdc-49be-8769-e562ff5e33a0"),
                Code = "8057",
                Name = "Orodara Vinte",
                AddressId = Guid.Parse("d6cf8692-ca3e-4e7a-a2f1-00e946716cad"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("c36607cf-976c-4a2e-a09c-67c18af70d72"),
                Code = "8333",
                Name = "Dongfanghong Blogpad",
                AddressId = Guid.Parse("144ee5b8-1dfd-4583-a1e2-4cd9852e5537"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("c6aff869-d2ea-420f-b381-1cc66820fa5c"),
                Code = "7200",
                Name = "Nanjiao Twitterworks",
                AddressId = Guid.Parse("363c7844-a5d7-4317-ad94-7c948f069892"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("c6b19fb0-d82b-4dc1-8a9b-e0d0d1079dff"),
                Code = "5315",
                Name = "Rendian Quatz",
                AddressId = Guid.Parse("6fa38310-f481-448c-af90-8e8e4f8d6e1b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("cfa000cc-7914-4c56-83b3-03750858f9a8"),
                Code = "7793",
                Name = "Shicheng Jabberstorm",
                AddressId = Guid.Parse("5e745049-a00e-4d8a-bdd6-9d62d6eca0c4"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("d0af86a4-5472-461c-b6a1-17067bd8c0d2"),
                Code = "6861",
                Name = "Anping Aibox",
                AddressId = Guid.Parse("f4935e2d-ea1e-4c65-8ff7-791dd9d8ed22"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("d1389037-dc3a-4938-abb1-74dead5e1b53"),
                Code = "5271",
                Name = "Situsari Rhynoodle",
                AddressId = Guid.Parse("dc4850b4-554b-4878-8af5-48488d8d9d65"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("d58d12f7-5e64-424d-ad62-6fd0ff60ebbc"),
                Code = "8431",
                Name = "Capas Dabvine",
                AddressId = Guid.Parse("6b5b43a5-0837-437e-b06b-1d8b911bc218"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("d6b3a066-520a-43ff-983c-4e4cd579c9e9"),
                Code = "8573",
                Name = "Ljungsbro Zoomlounge",
                AddressId = Guid.Parse("ac4b9936-4cec-4add-a0d0-3cb3506c8e50"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("d84aa82d-fd2b-452a-a9fd-c5928fae0829"),
                Code = "5640",
                Name = "Petrolina de Goiás Quatz",
                AddressId = Guid.Parse("84141d53-c4cc-49be-86a1-04992c0ec1fd"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("39b50de2-aac0-4880-a0b1-3f6f548eb8f9")
            },

            new Customer
            {
                Id = Guid.Parse("db0937ae-73b4-4083-9b34-44c2db59bd12"),
                Code = "8264",
                Name = "Cikembang Ntags",
                AddressId = Guid.Parse("8cb517bb-9bd2-48f5-b18f-e480c9d25bea"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("db7c0d56-72f0-43be-93f0-0fd8d123c081"),
                Code = "7634",
                Name = "Migues Wikibox",
                AddressId = Guid.Parse("b1644ebb-604e-4d65-b29a-bbf58d78eba8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("49a06b5a-f90f-45c1-8bc0-940220657870")
            },

            new Customer
            {
                Id = Guid.Parse("dbad4020-7ad7-4d55-b4a9-a29a378c9414"),
                Code = "7930",
                Name = "Calumpit Tagpad",
                AddressId = Guid.Parse("817f5b4e-9812-4f56-9bee-0c08700a7352"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("e68839c8-1b05-40a2-8e7d-0bff9162462c"),
                Code = "8544",
                Name = "Cabricán Thoughtstorm",
                AddressId = Guid.Parse("c41a8995-b0f6-4138-8646-aa74ab98ddfe"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450")
            },

            new Customer
            {
                Id = Guid.Parse("e6e72b41-fb7d-48a1-b11b-8cd316a43c51"),
                Code = "8528",
                Name = "Ban Phaeo Cogilith",
                AddressId = Guid.Parse("bb3b70c2-d2a0-49fe-a5c9-5e90cf2d31e9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("e72c9a27-6ac1-47f4-a66a-d65e9e0d46d1"),
                Code = "6792",
                Name = "Emplak Flashdog",
                AddressId = Guid.Parse("e4f9808a-f0c7-4b4d-b871-c463f1eabb74"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("240610da-4cb9-4735-b19e-a13a65c47771")
            },

            new Customer
            {
                Id = Guid.Parse("e78b1196-21ec-47b3-a82c-9a1854c4ba2c"),
                Code = "5924",
                Name = "Jetis Topiczoom",
                AddressId = Guid.Parse("6bcb42a6-6a58-4595-aeab-8396284c6a17"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("34ed5a6a-16b2-4124-a60e-391394cfe2cf")
            },

            new Customer
            {
                Id = Guid.Parse("e8964b4d-c59e-4a55-a958-fc43955a289d"),
                Code = "7637",
                Name = "Huadi Twimm",
                AddressId = Guid.Parse("d7291aa8-3b54-4fd3-b0dd-df93a873af10"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("e8d55a90-f1d1-4935-9cb4-d2cd6a73cd88"),
                Code = "8203",
                Name = "Seto Jaloo",
                AddressId = Guid.Parse("436e77da-29c6-4779-98e9-0b893dfba318"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("e963e674-af77-4991-b10a-4d33c3b48a78"),
                Code = "8576",
                Name = "Rudnik Dabvine",
                AddressId = Guid.Parse("0d39a99a-894e-4ad3-854e-2227071761e2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("e9fa68d5-9792-42c8-8d5c-e15e7018648b"),
                Code = "8735",
                Name = "Kýthnos Jabberstorm",
                AddressId = Guid.Parse("93b6a176-7f67-4783-8381-6977b709f342"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426")
            },

            new Customer
            {
                Id = Guid.Parse("ec4cf749-24cd-45b4-9285-bc1f22b52204"),
                Code = "6427",
                Name = "Tisul’ Thoughtstorm",
                AddressId = Guid.Parse("dd6c4688-c2d5-488e-b0a4-5871ba989b54"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("f33edc88-1eb1-4de4-90bb-178dc2113af5"),
                Code = "8629",
                Name = "Bera Voonyx",
                AddressId = Guid.Parse("6791823e-7eb4-4d05-b5c3-dc34f86ffcab"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("34ed5a6a-16b2-4124-a60e-391394cfe2cf")
            },

            new Customer
            {
                Id = Guid.Parse("f45d434b-9376-48eb-a77b-f873d7f23d2e"),
                Code = "8453",
                Name = "Karangtengah Lor Katz",
                AddressId = Guid.Parse("f3f745b5-98c8-4016-888b-1625db7666f5"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("f4b38069-4ed4-41e9-8fab-b5297c2946df"),
                Code = "7026",
                Name = "Mahe Shuffletag",
                AddressId = Guid.Parse("5ae892f8-2f88-4b22-af31-c120533bcb06"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("f4bccb1a-fb5b-40ba-b682-57737477ecb3"),
                Code = "6547",
                Name = "Dal’nerechensk InnoZ",
                AddressId = Guid.Parse("38b4b958-51f1-4a00-a258-e67df7696110"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("f6603a4e-ae80-45e4-984e-c80f64420f3c"),
                Code = "5714",
                Name = "Labnig Rooxo",
                AddressId = Guid.Parse("0016eba5-f55a-4c0c-85e3-b54d36b53ed6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b")
            },

            new Customer
            {
                Id = Guid.Parse("f6e86569-69a8-4c10-b1c2-3cb4e74eeb64"),
                Code = "8419",
                Name = "Nakuru Flashspan",
                AddressId = Guid.Parse("05612d3c-3128-47f4-8216-3ca565ebf0c7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("f70b159f-0469-4887-8abf-ffce8c645616"),
                Code = "7091",
                Name = "Huangdu Katz",
                AddressId = Guid.Parse("71778327-c312-4ffe-a4a5-31ae788dedb7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("49a06b5a-f90f-45c1-8bc0-940220657870")
            },

            new Customer
            {
                Id = Guid.Parse("f9555fc5-f1d4-42e4-8ff6-47683bf26e97"),
                Code = "8029",
                Name = "Oklahoma City Tagfeed",
                AddressId = Guid.Parse("0ffa059c-f272-40e6-abf0-06cfff66ae6e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("fa579f31-2357-4b1c-9eff-6248bb88217a"),
                Code = "5670",
                Name = "Ebene Blogspan",
                AddressId = Guid.Parse("404e41d2-9817-42f0-9b42-05fa55ffa116"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0")
            },

            new Customer
            {
                Id = Guid.Parse("faa54a0d-497b-4323-93f8-e54d7b5b0cc9"),
                Code = "6118",
                Name = "Lansing Pixope",
                AddressId = Guid.Parse("cb810fe1-9ea5-49f2-afac-8860fc8911a6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("49a06b5a-f90f-45c1-8bc0-940220657870")
            },

            new Customer
            {
                Id = Guid.Parse("fe409812-db1d-496c-8c4d-fa77e173db51"),
                Code = "8370",
                Name = "Tawaran Youspan",
                AddressId = Guid.Parse("d2c239ad-fc52-47b4-870e-9a58d134e69e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a")
            },

            new Customer
            {
                Id = Guid.Parse("fecc825d-31ed-419b-8aa7-bf7eb4a13a19"),
                Code = "8363",
                Name = "Hlybokaye Tagcat",
                AddressId = Guid.Parse("ff7a7c2d-b5d6-4035-acff-b2bf5ecc5f4a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                CompanyId = Guid.Parse("39b50de2-aac0-4880-a0b1-3f6f548eb8f9")
            }




           );
    }
}
