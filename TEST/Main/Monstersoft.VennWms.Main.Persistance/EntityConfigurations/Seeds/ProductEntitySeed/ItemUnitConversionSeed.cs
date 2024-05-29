using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ItemUnitConversionSeed : IEntityTypeConfiguration<ItemUnitConversion>
{
    public void Configure(EntityTypeBuilder<ItemUnitConversion> builder)
    {
        builder.HasData(
            new ItemUnitConversion
            {
                Id = Guid.Parse("02c0ffb5-68e3-4d0a-88c2-a7141cb93b50"),
                ReferenceItemUnitId = Guid.Parse("3B7A2E3C-653D-4ABF-B137-A953C66A03CB"),
                ConvertedItemUnitId = Guid.Parse("DFC1CC60-B199-4D05-AB23-0ED7113AC974"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("0328286c-800f-4144-8745-324f5d83b381"),
                ReferenceItemUnitId = Guid.Parse("5533182D-8197-40E7-8036-F3D891D36FA1"),
                ConvertedItemUnitId = Guid.Parse("9E13C0E0-7B1F-463C-AC3F-750B3F8E389F"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("048a87ad-32c9-4337-bc60-ed6e9fe721ef"),
                ReferenceItemUnitId = Guid.Parse("3A741DA9-0B50-4946-8032-5CACC8A568DB"),
                ConvertedItemUnitId = Guid.Parse("D15267BB-D7F5-438C-B194-847032C8513B"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("082c5b09-01cb-4615-b722-8c4568f6644b"),
                ReferenceItemUnitId = Guid.Parse("9859D458-6E4D-4211-8067-989EF403AF86"),
                ConvertedItemUnitId = Guid.Parse("C81EFF75-5756-446E-9881-6C7CCA16EA58"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("08426aa6-0bc2-43a5-9aef-ceeda6e1d8a8"),
                ReferenceItemUnitId = Guid.Parse("C70F2FE6-40E6-42E5-A92F-5B3FAB5E62D7"),
                ConvertedItemUnitId = Guid.Parse("AE1A4504-488D-40F8-92D1-9B0E842949FA"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("09769206-b1f9-444a-b18c-b4cc913037f7"),
                ReferenceItemUnitId = Guid.Parse("1B309B2A-0DE4-41D5-97B7-4BB88AFFB97F"),
                ConvertedItemUnitId = Guid.Parse("065BC0C2-CCA7-4568-ACC9-9F7F8BE2109F"),
                ConversionQuantity = 360m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("09791dec-e3a0-4c23-9996-0d2db26feb39"),
                ReferenceItemUnitId = Guid.Parse("6880CFC3-EBE9-41F4-AC06-12BC0B7FCE7B"),
                ConvertedItemUnitId = Guid.Parse("FC843637-9E15-43E2-A2C8-39AABA7CC9A1"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("09965964-45c6-4214-96a6-98e5eebf77da"),
                ReferenceItemUnitId = Guid.Parse("77F13E21-DDE4-4C37-8179-F3EE440947FA"),
                ConvertedItemUnitId = Guid.Parse("EFE00027-DB73-4A93-B9C1-2A696FA2167D"),
                ConversionQuantity = 432m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("0a0a1999-da83-4de7-9965-cbed5c381211"),
                ReferenceItemUnitId = Guid.Parse("49BD3834-B727-4977-98CF-61A2766EBA37"),
                ConvertedItemUnitId = Guid.Parse("DBA2FA1D-9E09-4647-AC2B-91D01F761394"),
                ConversionQuantity = 48m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("0b912b08-bea3-49b4-9423-d1c0779d7c93"),
                ReferenceItemUnitId = Guid.Parse("20426CEE-01CF-40AE-AA30-8760B8FBC8C1"),
                ConvertedItemUnitId = Guid.Parse("EFE00027-DB73-4A93-B9C1-2A696FA2167D"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("0cc46d57-c454-4d94-8818-c763e2c3605d"),
                ReferenceItemUnitId = Guid.Parse("25CA555F-9369-44FA-98B2-B36961C3DE97"),
                ConvertedItemUnitId = Guid.Parse("84A25647-6938-49F8-BF14-6311F925A965"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("0d36db35-b0c9-4bcd-a7a7-bc35454c58bf"),
                ReferenceItemUnitId = Guid.Parse("A9162521-4028-4929-AD83-1C4EE4C4C481"),
                ConvertedItemUnitId = Guid.Parse("8CE82425-296E-41C2-82FD-0A36DEEB6023"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("0d67d7f6-ff59-4deb-98b2-7d0d65d2d4c1"),
                ReferenceItemUnitId = Guid.Parse("0D2D0F4A-D498-4B03-8D4A-42F430ACFD33"),
                ConvertedItemUnitId = Guid.Parse("07076D2C-EFCE-4CB2-A31E-A3DBF7FE4A97"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("0eb806a5-b9f9-4297-b12f-8e3f11baedb8"),
                ReferenceItemUnitId = Guid.Parse("234B6173-4C04-48D4-8D87-11F5C69D47FF"),
                ConvertedItemUnitId = Guid.Parse("D56442E3-5858-4A1B-86D7-4A76F09A030A"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("0fa7172e-f07f-4b82-9eb1-d2b8fcce0d7a"),
                ReferenceItemUnitId = Guid.Parse("E5EF573B-5129-4354-B021-BBFB6CEBF38B"),
                ConvertedItemUnitId = Guid.Parse("C360A841-3358-424F-8B97-2AD2D6D9D06C"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("0fe08528-5f9a-490e-b471-06d30c5db43c"),
                ReferenceItemUnitId = Guid.Parse("89919F4A-7851-40B1-BF16-BE6C537D10EF"),
                ConvertedItemUnitId = Guid.Parse("99BFF122-E390-45ED-A1AB-CC225A1C00C3"),
                ConversionQuantity = 576m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("103f0bfb-2fe5-4dec-acc9-9568181a8837"),
                ReferenceItemUnitId = Guid.Parse("C8E56560-8BB9-4E82-89BB-FE482EAEF9C3"),
                ConvertedItemUnitId = Guid.Parse("1C40B21E-8F56-497B-81F1-A6932C8D1FCD"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("1099c6fa-a67b-41c4-a29b-4ff017ab8d93"),
                ReferenceItemUnitId = Guid.Parse("595E62F0-EC10-41DB-B460-901119A806E0"),
                ConvertedItemUnitId = Guid.Parse("C6BE66B8-4BF9-4A31-BB53-333E483EB10B"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("146fb2fe-91c1-4ed9-989b-185a7c9a8c3c"),
                ReferenceItemUnitId = Guid.Parse("6A1EEC39-1EC4-4554-BC31-5082CFC7AE8F"),
                ConvertedItemUnitId = Guid.Parse("D330EAED-1555-4E56-A18A-E5C73120A559"),
                ConversionQuantity = 360m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("1539adde-33c2-406f-97f1-586d4be34c2b"),
                ReferenceItemUnitId = Guid.Parse("F100828F-56E8-44CA-9F62-72716C2048F6"),
                ConvertedItemUnitId = Guid.Parse("5ADCD688-797D-455F-86A1-599BB1680C7D"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("15913d93-46cd-4517-bd4a-d4ade8d5bc06"),
                ReferenceItemUnitId = Guid.Parse("6357B0CE-4935-4570-96F5-26E3DBCBA645"),
                ConvertedItemUnitId = Guid.Parse("A6689121-2A94-49EF-B5A7-3BE915BEB1EF"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("184fd055-28ae-4f94-984a-101416ccc398"),
                ReferenceItemUnitId = Guid.Parse("BF935C1A-370A-4535-918A-5B1958392AC7"),
                ConvertedItemUnitId = Guid.Parse("84A25647-6938-49F8-BF14-6311F925A965"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("1a4b928b-7c5c-4d5b-8bad-8b19b9656ff0"),
                ReferenceItemUnitId = Guid.Parse("4A3F580F-0CD5-451E-A8EA-C727DAAC134D"),
                ConvertedItemUnitId = Guid.Parse("9AF3C5A6-CCFD-4FFD-90A5-DED3CCEA3D58"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("1b251575-1581-4392-8a91-5de06092fab7"),
                ReferenceItemUnitId = Guid.Parse("C8F0ACE9-5CAA-4F83-ACE2-42E56751711D"),
                ConvertedItemUnitId = Guid.Parse("11B79889-EC4D-4407-83B6-9A8993A65791"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("1bbe9a50-7992-40e2-b7c7-9c96c46d204a"),
                ReferenceItemUnitId = Guid.Parse("1AFBE70C-9EF6-4FCC-BBFD-9B2F49BA9365"),
                ConvertedItemUnitId = Guid.Parse("1A0160CC-09BF-403E-B53B-474D8CB00DFE"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("1bf5bf38-6991-4b06-ab68-1a1cf903d74d"),
                ReferenceItemUnitId = Guid.Parse("55349CA6-285A-4B10-8ED2-3BC2246F319B"),
                ConvertedItemUnitId = Guid.Parse("4E8326B4-07D3-4C1D-8014-9FC57AE686F2"),
                ConversionQuantity = 480m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("1d2a9871-040f-4bed-a8b8-4c4d0ae339e1"),
                ReferenceItemUnitId = Guid.Parse("6E97A116-9D7A-41ED-B273-B85F798C1EC0"),
                ConvertedItemUnitId = Guid.Parse("B165AAFA-90A7-41FA-9508-1C56FCE5C1AF"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("1db21816-fe89-4a49-b942-703794f452a5"),
                ReferenceItemUnitId = Guid.Parse("A78B4FEF-B67E-44AE-837A-DEFC6248136B"),
                ConvertedItemUnitId = Guid.Parse("6656AB3D-F7E5-4A43-BC04-E16B582A6E19"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("1fd67b01-838d-46d8-b156-2aeb0a77a250"),
                ReferenceItemUnitId = Guid.Parse("6B59EE3E-774A-4BF3-90B1-539E6FA0C6DE"),
                ConvertedItemUnitId = Guid.Parse("D96E008A-1476-43BF-B74B-C6CA9E90B64E"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("2009c943-d5dd-469b-aeff-9fc3af16ee1a"),
                ReferenceItemUnitId = Guid.Parse("5EE8D5DB-CAAF-4FC7-8469-4B2213255BCA"),
                ConvertedItemUnitId = Guid.Parse("7016D365-EE5D-4C28-B139-1C418CC1FA07"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("21352566-6db4-4fcf-87f5-494be07033a6"),
                ReferenceItemUnitId = Guid.Parse("CDDE7FE2-9106-4C11-94C8-B16C4D61BDB0"),
                ConvertedItemUnitId = Guid.Parse("4FCA6E54-1479-4B32-91E2-3CA485B920EB"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("22125572-f500-4462-ab25-eb6906797c9c"),
                ReferenceItemUnitId = Guid.Parse("AB35D516-0B5C-4C8B-B97E-2B07A455056B"),
                ConvertedItemUnitId = Guid.Parse("77CB5BEF-0AAD-470E-B697-06C6F1587787"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("253efc9b-c80e-4ba5-aaa6-35049a196d1b"),
                ReferenceItemUnitId = Guid.Parse("3300C267-DAE4-40D7-BD3C-C6D9B4F6A0AA"),
                ConvertedItemUnitId = Guid.Parse("C81EFF75-5756-446E-9881-6C7CCA16EA58"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("25476a00-56c6-4b4c-af21-69f29ebfeb52"),
                ReferenceItemUnitId = Guid.Parse("421DCA12-76C0-48E1-9B87-C93391E1BEF8"),
                ConvertedItemUnitId = Guid.Parse("A6CE04C3-871C-4C69-9BE6-10544155248E"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("2563ebb9-abf6-445e-b87f-3d22ad94a411"),
                ReferenceItemUnitId = Guid.Parse("353AE184-1737-408D-8DA3-A9A52A3281D7"),
                ConvertedItemUnitId = Guid.Parse("299416C9-CE42-4D44-801C-C0EAF7E95B4F"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("26c16c6a-91a9-4fad-911b-2f76ea3636dc"),
                ReferenceItemUnitId = Guid.Parse("3A44E9C6-ED85-45BC-AB43-25B00F12360B"),
                ConvertedItemUnitId = Guid.Parse("39DA5472-7CBF-45F4-B607-14F223F61BAD"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("26dd12ae-c814-4dba-bec5-0f657602c538"),
                ReferenceItemUnitId = Guid.Parse("2A63FB0D-1D0E-4FC5-AC09-705F99AB970A"),
                ConvertedItemUnitId = Guid.Parse("70915CD3-8277-432F-9568-BE72C8EA8D0D"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("26efb46a-ade7-4a2c-b9b1-12e43bb1d3aa"),
                ReferenceItemUnitId = Guid.Parse("B1ADA7C9-A36C-4D6C-B1D1-F3480F24D67C"),
                ConvertedItemUnitId = Guid.Parse("39DA5472-7CBF-45F4-B607-14F223F61BAD"),
                ConversionQuantity = 1080m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("277694a9-2597-4f41-a55a-f5c16a513264"),
                ReferenceItemUnitId = Guid.Parse("52E17CAA-F50B-4CC6-B889-B95E3AC39F41"),
                ConvertedItemUnitId = Guid.Parse("E8483812-85FF-49AC-835D-59A16DD9DC81"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("28efb94d-9525-4474-be9b-35a6a496ebd3"),
                ReferenceItemUnitId = Guid.Parse("CF0F63C9-BC5C-4B46-ADB1-42AF5D7C48FA"),
                ConvertedItemUnitId = Guid.Parse("D96E008A-1476-43BF-B74B-C6CA9E90B64E"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("2ab938d4-b569-4706-9489-b421c3af9c96"),
                ReferenceItemUnitId = Guid.Parse("2EFBBF5C-C20B-4D0C-A09D-7B64FF9AED59"),
                ConvertedItemUnitId = Guid.Parse("19192C15-01EA-4C21-9D8B-AD77D51E6A84"),
                ConversionQuantity = 120m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("2ba73904-9f62-4ddd-92a1-ff45e889238f"),
                ReferenceItemUnitId = Guid.Parse("8E23D72A-CECA-4086-9677-E00D62FE558D"),
                ConvertedItemUnitId = Guid.Parse("F4AF1877-493C-4D46-A2AE-BBACE0FFE337"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("2d41eb9c-ad6a-4cca-8af1-868efc72906d"),
                ReferenceItemUnitId = Guid.Parse("15A4B699-E45E-4F3E-A732-F71E76591E36"),
                ConvertedItemUnitId = Guid.Parse("146DF446-ED3B-435B-8E11-9D4E57EBC025"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("2e3c2cdc-02e8-4f4b-a22e-669dff54a2ab"),
                ReferenceItemUnitId = Guid.Parse("794042C0-5BFA-4A9F-B39F-0F7B78F1C813"),
                ConvertedItemUnitId = Guid.Parse("549E4987-498F-44B8-B9F3-37C702C28F99"),
                ConversionQuantity = 432m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("2f55626d-7e1a-456f-b6ef-47a3470003ed"),
                ReferenceItemUnitId = Guid.Parse("75517A97-7876-4A7E-B20F-4E37C99468D5"),
                ConvertedItemUnitId = Guid.Parse("7016D365-EE5D-4C28-B139-1C418CC1FA07"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("2f8a63e8-e8b4-4802-8b3e-9af86c4b7704"),
                ReferenceItemUnitId = Guid.Parse("DCFE694A-1ABD-4567-AF23-75925EBD1AF7"),
                ConvertedItemUnitId = Guid.Parse("A32B5522-B666-489A-8751-F36E35F329B6"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3099e918-ca68-4882-9129-c692077d09eb"),
                ReferenceItemUnitId = Guid.Parse("0D3ACE8E-04D3-4733-A359-76E13191E054"),
                ConvertedItemUnitId = Guid.Parse("6656AB3D-F7E5-4A43-BC04-E16B582A6E19"),
                ConversionQuantity = 480m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("30b11a71-f3b0-483b-875d-9fbc655eaff5"),
                ReferenceItemUnitId = Guid.Parse("33B554FF-7599-4710-A3FF-0EB1D8C52259"),
                ConvertedItemUnitId = Guid.Parse("1A0160CC-09BF-403E-B53B-474D8CB00DFE"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3114b29f-00fb-474f-9517-f556448f72e0"),
                ReferenceItemUnitId = Guid.Parse("3F381194-3520-4EE5-8920-5747E19E2505"),
                ConvertedItemUnitId = Guid.Parse("BCD8966A-878A-4C12-9682-F8E27319C013"),
                ConversionQuantity = 8m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("31bfcdff-74ac-422b-9a3b-c61980e38368"),
                ReferenceItemUnitId = Guid.Parse("C56B2047-372A-4E57-B5E0-52C16F0D6E79"),
                ConvertedItemUnitId = Guid.Parse("E8483812-85FF-49AC-835D-59A16DD9DC81"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("31ec063f-d51b-49ab-80f7-984ddc509016"),
                ReferenceItemUnitId = Guid.Parse("3D591290-FC42-4958-817C-93907AA54857"),
                ConvertedItemUnitId = Guid.Parse("1C40B21E-8F56-497B-81F1-A6932C8D1FCD"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("32aae1ab-0888-4ab6-9f75-1f4fdb501f2c"),
                ReferenceItemUnitId = Guid.Parse("3F93FCC4-3241-4E1D-B04A-3F6EFEC6D15E"),
                ConvertedItemUnitId = Guid.Parse("AA7C8C4E-11D0-42DA-988D-FD9741E10BE5"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3478a12e-7222-4e97-a7d9-526eda3b42a4"),
                ReferenceItemUnitId = Guid.Parse("F5F4FC1B-9527-49CD-BEE1-2B3CB29BC43E"),
                ConvertedItemUnitId = Guid.Parse("7016D365-EE5D-4C28-B139-1C418CC1FA07"),
                ConversionQuantity = 1296m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("358cd91a-4756-4b23-ad7e-a9ab4367190c"),
                ReferenceItemUnitId = Guid.Parse("08E1CE19-21B3-4743-98F6-068B73C15FD4"),
                ConvertedItemUnitId = Guid.Parse("F86F5B6E-D11E-41DA-A6DF-621569B49FA8"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("36f23785-479c-4012-bd83-44a7a2ce99ea"),
                ReferenceItemUnitId = Guid.Parse("CE835918-80AA-4818-A79D-1A58BC084AF1"),
                ConvertedItemUnitId = Guid.Parse("9C5795CD-26B2-4856-801D-65EBDA067997"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("39b46581-64b9-4db4-893a-46c33e35e459"),
                ReferenceItemUnitId = Guid.Parse("3E453FC6-D8F0-4B28-82EA-6AC95FA6E1B5"),
                ConvertedItemUnitId = Guid.Parse("3645C383-3582-40B5-9223-B2475B556FA4"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3a6c4437-f915-4333-bab7-fcd618e617c7"),
                ReferenceItemUnitId = Guid.Parse("532CBEF2-A0B1-41A7-95A8-A5F46197C793"),
                ConvertedItemUnitId = Guid.Parse("5ADCD688-797D-455F-86A1-599BB1680C7D"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3b06e6eb-519b-4c3f-be92-3f88e7632da3"),
                ReferenceItemUnitId = Guid.Parse("66CD2C6A-77C4-4203-A671-E6BECCD5A6BA"),
                ConvertedItemUnitId = Guid.Parse("CCFACEFC-73AF-46C8-BF6B-EE93A5445A67"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3be11d7d-b0a9-4176-9483-6ffe8fcfe56b"),
                ReferenceItemUnitId = Guid.Parse("79A9294F-62EC-4313-A081-B8C5FD8169FE"),
                ConvertedItemUnitId = Guid.Parse("56BFD555-E5DD-459A-B6DF-E8FE4442FF3B"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3cff54e8-0ed8-40b1-b54a-f2a4000ed25d"),
                ReferenceItemUnitId = Guid.Parse("E399E6E9-8987-4A0D-B134-424BF8FA3836"),
                ConvertedItemUnitId = Guid.Parse("1C40B21E-8F56-497B-81F1-A6932C8D1FCD"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3d394c3b-40e3-4694-a650-57c873aa6762"),
                ReferenceItemUnitId = Guid.Parse("DE50E31B-1E36-4801-92A3-3F1CCC22B6CB"),
                ConvertedItemUnitId = Guid.Parse("13BCDDA6-2FBA-4848-BF3C-EF01094A296E"),
                ConversionQuantity = 432m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3ddaab08-6b6e-4432-a5b9-ff815611ed6b"),
                ReferenceItemUnitId = Guid.Parse("406C7FD9-5AC6-4BDB-B2FB-AF62F8BBA872"),
                ConvertedItemUnitId = Guid.Parse("B3A652D7-5CE5-42FD-A776-880294446DEA"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3e957922-daa4-4c46-addd-96296fe35a64"),
                ReferenceItemUnitId = Guid.Parse("03C90EE2-E782-4519-9FBE-1F1041093147"),
                ConvertedItemUnitId = Guid.Parse("68527238-83B6-468A-B57F-47C51E8CF400"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3ee136f1-1b9a-466a-aa13-3ba64ad0859b"),
                ReferenceItemUnitId = Guid.Parse("95787353-61B6-4C1C-A55C-3024506EC7A5"),
                ConvertedItemUnitId = Guid.Parse("CFC16836-B3CD-401E-A148-CC6B1107AE01"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3f401e65-7f9a-47ce-97e8-31c4ecdfffc9"),
                ReferenceItemUnitId = Guid.Parse("FAD081FF-9C48-4162-8293-29868005CDEA"),
                ConvertedItemUnitId = Guid.Parse("C6BE66B8-4BF9-4A31-BB53-333E483EB10B"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("3ff6d031-5452-4c2f-9643-fd7759d8359e"),
                ReferenceItemUnitId = Guid.Parse("FA58F9C3-25C0-4580-B1EC-1FC48B7EB57F"),
                ConvertedItemUnitId = Guid.Parse("6656AB3D-F7E5-4A43-BC04-E16B582A6E19"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("4091da74-bddb-42bd-b0ff-7108978beeaa"),
                ReferenceItemUnitId = Guid.Parse("F54BB47F-F7A1-41B9-8CE2-C8DD14048066"),
                ConvertedItemUnitId = Guid.Parse("EDEAB2B4-F651-4BD3-90E3-16187D795AF9"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("420adc70-b33a-4412-b323-fd546c53363c"),
                ReferenceItemUnitId = Guid.Parse("10B8047A-E230-41A4-9D96-B940F884B114"),
                ConvertedItemUnitId = Guid.Parse("850B5E1B-17F3-4675-9983-E2BA146898F9"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("420b18a4-ffa8-4693-8ecc-72d88dae6476"),
                ReferenceItemUnitId = Guid.Parse("51161258-7E59-42E0-AA59-35BCE966F7DE"),
                ConvertedItemUnitId = Guid.Parse("A32B5522-B666-489A-8751-F36E35F329B6"),
                ConversionQuantity = 1080m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("4344f814-e8d8-40e2-b31a-1ddd80f949fe"),
                ReferenceItemUnitId = Guid.Parse("774AFA26-3D7E-4571-B312-6CCF23B6AACC"),
                ConvertedItemUnitId = Guid.Parse("51D5DD5C-C9F5-4730-9435-3D182C4C5D99"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("434806a0-a60b-40a0-896e-74d32ddbdd00"),
                ReferenceItemUnitId = Guid.Parse("9CACBC01-D505-4FA2-A678-2A43DC0398E3"),
                ConvertedItemUnitId = Guid.Parse("B4A48062-2BA7-49C2-AC33-E16665AB418F"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("443fc654-cee4-4655-8d53-5275b75c8760"),
                ReferenceItemUnitId = Guid.Parse("4AE1D97C-5420-4CBA-85C8-01D2DCC101C2"),
                ConvertedItemUnitId = Guid.Parse("DEA1B296-7034-47D3-9E33-640EEBFC82A6"),
                ConversionQuantity = 1152m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("4732e421-b9fa-4e0e-a27a-ec436874b5aa"),
                ReferenceItemUnitId = Guid.Parse("4C24C671-A9C3-47BC-918E-E1D3080461F6"),
                ConvertedItemUnitId = Guid.Parse("00C9D6EA-C404-4EED-9B2B-EABEF1305DC1"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("476979df-a567-424b-a4fe-2dc893de9a50"),
                ReferenceItemUnitId = Guid.Parse("953E01FC-9A34-4B26-B93D-094D4A918549"),
                ConvertedItemUnitId = Guid.Parse("065BC0C2-CCA7-4568-ACC9-9F7F8BE2109F"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("48a71954-3bb8-4da5-9fab-a0e10912d52e"),
                ReferenceItemUnitId = Guid.Parse("9178B870-CB05-40F5-A31A-D44493322B87"),
                ConvertedItemUnitId = Guid.Parse("7563B910-54DD-402B-8E87-12B3A6CCF85C"),
                ConversionQuantity = 360m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("48ca9d00-1d5d-4fa5-ad57-fb7f97863d0c"),
                ReferenceItemUnitId = Guid.Parse("9A112C35-D62D-4F38-8C60-C7FFCBF29D3D"),
                ConvertedItemUnitId = Guid.Parse("EA168A90-F837-414A-B03E-793713AFAE9B"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("4bfd94fc-cf05-483a-9178-9996021ffd7a"),
                ReferenceItemUnitId = Guid.Parse("233BDFDE-2403-42A2-830B-ABFCA5FCB53E"),
                ConvertedItemUnitId = Guid.Parse("9C5795CD-26B2-4856-801D-65EBDA067997"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("4ca2c581-c69b-4d12-adb8-eb9a29a142cd"),
                ReferenceItemUnitId = Guid.Parse("5F7F3874-F751-49EF-9A38-9EAFBF8FA241"),
                ConvertedItemUnitId = Guid.Parse("51C982C4-BD4E-463C-9C89-4571C25EB294"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("4dec44dd-3a34-4747-adcc-59aab3013df1"),
                ReferenceItemUnitId = Guid.Parse("4AAA2FBC-B7D9-451A-BCE3-8EB95EDF18F6"),
                ConvertedItemUnitId = Guid.Parse("E61D6DC4-7A4B-45DA-8015-2FBA4A03C8C2"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("4f7be193-1902-4eda-926e-432cfd95c261"),
                ReferenceItemUnitId = Guid.Parse("091CE400-09E4-44F7-A99E-3872722EDD3E"),
                ConvertedItemUnitId = Guid.Parse("3645C383-3582-40B5-9223-B2475B556FA4"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("4f92677a-3976-40c8-b211-0cfd41ab659e"),
                ReferenceItemUnitId = Guid.Parse("2FCE987B-CF13-4F53-B46B-C0F7916E0AF4"),
                ConvertedItemUnitId = Guid.Parse("19192C15-01EA-4C21-9D8B-AD77D51E6A84"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("512847ce-6cb1-46d0-9a05-6fd254f9dfe9"),
                ReferenceItemUnitId = Guid.Parse("670BB366-373A-491D-AFFF-38A3EB1D5983"),
                ConvertedItemUnitId = Guid.Parse("698C29D2-6893-4C29-A0B3-6EB41FC5A542"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5143c7e4-1071-4012-b205-5b1f00909d5c"),
                ReferenceItemUnitId = Guid.Parse("BBA68587-F66C-4F25-AAE4-7E286021F666"),
                ConvertedItemUnitId = Guid.Parse("C4ED4D4A-C179-4278-82A3-2C9822371BB4"),
                ConversionQuantity = 120m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5152f95b-146d-4591-b94e-dd94b8004cb4"),
                ReferenceItemUnitId = Guid.Parse("2D62F3EA-7666-4446-9025-327725DEFE8D"),
                ConvertedItemUnitId = Guid.Parse("56BFD555-E5DD-459A-B6DF-E8FE4442FF3B"),
                ConversionQuantity = 480m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("530cdbdb-fd00-47d8-a61a-5e1ded7a2184"),
                ReferenceItemUnitId = Guid.Parse("437CE102-DACB-4310-BCDC-BA8F0057799C"),
                ConvertedItemUnitId = Guid.Parse("1A0160CC-09BF-403E-B53B-474D8CB00DFE"),
                ConversionQuantity = 576m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("536fe530-1d0b-46e2-a5b0-5a2bd904e331"),
                ReferenceItemUnitId = Guid.Parse("C207000F-488E-45D5-AB13-14A66DAFC60B"),
                ConvertedItemUnitId = Guid.Parse("11B79889-EC4D-4407-83B6-9A8993A65791"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("53b329cf-5a4b-4f85-96a4-19d36f25127b"),
                ReferenceItemUnitId = Guid.Parse("6D80F23D-43AD-4764-BCD1-B107B2DA659F"),
                ConvertedItemUnitId = Guid.Parse("299416C9-CE42-4D44-801C-C0EAF7E95B4F"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("53c7e63f-3935-4373-b3ad-605e4b6a3043"),
                ReferenceItemUnitId = Guid.Parse("FA3A5C5E-1905-4A69-9963-2B4E7FEA790D"),
                ConvertedItemUnitId = Guid.Parse("B3A652D7-5CE5-42FD-A776-880294446DEA"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("54a1d2d2-3cfd-44c9-8d5a-71fbb043a88c"),
                ReferenceItemUnitId = Guid.Parse("8E6965D3-FBCE-422F-A478-B61D691BDF74"),
                ConvertedItemUnitId = Guid.Parse("AE1A4504-488D-40F8-92D1-9B0E842949FA"),
                ConversionQuantity = 360m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("54cdec5f-87d9-4893-8b96-69e36bbfa3bf"),
                ReferenceItemUnitId = Guid.Parse("864EC55D-59C6-462E-B60B-AD33FE82F842"),
                ConvertedItemUnitId = Guid.Parse("13BCDDA6-2FBA-4848-BF3C-EF01094A296E"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5507275e-5743-4c3f-ad16-98352f902c77"),
                ReferenceItemUnitId = Guid.Parse("552DC968-2375-4F80-9DD4-365D64D54D1C"),
                ConvertedItemUnitId = Guid.Parse("A6CE04C3-871C-4C69-9BE6-10544155248E"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("55de2eed-c36b-449b-b1f1-a261517b8efc"),
                ReferenceItemUnitId = Guid.Parse("43D556A6-5B4B-4179-93D5-278A45F2C38A"),
                ConvertedItemUnitId = Guid.Parse("8DAAC8E8-0784-4AE3-8CD5-AAE250A2D185"),
                ConversionQuantity = 360m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("56e30e54-9af5-473e-a3cb-9661da4a2363"),
                ReferenceItemUnitId = Guid.Parse("97413815-E200-4DBD-B68F-ADE348CCEC4F"),
                ConvertedItemUnitId = Guid.Parse("4913E935-6ABC-48B6-AA09-C52919875B0C"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("56f12842-f7f5-48c6-921b-de8b71a56f81"),
                ReferenceItemUnitId = Guid.Parse("E6122F5C-CA8A-48C8-B223-F1ABE656E906"),
                ConvertedItemUnitId = Guid.Parse("70915CD3-8277-432F-9568-BE72C8EA8D0D"),
                ConversionQuantity = 576m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("57b77604-1554-48f4-b0c7-d0df3511cff4"),
                ReferenceItemUnitId = Guid.Parse("C3E03EA0-9425-4112-9821-328D9EBCB114"),
                ConvertedItemUnitId = Guid.Parse("00C9D6EA-C404-4EED-9B2B-EABEF1305DC1"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("583c590e-b294-4235-98f6-02319f115321"),
                ReferenceItemUnitId = Guid.Parse("26BDB59A-B61E-4575-A656-B3B68B14D28A"),
                ConvertedItemUnitId = Guid.Parse("FBBA1F14-9E14-4211-BA6A-468FF571E3B4"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5868052c-3d3d-441f-b78b-8cc1e0e91a27"),
                ReferenceItemUnitId = Guid.Parse("10FAFC6B-81EB-431A-A991-BB4A5AA1D566"),
                ConvertedItemUnitId = Guid.Parse("DBA2FA1D-9E09-4647-AC2B-91D01F761394"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("58b0047c-0d74-4a07-b8fd-d70a7f288da8"),
                ReferenceItemUnitId = Guid.Parse("7586CC1B-7E0F-4FF0-B593-38483D04FBD7"),
                ConvertedItemUnitId = Guid.Parse("84A25647-6938-49F8-BF14-6311F925A965"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5915b658-ce71-42d9-b72b-93af1316fb06"),
                ReferenceItemUnitId = Guid.Parse("6D6F4058-D76F-4EFE-AC48-F70024D0692C"),
                ConvertedItemUnitId = Guid.Parse("C2B7D00B-8560-4CDF-AEAB-E27324124643"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5ab08660-30a9-448a-957f-4433284268f5"),
                ReferenceItemUnitId = Guid.Parse("6653FC81-F2AF-4D12-9A81-5DA3E9C896A9"),
                ConvertedItemUnitId = Guid.Parse("FC33C8C9-02DC-47C3-8E08-5EDE6BC6DD46"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5ac74225-4bd1-4d5c-8a2c-0ecd02ced41b"),
                ReferenceItemUnitId = Guid.Parse("80912782-EDED-4BE0-B6B7-DD33E6005C3A"),
                ConvertedItemUnitId = Guid.Parse("E1E28CA9-8312-4E72-9228-EE9253ABC6BD"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5b363484-f45c-4c86-a220-50be42ea140a"),
                ReferenceItemUnitId = Guid.Parse("41DE7A60-8689-4F76-80DF-FFB67E6B8D45"),
                ConvertedItemUnitId = Guid.Parse("4913E935-6ABC-48B6-AA09-C52919875B0C"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5ba0c5ff-10bc-4d04-a477-a2eb5dcd0759"),
                ReferenceItemUnitId = Guid.Parse("15B3DC37-3E41-43B5-B224-7A1EAF9EAE72"),
                ConvertedItemUnitId = Guid.Parse("E61D6DC4-7A4B-45DA-8015-2FBA4A03C8C2"),
                ConversionQuantity = 360m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5c005282-31f8-4c21-abbc-aea1e7f49094"),
                ReferenceItemUnitId = Guid.Parse("FA36D4F9-7F0C-43B3-BBF2-0E44B0F124A5"),
                ConvertedItemUnitId = Guid.Parse("DBA2FA1D-9E09-4647-AC2B-91D01F761394"),
                ConversionQuantity = 1152m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5ea1ca17-1068-43b5-b00f-fc44c8249c23"),
                ReferenceItemUnitId = Guid.Parse("B144E9E4-D99F-4E90-B2B6-A3E04317C8D9"),
                ConvertedItemUnitId = Guid.Parse("88FE955A-BD24-4B62-ADE3-BE9E7CF0E085"),
                ConversionQuantity = 360m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5eb10113-8e69-487f-9e0d-4e7c2c42c020"),
                ReferenceItemUnitId = Guid.Parse("0E583039-7028-4AA7-A47D-2E99C2AD5471"),
                ConvertedItemUnitId = Guid.Parse("64AD60FD-FC18-461C-9FD0-C3F882E3CA93"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5f0ec1df-a628-4f36-a797-e018159cc76a"),
                ReferenceItemUnitId = Guid.Parse("888E6E0F-F467-49AA-A67F-217A7628525D"),
                ConvertedItemUnitId = Guid.Parse("146DF446-ED3B-435B-8E11-9D4E57EBC025"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5f4766b5-f14b-4d6c-b7c3-378df5744de8"),
                ReferenceItemUnitId = Guid.Parse("21D74012-E7DB-4F96-8D00-773F320C8DCE"),
                ConvertedItemUnitId = Guid.Parse("F4AF1877-493C-4D46-A2AE-BBACE0FFE337"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("5f8cbf95-3293-4a7f-8c1a-28648a0ed554"),
                ReferenceItemUnitId = Guid.Parse("057D7A7F-F8DF-47C6-8994-1FEAA76D5528"),
                ConvertedItemUnitId = Guid.Parse("77CB5BEF-0AAD-470E-B697-06C6F1587787"),
                ConversionQuantity = 120m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("604b5812-085e-4690-a978-e09c20312c2b"),
                ReferenceItemUnitId = Guid.Parse("143E5844-ED13-4B43-BD9F-BACD99E072D8"),
                ConvertedItemUnitId = Guid.Parse("AD3F08F6-9D46-44DD-9356-684BA8345428"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("606f5e2d-c05c-4d34-b666-3039489cce30"),
                ReferenceItemUnitId = Guid.Parse("E3D128DF-2C79-4905-8AB2-3F75105E3196"),
                ConvertedItemUnitId = Guid.Parse("8D93EC54-CC09-4E41-A503-B454D72AD405"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("61582267-4863-4ef0-a8fa-9558f6ec378c"),
                ReferenceItemUnitId = Guid.Parse("7F93FB7D-BA39-4782-9355-06AA989554E8"),
                ConvertedItemUnitId = Guid.Parse("C2B7D00B-8560-4CDF-AEAB-E27324124643"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("61ccf652-9e6f-40af-92b6-1b70b293eb91"),
                ReferenceItemUnitId = Guid.Parse("B91A27A4-CCFF-4C41-8FC9-20245974AD72"),
                ConvertedItemUnitId = Guid.Parse("516344F8-74F2-4B34-A39E-FD6ACFAD4422"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("63e4db89-dcd2-41cd-976a-59954f5fcafe"),
                ReferenceItemUnitId = Guid.Parse("315CCD12-0DB8-4D8E-8C03-98A6547AEA70"),
                ConvertedItemUnitId = Guid.Parse("2879C596-0102-42A2-A7F5-E9AE3FA82700"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("644da236-76dd-487b-963f-27246adb60c1"),
                ReferenceItemUnitId = Guid.Parse("EF442921-A207-4C18-9A5F-C67029B36B69"),
                ConvertedItemUnitId = Guid.Parse("F4AF1877-493C-4D46-A2AE-BBACE0FFE337"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("65927c67-32cb-4f74-ae51-67a9ee3a8943"),
                ReferenceItemUnitId = Guid.Parse("59E156EA-3FAE-4F56-8A3A-7B9337633C00"),
                ConvertedItemUnitId = Guid.Parse("C4ED4D4A-C179-4278-82A3-2C9822371BB4"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("66b8e634-105f-44fa-a882-b67bc2e5c92f"),
                ReferenceItemUnitId = Guid.Parse("99ADDB6A-FBB1-409A-9353-B35E4D712B63"),
                ConvertedItemUnitId = Guid.Parse("B165AAFA-90A7-41FA-9508-1C56FCE5C1AF"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("66da1225-562e-4b3b-9eb0-50c06d2d81e8"),
                ReferenceItemUnitId = Guid.Parse("18B4EC5F-1A35-4B55-AC7B-22C0112EE28E"),
                ConvertedItemUnitId = Guid.Parse("DFC1CC60-B199-4D05-AB23-0ED7113AC974"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("675bc726-4159-4652-9ad5-54e062360165"),
                ReferenceItemUnitId = Guid.Parse("33E21FB8-7645-4314-8B08-4599C7E3E25A"),
                ConvertedItemUnitId = Guid.Parse("698C29D2-6893-4C29-A0B3-6EB41FC5A542"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("68034bd7-0d57-4de7-bd91-e23d29310fa6"),
                ReferenceItemUnitId = Guid.Parse("1BD20A9A-A2CD-4F99-8D1B-9CEE18992D9E"),
                ConvertedItemUnitId = Guid.Parse("B276767C-7C6E-49CA-8C54-9A19EE4F6A8E"),
                ConversionQuantity = 768m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("68c51043-f9aa-4825-b7b4-7474be90df9e"),
                ReferenceItemUnitId = Guid.Parse("C50970C8-6B18-4DDF-985B-0C5C2BA7034A"),
                ConvertedItemUnitId = Guid.Parse("D56442E3-5858-4A1B-86D7-4A76F09A030A"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("697b1c0e-eaba-4d79-9720-cc1d55d9dffe"),
                ReferenceItemUnitId = Guid.Parse("F383C241-545D-4A45-8188-1E5CBA359E3F"),
                ConvertedItemUnitId = Guid.Parse("E1E28CA9-8312-4E72-9228-EE9253ABC6BD"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("6ab5655d-5b95-4408-ad9f-7a1706656662"),
                ReferenceItemUnitId = Guid.Parse("104CD401-3899-4EE5-AB09-9D3C7D3F37B9"),
                ConvertedItemUnitId = Guid.Parse("B3A652D7-5CE5-42FD-A776-880294446DEA"),
                ConversionQuantity = 360m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("6b3913e1-6247-4670-a5d1-aeb6e923d612"),
                ReferenceItemUnitId = Guid.Parse("25FAACBB-B5BA-41AB-AF2C-0B31AB76AC92"),
                ConvertedItemUnitId = Guid.Parse("4E8326B4-07D3-4C1D-8014-9FC57AE686F2"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("6ba54ca9-b544-4d02-9033-a12cfc2f3341"),
                ReferenceItemUnitId = Guid.Parse("B1D8BE28-84EA-447E-B816-E8E8C17166F4"),
                ConvertedItemUnitId = Guid.Parse("9D8A6A00-D80D-4131-BB9E-DF10AFD44BCA"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("6cea4300-e374-45a5-84f3-9e94bea3f189"),
                ReferenceItemUnitId = Guid.Parse("29BF5E71-0E11-4D2D-8DD3-C6061BB6E02A"),
                ConvertedItemUnitId = Guid.Parse("3645C383-3582-40B5-9223-B2475B556FA4"),
                ConversionQuantity = 1296m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("6e5f19fa-829e-48a0-a217-b1a6e9daac54"),
                ReferenceItemUnitId = Guid.Parse("AB567010-71F7-4BFC-A47F-FB113A4B1186"),
                ConvertedItemUnitId = Guid.Parse("47AF2EB3-2E03-4DD2-A0BF-07AACA4A59C5"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("70fea627-1bd2-4bbb-8649-2ed92dae3b4a"),
                ReferenceItemUnitId = Guid.Parse("F22C4828-D705-4FA8-93DC-E309BB229C7F"),
                ConvertedItemUnitId = Guid.Parse("EDEAB2B4-F651-4BD3-90E3-16187D795AF9"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7327f91a-d8a5-47ca-a00e-ed3c0b1fd11a"),
                ReferenceItemUnitId = Guid.Parse("A44FE6BE-06F6-43E6-811F-36A801925F6F"),
                ConvertedItemUnitId = Guid.Parse("B63935F6-79F4-4020-8A92-8784AFC2A427"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("735600a3-9918-4ae7-8519-f86ecc75f19f"),
                ReferenceItemUnitId = Guid.Parse("97DB5A39-C55E-4F3C-8694-D97421AB1EB9"),
                ConvertedItemUnitId = Guid.Parse("C2B7D00B-8560-4CDF-AEAB-E27324124643"),
                ConversionQuantity = 480m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("73fc4bd4-066b-4abb-b561-e7b8f640cb07"),
                ReferenceItemUnitId = Guid.Parse("EF6648F0-C724-46AF-A4A8-6443C2F83922"),
                ConvertedItemUnitId = Guid.Parse("36D55F2C-567A-498D-AE16-521531BEC943"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("74455f7e-102c-42b0-b0f9-fa2185f2d5b4"),
                ReferenceItemUnitId = Guid.Parse("FE7E6D03-80C2-4704-9BDF-C389B73F6AB9"),
                ConvertedItemUnitId = Guid.Parse("B4A48062-2BA7-49C2-AC33-E16665AB418F"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7454c5b5-a0c1-465a-a45e-2fc1558324dd"),
                ReferenceItemUnitId = Guid.Parse("0A393751-B7E7-49D5-8133-1828E9F8145B"),
                ConvertedItemUnitId = Guid.Parse("299416C9-CE42-4D44-801C-C0EAF7E95B4F"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("75c33b07-2e5d-4e06-a136-1e84849c3274"),
                ReferenceItemUnitId = Guid.Parse("52884777-2380-4C27-B2A3-59FF9DFB6B7D"),
                ConvertedItemUnitId = Guid.Parse("D15267BB-D7F5-438C-B194-847032C8513B"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("75d91c77-2f61-469e-93e9-f6576bee85b7"),
                ReferenceItemUnitId = Guid.Parse("24DA9AF2-CC2E-48C2-94E3-472545DA88B9"),
                ConvertedItemUnitId = Guid.Parse("D330EAED-1555-4E56-A18A-E5C73120A559"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7690dc43-a6ff-46c0-8ad2-e88212ac41bc"),
                ReferenceItemUnitId = Guid.Parse("9616D06C-67C7-4E8E-92E7-163E5F31D5BF"),
                ConvertedItemUnitId = Guid.Parse("816236DD-9BC4-4C3B-8FB2-08247E598803"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7b08d479-9a13-4124-a0bc-f96e11073cfa"),
                ReferenceItemUnitId = Guid.Parse("BA33699A-CB08-462A-8068-25D6971D9855"),
                ConvertedItemUnitId = Guid.Parse("7B35130B-3186-472B-B9E5-174E5882AECC"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7b6f927f-a1eb-47f2-9619-cd2d8936cc90"),
                ReferenceItemUnitId = Guid.Parse("21FABEF7-7209-4D20-A11D-EF961E1A1745"),
                ConvertedItemUnitId = Guid.Parse("549E4987-498F-44B8-B9F3-37C702C28F99"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7b9ec870-1645-4b47-acc0-158dcb699c56"),
                ReferenceItemUnitId = Guid.Parse("AFF23A32-2FED-4F83-9EE4-2FBE167C5D82"),
                ConvertedItemUnitId = Guid.Parse("4E8326B4-07D3-4C1D-8014-9FC57AE686F2"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7bbd8ba0-48f4-4a05-93f3-dbef0d1f2dd5"),
                ReferenceItemUnitId = Guid.Parse("C1FA3983-7828-40BB-BC99-8966654F5757"),
                ConvertedItemUnitId = Guid.Parse("3F4D10F0-ED24-4A87-9F2E-44BBB582CC7B"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7c2a9af4-a15f-44e6-bf6b-791eea5b1f16"),
                ReferenceItemUnitId = Guid.Parse("AF6A38CC-0881-45AA-8C4C-DC058F6C3B3B"),
                ConvertedItemUnitId = Guid.Parse("8DAAC8E8-0784-4AE3-8CD5-AAE250A2D185"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7d89d8e0-e8c7-4007-a160-12c7f1cd5296"),
                ReferenceItemUnitId = Guid.Parse("36D858F1-B76C-4C53-B724-A6FC39B9B62D"),
                ConvertedItemUnitId = Guid.Parse("B63935F6-79F4-4020-8A92-8784AFC2A427"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7dc4f183-60cf-49dd-82f1-686ac2321395"),
                ReferenceItemUnitId = Guid.Parse("22EE5C1B-54BD-4638-B5C0-B5928B8E937F"),
                ConvertedItemUnitId = Guid.Parse("51C982C4-BD4E-463C-9C89-4571C25EB294"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7eedd526-b928-43f2-862c-7fd035ec8509"),
                ReferenceItemUnitId = Guid.Parse("A1F216AA-FF63-4239-904A-D111B57095EF"),
                ConvertedItemUnitId = Guid.Parse("452C3E2B-225C-4A15-BD5D-136220415A89"),
                ConversionQuantity = 480m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("7f77de18-ccf5-46fe-97b2-4f8318512904"),
                ReferenceItemUnitId = Guid.Parse("B6936861-6A3C-435A-9412-648E8D338C00"),
                ConvertedItemUnitId = Guid.Parse("C360A841-3358-424F-8B97-2AD2D6D9D06C"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("81965456-046b-4293-b903-856f3e328fee"),
                ReferenceItemUnitId = Guid.Parse("5AF133E0-178E-4C74-A9BA-6B2303E34B54"),
                ConvertedItemUnitId = Guid.Parse("07076D2C-EFCE-4CB2-A31E-A3DBF7FE4A97"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("81ef3f11-2bc4-49a1-a50a-f0d54e9b782c"),
                ReferenceItemUnitId = Guid.Parse("5C079C15-5568-4888-8E15-38E0CCEB9BC0"),
                ConvertedItemUnitId = Guid.Parse("5FF76D80-E2F3-47F5-B8D4-4F4FED175FFB"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("82d503b6-c756-4542-8dfc-130a5255a8a2"),
                ReferenceItemUnitId = Guid.Parse("2EE47897-D499-451B-AEB0-09EC28451FA6"),
                ConvertedItemUnitId = Guid.Parse("57BD0E35-C672-4BBA-9F69-5EA5D8378D8D"),
                ConversionQuantity = 576m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("82d917ca-ebda-4eb0-a018-be3f2c3b8c79"),
                ReferenceItemUnitId = Guid.Parse("01E70A0E-FF21-4850-8DFA-23456E708931"),
                ConvertedItemUnitId = Guid.Parse("57BD0E35-C672-4BBA-9F69-5EA5D8378D8D"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("840ce532-5b44-47e6-89a6-b24713b46d8f"),
                ReferenceItemUnitId = Guid.Parse("B9718DFC-E464-4471-BA96-B8241D58F34C"),
                ConvertedItemUnitId = Guid.Parse("88FE955A-BD24-4B62-ADE3-BE9E7CF0E085"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("8640aeec-2e16-4837-b2c2-80298deadab5"),
                ReferenceItemUnitId = Guid.Parse("A40F6B6E-164C-46FE-9DB9-E53F55EBAE37"),
                ConvertedItemUnitId = Guid.Parse("9AF3C5A6-CCFD-4FFD-90A5-DED3CCEA3D58"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("86614767-cb60-4731-ad37-cefc9295258e"),
                ReferenceItemUnitId = Guid.Parse("4AF29841-AF65-408C-AB6B-B39C9B0C63B6"),
                ConvertedItemUnitId = Guid.Parse("B63935F6-79F4-4020-8A92-8784AFC2A427"),
                ConversionQuantity = 1080m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("86c3fed1-2459-4462-b284-f4bdf88bc7f6"),
                ReferenceItemUnitId = Guid.Parse("1FF483AA-3F32-4BD1-A87F-66C56DC2EF5E"),
                ConvertedItemUnitId = Guid.Parse("2879C596-0102-42A2-A7F5-E9AE3FA82700"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("8727eeee-16e3-4f55-9779-33b822750caf"),
                ReferenceItemUnitId = Guid.Parse("D8DECA9C-E6D5-456F-8460-D0610CA2AD57"),
                ConvertedItemUnitId = Guid.Parse("EDEAB2B4-F651-4BD3-90E3-16187D795AF9"),
                ConversionQuantity = 480m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("8819cf42-12bc-49c3-ac2f-8c857c26e0a0"),
                ReferenceItemUnitId = Guid.Parse("701D0B0C-7E41-4EFD-A64F-B2A79A6860BC"),
                ConvertedItemUnitId = Guid.Parse("D9F8B3D1-07DD-4555-B220-D80565F42913"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("89737128-e842-4bc6-bf76-261ac78306ac"),
                ReferenceItemUnitId = Guid.Parse("92146032-6A20-4808-BD5C-B405CC24A462"),
                ConvertedItemUnitId = Guid.Parse("13BCDDA6-2FBA-4848-BF3C-EF01094A296E"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("8ae8cfdf-8520-449f-b3d0-e707812ae086"),
                ReferenceItemUnitId = Guid.Parse("E31BE447-1E2D-4F55-B8AD-03CB7371914B"),
                ConvertedItemUnitId = Guid.Parse("BCD8966A-878A-4C12-9682-F8E27319C013"),
                ConversionQuantity = 16m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("8c0dcfaf-795d-48f6-aaed-de0e9614405a"),
                ReferenceItemUnitId = Guid.Parse("751A2F31-8CB8-4B2F-9211-83C2A33BFAB4"),
                ConvertedItemUnitId = Guid.Parse("64AD60FD-FC18-461C-9FD0-C3F882E3CA93"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("8e567cc4-1514-4a5b-8e1b-99c3586fbead"),
                ReferenceItemUnitId = Guid.Parse("8A3D8964-F891-40F3-974C-84EE07B1AFA0"),
                ConvertedItemUnitId = Guid.Parse("B745B05E-3CA7-4E8E-A500-B266834849E9"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("8f99d02d-bb35-4e8c-9ca7-28b3dcff909a"),
                ReferenceItemUnitId = Guid.Parse("80D5986F-742C-4A2C-86B4-258B1B10F808"),
                ConvertedItemUnitId = Guid.Parse("C81EFF75-5756-446E-9881-6C7CCA16EA58"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("8fcb8789-2a6f-470d-a0ab-8a0f3e1edc1a"),
                ReferenceItemUnitId = Guid.Parse("44C6DB6A-3F47-402C-9A07-B7361E7B2D87"),
                ConvertedItemUnitId = Guid.Parse("4913E935-6ABC-48B6-AA09-C52919875B0C"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("90058e1f-22c4-4a93-afd7-41364900209b"),
                ReferenceItemUnitId = Guid.Parse("D9DD70E1-A7F9-47BD-BA23-187580117730"),
                ConvertedItemUnitId = Guid.Parse("07076D2C-EFCE-4CB2-A31E-A3DBF7FE4A97"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("90318c70-eb8f-4db3-a20a-17e95d93858a"),
                ReferenceItemUnitId = Guid.Parse("5F9E7E3A-DD89-4517-B7FB-C7780E6640A9"),
                ConvertedItemUnitId = Guid.Parse("A072A88B-3F5F-46DA-A721-CEE61389ED33"),
                ConversionQuantity = 144m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("90c17099-ce64-4334-a446-7c0611272bfe"),
                ReferenceItemUnitId = Guid.Parse("504F2844-C89B-4193-AF3A-1E4D1DC2C4F7"),
                ConvertedItemUnitId = Guid.Parse("BD7756C9-A5E9-424E-9ED5-CE8C61EC8504"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("912bbdfc-c36c-4374-9760-ccc04495cd9c"),
                ReferenceItemUnitId = Guid.Parse("23FDB184-90E6-4470-8B17-D884E95D7475"),
                ConvertedItemUnitId = Guid.Parse("B276767C-7C6E-49CA-8C54-9A19EE4F6A8E"),
                ConversionQuantity = 32m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9180cc6d-6ba5-455f-bb3b-5d98d971c421"),
                ReferenceItemUnitId = Guid.Parse("C001F089-7DCA-4AFA-A940-BB3CB3B3CF49"),
                ConvertedItemUnitId = Guid.Parse("DEA1B296-7034-47D3-9E33-640EEBFC82A6"),
                ConversionQuantity = 48m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("92701d10-a320-4789-ac59-48cfca715d20"),
                ReferenceItemUnitId = Guid.Parse("5DB21F4D-70C4-41DA-9047-0A2B11F4AF8A"),
                ConvertedItemUnitId = Guid.Parse("F83248E6-DA20-4DF2-97FC-69CDA3D1DAD4"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("93cb90d3-6dfc-431f-a1ce-05f14292fd00"),
                ReferenceItemUnitId = Guid.Parse("4ABB1D3D-BFDF-4B8A-B90E-2F5BBEA1C4AD"),
                ConvertedItemUnitId = Guid.Parse("065BC0C2-CCA7-4568-ACC9-9F7F8BE2109F"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("941222bd-d9e7-4753-b9a5-8df021e730c8"),
                ReferenceItemUnitId = Guid.Parse("220DECE4-D93E-49E5-9207-93CA3C03A68A"),
                ConvertedItemUnitId = Guid.Parse("EA168A90-F837-414A-B03E-793713AFAE9B"),
                ConversionQuantity = 1152m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("94bd5ccb-e35b-4ecd-a939-14c2be28b738"),
                ReferenceItemUnitId = Guid.Parse("F21EEA46-8DBE-402E-A651-7555312279B8"),
                ConvertedItemUnitId = Guid.Parse("70DF4295-57EA-4BEB-A9FC-5FD2E39440DC"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("950cc3b6-e922-4ff3-8a72-47497ebabce4"),
                ReferenceItemUnitId = Guid.Parse("D744201B-4638-41EF-9F67-4D3B2E4BB858"),
                ConvertedItemUnitId = Guid.Parse("516344F8-74F2-4B34-A39E-FD6ACFAD4422"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9608df4b-67ca-4df1-9da7-7983c9b444ce"),
                ReferenceItemUnitId = Guid.Parse("B12EEC56-02A5-4622-A2DE-17AD7E8551B7"),
                ConvertedItemUnitId = Guid.Parse("70DF4295-57EA-4BEB-A9FC-5FD2E39440DC"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("96cbee60-b10c-4029-b89e-dbdfa0a1d206"),
                ReferenceItemUnitId = Guid.Parse("E6DC91CA-3B06-4EBD-B58C-22E771A41568"),
                ConvertedItemUnitId = Guid.Parse("698C29D2-6893-4C29-A0B3-6EB41FC5A542"),
                ConversionQuantity = 120m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9926f343-32d0-4579-a6a4-d292bdd9fcb0"),
                ReferenceItemUnitId = Guid.Parse("271A11C0-82B3-4D01-82C3-067A48646031"),
                ConvertedItemUnitId = Guid.Parse("77CB5BEF-0AAD-470E-B697-06C6F1587787"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("99c2a970-4b4a-469a-8f90-1bd7b37c0b4d"),
                ReferenceItemUnitId = Guid.Parse("406489A7-6BC1-4892-904D-AD83074B4A9B"),
                ConvertedItemUnitId = Guid.Parse("F86F5B6E-D11E-41DA-A6DF-621569B49FA8"),
                ConversionQuantity = 576m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("99d1b000-07ac-4c2c-8387-a2f2e03b4686"),
                ReferenceItemUnitId = Guid.Parse("B2309A86-EF74-4263-9FD6-66BE385FD5E7"),
                ConvertedItemUnitId = Guid.Parse("8CE82425-296E-41C2-82FD-0A36DEEB6023"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9b5165a9-cf56-46cd-ba62-f888f7a373e4"),
                ReferenceItemUnitId = Guid.Parse("745FEF1B-7686-4B6B-9842-23F4EBFDD4BF"),
                ConvertedItemUnitId = Guid.Parse("DFC1CC60-B199-4D05-AB23-0ED7113AC974"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9ba878ab-a0df-4f17-8134-2fb8213331e1"),
                ReferenceItemUnitId = Guid.Parse("77E57E27-2959-4833-8D36-B4369158B207"),
                ConvertedItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9c3241c2-7382-40c0-850d-031353d422f7"),
                ReferenceItemUnitId = Guid.Parse("5BBFD066-C55F-4C4E-AFF2-76EABA2B41B6"),
                ConvertedItemUnitId = Guid.Parse("EA168A90-F837-414A-B03E-793713AFAE9B"),
                ConversionQuantity = 48m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9c77d9be-053c-412a-a6ec-118b1c56e003"),
                ReferenceItemUnitId = Guid.Parse("A81B257E-ECF2-4C1C-9467-D20F881DD310"),
                ConvertedItemUnitId = Guid.Parse("3F4D10F0-ED24-4A87-9F2E-44BBB582CC7B"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9d4d67d1-9f8f-4f92-9b74-7298c7abf3af"),
                ReferenceItemUnitId = Guid.Parse("622150F3-8917-4BF3-A484-710BDD0A7EA5"),
                ConvertedItemUnitId = Guid.Parse("AD3F08F6-9D46-44DD-9356-684BA8345428"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9def17fb-288c-462b-9896-eb1c47af6b94"),
                ReferenceItemUnitId = Guid.Parse("5C4A7F79-21A2-424B-B3F5-805636293F84"),
                ConvertedItemUnitId = Guid.Parse("E8483812-85FF-49AC-835D-59A16DD9DC81"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9fc6c1b1-a624-46d7-8306-b4768680a51d"),
                ReferenceItemUnitId = Guid.Parse("C1D7F2B5-E47A-40A0-9DC1-84DBCD6365F3"),
                ConvertedItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
                ConversionQuantity = 432m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("9ffaaaf4-a81c-4862-9a82-afd7921b9bd5"),
                ReferenceItemUnitId = Guid.Parse("24B8E5CB-16CD-40DD-8C7B-A088A1A9A05C"),
                ConvertedItemUnitId = Guid.Parse("F83248E6-DA20-4DF2-97FC-69CDA3D1DAD4"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("a24d85fe-1826-407e-874c-9a621f93175a"),
                ReferenceItemUnitId = Guid.Parse("3C355087-CCB3-4CA4-A097-4083C27495E8"),
                ConvertedItemUnitId = Guid.Parse("4FCA6E54-1479-4B32-91E2-3CA485B920EB"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("a3cb099e-4e62-4fcd-8af2-f122617cff63"),
                ReferenceItemUnitId = Guid.Parse("9BF1B741-98FE-4238-944F-71808D7E91C1"),
                ConvertedItemUnitId = Guid.Parse("A6689121-2A94-49EF-B5A7-3BE915BEB1EF"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("a4207c62-05e7-4e84-b6f3-b96a4c3de69f"),
                ReferenceItemUnitId = Guid.Parse("0AA0545F-D7C7-42BF-844F-B05CC117199A"),
                ConvertedItemUnitId = Guid.Parse("452C3E2B-225C-4A15-BD5D-136220415A89"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("a42955d5-5641-41ce-806f-783284f6079c"),
                ReferenceItemUnitId = Guid.Parse("AF248035-CC6F-4874-89FB-5ECEC665B1CB"),
                ConvertedItemUnitId = Guid.Parse("88FE955A-BD24-4B62-ADE3-BE9E7CF0E085"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("a70a738a-4b22-404d-9515-b39dfe772023"),
                ReferenceItemUnitId = Guid.Parse("89CD1ACD-4DF4-4E40-9DBC-C7151CF83209"),
                ConvertedItemUnitId = Guid.Parse("EFE00027-DB73-4A93-B9C1-2A696FA2167D"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("a7892f7a-bb7a-4dd1-a88c-fae627cf02ba"),
                ReferenceItemUnitId = Guid.Parse("8B4B0F5D-856F-49D2-82AF-61A87DFC10D1"),
                ConvertedItemUnitId = Guid.Parse("C360A841-3358-424F-8B97-2AD2D6D9D06C"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("a865dfcb-8f15-4cd9-8dea-d17f29a53e8b"),
                ReferenceItemUnitId = Guid.Parse("DCD0617C-F8DE-49BC-9022-6DBCCFFE86A5"),
                ConvertedItemUnitId = Guid.Parse("5FF76D80-E2F3-47F5-B8D4-4F4FED175FFB"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("aa49fad4-2516-41f7-b2b8-103f6a65983b"),
                ReferenceItemUnitId = Guid.Parse("8ACE3C2C-B2CF-41FC-A8D2-17ACADDB17C9"),
                ConvertedItemUnitId = Guid.Parse("AA7C8C4E-11D0-42DA-988D-FD9741E10BE5"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("aa66540f-ada0-4532-9b59-b75d867ba13b"),
                ReferenceItemUnitId = Guid.Parse("28B400B1-B09E-4A12-9CF7-41A75DCCF413"),
                ConvertedItemUnitId = Guid.Parse("D9F8B3D1-07DD-4555-B220-D80565F42913"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("aad0be1b-f587-4d27-8053-2902ee4357d1"),
                ReferenceItemUnitId = Guid.Parse("32E98BE2-6CE7-4059-8D91-9EFC106EE97F"),
                ConvertedItemUnitId = Guid.Parse("D96E008A-1476-43BF-B74B-C6CA9E90B64E"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ac5d427c-26ce-4b0e-a5bc-7dd37b13d45d"),
                ReferenceItemUnitId = Guid.Parse("AAFBA082-5F08-4C01-9472-92E15B338558"),
                ConvertedItemUnitId = Guid.Parse("36D55F2C-567A-498D-AE16-521531BEC943"),
                ConversionQuantity = 1080m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("acf09f75-ed23-42b2-b6e4-02d6377866bd"),
                ReferenceItemUnitId = Guid.Parse("4C63A204-9A6C-41D6-88DA-912D635CDA06"),
                ConvertedItemUnitId = Guid.Parse("9D8A6A00-D80D-4131-BB9E-DF10AFD44BCA"),
                ConversionQuantity = 1296m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("adfa468e-f214-456d-9803-8bb0ef12c947"),
                ReferenceItemUnitId = Guid.Parse("069E0AD5-F015-4BE9-B7FE-DC61E5845815"),
                ConvertedItemUnitId = Guid.Parse("3F4D10F0-ED24-4A87-9F2E-44BBB582CC7B"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ae4558fb-5b8a-4523-923a-1a5327dba423"),
                ReferenceItemUnitId = Guid.Parse("4AF4EA54-F270-4D88-9548-66611A805381"),
                ConvertedItemUnitId = Guid.Parse("8DB6CD59-4BA4-49E2-9992-B025A7895DA4"),
                ConversionQuantity = 144m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("af788d99-bda8-4828-b72e-cb065bfc7bba"),
                ReferenceItemUnitId = Guid.Parse("F3D8C3D5-835D-4F5F-AC83-9900615F344A"),
                ConvertedItemUnitId = Guid.Parse("51D5DD5C-C9F5-4730-9435-3D182C4C5D99"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b025bdb8-bd1d-4348-aee7-2a8e445e099e"),
                ReferenceItemUnitId = Guid.Parse("087849B0-CBCD-4AB7-82DF-6966EC353F84"),
                ConvertedItemUnitId = Guid.Parse("64AD60FD-FC18-461C-9FD0-C3F882E3CA93"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b0fcfec8-ac9d-41d4-ba9d-a855db65aa06"),
                ReferenceItemUnitId = Guid.Parse("8D305EBD-45D9-4094-88E8-DB4C148F11D2"),
                ConvertedItemUnitId = Guid.Parse("D15267BB-D7F5-438C-B194-847032C8513B"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b1ec755d-09bb-4308-9ff4-4f66d03815c8"),
                ReferenceItemUnitId = Guid.Parse("EDDE5B4E-F2AF-4888-A50C-E2096FD84E3B"),
                ConvertedItemUnitId = Guid.Parse("A32B5522-B666-489A-8751-F36E35F329B6"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b2251d04-98ce-4fc2-a906-ec43dd36852b"),
                ReferenceItemUnitId = Guid.Parse("B78537DF-D669-44A5-9EF0-6A4075E54CF2"),
                ConvertedItemUnitId = Guid.Parse("9E13C0E0-7B1F-463C-AC3F-750B3F8E389F"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b3b5b5b9-5682-423c-aa53-983fadfea180"),
                ReferenceItemUnitId = Guid.Parse("D527D700-3A9A-4F63-9AA0-3ABEC4A62A43"),
                ConvertedItemUnitId = Guid.Parse("F83248E6-DA20-4DF2-97FC-69CDA3D1DAD4"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b441cfde-ff8d-40af-9e1e-36d9405b1816"),
                ReferenceItemUnitId = Guid.Parse("41AA2304-20B7-4EC8-A45A-2D215BE887FC"),
                ConvertedItemUnitId = Guid.Parse("99BFF122-E390-45ED-A1AB-CC225A1C00C3"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b4c7a139-2155-495c-bbf2-6af7d11de7ef"),
                ReferenceItemUnitId = Guid.Parse("4249AA34-95F5-4564-B2CB-720D56C89F0E"),
                ConvertedItemUnitId = Guid.Parse("39DA5472-7CBF-45F4-B607-14F223F61BAD"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b4d48f37-67fb-46cd-90fb-264cb16eafd1"),
                ReferenceItemUnitId = Guid.Parse("F54134D0-0774-481E-BCAB-B502F57AAEE4"),
                ConvertedItemUnitId = Guid.Parse("926AFBBD-7010-41B5-88DC-3985C2E60C74"),
                ConversionQuantity = 8m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b5794241-4f3d-4a9b-9a2c-bfd7ab4b0d45"),
                ReferenceItemUnitId = Guid.Parse("8941560B-98ED-4291-B0F1-BF5CCBAEEEE7"),
                ConvertedItemUnitId = Guid.Parse("00C9D6EA-C404-4EED-9B2B-EABEF1305DC1"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b5c5415a-3785-46a7-a54c-d8ccbee40fa4"),
                ReferenceItemUnitId = Guid.Parse("18986D68-D567-4913-AC20-81AD61722368"),
                ConvertedItemUnitId = Guid.Parse("C4ED4D4A-C179-4278-82A3-2C9822371BB4"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b69f447c-df91-4ba0-84cd-4bb8d46a694b"),
                ReferenceItemUnitId = Guid.Parse("CC1E36DA-AB81-4444-8A66-54920522BFF2"),
                ConvertedItemUnitId = Guid.Parse("19192C15-01EA-4C21-9D8B-AD77D51E6A84"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b75c6971-8ab1-4da8-b3a4-1502708a12d3"),
                ReferenceItemUnitId = Guid.Parse("B8ED8999-D2DF-44AA-B035-3F0084152972"),
                ConvertedItemUnitId = Guid.Parse("9AF3C5A6-CCFD-4FFD-90A5-DED3CCEA3D58"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b84faf1d-d589-4087-bea5-73b703fb4b10"),
                ReferenceItemUnitId = Guid.Parse("4F0BD153-B4F7-4606-A8F3-882845317A71"),
                ConvertedItemUnitId = Guid.Parse("BD7756C9-A5E9-424E-9ED5-CE8C61EC8504"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("b9093198-06f1-40a8-a092-11bb56914019"),
                ReferenceItemUnitId = Guid.Parse("B0D16F0A-F693-4429-B31F-ED50B9EF7CDC"),
                ConvertedItemUnitId = Guid.Parse("146DF446-ED3B-435B-8E11-9D4E57EBC025"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ba227e6f-9718-4b96-843c-c5014e78029d"),
                ReferenceItemUnitId = Guid.Parse("7A81F8B7-1A42-4006-B193-E61878B07C77"),
                ConvertedItemUnitId = Guid.Parse("9E13C0E0-7B1F-463C-AC3F-750B3F8E389F"),
                ConversionQuantity = 576m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("bb30c07a-3701-44ad-bada-e9433e6cd5bc"),
                ReferenceItemUnitId = Guid.Parse("539C9A7A-D5AC-490A-898A-C1741DAEAA3F"),
                ConvertedItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("bd20b5e4-44be-4cb0-8e86-be67efff983d"),
                ReferenceItemUnitId = Guid.Parse("347A4A6F-DE76-4FBE-BAA1-8A9BD2EB69A1"),
                ConvertedItemUnitId = Guid.Parse("8D93EC54-CC09-4E41-A503-B454D72AD405"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("bd6428e2-1183-4132-9e75-e172523cf478"),
                ReferenceItemUnitId = Guid.Parse("43D4F2DC-DB42-4040-8EF2-EDC0C2759C8B"),
                ConvertedItemUnitId = Guid.Parse("68527238-83B6-468A-B57F-47C51E8CF400"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("beaf935a-b2a7-49c6-80dc-d3f7d713ca33"),
                ReferenceItemUnitId = Guid.Parse("C2BFCD25-5116-4E4B-A182-9917CB13559F"),
                ConvertedItemUnitId = Guid.Parse("4B5E24AA-08CB-4F66-A738-57F0E648BF3C"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("bee99273-9469-48e2-9ee2-dcfce713c7cb"),
                ReferenceItemUnitId = Guid.Parse("4109AC2D-ACCE-4348-83B7-D87088CE5A03"),
                ConvertedItemUnitId = Guid.Parse("4FCA6E54-1479-4B32-91E2-3CA485B920EB"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c04b43ee-b38c-4529-b5a8-acdc9749847d"),
                ReferenceItemUnitId = Guid.Parse("D51035B6-4328-4909-8B8D-9DDB8107EB01"),
                ConvertedItemUnitId = Guid.Parse("FC33C8C9-02DC-47C3-8E08-5EDE6BC6DD46"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c0e39222-f297-4cee-90e3-70f275e75fc0"),
                ReferenceItemUnitId = Guid.Parse("FCFC55D9-A0BD-44C6-A5E0-D4D427F13A2E"),
                ConvertedItemUnitId = Guid.Parse("9E915514-2ECB-48F9-B893-131869E73C0D"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c20ccdc0-ca80-4cc0-9a57-d49b4eda080f"),
                ReferenceItemUnitId = Guid.Parse("7D4EA8DB-E517-4DD1-A191-2470C89FA98F"),
                ConvertedItemUnitId = Guid.Parse("CCFACEFC-73AF-46C8-BF6B-EE93A5445A67"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c28afa27-dca5-47fa-97f9-88e3c8c3dd7a"),
                ReferenceItemUnitId = Guid.Parse("9949262B-93B5-4597-B878-A11FB00BA7C4"),
                ConvertedItemUnitId = Guid.Parse("51D5DD5C-C9F5-4730-9435-3D182C4C5D99"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c3009862-5a0e-418d-a2b5-65e11e7a657c"),
                ReferenceItemUnitId = Guid.Parse("ECD9CBFD-0EF3-4588-A1C4-183F0E162BFB"),
                ConvertedItemUnitId = Guid.Parse("9D8A6A00-D80D-4131-BB9E-DF10AFD44BCA"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c33ac59c-49bf-4cb0-8a92-13b5d2033cd1"),
                ReferenceItemUnitId = Guid.Parse("A731510C-392A-4475-93E3-465F9EA1C4F1"),
                ConvertedItemUnitId = Guid.Parse("B4A48062-2BA7-49C2-AC33-E16665AB418F"),
                ConversionQuantity = 120m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c360707b-4e67-4f0e-bab6-a04de191f0d8"),
                ReferenceItemUnitId = Guid.Parse("EDFF47B4-E29B-453C-A05C-F9A67BAE939E"),
                ConvertedItemUnitId = Guid.Parse("8DB6CD59-4BA4-49E2-9992-B025A7895DA4"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c45b39af-1e62-4041-8eca-9bb4ffcb2127"),
                ReferenceItemUnitId = Guid.Parse("89521651-316A-4649-8FE7-DF19FB1926D2"),
                ConvertedItemUnitId = Guid.Parse("CFC16836-B3CD-401E-A148-CC6B1107AE01"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c49e7ff4-005c-4d13-a6f8-aee0d9bb7590"),
                ReferenceItemUnitId = Guid.Parse("ED97D761-BDF6-42D3-BF5E-1E9B5994E95B"),
                ConvertedItemUnitId = Guid.Parse("95B0A158-AF96-4FDF-914A-735E5A0B42A8"),
                ConversionQuantity = 480m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c4e830b1-cbb2-4eed-ae64-4978a0d79e11"),
                ReferenceItemUnitId = Guid.Parse("1946BE1B-160C-4313-8660-B081A6E4264D"),
                ConvertedItemUnitId = Guid.Parse("68527238-83B6-468A-B57F-47C51E8CF400"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c510d940-99a0-472b-b775-f481301d93ca"),
                ReferenceItemUnitId = Guid.Parse("482F08F0-7654-4784-A21F-21B4CC567CAD"),
                ConvertedItemUnitId = Guid.Parse("47AF2EB3-2E03-4DD2-A0BF-07AACA4A59C5"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c5520447-cc66-4a56-8004-104c8c0eb79c"),
                ReferenceItemUnitId = Guid.Parse("7BDE1C28-7CBA-417B-BCDC-CFB7771C22E1"),
                ConvertedItemUnitId = Guid.Parse("2879C596-0102-42A2-A7F5-E9AE3FA82700"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c56857df-e5bf-4ab2-8759-7bc5174b6913"),
                ReferenceItemUnitId = Guid.Parse("FC7E96A4-9490-46D6-9FB8-A43A3E4CF53C"),
                ConvertedItemUnitId = Guid.Parse("A6689121-2A94-49EF-B5A7-3BE915BEB1EF"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c86b69b6-28eb-494d-96b8-76435d1f4975"),
                ReferenceItemUnitId = Guid.Parse("A5E5B942-A590-4D31-B218-4AF6940013EA"),
                ConvertedItemUnitId = Guid.Parse("E1E28CA9-8312-4E72-9228-EE9253ABC6BD"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c8a197e0-a4aa-49ce-8be1-ba2c844f8aca"),
                ReferenceItemUnitId = Guid.Parse("BAAD74F2-AF6C-47B3-B9B5-C057BF315E40"),
                ConvertedItemUnitId = Guid.Parse("DEA1B296-7034-47D3-9E33-640EEBFC82A6"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c8fd82ca-78a1-49d3-9c49-4459fa588122"),
                ReferenceItemUnitId = Guid.Parse("A09ABBE2-ABDE-4142-8258-A697731DAEDB"),
                ConvertedItemUnitId = Guid.Parse("D330EAED-1555-4E56-A18A-E5C73120A559"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c9d914a5-712d-4a23-bbcd-db9a8d530405"),
                ReferenceItemUnitId = Guid.Parse("EC369480-42D1-4AB0-BA86-5031BD5B5805"),
                ConvertedItemUnitId = Guid.Parse("FBBA1F14-9E14-4211-BA6A-468FF571E3B4"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("c9f58b18-0d7a-4f94-bc49-ee059c8ecab5"),
                ReferenceItemUnitId = Guid.Parse("56EC3E91-B530-43BB-A6F2-DD5CD2DFFA98"),
                ConvertedItemUnitId = Guid.Parse("850B5E1B-17F3-4675-9983-E2BA146898F9"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ca10c901-3f4f-4a18-9a4a-fa64743344c6"),
                ReferenceItemUnitId = Guid.Parse("1CB2E917-4A39-48A5-AD33-D6BA092E4F55"),
                ConvertedItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ca18a120-35a8-4dfe-8aec-00f8d44b8dcc"),
                ReferenceItemUnitId = Guid.Parse("91DE61F9-069B-442A-8AC6-48A111741589"),
                ConvertedItemUnitId = Guid.Parse("B745B05E-3CA7-4E8E-A500-B266834849E9"),
                ConversionQuantity = 1080m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ca92c039-2fb2-4327-869f-bf0e500b73f0"),
                ReferenceItemUnitId = Guid.Parse("4B19F9EC-51E7-4019-9EB2-EE1EF4075482"),
                ConvertedItemUnitId = Guid.Parse("FBBA1F14-9E14-4211-BA6A-468FF571E3B4"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ca99740c-c74e-47bd-954c-7dfac1d8dd23"),
                ReferenceItemUnitId = Guid.Parse("CADBC882-35A4-4136-8C46-5A2AEEECC334"),
                ConvertedItemUnitId = Guid.Parse("926AFBBD-7010-41B5-88DC-3985C2E60C74"),
                ConversionQuantity = 384m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("cca0b353-ec23-43d0-89ad-97fa9c603a57"),
                ReferenceItemUnitId = Guid.Parse("5591EABE-8166-4FFF-A790-05D1A32F4E58"),
                ConvertedItemUnitId = Guid.Parse("5ADCD688-797D-455F-86A1-599BB1680C7D"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ccaddf3e-87db-4a31-bb94-508851ac7c80"),
                ReferenceItemUnitId = Guid.Parse("71034C39-8D15-45B1-9D16-3AF9F2406BD8"),
                ConvertedItemUnitId = Guid.Parse("DB2DE84F-51F3-4D91-A380-E22D49140092"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("cce5aab0-acc3-4714-be35-c0f823f02117"),
                ReferenceItemUnitId = Guid.Parse("AAD4E1F2-2A51-43F3-BD92-F6EB5989F8E0"),
                ConvertedItemUnitId = Guid.Parse("816236DD-9BC4-4C3B-8FB2-08247E598803"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("cef29d2d-bbed-48f2-8e03-bb0bfc0afd87"),
                ReferenceItemUnitId = Guid.Parse("BA49DF58-42EA-45B4-A108-C8DC454B77E5"),
                ConvertedItemUnitId = Guid.Parse("56BFD555-E5DD-459A-B6DF-E8FE4442FF3B"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ceffb34a-c0cb-48a0-9f4b-924d143ee9f4"),
                ReferenceItemUnitId = Guid.Parse("D22ACA86-16B4-4FD9-B728-6633293344D2"),
                ConvertedItemUnitId = Guid.Parse("452C3E2B-225C-4A15-BD5D-136220415A89"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d039ed5a-fd2b-464b-8f69-fb1240bbaef1"),
                ReferenceItemUnitId = Guid.Parse("B209E432-760B-4E30-A74E-F9398FE7DD4A"),
                ConvertedItemUnitId = Guid.Parse("70915CD3-8277-432F-9568-BE72C8EA8D0D"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d1cc3190-9b1e-4090-8004-3e2473b1f7fa"),
                ReferenceItemUnitId = Guid.Parse("A5915C84-800C-4B1E-B991-0D931B9285C6"),
                ConvertedItemUnitId = Guid.Parse("95B0A158-AF96-4FDF-914A-735E5A0B42A8"),
                ConversionQuantity = 20m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d459f995-0531-4dc9-8998-adce2184935e"),
                ReferenceItemUnitId = Guid.Parse("84706888-935D-45F8-BDA5-41E669068887"),
                ConvertedItemUnitId = Guid.Parse("DB2DE84F-51F3-4D91-A380-E22D49140092"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d6c213d5-a6eb-48aa-9c98-7ecc0d06c645"),
                ReferenceItemUnitId = Guid.Parse("EE39E74A-4801-431A-83C8-793C6776E999"),
                ConvertedItemUnitId = Guid.Parse("9C5795CD-26B2-4856-801D-65EBDA067997"),
                ConversionQuantity = 864m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d6c311c7-2f20-491b-8526-22574553965a"),
                ReferenceItemUnitId = Guid.Parse("00DCC232-DD8B-4744-851B-7254D0126787"),
                ConvertedItemUnitId = Guid.Parse("A072A88B-3F5F-46DA-A721-CEE61389ED33"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d76822d4-0c84-430c-bbd0-770d068fef7b"),
                ReferenceItemUnitId = Guid.Parse("22B2E013-E927-4BA1-A445-B249A2339599"),
                ConvertedItemUnitId = Guid.Parse("FC843637-9E15-43E2-A2C8-39AABA7CC9A1"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d7e364e5-0b12-4222-a426-d1b4fa0af319"),
                ReferenceItemUnitId = Guid.Parse("43CF57F9-52F2-4F8F-83AF-E9EC0ABFC63D"),
                ConvertedItemUnitId = Guid.Parse("516344F8-74F2-4B34-A39E-FD6ACFAD4422"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d8d2c39a-3a24-460a-85ec-f3984515b07f"),
                ReferenceItemUnitId = Guid.Parse("A541FF24-A58B-40C0-A052-B679D1578CF1"),
                ConvertedItemUnitId = Guid.Parse("A6CE04C3-871C-4C69-9BE6-10544155248E"),
                ConversionQuantity = 240m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d8d5061c-9586-4f67-a73f-78798ade7e13"),
                ReferenceItemUnitId = Guid.Parse("A7F0B97C-8659-458E-84DB-0BDC430EB2CE"),
                ConvertedItemUnitId = Guid.Parse("F86F5B6E-D11E-41DA-A6DF-621569B49FA8"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("d9306bbe-3a32-41b3-8ecd-791e2a1ad3e8"),
                ReferenceItemUnitId = Guid.Parse("E1D0D58B-7E94-4620-841E-8E0076D2A23E"),
                ConvertedItemUnitId = Guid.Parse("C6BE66B8-4BF9-4A31-BB53-333E483EB10B"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("dbba9ad4-2d3a-4df3-ab94-e1eb91a4b6e6"),
                ReferenceItemUnitId = Guid.Parse("75EAB908-2FFC-4806-8B63-E64503190DBB"),
                ConvertedItemUnitId = Guid.Parse("BD7756C9-A5E9-424E-9ED5-CE8C61EC8504"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("dc1c5eca-5837-4424-803c-67b6f5d74017"),
                ReferenceItemUnitId = Guid.Parse("0F00739D-B298-4263-8597-2B8B9D6D5D24"),
                ConvertedItemUnitId = Guid.Parse("E61D6DC4-7A4B-45DA-8015-2FBA4A03C8C2"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("dd3291a2-160f-454a-aaee-4d7c73d39ecf"),
                ReferenceItemUnitId = Guid.Parse("7C19662D-BB5C-4921-ACEB-12AFB6FA1E19"),
                ConvertedItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("e0b02b7a-896e-436c-8d3b-08e2f8003f1c"),
                ReferenceItemUnitId = Guid.Parse("5E11E7E2-03A9-429B-9583-0877C2F4C31F"),
                ConvertedItemUnitId = Guid.Parse("7563B910-54DD-402B-8E87-12B3A6CCF85C"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("e2c85b6a-d55b-40e9-9207-1aa052f304c9"),
                ReferenceItemUnitId = Guid.Parse("6044DB36-EB67-4B67-BEE4-B94FBF241300"),
                ConvertedItemUnitId = Guid.Parse("D56442E3-5858-4A1B-86D7-4A76F09A030A"),
                ConversionQuantity = 1080m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("e67535c5-a4b9-40d6-8f29-8280435d3697"),
                ReferenceItemUnitId = Guid.Parse("3CEB0F57-5AAB-4E4E-AB36-6B6A153AC0A1"),
                ConvertedItemUnitId = Guid.Parse("4B5E24AA-08CB-4F66-A738-57F0E648BF3C"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("e6e77912-c10d-4181-851c-bc51f88ec8a2"),
                ReferenceItemUnitId = Guid.Parse("9F4A273B-9BE3-4E32-8A2F-85CC1CC25100"),
                ConvertedItemUnitId = Guid.Parse("11B79889-EC4D-4407-83B6-9A8993A65791"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("e75d10f9-42b9-4d36-9e47-02ad71ebb763"),
                ReferenceItemUnitId = Guid.Parse("8416E77A-759A-4E64-90EF-EDA8361E8D54"),
                ConvertedItemUnitId = Guid.Parse("5FF76D80-E2F3-47F5-B8D4-4F4FED175FFB"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("e98d9845-fbda-4d33-baf1-c7555fa8f53f"),
                ReferenceItemUnitId = Guid.Parse("72F83A28-97C7-443B-A914-14FE8D5D2D6A"),
                ConvertedItemUnitId = Guid.Parse("816236DD-9BC4-4C3B-8FB2-08247E598803"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("e9bae01a-d12c-4801-b13f-d019d95434c4"),
                ReferenceItemUnitId = Guid.Parse("01A25038-AE16-4225-AD1A-A2BDB35F1055"),
                ConvertedItemUnitId = Guid.Parse("8D93EC54-CC09-4E41-A503-B454D72AD405"),
                ConversionQuantity = 144m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ea6497b7-d43d-4cf3-99aa-b26b2cce5cb1"),
                ReferenceItemUnitId = Guid.Parse("B8D66B8A-80FA-45C8-80ED-8262F4680DF9"),
                ConvertedItemUnitId = Guid.Parse("57BD0E35-C672-4BBA-9F69-5EA5D8378D8D"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("eae8da1a-1753-44ba-8103-c5c1d3736baa"),
                ReferenceItemUnitId = Guid.Parse("DE03EBE6-B011-404B-8838-660DED9394B2"),
                ConvertedItemUnitId = Guid.Parse("99BFF122-E390-45ED-A1AB-CC225A1C00C3"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("eb44c3fc-fd2c-4935-a66e-3e7409779736"),
                ReferenceItemUnitId = Guid.Parse("40BEBF59-6EBF-4014-B1B9-BAED653AE9AB"),
                ConvertedItemUnitId = Guid.Parse("926AFBBD-7010-41B5-88DC-3985C2E60C74"),
                ConversionQuantity = 16m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ec31389f-47e7-4680-a065-d76c05a61c07"),
                ReferenceItemUnitId = Guid.Parse("FD53AD02-DB0D-4F82-B541-A1BF4E16B870"),
                ConvertedItemUnitId = Guid.Parse("7B35130B-3186-472B-B9E5-174E5882AECC"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ec8751da-4ae6-498c-a383-e265c1486995"),
                ReferenceItemUnitId = Guid.Parse("9CD12FC2-DCA8-4E42-9DFB-C7347F4AB963"),
                ConvertedItemUnitId = Guid.Parse("9E915514-2ECB-48F9-B893-131869E73C0D"),
                ConversionQuantity = 288m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ed43729a-f034-499f-b1bc-0874992205c0"),
                ReferenceItemUnitId = Guid.Parse("1288C5D8-7798-4A0E-8BD8-6B36736DDA82"),
                ConvertedItemUnitId = Guid.Parse("850B5E1B-17F3-4675-9983-E2BA146898F9"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ee80adff-db9a-4105-9228-9697e024ace8"),
                ReferenceItemUnitId = Guid.Parse("10BD9EE8-878C-473C-9D10-560A26B997A9"),
                ConvertedItemUnitId = Guid.Parse("A072A88B-3F5F-46DA-A721-CEE61389ED33"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("eec7fc17-28c3-457a-adf0-e6e358321737"),
                ReferenceItemUnitId = Guid.Parse("4E87F9F4-FCC9-4656-8ABB-244974E67CFE"),
                ConvertedItemUnitId = Guid.Parse("AE1A4504-488D-40F8-92D1-9B0E842949FA"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f05fa54d-8e62-4cfa-b1bf-5be75af52a1a"),
                ReferenceItemUnitId = Guid.Parse("4B76900F-E041-4100-B5DD-5BFE49927717"),
                ConvertedItemUnitId = Guid.Parse("51C982C4-BD4E-463C-9C89-4571C25EB294"),
                ConversionQuantity = 360m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f1d59af5-b44f-4a9e-9ff6-e225624d7f96"),
                ReferenceItemUnitId = Guid.Parse("C8F363CC-D1F2-45F5-8C95-C0507B45D4B9"),
                ConvertedItemUnitId = Guid.Parse("FC33C8C9-02DC-47C3-8E08-5EDE6BC6DD46"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f29d2293-0cf0-429b-a025-e43df1a2e07b"),
                ReferenceItemUnitId = Guid.Parse("C925AB6D-6F03-42AB-89FB-C1E3C7CE02EB"),
                ConvertedItemUnitId = Guid.Parse("8DAAC8E8-0784-4AE3-8CD5-AAE250A2D185"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f45879d3-8937-4546-b530-58028845ae97"),
                ReferenceItemUnitId = Guid.Parse("15ABD40D-51FB-4F6F-B47F-50161380F45C"),
                ConvertedItemUnitId = Guid.Parse("7563B910-54DD-402B-8E87-12B3A6CCF85C"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f514ea31-4eb5-469f-a0dd-fb3af5021bb4"),
                ReferenceItemUnitId = Guid.Parse("BFA5C78D-25C3-4B51-9384-6E6D519EDD5C"),
                ConvertedItemUnitId = Guid.Parse("B745B05E-3CA7-4E8E-A500-B266834849E9"),
                ConversionQuantity = 15m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f56a2981-9515-459d-b5e4-d5a7b052e729"),
                ReferenceItemUnitId = Guid.Parse("D5DACF21-9245-41BC-8220-22E8A0F33650"),
                ConvertedItemUnitId = Guid.Parse("AD3F08F6-9D46-44DD-9356-684BA8345428"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f7646eaf-a216-4893-9181-3964e15d5911"),
                ReferenceItemUnitId = Guid.Parse("07C214EC-18E4-48A0-BDE5-AC3B54E23D47"),
                ConvertedItemUnitId = Guid.Parse("D9F8B3D1-07DD-4555-B220-D80565F42913"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f7ce9c45-1193-4bda-8b18-4ffb580e7c5b"),
                ReferenceItemUnitId = Guid.Parse("BB748E97-88B8-41F9-978C-A95C434553AB"),
                ConvertedItemUnitId = Guid.Parse("DB2DE84F-51F3-4D91-A380-E22D49140092"),
                ConversionQuantity = 24m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f7dcf5a2-e463-486e-aa10-fea406420789"),
                ReferenceItemUnitId = Guid.Parse("D3EA4F84-0FB7-4135-ABE9-4E06B5CD8DB1"),
                ConvertedItemUnitId = Guid.Parse("9E915514-2ECB-48F9-B893-131869E73C0D"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f874a22d-af82-4d35-9f04-b2bab72194e7"),
                ReferenceItemUnitId = Guid.Parse("39385DC7-A950-48D8-A2F2-D13AB91AEE10"),
                ConvertedItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f87fe8a6-1e38-4409-a8ba-ba3217f66828"),
                ReferenceItemUnitId = Guid.Parse("1145C680-A8BD-42DF-A0B5-DAA7E297D5E4"),
                ConvertedItemUnitId = Guid.Parse("B276767C-7C6E-49CA-8C54-9A19EE4F6A8E"),
                ConversionQuantity = 16m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f8e12ed8-d91d-42ad-8985-2818701e4be2"),
                ReferenceItemUnitId = Guid.Parse("DDA3D5CE-D040-4C0C-9158-647DDA5AE480"),
                ConvertedItemUnitId = Guid.Parse("4B5E24AA-08CB-4F66-A738-57F0E648BF3C"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f9273a0c-72c0-44c6-8758-c6a588d4e0bb"),
                ReferenceItemUnitId = Guid.Parse("44329E0A-F233-4698-831C-99C84438CEBA"),
                ConvertedItemUnitId = Guid.Parse("47AF2EB3-2E03-4DD2-A0BF-07AACA4A59C5"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f97289d1-a900-4c14-950b-e7da69569922"),
                ReferenceItemUnitId = Guid.Parse("BA5BD9BA-0C24-4085-AB2C-B88B1BECEE74"),
                ConvertedItemUnitId = Guid.Parse("CCFACEFC-73AF-46C8-BF6B-EE93A5445A67"),
                ConversionQuantity = 144m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("f9b32017-3d37-4517-b9e6-13d35b0c4965"),
                ReferenceItemUnitId = Guid.Parse("C59235B4-34F8-420D-B545-A8627636B557"),
                ConvertedItemUnitId = Guid.Parse("CFC16836-B3CD-401E-A148-CC6B1107AE01"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("fa322c2e-96c4-4cc5-83a1-d1196336ec53"),
                ReferenceItemUnitId = Guid.Parse("3F90EA94-6C91-4073-BF97-5D0DE5811E6D"),
                ConvertedItemUnitId = Guid.Parse("95B0A158-AF96-4FDF-914A-735E5A0B42A8"),
                ConversionQuantity = 10m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("fa70a945-bf88-403b-9d1a-14f09235224a"),
                ReferenceItemUnitId = Guid.Parse("65A3264C-1740-4153-8AAA-53B729B47C46"),
                ConvertedItemUnitId = Guid.Parse("FC843637-9E15-43E2-A2C8-39AABA7CC9A1"),
                ConversionQuantity = 18m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("fa77758d-bc10-49ee-bead-c96698906371"),
                ReferenceItemUnitId = Guid.Parse("00491241-3E02-406A-B058-026DDAFF9F26"),
                ConvertedItemUnitId = Guid.Parse("549E4987-498F-44B8-B9F3-37C702C28F99"),
                ConversionQuantity = 6m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("fa8eb61f-8c99-41b0-a20d-301a85d76b1c"),
                ReferenceItemUnitId = Guid.Parse("5BD53CFD-F2EF-42FD-AE8C-70C6B0E69B36"),
                ConvertedItemUnitId = Guid.Parse("70DF4295-57EA-4BEB-A9FC-5FD2E39440DC"),
                ConversionQuantity = 5m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("fb3c8b5b-a9ff-4334-86e5-05b41f684eea"),
                ReferenceItemUnitId = Guid.Parse("64D6F7A6-4F18-4D57-967E-A63FE656D903"),
                ConvertedItemUnitId = Guid.Parse("36D55F2C-567A-498D-AE16-521531BEC943"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("fb522abc-72b2-4015-ac9c-c4ba7e2ac350"),
                ReferenceItemUnitId = Guid.Parse("8A43504A-5825-4C88-A356-658C71219457"),
                ConvertedItemUnitId = Guid.Parse("AA7C8C4E-11D0-42DA-988D-FD9741E10BE5"),
                ConversionQuantity = 30m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("fbdbeb99-efa1-42bd-bb53-668cb796542d"),
                ReferenceItemUnitId = Guid.Parse("1F5F3187-BC0D-40F5-BB2C-299FDAD3D4AB"),
                ConvertedItemUnitId = Guid.Parse("8DB6CD59-4BA4-49E2-9992-B025A7895DA4"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("fc4bde68-81ec-4172-90f3-76c03e048c8f"),
                ReferenceItemUnitId = Guid.Parse("F4134AF3-DC5B-42A4-A620-19085DA0F87E"),
                ConvertedItemUnitId = Guid.Parse("BCD8966A-878A-4C12-9682-F8E27319C013"),
                ConversionQuantity = 384m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("fe3ab9ad-b180-4dbc-ac1f-5f1eab7528df"),
                ReferenceItemUnitId = Guid.Parse("6DDB5A9D-3FD4-4095-88CF-730BA89D3C06"),
                ConvertedItemUnitId = Guid.Parse("7B35130B-3186-472B-B9E5-174E5882AECC"),
                ConversionQuantity = 12m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ff29cd84-583a-4ba3-bb80-442b8b86ed89"),
                ReferenceItemUnitId = Guid.Parse("DEA0342F-6DF6-4109-A731-D9BD1A2D9412"),
                ConvertedItemUnitId = Guid.Parse("B165AAFA-90A7-41FA-9508-1C56FCE5C1AF"),
                ConversionQuantity = 720m,
                CreatedDate = DateTime.Now,
            },
            new ItemUnitConversion
            {
                Id = Guid.Parse("ff602662-b608-4664-88f7-0e9332d400cc"),
                ReferenceItemUnitId = Guid.Parse("BD99FDC7-BEB4-4FB5-AE54-4B90FBAB4C48"),
                ConvertedItemUnitId = Guid.Parse("8CE82425-296E-41C2-82FD-0A36DEEB6023"),
                ConversionQuantity = 36m,
                CreatedDate = DateTime.Now,
            }

        );
    }
}
