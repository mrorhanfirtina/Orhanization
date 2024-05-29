using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationCoordinateSeed : IEntityTypeConfiguration<LocationCoordinate>
{
    public void Configure(EntityTypeBuilder<LocationCoordinate> builder)
    {
        builder.HasData(
            new LocationCoordinate
            {
                Id = Guid.Parse("0064525a-1c29-4743-95d6-5eaa5f3537c7"),
                LocationId = Guid.Parse("5D73712E-AC35-47CD-B70C-3BC7B5DE4A8D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("00c69639-7d4b-43b2-948c-74eecd31de31"),
                LocationId = Guid.Parse("3B70B04D-EAFC-4C94-BBA0-1E088ED3C4AC"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("017d0f55-1b3e-469d-abd6-4b1befc7cd3f"),
                LocationId = Guid.Parse("99659BE1-D0DC-4E92-BAC1-8186B6A29840"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("01f60c16-15dc-4a6e-8c67-ecf45953e46b"),
                LocationId = Guid.Parse("31819F07-8281-40CE-87D6-9F27AE1285A6"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("01f6c74b-cc23-45e8-acb6-563311591b95"),
                LocationId = Guid.Parse("5B8C341E-E660-4796-B4F3-2E7BAE6266D7"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("021bbf68-d65d-497e-9a3e-6cfdef29eed5"),
                LocationId = Guid.Parse("35B46911-4A55-410C-9611-9DAED52023C1"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("02287142-9576-4474-8d16-490b5c860677"),
                LocationId = Guid.Parse("594718C4-07F8-4130-946A-AE3E0F9ACD08"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("02a10128-fca4-4a47-a59b-13f3462f1ca5"),
                LocationId = Guid.Parse("34845879-8C11-4101-BFD5-4CB92081BE64"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("02a52512-f343-426e-a75a-63baf635c549"),
                LocationId = Guid.Parse("2A58FE31-856B-4010-93DA-53DEEFDE4ADD"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("02bfbbcb-51fb-4cbb-a72d-3ba592361653"),
                LocationId = Guid.Parse("0F650255-8AF5-4492-AC90-415CE6EF3453"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("02ce314f-da7f-4232-a423-a84a4a30a3e3"),
                LocationId = Guid.Parse("205DCFA3-3385-4CBB-A978-B87BCD60957A"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("031deda2-5b7b-4a7f-a757-44903f032732"),
                LocationId = Guid.Parse("661C6B76-A58B-4272-A08B-22306ED378F3"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0364c4ec-73af-4bd3-ba42-be51821a421d"),
                LocationId = Guid.Parse("25C4071B-EDCA-455E-9ECC-9BDF9F2DFB77"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("03cfa92d-5533-4a61-b6ff-e01f14e011ff"),
                LocationId = Guid.Parse("2D279747-62B7-44F7-8E85-A7D4E92F6204"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0481dee6-08b0-49d8-ad81-21ae66f89707"),
                LocationId = Guid.Parse("6C4EB2F8-86CD-4ED6-AD91-4E286B6FE9EE"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("048f189e-a2ca-401b-89a9-b792e4f02d25"),
                LocationId = Guid.Parse("06E34A1B-A351-4E0C-9E33-C5B375BCEE29"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("04b73006-fd1e-4614-b11b-d50ded104130"),
                LocationId = Guid.Parse("D0496B8B-921D-4027-8DB3-5BFCC241CBEA"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("050fe3d9-7256-4bcb-be50-e52b60be2ddb"),
                LocationId = Guid.Parse("78E6B748-6242-4415-9133-B65DE0F76784"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("059ae06e-67f1-483e-9a9c-455ffe09f7ef"),
                LocationId = Guid.Parse("0BC9D1AD-A1E3-4271-96EC-3810C969EE11"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("05b2cf9c-c7fa-44b0-b92c-2646d3f8cdad"),
                LocationId = Guid.Parse("C90D2F0C-D0B3-414D-A015-E20EFE4CDEE6"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("05d05e81-4c79-4173-8a07-1996c79c4c9b"),
                LocationId = Guid.Parse("C9E0D628-39FF-4673-8876-C04F3C8B49EB"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("06760148-af72-4921-b57b-2c489d8e8000"),
                LocationId = Guid.Parse("4BCA6AEA-CD6D-4D04-ABDC-0445BC92554E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("071022f1-e62b-44c7-bc33-b2f7c36cecbf"),
                LocationId = Guid.Parse("6D5C46E1-8A4A-44B2-B6DB-C21548AAF6C3"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("073205d3-e1ed-4cdf-b370-f2e263b1c401"),
                LocationId = Guid.Parse("718BB6AB-A0BF-413B-AC1C-8DE31CE2BD2D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0739af58-21b5-4554-adaf-81c7fcf1dbfb"),
                LocationId = Guid.Parse("CEE58723-48B6-403D-B03A-A4E17FED8426"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0785e25d-711f-4856-881f-28dc641de773"),
                LocationId = Guid.Parse("05D8F377-E968-4819-8FA1-3688DC226F6C"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0797ae0f-70b5-4fd5-a892-c28b95b2f927"),
                LocationId = Guid.Parse("62F5D3F2-9B9C-4431-A774-B650899D55C6"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("07a355ca-ea9f-4cf1-88e4-6db116685a15"),
                LocationId = Guid.Parse("5E0157FE-E695-4BE7-9DCA-5674E533D1A8"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("07f82afc-36f6-4080-97bd-4c9e83ca93f8"),
                LocationId = Guid.Parse("95467DC2-DD7F-4D85-85D1-F178D346A637"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("081b3142-3b40-4d1d-a25d-8fae85a4712b"),
                LocationId = Guid.Parse("B3FB89E5-363C-4FBD-A978-1D23F191A2BC"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("08cfc03f-1067-42d3-8d3c-47d77bbf9093"),
                LocationId = Guid.Parse("E9FA3839-7F98-421B-B04E-3A173334B838"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("092ccce5-5256-406e-8bd6-d532f39a10b8"),
                LocationId = Guid.Parse("92142BBC-FA32-446F-A62E-0A6087D3129D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("094b89ad-7e05-4a8f-8b2a-2e2b1ad31608"),
                LocationId = Guid.Parse("9AB14C2E-6FD0-4C4E-98DE-D8E576B2668E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("098b1929-c35d-4d8a-b4ea-6ff0686ac9c3"),
                LocationId = Guid.Parse("68BE3CE8-6174-43D4-A145-2A97DD7DE349"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0a02bcbf-732b-4217-a2ca-8a3baf1d83a8"),
                LocationId = Guid.Parse("E87A9F3C-660E-4D0A-A41B-4CF92415D6F8"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0a095f9e-762e-4733-8e96-8e410a4b3973"),
                LocationId = Guid.Parse("951C4193-A262-49D5-BD04-3618BCD87A79"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0a18a1a2-0411-4b61-ab34-2923f783ada7"),
                LocationId = Guid.Parse("C5D2D529-425A-4AFF-8501-D60400C5AF80"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0acb362a-2b78-4093-a52f-1f74ff74156f"),
                LocationId = Guid.Parse("86867DC0-4575-44EE-BDE0-2F9DE986BF4E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0adbd273-d455-4f1e-8615-71a2428169b0"),
                LocationId = Guid.Parse("DDAB77D2-F5B6-4496-86B7-D244B5DC3939"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0b1c8b52-b61a-4e62-a3b2-24144e5e52b4"),
                LocationId = Guid.Parse("726B5B2F-8AC1-457D-ADB9-53003E078E30"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0b59163e-266e-49cf-8da5-7403bb1990dc"),
                LocationId = Guid.Parse("5472C4DF-4717-4841-9151-3BE69ED68B4E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0bbfb8ba-d5f3-4dd6-b476-eddd00a07c98"),
                LocationId = Guid.Parse("180DF9D6-C0B0-4B3E-AD02-E3C4E4792097"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0c060839-05cb-4399-83cc-6cf323d81490"),
                LocationId = Guid.Parse("A518B657-DDFF-4588-A8D5-C86D931A6E86"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0c380030-f09a-458b-9d35-5d5321ec3bc3"),
                LocationId = Guid.Parse("33103507-FD3B-4299-BC4D-45695385492B"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0c38a23e-d549-4495-b8c4-ffbb280d8282"),
                LocationId = Guid.Parse("CBC0A569-A95E-4903-AC34-A6184196D42E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0c5f97b9-64ab-483a-83a1-4ead1522fb0f"),
                LocationId = Guid.Parse("7677A671-91B3-4B61-B10C-F0E9DD8D8583"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0c77bb44-d6dc-4d7c-8890-fc97f23e0238"),
                LocationId = Guid.Parse("8D0714C7-0259-400C-9AF8-89EB8E19E959"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0d1265bc-35d9-4e02-a6c6-56f259593fa4"),
                LocationId = Guid.Parse("3A1757D8-1F1E-416E-8D4E-D2DF97E68EF9"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0d358bec-2dd1-4059-8cc9-82d33e19b8f0"),
                LocationId = Guid.Parse("04714C80-D35F-4AD6-96BC-706A13D86EE7"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0d62671b-49d1-4445-a9ac-c83c3e1bfab2"),
                LocationId = Guid.Parse("7D9A365C-BFDC-4220-B29B-7C9B0DC76EE2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0d8b8b9e-810d-4d4c-8312-0edeea064c40"),
                LocationId = Guid.Parse("3E0279F0-95F6-449A-BDF0-BB60DFCE87FC"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0d9f5fbd-719c-4a73-9424-ec8208c6da32"),
                LocationId = Guid.Parse("EB4967D0-8479-426C-B8A3-FFA96085A5DA"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0db4bb25-0efd-463e-b44e-0206c85651d3"),
                LocationId = Guid.Parse("85E574E5-871B-4A7C-A6A0-912D978AA876"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0e1af227-adb2-45b5-ab55-35d66e5eca8e"),
                LocationId = Guid.Parse("1F143097-B1BB-4018-8C0E-95165AB3320C"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0e81c810-5d54-4dc3-8711-4ad83e2dd5d8"),
                LocationId = Guid.Parse("E35CBE4F-55B7-45FA-8908-03C607DC779C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0e923b95-0d91-4e57-b1ac-4abe04e8fe96"),
                LocationId = Guid.Parse("F1C732A2-2F5E-412F-A04B-96825E0E3015"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0eee89ce-8ba1-4382-ae8a-20297c5d8f24"),
                LocationId = Guid.Parse("03946599-1758-46B0-AF46-6AA6D0C5C919"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0ef0b7f6-7f5f-4f0d-8ac9-f8dc89f6a26a"),
                LocationId = Guid.Parse("EED54415-6ED5-4F27-9F35-86E237D41C66"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0f30cfd5-a532-442f-9bdd-de8493e2381f"),
                LocationId = Guid.Parse("917064AC-EF1E-49EC-8AA5-034EF79831C2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0f50fd8a-fe25-44cf-976d-1ae8dc3d7294"),
                LocationId = Guid.Parse("8A1B3040-6893-4048-A132-7BDD80C675EF"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0f56c8da-8c6f-4714-a5f9-4c44aa5cc2d6"),
                LocationId = Guid.Parse("88D671F7-16B8-4811-B4B3-27EC75979F48"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0f775e12-04f6-44ce-a95a-ab8848994a9f"),
                LocationId = Guid.Parse("94AD1168-126B-4866-967B-366E2790BEA2"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0f9b2c23-acef-405f-9d82-325f415fdfcd"),
                LocationId = Guid.Parse("4F241A92-D523-4661-8604-0079F002008A"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("0fe28ac9-d399-4cf8-9aaa-cd7a7a9336ef"),
                LocationId = Guid.Parse("A53DB7AA-48F1-462F-BDF1-9FDEFC5F2BC4"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("100738a6-400a-4bc7-ac2b-9a3da4b0c7ed"),
                LocationId = Guid.Parse("F468A76A-A400-4179-986D-CBF1F3F6EDE6"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("10683920-220a-474c-9ee8-44369c04dfe9"),
                LocationId = Guid.Parse("9CFFE146-C8B1-4379-B188-5B9B6BDF7023"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("10aa1611-240f-4721-826f-44b7a5868d17"),
                LocationId = Guid.Parse("29E6E644-EE1C-4814-A915-DD8A576DEB70"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("112e9f0d-600b-47e4-a592-60eea48e60f4"),
                LocationId = Guid.Parse("EDD0D4D6-446C-4FB2-837A-80750B3C0E16"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("11c8f061-ff80-47f0-8a89-9ed3ccb08030"),
                LocationId = Guid.Parse("1F833821-F59C-4B29-B8D9-194547611709"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1242a09b-c2e1-438e-bab8-5a02efbbea8d"),
                LocationId = Guid.Parse("6C3FD444-B14E-42FF-8658-DB585E6B0CC4"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("125c88ca-513f-43f0-a771-8d269f7bb585"),
                LocationId = Guid.Parse("A11B39BF-8835-4331-8876-0C414E2899DA"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("128cce05-2b2d-4559-9b6b-c350e078c503"),
                LocationId = Guid.Parse("21BD5634-DC69-4A22-B743-B6C015D9BB2D"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("128d08dc-1a55-42f8-9ce6-7f175561be99"),
                LocationId = Guid.Parse("208B21C2-5C59-4163-A32B-49C7EAC24A07"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("12c6bd63-c343-474b-bd5a-7b608737e403"),
                LocationId = Guid.Parse("3E5D5B64-5184-472D-8B00-904E6D19884C"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("135e7292-792d-4e55-99ed-1d8e9e9284e1"),
                LocationId = Guid.Parse("1F4B2FA7-A9F0-4DF0-B899-BF2FBD03CFA1"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("13612ff5-66d1-4668-bea5-abe52cee0996"),
                LocationId = Guid.Parse("023AC259-B641-4A72-9E96-F5BB2D165D27"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("136cc42c-2df7-4516-86b3-bd8d00461fce"),
                LocationId = Guid.Parse("1EB23889-EB0E-47D9-83E6-A2D268DEC092"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("13810ed3-e8fc-4321-b4c3-e3a78919afdb"),
                LocationId = Guid.Parse("21B2CBD3-03BA-4043-A159-993E9B3E7A9D"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("147ed83d-c7b0-4647-8aad-6d30a4d40add"),
                LocationId = Guid.Parse("6CBFFB60-9CA7-4D32-8C24-E49F14AF0281"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("14cb57ce-a7e2-469e-af8d-20b9f7b6f2cd"),
                LocationId = Guid.Parse("218C693A-9F45-4D62-BED7-9D124AE3FEAB"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1501c1ac-3016-4fba-868b-39af750b53cc"),
                LocationId = Guid.Parse("6908B3B1-B0E8-43A3-975A-D97499131C4B"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("153ccdd0-f730-4d0d-a20c-c8cf3e125385"),
                LocationId = Guid.Parse("7D881881-E983-403E-88FC-FB70F7DD6A34"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1580af17-abd0-4684-a35a-ab755d2a386d"),
                LocationId = Guid.Parse("F97DAD7A-F345-4E81-9E0C-44EE99C74E49"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("15dffd27-ab8a-4105-a2ae-da6823940c82"),
                LocationId = Guid.Parse("0EFC4F0A-52A3-4B1C-BF12-50CD20DAD3CB"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("15f153bb-f61d-4fcd-a520-35cd1db1a427"),
                LocationId = Guid.Parse("AE4475A7-41EE-467F-99D2-241AC7057CE1"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("160c381b-8920-46de-8dca-d28e1d48234e"),
                LocationId = Guid.Parse("AB663B62-9719-41B7-96C9-CDA1597F831E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("161c452a-7016-460d-a251-c3764de33b2f"),
                LocationId = Guid.Parse("33B2FCE5-1F47-4C84-84B7-19D15628C410"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1681a1a1-f051-4e81-a80d-6613d9ae753e"),
                LocationId = Guid.Parse("B3237950-B52C-4241-93E5-CFBA89D81C51"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("16907adc-817b-4691-8581-722697b870d6"),
                LocationId = Guid.Parse("B783C6C7-902B-4F52-9366-2782DBB09A32"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("16ad7d41-9c86-4c49-a0a9-99910a743413"),
                LocationId = Guid.Parse("CDE1CC2A-A6E1-4070-BAEF-F64584CB386F"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("16eea703-e029-46ee-b7b9-a1bbe7a02c53"),
                LocationId = Guid.Parse("4F445D33-29F9-46CF-AB1F-04A3C139086A"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("17207191-2ee5-400b-9916-bb3b87d1a253"),
                LocationId = Guid.Parse("20F92890-3774-4091-A98C-E8C40972354D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("174edd56-e72b-4791-b8a4-e01e17904a05"),
                LocationId = Guid.Parse("614459A6-4602-4E8E-932F-98C2A9403AD1"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("174fab41-22e0-4c22-9ef6-c00595e372bd"),
                LocationId = Guid.Parse("FE66203B-2C95-492D-8CBE-036EC1A709F5"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("17a72b58-ab98-40c8-9b6e-1ac95d286930"),
                LocationId = Guid.Parse("8BEB918F-04BA-4BA0-93B9-F87BA4D9206E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("17f04ce7-fe0f-4bc8-abba-6d3efcd8566d"),
                LocationId = Guid.Parse("E83B1E0A-1AC3-4588-982A-EACF5DB21727"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1821553b-509e-4164-ac27-1663a7d43263"),
                LocationId = Guid.Parse("142B6FFA-FDA6-4279-AC0D-52E7657D2D94"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1841f77f-2ef3-4ae7-90f2-3f43f968ecd7"),
                LocationId = Guid.Parse("B0165826-58B8-4077-B4BF-3027E2841691"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1860100d-29e6-4cc6-af9d-e1dcdd68bc23"),
                LocationId = Guid.Parse("C28554DC-D7E0-4633-A413-FF81990AAA86"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("18891bf1-a90e-4c02-8911-98f6e96625d4"),
                LocationId = Guid.Parse("C4E8063A-0FEB-496E-9A5E-6F8A0FF6B845"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("189450be-b8f7-416b-b554-5691865a6b1e"),
                LocationId = Guid.Parse("DF34862E-5CF5-4829-8DD1-AB9E0ACA4F06"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("19179816-30bf-4c12-9d2e-f8ebf5dd9d9b"),
                LocationId = Guid.Parse("61C049BF-5637-4E2E-B89B-D53F345A9284"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("194bb816-f1c9-4339-9aa9-fdfd5cee591b"),
                LocationId = Guid.Parse("BDF943B0-6934-4C34-BCF0-04C4C1042FCE"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1976c223-478a-4206-9562-5e9c11357259"),
                LocationId = Guid.Parse("091245F7-359D-4DFA-ADDA-A6AD7D2B364C"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("19a05d4e-d411-42af-ae62-0664605122c9"),
                LocationId = Guid.Parse("9E08B94E-30A5-4E74-8B4F-54EC70E3B7D4"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1a1feb23-e026-49c5-b4d8-6af41c8e9149"),
                LocationId = Guid.Parse("385F1ABA-1C6F-48F9-8551-CB47434E6200"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1a377580-5e95-4455-899b-7cbc382d210e"),
                LocationId = Guid.Parse("76430393-B4E7-4188-8FED-67871854FFAA"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1a76049d-1a4a-4100-aeb7-ff44d385abbd"),
                LocationId = Guid.Parse("4FFDE7D1-1759-4A8C-B154-5C02D92E04F2"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1abea6da-f9f5-4c0e-a4d7-16b342c900a6"),
                LocationId = Guid.Parse("4C6EA125-CB8E-49E6-BE1D-A67D2ADF42FD"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1b1f6714-32ca-4757-9baf-3ce69894b64e"),
                LocationId = Guid.Parse("2857A1B2-6385-4BC0-83D1-38AB382D7073"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1b5bb191-c0f6-4fd5-b33e-487bb17421fb"),
                LocationId = Guid.Parse("5C2758A6-5BAF-4F99-87CD-3912E7F5BE70"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1b669985-7a44-42ad-b8ac-9536c7edd47e"),
                LocationId = Guid.Parse("E175E037-1BD1-4B37-AFAB-60D98F0382C1"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1b7ac669-812a-4705-a2c0-9c8aa09ad200"),
                LocationId = Guid.Parse("605AEB26-A210-49F3-B324-015DAEEC249C"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1c74153f-1f6f-4010-951c-65a89d078d1a"),
                LocationId = Guid.Parse("A472088F-B78D-4125-93E7-0205E3928D0D"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1ca137c1-7247-49cb-9b0d-db1be2e7241e"),
                LocationId = Guid.Parse("EA4C8E3E-E974-4C44-A911-3472C46A2DB3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1cc7c4c7-9bc2-4412-a628-70e1c8c5602e"),
                LocationId = Guid.Parse("35430B56-66B0-427D-9387-6AB9CB65E0E7"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1d0143d1-55fa-409b-a001-80d6eb2d11ba"),
                LocationId = Guid.Parse("C280EC1C-0C0A-4F4C-9458-F767F3C6F4DC"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1d100bd6-432e-4801-8e2c-370cc2508293"),
                LocationId = Guid.Parse("2E79EC7F-4855-40E0-96E6-C2F479CFA901"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1d3e3730-8257-49d9-bd79-c08f265d19c1"),
                LocationId = Guid.Parse("984981F8-8F9E-4A99-9AE2-A189D436249D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1d523390-b666-4a36-b828-b69d39f52158"),
                LocationId = Guid.Parse("50AD7707-117E-4504-9570-AA879C9B2F34"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1ded3f93-2266-4607-ba5d-6e188bdddfdd"),
                LocationId = Guid.Parse("0E1F234B-842C-4495-9FE6-35FD7C0A55FD"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1e0e9049-28fe-44e7-b62c-8af894a12f0c"),
                LocationId = Guid.Parse("4646E3A1-B60C-4F60-B024-C0DB056D6DFF"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1e40482f-8239-48d6-b998-9d5c1b572a13"),
                LocationId = Guid.Parse("FD18F0DC-EE3D-48C9-AD3D-786FEAA09AD0"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1e7650c7-8392-4884-afb2-b0b9982eb5a7"),
                LocationId = Guid.Parse("8158465E-2CB9-4546-A272-9E9E2FB5C33A"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1e90dedb-6230-4b73-bcf9-2fb378e0e326"),
                LocationId = Guid.Parse("4A1593C1-E0E6-46F0-BC41-05A018BA44CA"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1e979ed1-e2ed-424a-80c6-d5f752ab9edb"),
                LocationId = Guid.Parse("321CB066-D735-4893-B47B-5E55A1B6BD52"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1f9298c2-b63c-4754-9525-1e6cdc96ecc5"),
                LocationId = Guid.Parse("7EFBE599-DB08-4E7C-9178-BB45FD3774E6"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1fa92f6f-ee8e-4702-9c7a-528f24c6981e"),
                LocationId = Guid.Parse("DBD6804E-37A0-4935-8617-F7E45A0AD0C8"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1fbf2e70-65fe-4537-9c45-b35bef52bf4e"),
                LocationId = Guid.Parse("C49B90AE-5C4D-4533-B629-0779D663E49D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1fcb2508-d2c1-423e-b413-19d4ed38581c"),
                LocationId = Guid.Parse("DFD0D59D-C650-4D30-9DCE-D18AFEDDBEFE"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("1feff9d0-1e28-4908-ba0b-3536aaa31986"),
                LocationId = Guid.Parse("8C719712-91C4-4A4C-8140-125DCA14430C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("20091d6b-6fbb-4a7e-95e8-0c08379b8874"),
                LocationId = Guid.Parse("70A3B1AD-0380-4D2D-BAD7-5555B3FDFC25"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2011eef4-b015-492c-9b3d-129e14dbfa90"),
                LocationId = Guid.Parse("2F827F70-8E9C-4720-ADFD-F29A7D25A3E4"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("205f67bf-593f-4bc2-a152-f75024a35b2d"),
                LocationId = Guid.Parse("C8806F5A-DF3C-42D7-AF01-B27F76CFF65C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("20840ed2-df9d-4774-915c-3171d3112fa8"),
                LocationId = Guid.Parse("FEAFF5D8-3891-4ED1-A75B-483BEDEC7505"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2084c38e-ae3b-491f-90d0-c80e3972073b"),
                LocationId = Guid.Parse("B91E2CC4-46FA-4C2F-A004-BC97E6421D84"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2092ebe8-62f0-4f38-a103-ace2608eef3c"),
                LocationId = Guid.Parse("6C40644B-AED2-4A22-9D03-7912B65CED3F"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("209fd00e-5af6-4579-8c32-101cf7ad8816"),
                LocationId = Guid.Parse("16E55DE8-AF21-4E29-8752-DC036D12331F"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("20c6ae1b-f41e-447d-9dd7-af07e990a9c2"),
                LocationId = Guid.Parse("3AC946AD-B42A-48FA-A2CC-1CBA951D5A01"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("20d38eda-9f7d-4675-b581-715e9e97770c"),
                LocationId = Guid.Parse("F348A56B-20C3-4C77-824A-226C2E223034"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("211bf930-6e20-4bb9-af8f-8fdccd23f11f"),
                LocationId = Guid.Parse("B642FA39-01CD-4918-977B-7E417FA82F3F"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("211fa4ce-99c4-4011-b528-012e67b7f610"),
                LocationId = Guid.Parse("F83B9011-383F-4922-A773-E3F8F6C2ABBC"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("21f7148c-8e3c-4f31-8167-75e3a2bdfbbb"),
                LocationId = Guid.Parse("D93BADC3-C255-4932-AC8F-17410EC92C41"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("220eba14-4d40-4a8a-b623-95c287fe68ac"),
                LocationId = Guid.Parse("233E4ECA-8BAE-4FE7-B1F0-5678E862F364"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("223852d4-beec-4285-95bf-9a90b0737802"),
                LocationId = Guid.Parse("62CA6FC7-87E1-43F4-B173-0972C7859A33"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("224dfbae-ed83-4132-b8c4-24519003f917"),
                LocationId = Guid.Parse("983657AF-8ED8-440C-84D9-C3FD236243F1"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2262a835-3222-46a2-9cfe-73b251d172f9"),
                LocationId = Guid.Parse("676373A8-6CB8-4CB5-B3C8-430845FB5644"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2273c385-7c72-40ae-a606-21a1d34c1710"),
                LocationId = Guid.Parse("4CDBB4BC-3CE7-46EC-BEDA-223876D22DAD"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("22bb9a07-aaf1-40f4-a338-b0d0cdf47112"),
                LocationId = Guid.Parse("35614D9A-B356-4B8A-8390-3B519249DAF9"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("231ed477-0f0d-422c-a3ba-5880bffd217e"),
                LocationId = Guid.Parse("01690442-3312-4AF3-B6B7-485F6246E5E6"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2364c44e-2141-4e3e-b386-1f98d8e55a7c"),
                LocationId = Guid.Parse("0E835AB7-2E8D-42DD-8CF3-1DDBEA7F0477"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("239c8cd2-1869-444e-8ee6-a2352f3577f6"),
                LocationId = Guid.Parse("4C3AC6FE-2E7F-4A7C-ABF7-129E491F6390"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("23aa2bdc-dc27-45e7-8b8b-2d58d87d1283"),
                LocationId = Guid.Parse("308D895D-45CC-487B-948F-8DBC88F3641D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("23dbc3a6-1501-4c57-9f45-f7ba3062d56a"),
                LocationId = Guid.Parse("2A8C91B9-2A44-4A60-BC68-019F3039348A"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("23e0b31e-b091-47a0-892c-2cb2268b7ab4"),
                LocationId = Guid.Parse("8C424ADC-2B63-440D-93CC-4BEF07D536A4"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("240a9c10-71a7-463f-a2c5-7845314a396a"),
                LocationId = Guid.Parse("A8E4AB3D-AFB8-46B5-9ECD-D29D3BE0ECFC"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2427fe7d-ab88-42fc-a095-4ae7ab525a61"),
                LocationId = Guid.Parse("E1310210-3B3C-4D86-99D0-532D0D6F5C79"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("24980bc1-693d-47b6-8830-fe04d1bebd73"),
                LocationId = Guid.Parse("916C6B67-2790-4A3C-872F-39E80FC3E195"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("24cba345-6fad-4fd3-965f-634def5769b6"),
                LocationId = Guid.Parse("7B19D914-05BB-4008-8C99-10C0231FC4D1"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2575f768-900c-47b8-8ce5-01dd494a1e24"),
                LocationId = Guid.Parse("BE676A80-EAB3-4921-9C07-B2EF4F047030"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("25811151-171f-4fd5-bf3b-df32fe4da145"),
                LocationId = Guid.Parse("27D5D1E8-581B-4BFE-BDCD-62AE32EAA500"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("25bd43e2-aab2-4b50-a8bd-45fb187ce98b"),
                LocationId = Guid.Parse("9277B4B2-7C31-436C-98A9-D9A1930FBCCE"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("25f58423-8f8f-4e27-a54a-10b24aa28cf0"),
                LocationId = Guid.Parse("E0E00F38-62F4-4420-91D3-1C2F80349AEF"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("261abc12-2519-4280-a3f1-cda59a30cc2e"),
                LocationId = Guid.Parse("D51A42D6-85F2-46F4-88C8-88866F508668"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("262963dc-72b7-4621-9ec6-81494902853d"),
                LocationId = Guid.Parse("D85CA8C5-5013-4A41-BCF5-B8518B47E123"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("26843313-2d05-4b58-a69c-8f4117318c68"),
                LocationId = Guid.Parse("5CF9203A-AE22-4073-960F-60E346CCF30C"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("271c3396-ea86-486a-9750-cb90b1175e6d"),
                LocationId = Guid.Parse("2547A01B-519B-4A5C-9DFA-4530479A749D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("271d4cc1-3ece-40cd-b867-f25ab529231e"),
                LocationId = Guid.Parse("EF2FCD19-2612-4ACF-8114-340349519480"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2793163e-1cc7-4e0b-b10e-cc8edce73f94"),
                LocationId = Guid.Parse("5D4D060E-10B2-42FE-B23D-C5479ECED31A"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("27b30bc2-07c1-4b66-a14a-006af263bafa"),
                LocationId = Guid.Parse("BECBD0D1-DF3B-4F2D-9D69-A773005960B4"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("27ef0e2b-3f94-448f-9404-bb08fdeb6364"),
                LocationId = Guid.Parse("AA064122-D71A-418C-AA7E-F613D648BDC2"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("27fbe9b4-3812-4ded-bdc5-acde6427b2ca"),
                LocationId = Guid.Parse("B62ED50F-894F-449D-89BD-18457492FAB5"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2808ae8f-fda7-4223-9b68-c54c1e1205b2"),
                LocationId = Guid.Parse("EDEAEB06-9BC7-47F5-A25F-54E43A0EB697"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("28506ff9-d6f2-4311-bb42-6019edd60fcc"),
                LocationId = Guid.Parse("F9F31F13-49B5-437D-97B4-8AEA709A9E12"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2880d392-88c2-40a5-89ac-52063a351f34"),
                LocationId = Guid.Parse("709E8DFB-74DF-48B8-BD08-70259CBAB9C9"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2884018c-4481-4787-ac11-0d239983b975"),
                LocationId = Guid.Parse("0369C9E7-9052-4334-A330-651904E3D5F6"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("28991ef4-15bf-4c64-9890-d98903b1f860"),
                LocationId = Guid.Parse("62C5F384-C3E7-4643-B76A-56DD54441201"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2903c70f-c28a-4377-890b-3abfc523f254"),
                LocationId = Guid.Parse("534B4B6F-AF38-457A-91A5-84E291468028"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2905f193-fd3a-47e4-ab81-35761e6dcfd4"),
                LocationId = Guid.Parse("1215F106-DA1B-4EA9-8286-D6086F614DB0"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("294f0f03-bd84-41a0-bbd2-bd369964f4c4"),
                LocationId = Guid.Parse("999302D9-7AE0-4DE0-9B2C-15DCD91F75C0"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("297d1c78-7a0d-4956-b86e-ff688c690774"),
                LocationId = Guid.Parse("4D3F024B-0E54-4F20-B9CB-0ED98824BE71"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2989e232-d29b-4623-9517-98f321f8f609"),
                LocationId = Guid.Parse("6808CB5D-6061-4375-AB1C-E2D53385B202"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("29fc8a49-9e37-46a4-8b98-858293000ca8"),
                LocationId = Guid.Parse("C982DF50-236D-4BD9-B7BF-464939701BDE"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2a1299be-ed63-4926-adb2-07ef4a55de2e"),
                LocationId = Guid.Parse("085ED696-23CE-4DDD-90FA-75838C06DB10"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2a47a913-abff-4cf4-9381-eee18f0b59b7"),
                LocationId = Guid.Parse("B6295887-87B1-4B86-855B-95DD4A7189F2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2a6fd4a9-85c2-4364-a647-10dfbfc49bed"),
                LocationId = Guid.Parse("85E4BD86-37DE-4CF4-920C-D0EAE274FD60"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2a94e9fd-9941-4bf7-a24c-2b94a3ac4752"),
                LocationId = Guid.Parse("67461BD6-BF93-4AFF-A33B-26F67AC1397A"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2acf26e7-b686-49e0-97a2-6d85739c2e97"),
                LocationId = Guid.Parse("1C5A573C-C9FE-4970-8F9F-51C3C9A3E67B"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2b0de1ce-bae8-44cb-8e7f-9473cfc0d242"),
                LocationId = Guid.Parse("1A1F8709-DC8F-4816-8129-7B5BF4E109E2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2b4094b5-1955-4f19-aa62-568e6ac44157"),
                LocationId = Guid.Parse("8811E420-489A-4BCD-B16F-98629EB9EAB3"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2b78e310-f23e-4dc0-8c9c-a541624c3d5b"),
                LocationId = Guid.Parse("6631F94F-A42A-4C38-A7C9-11670FFDF351"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2b99d0dc-b344-4eea-ac2c-7953e9864cc9"),
                LocationId = Guid.Parse("F4402EC8-5BBA-46C2-9280-5F3CA001DD36"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2bf03d07-64ae-4c7a-8117-356ae1728b5c"),
                LocationId = Guid.Parse("53428BEF-3F4B-4540-B509-9D4A340BBF71"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2bf7064c-9d32-4aae-a78a-93d4c166fe25"),
                LocationId = Guid.Parse("E6B22EFB-6C7B-4096-86FE-68FE70BD8C9F"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2c14479c-ae92-4499-bf14-af48de0894f5"),
                LocationId = Guid.Parse("5BE7309B-E9A7-4EC0-882C-3BD890642B10"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2c599bd2-ce61-4a31-a198-705bd51cd56e"),
                LocationId = Guid.Parse("A936855C-EA0E-45EE-9FE2-8EF772067BC1"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2d1902d2-1fbe-4153-9c2b-459f89561ff9"),
                LocationId = Guid.Parse("E8FE0A03-1D29-4A16-92C5-CC87526162EF"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2d6b2bcd-2536-4828-8f6b-c6ad76e3c279"),
                LocationId = Guid.Parse("E98A7580-2008-454C-9B59-F931C453EA17"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2d7c550d-3b2b-465b-9f95-5a7e02ef64a9"),
                LocationId = Guid.Parse("3E9C8BC6-C560-41E2-A0FA-65C733518CF2"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2dbe6697-774d-4715-b66d-38f3fd1ab780"),
                LocationId = Guid.Parse("3EE00D12-A451-4636-AAC9-08D4DD60CA49"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2dccdeff-6e9b-4d06-8ee7-dedf1c8b82e5"),
                LocationId = Guid.Parse("B79DD67A-45A7-4CAF-846A-6936834F2021"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2ef7d149-bda4-4572-83a3-39145bb79a59"),
                LocationId = Guid.Parse("DA36052E-DA7E-4581-8EE7-B9358F11A0B2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2f194720-3a6c-4e4b-921b-fe38f04f7564"),
                LocationId = Guid.Parse("9055D2C5-A6FD-4DDE-9E6A-6B4077F19B88"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2f3fa6ef-1699-4bee-872a-f3773ad23b2c"),
                LocationId = Guid.Parse("4DCBF2E7-C97D-4551-9C72-73096A726483"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2f401c16-c73a-4fc1-99c7-5a8cfb0b1e2e"),
                LocationId = Guid.Parse("55B51956-D4F2-48C9-BE4F-5C074937B3D3"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2f59ddf1-ddc8-4e4f-abea-7da72bc792a4"),
                LocationId = Guid.Parse("0F3BA9E6-19B2-4591-90C8-C47581A328B9"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2f640404-ae84-475f-90d2-381c7292dca3"),
                LocationId = Guid.Parse("E21E268A-E8AD-4877-A5B2-BDDA10EA599E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2f64981a-885d-4dc8-a3d7-9abeaadfced8"),
                LocationId = Guid.Parse("8E24BD56-B514-455F-875A-9C08B5FB9420"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("2fe59edd-7132-4e48-a1de-cd4b1587c0f5"),
                LocationId = Guid.Parse("EC838EBF-700B-4341-84EA-D9326D18106C"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3055427e-ad6c-4930-a29c-3fb3c3e1f76b"),
                LocationId = Guid.Parse("551974BB-0B32-48EF-BE1A-B92348B9C987"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3059ea49-887d-4b39-9713-66141e7167bc"),
                LocationId = Guid.Parse("DC3238AD-E330-44EA-B9A4-DCABAA4050D3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3086944d-b355-46e0-8c32-2985dde7a870"),
                LocationId = Guid.Parse("E37AE645-A1A4-417E-BCA3-F5327BBBB36A"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("30f56001-c668-44ca-90fd-06a9c9301ac5"),
                LocationId = Guid.Parse("D7F7D7EE-9E7C-4657-ACDC-F5CF97A398BF"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("31df87da-17db-4bc1-bb64-853fd24ae983"),
                LocationId = Guid.Parse("1ACE08C2-6EAD-40D1-B18F-46880EB0F652"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("328dce68-660a-4243-98c6-764f1bebe412"),
                LocationId = Guid.Parse("49DCB7F5-E6C4-45E7-95F9-9BFAC03C6131"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("32952a89-d087-44e5-bfa7-176731fdf622"),
                LocationId = Guid.Parse("6ED0C6B2-531A-4122-8137-83D3CE401426"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("32cc5adf-3762-42ef-a6d2-17e5334eff30"),
                LocationId = Guid.Parse("F690F20F-2BB3-4B09-AA0D-97342E08B0C8"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3301d257-4fe5-4182-8cf1-4d32014ebb41"),
                LocationId = Guid.Parse("FABA8C46-3F25-4CB4-A307-B60F2419C4B8"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("331b3ae2-c255-4fbc-ae51-158cac0dca9f"),
                LocationId = Guid.Parse("5B7664D8-0B62-490D-A666-CB373490B7DA"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("338e95e5-fd1a-4042-a0e6-e5ef816831ab"),
                LocationId = Guid.Parse("3E2094B5-D31B-4BAF-9E0D-0B91C54F7000"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("342a2d49-d975-4458-9866-e30811e07825"),
                LocationId = Guid.Parse("EA6BA8F9-5424-4EB7-865E-6B6A054283FD"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("346bf9bc-e864-416d-aec1-3bf59dba8d10"),
                LocationId = Guid.Parse("83EAEE5F-FECC-4639-9EB8-C3512A2A6D1E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("350d4bae-0b7a-4db4-9f7f-301845ff2a03"),
                LocationId = Guid.Parse("175DFDAF-0C13-4D0E-A800-2B564681E885"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("35570dcd-e18d-4d34-8383-9e7144ac0303"),
                LocationId = Guid.Parse("0CCF039F-855D-40BA-8CF3-6F8330AF1AB7"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("355d2e47-7c17-401d-9cf7-5bc51ef82605"),
                LocationId = Guid.Parse("12EA1B8A-380E-4018-8B19-D074584325C6"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3573c79f-ed6e-4948-b095-7891f4901e88"),
                LocationId = Guid.Parse("AFE679ED-4B44-478D-9B97-11692A81D384"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3578ef73-1ba4-4b6a-abbe-64e09ef1a2b8"),
                LocationId = Guid.Parse("89319188-673D-488F-B8FF-7D28A31F72F8"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("35abc50d-af12-44a4-8098-cee4ea735ced"),
                LocationId = Guid.Parse("8B7E2C49-6C4B-4C2C-B786-D480A4ED3BD2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("363c4775-0a1a-4a1b-8cae-0aa9ce8bba40"),
                LocationId = Guid.Parse("D765746A-8575-4659-A5C3-360294F5E021"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("36adf4a6-0cf2-42fb-92af-1758bc4078d2"),
                LocationId = Guid.Parse("57B9DE7F-6173-4EC1-87B3-540A3FB7FDA9"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("36c9cb9a-ee5e-4fb6-a8f6-b0fa9be14e0d"),
                LocationId = Guid.Parse("B9B76C44-D266-48F0-8BC7-DEF8404E6806"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("36de7747-9d05-4330-b9db-e2fac72c11fb"),
                LocationId = Guid.Parse("40AD9B0F-9097-417F-A124-8B0425D77EB0"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("378b6f84-8741-41e4-9e75-192913e8b1a0"),
                LocationId = Guid.Parse("5BF10913-E98D-4294-9436-45FFF9C5AEBA"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("37ad920a-7843-4dd2-914c-caf07004e0c9"),
                LocationId = Guid.Parse("A385AA13-3C1A-4068-86DF-882FA58C860A"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("38d8caab-a07d-4cb1-9cb2-49b32dd25052"),
                LocationId = Guid.Parse("3662DBBD-8D58-4A3F-ADDF-2227375082D4"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("38dac695-a064-49b2-bd81-1a7bd1118081"),
                LocationId = Guid.Parse("0A761667-A949-4207-86DC-EAE73E8FE291"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("39405440-efc1-4189-b66b-65de2d0f3d66"),
                LocationId = Guid.Parse("4A4BDC07-ED9F-4929-94B1-D10EAEB95536"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("395d84ea-db86-402d-98ec-05e5dc3d8c24"),
                LocationId = Guid.Parse("615C7C59-C878-46A3-B6B7-C5A8C0FE4DFE"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("39a31ba0-479c-4d32-88d7-fc86a43d57c1"),
                LocationId = Guid.Parse("F1592FE8-CEFB-4CA0-AE05-A20F17F97457"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3aa43166-7351-4106-998c-14a1a9a71c6d"),
                LocationId = Guid.Parse("ACDCEBBC-867A-44E3-895A-1E5F2ED18C4E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3ab3ac18-5675-4a40-87e1-58b3565c96fe"),
                LocationId = Guid.Parse("5B2DC006-940E-4C09-8309-51F020968A89"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3ac7cc04-89da-4c18-adec-691d5d248387"),
                LocationId = Guid.Parse("BB2F7D53-6749-488F-A3B5-40DE5F14D004"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3be88a64-7e17-4bf9-ae06-0df7fcefac36"),
                LocationId = Guid.Parse("6A3B7866-338C-4BDD-A930-E69C13384E36"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3c09c31d-dec9-45ed-a355-865b86d06c6d"),
                LocationId = Guid.Parse("FCCF700C-6F1E-404C-AC6D-2C97E19C1893"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3c18cb9a-88e9-4e36-8760-d64ca99ce9c5"),
                LocationId = Guid.Parse("5484A1BD-B0FC-4AD5-BBFE-ADFFF0B88EC8"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3c2c8ef8-f1c2-4574-b869-7273911aaf3d"),
                LocationId = Guid.Parse("7A378FB6-6362-47F8-AEEA-7809B258FC3B"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3c5ff1c0-1629-4ab6-aedc-30a80a270a85"),
                LocationId = Guid.Parse("2FFFD2FF-EE75-460D-B04C-7D63AFE3030F"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3c64acda-0ab8-4672-a48d-1dd819f0726e"),
                LocationId = Guid.Parse("0FB51854-59F5-4FBE-91B6-DC258B2F146A"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3c89d78a-ada9-4e51-8777-be2474b1d123"),
                LocationId = Guid.Parse("2B66E5E0-453C-42BB-BB7E-89255D6215A9"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3c8ea462-cf7f-41bd-aea6-7014363a7abb"),
                LocationId = Guid.Parse("73D47496-48C9-44A6-95C7-7C676A7D11E3"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3d74163d-ddef-4d97-a896-c1700899bb1b"),
                LocationId = Guid.Parse("67CB0669-FA40-4859-9572-293677577F9F"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3db33912-dc02-4afc-949c-52a1082e455f"),
                LocationId = Guid.Parse("E743905F-9FCA-4596-8D3C-418657D6E979"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3e56bd21-f8a9-437a-a240-a3042930f84a"),
                LocationId = Guid.Parse("A51E30BF-16D2-4B23-837B-DA0087AEAF50"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3ed07d13-561e-4eb1-b4be-5bc2a3a159a2"),
                LocationId = Guid.Parse("C115EAAC-F40F-47F6-85B9-66386A03C016"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3ef6584a-05dc-4a98-904a-bfa64c7dccfe"),
                LocationId = Guid.Parse("29F89297-359D-4EAB-9882-B7BB744EAFA8"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3f1569e4-25c7-420d-8d01-ed63f45eb950"),
                LocationId = Guid.Parse("7DB0738F-00D8-4113-A5FD-0A4565A1E9FF"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3f222b15-70f3-4b49-b190-5cddb184cef2"),
                LocationId = Guid.Parse("DCAB1110-6AB1-42A9-96BD-35152BC9F021"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3f464d70-619c-4fca-b0ac-9e71542d9150"),
                LocationId = Guid.Parse("97200555-3F33-4FB7-8802-3ED5D135B384"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("3f6a0611-56ae-4e5e-9dae-6292d7d46f5c"),
                LocationId = Guid.Parse("8903E7CE-9604-4BC4-8C3E-17FDCBD51328"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("40355fee-30e8-4388-897a-51cd2440ca4e"),
                LocationId = Guid.Parse("7CE72209-193E-4122-AF20-F79F9E33B911"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("40b40ede-20f1-4216-a07a-416f97a210bb"),
                LocationId = Guid.Parse("84AF8044-D1BF-4F26-A6AE-A1BBE7A7024E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("40bb66fe-bdc8-46a3-b710-a750b0d60ccf"),
                LocationId = Guid.Parse("179C5A49-4270-4D1E-A8F3-9D7AB05C8AD7"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("40c40585-e537-45c3-a9cf-a83773bcd4ec"),
                LocationId = Guid.Parse("1D6537ED-C4DC-4B98-AF1A-45B6C06FB35C"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("41a50130-b340-4289-9653-eda72b98ae6a"),
                LocationId = Guid.Parse("37F055CC-74EF-4AA6-B45B-68168DBB4FFD"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("41ad4385-0b9a-42f6-b6c1-5b47fadca978"),
                LocationId = Guid.Parse("0D9264A8-85B5-47CA-B3AA-E8FA318F2111"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("420c7329-9fc8-4711-aac3-f2f1336e2bbc"),
                LocationId = Guid.Parse("78D05AC9-89F5-4A31-896D-D1ACF1E92850"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("423914c8-f3b1-4ac9-82b6-65a1d29771ef"),
                LocationId = Guid.Parse("6ECD12E5-E5FB-4BF8-9E70-820885AF4C0F"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("426d4e56-0661-427c-a90c-0114f7c8ad38"),
                LocationId = Guid.Parse("DABDD3C4-DAEC-43EC-BB9E-B01C659FABB1"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("42b4f720-b480-4ee7-ab31-939d423d4b0a"),
                LocationId = Guid.Parse("969004C5-8A29-43A7-91F8-3F46C55413A3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("42bfa273-1648-473b-a340-c8c891271629"),
                LocationId = Guid.Parse("559A14E6-F482-44CB-BEB9-15F0D7B76897"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("42d8ce8b-fdc7-4e09-bdaf-b92622af20ec"),
                LocationId = Guid.Parse("284099B3-1EB8-4BCD-B74D-90EE1CD5F74C"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4316a63a-f340-4afa-b085-3a1207588b12"),
                LocationId = Guid.Parse("4AEB6EF0-C53A-4AAC-AF44-98F896BA2924"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("437a7ace-3192-4546-a2fb-4039379b8cdf"),
                LocationId = Guid.Parse("4A61D3D1-8F1A-475B-84E9-5FE22F13978D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("438ae981-be58-456a-a083-6a598b1e3c55"),
                LocationId = Guid.Parse("86D2B9E8-3743-428D-A44F-366D221227B3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("438b71c2-9c9d-40ed-9dd5-70ccb2402907"),
                LocationId = Guid.Parse("5754D664-96A2-489A-B8B9-EFFF7EC62AFE"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("43d11946-f673-4c63-8e2e-53981561ce4f"),
                LocationId = Guid.Parse("872FB59A-1A6C-479D-82BC-B523DE3055B6"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("440a74c4-2f4c-4d5f-8ebf-7aaae4d8b5a0"),
                LocationId = Guid.Parse("FEF27F67-590D-48C0-B131-0444768F8B2B"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("442e924f-9687-4192-9f64-6ab3398124d0"),
                LocationId = Guid.Parse("14670726-D69E-4D3B-9578-D49A45D8B1C8"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("44bcba7b-59a3-47d1-a135-a44dcb725da6"),
                LocationId = Guid.Parse("8966D478-61D2-48DB-9ADB-64503348DD41"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("45224e46-ed7c-4a4f-b964-61967595b0dc"),
                LocationId = Guid.Parse("9A509E73-8004-4A5B-9EE9-6B41287DF8A5"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("45934fba-d502-47ff-99d9-022abac768df"),
                LocationId = Guid.Parse("2FE77080-87F0-4588-A99B-5F0F58132F84"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("45b01b8b-c4c0-4340-8343-13b0992682bb"),
                LocationId = Guid.Parse("502CC069-FB1F-4AA7-ADAF-BE2A71888215"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("46596e20-d809-49fe-a57f-e74fc35bafd1"),
                LocationId = Guid.Parse("EF47E89F-3BFD-471A-B907-4E5534D95940"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("46600f3c-3459-4f32-bcdb-3432d4d7c46e"),
                LocationId = Guid.Parse("3B832429-F3B7-43D2-9B63-690282250036"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4695b452-2670-4a05-8a5d-ef63fd282aee"),
                LocationId = Guid.Parse("F9065451-6C74-4B3A-BD43-A723FE444D6E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("46da9bdb-e555-4c6c-8c66-3204dc48edf8"),
                LocationId = Guid.Parse("9364B7D7-5BBF-40F5-B4D6-FD5A3C7B42D6"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4962a06e-4533-44ec-9bfd-0afc28100af6"),
                LocationId = Guid.Parse("43EB91BE-9859-402E-85E3-FA98142D105D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("49652f7d-a115-4f3f-b1be-d2fe0f97d60d"),
                LocationId = Guid.Parse("DA334E5C-E10D-42A2-8BA9-A3D407A39AD0"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4991a1c3-bcc7-4353-9a45-455e1b1155ee"),
                LocationId = Guid.Parse("FE3AB564-4334-418F-9A95-703DC013493D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4a4ef0dc-1f91-4dd0-9ec7-fc2f70621c5b"),
                LocationId = Guid.Parse("7B9229C5-88A1-496E-992F-BA887AFE0BF8"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4aa20bb7-2dcc-458f-9bb9-998d11778393"),
                LocationId = Guid.Parse("6B63A85B-6EC6-4CBA-A044-E3C0540467DE"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4b7cca3e-932a-4bf3-9232-d5661565e506"),
                LocationId = Guid.Parse("2261E48B-97DA-44AC-A7A5-CA1BDAD42E60"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4c02cb09-e96f-4596-915f-a1b27bf49d0f"),
                LocationId = Guid.Parse("4F2A0D23-58C0-4F14-9F0C-BAB18B46A9A5"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4c5c30d6-ffa0-49ed-85db-03929f32358e"),
                LocationId = Guid.Parse("57E6329C-08B0-4CAE-A5E1-0AE8FBABD3D0"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4cde3130-4ee4-4af5-b08e-107cce0ba749"),
                LocationId = Guid.Parse("AB88E1E7-B259-487B-82C4-5F7A81224170"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4d1ae811-1dd6-481c-b5fd-d9528a197e7f"),
                LocationId = Guid.Parse("1675D1E8-D06D-45DA-B27D-FE99D5D3C2FB"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4d85b970-e9dc-453b-80cd-103f3b457666"),
                LocationId = Guid.Parse("CBF8C644-6857-41D2-9590-6483F87E581D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4dbcfc11-01cc-48fe-87be-d6aae4aa9b0f"),
                LocationId = Guid.Parse("5D72BE2A-32CA-4220-8010-CC664DD02350"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4dc8f6c1-6e2b-4a28-a0ba-4fc5d2f73eaf"),
                LocationId = Guid.Parse("A83B8E11-3325-4E37-A2F4-E6F55475035D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4dd6ab4a-f2cf-4130-9c57-76fd422dc734"),
                LocationId = Guid.Parse("11400A33-855A-4E5E-9D98-A3A95FCABF3F"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4e657608-f992-4409-b0ff-9b55fba30ecc"),
                LocationId = Guid.Parse("FD6765A5-526E-4D7E-AB92-13273D341C88"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4ee23a39-e01f-41dd-b1d8-e0025ea54793"),
                LocationId = Guid.Parse("8C12BEAF-051C-4E1E-B60A-0B90E2A9936E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4ee74142-9e36-4bb5-8194-673946ef6a41"),
                LocationId = Guid.Parse("33FD64A7-D37F-4538-8F48-03923089C108"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4ef4f909-85cf-4020-af9b-7f98ceb6a664"),
                LocationId = Guid.Parse("C3F39EB5-A8D4-45A6-8FC4-F37C1EA42E7C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("4f7b9469-0dfa-4a2a-9721-35a37e17f31b"),
                LocationId = Guid.Parse("671709C0-EA23-4FA5-971A-96C3738FACD6"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5006572f-383e-467e-ba5a-212c9a43a10b"),
                LocationId = Guid.Parse("F792599E-D8E5-4AE9-AFC4-431C62B6B5DB"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("50121726-281a-419c-9bf0-734d1c0ef96f"),
                LocationId = Guid.Parse("6F8CCA66-8966-41DD-B29D-FF42E35541B3"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("50416dfc-22f3-46a1-8845-d0540e78c2f1"),
                LocationId = Guid.Parse("759578D9-2EF3-4B41-BDA6-91766B4D74F1"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("50b03aaa-dac4-4ebd-ac05-d46470269e81"),
                LocationId = Guid.Parse("F451F47B-39A0-4434-AA35-EC403F274139"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("51237ce9-7478-4d9c-8f4a-dd9d0156b072"),
                LocationId = Guid.Parse("146F1C82-6B22-410E-8D46-A36F797B2F56"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("51696f9b-9417-4691-a65a-cb12c7a47b7e"),
                LocationId = Guid.Parse("A49C401A-C36D-4818-8270-899E33CF331E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("51f376f3-57e5-41be-b24a-5dc225595cfe"),
                LocationId = Guid.Parse("165FE15E-C955-4BD8-9321-1DC148C8896C"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5224cf8e-37c2-461c-9500-24e8994c8566"),
                LocationId = Guid.Parse("CF00F37D-8D90-479D-BD3A-A147479609C4"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5259cbe8-9362-4bb6-a85f-79b47719e2dc"),
                LocationId = Guid.Parse("DCA3AEE0-2A18-42ED-BF73-18377F44C7A7"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5277e73e-24a1-4aea-a17f-130eb8d25657"),
                LocationId = Guid.Parse("9782C259-4B29-444E-9190-FAE035B08ACE"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("531575ae-2107-4f1c-88fd-65dc335fcca1"),
                LocationId = Guid.Parse("922118B8-49C6-4EC8-BE3C-1FA7B7B03B57"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5316908e-fc84-406a-b905-41c884979d8d"),
                LocationId = Guid.Parse("08F12C54-4BAD-4367-8137-5695865313AB"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("531fd26e-3128-4227-a45a-a826220da9ba"),
                LocationId = Guid.Parse("9CFDAF7F-F1E9-43C4-9F29-1DF22B2F6661"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("533a1bcf-5a78-4b9f-8046-efc0c67991fd"),
                LocationId = Guid.Parse("CDBD1C39-E3D9-4913-B39B-E6D319859EB6"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("533e65d2-968a-4928-b795-e063bdb69598"),
                LocationId = Guid.Parse("72A0EA89-815F-49F5-8ABA-D1EB519D042B"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("53a687cc-b80b-4fbc-b54a-a20317f40e3a"),
                LocationId = Guid.Parse("5C304231-5894-432A-BF7C-C3219F68B2A7"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5406f901-8a0d-4359-8948-b63ea4d16f07"),
                LocationId = Guid.Parse("F486EBEA-3200-4979-BED0-426976786C7A"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("54220066-e8e9-4f78-b8ee-fa029b20f399"),
                LocationId = Guid.Parse("EAFAA6E9-FB9C-4896-8932-27E89141579A"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("54aa258e-b8b9-4ddf-acf4-523707bb7a91"),
                LocationId = Guid.Parse("A3150263-7237-4CB3-AADD-20F456B47B47"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5505e61c-419a-4525-b036-18f27968f8eb"),
                LocationId = Guid.Parse("AAE67FFB-E930-42E3-A9CE-626883C58183"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5515a71c-6891-45da-b351-3218aaabd1fc"),
                LocationId = Guid.Parse("1A9DAD23-9299-4671-931E-CB08C1E49E10"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5541c40e-2284-43b5-806d-538cbe7e6ed3"),
                LocationId = Guid.Parse("8A39A45D-F29E-41C6-B570-7419FB271D41"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("554e261d-d041-4efa-9234-eda5df315317"),
                LocationId = Guid.Parse("AC8085DD-73AF-4D1B-B404-D2E6824309C5"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("55813fd1-96e5-4389-8eca-2107298a6ce1"),
                LocationId = Guid.Parse("9C5112CF-79C4-4123-AC06-3E85CFE6E863"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("563e558a-5c21-4f24-b073-6ffa1d316eec"),
                LocationId = Guid.Parse("53700A31-EA7E-48AE-A7AA-9BA0EC329998"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("56410492-371f-4bcf-8be7-00423dd8b055"),
                LocationId = Guid.Parse("96BBB7CB-6C4F-45C1-B1FF-9D192E6DDE39"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("56469ce1-9cb4-411e-92c2-def706f40eee"),
                LocationId = Guid.Parse("61E44A08-1DC7-4841-B51B-0A9CDC7792AF"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("56c5f052-8894-455d-9008-4694077e7066"),
                LocationId = Guid.Parse("B937F620-1653-45C3-9026-0D61CFC3D518"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("56d67224-6e8e-4d28-8428-ebb7758de390"),
                LocationId = Guid.Parse("90D8B493-16B1-4567-96D3-110E68107BA3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("571c2dc8-9e89-465d-af20-2f83d53792d0"),
                LocationId = Guid.Parse("45BF7E06-3B66-4383-9FAA-B709E9FF7B47"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("573ff032-0ad9-4d21-800a-6e9c5a968eba"),
                LocationId = Guid.Parse("F9E16321-B26B-48BE-A354-8101385BEC33"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5768209d-7dfe-4763-8fb5-23c8d10a97ea"),
                LocationId = Guid.Parse("94383D92-84A8-47C0-B680-F069C580C99E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5858b650-0d68-4da1-a37d-3deba2777996"),
                LocationId = Guid.Parse("C2CAF7FC-28B6-4CE3-A98F-D400370A2133"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("58701e3b-4a99-48e6-96b1-48e8124bbafa"),
                LocationId = Guid.Parse("DFCA1992-6F93-498C-8389-F05FDFB4C584"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("588da476-ec9a-441b-a86d-fa742eab4fea"),
                LocationId = Guid.Parse("914E1211-FCEA-44E9-882F-DFDF1801BF66"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5892d4ba-b5c4-40de-a12e-4162555f15c0"),
                LocationId = Guid.Parse("5F5AE2A7-CE17-43F6-9630-455946BDC395"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5907dc04-9622-433e-8460-da02e34340d6"),
                LocationId = Guid.Parse("56ACD4F4-B248-441D-92BF-794F01EAE077"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("590dff7f-a804-4bfb-86f1-e68dbed7285c"),
                LocationId = Guid.Parse("C4B4AAC9-37D7-4949-BB39-22FAA7CA5065"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("593a2477-f1a2-4583-bc5d-2257adfcd9e6"),
                LocationId = Guid.Parse("66E368E4-4446-42EA-9076-42A448EE36A0"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("593dcd02-cff0-42c9-8a39-71c841026b39"),
                LocationId = Guid.Parse("701FAB68-183E-4E0A-A7E8-E3A4507FBA8D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5989c7ae-a958-4531-a2b6-1e0cfe1248c1"),
                LocationId = Guid.Parse("C6D66688-2E8E-4A32-927F-A3F245B72DEE"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("59a74100-94df-4f75-9838-d35689383343"),
                LocationId = Guid.Parse("0817CC45-4BA6-4AB9-B6EB-E9E33A58F100"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("59bface9-ba6e-4931-99db-b0da4c5f9dde"),
                LocationId = Guid.Parse("1D285A1E-59EC-45C5-A516-8322B07816BF"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5a2b6048-2526-4fbe-8a8a-beb08a7575af"),
                LocationId = Guid.Parse("870BF8CA-BBDA-4B0E-BACD-0FD06BA69FF4"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5a37e5ef-cbdc-4045-905e-1fe2ecae4c9d"),
                LocationId = Guid.Parse("C904F2C8-D611-4817-BF0B-FCC335168173"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5ad16b81-2926-4c65-887e-e66d14ab512f"),
                LocationId = Guid.Parse("1AE75553-2888-47CD-BE49-EF057493E648"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5b00d533-5911-44a0-a67e-54e7308652d8"),
                LocationId = Guid.Parse("541FF304-1887-4386-85F4-AE64979F79A7"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5b479a99-b31c-416c-9f2f-59ace8df3158"),
                LocationId = Guid.Parse("B582A521-4703-4B17-A0A3-97AD2E416967"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5b8b1e57-0f8e-445b-b40f-7bd2f22d3b32"),
                LocationId = Guid.Parse("E2AEED7D-15AA-4244-A530-9483C62CD69D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5cbbbb5f-68d0-4893-8489-583753c15d27"),
                LocationId = Guid.Parse("87CA442B-5182-48E1-8B33-996D4C86D808"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5ce30fab-73c5-4606-9d85-a35eff92ce82"),
                LocationId = Guid.Parse("869C5980-6526-46A2-B04C-EC18D76BE5E1"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5d23ff0b-5df3-4cc2-8fb2-8c0534f7fc80"),
                LocationId = Guid.Parse("58C8AA4D-A85F-40DC-9C22-33E520385D4D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5d76f3f1-9de4-46e0-9f86-b526342b22bf"),
                LocationId = Guid.Parse("BD79357F-1F2B-4073-A2D3-27D3E14FD3CA"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5e14815a-7058-473f-8951-283f4b80de4b"),
                LocationId = Guid.Parse("81E4223E-C9EA-4F11-9E50-6BC28549BC69"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5e72ebf6-be0e-4245-a17e-a8003c448545"),
                LocationId = Guid.Parse("E340AC92-5CAB-4B77-A9C9-8CE5071043BB"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5ee48efc-3095-4521-8aec-b9fd8ca6b8e0"),
                LocationId = Guid.Parse("7ED7935C-E0B3-456B-A20E-5D4F22345F13"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5f0e6400-cf21-45a0-89f6-a1086ecb1fe7"),
                LocationId = Guid.Parse("2AD20429-6726-4B08-ACCC-48CA689D03D9"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("5ff1710b-aee6-4973-8969-b02c5f2d0303"),
                LocationId = Guid.Parse("65BA67E2-BB04-4D42-8F7F-72E891AD84CD"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("60291c49-0170-4211-b7d5-750a5c92d3e9"),
                LocationId = Guid.Parse("333A5A72-DD9B-40B9-A584-9880AB5FF3C3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("60414187-77aa-4869-b381-521411443562"),
                LocationId = Guid.Parse("5C8B2BCC-BFE7-45FB-A7FC-4F90248CD208"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6046cdcf-433e-4979-b2ef-10cdc697c4d9"),
                LocationId = Guid.Parse("D6B8F2F1-7E1E-4C53-B4E6-AF192E683559"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("60485367-dc1f-445e-a21d-88a7f193ea33"),
                LocationId = Guid.Parse("64886229-FF05-4E1A-9D51-2BF8C1A6ECCC"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("612836f8-5f0c-4eee-aaa8-7f78e3dfcd85"),
                LocationId = Guid.Parse("77DE7C4F-A1CA-4CE0-9EED-2259DA541A48"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6150ac82-efe4-4bb3-907c-917e3a61f600"),
                LocationId = Guid.Parse("28B4D0E3-48E5-47B0-8003-1FC780F1959E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("61f8271c-541b-4d0c-bbd0-c04ff53363d1"),
                LocationId = Guid.Parse("83C950A3-EA62-41F1-9EB9-FF90F92DD15C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("61fb46c2-4490-48c1-96c0-e9b4136f7f40"),
                LocationId = Guid.Parse("82D92CA8-B01F-4FC5-9EBC-EFB33B1091C7"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("62332b2d-2dec-408b-96a2-60971fc4db6a"),
                LocationId = Guid.Parse("A50E87B3-CF3E-487F-92FB-39B190F852F6"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("625d178c-0623-495f-b1de-0d4a93a92541"),
                LocationId = Guid.Parse("61F9767E-5C79-40D8-9025-021C08C7ACE1"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("625dbdfc-4dc7-4217-9f20-6863b37eb9bb"),
                LocationId = Guid.Parse("869F437D-49F8-4AEC-94F2-21267F7BFAF9"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("62727a0e-719a-481b-b04b-98f5dd312f6f"),
                LocationId = Guid.Parse("EE559CFC-1631-4091-B18F-AB1B4FDCAEA9"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("627f1c04-4422-4193-8c4c-200eff647633"),
                LocationId = Guid.Parse("DD9A48A7-88E0-4442-A7F0-3A72901C7708"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("628c6fc8-4c86-471f-98cc-7f39b0c0a0a8"),
                LocationId = Guid.Parse("9E6990B3-3FD7-4207-91D4-3C20483E4089"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("62a1c0d0-0d07-485c-bb0d-7da806859b4f"),
                LocationId = Guid.Parse("EC67ECAB-7573-40AA-AC8F-17F23D2BE1D4"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6310cb69-6482-4537-96d1-88cb8f47cd59"),
                LocationId = Guid.Parse("37A0D29B-83F4-4C7F-8328-627A25503592"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6374a6f9-34b9-4ba8-b2dd-af18f9c6a97f"),
                LocationId = Guid.Parse("9D658B91-D666-40AC-A9D5-FCE51278D2D0"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6382db27-c8b0-404c-bbee-c3bfae9a9120"),
                LocationId = Guid.Parse("2B064761-C9A5-4427-B5B1-289FAE287D61"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("63886e4d-0440-47a6-b2c6-9ffa5e9c3c13"),
                LocationId = Guid.Parse("6C189587-F758-4828-AE14-2282A5D987E1"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("63dad7e2-775c-4b4b-8e89-073808426dda"),
                LocationId = Guid.Parse("433AD73B-0853-48AE-ABBB-6994FE37C804"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("63f51351-567e-4b5c-8d60-c7562e274631"),
                LocationId = Guid.Parse("2454423B-16FC-48AC-B3FE-335947D7EC2F"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6425cee0-cecc-4dad-9e80-8240c2abc9c9"),
                LocationId = Guid.Parse("165891F0-24D4-45D4-93AA-6B4ABCD02EAF"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("64420ef9-b1fa-402f-89fb-51c41cc70449"),
                LocationId = Guid.Parse("6D7C4D5A-B403-4C6A-BF4C-A5FA63B7E5D1"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("644f19fe-82fa-4eb9-98d4-50d1aac14c9b"),
                LocationId = Guid.Parse("7CA1A88F-DCD1-4F4A-A4E1-721664F8AE47"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("64d950fa-1beb-4bc9-a47b-c1a25148ef14"),
                LocationId = Guid.Parse("DB59859D-50F4-4431-BCD1-24B8EE65D2CE"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("64dfea58-880e-43bd-a5de-56999f45c4e5"),
                LocationId = Guid.Parse("D0B49AFB-211E-47DA-A05E-08EE3F92B44E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("65d197b6-02d1-4c79-a833-6566f9a4dac5"),
                LocationId = Guid.Parse("967CEE9A-20E3-40A2-8763-2E3A29501DEF"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("65e61a10-a356-478e-9034-b04ac3229f85"),
                LocationId = Guid.Parse("5053318E-6D3C-4D2B-9B13-009A42700B96"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("65fad16b-cb42-456f-8660-300cf3e1934d"),
                LocationId = Guid.Parse("B97CCAA6-79C6-4AD1-BA77-34A4BECA3156"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("666c6765-ce61-4a70-b338-1788f3dae52f"),
                LocationId = Guid.Parse("30E57503-8E1B-466A-B037-FE93EEE0C7BC"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("666f3649-fe79-4e48-8d8b-36e35e52baa7"),
                LocationId = Guid.Parse("77C6EEC4-E81E-4858-9AE7-AD21FFDDFDD0"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("66844018-4d78-4bf8-9de8-d0110fb1b5eb"),
                LocationId = Guid.Parse("A2F02DB1-74AE-4D80-B923-24446A6A015C"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("66fb4938-09dd-4af8-b0e5-36b27b25e122"),
                LocationId = Guid.Parse("8BCE4C38-B993-4064-8B8C-B925F6F3BFAC"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("670952cb-dd48-407a-9a45-f24c092d31c6"),
                LocationId = Guid.Parse("24D82ED3-A5AE-42E1-B4DE-20DED4E60D88"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("67a22637-0087-41b4-9f5e-8b15cb183f40"),
                LocationId = Guid.Parse("A6905CD2-D662-43B4-96FF-D9EE6EDFB6EB"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("67ac4d84-8e3d-4bb6-af73-6ae5aa1f89e9"),
                LocationId = Guid.Parse("08153064-0DCB-4F33-8559-9A16FFC35444"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("67e1ebe6-3369-4f87-b510-16c0da289355"),
                LocationId = Guid.Parse("29A0064E-D901-48B0-BB6C-74F87AF1519A"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("68312ff5-2c8a-46d9-925c-1fef40b0a829"),
                LocationId = Guid.Parse("6F8A3520-FEFD-44EE-BA55-00755BDBC80A"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6891b51a-a54f-495c-882c-085df120d371"),
                LocationId = Guid.Parse("7DF94896-CD28-4DE5-B713-CA2BE25AB179"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6897189c-688e-4357-aa48-c60d4a476bbf"),
                LocationId = Guid.Parse("A3D2EC8B-B260-48B5-AE3D-5CE6D635ECA3"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("68f7f642-4565-4974-9d4a-21d19c87a196"),
                LocationId = Guid.Parse("8B849040-2901-4790-85B5-5CA19C1CCE07"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("699f1416-33fa-462e-827f-6596b2719114"),
                LocationId = Guid.Parse("9C17CF71-34D0-4613-9C0B-DA3C7C81998E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("69a42691-774e-40f2-a194-08862e2335bd"),
                LocationId = Guid.Parse("409B3AF4-FBBF-4B3A-9F80-F9B93724A59B"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("69b13a35-bda4-43f5-85fe-f686cb480b6a"),
                LocationId = Guid.Parse("D150E4EB-FD7D-4995-B4F4-82B2C783CEE1"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("69f69f96-de06-4b42-be2d-8e4f62e2aed9"),
                LocationId = Guid.Parse("6914F079-1170-45A2-80B7-3E79A6208AF0"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6a12797b-772a-443e-9f17-78e9bd721f1e"),
                LocationId = Guid.Parse("0651DF5E-FABA-4E8F-9281-797BD7009614"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6ad16137-39dd-49cd-9c87-05457540010a"),
                LocationId = Guid.Parse("9F6287EE-0B3B-48B3-A3B7-6ACE7D914F49"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6af35d92-8c03-4f24-8f12-9d16a2c918ce"),
                LocationId = Guid.Parse("3D88194E-D628-48DB-9A56-119F31EA4244"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6af679b8-3f65-42f3-908c-dc81edd200ac"),
                LocationId = Guid.Parse("B9954F5E-2AF7-4199-AD45-B6525DC107E5"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6bb4e4e6-3f42-4814-9882-97a042401bdb"),
                LocationId = Guid.Parse("BE3DDD65-CBBE-4807-8B3D-6304C30FB034"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6c0f4819-99b7-4361-8743-4979b3875149"),
                LocationId = Guid.Parse("425315EB-59D5-41B0-9A2B-646115A3F190"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6e0368de-4413-42d6-bd86-baba8b63dfb1"),
                LocationId = Guid.Parse("647EC1B3-3037-42FF-B7C0-0E4210970578"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6e22e2f0-1d76-4c5e-9077-043e3913b366"),
                LocationId = Guid.Parse("B2AF8BBF-59D4-413B-84F2-54FEB51ED6EB"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6eac59bb-4dfb-448d-9e51-ca88bd3eb5e0"),
                LocationId = Guid.Parse("BDCC457C-3F2C-4F30-9B79-36051365ABFD"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6f10e329-d437-4a14-a669-04f450146442"),
                LocationId = Guid.Parse("9BB9CC28-9DCF-44C0-9CB8-58D8F717BA5D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6f3ee7f1-20e8-4f78-9330-7678c9134cd3"),
                LocationId = Guid.Parse("E88B418F-3191-4E5E-A19E-D48611CE04CC"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6f4575c8-88ba-42bf-8866-172aa8cce2bb"),
                LocationId = Guid.Parse("B72DFD4B-19BA-4E7F-8684-B7420A9012E0"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6fc15a6f-0dbe-47bb-97af-ae59101867a3"),
                LocationId = Guid.Parse("5444594E-80E5-43C9-B4B9-45E1A2F3C106"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6fc40845-d4a1-4682-8683-50d7fe2ce090"),
                LocationId = Guid.Parse("37D94B3C-9242-4E59-B4FB-18BAB6A7B77B"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("6fff4c8b-3b61-4451-96ca-997984c2bd76"),
                LocationId = Guid.Parse("82440856-C826-4D1C-A3D1-AC12C1414D22"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7015b41a-07d9-459f-a990-a2e0da152fbc"),
                LocationId = Guid.Parse("90E1F8FC-6F33-4D43-9454-89854B224362"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("705afeeb-2bde-45d0-8a6c-cd6b7bff6583"),
                LocationId = Guid.Parse("2B123CAE-D980-4620-986A-D6C3AFE28B98"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("70e2e0eb-d26e-4389-90f1-d8b0fb398cd4"),
                LocationId = Guid.Parse("1968F81D-9454-4607-B26C-8938D2CB5BBE"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("715090dc-4c96-4b0c-86e7-71bf28cd67da"),
                LocationId = Guid.Parse("0DEA6F6E-F1D3-4D37-B675-803371C3E260"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("72219412-5c79-404d-9d99-ddfc290f3dda"),
                LocationId = Guid.Parse("64912443-D586-4744-806D-EE947D2945E7"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7298c344-e479-4c47-9b96-7e80ae512f84"),
                LocationId = Guid.Parse("163687B1-6EFE-49AC-BF30-41619B626B67"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7366be4d-251e-4d44-b8e3-9e45646f85e1"),
                LocationId = Guid.Parse("1DC6589B-7099-4A23-B268-8323C88E51D4"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7372271b-d3e6-415e-89ab-3a65fb33ca78"),
                LocationId = Guid.Parse("08DB910A-6205-446C-89A7-72B2615E0248"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("73768407-abaf-4d47-8159-a60be36ec2f3"),
                LocationId = Guid.Parse("AE888DA9-3357-4043-9DC8-7F75531A60AE"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("73a3b797-3cb2-4b36-b7f8-49701e7898bc"),
                LocationId = Guid.Parse("09CB7B29-24A5-44D5-8994-0A1170EE0179"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("73a4315a-fce4-419d-9a33-d67de2d3454e"),
                LocationId = Guid.Parse("7CFC276E-590D-4AE2-BC3C-1F6EF5DEE447"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("740fb8e3-d57e-4eb5-8a6d-bb510eedb5a4"),
                LocationId = Guid.Parse("F560CBCA-D749-420A-80BA-8AAB02628F66"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7413fe61-a2dc-41d2-af7b-bdfc3372e218"),
                LocationId = Guid.Parse("968B938A-04C8-4791-A6B0-DC2AAB910477"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("74dd161b-9061-4786-93ce-0a9f0838bd91"),
                LocationId = Guid.Parse("3568CA04-2FF7-4609-8863-17BD00FCB6BE"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("75b69120-6fc7-4782-9467-1b059f191fcd"),
                LocationId = Guid.Parse("1E77FD02-25E6-41B0-B38F-F92D7BDEB2D8"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("75cbc425-f4a5-415a-9c47-852898292b52"),
                LocationId = Guid.Parse("B7D19175-DE32-421C-BF70-4749BC560886"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("763d0108-08f6-4635-b4ce-b79a4f9bb064"),
                LocationId = Guid.Parse("D1302E33-0FAA-40E5-9B44-A27E246B6AC8"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("768e8c38-6488-43a4-9fcb-6d29d871444a"),
                LocationId = Guid.Parse("D11F43A5-51B1-4505-92F2-C36491C9BF92"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("76fb6522-0be9-42bb-b528-d2d93270dc4e"),
                LocationId = Guid.Parse("C2F7C7CB-B609-4E2D-8CB5-9DA45ECC2AC7"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("77121735-a541-4715-9374-358cdc680954"),
                LocationId = Guid.Parse("4A314551-2F4F-4FD2-9274-AF1D234C6374"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("77ca260d-eecf-4d9d-90dd-ebb3c96c7e00"),
                LocationId = Guid.Parse("7D255CB1-6D87-47AA-8260-CC0C74737B6A"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("77d9de83-3120-462d-af1c-88b57f95b8e6"),
                LocationId = Guid.Parse("3ABF96AB-618A-415F-908A-85456144AB14"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("782200b0-c50d-4df1-a73a-6fe420f9e92a"),
                LocationId = Guid.Parse("D515492D-72C2-46B9-8060-B61C4339FD6A"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("78232d29-bd42-4005-b205-37136edda4ac"),
                LocationId = Guid.Parse("F07F6166-1ED1-48ED-8321-8996821EE284"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("78429596-2582-469b-ac9a-483d8b860b3b"),
                LocationId = Guid.Parse("5698B90F-B116-40D3-8BD3-D1EC5AF4D283"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("78738a0f-8277-46a3-8895-09ee313000fe"),
                LocationId = Guid.Parse("0E585062-8837-4FAD-9DC4-083781326350"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("788d5dba-756f-45ac-9b1f-b01624bac486"),
                LocationId = Guid.Parse("FE141BAA-A39E-4570-A5B5-13ACCD75E0B3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("79a18429-8e26-43a0-93a9-057c3ca1175e"),
                LocationId = Guid.Parse("ED32593B-972A-4C30-AA7A-A86CC197665F"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("79de60da-97c5-4d81-89a6-710df2918d46"),
                LocationId = Guid.Parse("F560D34F-7BC8-4E72-85FE-CF1700B41D06"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("79ef982e-bc16-460e-a3cb-de174b9da09d"),
                LocationId = Guid.Parse("FB89E9BE-C20C-45FA-A37B-4576CB39C76F"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("79f7cb59-9ea7-48be-87d5-3346ee4c3eb2"),
                LocationId = Guid.Parse("AD678213-3CD3-4660-A6F6-71673A5F73FD"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7a724fdc-8e49-40b9-9556-26ef37c95454"),
                LocationId = Guid.Parse("0DD5E0F0-FC93-4D1B-B7F1-95954442ECD8"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7a9b206f-1f47-47f7-ae4a-96f199894782"),
                LocationId = Guid.Parse("5378522C-6E81-4360-AE17-C72FA95611B0"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7a9d62fc-ad1e-4e31-ad8f-15954c4e1f83"),
                LocationId = Guid.Parse("B240EFE4-AAF2-4DEC-994C-F97C2D7CFFEF"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7aa5d170-62b1-4ceb-a7fd-f033105c3536"),
                LocationId = Guid.Parse("F37BB961-4C20-4F70-8B72-5B8F6E2BE754"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7ae6d516-dc13-46ae-9ab0-06816e722822"),
                LocationId = Guid.Parse("940F2CE2-4024-4EDB-9DDC-62A00FA0F654"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7aec004c-1eab-43a1-80c0-5bcb78301bc7"),
                LocationId = Guid.Parse("ECED1B0F-DE75-43F7-BB8E-C9326EC2CAB8"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7b1baf44-995e-463f-84f5-574540bd5c11"),
                LocationId = Guid.Parse("E9BE0BCA-B22B-41B9-869D-728C1679E1AF"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7b37d35f-ab3b-4161-b1dd-397c6604b28a"),
                LocationId = Guid.Parse("B6FE9A68-70DE-48D6-8A8E-944E344698BF"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7c89a53b-9bba-4c4b-a13d-61de62769888"),
                LocationId = Guid.Parse("9F371A09-5DA4-40A7-AA37-93FBF230A167"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7ca8e72f-df4f-419a-9a4e-7ab6a20fa6c4"),
                LocationId = Guid.Parse("D3244AD1-BE8B-461A-A969-A99D05AAAFEF"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7cee217a-828a-4736-8829-d29629537ea1"),
                LocationId = Guid.Parse("31DB0D77-1164-463A-B434-26781B144F14"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7e47858f-8435-4af1-b274-7abf408cdfae"),
                LocationId = Guid.Parse("7AFBB739-96DD-449E-9EDB-CCC912CF236B"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7e7ab64b-ad0e-4725-a251-0d804c999970"),
                LocationId = Guid.Parse("8DE5956D-DC71-46FB-8800-7BB0F83ADC41"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7f4e6e3e-dc8c-43b9-899f-66cb60c04d91"),
                LocationId = Guid.Parse("018FF9E4-7A40-4E98-A22C-96B6FD44A7A1"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7f744d12-1f51-4995-97ee-2b5c497a25d0"),
                LocationId = Guid.Parse("2E3F0C6C-959C-4E15-B910-CDD0AD22CA1B"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("7fb6f13f-0a76-4f64-a303-a8def5ff8e8e"),
                LocationId = Guid.Parse("1095D6AD-B942-4299-A19F-5E456E46FF37"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8005e398-0aea-4511-82ee-3a319b0ff77b"),
                LocationId = Guid.Parse("7046D885-B56A-402B-BFFE-CDB73273437D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("808df551-73aa-4ecd-959b-4f4f73851371"),
                LocationId = Guid.Parse("45393795-8BFF-44BE-B8FA-A87DFE02CC41"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8094b299-aad6-45d7-9edb-f8c1df828b9e"),
                LocationId = Guid.Parse("A3D4C3D6-D367-45A9-81CD-8C69DCF59134"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("80bcc3c7-5580-4abe-87c3-de6a153c3335"),
                LocationId = Guid.Parse("66ADCA12-2FAF-4E22-A3AE-96772DB43002"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("80cdbc8b-7621-43d5-b396-1b6a69ea8ec1"),
                LocationId = Guid.Parse("54BE1CB4-FB59-44B7-9990-AEB6216F8F63"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8121ea6f-ca96-4a9a-87f4-2ab58f1a5262"),
                LocationId = Guid.Parse("CE9467D6-BBC2-411A-94E7-13FB0EB67190"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("81241e2e-e431-4370-a514-b6bae636a3f9"),
                LocationId = Guid.Parse("09BB9EAE-7A41-4655-8AEE-026089F36BB5"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("81370b63-6bde-4c8a-ae06-3623575bd392"),
                LocationId = Guid.Parse("75186127-4644-4BC5-B9C8-0CBD2E13EDE7"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("81839d1a-bed9-4133-b089-539555929b15"),
                LocationId = Guid.Parse("F2B7CDCE-1746-47E2-BDF1-819C789018B0"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("81e982ca-7bd6-49b3-a5a4-71208074edb2"),
                LocationId = Guid.Parse("10048E66-067E-4205-9104-7ABC758A6FC6"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("81ff3b29-e2a6-45e0-84fe-1db55769d119"),
                LocationId = Guid.Parse("7766DDAE-3CD9-4574-82ED-3D7D2ECD48DB"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8267cad1-9290-4968-b5fa-0a1ca2330a6d"),
                LocationId = Guid.Parse("21E39A8A-F254-466B-A4D6-8FFE13F36A5C"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8274e716-53a0-47da-80d5-d56ac35d5aaa"),
                LocationId = Guid.Parse("FD395D8D-3495-4F6F-AF91-BB245C9BA19D"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("82e24532-1616-4f51-a8c5-e2d6037a7a50"),
                LocationId = Guid.Parse("B18D2B4A-CE2D-45A1-84FD-79D9A6107FB2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("83254f99-7d48-4c59-a6c6-1e08049fb481"),
                LocationId = Guid.Parse("74211777-5409-4D47-A7A7-DC98B2752C99"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("83542b60-8934-4a96-a8b9-bb82d0f6a1b0"),
                LocationId = Guid.Parse("D6938B7B-F463-4947-86B1-1BC9B86757E9"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("83cadf1d-1585-4520-854a-ddf7c7d2001d"),
                LocationId = Guid.Parse("FF12AC64-CD34-4893-BA47-D997D10E38C9"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("83e755c7-c774-452e-93bc-69b05c4d42e4"),
                LocationId = Guid.Parse("21FE749C-A2B5-42DD-A7D3-64C498889301"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("84287bb8-e8de-41b8-ab81-38a3e072d44a"),
                LocationId = Guid.Parse("3DAEACD6-8A62-480D-BBE1-571FB74239C2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("842fa1f4-bbca-48b4-bc3d-f24ad6c07e94"),
                LocationId = Guid.Parse("FB8BBFFA-4A2B-49C9-B84A-F5AEFEB07EDC"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("844382b9-3528-4380-9e85-081ef1db6910"),
                LocationId = Guid.Parse("32A25CAA-A275-4AD7-8B1B-F569AE4A3724"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("84bb9269-2eaa-435c-bb14-ab9e2bae4b5f"),
                LocationId = Guid.Parse("C355684A-1B93-4A71-BF2E-D4A5C383ED63"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("84eaba70-9ebf-41fa-82e3-4bd6ba59c339"),
                LocationId = Guid.Parse("9EBC52DE-22B5-4048-A4EA-E498936ABA05"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("84fc3dd7-be4f-48fb-967f-734c4ecb548c"),
                LocationId = Guid.Parse("2907E7DD-F6BC-498D-9245-525D0EA8E5C0"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8501b4b7-c13d-4d7a-a5cf-ae200767d4f3"),
                LocationId = Guid.Parse("498D2CCB-3A08-4099-B38E-C3564B84E16F"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("85153ba5-7138-4c37-9d8b-5a1b1cdbb8b7"),
                LocationId = Guid.Parse("0CA6BFB4-D9AA-4270-8990-BF88F89AFD31"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8575222e-2b4f-4e57-8dc1-9ad1c8ad045a"),
                LocationId = Guid.Parse("01C6A392-12B7-4712-8711-43E3B4D9ACEA"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8616335d-e01f-4f1d-8415-a5d5e9b5aa3a"),
                LocationId = Guid.Parse("E88E19A9-C3EE-45F3-9F14-9ACB9960A65C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("863a415d-9109-4da0-857c-1331182bdd3d"),
                LocationId = Guid.Parse("15D2DB31-3ED5-4F2B-BEAB-667B6F53B256"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8649367b-dc29-41ed-ae52-7db889e8f74c"),
                LocationId = Guid.Parse("851C28CF-DD77-44FE-9A9D-65BB7CEDE506"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("865094ab-6418-4e63-a048-e79bc166840c"),
                LocationId = Guid.Parse("FFCB6B9F-9DD1-4E85-AF2B-7E5651F4951A"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("866735aa-ffad-49ad-abd7-0a3451ad9a7a"),
                LocationId = Guid.Parse("F2D0E15E-FDE1-4CE8-8530-E3A629DD25C6"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8681d269-fbaa-4f7a-9d98-4ae7eb191079"),
                LocationId = Guid.Parse("53400AEA-12CB-418C-A278-6DCF31D04E63"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8732ebdf-de49-4002-89f9-046dfee8aa6a"),
                LocationId = Guid.Parse("77BE4A0B-7554-49AB-8636-43CAFDFF6396"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8733f381-a161-439e-9375-66e35263707f"),
                LocationId = Guid.Parse("F7D706C5-8AE4-4AFB-8316-A25150885E9F"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8737d561-9e93-457e-9b53-7772538c48f5"),
                LocationId = Guid.Parse("E378F174-BAD4-4A0C-8DE4-FE03D0640647"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("87498ac6-d901-4d6a-b80f-e8f73362ba0c"),
                LocationId = Guid.Parse("7013DD51-F38F-4E1F-809F-5F704F238D23"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("87551116-0385-408d-aaa2-7eac5c0a736d"),
                LocationId = Guid.Parse("C2D7698B-E5F0-4E60-9CE0-D3AED4703367"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("87a77808-f65f-4767-9e6e-481b531273c2"),
                LocationId = Guid.Parse("10E9D135-3A44-4BDD-A7A9-7F0488267A5E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("87b2192e-a5dd-4259-b181-b61873fb4859"),
                LocationId = Guid.Parse("1749E9A1-6441-46EB-9686-DBF6F34C8931"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("87b48834-fd07-4525-a848-12b56158149f"),
                LocationId = Guid.Parse("ABB8D486-77F2-4DB2-9669-1735A3323B3E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8821dc3c-0940-4f55-8da8-6b4b9fa7668c"),
                LocationId = Guid.Parse("6369BC0C-381C-4E67-92A7-81C94F3F8260"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("88da9adb-d369-4496-9e3e-495ae22704bf"),
                LocationId = Guid.Parse("33A86E41-C2F3-4655-8CCD-FA2C61060143"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("88ec4e37-0596-4d37-838b-90dd4c17335c"),
                LocationId = Guid.Parse("9CB1B11C-E8E8-495B-B87D-65355AE198E5"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8912fb46-d540-4f1f-996a-5e784515715e"),
                LocationId = Guid.Parse("F8AF3840-DCC3-48B4-ADE8-4EBFBEA921F8"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("892b781c-d757-40e6-b2ed-696ff1895790"),
                LocationId = Guid.Parse("2DA5F13F-7801-48DC-B88D-6F70C400C3D6"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("89473768-19bb-4ef9-bdf2-61551d0c802a"),
                LocationId = Guid.Parse("D116567B-ECA2-403F-B856-459ED69233BA"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("894b260e-65e4-466c-82e5-5b8dfca55b97"),
                LocationId = Guid.Parse("65472328-CBA1-4948-9A30-82490DE3383C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8a19e857-48e1-4b5d-bc30-c59e540e37f5"),
                LocationId = Guid.Parse("4A2B7271-65D3-41CE-ACBE-ACEBE26F4804"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8a96cd0c-0d79-4f90-970e-9e6865af7b93"),
                LocationId = Guid.Parse("135C9E37-8E46-400C-9367-84B40016A4BE"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8ac92726-361b-4f74-bdf1-44cc89939629"),
                LocationId = Guid.Parse("C32E7DDA-10B8-424D-BDD8-A4D1230437E9"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8b333ae8-bc55-4383-8d42-722af21d1dc4"),
                LocationId = Guid.Parse("8BFE786D-3C66-49CB-B720-88DE86DB872C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8b60b0b9-5204-4921-a416-9e88073293d3"),
                LocationId = Guid.Parse("9DF47BBF-1A1D-46C5-B262-1100DAB117FA"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8bf7b60d-efc9-439f-bdd0-76d6c09ee59c"),
                LocationId = Guid.Parse("9D0A52C1-7572-4AC5-B068-08B68DE01803"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8c2ad106-f68c-4721-b03d-e7b764ff8e70"),
                LocationId = Guid.Parse("774A2B5C-8BEB-41CC-AC19-14E7D6D2476C"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8cb118e0-bdaf-48a7-a089-e5bbeb51d550"),
                LocationId = Guid.Parse("DB52CCE2-8083-4B7C-94C0-6D1595336B75"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8d49230c-cb3c-4b61-ad56-de6d1b0a94e4"),
                LocationId = Guid.Parse("99F88BBE-00E6-441A-B735-1218FA039CC2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8d499c79-676e-401c-989a-e5ebe3767bee"),
                LocationId = Guid.Parse("08507726-5E9A-43B7-8B8D-3166F79626F2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8d57c8c1-f43f-427a-84d1-401742ac83d8"),
                LocationId = Guid.Parse("31FD185F-607A-4486-9123-39EA39AE5CD8"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8d5e65bc-63a4-400f-a333-54448f5f6c1e"),
                LocationId = Guid.Parse("CD3BC38F-B778-426A-A068-EAA7726B05F0"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8daa238f-2cd7-4988-9ab3-3e9b31a0aa42"),
                LocationId = Guid.Parse("FEBD0A7D-C048-4A92-8039-347CCE2828B0"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8e1ed036-e472-44db-9a16-d4cba3bc7840"),
                LocationId = Guid.Parse("9232D026-A6DC-450B-A445-D252C01F0959"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8eb0d7ae-9087-4efe-8fad-1a998776abd4"),
                LocationId = Guid.Parse("D8F7D25F-62A6-448D-A5CD-C10489664F21"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8ec9a60d-91d7-4fc0-8753-dab3c7ffd3bd"),
                LocationId = Guid.Parse("7008609A-4212-46CD-859F-098B8A338246"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("8f0f8455-a4f6-4443-a939-80b4a0e8cbe0"),
                LocationId = Guid.Parse("249B7D6E-3D63-4CEF-9C77-09314F11FF3C"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("902c982d-c03d-4350-8edd-04f2de117697"),
                LocationId = Guid.Parse("34FB6E12-EF54-4DC0-A1C6-9A08E3CBA375"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9030712b-8d07-4d7f-9ac7-b4620e0c7d81"),
                LocationId = Guid.Parse("4F3CFC68-EC33-4BCE-8FDC-B473470D6578"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("90490bea-7180-4e88-afcd-4039e0acd554"),
                LocationId = Guid.Parse("76200187-C46D-44D6-9B92-9869A5600CDD"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("907bc31d-2268-4c82-9e2d-ee1318851d8a"),
                LocationId = Guid.Parse("1F995D36-E7CD-4813-974D-0A7CF8788970"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("90a3dfce-7e7b-4422-8f3c-349760b8dab2"),
                LocationId = Guid.Parse("EA9769E1-56E8-48E2-BE77-10A63172A04B"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("90a4f680-aa97-467d-b3fc-c2d9234184a9"),
                LocationId = Guid.Parse("299D7E08-57D7-47FA-98E9-EFD0878F8A25"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("90a631da-53c7-429e-a400-b11fc910e38e"),
                LocationId = Guid.Parse("A118058A-E426-4FC9-86FE-1E6A3B021F3B"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("90b0bf6c-9068-4745-827e-d3fb0e5185c9"),
                LocationId = Guid.Parse("C96CC2BD-6A99-432B-9ABE-834FD254EFFD"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("90c276fd-841d-4cc1-8792-771cdc4f3312"),
                LocationId = Guid.Parse("F6073E5C-3A13-44AD-A522-E8BA6DED8D11"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("90dbe700-9b10-4862-8efd-51b1702b7cbe"),
                LocationId = Guid.Parse("2249D9FE-746F-4BE1-8114-5D6C5BBF16B9"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("90e620be-3cd3-4dd8-addc-43d7d134eeed"),
                LocationId = Guid.Parse("BFF89121-7372-4FA2-9128-A9F7506C8205"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("90f30c33-9f3e-4b38-b277-fbcc11bda77b"),
                LocationId = Guid.Parse("10993DCA-FF75-4616-A226-A41F2117F7BE"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("91090d56-9234-4e71-8391-999e7da7b11f"),
                LocationId = Guid.Parse("16B56E45-4720-49AE-AB43-2BADC4F41ABE"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("910fd1cf-c236-4a8c-bfcb-cce3466756ac"),
                LocationId = Guid.Parse("538E2399-2AD7-4BE6-B577-81EC30DB4B2F"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9162a7bd-62a9-4996-8393-e110b662399e"),
                LocationId = Guid.Parse("B51FE85C-B0DB-48D5-A6CA-20A96AE491CB"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("91669cb9-9a59-4b09-95b8-3444cf0d630c"),
                LocationId = Guid.Parse("C035BA4E-6A44-4464-95E1-E504A9645A02"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("91afbc92-b772-4252-8609-2c830659a4e1"),
                LocationId = Guid.Parse("D89BCB17-1C67-476A-A769-9DE34EC93F3C"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("91d17d6f-bad5-4d59-b381-aad669a7cf85"),
                LocationId = Guid.Parse("F12D784C-5C1D-4BC9-A0E5-513C6A0C7CF7"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("928fd161-8c1c-444d-9598-0448ecb5f624"),
                LocationId = Guid.Parse("FF341B33-78E4-4DCA-BAD7-89722B6274CD"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("92b0f761-4cfd-4e85-96f8-c20d1939ea58"),
                LocationId = Guid.Parse("50D643FB-404B-421F-ABC2-D074C28BEB25"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("92f3eec3-ec62-48c4-83a1-686db69aa389"),
                LocationId = Guid.Parse("7CA93ED9-65E3-40DA-A8E5-FCC5298277A9"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("933ef619-7742-407c-abe0-b14bb11dfa93"),
                LocationId = Guid.Parse("9BDA4EBB-49B5-4AC7-9B0F-6CABBC4A12AA"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("936c887c-297f-4440-b9a6-fe2575a7ee7b"),
                LocationId = Guid.Parse("898DD080-39F9-4944-86D8-7D74DA0B8E30"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("93d31108-9d73-4084-bbd4-c74935b4cc0a"),
                LocationId = Guid.Parse("C505D7E2-31C4-42B6-867C-A7EF922E3F5C"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9467d561-ff8a-4d10-a933-fd622f918b46"),
                LocationId = Guid.Parse("EA80F2EE-4B48-4B62-AD74-021BDEF06A97"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("948508e8-e6ed-465b-b7be-9165bce77507"),
                LocationId = Guid.Parse("18EB2141-F1D1-4AAA-B285-F8C87D082841"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9491f0a6-cb6a-4ff0-95cf-e5a2faf90ac0"),
                LocationId = Guid.Parse("99E264A6-F6F9-41C2-B012-3A68856905E7"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("94e40e71-ffb9-434d-a078-01067c0b8a54"),
                LocationId = Guid.Parse("AE41D2CD-14DC-417D-BB36-001071CE5EF1"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("94f32f7f-78b9-43e1-b841-b3fca1bcf1ac"),
                LocationId = Guid.Parse("4D817D09-8458-4106-8578-3E527AB1F5D6"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("94fc890e-1aa4-41c8-ba04-5dfceaaa7527"),
                LocationId = Guid.Parse("5FA06894-1A20-47F4-BE26-DBC829F3A1FA"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("951a7f6b-aa92-4f78-875b-2be0f878eb18"),
                LocationId = Guid.Parse("746651C7-474A-4AC7-A1B6-2419B96D99CC"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("953c1bf2-5d09-48ca-8c93-f26d9d2ed68a"),
                LocationId = Guid.Parse("2AFA0722-42D3-4724-9517-C30F4CDBB9F3"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("956b4049-a5f3-4ab2-90a0-0acbb69fb8af"),
                LocationId = Guid.Parse("08600ACE-38BE-48DD-9A6E-37C165F2938A"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("957b86c2-9b9c-4804-8de8-4f7734e6c05f"),
                LocationId = Guid.Parse("962EC7A4-552B-4502-AFF9-C4E7E00D6E6E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("95af6de8-0619-4388-a757-b708bc100bb1"),
                LocationId = Guid.Parse("5792B387-AB5B-4BE3-85A4-DD19BA38819D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("95ebd789-a597-4b23-a234-f60ee4b36ba1"),
                LocationId = Guid.Parse("BDA1824D-D22D-4CA7-8D49-87A7AB6F8743"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("96033566-a478-4065-8ab6-faeb4fb01225"),
                LocationId = Guid.Parse("DA61DC84-F1D3-491C-A652-A53952AD8252"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("96159bd7-cb4a-497e-9a41-6b821d11d4c9"),
                LocationId = Guid.Parse("1386C7A7-98EE-460E-88BA-7E3A19CD167E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("964b43c7-4239-499b-9ddc-f3e6a34bab40"),
                LocationId = Guid.Parse("4CC8DB36-8C93-4AB9-B71E-629D57732079"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("967a23cf-a626-4bef-af9b-150e7433d7b5"),
                LocationId = Guid.Parse("A88040C2-F46C-4155-AE84-DF61E1D99E97"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9682de2d-ad80-425a-a21b-56dc2613bfbc"),
                LocationId = Guid.Parse("C4BA865E-A08D-48AA-A72D-433A30A49185"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("96f494c9-212e-4546-a770-297cf6f24d62"),
                LocationId = Guid.Parse("1C6A4AB9-D4F9-4D34-BA49-E2F4B1DA9945"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9726f106-60ab-4621-9d7e-ef6be62447bd"),
                LocationId = Guid.Parse("7DEBDCD6-B1C2-4A75-9E04-428AF73F5547"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("97335d72-5c2b-4f8a-9935-49bd00292ae9"),
                LocationId = Guid.Parse("FCB11A58-0A7D-4EC0-93CE-04D4A61F9F19"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("97748574-9445-4e99-8a54-9f6ba4334adf"),
                LocationId = Guid.Parse("76E69F6B-CAFE-4509-AE43-E6FF2748A3AA"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("97803c50-93e3-4518-945d-b453f0d21d72"),
                LocationId = Guid.Parse("37B46F8D-408A-4468-A510-C31F1D3D77D4"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("97be297c-fc05-4a81-9aee-aca2b13d2a41"),
                LocationId = Guid.Parse("50F6CB89-3A77-4D1C-A7E2-78C475A5B58E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("97cd0029-1e2e-4465-a062-c4e91f39d54d"),
                LocationId = Guid.Parse("0E40E16E-3B62-4543-BE47-A6C949F53C4E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("98607b89-4a91-4380-87e5-86feb76982b5"),
                LocationId = Guid.Parse("529BD98E-6758-4901-99C5-3C8710636221"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("98915498-c0a9-4268-b2ee-dca549fd0214"),
                LocationId = Guid.Parse("E94F238F-A60D-43F3-86D3-E43FC7B2E6B9"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9962801a-73b9-4a2b-b6ec-0f0eda816db0"),
                LocationId = Guid.Parse("28760806-36F2-4684-B18E-8D8F62B25896"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("997d971d-43fd-4fe9-aab8-7a36374c68e9"),
                LocationId = Guid.Parse("BB2D6930-A524-4BD6-B893-87AC7BFDC6E2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("99d4b3ac-0230-4d40-addf-c50a18b57589"),
                LocationId = Guid.Parse("D49024E5-3A11-4293-AA55-3ED4D5795C61"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9a19dedd-c68d-44c3-b951-06dbde6b00db"),
                LocationId = Guid.Parse("7D620FEA-FD45-456B-B682-654821A95BE0"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9a28efde-5993-407b-aeac-4acabe8fc3af"),
                LocationId = Guid.Parse("ACFB16BE-FD66-4590-9871-ED398FC914CE"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9a641ff5-a64e-45bd-92c1-3eea0a6f9fa9"),
                LocationId = Guid.Parse("6C236AFF-D08F-4FD9-A2DC-05BC24F86858"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9a6ba613-3ea7-4d6b-9009-b43dfad34c09"),
                LocationId = Guid.Parse("329B8FC3-57BB-4E23-A255-97ADD2829260"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9aa48477-9e1b-4681-8531-75096e871cbc"),
                LocationId = Guid.Parse("7DD489C3-C276-4784-9374-26E21E751B17"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9b8ff11d-a9a8-4d78-acc1-6a9bbcf3c35b"),
                LocationId = Guid.Parse("48538912-2E19-4268-ADE8-F10BD97F27EF"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9bcc5ad0-8b27-4e21-8345-197537e7215b"),
                LocationId = Guid.Parse("029379BD-7EAB-4FFB-B2E4-1DAEE26B98F6"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9c821d64-dc65-4712-b24c-8f266e39101b"),
                LocationId = Guid.Parse("B661943E-4D13-45B9-AE23-64A2BED3DCF2"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9c90c40b-6920-469c-b6f4-6a669d0c058c"),
                LocationId = Guid.Parse("B2CBB791-7D21-4DF6-8DF5-923DC4CE8F2B"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9d7875f1-13a4-40ba-96e4-fb3366fbd59a"),
                LocationId = Guid.Parse("5819EC60-213B-446B-9605-F73E4E2C0415"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9de22f8a-eece-4fd8-bff0-30e722b03913"),
                LocationId = Guid.Parse("11F4FFE5-AEAC-4708-91A2-873503910271"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9e1713ad-6e8d-4c57-91d4-1191743674ff"),
                LocationId = Guid.Parse("37973337-3EB5-4A7C-961D-18FE6E24589D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9e4bfcb3-0a20-4c79-8a9e-14b0733d0088"),
                LocationId = Guid.Parse("02F9F410-04D0-4161-93D4-B15EAF5B6379"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9e5ac70e-6316-457b-b193-c89b10f315b4"),
                LocationId = Guid.Parse("C93EE740-B29A-499A-A24B-0D4B3AFD5A57"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9e656f2c-73a9-4627-afa6-faa76cc8f9f2"),
                LocationId = Guid.Parse("0BC6A1A3-7D15-4C11-B605-0851F1921047"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9e69f11a-ee4b-49a7-93a5-b67652dcfdc4"),
                LocationId = Guid.Parse("E2B903F0-015A-40AF-B56C-9FD400DDBD72"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9e6f3b49-5b68-454d-8bea-bc11e11bef1c"),
                LocationId = Guid.Parse("00A8AA0E-C5FD-499C-8063-76B3058F1D09"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9eb7461c-b84e-4048-95d0-5d69ddc889e2"),
                LocationId = Guid.Parse("79D3EC14-DA9E-446F-BE81-10E26870D8E1"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9f04bc11-fffd-484a-8bf1-237bbec855b4"),
                LocationId = Guid.Parse("51194498-8A1A-4850-870B-4B48A4973AB6"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9f11dfeb-f9ac-4150-93f7-4c3de3723482"),
                LocationId = Guid.Parse("D7CED2C5-3C57-4B18-8642-D88D1911DE4E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9f392b00-8bb7-4dc2-b15d-76bd29fc9c8b"),
                LocationId = Guid.Parse("8BCD15CE-74E2-4F6B-95EE-59CFC9FB1B36"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9f40d692-4e15-4998-87a6-51f3a88d9b23"),
                LocationId = Guid.Parse("D0D69B94-AE03-432D-B899-2DBA6AA86992"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("9fd23356-1878-4634-949d-00e8d1d9bc7c"),
                LocationId = Guid.Parse("BC309166-1803-4A09-B813-F79F8E37ABCD"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a003151e-c6ac-4d8b-9410-2418601cc9ae"),
                LocationId = Guid.Parse("1AD41CC5-A950-45C6-86C4-95221C7DF60B"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a0136aac-829c-4685-b7a6-991c2c81c2cb"),
                LocationId = Guid.Parse("820562DE-CEBD-46DE-A729-7433F7C3D76D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a018e12e-799c-49c1-853f-63baf289dfe8"),
                LocationId = Guid.Parse("80C2219A-D192-482A-A698-E730A3C91B52"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a0717d9b-cc47-42c2-a715-1163e342ea8e"),
                LocationId = Guid.Parse("F0F61787-01D3-4161-B90B-F3142ED3567C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a07cf474-fc2e-42ca-b333-77b8e9291c00"),
                LocationId = Guid.Parse("7B7C987A-8A18-4DCA-B71C-F5E51B518D69"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a0ba72be-c320-4ebd-9e0d-1b6d510b7e86"),
                LocationId = Guid.Parse("BDB8EB5E-B7F2-45A2-A6B8-350223580D3E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a0c11093-3d4c-4ddd-ac28-8c914761fd12"),
                LocationId = Guid.Parse("B9A21AC6-86FF-4B10-9FDA-0D5F84D401EF"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a10eeba1-62e5-467d-a88d-014ce352c594"),
                LocationId = Guid.Parse("6F4EEE79-D7A9-46F2-8F6A-1C88ED656056"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a1c37218-2095-4f81-9868-dacd8b6e9595"),
                LocationId = Guid.Parse("B4E1CED0-C7A2-4566-A8C4-739F8A94F98C"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a1ca574f-653e-4166-bec2-0e0b6549163e"),
                LocationId = Guid.Parse("C0B8F30C-F29B-42AC-8629-AFCA77D0820F"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a228dd8c-2bd6-4b68-a893-edfff32614c5"),
                LocationId = Guid.Parse("DFEAB1A4-8A08-45DF-A00F-67F335265B52"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a25efec7-57a2-4c84-9d5d-53423baed226"),
                LocationId = Guid.Parse("30801C7C-4A19-42C2-992D-F35E73EACFD1"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a2785579-3433-4b1d-b88d-0201538d4eff"),
                LocationId = Guid.Parse("B82FFE42-66D9-4AD3-899D-E0F38E7F8B11"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a2ab876b-21b8-4d61-93c0-c4799543b112"),
                LocationId = Guid.Parse("230CA735-73D0-424C-99BC-3DAA3AD62121"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a2b08a1b-e834-4bd3-8de5-84c6060551d7"),
                LocationId = Guid.Parse("43336C29-8B2A-4B47-A4F3-2B74EB18A7D5"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a2dc9d31-becf-46fc-a8d0-2c6f26af0971"),
                LocationId = Guid.Parse("65521AC9-7FEB-4AC2-B68F-92F7B5295EC2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a305f37f-089a-48df-a77a-7242b31a609d"),
                LocationId = Guid.Parse("EA3A8A7F-5AAD-4FA9-8E8E-36A138D48234"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a31a959c-1ec4-40c4-9ae3-e2e0d0efe012"),
                LocationId = Guid.Parse("85336727-F4A1-497B-BE9E-E3B53D2A82DF"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a35af053-ffa0-4c12-b5fb-76d9217c9849"),
                LocationId = Guid.Parse("F4FE04A5-224D-4D6C-A29C-293E636685B2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a378b313-1955-4995-a422-732fd6f940e0"),
                LocationId = Guid.Parse("3DFE2DA7-3DA3-4CDF-A6D7-94D5AE00CE80"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a37be1d3-68e0-446f-90a9-78e0c135a821"),
                LocationId = Guid.Parse("A72B17F4-5741-4EFE-914A-25DDDB1A6818"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a3f49687-73e1-40b2-b0f2-31ed46fa5718"),
                LocationId = Guid.Parse("1FFB53C3-0811-46AF-BADF-F2FFA3AB3803"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a40082d2-4014-44c0-86ba-f75d95fa245f"),
                LocationId = Guid.Parse("1623AC56-6058-4D90-AF88-391C438931A2"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a4279679-07a6-4551-8ed5-405c19bdc19a"),
                LocationId = Guid.Parse("8BFA249D-345B-4CD5-A6AA-F70E7FAC6EEB"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a4809499-7b04-4f0f-b1e7-6d0c0be0d816"),
                LocationId = Guid.Parse("663D7FE5-4CBC-4C15-B6E3-C256AF72B359"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a498b0e3-dfe2-4952-a23c-b236fa16bcf0"),
                LocationId = Guid.Parse("59578728-11BA-4731-A186-75BFAD46FDD8"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a49f2676-0b0f-4cd7-8d0e-269cf1a24f87"),
                LocationId = Guid.Parse("9DAAFD5A-C7C9-47CC-844A-5622E8C6AFA4"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a51580b7-e1b7-43bf-ad44-a4f57c3e5389"),
                LocationId = Guid.Parse("A4618B23-B8BD-4F52-958F-CDD3FD79BE1C"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a5937501-8829-4897-8288-4371849b0fda"),
                LocationId = Guid.Parse("238692EB-EC32-41AE-87D9-02EB2C31352D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a5c44bcf-aee7-4e88-8f2d-54469387f6b2"),
                LocationId = Guid.Parse("95589BF0-BB04-4590-ABEF-69771955CACD"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a60262cc-5d08-46f6-b5a7-67d2dd134bea"),
                LocationId = Guid.Parse("9C34BF02-6E1C-4617-942B-C2895444BC4D"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a64dabce-11e1-47b5-9d3a-196833e8f45c"),
                LocationId = Guid.Parse("2FED08D6-888F-4B4F-AA11-78CF833AF7EE"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a676ba52-d232-4309-a69c-3f2e48662fd3"),
                LocationId = Guid.Parse("0D26FD04-E6D7-48D5-8B04-23CA8F6736E7"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a69e3687-e778-4d89-ae24-8560f96a5fc3"),
                LocationId = Guid.Parse("4F3878B9-467B-4855-86F8-23E8BDDBFEA1"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a78a4cec-77f1-48d8-8f27-47948f4f5e1d"),
                LocationId = Guid.Parse("DB7D84DE-8B14-4289-BA00-0FE07E3EAF4B"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a7989d89-bb42-4548-9791-976a732fddf8"),
                LocationId = Guid.Parse("DDE5354B-A4AA-4FB0-8DAD-2A24207F6F63"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a82384ff-7c91-49b3-9ce0-c5ffeef29ffa"),
                LocationId = Guid.Parse("C64EB7BB-BD45-4118-BEF0-9045D7A15C96"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a83c59f8-2da4-448d-988e-b937ba2087ad"),
                LocationId = Guid.Parse("74EAA616-C25E-40B6-8CB0-7C29549728CB"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a8490163-7008-4e8b-9ea6-e656f6f3e08b"),
                LocationId = Guid.Parse("D269E124-C9F1-4076-A4C1-C327DB95539B"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a84b4795-d349-4578-9b8e-7333f2e2ab57"),
                LocationId = Guid.Parse("C76712A3-8F1A-4C08-AA62-FF89E4028ECC"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a8e81a8a-183c-4a67-9bf5-1035283d0d74"),
                LocationId = Guid.Parse("1931AF6E-CC0E-4D66-AF19-8953E9742A66"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a91e9ecc-3f7c-4e88-b205-1e5a0de7e79d"),
                LocationId = Guid.Parse("068ED621-1202-490C-BB4A-EBF3C2DA3BEE"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("a92faf9e-880a-494d-a702-00a01c305030"),
                LocationId = Guid.Parse("DC8B0DDA-8044-465C-9275-EE6A43B77A83"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("aa135518-2035-40f7-b26e-d5471490e8fe"),
                LocationId = Guid.Parse("70946B36-7088-4BC6-AC72-B24F32952938"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("aa269c96-7056-40f4-9c36-ec682b88a885"),
                LocationId = Guid.Parse("064DF2BE-FE05-4259-90F2-EB95378BD53E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("aa8349be-4378-4707-b271-6460db0d44f4"),
                LocationId = Guid.Parse("15D02309-65AD-48BC-BCBC-34D32EEC9E14"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("aa8ee73b-916d-4975-ab92-583e82c2cde5"),
                LocationId = Guid.Parse("B96CB111-3B4A-48D9-94B2-D5AE7B28B134"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ab6d743c-91ad-4d85-9f2d-de1469f337f7"),
                LocationId = Guid.Parse("F344F99C-923A-4BB2-A9B8-019AB3059BED"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ab9a6d60-2196-4459-8e5d-df32b4a45ec5"),
                LocationId = Guid.Parse("AC4D20E8-B910-42ED-91A7-1179094AE7FA"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("abaef330-ca91-42f0-ac1f-d3a4f612de1e"),
                LocationId = Guid.Parse("F261016D-FCB3-4EDD-BA9D-DE5E3ED85AA7"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("abb6a3db-5aa6-44ff-a2cb-9933560f7fad"),
                LocationId = Guid.Parse("F0960F87-BCFA-4264-82EC-8F7B00694DBF"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ac16b6b6-d8f3-47d8-8313-ed54c698f186"),
                LocationId = Guid.Parse("DC93B4C6-983A-498D-BBC5-3BEBDADD0FED"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ac88a152-bb05-4616-be65-9aa80af103c2"),
                LocationId = Guid.Parse("0594F79D-A905-4FB1-9D6A-2F1458815C4F"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ace3cbde-1b67-4416-bda5-083cf975a693"),
                LocationId = Guid.Parse("6C6AFF65-EDF9-4E0B-B8C5-2FFAFCF4D1EA"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ad47e53a-a3eb-4da8-8299-723aa1375c6a"),
                LocationId = Guid.Parse("C6A796FA-8B40-49EE-A643-2DD53ED49C71"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ad7a9f7e-7963-4dda-a3c1-76ef94fdd457"),
                LocationId = Guid.Parse("342A4AB3-6D0C-4DE5-AC65-D608A0EBEB99"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ad8e615f-dab2-46c2-8064-d79cfb260b44"),
                LocationId = Guid.Parse("DB74725F-07AC-4BB4-B148-ECF3D6AC90D9"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ae1a75c1-a8d2-486f-9309-fce29f7d29c7"),
                LocationId = Guid.Parse("4316C38D-FE4B-4203-8CD1-59815FE66A29"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ae5a10c9-b734-41fb-8d37-5c7d39d20aa1"),
                LocationId = Guid.Parse("60E6D6AF-F07B-4D5F-A4E1-792D782512CC"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ae852bde-d04c-4729-93b7-1d70d0894e46"),
                LocationId = Guid.Parse("2EB0EF3D-5723-4DA2-B112-BF0D4E33E4CE"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("aeace0bf-d794-4a93-8e16-2b96ee67201f"),
                LocationId = Guid.Parse("5BA93416-FAE7-4820-A661-AC3463DA86FD"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("aeb0b240-fc4c-4338-92d9-d8b3810c23ee"),
                LocationId = Guid.Parse("EDE82731-F972-4C94-B0B3-A63EE6439149"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("aeeac256-ee74-4754-9812-eec9c979d107"),
                LocationId = Guid.Parse("3EF1731F-3EA6-49C5-A4C5-C5AA48734C05"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("af38a563-dcb4-4b32-8f17-f58dc03db572"),
                LocationId = Guid.Parse("7BEF9224-C19B-4951-B3F0-5D622302F502"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("af3d2feb-5c88-439b-a986-41483002db32"),
                LocationId = Guid.Parse("01FE675D-797A-48F2-A5FA-88B45BD54855"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("afdb2aa5-0b1e-44ac-9c6f-368fcd125107"),
                LocationId = Guid.Parse("EE52516D-0C4C-4294-910A-9914BB303C78"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("afdd0470-c89b-4c0c-8b64-ff5212dbaeac"),
                LocationId = Guid.Parse("9C16B072-6A56-403B-8929-44EF89B0143D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("afe4a1a5-1819-4ccf-b0f8-ebb0cea3d8d5"),
                LocationId = Guid.Parse("32A659D9-5FF8-4B69-818D-3999C8CFBF51"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b0bec71c-ab3f-4d75-b977-3be9c1af7b12"),
                LocationId = Guid.Parse("FD7AB4AE-4E8A-4A12-BCBD-C89B90A893D2"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b0ca0ee8-b8f8-496d-b972-fba7ac0f26c1"),
                LocationId = Guid.Parse("28D0682C-24E6-4CC6-BFF0-68D743D90577"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b16986ce-a690-44ee-920c-88f4de005c66"),
                LocationId = Guid.Parse("F1EE0A65-9441-4333-8F84-763EC74A15BD"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b1764979-3e3a-445d-b090-de5047f29bd1"),
                LocationId = Guid.Parse("EAAFFB34-5B41-4098-B6FE-C5DA1F825218"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b1eb8d79-24e9-416b-b52f-785eb0fa9b90"),
                LocationId = Guid.Parse("B839638A-0B73-471F-8C75-6854AC760ED6"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b23f62c3-7c07-4673-a196-6a2009ee55ef"),
                LocationId = Guid.Parse("0C7550C1-365C-4CA9-80C5-89616A45AF5E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b25bbca2-3c28-448c-b74b-4558244c5069"),
                LocationId = Guid.Parse("3C555109-F8EE-41D1-BD97-C74AF8CE3C35"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b2ab7a6d-2e94-4ce0-9020-70b8e0c60f87"),
                LocationId = Guid.Parse("86F22D47-2A2E-4225-BECE-49ED14E5D859"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b2aee6e9-447f-4622-b980-a7084559da45"),
                LocationId = Guid.Parse("2400A1CE-8D9F-4157-B8DE-43EF6A7E9A1A"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b32ceaf3-56b0-48c7-816d-e19750447166"),
                LocationId = Guid.Parse("22841DC7-3DAF-4768-8D1B-B3B5A4B78D09"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b33e18c1-27a3-4a8e-91f1-3a2cc0efccce"),
                LocationId = Guid.Parse("A68A2CAD-5B4B-4C6A-A906-62743C176C41"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b34737f1-e453-435e-96fb-48aa5810f894"),
                LocationId = Guid.Parse("1B0C4C8F-93D3-4F68-9025-9F902F601ABD"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b36026ef-8a00-4dc8-8155-259b51a8dbca"),
                LocationId = Guid.Parse("96BCD218-37FD-4D84-9CD5-F038051F48E8"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b3a356f1-df7f-417c-b47f-f050fe84f054"),
                LocationId = Guid.Parse("E20D799C-7387-4583-83AD-A0105CC2185A"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b3acabfa-3f09-4c43-9d31-f914e5647d65"),
                LocationId = Guid.Parse("638C11AC-CB06-4176-B17D-FFC54DBB03FE"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b3d77d1b-587f-42ea-adb9-3faa492c144f"),
                LocationId = Guid.Parse("3EDB4AEC-268D-49D2-B697-E15FB5D3CB46"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b46afc7e-98e6-4796-b987-d3dfef6a398b"),
                LocationId = Guid.Parse("14D381CE-243A-4CDA-B3C2-2F1648CE14D8"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b4f6be65-d890-4f8e-b995-451cc2c3ce1e"),
                LocationId = Guid.Parse("2895F5EB-F72C-4CAF-B60D-FDDBCA4CC26E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b50bcd0b-9439-4843-be31-0a4fcb7179aa"),
                LocationId = Guid.Parse("8B76BE47-8A87-4C47-8C92-C4AF88377F42"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b53be85d-12a4-48e5-9a09-086433be56b8"),
                LocationId = Guid.Parse("2F868614-B887-420A-82F4-829B375C998E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b540dfba-5812-4f30-b37a-00ede878f790"),
                LocationId = Guid.Parse("1D3046B4-DDD8-43BF-AF08-6182BF34DCB2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b59afd44-3e5f-45f6-8831-413d13f03bc8"),
                LocationId = Guid.Parse("75C295A0-392E-47C1-B74C-52F88BA6DCBE"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b5aae94f-f0d1-46ae-8193-eb25c56c2183"),
                LocationId = Guid.Parse("43A0554E-6464-4393-B9F7-4049D528BA42"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b61fa2aa-7bb0-4120-9844-3c36ca86380d"),
                LocationId = Guid.Parse("5824A8CD-F3F3-48F5-B6E7-608E2B1B4F0C"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b63165dd-1459-4e21-990c-563cdd2044e7"),
                LocationId = Guid.Parse("F2553C74-B325-4DBE-A288-02B48519D039"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b6645395-71de-4c46-9328-c31c7d88a72a"),
                LocationId = Guid.Parse("F6B40402-4C6B-4712-B919-47A2ED8962BF"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b6b6a80a-371f-4dec-a0fb-cbb70dd026f7"),
                LocationId = Guid.Parse("547B3D7C-2E2E-4288-BA3A-D10E4D62E726"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b6ea8214-5e6b-445e-a080-06ad7273cfc4"),
                LocationId = Guid.Parse("D5F97054-8B88-4D21-BE42-8ECAFFCC3E26"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b7101c2c-52f5-4f0a-9133-b7055a735055"),
                LocationId = Guid.Parse("E5AEF3F9-7A35-42B5-A5B7-272243F44D68"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b7337cd7-ba36-45df-b144-e9dc964562a2"),
                LocationId = Guid.Parse("789A1DB9-8E2F-452A-A3F0-7065AB4AA20E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b76a8516-38e4-4c57-b605-c7a4f1d064d4"),
                LocationId = Guid.Parse("452E5EFE-ADAE-46A9-972A-94E970BAF290"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b7a62a0e-1873-4f31-977d-3e68e6ac5d3c"),
                LocationId = Guid.Parse("BFAFE417-54B3-4E9F-ABE8-E9967A657D69"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b7a9d3e3-236a-42a4-a74d-031f20286446"),
                LocationId = Guid.Parse("59C9146D-9728-4D19-9984-3BC191AB9884"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b8054b17-de50-4caa-b291-bb04f4b7dd88"),
                LocationId = Guid.Parse("2F24C9A4-95E3-4220-A12D-ED30CC0332BB"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b81eab85-562f-4768-94c6-ee40cca21236"),
                LocationId = Guid.Parse("A0DC3D2F-E01C-44CD-BD85-FA11349AFBD4"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b8453550-d201-4567-b079-d764f35d9a48"),
                LocationId = Guid.Parse("B97DCAFC-E05E-45C4-9C93-20157E4266E7"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b84fdae3-88b6-4643-9ba4-43e08cd77909"),
                LocationId = Guid.Parse("95E67FA9-0142-4B8C-83AB-B7401A3300ED"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b8f0a7c7-3426-4077-a333-c1831ce68552"),
                LocationId = Guid.Parse("DFCB244B-3BC8-4C76-8EB9-2369A11659A0"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b9401005-9966-4c0b-b7fb-a114233c951e"),
                LocationId = Guid.Parse("4FC4FC25-0073-4B25-AB26-4D2214CD967D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b96af352-2619-45ab-9adf-0b1b6c5b1ae5"),
                LocationId = Guid.Parse("D603B2F4-70DC-4C9F-944F-79CA587E1E38"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b9b78213-e2a9-4a71-81a1-0d9c762d9e32"),
                LocationId = Guid.Parse("465BD784-72E6-467D-917A-5F8F783512D0"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("b9fa4474-6e2c-431f-81b9-41c901de815a"),
                LocationId = Guid.Parse("E034AC20-2865-4466-9022-ACA88E52D372"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bb03d5f0-8167-43fb-bea5-9885f353c914"),
                LocationId = Guid.Parse("1D874D38-573B-4A35-8878-4A116597EA84"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bb65713e-79cb-4bea-82fb-fc35efbbbb5e"),
                LocationId = Guid.Parse("C94ED920-EE11-4585-9B89-6B8514640C75"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bba5e592-ad8a-4b96-8da5-c7a63b970bc6"),
                LocationId = Guid.Parse("871F2A40-59FE-4F9A-8749-78F374F1DD22"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bbf3c59b-7af1-483d-b47f-b353616251a0"),
                LocationId = Guid.Parse("25F74914-E324-4A9B-B454-6D512E0CB978"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bc25ea08-e3b3-4eae-98ee-4941fa788017"),
                LocationId = Guid.Parse("1DD6C54F-86A4-437D-A354-1347D2B6FDF3"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bc56234d-f4a6-490f-a9df-02a1bf144748"),
                LocationId = Guid.Parse("A9A62AF4-10D0-4750-A60D-29B445C8A147"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bcc7396f-0e0a-498a-8aeb-c1bb6198392c"),
                LocationId = Guid.Parse("58A75A0D-DE86-49BF-B195-E10811492658"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bd0c81d5-b04f-4185-bb08-c0075186ba37"),
                LocationId = Guid.Parse("24A848F6-B384-4D1F-A462-AB4699E3B0E9"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bd2bd1df-be14-4f83-b34a-0e3f9c0b9e8b"),
                LocationId = Guid.Parse("F5F4908D-8F63-4F33-AD49-685C90046798"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bd672b28-ab0c-454b-a977-bb4d5b96303f"),
                LocationId = Guid.Parse("683FF656-0AE5-4E19-ADF8-B1E087D3AF12"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bf270728-5a86-4057-a9c2-59b26fd50343"),
                LocationId = Guid.Parse("0AAB0CF6-10AB-49F9-A977-904A54D71FB4"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bf47bc01-2f33-4d51-ba51-bf247fae5af8"),
                LocationId = Guid.Parse("5153CD44-6DD5-44CE-B3A3-332D2F46D833"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bf56d0e3-ec14-427b-9f13-04088357fb51"),
                LocationId = Guid.Parse("FEBBC9F5-D98F-4E05-8045-7E07BBBC29F4"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bf6d314e-af95-49fa-8cc7-4b7dc5d1194e"),
                LocationId = Guid.Parse("23675227-94DE-447F-B0DA-EE69200F0AA2"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bf9d4571-50f4-475e-92fd-a2e8af1bc8b6"),
                LocationId = Guid.Parse("B7533350-4B1D-466D-AC01-20FB0A4C259B"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bf9d4ac9-4984-42c9-92e9-37f34242d4e1"),
                LocationId = Guid.Parse("E9DE6C79-B88F-4180-813E-BEEDBFB179D5"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("bfe587ef-c954-490f-9e81-a1a5cb980915"),
                LocationId = Guid.Parse("E7447F79-08CB-4FC8-8711-B11716A65F67"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c06ccfc0-cee0-447e-90da-64024f950923"),
                LocationId = Guid.Parse("D70B344B-5761-41AC-A382-B22DCD89AB56"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c0df55ad-d832-4e12-820e-e18fc6a16ec2"),
                LocationId = Guid.Parse("805A2639-EF7C-4159-B6AE-F9ABC4F0284A"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c0ebdc0d-eec8-471d-9db7-59a1a4971d3e"),
                LocationId = Guid.Parse("217E2410-5B43-47E1-8457-CEC31747A1E6"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c10ce550-017e-409e-a848-f254480bd58d"),
                LocationId = Guid.Parse("57C812A8-3216-486E-B6A3-7D20A165CC20"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c10efdd5-5fb5-4b04-9b87-77f1fd29d819"),
                LocationId = Guid.Parse("B630CCC4-D082-49B1-B66D-3E3F6AEB854E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c130f784-84f2-4256-923a-ff163f284ca3"),
                LocationId = Guid.Parse("4ED73D7F-34E9-4398-ABF0-99203076474D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c14fe7b5-e50e-4de8-80d6-598faf6dffa7"),
                LocationId = Guid.Parse("5CB81E9A-0519-470F-9B6E-9F83AD2CA0E4"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c1fbfc2c-d239-403c-940a-c2ad00aba894"),
                LocationId = Guid.Parse("58857610-5CE3-4C56-B15A-09B6F95F65B4"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c22aa7d4-02d9-4425-a0b5-682b6fbd11bb"),
                LocationId = Guid.Parse("BC5B881E-B3E6-4264-BF24-E603AB36382C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c2345caf-e7ed-4346-8898-be816c114954"),
                LocationId = Guid.Parse("53D534E5-C02D-42A7-96CE-F258A63C7A85"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c2b4039f-f072-496f-8cfc-735960fc3060"),
                LocationId = Guid.Parse("5EF18BA8-B63F-4E28-9926-50FD508EFF56"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c2bdb361-3c06-4991-a58c-3e7d21d99dbf"),
                LocationId = Guid.Parse("334EFB94-6F35-4C93-AF11-24AC5DC79D19"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c2fbaf91-7f13-4b9f-9c56-dd48127b9b10"),
                LocationId = Guid.Parse("E2985273-7435-46DF-AAFE-0BA0F8FA1246"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c3ca53ae-ed7d-453c-af48-f6fe023ba848"),
                LocationId = Guid.Parse("CAB347F6-DD06-4A6E-8672-80EC556A4E41"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c42a31c9-42fb-4d90-9640-904576bf2db1"),
                LocationId = Guid.Parse("1DF0BBBA-CD92-4B32-9461-EDE68CDAA5DE"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c433bb76-bf76-4874-b902-759bafc0da30"),
                LocationId = Guid.Parse("B6699048-100C-48BD-B34C-F4BDFF31A156"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c47ba6e3-3bc9-4475-8faf-90c8ea7ec3d0"),
                LocationId = Guid.Parse("6F629C35-0DB1-43A9-AE0B-88B697ECA217"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c4a07f17-e417-4248-91d9-d139d9b40876"),
                LocationId = Guid.Parse("8F6E4816-C4FE-4E4B-AA5F-BEC4DAA59B61"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c4d1d548-566d-471f-b2d9-1ebe5ef8da83"),
                LocationId = Guid.Parse("C933DA53-58E9-46B0-B68C-A561E27A7F62"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c58e3785-59c8-45e6-85b4-4a98b51ecf26"),
                LocationId = Guid.Parse("26C18BB0-0D66-4D0E-9DF0-227628A30392"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c6980f10-6356-4504-845e-ac958d6d5406"),
                LocationId = Guid.Parse("15420D23-38C6-40E7-9C6C-12474ADB71A2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c721811f-c6f1-4c6b-8676-a0db25768c4c"),
                LocationId = Guid.Parse("933825BC-9178-423C-91D1-4118BD400B6E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c726e03b-13c3-4563-8271-7ce4f5088bc7"),
                LocationId = Guid.Parse("DABEA372-8D80-4CB8-AC93-41641AC89B9C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c797c0cd-87f0-4d74-b1cc-c13cbbd8b9f2"),
                LocationId = Guid.Parse("6F37CFFD-36C9-4158-9F9C-648F1AE3EAF8"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c7e7614a-9980-4fb1-95f0-7e4858164e94"),
                LocationId = Guid.Parse("708424AA-7AA2-44E4-A780-A6C8F2DB52DC"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c89ba7fe-618d-472f-9bfd-3f19d8f9772b"),
                LocationId = Guid.Parse("5501D1E8-42ED-4911-AD6A-7C8CF242A19E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c9453d4d-426a-4eec-ab34-977a2a750553"),
                LocationId = Guid.Parse("754CE5F9-81C5-4AB5-A093-2695AEA1182B"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c953bf2e-680e-4009-b4c1-8703077280d8"),
                LocationId = Guid.Parse("3C401E9F-75DD-45D5-B756-F9A6CAFD2B0D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c976521f-9b9e-4dc4-b1e0-fc75b7fdcfbb"),
                LocationId = Guid.Parse("542799CB-1124-410E-85F1-BA593EE5A0A7"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c9a9574b-2fb3-46d8-8dd9-7296bef3f1f5"),
                LocationId = Guid.Parse("1D0FCB24-255A-431F-AE80-CA8C33BE5F1F"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("c9d032c6-63ec-4ec7-b5d8-fa397049c719"),
                LocationId = Guid.Parse("7B95C2D7-E2C4-447A-9667-D2A50802B385"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ca81f1b4-5ee5-49c3-abf3-a2edbe7a20d2"),
                LocationId = Guid.Parse("4AA27177-D240-4986-BCD1-1209C5C89D75"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cbd12e84-c73a-4297-a62b-5bc11a026db5"),
                LocationId = Guid.Parse("A148D044-2562-452E-8A78-E9ABCEFA8F77"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cc5012b8-437d-4093-81c9-2c9873327f1f"),
                LocationId = Guid.Parse("DCEBCBF6-855A-4441-A7BF-95CA6C340470"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cc7238c1-6f87-40c6-931a-0499b3a87905"),
                LocationId = Guid.Parse("27EE14B0-A3BD-40B2-8061-32D420F7409C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ccd88f29-9d9b-41f4-9467-16a357388b1a"),
                LocationId = Guid.Parse("50FE98D0-0D62-4B2D-A799-91D7C4343D3F"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cd7949d6-d774-413c-b7c0-d5cc61760033"),
                LocationId = Guid.Parse("734FFEBE-7D34-4815-81D5-0C0E1B160DE4"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cd80c983-6fa3-46b0-9679-b60e0bbaf2f1"),
                LocationId = Guid.Parse("D7095F15-AC80-4957-92F1-DC5D3B51634E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cd81fe17-ee34-4201-a622-e7360e85fa23"),
                LocationId = Guid.Parse("95CACAB0-99F8-42E6-AA8F-F49EEFB42776"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cd979221-7638-48a4-8177-75a79d90ecc9"),
                LocationId = Guid.Parse("46B572A6-B083-4C33-9039-EA3941C6CCD4"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cd98ca7e-736b-45de-b772-32d29a20af31"),
                LocationId = Guid.Parse("E3D812CE-7D9B-4EF9-B32A-E8D8B3BE32A8"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ce9d81bf-5192-4088-bbd4-f84545db5f4b"),
                LocationId = Guid.Parse("3F35D8E7-6025-4BE0-ACDD-B967374595B5"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cf15b1ed-9811-42a8-a2af-c7a3db0aea42"),
                LocationId = Guid.Parse("D58B7501-C5F7-4E51-94B1-D282852BBFA7"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cf3597a9-34d9-4739-9290-4c07baed8eac"),
                LocationId = Guid.Parse("3563C69A-D6AC-499B-87C7-50825C97527E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cf46c671-4da1-40f8-ab78-a1ffd5d6cd28"),
                LocationId = Guid.Parse("62387834-44EB-4420-A7DA-CD49A139335D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cf666976-9113-458b-8ab0-6d50e0a7c193"),
                LocationId = Guid.Parse("412019A8-F9F2-4757-9F2A-A52B632C5B90"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cf68a446-c30b-4e22-90e4-c95549e96c30"),
                LocationId = Guid.Parse("D658EE1C-3504-4D7B-B0D1-E9D844DEC5C0"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cf748131-50fd-4f8c-93e0-e61eee211b18"),
                LocationId = Guid.Parse("F26A63D4-49D6-4133-81EB-975FBD343576"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cfa26aa8-cad1-4124-b54f-b7d8a310df9f"),
                LocationId = Guid.Parse("69A7BE0E-B4B9-4A65-B0B8-51D68F34E14A"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cfb501a5-63a1-4b4a-bf81-546499291bfc"),
                LocationId = Guid.Parse("8395A6ED-93B9-412E-BB17-24817F28478A"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("cfb514e5-956b-42f9-bed4-a1f6b836ad83"),
                LocationId = Guid.Parse("2B0FA252-15DB-4E66-B240-AB3C9BB8AC0F"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d059caa4-706f-429a-8e92-7764ee57d9d4"),
                LocationId = Guid.Parse("BF8B854C-76B2-4626-96E6-4EAA2BB425C0"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d064fa56-6fe4-466b-8c20-c26a4f47de23"),
                LocationId = Guid.Parse("E7D021F2-3E6B-419A-9E5E-1690C2C7B3C9"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d09fea7a-90dd-4c00-9a24-617f8e6a9120"),
                LocationId = Guid.Parse("698B8807-DC6A-47F3-902C-3CC3363A314E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d0bae5ac-b752-41f1-b94d-fc2e6f1c4d96"),
                LocationId = Guid.Parse("37B57A50-3082-4935-A1F9-6982A2DBF719"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d0cddc11-b562-4d45-85ab-70e68e4bc84f"),
                LocationId = Guid.Parse("C4B1ECC9-38DF-4115-8ABF-D7E4113CF205"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d0d732d5-20a9-4184-aae7-fcf9456dfa53"),
                LocationId = Guid.Parse("29BB3A42-8005-4BDC-A455-872790352574"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d196f9f3-fee2-4b4b-8484-582540cb3a61"),
                LocationId = Guid.Parse("63B9312E-CEB1-4443-9F60-4AF7BA7F70A5"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d1fcd81c-0df8-4269-99cf-fd194176f134"),
                LocationId = Guid.Parse("B013E1A3-92C3-4020-810D-5DAF05182061"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d21cf045-01ea-4a0c-98cb-9c00133f1965"),
                LocationId = Guid.Parse("D5A6FA1A-F112-40A2-A8C2-A4CF08872374"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d221a51c-1472-459b-a804-31e1dde9490b"),
                LocationId = Guid.Parse("1C266AA5-9FBD-4E60-A5D0-CA4A942769F5"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d23da4c8-dde7-404a-903a-f87398360f3f"),
                LocationId = Guid.Parse("A711984F-A02C-4DFA-A558-425E7E7C7440"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d2a4c9ac-4865-49d0-b366-5a878937833f"),
                LocationId = Guid.Parse("98BDF824-9A8B-40E0-A59C-0F8F67301EE2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d2bb1c1c-3b67-4328-8d94-b61312f565e1"),
                LocationId = Guid.Parse("03C097A6-F658-4836-9353-4C84D845E827"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d2ce56c5-5776-4fd4-9791-6bab14474af8"),
                LocationId = Guid.Parse("B96B5DCF-AE22-4055-B0E0-CE9510152711"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d30dc3b3-325b-4c36-8b86-1472acd28fe6"),
                LocationId = Guid.Parse("8E71B940-8F17-4A2F-A9D9-0715754CD1A1"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d3759135-00f6-4a1b-971c-d12c11fb3eae"),
                LocationId = Guid.Parse("4A67A504-A790-4CA1-B6D7-F23C0C25371D"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d39fac4f-03d1-4ff1-977f-d3854f533207"),
                LocationId = Guid.Parse("434C5E33-3499-4620-BC79-152D927FC47F"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d4c7f112-423f-424c-bea6-cc54a24c28a2"),
                LocationId = Guid.Parse("A7328B8B-581A-4F21-8AEA-964A52836B89"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d5410a6b-a910-4069-b0ed-30dd30fd16df"),
                LocationId = Guid.Parse("BB04AC25-FA8E-443E-A780-9C93854379A2"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d594d05e-209f-427a-8f99-fba124c9ecd4"),
                LocationId = Guid.Parse("851207AA-881C-4152-95E9-5E83F027D243"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d5b0cdbd-c1cf-48ab-8d81-56241cd89c83"),
                LocationId = Guid.Parse("3C9A85F3-950F-41C5-AAF9-7F2EF75C73AB"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d5be7a75-57e6-416e-af01-d0d80bdf521c"),
                LocationId = Guid.Parse("E8419BB8-0A39-4D16-9D1A-7BB1F3852F42"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d5ed1fde-e8f5-4348-a7ce-ec8ee5b59ae0"),
                LocationId = Guid.Parse("B6423B06-1A1E-4762-8378-0D82B2864D54"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d5fb6d10-2322-4a2b-b0a9-c0f72fffcb72"),
                LocationId = Guid.Parse("7143B41E-BFE1-441A-A822-9BCD45DBFEE6"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d6060a89-9650-4ccc-9010-5c09985ef92c"),
                LocationId = Guid.Parse("6FCC47B7-677D-41F7-B7B5-6FD4CD47DB11"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d6140680-acac-4b3b-816e-dfb8dc609930"),
                LocationId = Guid.Parse("DA645152-DC1F-43D8-8483-25E9E4AF5ECE"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d6552aaf-5e70-4807-88ad-ab9602f18650"),
                LocationId = Guid.Parse("EC1F52F5-70BD-46FD-BA0F-6B62716BB55A"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d65f863a-0829-4d12-aeb4-cb26a9ff2d39"),
                LocationId = Guid.Parse("D6BBC568-4056-44C1-B1BE-AAD63DF987E1"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d66bf9e7-2f45-4246-80aa-6c93da140beb"),
                LocationId = Guid.Parse("045DB41F-058F-4F23-84E3-5F4666C4FF1F"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d6e93b70-b91f-4457-a917-2c39f924fe2e"),
                LocationId = Guid.Parse("D8B89A7A-69C7-44E8-A66F-6EBBAE260293"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d71a7bfd-469f-47a5-a75a-26cddd862a8b"),
                LocationId = Guid.Parse("D7EBE506-8C6E-48C8-B4A8-6755E3000D76"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d768778f-7028-4b71-a55f-a08f1dd06d89"),
                LocationId = Guid.Parse("D5DC00C7-AB7A-4780-BEDC-8880649DF02B"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d778338d-4d01-4a42-9284-fbe5c8b4d2bf"),
                LocationId = Guid.Parse("7A1570E1-FDBC-4FB8-91F6-52F986C7F8E8"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d77dadc3-be7f-404e-8259-cb90df8e0949"),
                LocationId = Guid.Parse("49333D20-304E-4D2A-BEBC-A42F47B651EA"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d79f3d16-93dd-49a6-adc6-7bc8d74378a9"),
                LocationId = Guid.Parse("27DCFE30-7E43-419C-86DF-B228AAAB8D4E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d7e55cc5-6a73-4032-b795-5fc446918098"),
                LocationId = Guid.Parse("52D4F420-722D-4377-AF01-D23F0497FDF7"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d83a0153-b7b0-4634-a6bf-f14a65a57090"),
                LocationId = Guid.Parse("07069E49-04EA-4A65-819B-1FAA890DB93E"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d85de5e0-3aac-4011-aa85-a12b9b185200"),
                LocationId = Guid.Parse("935F7805-F97A-431A-82AB-D22B78360A22"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d8934d6a-0a97-4058-9ed4-c1cf3de5ff25"),
                LocationId = Guid.Parse("0559D6D7-E065-410B-A576-6E0B0A5607ED"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d899861c-5d3c-41f4-b022-458e566fe7b0"),
                LocationId = Guid.Parse("283AD546-A85F-4255-81AB-50E98637E3E2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d8d2ad70-9beb-487e-a870-f33fff73c77e"),
                LocationId = Guid.Parse("4C7AD03C-7405-4716-B790-E2BCE28C9211"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d9520b89-7b05-4007-afb3-1a42d83bb73b"),
                LocationId = Guid.Parse("B190DBA5-5A59-4FE4-86E6-2F36B3B3B79F"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d95da95a-99a9-4dfb-9a15-7e913b3d7cbb"),
                LocationId = Guid.Parse("B8C28602-86B4-4976-9B1E-4BF0DA4C6A62"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("d96fb5ed-f3ef-4288-a6ef-e88ded5d0bb1"),
                LocationId = Guid.Parse("B9C2C1B4-AB00-47EB-B0DC-69761553855E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("da0a09a5-38f0-42c5-a864-834099b70cf2"),
                LocationId = Guid.Parse("E85117E6-D664-459F-876C-C4E4802EE14A"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("da157218-a53e-4abc-9f9f-6b4c2396d78d"),
                LocationId = Guid.Parse("C2FD2AF3-20ED-4C34-87D7-5E5AF74103CF"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("da316dc9-7b8f-4314-b3d1-9860a977d70f"),
                LocationId = Guid.Parse("4AED0EF7-37F7-4689-A4D2-53243C9F07D2"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("da90fb21-5cfe-477a-a614-f3fa31a5e382"),
                LocationId = Guid.Parse("C39C13B0-952E-47A7-AC34-3671088C85E8"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("da97a26c-34e5-42e2-9015-f2cb18939c6a"),
                LocationId = Guid.Parse("2525632D-84E1-4132-B0A3-89EA47493C21"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("daa7d0c4-b9e8-428e-86fb-f800798f4ab0"),
                LocationId = Guid.Parse("AF462FAF-E46E-4D4D-92CB-A91656784F75"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("db0f2920-b213-4ea5-a16a-aa834c4d0964"),
                LocationId = Guid.Parse("1F89D904-BB7B-43FA-B96E-6391830F32F8"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("db5bcda4-ddca-4aa7-8329-4928e29f4e5a"),
                LocationId = Guid.Parse("3DDDC968-A475-456F-8E78-7121321CA048"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("db811e42-0225-4817-a56c-ba02e9110abc"),
                LocationId = Guid.Parse("69519D77-4997-439D-A5FA-767C5B8EF042"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("db8ce9f5-2ebe-4ec9-b57e-e26cde0cf29f"),
                LocationId = Guid.Parse("89DB6CCA-7A1B-4EC0-B961-DCA5CD490407"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("db98a8e1-21cd-4559-b01a-27caeb6805ca"),
                LocationId = Guid.Parse("D0B3019D-F0BE-4582-9D54-575D0EFB6BFA"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dbaa29c2-15ca-402a-8d7e-66278ee49e31"),
                LocationId = Guid.Parse("55D8C424-DCD2-40C9-9F47-C561ABED57A5"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dc68e68c-bad4-4b8e-85a1-08f00ca6a4b9"),
                LocationId = Guid.Parse("0DC28C08-E1B4-41D5-AE76-90E7EE3119F1"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dccba9cb-19a0-4753-82b2-27fe0dd30e4d"),
                LocationId = Guid.Parse("785143DD-735F-4217-B3AB-779FB0D6D6E9"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dd0fba17-33cc-47b9-a0d9-3f9a985309b2"),
                LocationId = Guid.Parse("540FF631-E684-4319-AA20-C6A0258493B2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dd534e99-bcbe-4a5d-8f3b-01bbbb8ebd98"),
                LocationId = Guid.Parse("0564C707-A89C-47BB-9986-C8F7730EFB56"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dd5e20a5-0ed1-45c0-8016-6bcd8c3be823"),
                LocationId = Guid.Parse("7BFFC99A-7806-4E4B-A3DC-A07D3A1D551F"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dd6ee088-92c6-4f9a-8212-49906b6efff0"),
                LocationId = Guid.Parse("7695C7CB-4217-464A-99DB-45CE4BA667B3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ddd8eb7f-6622-4264-b445-0423085f3b88"),
                LocationId = Guid.Parse("CF39F252-D10B-43F2-AFE2-2E43F9080EBD"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("de1ec913-f951-4295-9c02-5875e8b5d5f1"),
                LocationId = Guid.Parse("ADB65460-1CA3-497C-BA38-C4A61CAE2830"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("de4a4faa-61d6-4378-832e-526d679d52ce"),
                LocationId = Guid.Parse("18468C1C-EA00-469C-A68E-C77B84AFB15D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("de65a61b-42cc-48c5-86e5-fe49e9db572d"),
                LocationId = Guid.Parse("53A695CC-2160-4703-91E3-762FE5960607"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("de8b3a04-f723-4b05-9b4e-d20ade2492b2"),
                LocationId = Guid.Parse("2A07D47C-2BAD-4583-B610-ECB6BF696455"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dedc65ef-1e42-4fad-acb2-cf3c16b39740"),
                LocationId = Guid.Parse("E8472247-D628-4946-B626-513F42891850"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("df126a03-c075-46f4-93c2-c3d5ce49df83"),
                LocationId = Guid.Parse("F5FD6A14-5E4E-4852-B883-5D714E23B7B4"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("df38ef10-4f27-49c4-9a2d-601b80bb84e7"),
                LocationId = Guid.Parse("7CBC6DD2-1D03-4E37-9870-9586D3878C44"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("df671842-e725-4b5e-b1f8-dc09df34f68e"),
                LocationId = Guid.Parse("DB5D3208-9C41-4BC8-829C-09E839937170"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dfdca675-1201-40e6-b88c-99fee913ea34"),
                LocationId = Guid.Parse("4484BF82-E40D-4BF9-92F5-8E3A7C3C1663"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("dfe032e9-81a2-4992-b14d-271f087a7677"),
                LocationId = Guid.Parse("AADE6D2D-4FC1-4209-8F5D-F076439A894C"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e04e3366-10d9-4d6c-a574-d1c003e53c8f"),
                LocationId = Guid.Parse("DE8C2D47-DF2D-42F3-91F2-6DE87A5F54AF"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e0b6d67a-9b19-48f1-9cdd-83f33be319bb"),
                LocationId = Guid.Parse("D994B067-6BA1-48FB-AC11-E4D9CDA790FD"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e0c05c52-28c8-4e9b-a2b4-cd75c333d2ef"),
                LocationId = Guid.Parse("39505CF5-DF22-4CE4-B570-4064A7D53E2D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e1159667-7fe0-4106-b303-e7ae0d1f2796"),
                LocationId = Guid.Parse("2E178E58-43AA-4631-ACCD-42088A0320FD"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e147c4c7-1920-4001-9ded-3098169be5fc"),
                LocationId = Guid.Parse("A92FC2D0-3998-4340-956D-82CCCA1A76B5"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e1b9f632-5224-4111-87be-c5bd1027e03b"),
                LocationId = Guid.Parse("CC2B3FF3-50CA-4976-A7BF-AFCF2E42B1D0"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e22cbaf4-b962-484e-89f2-13ed15adf9e5"),
                LocationId = Guid.Parse("8B938948-E002-4713-9799-65657223D45A"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e29e00ad-174a-4e13-bff6-01972ebc0a27"),
                LocationId = Guid.Parse("CE9B62EE-1A09-4DBB-A1A0-F0932FB67006"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e2c386cc-1fb1-4203-a7f6-50d069d59650"),
                LocationId = Guid.Parse("DC1A550C-42D4-4FF0-B0FE-046DE3043931"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e34a2e67-20b8-4ca1-879a-61e1aebfd3c8"),
                LocationId = Guid.Parse("596E8780-D572-475A-8FBF-BFE76AFC293D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e34b422a-ae71-4755-ba43-336ce55ae734"),
                LocationId = Guid.Parse("537168DD-8762-4826-9EB9-EF9CBE0DE280"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e3eca82f-7fd6-4554-8698-d3a90eecd468"),
                LocationId = Guid.Parse("F810246A-7D82-42B5-9EF6-C7951EDAE851"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e42e27f1-7661-406e-9533-93d310db0200"),
                LocationId = Guid.Parse("2440ABFA-CE2F-4CAB-BE8A-EE37D353D105"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e46ca663-d408-4146-b90e-8e1afa280a9d"),
                LocationId = Guid.Parse("10A3042C-BBDF-47A5-A456-B75D367AE846"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e4bdf871-ace0-485d-a9b2-c71b0dbf6d37"),
                LocationId = Guid.Parse("3E8B4F5E-CBB5-4ED7-A924-C1CC41AA2AF9"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e4c9c69c-1b28-4a77-8601-862a40ce1144"),
                LocationId = Guid.Parse("C069E7CA-89DC-4CEE-AC5A-170300852625"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e56b5ee2-8e48-4aca-8891-53da079e5af9"),
                LocationId = Guid.Parse("676869D0-C9F1-49F2-93FA-9C98051AF837"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e5cf753b-4fa3-44be-a59c-540f244e6ec9"),
                LocationId = Guid.Parse("98531D93-0EAF-4070-8C8D-5296AB84F845"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e602f5dc-f1aa-4f00-b800-0b96477b73fe"),
                LocationId = Guid.Parse("04C01181-6181-4B11-97E8-4D3159559534"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 20.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e68f881f-f744-44a2-b9db-4b50ada94885"),
                LocationId = Guid.Parse("C338C9B2-1B4F-41E1-A875-A7B34FC2339E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e6a6b7f0-730c-4367-979d-3ca0314d70f8"),
                LocationId = Guid.Parse("14A17C74-EA45-43D9-AF82-E2FED309D072"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e6c28915-1cb5-4536-b739-dc9459e48581"),
                LocationId = Guid.Parse("01205D27-03C4-4A79-9919-161581A19728"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e6f8ea71-c360-49b9-b65b-628b79f244b8"),
                LocationId = Guid.Parse("4D7AE668-DE00-4846-A4E4-925A0211365F"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e737bcb3-26c9-4e05-a4a9-b08043ca266c"),
                LocationId = Guid.Parse("B20C7142-BFB6-4D9B-B36D-5BDAF276B397"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e780c7d8-16d8-46d1-868f-45f0660a59eb"),
                LocationId = Guid.Parse("9CCDB865-C3AE-4C5D-8D7A-AEC604F53F12"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e783a0dc-6f24-444b-a9b2-6b74123cb764"),
                LocationId = Guid.Parse("40C5BFC2-8B17-42A5-94A5-7950EA7B0541"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e7e48e1c-7fe8-47ff-9d3f-5cb7c734bf79"),
                LocationId = Guid.Parse("29BEBD68-0394-44B2-A20D-8811C4C1F1E0"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 23.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e85954c1-209a-44a8-878b-81c85af7f1a2"),
                LocationId = Guid.Parse("1D7BC5DE-5511-4715-B77F-2834C04B8F51"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e8c0a782-69d0-4e5d-b266-292ca4bb158d"),
                LocationId = Guid.Parse("2F923A4E-0DEA-4051-8A28-A124A2FC30D7"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e8c8c54c-2cf6-473a-94f1-25d06d10d9de"),
                LocationId = Guid.Parse("8420F8AB-BDC0-45EA-A780-FBA9374AAD30"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e8ebc59b-3e7e-4a0e-a5d7-49effdecd11c"),
                LocationId = Guid.Parse("7BF687BD-9674-477A-B5AC-BC65831C1190"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e8fe0926-18f5-4c59-823a-b1648f0233c8"),
                LocationId = Guid.Parse("56FF3BEE-B5AA-4E17-8FFF-D74FE222FCDF"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("e90d9ed7-2436-4a4c-ac29-aaf5840de3af"),
                LocationId = Guid.Parse("B06D9241-D74E-423C-8C58-0A55C31464A8"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("eb77b566-f830-4711-ae4c-941bf9a9e45b"),
                LocationId = Guid.Parse("E6D65AFC-A22D-4149-8327-C1B5F1226547"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("eb879230-112e-460c-ada3-7a0aa5752187"),
                LocationId = Guid.Parse("60028149-1BD9-4118-8B4D-7FE42FCCF79D"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ebdab098-9407-4e58-9d95-63fd1f67646f"),
                LocationId = Guid.Parse("C1C10C8A-D575-49FB-AC51-1C54A1AC01FB"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ebe2b389-cd84-4d44-9b93-a4a5c8c00da0"),
                LocationId = Guid.Parse("D78056AE-1032-4195-B701-F7FFDDC10A91"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ec306f5b-8856-44f8-900d-74a3a240050b"),
                LocationId = Guid.Parse("6CDCADD9-419B-488F-8ACC-70F5A22D9B31"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ec4fe6d3-5e11-49d5-9b9f-4cb7efd5326c"),
                LocationId = Guid.Parse("A7F072C9-4C1A-44C1-8624-543359B1D702"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ecb83a6e-f881-4c22-8312-644a0c353303"),
                LocationId = Guid.Parse("61E41F8A-84DB-4B80-BE4D-3DD111DA523D"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ed6675ad-d792-4f1b-a4b9-501209a55897"),
                LocationId = Guid.Parse("0CEA5D3B-C27F-41F2-ABF5-EBF578C835AC"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("eda28cb9-e539-46a1-8351-70b56afcf20f"),
                LocationId = Guid.Parse("7E42E88E-D4CE-4258-9921-3912A465D78E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("edf6770e-1dd6-4415-b49f-c90737a950ea"),
                LocationId = Guid.Parse("C4D0458C-91C5-4532-9D5C-086E69CA697E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ee2a7bcb-fa05-4f3d-bba3-4df3875c74fd"),
                LocationId = Guid.Parse("53EBD698-B02D-4BF9-B1C5-FB4D3F5F5B6F"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("eed9c74e-86da-4c83-ba45-e9ad94800f51"),
                LocationId = Guid.Parse("051DCE8E-5D80-45D0-8BD4-B284A68387E9"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 12.75m,
                LocationY = 3m,
                LocationZ = 25m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ef1a6cb4-34c4-4483-9493-043301cbee05"),
                LocationId = Guid.Parse("46E84B22-9A75-4614-8286-8BDEEB92054B"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ef4dd287-7921-4023-947d-336fbaf0d5eb"),
                LocationId = Guid.Parse("85B889FD-F5E1-4ABA-8A92-8AD71CD41AF4"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ef79cd6e-58f5-4033-8e7b-dbf4bb22a838"),
                LocationId = Guid.Parse("2F2DABE9-1963-45FE-9A62-167A8BCF64A5"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("efcc7068-8301-4ab0-8d7a-018681cdbe2c"),
                LocationId = Guid.Parse("76B4D77B-0832-4769-82CA-F2034B066AA0"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 28.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f09030d7-7640-4766-aa13-00a840114bc9"),
                LocationId = Guid.Parse("62E1997A-529E-42B3-B78C-69083345A8DB"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 31.75m,
                LocationY = 1m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f0ade03d-6bd4-4827-abbd-67bcc8d16a09"),
                LocationId = Guid.Parse("6C3D94E4-30A5-40A0-B386-5E6CFF161807"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f0be6e6d-9c28-4129-ae30-26f621c18441"),
                LocationId = Guid.Parse("F797B580-E4D4-48D7-90D0-8B59F188BFD6"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f1158f4e-1937-40dc-8910-78e9d5dcd9b8"),
                LocationId = Guid.Parse("1EE2CA7E-9ADB-4EA7-B47D-DAF5AF2DCE93"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 30.25m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f18e67b6-ca3f-4fbd-b3fb-824e8dddd08b"),
                LocationId = Guid.Parse("B4DBFF4E-0917-4DDF-AB0C-EB6B5A03F0E1"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f1a36773-76a9-4095-8c57-4bb43dc083a0"),
                LocationId = Guid.Parse("17135D1E-E9F5-474D-885F-1A7E931B99CB"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f2061ab4-9fe3-476d-afce-02a342f609b0"),
                LocationId = Guid.Parse("2332661F-DB93-4372-8E0A-99757A446730"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f25543af-30fa-4fb7-8fca-6fca4fffee17"),
                LocationId = Guid.Parse("C5ADBD98-9F0A-407C-BD98-2038F73AF617"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f25a3a83-fbc2-4fd8-9146-c7808050606b"),
                LocationId = Guid.Parse("12A36991-33DB-422E-8982-75BA8C6CB2EE"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f2854cb7-1f53-4a55-a946-0a175f73ce13"),
                LocationId = Guid.Parse("636D4B37-2651-4ED0-A651-DEDD57BCD3F2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f2f352d8-7cb1-4007-ae79-6f2d924d89bd"),
                LocationId = Guid.Parse("E5D1C4CF-B04A-4961-87F6-CFF20A8F6B60"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 20.75m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f3333a7f-1344-48c2-870d-f2f3902d0a1f"),
                LocationId = Guid.Parse("44C711C1-8FAA-48B4-9717-DC0F4FC7C8F2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f3716865-e709-4d57-8cbb-7e53fe30ad78"),
                LocationId = Guid.Parse("340AD20A-4A98-4770-AACF-091754EF5812"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f3bbad55-5cc9-483e-a9a6-ae08460fa9a7"),
                LocationId = Guid.Parse("88EABC6F-77A4-4C18-8863-1B4CC96927BF"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f3d79781-5928-486d-a9ef-810a44ddc4f5"),
                LocationId = Guid.Parse("05EF9450-AB58-4D58-B55C-53C79B56EA70"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f3ddbfc2-9bbd-4e92-9990-f433e5f40ed0"),
                LocationId = Guid.Parse("AFEAEE09-916A-46B4-8C9D-50F907ABE9AD"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f3e8b367-6cd0-4c51-a313-9f1f0dda36cf"),
                LocationId = Guid.Parse("F20C4E65-FCB3-47BB-BBA0-127F036DAACC"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 26.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f44e551c-46ea-416c-bc43-e7f34e832f98"),
                LocationId = Guid.Parse("2469C682-CF4B-446B-9FAD-76C94321A74E"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 1m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f4992064-05f8-4f63-8a48-0b7012b31142"),
                LocationId = Guid.Parse("02284D23-3AE8-4900-BB14-D5A1F728DE43"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f4d789b0-12d1-4fc0-a30c-4f91e5a26752"),
                LocationId = Guid.Parse("8AD74B14-D0B5-4CFF-B9A2-45028A3634D4"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 23m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f5e31b44-d5b1-4d14-ae14-6b4e6ee24bd4"),
                LocationId = Guid.Parse("19DC5D42-40A7-463C-A095-E3077EF52568"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 16m,
                LocationY = 3m,
                LocationZ = 29.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f6363096-169c-433b-bb3f-b003c58b09db"),
                LocationId = Guid.Parse("4B921B8F-D3C5-497F-AEBE-7B9BA05E2ABB"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f6c103b2-143b-4d94-8c14-47205cc3cafe"),
                LocationId = Guid.Parse("95D257E7-7ADF-4F8E-ADAD-04AF89F74BCB"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f6fbb5bf-6637-47bf-9b15-f0eedb168da8"),
                LocationId = Guid.Parse("D4BB1111-9E95-458A-9B84-B45012AF1DF3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 29m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f701ced1-4d5d-4f39-8f2d-a47a82d5fdbf"),
                LocationId = Guid.Parse("EA4845F3-36A9-4C11-A9F5-67ABC62D5C80"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f70ae6e4-8d11-4164-bad2-44052222aa59"),
                LocationId = Guid.Parse("0E4C6007-95D5-441A-86EE-0EB71CFAB417"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 17.5m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f892d770-1ece-49a8-b86e-9986f312d79b"),
                LocationId = Guid.Parse("DEF10E5A-802C-43E7-ACE8-2AB1377D87A4"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 20.75m,
                LocationY = 3m,
                LocationZ = 26m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f8a30a56-040c-4959-a6d9-5074e69ad9f1"),
                LocationId = Guid.Parse("2AF54033-F0B9-4A99-9862-B9038859B12E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 21.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f8d79a89-3763-49f5-8a11-0ff7a089e6e0"),
                LocationId = Guid.Parse("D57C5F10-9BA9-4AD8-B6CD-09EE15DF598A"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f92179de-2a46-4698-a536-6982548f2471"),
                LocationId = Guid.Parse("DBAD6DC1-95FF-4532-9012-404A3500A176"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 22.25m,
                LocationY = 1m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f92a19b8-9e16-4200-9bf3-333844abecf8"),
                LocationId = Guid.Parse("C18027B4-7BAA-4A08-A975-A993B0D0A11C"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 27m,
                LocationY = 1m,
                LocationZ = 27m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("f9aeb259-7626-4c34-82a1-f31888e91115"),
                LocationId = Guid.Parse("DC8C6EC5-05B1-4089-B872-DFBFD8BC88C5"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fafe572d-07c1-4839-b0b7-6979c76eae9b"),
                LocationId = Guid.Parse("369AF6DA-F29C-470A-9AB3-609F6263B20E"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 11.25m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fb0480d0-62a2-4d66-bf0d-2b6c8bbc5f17"),
                LocationId = Guid.Parse("971C6BF6-C36D-422E-B116-E77C7D8F33B9"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 31.75m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fb241da3-47c0-48eb-bc63-441b2aa24158"),
                LocationId = Guid.Parse("90354D6B-092F-401D-AF69-8C601BB1C49E"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 25.5m,
                LocationY = 3m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fb675cc3-a001-47ad-89fc-c311a61b74f4"),
                LocationId = Guid.Parse("80EC69B8-42CE-4A6F-BBF0-5FAAA081AC88"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fbb23e79-56f9-484f-b0ef-6173afefd4ba"),
                LocationId = Guid.Parse("DC9961EE-25C6-42F3-A448-69EB35D2B747"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 7.75m,
                LocationY = 3m,
                LocationZ = 24.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fbbaa83c-c830-4515-99a8-c04eb7e26ee6"),
                LocationId = Guid.Parse("C63696D0-5162-4CD9-A2AB-1487FACF7301"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fc099582-35bc-4969-8f39-f499023eecde"),
                LocationId = Guid.Parse("5A76F4B9-3896-4069-BD36-A0B224B3DED2"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 24m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fc608182-60e9-4097-9023-afefc5f673bf"),
                LocationId = Guid.Parse("55A91AC2-7B75-44EF-BA6C-FFF19469DFC3"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 25.5m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fc972459-829b-4ef5-a4d3-26d05aea376f"),
                LocationId = Guid.Parse("2F37D051-1B20-4836-8489-F0D3F2EBFC1F"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fdf076b0-ee99-41c2-9045-70bbce0636d4"),
                LocationId = Guid.Parse("FD4C1BCB-2C66-4CD1-B246-13CE29DDFD1C"),
                BuildingId = Guid.Parse("6B94BDFE-4158-4E98-816E-A3422816B2A3"),
                LocationX = 16m,
                LocationY = 1m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fe2158c7-164a-4c80-ac3f-e5b000989095"),
                LocationId = Guid.Parse("6019CB17-657B-41D1-8936-799A728AB0C6"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 27m,
                LocationY = 3m,
                LocationZ = 21m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fe831648-1c7a-4c66-82ee-9841a810b97e"),
                LocationId = Guid.Parse("87426395-54C6-421E-A62B-A43CFB53432A"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 35m,
                LocationY = 1m,
                LocationZ = 25.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fed9cbac-0dc5-4860-9a92-3b13531b50de"),
                LocationId = Guid.Parse("C4697D7C-AADC-4D69-B5C6-CDC0E8BDB9E0"),
                BuildingId = Guid.Parse("ACC4558E-9492-4EEC-9B31-9BDF31844740"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 27.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fee48bfa-ae5a-4da0-a172-cccd27944b72"),
                LocationId = Guid.Parse("628558AE-BBFA-413B-874E-14A9588C5F75"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 22m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("ffdae322-02b7-4637-916c-66391ee6dcca"),
                LocationId = Guid.Parse("F5B067F1-D645-41F4-BA4C-F565F86E532F"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 30.25m,
                LocationY = 1m,
                LocationZ = 28m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fff1d642-d1cc-41fd-9a3e-d7989834a6cb"),
                LocationId = Guid.Parse("5808139F-5FED-4D9A-806F-11F7259FDD11"),
                BuildingId = Guid.Parse("0D240376-68A1-4F9C-904B-7AE8A4CE5150"),
                LocationX = 22.25m,
                LocationY = 3m,
                LocationZ = 22.5m,
                CreatedDate = DateTime.Now,
            },
            new LocationCoordinate
            {
                Id = Guid.Parse("fff296dc-1252-4de8-9a0f-7e188667a604"),
                LocationId = Guid.Parse("E8E409D5-47C9-4C2C-958F-6A0255C4D131"),
                BuildingId = Guid.Parse("2CE97C33-78F5-46A9-94B8-668C53FBE49E"),
                LocationX = 11.25m,
                LocationY = 3m,
                LocationZ = 30m,
                CreatedDate = DateTime.Now,
            }

            );
    }
}
