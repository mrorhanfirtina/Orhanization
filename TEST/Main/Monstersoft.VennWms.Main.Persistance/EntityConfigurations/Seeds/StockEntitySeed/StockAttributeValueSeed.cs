using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.StockEntitySeed;

public class StockAttributeValueSeed : IEntityTypeConfiguration<StockAttributeValue>
{
    public void Configure(EntityTypeBuilder<StockAttributeValue> builder)
    {
        builder.HasData(
        new StockAttributeValue
        {
            Id = Guid.Parse("010CA53B-3D95-4809-A986-34820C14E105"),
            StockId = Guid.Parse("BF35AEC9-2510-419D-9A43-9959A5ABA873"),
            StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
            Value = "0",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("13E5B35A-2EDA-4796-A03D-A7B5FF8B58FE"),
            StockId = Guid.Parse("E519D3FF-8D8C-4EA2-92EE-2FF46C581897"),
            StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
            Value = "0",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("14A8DB5D-B09A-4338-8E0F-C3E2BA4C7399"),
            StockId = Guid.Parse("E261F800-03DB-4734-89FD-C49B40335EF4"),
            StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("283B68F2-9C7E-40A8-8BC0-012E9A13A7CA"),
            StockId = Guid.Parse("3DC167DB-2010-4B61-BFA3-2B3C200789D9"),
            StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
            Value = "AMBAR2",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("2C85A277-F230-4D04-BDCE-F1A0A1280481"),
            StockId = Guid.Parse("7792A3AC-494A-4A27-934E-99A8530C2640"),
            StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
            Value = "AMBAR1",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("2E7CA064-CFE3-4F34-841C-B64805C284A4"),
            StockId = Guid.Parse("3DC167DB-2010-4B61-BFA3-2B3C200789D9"),
            StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("376552E7-ACAE-43F2-A273-F7A07080C049"),
            StockId = Guid.Parse("E519D3FF-8D8C-4EA2-92EE-2FF46C581897"),
            StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
            Value = "AMBAR3",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("3A891EC6-A3BB-4279-BAF8-852D198A9F51"),
            StockId = Guid.Parse("3437D9FC-D394-45AB-8EC7-27CF622D8484"),
            StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("404ACE95-446B-42DB-9633-B77CD02801FC"),
            StockId = Guid.Parse("E261F800-03DB-4734-89FD-C49B40335EF4"),
            StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("497136C8-B61D-40B1-9FCC-A06050B720DF"),
            StockId = Guid.Parse("471B8449-2BA3-4F41-A726-6D9206F40AC0"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "1010802922",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("55954C97-1B74-4B1A-AF37-0B1BF36AA581"),
            StockId = Guid.Parse("3DC167DB-2010-4B61-BFA3-2B3C200789D9"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "1026338251",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("64FE86B8-57AC-429D-AF24-8AFF767D3C6E"),
            StockId = Guid.Parse("3437D9FC-D394-45AB-8EC7-27CF622D8484"),
            StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("7B8EDABF-AF9F-41F1-B03E-386309DD48F1"),
            StockId = Guid.Parse("64D678B6-67A6-4290-BB43-AF6A889EB383"),
            StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
            Value = "AMBAR1",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("8744EC55-C699-4FF7-AF38-998BEC2E9DFE"),
            StockId = Guid.Parse("3DC167DB-2010-4B61-BFA3-2B3C200789D9"),
            StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
            Value = "0",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("8DB58AEB-DB41-4EB1-B9B4-6E27BBBDF9B2"),
            StockId = Guid.Parse("E261F800-03DB-4734-89FD-C49B40335EF4"),
            StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
            Value = "AMBAR1",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("9022BAEC-46B7-471A-8639-AC39F76EF609"),
            StockId = Guid.Parse("7792A3AC-494A-4A27-934E-99A8530C2640"),
            StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
            Value = "0",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("9525E7F6-AA36-49E6-B880-2451DB977E40"),
            StockId = Guid.Parse("E261F800-03DB-4734-89FD-C49B40335EF4"),
            StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
            Value = "0",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("9A23A49E-68B9-4238-8859-5B74748E29B5"),
            StockId = Guid.Parse("471B8449-2BA3-4F41-A726-6D9206F40AC0"),
            StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
            Value = "AMBAR1",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("9CFFEC8D-3A35-4B5F-B43D-F10829DDE164"),
            StockId = Guid.Parse("471B8449-2BA3-4F41-A726-6D9206F40AC0"),
            StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("AE843F75-2689-47A5-ABB9-ACC67921E2EB"),
            StockId = Guid.Parse("E519D3FF-8D8C-4EA2-92EE-2FF46C581897"),
            StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("B046DA49-21D4-4E69-83F7-DEEBF9D68CC2"),
            StockId = Guid.Parse("BF35AEC9-2510-419D-9A43-9959A5ABA873"),
            StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
            Value = "AMBAR3",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("B18457C0-3E9B-496C-975A-19036F2AF535"),
            StockId = Guid.Parse("3DC167DB-2010-4B61-BFA3-2B3C200789D9"),
            StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("B1C5AB4E-4BF9-4B33-8A2A-62DD9212675F"),
            StockId = Guid.Parse("64D678B6-67A6-4290-BB43-AF6A889EB383"),
            StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
            Value = "0",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("C8D63FA3-3E9C-404B-98B7-DACBCA574FC9"),
            StockId = Guid.Parse("3437D9FC-D394-45AB-8EC7-27CF622D8484"),
            StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
            Value = "AMBAR2",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("CC6289F6-43C6-4EDC-B91E-06FA3BC3FE0C"),
            StockId = Guid.Parse("E519D3FF-8D8C-4EA2-92EE-2FF46C581897"),
            StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("CD9764E7-A133-4941-AA73-17CD3720C770"),
            StockId = Guid.Parse("471B8449-2BA3-4F41-A726-6D9206F40AC0"),
            StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
            Value = "0",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("D59290BC-0342-4BD8-9BDE-A00829DAD497"),
            StockId = Guid.Parse("3437D9FC-D394-45AB-8EC7-27CF622D8484"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "1010602536",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("D7F59124-5DD2-41AB-BD02-A84A8454C962"),
            StockId = Guid.Parse("E519D3FF-8D8C-4EA2-92EE-2FF46C581897"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "1187669652",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("E4B352D2-629B-45C5-AFB7-FCF247D3FD35"),
            StockId = Guid.Parse("471B8449-2BA3-4F41-A726-6D9206F40AC0"),
            StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
            Value = "2023-10-23",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("ECC86F9E-7AF5-4945-B9AA-6C7C85727272"),
            StockId = Guid.Parse("3437D9FC-D394-45AB-8EC7-27CF622D8484"),
            StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
            Value = "0",
            CreatedDate = DateTime.Now,
        },
        new StockAttributeValue
        {
            Id = Guid.Parse("FD2BF350-1457-423F-90AF-944C823EBF63"),
            StockId = Guid.Parse("E261F800-03DB-4734-89FD-C49B40335EF4"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "1163315515",
            CreatedDate = DateTime.Now,
        }

        );
    }
}
