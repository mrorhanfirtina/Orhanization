using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationProductConstraintSeed : IEntityTypeConfiguration<LocationProductConstraint>
{
    public void Configure(EntityTypeBuilder<LocationProductConstraint> builder)
    {
        builder.HasData(
            new LocationProductConstraint
            {
                Id = Guid.Parse("0170ac21-8d35-43ce-a415-cb7022c43192"),
                LocationId = Guid.Parse("1EB23889-EB0E-47D9-83E6-A2D268DEC092"),
                ItemUnitId = Guid.Parse("77CB5BEF-0AAD-470E-B697-06C6F1587787"),
                Capacity = 120m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("019e5df2-449d-4e7a-8aac-79a6f6ed94a4"),
                LocationId = Guid.Parse("0DEA6F6E-F1D3-4D37-B675-803371C3E260"),
                ItemUnitId = Guid.Parse("B745B05E-3CA7-4E8E-A500-B266834849E9"),
                Capacity = 1080m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("02c027a7-b1d9-4107-93b4-e1f5910e498e"),
                LocationId = Guid.Parse("0E585062-8837-4FAD-9DC4-083781326350"),
                ItemUnitId = Guid.Parse("271A11C0-82B3-4D01-82C3-067A48646031"),
                Capacity = 12m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("031c2aa4-8254-4df1-81b0-5f1b69eb11ce"),
                LocationId = Guid.Parse("233E4ECA-8BAE-4FE7-B1F0-5678E862F364"),
                ItemUnitId = Guid.Parse("F86F5B6E-D11E-41DA-A6DF-621569B49FA8"),
                Capacity = 576m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("08eca51a-0293-478d-8c14-cec590bf7836"),
                LocationId = Guid.Parse("0DEA6F6E-F1D3-4D37-B675-803371C3E260"),
                ItemUnitId = Guid.Parse("BFA5C78D-25C3-4B51-9384-6E6D519EDD5C"),
                Capacity = 72m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("1192627a-136a-4096-80d5-2a2a9b703cfa"),
                LocationId = Guid.Parse("0E585062-8837-4FAD-9DC4-083781326350"),
                ItemUnitId = Guid.Parse("057D7A7F-F8DF-47C6-8994-1FEAA76D5528"),
                Capacity = 1m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("1b325336-6fdb-4225-81b1-3a237a6e0688"),
                LocationId = Guid.Parse("1EB23889-EB0E-47D9-83E6-A2D268DEC092"),
                ItemUnitId = Guid.Parse("271A11C0-82B3-4D01-82C3-067A48646031"),
                Capacity = 12m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("1ba10d54-60d6-4b64-a734-69219188bc43"),
                LocationId = Guid.Parse("0E40E16E-3B62-4543-BE47-A6C949F53C4E"),
                ItemUnitId = Guid.Parse("4B5E24AA-08CB-4F66-A738-57F0E648BF3C"),
                Capacity = 720m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("1e93c365-d80b-41f1-b4b1-a5d5cd8ded98"),
                LocationId = Guid.Parse("0DC28C08-E1B4-41D5-AE76-90E7EE3119F1"),
                ItemUnitId = Guid.Parse("C2B7D00B-8560-4CDF-AEAB-E27324124643"),
                Capacity = 480m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("251e4c64-dd37-46ac-b86a-de2d270db686"),
                LocationId = Guid.Parse("0DC28C08-E1B4-41D5-AE76-90E7EE3119F1"),
                ItemUnitId = Guid.Parse("7F93FB7D-BA39-4782-9355-06AA989554E8"),
                Capacity = 24m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("44a3d38e-154b-41de-aa70-5f06813113f5"),
                LocationId = Guid.Parse("0E585062-8837-4FAD-9DC4-083781326350"),
                ItemUnitId = Guid.Parse("AB35D516-0B5C-4C8B-B97E-2B07A455056B"),
                Capacity = 24m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("4fe5abe0-fc46-441a-a1e7-25cd3a12d1cf"),
                LocationId = Guid.Parse("0EFC4F0A-52A3-4B1C-BF12-50CD20DAD3CB"),
                ItemUnitId = Guid.Parse("4AF29841-AF65-408C-AB6B-B39C9B0C63B6"),
                Capacity = 1m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("590a65b1-a419-4f08-aeed-5449a8b3ab77"),
                LocationId = Guid.Parse("0DEA6F6E-F1D3-4D37-B675-803371C3E260"),
                ItemUnitId = Guid.Parse("91DE61F9-069B-442A-8AC6-48A111741589"),
                Capacity = 1m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("6e587d79-8784-4264-a603-c73e0833160b"),
                LocationId = Guid.Parse("233E4ECA-8BAE-4FE7-B1F0-5678E862F364"),
                ItemUnitId = Guid.Parse("08E1CE19-21B3-4743-98F6-068B73C15FD4"),
                Capacity = 24m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("6fce2106-fb77-4ea0-92db-96ebdd69be69"),
                LocationId = Guid.Parse("233E4ECA-8BAE-4FE7-B1F0-5678E862F364"),
                ItemUnitId = Guid.Parse("406489A7-6BC1-4892-904D-AD83074B4A9B"),
                Capacity = 1m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("8109eb7b-6f50-4689-ba94-1242eb6f2b4c"),
                LocationId = Guid.Parse("0E40E16E-3B62-4543-BE47-A6C949F53C4E"),
                ItemUnitId = Guid.Parse("DDA3D5CE-D040-4C0C-9158-647DDA5AE480"),
                Capacity = 24m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("8279ccf1-e33f-413e-b900-07aba2edecba"),
                LocationId = Guid.Parse("0E585062-8837-4FAD-9DC4-083781326350"),
                ItemUnitId = Guid.Parse("77CB5BEF-0AAD-470E-B697-06C6F1587787"),
                Capacity = 120m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("85b7bcee-f10c-4966-8b31-79c6e3cb480b"),
                LocationId = Guid.Parse("0DEA6F6E-F1D3-4D37-B675-803371C3E260"),
                ItemUnitId = Guid.Parse("8A3D8964-F891-40F3-974C-84EE07B1AFA0"),
                Capacity = 36m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("8da84b23-3464-4c5d-bcf3-9966470fbd35"),
                LocationId = Guid.Parse("0EFC4F0A-52A3-4B1C-BF12-50CD20DAD3CB"),
                ItemUnitId = Guid.Parse("B63935F6-79F4-4020-8A92-8784AFC2A427"),
                Capacity = 1080m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("91db39a9-76b0-499f-9739-8bfe69dae50e"),
                LocationId = Guid.Parse("0E40E16E-3B62-4543-BE47-A6C949F53C4E"),
                ItemUnitId = Guid.Parse("3CEB0F57-5AAB-4E4E-AB36-6B6A153AC0A1"),
                Capacity = 48m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("93535609-6d56-4acf-9c7c-4da1eb99bae8"),
                LocationId = Guid.Parse("0E835AB7-2E8D-42DD-8CF3-1DDBEA7F0477"),
                ItemUnitId = Guid.Parse("1946BE1B-160C-4313-8660-B081A6E4264D"),
                Capacity = 24m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("97063d1f-bc1d-481a-a6a2-735310945d69"),
                LocationId = Guid.Parse("0DC28C08-E1B4-41D5-AE76-90E7EE3119F1"),
                ItemUnitId = Guid.Parse("97DB5A39-C55E-4F3C-8694-D97421AB1EB9"),
                Capacity = 1m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("9c0ec26c-9b5e-419c-85f2-5a41ee3477d4"),
                LocationId = Guid.Parse("1EB23889-EB0E-47D9-83E6-A2D268DEC092"),
                ItemUnitId = Guid.Parse("AB35D516-0B5C-4C8B-B97E-2B07A455056B"),
                Capacity = 24m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("9d4e99a8-9a57-43bb-a7e1-1b0c77950b7e"),
                LocationId = Guid.Parse("0EFC4F0A-52A3-4B1C-BF12-50CD20DAD3CB"),
                ItemUnitId = Guid.Parse("A44FE6BE-06F6-43E6-811F-36A801925F6F"),
                Capacity = 36m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("9f45ca06-7123-493f-a6ed-80e324503bef"),
                LocationId = Guid.Parse("0E835AB7-2E8D-42DD-8CF3-1DDBEA7F0477"),
                ItemUnitId = Guid.Parse("03C90EE2-E782-4519-9FBE-1F1041093147"),
                Capacity = 48m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("b33c1b13-c049-4526-abc0-0e2b6e4965e4"),
                LocationId = Guid.Parse("1EB23889-EB0E-47D9-83E6-A2D268DEC092"),
                ItemUnitId = Guid.Parse("057D7A7F-F8DF-47C6-8994-1FEAA76D5528"),
                Capacity = 1m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("bf5da0e4-2295-4602-85a7-0f7ba4660069"),
                LocationId = Guid.Parse("0DC28C08-E1B4-41D5-AE76-90E7EE3119F1"),
                ItemUnitId = Guid.Parse("6D6F4058-D76F-4EFE-AC48-F70024D0692C"),
                Capacity = 48m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("c3ad0b7b-8605-4bf1-b459-4a3d927d1ac4"),
                LocationId = Guid.Parse("0E835AB7-2E8D-42DD-8CF3-1DDBEA7F0477"),
                ItemUnitId = Guid.Parse("43D4F2DC-DB42-4040-8EF2-EDC0C2759C8B"),
                Capacity = 1m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("d45a2abe-2888-4491-a0f6-fabfc93150a9"),
                LocationId = Guid.Parse("0E40E16E-3B62-4543-BE47-A6C949F53C4E"),
                ItemUnitId = Guid.Parse("C2BFCD25-5116-4E4B-A182-9917CB13559F"),
                Capacity = 1m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("e37259f4-6fb5-482f-9b54-d831ebbdd868"),
                LocationId = Guid.Parse("0EFC4F0A-52A3-4B1C-BF12-50CD20DAD3CB"),
                ItemUnitId = Guid.Parse("36D858F1-B76C-4C53-B724-A6FC39B9B62D"),
                Capacity = 72m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("e57b2e4d-15f3-4c8a-bd7d-f6afa6c715f2"),
                LocationId = Guid.Parse("0E835AB7-2E8D-42DD-8CF3-1DDBEA7F0477"),
                ItemUnitId = Guid.Parse("68527238-83B6-468A-B57F-47C51E8CF400"),
                Capacity = 864m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            },
            new LocationProductConstraint
            {
                Id = Guid.Parse("f941f961-3230-4410-9908-884f870f1cee"),
                LocationId = Guid.Parse("233E4ECA-8BAE-4FE7-B1F0-5678E862F364"),
                ItemUnitId = Guid.Parse("A7F0B97C-8659-458E-84DB-0BDC430EB2CE"),
                Capacity = 48m,
                ReplenishmentTreshold = 20m,
                ExceedCapacityMargin = 5m,
                CreatedDate = DateTime.Now,
            }
        );
    }
}
