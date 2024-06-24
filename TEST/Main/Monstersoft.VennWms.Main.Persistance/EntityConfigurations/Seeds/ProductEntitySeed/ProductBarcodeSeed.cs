using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ProductBarcodeSeed : IEntityTypeConfiguration<ProductBarcode>
{
    public void Configure(EntityTypeBuilder<ProductBarcode> builder)
    {
        builder.HasData(
            new ProductBarcode
            {
                Id = Guid.Parse("00084897-d257-4d7d-8bda-9ec75499c076"),
                ProductId = Guid.Parse("27B22F2A-5D8B-40D2-9F6E-3FEC92DE9A71"),
                ItemUnitId = Guid.Parse("BB748E97-88B8-41F9-978C-A95C434553AB"),
                BarcodeString = "7810313863701",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0015e6aa-f12e-48e8-9e45-9794f708b6c0"),
                ProductId = Guid.Parse("1987A609-D7FC-4EF9-8175-04A08D371015"),
                ItemUnitId = Guid.Parse("EF442921-A207-4C18-9A5F-C67029B36B69"),
                BarcodeString = "9930141620023",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("00997ce8-8509-42c4-8c79-d8ff017a515d"),
                ProductId = Guid.Parse("2C7AFEDF-7D80-4486-861A-9EA50DBEE9FC"),
                ItemUnitId = Guid.Parse("E8483812-85FF-49AC-835D-59A16DD9DC81"),
                BarcodeString = "8711969642653",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("00bb46f2-201b-4433-8a63-3c93efa659b9"),
                ProductId = Guid.Parse("E7CB3414-C0B4-4884-B9EA-A10E13C49337"),
                ItemUnitId = Guid.Parse("FC843637-9E15-43E2-A2C8-39AABA7CC9A1"),
                BarcodeString = "9876932907357",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("00bd85b3-2976-4d7e-85d0-4b3bf49b36a5"),
                ProductId = Guid.Parse("30943E74-2644-4848-B12A-B385EBE76F3E"),
                ItemUnitId = Guid.Parse("32E98BE2-6CE7-4059-8D91-9EFC106EE97F"),
                BarcodeString = "7356050819088",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("016a3a65-f2af-4a40-a002-ba5f6c45076a"),
                ProductId = Guid.Parse("09B413E9-02B8-4FE7-9646-75B7ACDF1FEF"),
                ItemUnitId = Guid.Parse("A1F216AA-FF63-4239-904A-D111B57095EF"),
                BarcodeString = "9684886708163",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("020d81a0-0a53-4550-b4d1-32ffe7ed2a5f"),
                ProductId = Guid.Parse("39A9C0D5-F8B3-43AB-8A05-4F94DCE7AA10"),
                ItemUnitId = Guid.Parse("3D591290-FC42-4958-817C-93907AA54857"),
                BarcodeString = "9523445857713",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("026bc994-86fa-48cd-a2ea-25da15b08977"),
                ProductId = Guid.Parse("93B43571-A79A-4FFE-9112-4C48B400A8A9"),
                ItemUnitId = Guid.Parse("888E6E0F-F467-49AA-A67F-217A7628525D"),
                BarcodeString = "6143749684875",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("030fe4d7-9d6a-4681-be99-2bc5b18afa32"),
                ProductId = Guid.Parse("1535C81D-E2E1-43F4-B7DA-5F102896277D"),
                ItemUnitId = Guid.Parse("BBA68587-F66C-4F25-AAE4-7E286021F666"),
                BarcodeString = "6806299780874",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("036328e7-c9d4-4f42-a955-813ca129e7fd"),
                ProductId = Guid.Parse("17497A0A-8F97-42E5-909C-AA52D0853A51"),
                ItemUnitId = Guid.Parse("AE1A4504-488D-40F8-92D1-9B0E842949FA"),
                BarcodeString = "7041214780728",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0377e437-7e46-4088-a196-dfbf495a7367"),
                ProductId = Guid.Parse("42D23B7E-70C4-49A7-BB2A-6D27D2F727D6"),
                ItemUnitId = Guid.Parse("CFC16836-B3CD-401E-A148-CC6B1107AE01"),
                BarcodeString = "7799942609380",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("04d874a1-0b4b-41eb-8845-a4aa78459250"),
                ProductId = Guid.Parse("4007CA39-2AAA-45E2-BD6C-ECB16E0A69CE"),
                ItemUnitId = Guid.Parse("E3D128DF-2C79-4905-8AB2-3F75105E3196"),
                BarcodeString = "8015541967432",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("04dc20f1-90b7-4887-9f8b-67212dcb56a5"),
                ProductId = Guid.Parse("E19B56EF-BC63-4376-A258-247B51C2AC3A"),
                ItemUnitId = Guid.Parse("DFC1CC60-B199-4D05-AB23-0ED7113AC974"),
                BarcodeString = "7818871709709",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("052eb92b-4763-4493-90b9-197e2716fe07"),
                ProductId = Guid.Parse("40667126-379B-4BFC-A9F3-88F74C17EE8A"),
                ItemUnitId = Guid.Parse("11B79889-EC4D-4407-83B6-9A8993A65791"),
                BarcodeString = "9709642925395",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("057b3638-336c-424c-808a-34d39726149b"),
                ProductId = Guid.Parse("CC92C663-85C3-4BCA-8333-66B04380979B"),
                ItemUnitId = Guid.Parse("0D2D0F4A-D498-4B03-8D4A-42F430ACFD33"),
                BarcodeString = "9094555860909",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("059ebeae-9413-433c-bbfe-93005a1988a1"),
                ProductId = Guid.Parse("02369CE6-745F-471D-9862-976C6344927B"),
                ItemUnitId = Guid.Parse("C001F089-7DCA-4AFA-A940-BB3CB3B3CF49"),
                BarcodeString = "6353288650640",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("06d4a59b-65f7-4fd9-acad-9810472a7005"),
                ProductId = Guid.Parse("1169946B-7C0C-48E4-88A7-A47F7BD5FFA8"),
                ItemUnitId = Guid.Parse("E6DC91CA-3B06-4EBD-B58C-22E771A41568"),
                BarcodeString = "7340341785329",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("06e1ce89-c8bc-4f1f-a2e3-81d19d6b5e06"),
                ProductId = Guid.Parse("1CD42C42-00E0-4C41-A7D4-61BC7F52644D"),
                ItemUnitId = Guid.Parse("22EE5C1B-54BD-4638-B5C0-B5928B8E937F"),
                BarcodeString = "6667236732288",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("07492325-cb24-4459-9458-6f11706d46e5"),
                ProductId = Guid.Parse("BA3F09BD-A0E1-4026-9F8E-48FA01B1E97E"),
                ItemUnitId = Guid.Parse("33B554FF-7599-4710-A3FF-0EB1D8C52259"),
                BarcodeString = "8451334889856",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("07e67a00-3f6c-4b97-a5f3-ed658e0ccadd"),
                ProductId = Guid.Parse("84974822-B09E-4AE5-A793-AE8D52091647"),
                ItemUnitId = Guid.Parse("AB567010-71F7-4BFC-A47F-FB113A4B1186"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("080a758d-ad87-4077-8f5f-bac10255f93f"),
                ProductId = Guid.Parse("91276161-7358-4680-8FD6-A45FA83C3413"),
                ItemUnitId = Guid.Parse("B1D8BE28-84EA-447E-B816-E8E8C17166F4"),
                BarcodeString = "9187788915687",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("08187fc0-70dc-4de8-8258-60b4aca33102"),
                ProductId = Guid.Parse("068E8333-8AA7-4AC2-A944-FF96434F6AC2"),
                ItemUnitId = Guid.Parse("CADBC882-35A4-4136-8C46-5A2AEEECC334"),
                BarcodeString = "8091792978103",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("08a48efb-aee5-4496-af05-ae73044bc576"),
                ProductId = Guid.Parse("7B6B14E1-8014-4755-A20A-69DDAD87A1B3"),
                ItemUnitId = Guid.Parse("FBBA1F14-9E14-4211-BA6A-468FF571E3B4"),
                BarcodeString = "9213556693923",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("099b0d87-6590-4516-8a02-a7cb1513899e"),
                ProductId = Guid.Parse("AE325DB7-B0EA-4C72-9FCA-59B680C4209A"),
                ItemUnitId = Guid.Parse("6E97A116-9D7A-41ED-B273-B85F798C1EC0"),
                BarcodeString = "7965487891414",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0a95c925-9afa-4537-bc70-50a04d67b04d"),
                ProductId = Guid.Parse("0C20D2A3-0ECB-497C-B963-D8AA4E88B2D8"),
                ItemUnitId = Guid.Parse("4B5E24AA-08CB-4F66-A738-57F0E648BF3C"),
                BarcodeString = "8669699842965",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0b3c6b08-30ae-4815-90ea-1b006afef10d"),
                ProductId = Guid.Parse("259EEC3C-C5CA-4715-8D64-9423EF301586"),
                ItemUnitId = Guid.Parse("9CACBC01-D505-4FA2-A678-2A43DC0398E3"),
                BarcodeString = "7036075608805",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0b6d53d5-e039-4e3d-891f-3b8f95de954b"),
                ProductId = Guid.Parse("CC92C663-85C3-4BCA-8333-66B04380979B"),
                ItemUnitId = Guid.Parse("D9DD70E1-A7F9-47BD-BA23-187580117730"),
                BarcodeString = "9681148827528",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0c0d1bab-42d9-42fc-80e0-77a207b3fe97"),
                ProductId = Guid.Parse("F7D4DB5B-C00F-4D8C-B9F8-AB85F5D04D0F"),
                ItemUnitId = Guid.Parse("9BF1B741-98FE-4238-944F-71808D7E91C1"),
                BarcodeString = "6296589621753",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0c951fc2-eeeb-4ce6-8996-9d10366f545e"),
                ProductId = Guid.Parse("0F355ACB-83A6-459E-8E5B-8CEDF1BE204A"),
                ItemUnitId = Guid.Parse("8A43504A-5825-4C88-A356-658C71219457"),
                BarcodeString = "9612337751368",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0ceb1368-925a-486d-9308-40747b4a081a"),
                ProductId = Guid.Parse("836FA41A-AEB7-4C7C-9CE3-5BD1A99A1B46"),
                ItemUnitId = Guid.Parse("07C214EC-18E4-48A0-BDE5-AC3B54E23D47"),
                BarcodeString = "8085299744778",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0cf71c46-0752-4130-86bb-95a3714fcaea"),
                ProductId = Guid.Parse("1535C81D-E2E1-43F4-B7DA-5F102896277D"),
                ItemUnitId = Guid.Parse("59E156EA-3FAE-4F56-8A3A-7B9337633C00"),
                BarcodeString = "9850800900419",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0d7e6526-a7aa-4298-be42-37f5f793ac90"),
                ProductId = Guid.Parse("ED170CD5-03F5-4872-8D09-7C562DEE0E1C"),
                ItemUnitId = Guid.Parse("4C24C671-A9C3-47BC-918E-E1D3080461F6"),
                BarcodeString = "8765430865454",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0dad5956-78fe-4ef5-a080-598f17d05d8f"),
                ProductId = Guid.Parse("774490DA-CCC9-4754-ACEA-5E6754BE7FDD"),
                ItemUnitId = Guid.Parse("3645C383-3582-40B5-9223-B2475B556FA4"),
                BarcodeString = "7306217916535",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("0edb2b6c-95be-4e68-a03c-5896f47e76df"),
                ProductId = Guid.Parse("B1E0AE2B-B271-4613-89D8-8575564A6944"),
                ItemUnitId = Guid.Parse("5591EABE-8166-4FFF-A790-05D1A32F4E58"),
                BarcodeString = "8960811819207",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("104cb4eb-5c8f-4d3f-ad0d-317961395928"),
                ProductId = Guid.Parse("0C916C7A-F3E0-4E0A-B9BA-F61D2816861D"),
                ItemUnitId = Guid.Parse("C6BE66B8-4BF9-4A31-BB53-333E483EB10B"),
                BarcodeString = "8473996706111",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("112e3657-ccd9-4b36-88f7-0ef8f0dbf172"),
                ProductId = Guid.Parse("55EA8E5F-76F7-4F52-BBE8-2DF4D1D522E8"),
                ItemUnitId = Guid.Parse("8DAAC8E8-0784-4AE3-8CD5-AAE250A2D185"),
                BarcodeString = "7004162918089",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("11cc9b64-d667-404b-bf91-bb0db058e7a4"),
                ProductId = Guid.Parse("2C7AFEDF-7D80-4486-861A-9EA50DBEE9FC"),
                ItemUnitId = Guid.Parse("5C4A7F79-21A2-424B-B3F5-805636293F84"),
                BarcodeString = "7885798963169",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("128c9030-bd0d-4bed-ae9e-1f7157c2e5c6"),
                ProductId = Guid.Parse("C567F6F5-0D4A-4B9F-A537-9EF9BF4FB92D"),
                ItemUnitId = Guid.Parse("353AE184-1737-408D-8DA3-A9A52A3281D7"),
                BarcodeString = "6030051771930",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("14ede7d9-2f37-4d41-9262-4ec31ba562f4"),
                ProductId = Guid.Parse("65E8B711-3862-4588-8317-1E182BEB9655"),
                ItemUnitId = Guid.Parse("622150F3-8917-4BF3-A484-710BDD0A7EA5"),
                BarcodeString = "8037069751142",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("15881e99-f6a7-4d09-98e9-fede30cff96b"),
                ProductId = Guid.Parse("0C916C7A-F3E0-4E0A-B9BA-F61D2816861D"),
                ItemUnitId = Guid.Parse("595E62F0-EC10-41DB-B460-901119A806E0"),
                BarcodeString = "7018747912876",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1599013f-cb9c-416e-80ac-fe015676bc7e"),
                ProductId = Guid.Parse("E0268B02-2174-40CB-8630-4911D407C52A"),
                ItemUnitId = Guid.Parse("79A9294F-62EC-4313-A081-B8C5FD8169FE"),
                BarcodeString = "9791192746920",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("16008aea-f1ae-4381-b320-4786360181ed"),
                ProductId = Guid.Parse("30943E74-2644-4848-B12A-B385EBE76F3E"),
                ItemUnitId = Guid.Parse("CF0F63C9-BC5C-4B46-ADB1-42AF5D7C48FA"),
                BarcodeString = "7442421918981",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1743f100-8c14-4c8d-b44f-24837172e598"),
                ProductId = Guid.Parse("CC92C663-85C3-4BCA-8333-66B04380979B"),
                ItemUnitId = Guid.Parse("07076D2C-EFCE-4CB2-A31E-A3DBF7FE4A97"),
                BarcodeString = "7564431620172",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1913dcf0-b432-40c7-ac83-ac75b34e3731"),
                ProductId = Guid.Parse("55EA8E5F-76F7-4F52-BBE8-2DF4D1D522E8"),
                ItemUnitId = Guid.Parse("AF6A38CC-0881-45AA-8C4C-DC058F6C3B3B"),
                BarcodeString = "9779332802961",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("198f1e5f-c1db-4772-9e7a-3a70e596cb31"),
                ProductId = Guid.Parse("C1E9C300-DFB2-4D59-B24B-D325E73EED61"),
                ItemUnitId = Guid.Parse("68527238-83B6-468A-B57F-47C51E8CF400"),
                BarcodeString = "6434853876535",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1a8d3b47-f0a4-4320-9066-2dce487645de"),
                ProductId = Guid.Parse("0F355ACB-83A6-459E-8E5B-8CEDF1BE204A"),
                ItemUnitId = Guid.Parse("8ACE3C2C-B2CF-41FC-A8D2-17ACADDB17C9"),
                BarcodeString = "9672867969789",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1abc905f-205b-477e-811a-4e4f220c4c55"),
                ProductId = Guid.Parse("10D533B7-CC9E-4A60-B65D-109F90D86E7D"),
                ItemUnitId = Guid.Parse("D744201B-4638-41EF-9F67-4D3B2E4BB858"),
                BarcodeString = "6550168942445",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1ae81712-b842-4651-93fc-32120d781acc"),
                ProductId = Guid.Parse("1987A609-D7FC-4EF9-8175-04A08D371015"),
                ItemUnitId = Guid.Parse("21D74012-E7DB-4F96-8D00-773F320C8DCE"),
                BarcodeString = "7123327984008",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1c2e05d3-2f5f-455f-81a6-d663391a3a8e"),
                ProductId = Guid.Parse("00D22996-340A-46CC-8D64-2C103CB59ACF"),
                ItemUnitId = Guid.Parse("44C6DB6A-3F47-402C-9A07-B7361E7B2D87"),
                BarcodeString = "9350360602696",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1d14fdf8-b9ec-46b1-bafb-854a58074b29"),
                ProductId = Guid.Parse("A33AAA45-B6D5-48B6-ACFC-37B79BA4BBC2"),
                ItemUnitId = Guid.Parse("406C7FD9-5AC6-4BDB-B2FB-AF62F8BBA872"),
                BarcodeString = "7558323739701",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1ddb5b03-1c20-4844-a79e-0c6ea695ec44"),
                ProductId = Guid.Parse("F7439C76-4855-465F-832F-D2B3A845A25D"),
                ItemUnitId = Guid.Parse("FA58F9C3-25C0-4580-B1EC-1FC48B7EB57F"),
                BarcodeString = "8384881867875",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1f2b2443-0892-4a29-a865-cdd083f22c51"),
                ProductId = Guid.Parse("47278DB5-239B-43BE-81AE-89AF3AAF0443"),
                ItemUnitId = Guid.Parse("19192C15-01EA-4C21-9D8B-AD77D51E6A84"),
                BarcodeString = "9968942726707",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("1f8298b4-9f2c-465c-a446-6dbc55e15736"),
                ProductId = Guid.Parse("514ED67A-E441-4A5C-809C-423EB99EBBCC"),
                ItemUnitId = Guid.Parse("36D55F2C-567A-498D-AE16-521531BEC943"),
                BarcodeString = "8961492963528",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("203c9494-85db-4dfa-b595-4f748be25e0f"),
                ProductId = Guid.Parse("1169946B-7C0C-48E4-88A7-A47F7BD5FFA8"),
                ItemUnitId = Guid.Parse("698C29D2-6893-4C29-A0B3-6EB41FC5A542"),
                BarcodeString = "7964408996901",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("20db1f8d-985a-448b-b190-284c475b9825"),
                ProductId = Guid.Parse("42D23B7E-70C4-49A7-BB2A-6D27D2F727D6"),
                ItemUnitId = Guid.Parse("C59235B4-34F8-420D-B545-A8627636B557"),
                BarcodeString = "9722614881931",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("21147e35-dd11-49e0-8468-927d7ed08c8f"),
                ProductId = Guid.Parse("AE325DB7-B0EA-4C72-9FCA-59B680C4209A"),
                ItemUnitId = Guid.Parse("B165AAFA-90A7-41FA-9508-1C56FCE5C1AF"),
                BarcodeString = "8351839931576",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("236c9e77-97cc-4c27-adbd-e4c72f5949cd"),
                ProductId = Guid.Parse("91EBEBFA-B2CB-4856-8292-5EB2333D4B82"),
                ItemUnitId = Guid.Parse("4AAA2FBC-B7D9-451A-BCE3-8EB95EDF18F6"),
                BarcodeString = "8407017904854",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("2403abf8-eac2-41da-8fbb-84e0b6b6ee46"),
                ProductId = Guid.Parse("E7CB3414-C0B4-4884-B9EA-A10E13C49337"),
                ItemUnitId = Guid.Parse("65A3264C-1740-4153-8AAA-53B729B47C46"),
                BarcodeString = "8600590601853",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("247484e7-a0ed-4c4b-bd3e-10db1503c80c"),
                ProductId = Guid.Parse("05F16EE5-B3E2-4EA7-B5BF-16ED86D84CCE"),
                ItemUnitId = Guid.Parse("9A112C35-D62D-4F38-8C60-C7FFCBF29D3D"),
                BarcodeString = "9711858780219",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("24a32155-57e3-4c8d-a561-5bec8f00e427"),
                ProductId = Guid.Parse("E19B56EF-BC63-4376-A258-247B51C2AC3A"),
                ItemUnitId = Guid.Parse("18B4EC5F-1A35-4B55-AC7B-22C0112EE28E"),
                BarcodeString = "7177503841135",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("257a3a19-8b10-42a6-95d5-a063d20773e7"),
                ProductId = Guid.Parse("4787896C-3176-4AA1-B59F-DC435BDA8EAD"),
                ItemUnitId = Guid.Parse("77CB5BEF-0AAD-470E-B697-06C6F1587787"),
                BarcodeString = "6244905844618",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("25a717d3-8c94-4c17-810d-9b3f5605632d"),
                ProductId = Guid.Parse("CAC2533D-31B1-402D-B093-B7152F88F7CF"),
                ItemUnitId = Guid.Parse("6DDB5A9D-3FD4-4095-88CF-730BA89D3C06"),
                BarcodeString = "7679198913216",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("25bff489-6535-4d1b-a1e5-20628fbc68e2"),
                ProductId = Guid.Parse("F1E438F5-778D-42F8-A81E-0F0B3D97EFB4"),
                ItemUnitId = Guid.Parse("2EE47897-D499-451B-AEB0-09EC28451FA6"),
                BarcodeString = "8024741907568",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("276b37b5-af21-4786-9c76-a7d30a0d2b60"),
                ProductId = Guid.Parse("CAC2533D-31B1-402D-B093-B7152F88F7CF"),
                ItemUnitId = Guid.Parse("7B35130B-3186-472B-B9E5-174E5882AECC"),
                BarcodeString = "8807744819245",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("27b57a46-5748-41e0-a417-5ff8ef4049b1"),
                ProductId = Guid.Parse("368D3792-52AE-4CBF-A3E1-FFB70A867E0B"),
                ItemUnitId = Guid.Parse("5F9E7E3A-DD89-4517-B7FB-C7780E6640A9"),
                BarcodeString = "6893944603474",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("27e6be3b-1203-463e-af83-ac8d8962b66f"),
                ProductId = Guid.Parse("7B6B14E1-8014-4755-A20A-69DDAD87A1B3"),
                ItemUnitId = Guid.Parse("4B19F9EC-51E7-4019-9EB2-EE1EF4075482"),
                BarcodeString = "6967186697065",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("2943c283-8ea4-4efa-adb6-9468ae712f4f"),
                ProductId = Guid.Parse("1564475B-EBCA-4BB3-8DE1-328AF49C0E1F"),
                ItemUnitId = Guid.Parse("F383C241-545D-4A45-8188-1E5CBA359E3F"),
                BarcodeString = "9161696883636",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("296d0eb6-9b3a-4c01-8f6f-8bcb0d58f1f5"),
                ProductId = Guid.Parse("D11CD853-1D91-46AE-95B4-B6F9F183E5CB"),
                ItemUnitId = Guid.Parse("C360A841-3358-424F-8B97-2AD2D6D9D06C"),
                BarcodeString = "6562745745829",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("298bb47b-af8b-44ab-9917-4765b93aea08"),
                ProductId = Guid.Parse("17497A0A-8F97-42E5-909C-AA52D0853A51"),
                ItemUnitId = Guid.Parse("4E87F9F4-FCC9-4656-8ABB-244974E67CFE"),
                BarcodeString = "9165078971086",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("2a5bbe59-aa0d-448b-8e18-2a2f43637f0d"),
                ProductId = Guid.Parse("F7D4DB5B-C00F-4D8C-B9F8-AB85F5D04D0F"),
                ItemUnitId = Guid.Parse("FC7E96A4-9490-46D6-9FB8-A43A3E4CF53C"),
                BarcodeString = "7276782624812",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("2b17024a-5fa4-4cd3-93ab-5c77a72b6ee4"),
                ProductId = Guid.Parse("E0268B02-2174-40CB-8630-4911D407C52A"),
                ItemUnitId = Guid.Parse("56BFD555-E5DD-459A-B6DF-E8FE4442FF3B"),
                BarcodeString = "8536996748268",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("2c910034-0349-4a14-a879-28fe7056403a"),
                ProductId = Guid.Parse("B40836D7-6A05-4D61-B2F2-B8344D6996F3"),
                ItemUnitId = Guid.Parse("087849B0-CBCD-4AB7-82DF-6966EC353F84"),
                BarcodeString = "8415759600406",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("2e94608e-4813-4532-ab62-b51819603873"),
                ProductId = Guid.Parse("D11CD853-1D91-46AE-95B4-B6F9F183E5CB"),
                ItemUnitId = Guid.Parse("8B4B0F5D-856F-49D2-82AF-61A87DFC10D1"),
                BarcodeString = "6413235631485",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("2f40b353-3aec-4d13-8b72-ddf84da08b45"),
                ProductId = Guid.Parse("09F106A7-DFFC-4868-97D4-9EE24B244B0C"),
                ItemUnitId = Guid.Parse("C2B7D00B-8560-4CDF-AEAB-E27324124643"),
                BarcodeString = "6087776841748",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("307a1e4b-0c4a-443f-99ea-e82aee45850b"),
                ProductId = Guid.Parse("F20C1167-4751-46F0-9A33-AC3D8D00A991"),
                ItemUnitId = Guid.Parse("E6122F5C-CA8A-48C8-B223-F1ABE656E906"),
                BarcodeString = "9310362999893",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("31bf65db-f9a6-4da9-8b22-80abae519881"),
                ProductId = Guid.Parse("C493BB30-902F-4F54-830F-A3D6B1683A2B"),
                ItemUnitId = Guid.Parse("5DB21F4D-70C4-41DA-9047-0A2B11F4AF8A"),
                BarcodeString = "8137723602367",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("31fb12a8-78e4-4875-b1ad-7ce61c86d943"),
                ProductId = Guid.Parse("04202692-9052-4977-B297-683369796EE6"),
                ItemUnitId = Guid.Parse("BCD8966A-878A-4C12-9682-F8E27319C013"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("320bf53f-d53b-43fb-87f5-f01120372ab8"),
                ProductId = Guid.Parse("E89EFE13-8CE5-45B1-BD6F-747695519A84"),
                ItemUnitId = Guid.Parse("774AFA26-3D7E-4571-B312-6CCF23B6AACC"),
                BarcodeString = "7924461846480",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3288a1bc-07d5-40df-a05d-5cf7e923b29e"),
                ProductId = Guid.Parse("84974822-B09E-4AE5-A793-AE8D52091647"),
                ItemUnitId = Guid.Parse("482F08F0-7654-4784-A21F-21B4CC567CAD"),
                BarcodeString = "8179876861409",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3400aa09-e98a-40ea-a2d1-3ac4c6189117"),
                ProductId = Guid.Parse("93B43571-A79A-4FFE-9112-4C48B400A8A9"),
                ItemUnitId = Guid.Parse("15A4B699-E45E-4F3E-A732-F71E76591E36"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("340151b2-1024-489f-a722-65771f74d274"),
                ProductId = Guid.Parse("08E07219-C245-436E-BD33-86B05E2C6A26"),
                ItemUnitId = Guid.Parse("1BD20A9A-A2CD-4F99-8D1B-9CEE18992D9E"),
                BarcodeString = "7754002897276",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("34c26bdb-1ad2-41cc-8d9d-8d182cca5e2d"),
                ProductId = Guid.Parse("1681FBD9-A2C4-4EA0-B0C9-38439E239DE9"),
                ItemUnitId = Guid.Parse("3F4D10F0-ED24-4A87-9F2E-44BBB582CC7B"),
                BarcodeString = "7154112855001",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("356b1510-85cc-4a9c-bc69-c7b554de2fc6"),
                ProductId = Guid.Parse("0C916C7A-F3E0-4E0A-B9BA-F61D2816861D"),
                ItemUnitId = Guid.Parse("E1D0D58B-7E94-4620-841E-8E0076D2A23E"),
                BarcodeString = "9306903761194",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("357828e8-dd7e-4b03-ab84-fb58794f4e21"),
                ProductId = Guid.Parse("836FA41A-AEB7-4C7C-9CE3-5BD1A99A1B46"),
                ItemUnitId = Guid.Parse("D9F8B3D1-07DD-4555-B220-D80565F42913"),
                BarcodeString = "8396003824402",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("35fe58de-1bec-4f26-973f-a4abc5f346de"),
                ProductId = Guid.Parse("FBF09C48-C1D5-4A16-BDAF-3E5535D983AF"),
                ItemUnitId = Guid.Parse("421DCA12-76C0-48E1-9B87-C93391E1BEF8"),
                BarcodeString = "8122130634932",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("36ed4e29-1cd4-4ae3-ba0c-2de69c31af01"),
                ProductId = Guid.Parse("AB8B3752-727D-4FCE-A139-D3E7F1E9664A"),
                ItemUnitId = Guid.Parse("B745B05E-3CA7-4E8E-A500-B266834849E9"),
                BarcodeString = "8241328867985",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("376c2b33-b173-43de-9906-225f679da556"),
                ProductId = Guid.Parse("5868A3DF-C076-4DAE-88ED-A763A8E2C2D9"),
                ItemUnitId = Guid.Parse("39DA5472-7CBF-45F4-B607-14F223F61BAD"),
                BarcodeString = "9479276727728",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("38c75f31-19d0-4e65-8764-e4654e70b5aa"),
                ProductId = Guid.Parse("04610291-8C35-4655-BA9B-48198D0D6457"),
                ItemUnitId = Guid.Parse("10FAFC6B-81EB-431A-A991-BB4A5AA1D566"),
                BarcodeString = "9801056611661",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3908fd0b-855a-4893-932c-291ec187a6d1"),
                ProductId = Guid.Parse("1D0FBE6C-D3CC-4D0F-A20A-122A1EE25190"),
                ItemUnitId = Guid.Parse("8D305EBD-45D9-4094-88E8-DB4C148F11D2"),
                BarcodeString = "9231906651631",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("39a067a7-3d06-45bc-80b7-bae306b728b2"),
                ProductId = Guid.Parse("4F64A707-DE84-471A-BC9D-D3A890C59F55"),
                ItemUnitId = Guid.Parse("36D858F1-B76C-4C53-B724-A6FC39B9B62D"),
                BarcodeString = "7173860807990",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3a03e422-5ff8-4f52-939a-8aa1fbb8b422"),
                ProductId = Guid.Parse("42D23B7E-70C4-49A7-BB2A-6D27D2F727D6"),
                ItemUnitId = Guid.Parse("95787353-61B6-4C1C-A55C-3024506EC7A5"),
                BarcodeString = "8628461855416",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3a06061c-7a0d-40ff-bad7-72aaf47f1d57"),
                ProductId = Guid.Parse("AAFDBACD-4121-476B-AEF6-84DB6462BE82"),
                ItemUnitId = Guid.Parse("6044DB36-EB67-4B67-BEE4-B94FBF241300"),
                BarcodeString = "8842326647917",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3a652fb7-b3a8-429d-a70d-075bb84e47a8"),
                ProductId = Guid.Parse("F7439C76-4855-465F-832F-D2B3A845A25D"),
                ItemUnitId = Guid.Parse("0D3ACE8E-04D3-4733-A359-76E13191E054"),
                BarcodeString = "8951684701609",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3bca44d3-524a-4199-8d9b-dcefe206952c"),
                ProductId = Guid.Parse("87538842-18E0-41E5-AD77-9E3E7F998C40"),
                ItemUnitId = Guid.Parse("F5F4FC1B-9527-49CD-BEE1-2B3CB29BC43E"),
                BarcodeString = "8171011759043",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3c17d143-3229-41e5-94fd-ccb66c0ecf7b"),
                ProductId = Guid.Parse("6041BBC6-DE60-455C-9556-CA9DBBC95740"),
                ItemUnitId = Guid.Parse("D330EAED-1555-4E56-A18A-E5C73120A559"),
                BarcodeString = "9469470865356",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3c35bbd5-a7d6-422d-9cd9-e4e882c42247"),
                ProductId = Guid.Parse("91276161-7358-4680-8FD6-A45FA83C3413"),
                ItemUnitId = Guid.Parse("4C63A204-9A6C-41D6-88DA-912D635CDA06"),
                BarcodeString = "8450564959182",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3cecdd20-eed1-44a8-a4df-865db684c91b"),
                ProductId = Guid.Parse("6BB36A77-5E53-4681-95E0-B693453F1E19"),
                ItemUnitId = Guid.Parse("1FF483AA-3F32-4BD1-A87F-66C56DC2EF5E"),
                BarcodeString = "9871780679217",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3f1bfc49-3c88-4a64-b48d-b8d13aa7c360"),
                ProductId = Guid.Parse("E49EFDEA-46E2-4E3E-9E1D-CB8F2BD81CEB"),
                ItemUnitId = Guid.Parse("BD7756C9-A5E9-424E-9ED5-CE8C61EC8504"),
                BarcodeString = "9065363940084",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3f43ea12-bfa2-4ad3-8d2e-2695e94f7347"),
                ProductId = Guid.Parse("4B679760-1072-4A69-B0CD-B7F0B54E13A0"),
                ItemUnitId = Guid.Parse("AF248035-CC6F-4874-89FB-5ECEC665B1CB"),
                BarcodeString = "7239461838932",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("3fbb125c-9670-43fa-ae80-d8df38334ed0"),
                ProductId = Guid.Parse("DA0CF148-968C-40CE-8D00-70A13D8642CC"),
                ItemUnitId = Guid.Parse("D8DECA9C-E6D5-456F-8460-D0610CA2AD57"),
                BarcodeString = "6221366922983",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("402673d7-bdca-4d14-953d-48cef713bc11"),
                ProductId = Guid.Parse("84974822-B09E-4AE5-A793-AE8D52091647"),
                ItemUnitId = Guid.Parse("44329E0A-F233-4698-831C-99C84438CEBA"),
                BarcodeString = "8543061668487",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("41bb8bc5-c9f9-4bb4-85f2-a15cebb4c84f"),
                ProductId = Guid.Parse("B6353454-059E-409D-85E4-B273F1D9A032"),
                ItemUnitId = Guid.Parse("7A81F8B7-1A42-4006-B193-E61878B07C77"),
                BarcodeString = "8785591732063",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("41fe00a9-4153-47fe-b829-96d6020e3271"),
                ProductId = Guid.Parse("D091159E-92EE-4F55-AAA0-BC489A719E22"),
                ItemUnitId = Guid.Parse("816236DD-9BC4-4C3B-8FB2-08247E598803"),
                BarcodeString = "6027516629208",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("42f6fbb5-a27d-461b-b949-9ecf90b8248a"),
                ProductId = Guid.Parse("068E8333-8AA7-4AC2-A944-FF96434F6AC2"),
                ItemUnitId = Guid.Parse("40BEBF59-6EBF-4014-B1B9-BAED653AE9AB"),
                BarcodeString = "6445972838971",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4375ae38-9d97-4c14-9a75-788f956bf9af"),
                ProductId = Guid.Parse("1681FBD9-A2C4-4EA0-B0C9-38439E239DE9"),
                ItemUnitId = Guid.Parse("C1FA3983-7828-40BB-BC99-8966654F5757"),
                BarcodeString = "6488336978537",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("457e3d01-bc9a-43ac-b9b2-8e356772a798"),
                ProductId = Guid.Parse("40667126-379B-4BFC-A9F3-88F74C17EE8A"),
                ItemUnitId = Guid.Parse("9F4A273B-9BE3-4E32-8A2F-85CC1CC25100"),
                BarcodeString = "7925349648502",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("458c901b-7780-4b36-9f77-0a42fa597130"),
                ProductId = Guid.Parse("E7CB3414-C0B4-4884-B9EA-A10E13C49337"),
                ItemUnitId = Guid.Parse("6880CFC3-EBE9-41F4-AC06-12BC0B7FCE7B"),
                BarcodeString = "6581941944216",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("45cee292-fec0-49f8-9d7e-586f25c70387"),
                ProductId = Guid.Parse("DD0805D2-84A1-4FA1-89B0-2BF012924EC8"),
                ItemUnitId = Guid.Parse("3F90EA94-6C91-4073-BF97-5D0DE5811E6D"),
                BarcodeString = "8475541967915",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("45e6e645-9d42-45d3-8c21-b57256986afa"),
                ProductId = Guid.Parse("09187E90-5E30-43AB-BD28-FA869EBBA906"),
                ItemUnitId = Guid.Parse("3300C267-DAE4-40D7-BD3C-C6D9B4F6A0AA"),
                BarcodeString = "8948230610043",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("471e0de1-7d2b-4a42-a3d0-a99cce17f3ba"),
                ProductId = Guid.Parse("0CAE18A2-B990-4DB5-9EC2-54E081D3F378"),
                ItemUnitId = Guid.Parse("CDDE7FE2-9106-4C11-94C8-B16C4D61BDB0"),
                BarcodeString = "6451636768600",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("479175c3-c1bb-437f-939e-061ac66b072d"),
                ProductId = Guid.Parse("0CAE18A2-B990-4DB5-9EC2-54E081D3F378"),
                ItemUnitId = Guid.Parse("4109AC2D-ACCE-4348-83B7-D87088CE5A03"),
                BarcodeString = "9617500647140",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("47c0982a-defd-4fc9-8ba4-943f4dfe91fe"),
                ProductId = Guid.Parse("39A9C0D5-F8B3-43AB-8A05-4F94DCE7AA10"),
                ItemUnitId = Guid.Parse("1C40B21E-8F56-497B-81F1-A6932C8D1FCD"),
                BarcodeString = "6696079701843",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4a0ca28b-ec7d-4f6a-918b-0732fb741a17"),
                ProductId = Guid.Parse("0F355ACB-83A6-459E-8E5B-8CEDF1BE204A"),
                ItemUnitId = Guid.Parse("3F93FCC4-3241-4E1D-B04A-3F6EFEC6D15E"),
                BarcodeString = "8673390906294",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4a4f4ec1-c113-46d1-8871-aca806c926ae"),
                ProductId = Guid.Parse("87538842-18E0-41E5-AD77-9E3E7F998C40"),
                ItemUnitId = Guid.Parse("7016D365-EE5D-4C28-B139-1C418CC1FA07"),
                BarcodeString = "9580016908751",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4b1758c3-43f8-4178-ae0d-123cee7e8e20"),
                ProductId = Guid.Parse("4007CA39-2AAA-45E2-BD6C-ECB16E0A69CE"),
                ItemUnitId = Guid.Parse("01A25038-AE16-4225-AD1A-A2BDB35F1055"),
                BarcodeString = "6985090669889",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4c10d391-30fd-42a6-9103-ac3037af5645"),
                ProductId = Guid.Parse("F8D487BD-A119-4E92-B443-1358B58C995F"),
                ItemUnitId = Guid.Parse("25CA555F-9369-44FA-98B2-B36961C3DE97"),
                BarcodeString = "9736003685240",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4c5b33fa-a5c4-4651-a946-79051e04db90"),
                ProductId = Guid.Parse("E5005446-B5ED-4AD0-A835-C709636B15F8"),
                ItemUnitId = Guid.Parse("233BDFDE-2403-42A2-830B-ABFCA5FCB53E"),
                BarcodeString = "9047772689611",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4c5f72ed-728a-4c03-a49e-9e51f75e6834"),
                ProductId = Guid.Parse("30943E74-2644-4848-B12A-B385EBE76F3E"),
                ItemUnitId = Guid.Parse("6B59EE3E-774A-4BF3-90B1-539E6FA0C6DE"),
                BarcodeString = "7332713839937",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4cd6e58f-6f00-474c-ba33-0f32cb693a73"),
                ProductId = Guid.Parse("F2E01CB2-9795-4C0E-9226-A3E3363BCF3F"),
                ItemUnitId = Guid.Parse("9CD12FC2-DCA8-4E42-9DFB-C7347F4AB963"),
                BarcodeString = "8460076945366",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4e27af4b-fda1-4259-adaf-14210ec778d4"),
                ProductId = Guid.Parse("55EA8E5F-76F7-4F52-BBE8-2DF4D1D522E8"),
                ItemUnitId = Guid.Parse("C925AB6D-6F03-42AB-89FB-C1E3C7CE02EB"),
                BarcodeString = "6194187906753",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4e85bf38-5f05-433b-af68-874f953f68cf"),
                ProductId = Guid.Parse("91EBEBFA-B2CB-4856-8292-5EB2333D4B82"),
                ItemUnitId = Guid.Parse("0F00739D-B298-4263-8597-2B8B9D6D5D24"),
                BarcodeString = "8466413896101",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4ee1e902-ba13-4a3c-9e1a-35563904d86d"),
                ProductId = Guid.Parse("3B66B603-5535-44E6-82C6-320E73575328"),
                ItemUnitId = Guid.Parse("CCFACEFC-73AF-46C8-BF6B-EE93A5445A67"),
                BarcodeString = "9926291918200",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4f02aab8-26a7-4869-8f23-44c7ca6ba318"),
                ProductId = Guid.Parse("08E07219-C245-436E-BD33-86B05E2C6A26"),
                ItemUnitId = Guid.Parse("23FDB184-90E6-4470-8B17-D884E95D7475"),
                BarcodeString = "6868476831014",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4f03e705-e5f1-49f8-81f2-575a984b808a"),
                ProductId = Guid.Parse("F2E01CB2-9795-4C0E-9226-A3E3363BCF3F"),
                ItemUnitId = Guid.Parse("FCFC55D9-A0BD-44C6-A5E0-D4D427F13A2E"),
                BarcodeString = "9695593897701",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("4f4bf590-9c6e-41fc-89c8-74daa32b5bb4"),
                ProductId = Guid.Parse("75EC2DA5-CFC2-4577-B640-AA37870330B4"),
                ItemUnitId = Guid.Parse("13BCDDA6-2FBA-4848-BF3C-EF01094A296E"),
                BarcodeString = "8157227883792",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5119a1ec-08b5-4c03-a6a8-d3843cfed70b"),
                ProductId = Guid.Parse("E5005446-B5ED-4AD0-A835-C709636B15F8"),
                ItemUnitId = Guid.Parse("EE39E74A-4801-431A-83C8-793C6776E999"),
                BarcodeString = "8886310767861",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("513c8abb-5b3b-41eb-8efb-46bcb66ed17c"),
                ProductId = Guid.Parse("E5005446-B5ED-4AD0-A835-C709636B15F8"),
                ItemUnitId = Guid.Parse("CE835918-80AA-4818-A79D-1A58BC084AF1"),
                BarcodeString = "8299415651518",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("51ad1a1d-3a54-4fdf-9827-8769d2f884bb"),
                ProductId = Guid.Parse("70E20C31-085B-4BA1-97C6-76951BDE1A86"),
                ItemUnitId = Guid.Parse("FC33C8C9-02DC-47C3-8E08-5EDE6BC6DD46"),
                BarcodeString = "9875805745630",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("51c8b67a-6de2-469f-ae60-b1eaa5096f4b"),
                ProductId = Guid.Parse("5868A3DF-C076-4DAE-88ED-A763A8E2C2D9"),
                ItemUnitId = Guid.Parse("4249AA34-95F5-4564-B2CB-720D56C89F0E"),
                BarcodeString = "9031628836869",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5245c7c2-5a1a-46af-8815-0e0b16016a6c"),
                ProductId = Guid.Parse("F7D4DB5B-C00F-4D8C-B9F8-AB85F5D04D0F"),
                ItemUnitId = Guid.Parse("6357B0CE-4935-4570-96F5-26E3DBCBA645"),
                BarcodeString = "7820868656499",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("52493393-8f09-492e-a808-15402e049087"),
                ProductId = Guid.Parse("774490DA-CCC9-4754-ACEA-5E6754BE7FDD"),
                ItemUnitId = Guid.Parse("091CE400-09E4-44F7-A99E-3872722EDD3E"),
                BarcodeString = "6571399757273",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("53a45944-ac28-4876-9f0e-3be72bd6fc49"),
                ProductId = Guid.Parse("514ED67A-E441-4A5C-809C-423EB99EBBCC"),
                ItemUnitId = Guid.Parse("AAFBA082-5F08-4C01-9472-92E15B338558"),
                BarcodeString = "7059807892549",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("55e16f69-c7de-4b14-82b9-4e3364ce9cb5"),
                ProductId = Guid.Parse("6041BBC6-DE60-455C-9556-CA9DBBC95740"),
                ItemUnitId = Guid.Parse("A09ABBE2-ABDE-4142-8258-A697731DAEDB"),
                BarcodeString = "7832307984838",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("572814a4-be6f-4d98-b276-c87a482ffe7a"),
                ProductId = Guid.Parse("91276161-7358-4680-8FD6-A45FA83C3413"),
                ItemUnitId = Guid.Parse("ECD9CBFD-0EF3-4588-A1C4-183F0E162BFB"),
                BarcodeString = "8767738776661",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("57d7650e-0fb8-4801-9647-a5e19c41e9a4"),
                ProductId = Guid.Parse("05F16EE5-B3E2-4EA7-B5BF-16ED86D84CCE"),
                ItemUnitId = Guid.Parse("EA168A90-F837-414A-B03E-793713AFAE9B"),
                BarcodeString = "9805514612107",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("58c79967-ce2f-45bc-87e8-ac46fc7e868f"),
                ProductId = Guid.Parse("4F64A707-DE84-471A-BC9D-D3A890C59F55"),
                ItemUnitId = Guid.Parse("A44FE6BE-06F6-43E6-811F-36A801925F6F"),
                BarcodeString = "8014670903275",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("58edfc62-58e6-4f7a-8b51-04e1becd6122"),
                ProductId = Guid.Parse("27B22F2A-5D8B-40D2-9F6E-3FEC92DE9A71"),
                ItemUnitId = Guid.Parse("DB2DE84F-51F3-4D91-A380-E22D49140092"),
                BarcodeString = "8187744621533",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5903273e-6671-40a8-9027-ffa62e52e26f"),
                ProductId = Guid.Parse("70E20C31-085B-4BA1-97C6-76951BDE1A86"),
                ItemUnitId = Guid.Parse("6653FC81-F2AF-4D12-9A81-5DA3E9C896A9"),
                BarcodeString = "7169795800434",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("59eb71af-2521-4f0b-bfb6-d8b387064506"),
                ProductId = Guid.Parse("3C75D6D9-D389-4B0E-9943-133D7C0529DC"),
                ItemUnitId = Guid.Parse("1F5F3187-BC0D-40F5-BB2C-299FDAD3D4AB"),
                BarcodeString = "9388412759292",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("59fabd82-5ea8-4e32-8bb4-9e52f7eb2339"),
                ProductId = Guid.Parse("4B679760-1072-4A69-B0CD-B7F0B54E13A0"),
                ItemUnitId = Guid.Parse("88FE955A-BD24-4B62-ADE3-BE9E7CF0E085"),
                BarcodeString = "6876074678255",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5a387101-90e1-412a-a051-9cb764a16139"),
                ProductId = Guid.Parse("96F39E35-716A-4424-B45C-E3E9F9540034"),
                ItemUnitId = Guid.Parse("5E11E7E2-03A9-429B-9583-0877C2F4C31F"),
                BarcodeString = "9025187626904",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5a545e54-1ab4-41c2-b332-dfa520275747"),
                ProductId = Guid.Parse("F1E438F5-778D-42F8-A81E-0F0B3D97EFB4"),
                ItemUnitId = Guid.Parse("57BD0E35-C672-4BBA-9F69-5EA5D8378D8D"),
                BarcodeString = "9965848973317",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5b9cf094-072a-4a2a-ade1-4d003cac34d8"),
                ProductId = Guid.Parse("ED170CD5-03F5-4872-8D09-7C562DEE0E1C"),
                ItemUnitId = Guid.Parse("00C9D6EA-C404-4EED-9B2B-EABEF1305DC1"),
                BarcodeString = "9792077653308",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5cd81a80-868b-442d-a037-cdd016e62668"),
                ProductId = Guid.Parse("6BB36A77-5E53-4681-95E0-B693453F1E19"),
                ItemUnitId = Guid.Parse("315CCD12-0DB8-4D8E-8C03-98A6547AEA70"),
                BarcodeString = "6315243849753",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5d2c6912-8884-4270-92e3-9056038c116c"),
                ProductId = Guid.Parse("09F106A7-DFFC-4868-97D4-9EE24B244B0C"),
                ItemUnitId = Guid.Parse("6D6F4058-D76F-4EFE-AC48-F70024D0692C"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5d8af4df-6507-44c8-9929-2064c9acdaa5"),
                ProductId = Guid.Parse("E5005446-B5ED-4AD0-A835-C709636B15F8"),
                ItemUnitId = Guid.Parse("9C5795CD-26B2-4856-801D-65EBDA067997"),
                BarcodeString = "8877219660764",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5f8c7381-5150-499a-bdd5-5cb37b21e2f5"),
                ProductId = Guid.Parse("1D0FBE6C-D3CC-4D0F-A20A-122A1EE25190"),
                ItemUnitId = Guid.Parse("D15267BB-D7F5-438C-B194-847032C8513B"),
                BarcodeString = "9679960957945",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("5fce033d-fac1-425e-8fdf-8cd53334236b"),
                ProductId = Guid.Parse("A33AAA45-B6D5-48B6-ACFC-37B79BA4BBC2"),
                ItemUnitId = Guid.Parse("B3A652D7-5CE5-42FD-A776-880294446DEA"),
                BarcodeString = "9608332676728",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("60070198-5359-4cfe-871e-9ca957ae0966"),
                ProductId = Guid.Parse("0C916C7A-F3E0-4E0A-B9BA-F61D2816861D"),
                ItemUnitId = Guid.Parse("FAD081FF-9C48-4162-8293-29868005CDEA"),
                BarcodeString = "9130838861475",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("600ec4ea-4a83-4997-be3c-3ddbc3e311b0"),
                ProductId = Guid.Parse("6028ABF9-2149-4CD5-9B16-CECC80146029"),
                ItemUnitId = Guid.Parse("4ABB1D3D-BFDF-4B8A-B90E-2F5BBEA1C4AD"),
                BarcodeString = "7108554752080",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("60bd7302-0d1c-48e8-88fe-d9e4ed62ba2a"),
                ProductId = Guid.Parse("0CAE18A2-B990-4DB5-9EC2-54E081D3F378"),
                ItemUnitId = Guid.Parse("3C355087-CCB3-4CA4-A097-4083C27495E8"),
                BarcodeString = "6648561602868",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("60ed3bdd-6a58-46c3-acbe-b051733d1360"),
                ProductId = Guid.Parse("CAC2533D-31B1-402D-B093-B7152F88F7CF"),
                ItemUnitId = Guid.Parse("BA33699A-CB08-462A-8068-25D6971D9855"),
                BarcodeString = "6648417755179",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("61237fcb-f6de-4b96-a672-e3fc67974f95"),
                ProductId = Guid.Parse("DA0CF148-968C-40CE-8D00-70A13D8642CC"),
                ItemUnitId = Guid.Parse("EDEAB2B4-F651-4BD3-90E3-16187D795AF9"),
                BarcodeString = "8118086863577",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("612e2425-da0f-49af-ae16-dd52d2f8ed32"),
                ProductId = Guid.Parse("774490DA-CCC9-4754-ACEA-5E6754BE7FDD"),
                ItemUnitId = Guid.Parse("29BF5E71-0E11-4D2D-8DD3-C6061BB6E02A"),
                BarcodeString = "9104145934170",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("618c7db4-51de-40be-a2b6-fe26b11b7294"),
                ProductId = Guid.Parse("E7CB3414-C0B4-4884-B9EA-A10E13C49337"),
                ItemUnitId = Guid.Parse("22B2E013-E927-4BA1-A445-B249A2339599"),
                BarcodeString = "7923208658499",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("61a79b00-df79-4722-8a37-10b084f858a8"),
                ProductId = Guid.Parse("70E20C31-085B-4BA1-97C6-76951BDE1A86"),
                ItemUnitId = Guid.Parse("C8F363CC-D1F2-45F5-8C95-C0507B45D4B9"),
                BarcodeString = "7457771674348",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("626f334f-aac6-4180-98a4-1fd4be51fa67"),
                ProductId = Guid.Parse("B40836D7-6A05-4D61-B2F2-B8344D6996F3"),
                ItemUnitId = Guid.Parse("64AD60FD-FC18-461C-9FD0-C3F882E3CA93"),
                BarcodeString = "8361823845587",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6288ebdf-b005-4b11-9fd7-d11a76ec9fd6"),
                ProductId = Guid.Parse("71DE705A-489C-480A-9A03-8E112B787307"),
                ItemUnitId = Guid.Parse("549E4987-498F-44B8-B9F3-37C702C28F99"),
                BarcodeString = "8296524766519",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6378c63f-315d-4380-a488-65b7ee0c33bf"),
                ProductId = Guid.Parse("6041BBC6-DE60-455C-9556-CA9DBBC95740"),
                ItemUnitId = Guid.Parse("24DA9AF2-CC2E-48C2-94E3-472545DA88B9"),
                BarcodeString = "7516311915219",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("64022117-07de-41a5-96fe-a9bd77cd0614"),
                ProductId = Guid.Parse("068E8333-8AA7-4AC2-A944-FF96434F6AC2"),
                ItemUnitId = Guid.Parse("F54134D0-0774-481E-BCAB-B502F57AAEE4"),
                BarcodeString = "9736299722516",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("64c096dc-6316-4b33-b592-286f98436ddf"),
                ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
                ItemUnitId = Guid.Parse("39385DC7-A950-48D8-A2F2-D13AB91AEE10"),
                BarcodeString = "8017404745906",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("67ce1f6f-69a8-40bd-918a-92a3d069788e"),
                ProductId = Guid.Parse("91EBEBFA-B2CB-4856-8292-5EB2333D4B82"),
                ItemUnitId = Guid.Parse("15B3DC37-3E41-43B5-B224-7A1EAF9EAE72"),
                BarcodeString = "7037136689952",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("682b3203-4fa6-4059-aa4c-2c75a6b965e6"),
                ProductId = Guid.Parse("C493BB30-902F-4F54-830F-A3D6B1683A2B"),
                ItemUnitId = Guid.Parse("F83248E6-DA20-4DF2-97FC-69CDA3D1DAD4"),
                BarcodeString = "9939423969271",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("687d6b67-7a7c-4f54-a79c-3bbbcf2bf90c"),
                ProductId = Guid.Parse("7B6B14E1-8014-4755-A20A-69DDAD87A1B3"),
                ItemUnitId = Guid.Parse("EC369480-42D1-4AB0-BA86-5031BD5B5805"),
                BarcodeString = "9129381791529",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("69304fdf-b392-42e4-b180-f9096e02a6a2"),
                ProductId = Guid.Parse("259EEC3C-C5CA-4715-8D64-9423EF301586"),
                ItemUnitId = Guid.Parse("A731510C-392A-4475-93E3-465F9EA1C4F1"),
                BarcodeString = "8906722742490",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6b144f55-bad9-4114-9d51-608f5ee0f967"),
                ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
                ItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
                BarcodeString = "9576400903704",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6bb3fa81-558f-4a19-af97-af2d7be32349"),
                ProductId = Guid.Parse("4B679760-1072-4A69-B0CD-B7F0B54E13A0"),
                ItemUnitId = Guid.Parse("B144E9E4-D99F-4E90-B2B6-A3E04317C8D9"),
                BarcodeString = "8238958612287",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6c9eddf6-7fe1-41d7-b5b5-c61d8a8f9e8a"),
                ProductId = Guid.Parse("6028ABF9-2149-4CD5-9B16-CECC80146029"),
                ItemUnitId = Guid.Parse("1B309B2A-0DE4-41D5-97B7-4BB88AFFB97F"),
                BarcodeString = "8992591950132",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6cd0a90e-6ecf-416d-bb39-e329628ae84c"),
                ProductId = Guid.Parse("10D533B7-CC9E-4A60-B65D-109F90D86E7D"),
                ItemUnitId = Guid.Parse("B91A27A4-CCFF-4C41-8FC9-20245974AD72"),
                BarcodeString = "9959139902884",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6cf0513a-dd78-48d5-b59d-3c6b9bb1372d"),
                ProductId = Guid.Parse("2C7AFEDF-7D80-4486-861A-9EA50DBEE9FC"),
                ItemUnitId = Guid.Parse("52E17CAA-F50B-4CC6-B889-B95E3AC39F41"),
                BarcodeString = "6212893920494",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6e4c59c1-80ab-436f-9828-23b619941559"),
                ProductId = Guid.Parse("B40836D7-6A05-4D61-B2F2-B8344D6996F3"),
                ItemUnitId = Guid.Parse("751A2F31-8CB8-4B2F-9211-83C2A33BFAB4"),
                BarcodeString = "8330350823084",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6e670202-083c-4814-bd28-d0ceefebfab3"),
                ProductId = Guid.Parse("0C20D2A3-0ECB-497C-B963-D8AA4E88B2D8"),
                ItemUnitId = Guid.Parse("DDA3D5CE-D040-4C0C-9158-647DDA5AE480"),
                BarcodeString = "8405826929783",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6e68961f-91db-4faa-b2ce-9c6aaef6f5c6"),
                ProductId = Guid.Parse("75EC2DA5-CFC2-4577-B640-AA37870330B4"),
                ItemUnitId = Guid.Parse("DE50E31B-1E36-4801-92A3-3F1CCC22B6CB"),
                BarcodeString = "8206416980749",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6ec74ccb-33a3-47de-9deb-e94e815cded5"),
                ProductId = Guid.Parse("1987A609-D7FC-4EF9-8175-04A08D371015"),
                ItemUnitId = Guid.Parse("F4AF1877-493C-4D46-A2AE-BBACE0FFE337"),
                BarcodeString = "8295717805956",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6f387159-d237-4441-99c8-056dfe5b4605"),
                ProductId = Guid.Parse("0E991364-5F84-4C85-AE72-F6E9404F1366"),
                ItemUnitId = Guid.Parse("B12EEC56-02A5-4622-A2DE-17AD7E8551B7"),
                BarcodeString = "9593080908386",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6f5ada26-b735-454f-b89d-e8453ffba171"),
                ProductId = Guid.Parse("70E20C31-085B-4BA1-97C6-76951BDE1A86"),
                ItemUnitId = Guid.Parse("D51035B6-4328-4909-8B8D-9DDB8107EB01"),
                BarcodeString = "7535403772831",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6fa85856-eae1-4ee7-8948-f0cc28385907"),
                ProductId = Guid.Parse("D07EC644-37F0-416B-9323-AA25D1A819B4"),
                ItemUnitId = Guid.Parse("A9162521-4028-4929-AD83-1C4EE4C4C481"),
                BarcodeString = "6410418962763",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6fce066f-942c-4687-b674-6e6ee3a40c6f"),
                ProductId = Guid.Parse("27B22F2A-5D8B-40D2-9F6E-3FEC92DE9A71"),
                ItemUnitId = Guid.Parse("71034C39-8D15-45B1-9D16-3AF9F2406BD8"),
                BarcodeString = "9266271643538",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("6fdc028e-9e99-4864-aac0-b76290778cee"),
                ProductId = Guid.Parse("ED170CD5-03F5-4872-8D09-7C562DEE0E1C"),
                ItemUnitId = Guid.Parse("8941560B-98ED-4291-B0F1-BF5CCBAEEEE7"),
                BarcodeString = "6426604762122",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("704b9d4e-193d-4e91-b5fe-13cce8eb18b3"),
                ProductId = Guid.Parse("96F39E35-716A-4424-B45C-E3E9F9540034"),
                ItemUnitId = Guid.Parse("15ABD40D-51FB-4F6F-B47F-50161380F45C"),
                BarcodeString = "8263788607403",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("704cb6d3-4f2a-46d0-9d70-1762ac961955"),
                ProductId = Guid.Parse("05F16EE5-B3E2-4EA7-B5BF-16ED86D84CCE"),
                ItemUnitId = Guid.Parse("5BBFD066-C55F-4C4E-AFF2-76EABA2B41B6"),
                BarcodeString = "9558738871896",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("70c6b314-8dac-4724-a836-0b99e624f6fb"),
                ProductId = Guid.Parse("A33AAA45-B6D5-48B6-ACFC-37B79BA4BBC2"),
                ItemUnitId = Guid.Parse("104CD401-3899-4EE5-AB09-9D3C7D3F37B9"),
                BarcodeString = "6921341980755",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("70cbed7e-760a-4b9d-b975-7a8c57cd75c5"),
                ProductId = Guid.Parse("04202692-9052-4977-B297-683369796EE6"),
                ItemUnitId = Guid.Parse("3F381194-3520-4EE5-8920-5747E19E2505"),
                BarcodeString = "6729228917043",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("71046188-fa60-4b95-8115-d17392420afb"),
                ProductId = Guid.Parse("6BB36A77-5E53-4681-95E0-B693453F1E19"),
                ItemUnitId = Guid.Parse("2879C596-0102-42A2-A7F5-E9AE3FA82700"),
                BarcodeString = "8612898701651",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("7166bb3f-8980-4f07-b0e2-4854c0d38a89"),
                ProductId = Guid.Parse("B1E0AE2B-B271-4613-89D8-8575564A6944"),
                ItemUnitId = Guid.Parse("F100828F-56E8-44CA-9F62-72716C2048F6"),
                BarcodeString = "8528516835570",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("718d3238-614e-462a-8963-ff7a687cde33"),
                ProductId = Guid.Parse("B1E0AE2B-B271-4613-89D8-8575564A6944"),
                ItemUnitId = Guid.Parse("532CBEF2-A0B1-41A7-95A8-A5F46197C793"),
                BarcodeString = "9771334829397",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("71e2f722-4a80-4621-8b28-3153d8c9539d"),
                ProductId = Guid.Parse("D46E2E23-5391-403D-9602-8CAA1E769131"),
                ItemUnitId = Guid.Parse("AFF23A32-2FED-4F83-9EE4-2FBE167C5D82"),
                BarcodeString = "6545925741579",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("737ecf5b-7f28-4536-8bd1-931e9d5ba8d4"),
                ProductId = Guid.Parse("F253EF01-2818-42E7-AE46-66ABC537E5C0"),
                ItemUnitId = Guid.Parse("850B5E1B-17F3-4675-9983-E2BA146898F9"),
                BarcodeString = "6504102620084",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("740bb74d-a377-4ad7-80ea-030ebb45c55a"),
                ProductId = Guid.Parse("9959BACC-1C42-4791-8854-2285E471D4B3"),
                ItemUnitId = Guid.Parse("539C9A7A-D5AC-490A-898A-C1741DAEAA3F"),
                BarcodeString = "9982634922302",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("74b5dce4-0b21-4db4-96af-e0b67d593d0d"),
                ProductId = Guid.Parse("D11CD853-1D91-46AE-95B4-B6F9F183E5CB"),
                ItemUnitId = Guid.Parse("B6936861-6A3C-435A-9412-648E8D338C00"),
                BarcodeString = "9298874697761",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("74b86e93-1b5b-41bb-b620-410ea997479a"),
                ProductId = Guid.Parse("F7439C76-4855-465F-832F-D2B3A845A25D"),
                ItemUnitId = Guid.Parse("A78B4FEF-B67E-44AE-837A-DEFC6248136B"),
                BarcodeString = "8995351720036",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("74cb5776-8ddc-42a4-b69f-86d984e857ce"),
                ProductId = Guid.Parse("D9A78239-FFF7-48C1-8538-C762C6E5C53E"),
                ItemUnitId = Guid.Parse("A40F6B6E-164C-46FE-9DB9-E53F55EBAE37"),
                BarcodeString = "8433105782858",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("762f6187-70ff-4641-b05e-18e1b695accd"),
                ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
                ItemUnitId = Guid.Parse("1CB2E917-4A39-48A5-AD33-D6BA092E4F55"),
                BarcodeString = "9720269719098",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("76c946cc-dd34-47d5-b79b-ff8480781388"),
                ProductId = Guid.Parse("65E8B711-3862-4588-8317-1E182BEB9655"),
                ItemUnitId = Guid.Parse("D5DACF21-9245-41BC-8220-22E8A0F33650"),
                BarcodeString = "9487433650501",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("77074c5c-b2cd-4ca2-b4ef-9f8486bb6e66"),
                ProductId = Guid.Parse("F8D487BD-A119-4E92-B443-1358B58C995F"),
                ItemUnitId = Guid.Parse("84A25647-6938-49F8-BF14-6311F925A965"),
                BarcodeString = "9221853727836",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("77bd8a0f-b867-46e2-9f07-aa8e8b16e594"),
                ProductId = Guid.Parse("836FA41A-AEB7-4C7C-9CE3-5BD1A99A1B46"),
                ItemUnitId = Guid.Parse("701D0B0C-7E41-4EFD-A64F-B2A79A6860BC"),
                BarcodeString = "6100163747098",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("78771052-e0e5-46b1-a213-34fe0d8a25d7"),
                ProductId = Guid.Parse("E49EFDEA-46E2-4E3E-9E1D-CB8F2BD81CEB"),
                ItemUnitId = Guid.Parse("75EAB908-2FFC-4806-8B63-E64503190DBB"),
                BarcodeString = "8720884900445",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("78888feb-2cb6-4ef2-b228-7c9e1e0e17e2"),
                ProductId = Guid.Parse("0C20D2A3-0ECB-497C-B963-D8AA4E88B2D8"),
                ItemUnitId = Guid.Parse("C2BFCD25-5116-4E4B-A182-9917CB13559F"),
                BarcodeString = "9596674670146",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("7a8c19f2-857b-4db7-a355-e56c24eea568"),
                ProductId = Guid.Parse("D46E2E23-5391-403D-9602-8CAA1E769131"),
                ItemUnitId = Guid.Parse("25FAACBB-B5BA-41AB-AF2C-0B31AB76AC92"),
                BarcodeString = "6267950967968",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("7ad44d5b-575a-48a1-9554-300f7df09902"),
                ProductId = Guid.Parse("F8D487BD-A119-4E92-B443-1358B58C995F"),
                ItemUnitId = Guid.Parse("BF935C1A-370A-4535-918A-5B1958392AC7"),
                BarcodeString = "9486129750920",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("7d20df82-fff4-4deb-8c1a-e3bfaf23f11a"),
                ProductId = Guid.Parse("0E991364-5F84-4C85-AE72-F6E9404F1366"),
                ItemUnitId = Guid.Parse("5BD53CFD-F2EF-42FD-AE8C-70C6B0E69B36"),
                BarcodeString = "8651990816950",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("7d9bb860-3056-40c2-b713-77e2f043e69f"),
                ProductId = Guid.Parse("17497A0A-8F97-42E5-909C-AA52D0853A51"),
                ItemUnitId = Guid.Parse("8E6965D3-FBCE-422F-A478-B61D691BDF74"),
                BarcodeString = "9247058626283",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("7e7dea7b-9785-4e67-8ae6-4c1ca53759cf"),
                ProductId = Guid.Parse("E19B56EF-BC63-4376-A258-247B51C2AC3A"),
                ItemUnitId = Guid.Parse("745FEF1B-7686-4B6B-9842-23F4EBFDD4BF"),
                BarcodeString = "9552527754642",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("7ecd9bdb-4647-442b-b830-c4d9ab4ca523"),
                ProductId = Guid.Parse("BA3F09BD-A0E1-4026-9F8E-48FA01B1E97E"),
                ItemUnitId = Guid.Parse("1AFBE70C-9EF6-4FCC-BBFD-9B2F49BA9365"),
                BarcodeString = "8595485832252",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("7ee02f18-483f-430c-8830-8847c3c8dae0"),
                ProductId = Guid.Parse("91EBEBFA-B2CB-4856-8292-5EB2333D4B82"),
                ItemUnitId = Guid.Parse("E61D6DC4-7A4B-45DA-8015-2FBA4A03C8C2"),
                BarcodeString = "7911718790678",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8013ae90-8a45-4650-9e8f-d99db0bff013"),
                ProductId = Guid.Parse("836FA41A-AEB7-4C7C-9CE3-5BD1A99A1B46"),
                ItemUnitId = Guid.Parse("28B400B1-B09E-4A12-9CF7-41A75DCCF413"),
                BarcodeString = "7501580858696",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8017d777-f482-492e-88a7-dfc74c8fd78f"),
                ProductId = Guid.Parse("55EA8E5F-76F7-4F52-BBE8-2DF4D1D522E8"),
                ItemUnitId = Guid.Parse("43D556A6-5B4B-4179-93D5-278A45F2C38A"),
                BarcodeString = "6227057949141",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("80dcc968-2709-4558-96bc-309dd886c807"),
                ProductId = Guid.Parse("96F39E35-716A-4424-B45C-E3E9F9540034"),
                ItemUnitId = Guid.Parse("9178B870-CB05-40F5-A31A-D44493322B87"),
                BarcodeString = "7974264840561",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("814ce3d9-6643-470c-a021-23405995cdb6"),
                ProductId = Guid.Parse("AB8B3752-727D-4FCE-A139-D3E7F1E9664A"),
                ItemUnitId = Guid.Parse("91DE61F9-069B-442A-8AC6-48A111741589"),
                BarcodeString = "7142133601715",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("820adbe9-d6dd-4916-a4c5-2e661ea65d77"),
                ProductId = Guid.Parse("6028ABF9-2149-4CD5-9B16-CECC80146029"),
                ItemUnitId = Guid.Parse("953E01FC-9A34-4B26-B93D-094D4A918549"),
                BarcodeString = "6094729839855",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("82ea3be4-c408-4c6d-bc2a-09383c8366c8"),
                ProductId = Guid.Parse("1564475B-EBCA-4BB3-8DE1-328AF49C0E1F"),
                ItemUnitId = Guid.Parse("A5E5B942-A590-4D31-B218-4AF6940013EA"),
                BarcodeString = "8928759669107",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("83c7b896-37e5-4428-a16a-fb76dc89fa00"),
                ProductId = Guid.Parse("28622BA9-527F-43A3-BC64-241A40E319C0"),
                ItemUnitId = Guid.Parse("DCD0617C-F8DE-49BC-9022-6DBCCFFE86A5"),
                BarcodeString = "7987184939581",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8491f248-d41a-4ad5-b282-89b1b1a7b472"),
                ProductId = Guid.Parse("D091159E-92EE-4F55-AAA0-BC489A719E22"),
                ItemUnitId = Guid.Parse("9616D06C-67C7-4E8E-92E7-163E5F31D5BF"),
                BarcodeString = "8465536763717",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("84c92a6d-2f49-41a9-86ff-c97017aab29b"),
                ProductId = Guid.Parse("D091159E-92EE-4F55-AAA0-BC489A719E22"),
                ItemUnitId = Guid.Parse("AAD4E1F2-2A51-43F3-BD92-F6EB5989F8E0"),
                BarcodeString = "8493150977591",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("84e76cd9-b6d2-472c-a748-6aac54f8bcf2"),
                ProductId = Guid.Parse("09B413E9-02B8-4FE7-9646-75B7ACDF1FEF"),
                ItemUnitId = Guid.Parse("D22ACA86-16B4-4FD9-B728-6633293344D2"),
                BarcodeString = "8230213813237",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8571c68a-ecc3-4d2f-972b-4e8e6ae6fa8b"),
                ProductId = Guid.Parse("F20C1167-4751-46F0-9A33-AC3D8D00A991"),
                ItemUnitId = Guid.Parse("B209E432-760B-4E30-A74E-F9398FE7DD4A"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("86355d3b-29da-4053-a980-39efbbfadfd3"),
                ProductId = Guid.Parse("E0268B02-2174-40CB-8630-4911D407C52A"),
                ItemUnitId = Guid.Parse("2D62F3EA-7666-4446-9025-327725DEFE8D"),
                BarcodeString = "6535062978610",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("86829139-1b46-4b13-a9b7-1bd8a5169e64"),
                ProductId = Guid.Parse("BA6FEE82-E105-4A56-9365-A497C570A174"),
                ItemUnitId = Guid.Parse("41AA2304-20B7-4EC8-A45A-2D215BE887FC"),
                BarcodeString = "6580977607131",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("86907ac9-1b91-4b84-bcb9-7e948bbeeafb"),
                ProductId = Guid.Parse("AAFDBACD-4121-476B-AEF6-84DB6462BE82"),
                ItemUnitId = Guid.Parse("C50970C8-6B18-4DDF-985B-0C5C2BA7034A"),
                BarcodeString = "7035216921198",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("86a219c1-fe29-40c9-8dbd-0b80401e1f4e"),
                ProductId = Guid.Parse("87538842-18E0-41E5-AD77-9E3E7F998C40"),
                ItemUnitId = Guid.Parse("5EE8D5DB-CAAF-4FC7-8469-4B2213255BCA"),
                BarcodeString = "9416822646002",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("86cb8a4f-c835-4a12-b1c6-2cf7077c19b1"),
                ProductId = Guid.Parse("B6353454-059E-409D-85E4-B273F1D9A032"),
                ItemUnitId = Guid.Parse("9E13C0E0-7B1F-463C-AC3F-750B3F8E389F"),
                BarcodeString = "6588695900846",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("876d9e0a-457f-4206-94ad-faea5b9f945e"),
                ProductId = Guid.Parse("F20C1167-4751-46F0-9A33-AC3D8D00A991"),
                ItemUnitId = Guid.Parse("70915CD3-8277-432F-9568-BE72C8EA8D0D"),
                BarcodeString = "6618619743117",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8798583e-f1bb-49cf-8044-eac0bb2be9dc"),
                ProductId = Guid.Parse("1CD42C42-00E0-4C41-A7D4-61BC7F52644D"),
                ItemUnitId = Guid.Parse("5F7F3874-F751-49EF-9A38-9EAFBF8FA241"),
                BarcodeString = "9633916711108",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("880b8d6c-0fbb-425c-beb0-51ef2ffdb70f"),
                ProductId = Guid.Parse("CAC2533D-31B1-402D-B093-B7152F88F7CF"),
                ItemUnitId = Guid.Parse("FD53AD02-DB0D-4F82-B541-A1BF4E16B870"),
                BarcodeString = "6209521722805",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8905404b-68b7-4350-8671-282dfc255359"),
                ProductId = Guid.Parse("09F106A7-DFFC-4868-97D4-9EE24B244B0C"),
                ItemUnitId = Guid.Parse("97DB5A39-C55E-4F3C-8694-D97421AB1EB9"),
                BarcodeString = "9442170921030",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8a053d90-1958-4565-8c45-72236b954997"),
                ProductId = Guid.Parse("B910CBE5-F014-4E8D-92A0-9199C2206D7A"),
                ItemUnitId = Guid.Parse("F86F5B6E-D11E-41DA-A6DF-621569B49FA8"),
                BarcodeString = "8169492795267",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8d6956e3-ce06-4977-ab24-258bbdf32f79"),
                ProductId = Guid.Parse("27B22F2A-5D8B-40D2-9F6E-3FEC92DE9A71"),
                ItemUnitId = Guid.Parse("84706888-935D-45F8-BDA5-41E669068887"),
                BarcodeString = "8783867950361",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8df2c729-82aa-433e-8b78-33362594df7a"),
                ProductId = Guid.Parse("B6353454-059E-409D-85E4-B273F1D9A032"),
                ItemUnitId = Guid.Parse("5533182D-8197-40E7-8036-F3D891D36FA1"),
                BarcodeString = "8753958632450",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8e49e1ec-41f2-43d4-a447-aad32c0bb8f4"),
                ProductId = Guid.Parse("1D0FBE6C-D3CC-4D0F-A20A-122A1EE25190"),
                ItemUnitId = Guid.Parse("3A741DA9-0B50-4946-8032-5CACC8A568DB"),
                BarcodeString = "6985198728338",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8ee93834-dab1-4a04-adc7-fc340064ba78"),
                ProductId = Guid.Parse("DD0805D2-84A1-4FA1-89B0-2BF012924EC8"),
                ItemUnitId = Guid.Parse("ED97D761-BDF6-42D3-BF5E-1E9B5994E95B"),
                BarcodeString = "6604825891180",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8f386fa9-5591-43dd-bd7e-d4b4f6bc9dd6"),
                ProductId = Guid.Parse("3C75D6D9-D389-4B0E-9943-133D7C0529DC"),
                ItemUnitId = Guid.Parse("8DB6CD59-4BA4-49E2-9992-B025A7895DA4"),
                BarcodeString = "7889067663935",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("8f83deb6-7e49-4b58-94fa-eb5aec648b6f"),
                ProductId = Guid.Parse("C567F6F5-0D4A-4B9F-A537-9EF9BF4FB92D"),
                ItemUnitId = Guid.Parse("6D80F23D-43AD-4764-BCD1-B107B2DA659F"),
                BarcodeString = "8495440918533",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("90b1d334-fd9d-4eda-a269-2b276dbbc75f"),
                ProductId = Guid.Parse("A33AAA45-B6D5-48B6-ACFC-37B79BA4BBC2"),
                ItemUnitId = Guid.Parse("FA3A5C5E-1905-4A69-9963-2B4E7FEA790D"),
                BarcodeString = "9170930656330",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("91bae0f0-63bd-4e0a-b723-2e2de7d31564"),
                ProductId = Guid.Parse("08E07219-C245-436E-BD33-86B05E2C6A26"),
                ItemUnitId = Guid.Parse("B276767C-7C6E-49CA-8C54-9A19EE4F6A8E"),
                BarcodeString = "6405790835338",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("923d863b-045f-4102-8d72-50462af9d227"),
                ProductId = Guid.Parse("A276616B-F023-4D6F-87EA-DF5574BD4F9C"),
                ItemUnitId = Guid.Parse("EDDE5B4E-F2AF-4888-A50C-E2096FD84E3B"),
                BarcodeString = "7546751743296",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("92e243c9-aceb-4b8c-9d5f-393df329452f"),
                ProductId = Guid.Parse("47278DB5-239B-43BE-81AE-89AF3AAF0443"),
                ItemUnitId = Guid.Parse("2EFBBF5C-C20B-4D0C-A09D-7B64FF9AED59"),
                BarcodeString = "7726059803640",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("92ef35a0-7266-4d95-af83-d32927914601"),
                ProductId = Guid.Parse("30943E74-2644-4848-B12A-B385EBE76F3E"),
                ItemUnitId = Guid.Parse("D96E008A-1476-43BF-B74B-C6CA9E90B64E"),
                BarcodeString = "6413876985789",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("92f8b349-28ef-4752-9931-0b745c6c0661"),
                ProductId = Guid.Parse("C493BB30-902F-4F54-830F-A3D6B1683A2B"),
                ItemUnitId = Guid.Parse("D527D700-3A9A-4F63-9AA0-3ABEC4A62A43"),
                BarcodeString = "7735485937072",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("951482a8-3c09-4b67-9526-eac7506fd9b3"),
                ProductId = Guid.Parse("C1E9C300-DFB2-4D59-B24B-D325E73EED61"),
                ItemUnitId = Guid.Parse("1946BE1B-160C-4313-8660-B081A6E4264D"),
                BarcodeString = "8483048942535",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("9684e297-d75c-4222-abb0-22cb1013c3d1"),
                ProductId = Guid.Parse("47278DB5-239B-43BE-81AE-89AF3AAF0443"),
                ItemUnitId = Guid.Parse("2FCE987B-CF13-4F53-B46B-C0F7916E0AF4"),
                BarcodeString = "8393199601596",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("98299060-77f3-4ab3-a8dc-65857f047e0c"),
                ProductId = Guid.Parse("00D22996-340A-46CC-8D64-2C103CB59ACF"),
                ItemUnitId = Guid.Parse("4913E935-6ABC-48B6-AA09-C52919875B0C"),
                BarcodeString = "6471677814606",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("990641bf-5652-48cf-a714-83a542d040a9"),
                ProductId = Guid.Parse("4F64A707-DE84-471A-BC9D-D3A890C59F55"),
                ItemUnitId = Guid.Parse("B63935F6-79F4-4020-8A92-8784AFC2A427"),
                BarcodeString = "6877771884956",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("99faa8db-869f-4779-9628-c7e77812bd21"),
                ProductId = Guid.Parse("BA3F09BD-A0E1-4026-9F8E-48FA01B1E97E"),
                ItemUnitId = Guid.Parse("437CE102-DACB-4310-BCDC-BA8F0057799C"),
                BarcodeString = "7721666676036",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("9a626efb-9870-4f98-b3b6-3391dfd0f08b"),
                ProductId = Guid.Parse("B910CBE5-F014-4E8D-92A0-9199C2206D7A"),
                ItemUnitId = Guid.Parse("08E1CE19-21B3-4743-98F6-068B73C15FD4"),
                BarcodeString = "9984808836708",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("9ad87a18-3cf8-45c0-bbf7-da22bacdb9e9"),
                ProductId = Guid.Parse("4787896C-3176-4AA1-B59F-DC435BDA8EAD"),
                ItemUnitId = Guid.Parse("271A11C0-82B3-4D01-82C3-067A48646031"),
                BarcodeString = "6982523773149",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a0159f4c-3ded-4663-bdeb-c453d0d737c0"),
                ProductId = Guid.Parse("4007CA39-2AAA-45E2-BD6C-ECB16E0A69CE"),
                ItemUnitId = Guid.Parse("347A4A6F-DE76-4FBE-BAA1-8A9BD2EB69A1"),
                BarcodeString = "9181156803020",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a077e433-706a-4d8b-9506-50f31b7557b2"),
                ProductId = Guid.Parse("17497A0A-8F97-42E5-909C-AA52D0853A51"),
                ItemUnitId = Guid.Parse("C70F2FE6-40E6-42E5-A92F-5B3FAB5E62D7"),
                BarcodeString = "8288040776250",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a1599815-5181-4d49-862b-6b84ec35d681"),
                ProductId = Guid.Parse("3C75D6D9-D389-4B0E-9943-133D7C0529DC"),
                ItemUnitId = Guid.Parse("EDFF47B4-E29B-453C-A05C-F9A67BAE939E"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a1c075bb-dc17-4cae-a9b3-47713e9d26d6"),
                ProductId = Guid.Parse("4B679760-1072-4A69-B0CD-B7F0B54E13A0"),
                ItemUnitId = Guid.Parse("B9718DFC-E464-4471-BA96-B8241D58F34C"),
                BarcodeString = "9530578864633",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a2a3718f-84d5-4b75-943f-9bd315d83ea8"),
                ProductId = Guid.Parse("6041BBC6-DE60-455C-9556-CA9DBBC95740"),
                ItemUnitId = Guid.Parse("6A1EEC39-1EC4-4554-BC31-5082CFC7AE8F"),
                BarcodeString = "9661007690200",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a41d155c-9e7f-4a6c-98c4-254ef5cfe6bc"),
                ProductId = Guid.Parse("71DE705A-489C-480A-9A03-8E112B787307"),
                ItemUnitId = Guid.Parse("794042C0-5BFA-4A9F-B39F-0F7B78F1C813"),
                BarcodeString = "6389524774205",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a4607888-331a-49c5-ab19-45cc6e44d2f3"),
                ProductId = Guid.Parse("E49EFDEA-46E2-4E3E-9E1D-CB8F2BD81CEB"),
                ItemUnitId = Guid.Parse("4F0BD153-B4F7-4606-A8F3-882845317A71"),
                BarcodeString = "6060382848340",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a49552f2-5bab-45f8-ba48-e1a1a87224a7"),
                ProductId = Guid.Parse("00D22996-340A-46CC-8D64-2C103CB59ACF"),
                ItemUnitId = Guid.Parse("41DE7A60-8689-4F76-80DF-FFB67E6B8D45"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a5366c21-6cc9-479d-adbf-b513eb5b52a4"),
                ProductId = Guid.Parse("3D50A706-EAA4-46CA-93F4-B0F204022A9D"),
                ItemUnitId = Guid.Parse("89CD1ACD-4DF4-4E40-9DBC-C7151CF83209"),
                BarcodeString = "8538841801853",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a674b2c9-6bfd-437d-805e-c2780e9c3497"),
                ProductId = Guid.Parse("E0268B02-2174-40CB-8630-4911D407C52A"),
                ItemUnitId = Guid.Parse("BA49DF58-42EA-45B4-A108-C8DC454B77E5"),
                BarcodeString = "7864731940662",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a6810c60-ecf1-410d-9def-5e699b54964e"),
                ProductId = Guid.Parse("BA6FEE82-E105-4A56-9365-A497C570A174"),
                ItemUnitId = Guid.Parse("DE03EBE6-B011-404B-8838-660DED9394B2"),
                BarcodeString = "7560483907423",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a84ba4b4-65da-4418-99b9-b3715483a0af"),
                ProductId = Guid.Parse("FBF09C48-C1D5-4A16-BDAF-3E5535D983AF"),
                ItemUnitId = Guid.Parse("A6CE04C3-871C-4C69-9BE6-10544155248E"),
                BarcodeString = "7823819887312",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a88e9546-3c0a-4fd4-92fd-b2e55f9a3428"),
                ProductId = Guid.Parse("02369CE6-745F-471D-9862-976C6344927B"),
                ItemUnitId = Guid.Parse("BAAD74F2-AF6C-47B3-B9B5-C057BF315E40"),
                BarcodeString = "7280669882248",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("a9e36d09-0a36-4d33-864b-516a359cf5b2"),
                ProductId = Guid.Parse("3B66B603-5535-44E6-82C6-320E73575328"),
                ItemUnitId = Guid.Parse("66CD2C6A-77C4-4203-A671-E6BECCD5A6BA"),
                BarcodeString = "6433625786046",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("aa0df8be-9b8b-4ab8-92a8-42fb376a25cc"),
                ProductId = Guid.Parse("1535C81D-E2E1-43F4-B7DA-5F102896277D"),
                ItemUnitId = Guid.Parse("18986D68-D567-4913-AC20-81AD61722368"),
                BarcodeString = "6948043614130",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("aa50a9b2-9243-452e-bbe6-2ba09e9d8607"),
                ProductId = Guid.Parse("AE325DB7-B0EA-4C72-9FCA-59B680C4209A"),
                ItemUnitId = Guid.Parse("99ADDB6A-FBB1-409A-9353-B35E4D712B63"),
                BarcodeString = "6969838858388",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("aa52a62f-d47b-4034-8dba-62f247c57e0a"),
                ProductId = Guid.Parse("0CAE18A2-B990-4DB5-9EC2-54E081D3F378"),
                ItemUnitId = Guid.Parse("4FCA6E54-1479-4B32-91E2-3CA485B920EB"),
                BarcodeString = "8281252762207",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("ab8830e3-884f-4fb3-9218-3973ce33dc86"),
                ProductId = Guid.Parse("F2E01CB2-9795-4C0E-9226-A3E3363BCF3F"),
                ItemUnitId = Guid.Parse("D3EA4F84-0FB7-4135-ABE9-4E06B5CD8DB1"),
                BarcodeString = "6023892777798",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("ab98aeb4-3f42-4d0b-b921-392e4a1acc72"),
                ProductId = Guid.Parse("04202692-9052-4977-B297-683369796EE6"),
                ItemUnitId = Guid.Parse("E31BE447-1E2D-4F55-B8AD-03CB7371914B"),
                BarcodeString = "6669469830669",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("ab9fa9ef-9e7d-48e4-9784-f666de51d0c6"),
                ProductId = Guid.Parse("774490DA-CCC9-4754-ACEA-5E6754BE7FDD"),
                ItemUnitId = Guid.Parse("3E453FC6-D8F0-4B28-82EA-6AC95FA6E1B5"),
                BarcodeString = "6641953691993",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("abbb69dc-8f1c-431c-b532-dcdac6584040"),
                ProductId = Guid.Parse("04610291-8C35-4655-BA9B-48198D0D6457"),
                ItemUnitId = Guid.Parse("FA36D4F9-7F0C-43B3-BBF2-0E44B0F124A5"),
                BarcodeString = "7563779756170",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("acc79da4-6b12-446b-bc31-4b33f90082e7"),
                ProductId = Guid.Parse("E19B56EF-BC63-4376-A258-247B51C2AC3A"),
                ItemUnitId = Guid.Parse("3B7A2E3C-653D-4ABF-B137-A953C66A03CB"),
                BarcodeString = "9292849814494",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("acd839e1-ffbe-4780-8630-457dde8c1eba"),
                ProductId = Guid.Parse("3D50A706-EAA4-46CA-93F4-B0F204022A9D"),
                ItemUnitId = Guid.Parse("77F13E21-DDE4-4C37-8179-F3EE440947FA"),
                BarcodeString = "8357547985135",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("af4e682a-64aa-495f-a2a3-ba30d16ccff4"),
                ProductId = Guid.Parse("9959BACC-1C42-4791-8854-2285E471D4B3"),
                ItemUnitId = Guid.Parse("77E57E27-2959-4833-8D36-B4369158B207"),
                BarcodeString = "8036463884042",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("afa00a1c-e3cf-44ea-89cd-d21c8012069f"),
                ProductId = Guid.Parse("E89EFE13-8CE5-45B1-BD6F-747695519A84"),
                ItemUnitId = Guid.Parse("9949262B-93B5-4597-B878-A11FB00BA7C4"),
                BarcodeString = "8768889745471",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b002349a-a480-4379-8bde-4baab70d208d"),
                ProductId = Guid.Parse("514ED67A-E441-4A5C-809C-423EB99EBBCC"),
                ItemUnitId = Guid.Parse("64D6F7A6-4F18-4D57-967E-A63FE656D903"),
                BarcodeString = "7568238720472",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b067c78c-cdc1-4a72-82b4-c945f01db449"),
                ProductId = Guid.Parse("259EEC3C-C5CA-4715-8D64-9423EF301586"),
                ItemUnitId = Guid.Parse("FE7E6D03-80C2-4704-9BDF-C389B73F6AB9"),
                BarcodeString = "9105174626612",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b0a26cf4-a33e-4755-b984-685717010030"),
                ProductId = Guid.Parse("3B66B603-5535-44E6-82C6-320E73575328"),
                ItemUnitId = Guid.Parse("BA5BD9BA-0C24-4085-AB2C-B88B1BECEE74"),
                BarcodeString = "8342471803758",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b0a45d45-a43b-4e8e-8993-e67b9b9767fd"),
                ProductId = Guid.Parse("DA0CF148-968C-40CE-8D00-70A13D8642CC"),
                ItemUnitId = Guid.Parse("F22C4828-D705-4FA8-93DC-E309BB229C7F"),
                BarcodeString = "9709830711123",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b0ddfce8-315a-4e8e-8bf0-16f2dccdf073"),
                ProductId = Guid.Parse("65E8B711-3862-4588-8317-1E182BEB9655"),
                ItemUnitId = Guid.Parse("AD3F08F6-9D46-44DD-9356-684BA8345428"),
                BarcodeString = "9003058766879",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b0e1615b-eb32-46ae-97e4-8671501d729a"),
                ProductId = Guid.Parse("CC92C663-85C3-4BCA-8333-66B04380979B"),
                ItemUnitId = Guid.Parse("5AF133E0-178E-4C74-A9BA-6B2303E34B54"),
                BarcodeString = "6686274826489",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b1736c59-fe74-4e5f-a4c3-c3d3d9119446"),
                ProductId = Guid.Parse("368D3792-52AE-4CBF-A3E1-FFB70A867E0B"),
                ItemUnitId = Guid.Parse("00DCC232-DD8B-4744-851B-7254D0126787"),
                BarcodeString = "6696205957137",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b1e15f59-d089-44c9-b326-e701645eeaa7"),
                ProductId = Guid.Parse("E89EFE13-8CE5-45B1-BD6F-747695519A84"),
                ItemUnitId = Guid.Parse("51D5DD5C-C9F5-4730-9435-3D182C4C5D99"),
                BarcodeString = "7352202897907",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b30c22e1-2e49-472b-9e08-e883845f6c4e"),
                ProductId = Guid.Parse("F2E01CB2-9795-4C0E-9226-A3E3363BCF3F"),
                ItemUnitId = Guid.Parse("9E915514-2ECB-48F9-B893-131869E73C0D"),
                BarcodeString = "9662144862302",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b325577b-84e9-4b7f-b446-147e4388d227"),
                ProductId = Guid.Parse("F253EF01-2818-42E7-AE46-66ABC537E5C0"),
                ItemUnitId = Guid.Parse("1288C5D8-7798-4A0E-8BD8-6B36736DDA82"),
                BarcodeString = "9701157852894",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b3ee4dbf-3d9c-41b4-b56b-86fc084a2a81"),
                ProductId = Guid.Parse("3C75D6D9-D389-4B0E-9943-133D7C0529DC"),
                ItemUnitId = Guid.Parse("4AF4EA54-F270-4D88-9548-66611A805381"),
                BarcodeString = "8889714968656",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b4377f2b-e14a-4f2b-92ab-fe28844f2cce"),
                ProductId = Guid.Parse("04610291-8C35-4655-BA9B-48198D0D6457"),
                ItemUnitId = Guid.Parse("DBA2FA1D-9E09-4647-AC2B-91D01F761394"),
                BarcodeString = "6168563657458",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b629a6d0-12c8-4bcd-850c-2f90bdd848ff"),
                ProductId = Guid.Parse("00D22996-340A-46CC-8D64-2C103CB59ACF"),
                ItemUnitId = Guid.Parse("97413815-E200-4DBD-B68F-ADE348CCEC4F"),
                BarcodeString = "7993873726492",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b650a529-b27c-4954-a005-8436b4310367"),
                ProductId = Guid.Parse("C1E9C300-DFB2-4D59-B24B-D325E73EED61"),
                ItemUnitId = Guid.Parse("43D4F2DC-DB42-4040-8EF2-EDC0C2759C8B"),
                BarcodeString = "8935019954621",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b79f5f8c-3390-4a11-89a7-11033879d3e8"),
                ProductId = Guid.Parse("1681FBD9-A2C4-4EA0-B0C9-38439E239DE9"),
                ItemUnitId = Guid.Parse("A81B257E-ECF2-4C1C-9467-D20F881DD310"),
                BarcodeString = "8565481850332",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("b8224a4d-4d14-4cba-87d4-ff9a61e4ec54"),
                ProductId = Guid.Parse("5868A3DF-C076-4DAE-88ED-A763A8E2C2D9"),
                ItemUnitId = Guid.Parse("3A44E9C6-ED85-45BC-AB43-25B00F12360B"),
                BarcodeString = "6949648600892",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("bada8158-4d3e-4439-b447-45c87e527042"),
                ProductId = Guid.Parse("28622BA9-527F-43A3-BC64-241A40E319C0"),
                ItemUnitId = Guid.Parse("8416E77A-759A-4E64-90EF-EDA8361E8D54"),
                BarcodeString = "9869892873938",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("bb385b89-0ba7-4fcf-8635-cdf8d1aec1f6"),
                ProductId = Guid.Parse("F253EF01-2818-42E7-AE46-66ABC537E5C0"),
                ItemUnitId = Guid.Parse("56EC3E91-B530-43BB-A6F2-DD5CD2DFFA98"),
                BarcodeString = "8873573883643",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("bb932f0c-bc5c-4fe0-a271-1b019eca1c57"),
                ProductId = Guid.Parse("1D0FBE6C-D3CC-4D0F-A20A-122A1EE25190"),
                ItemUnitId = Guid.Parse("52884777-2380-4C27-B2A3-59FF9DFB6B7D"),
                BarcodeString = "9917916924193",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("bbbdcd7e-cbe1-42ed-88a7-8c1ec0e21176"),
                ProductId = Guid.Parse("0F355ACB-83A6-459E-8E5B-8CEDF1BE204A"),
                ItemUnitId = Guid.Parse("AA7C8C4E-11D0-42DA-988D-FD9741E10BE5"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("bc3df7d5-0dee-48cc-bca1-0199a33c0521"),
                ProductId = Guid.Parse("1169946B-7C0C-48E4-88A7-A47F7BD5FFA8"),
                ItemUnitId = Guid.Parse("33E21FB8-7645-4314-8B08-4599C7E3E25A"),
                BarcodeString = "9606799963510",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("bc4cda22-56bc-4f36-bbde-9fa29027b503"),
                ProductId = Guid.Parse("4787896C-3176-4AA1-B59F-DC435BDA8EAD"),
                ItemUnitId = Guid.Parse("057D7A7F-F8DF-47C6-8994-1FEAA76D5528"),
                BarcodeString = "7278048833330",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("bf296006-1a9f-4413-8a1a-a5137bd813e2"),
                ProductId = Guid.Parse("0E991364-5F84-4C85-AE72-F6E9404F1366"),
                ItemUnitId = Guid.Parse("70DF4295-57EA-4BEB-A9FC-5FD2E39440DC"),
                BarcodeString = "8978881816449",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c0979659-c7f5-44b1-8451-db7cdbc3e449"),
                ProductId = Guid.Parse("AB8B3752-727D-4FCE-A139-D3E7F1E9664A"),
                ItemUnitId = Guid.Parse("8A3D8964-F891-40F3-974C-84EE07B1AFA0"),
                BarcodeString = "9509053921472",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c1340480-a902-475e-87b8-22cc4a0c4536"),
                ProductId = Guid.Parse("C493BB30-902F-4F54-830F-A3D6B1683A2B"),
                ItemUnitId = Guid.Parse("24B8E5CB-16CD-40DD-8C7B-A088A1A9A05C"),
                BarcodeString = "8821849937923",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c152a904-9dff-47fd-b156-1985eaeb84b6"),
                ProductId = Guid.Parse("D9A78239-FFF7-48C1-8538-C762C6E5C53E"),
                ItemUnitId = Guid.Parse("4A3F580F-0CD5-451E-A8EA-C727DAAC134D"),
                BarcodeString = "8048201668258",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c1630782-9950-4cff-9370-fbc01b296b1e"),
                ProductId = Guid.Parse("04610291-8C35-4655-BA9B-48198D0D6457"),
                ItemUnitId = Guid.Parse("49BD3834-B727-4977-98CF-61A2766EBA37"),
                BarcodeString = "9391935694532",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c16b6fd9-3946-42ef-8fe9-89cbb318d58b"),
                ProductId = Guid.Parse("FBF09C48-C1D5-4A16-BDAF-3E5535D983AF"),
                ItemUnitId = Guid.Parse("552DC968-2375-4F80-9DD4-365D64D54D1C"),
                BarcodeString = "9194452695802",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c1801e8e-dd16-4adf-baae-0a55dc7cad2c"),
                ProductId = Guid.Parse("AB8B3752-727D-4FCE-A139-D3E7F1E9664A"),
                ItemUnitId = Guid.Parse("BFA5C78D-25C3-4B51-9384-6E6D519EDD5C"),
                BarcodeString = "7092699913122",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c2e91fd8-2360-4f20-a5f7-d42fa2621b33"),
                ProductId = Guid.Parse("7B6B14E1-8014-4755-A20A-69DDAD87A1B3"),
                ItemUnitId = Guid.Parse("26BDB59A-B61E-4575-A656-B3B68B14D28A"),
                BarcodeString = "7705851645217",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c385ec71-5f7e-40ba-b96f-2c763237b8cc"),
                ProductId = Guid.Parse("09187E90-5E30-43AB-BD28-FA869EBBA906"),
                ItemUnitId = Guid.Parse("80D5986F-742C-4A2C-86B4-258B1B10F808"),
                BarcodeString = "8528244795822",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c4957bfa-65ca-4155-a3e0-f223bc86cb3a"),
                ProductId = Guid.Parse("259EEC3C-C5CA-4715-8D64-9423EF301586"),
                ItemUnitId = Guid.Parse("B4A48062-2BA7-49C2-AC33-E16665AB418F"),
                BarcodeString = "6745091602808",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c50937ae-f3e7-4d8c-99bb-682173e772b5"),
                ProductId = Guid.Parse("F7D4DB5B-C00F-4D8C-B9F8-AB85F5D04D0F"),
                ItemUnitId = Guid.Parse("A6689121-2A94-49EF-B5A7-3BE915BEB1EF"),
                BarcodeString = "9435738960034",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c5ac9373-8c43-4015-987b-564e0e141e1e"),
                ProductId = Guid.Parse("5868A3DF-C076-4DAE-88ED-A763A8E2C2D9"),
                ItemUnitId = Guid.Parse("B1ADA7C9-A36C-4D6C-B1D1-F3480F24D67C"),
                BarcodeString = "7367380796545",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c6370794-d14b-428d-adec-fae7dde073ce"),
                ProductId = Guid.Parse("514ED67A-E441-4A5C-809C-423EB99EBBCC"),
                ItemUnitId = Guid.Parse("EF6648F0-C724-46AF-A4A8-6443C2F83922"),
                BarcodeString = "9010034963844",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c6776d23-4de9-40ab-b2e6-5d9e139111ee"),
                ProductId = Guid.Parse("368D3792-52AE-4CBF-A3E1-FFB70A867E0B"),
                ItemUnitId = Guid.Parse("A072A88B-3F5F-46DA-A721-CEE61389ED33"),
                BarcodeString = "8775924636469",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c6cc2803-44ad-4675-8a6b-3cf514ae8270"),
                ProductId = Guid.Parse("10D533B7-CC9E-4A60-B65D-109F90D86E7D"),
                ItemUnitId = Guid.Parse("516344F8-74F2-4B34-A39E-FD6ACFAD4422"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("c7a5d569-8707-4920-b89d-11b341d27afd"),
                ProductId = Guid.Parse("96F39E35-716A-4424-B45C-E3E9F9540034"),
                ItemUnitId = Guid.Parse("7563B910-54DD-402B-8E87-12B3A6CCF85C"),
                BarcodeString = "6056062689189",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cbe6121f-ae14-4b0a-9409-79971bf70618"),
                ProductId = Guid.Parse("08E07219-C245-436E-BD33-86B05E2C6A26"),
                ItemUnitId = Guid.Parse("1145C680-A8BD-42DF-A0B5-DAA7E297D5E4"),
                BarcodeString = "8776282617077",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cd830331-bb90-4215-a8e9-93a4cc0eda6a"),
                ProductId = Guid.Parse("E89EFE13-8CE5-45B1-BD6F-747695519A84"),
                ItemUnitId = Guid.Parse("F3D8C3D5-835D-4F5F-AC83-9900615F344A"),
                BarcodeString = "6791357777997",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cdc22faa-2977-4149-9f90-b4fc79bca780"),
                ProductId = Guid.Parse("D46E2E23-5391-403D-9602-8CAA1E769131"),
                ItemUnitId = Guid.Parse("4E8326B4-07D3-4C1D-8014-9FC57AE686F2"),
                BarcodeString = "7164542757484",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cdd9f5c2-31c3-4d76-9219-5e15f2e61b4c"),
                ProductId = Guid.Parse("39A9C0D5-F8B3-43AB-8A05-4F94DCE7AA10"),
                ItemUnitId = Guid.Parse("C8E56560-8BB9-4E82-89BB-FE482EAEF9C3"),
                BarcodeString = "8068138664807",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cddd9b2c-4c38-4e93-9a33-f8af9b8b9c41"),
                ProductId = Guid.Parse("BA6FEE82-E105-4A56-9365-A497C570A174"),
                ItemUnitId = Guid.Parse("89919F4A-7851-40B1-BF16-BE6C537D10EF"),
                BarcodeString = "7737716817591",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("ce02c2ba-6283-4902-835d-6ab30b92d7f9"),
                ProductId = Guid.Parse("D46E2E23-5391-403D-9602-8CAA1E769131"),
                ItemUnitId = Guid.Parse("55349CA6-285A-4B10-8ED2-3BC2246F319B"),
                BarcodeString = "6803000807125",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cef267f4-13e9-496d-ace1-8f53935e4d68"),
                ProductId = Guid.Parse("1169946B-7C0C-48E4-88A7-A47F7BD5FFA8"),
                ItemUnitId = Guid.Parse("670BB366-373A-491D-AFFF-38A3EB1D5983"),
                BarcodeString = "8783270662255",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cf61d48f-0250-4723-9ed1-e4933d6300de"),
                ProductId = Guid.Parse("4787896C-3176-4AA1-B59F-DC435BDA8EAD"),
                ItemUnitId = Guid.Parse("AB35D516-0B5C-4C8B-B97E-2B07A455056B"),
                BarcodeString = "6851577926656",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cf6f354d-c356-4833-87c1-4ab265b5a5ae"),
                ProductId = Guid.Parse("02369CE6-745F-471D-9862-976C6344927B"),
                ItemUnitId = Guid.Parse("4AE1D97C-5420-4CBA-85C8-01D2DCC101C2"),
                BarcodeString = "8185910978836",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cf8d39e9-00da-417a-8ba9-e37bdc7b626f"),
                ProductId = Guid.Parse("1564475B-EBCA-4BB3-8DE1-328AF49C0E1F"),
                ItemUnitId = Guid.Parse("80912782-EDED-4BE0-B6B7-DD33E6005C3A"),
                BarcodeString = "9464542719620",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cf964b02-fa46-401f-9253-ee80617fd5d5"),
                ProductId = Guid.Parse("42D23B7E-70C4-49A7-BB2A-6D27D2F727D6"),
                ItemUnitId = Guid.Parse("89521651-316A-4649-8FE7-DF19FB1926D2"),
                BarcodeString = "6012650759614",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cfabb7c0-1eeb-44f2-a6ff-57c09d234434"),
                ProductId = Guid.Parse("ED170CD5-03F5-4872-8D09-7C562DEE0E1C"),
                ItemUnitId = Guid.Parse("C3E03EA0-9425-4112-9821-328D9EBCB114"),
                BarcodeString = "6595445735124",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("cfe0538c-580b-4975-b517-9d16bef2c1e4"),
                ProductId = Guid.Parse("C567F6F5-0D4A-4B9F-A537-9EF9BF4FB92D"),
                ItemUnitId = Guid.Parse("0A393751-B7E7-49D5-8133-1828E9F8145B"),
                BarcodeString = "9901527746284",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d044bebb-5fc3-4971-ac19-78b6a2613ea3"),
                ProductId = Guid.Parse("0C20D2A3-0ECB-497C-B963-D8AA4E88B2D8"),
                ItemUnitId = Guid.Parse("3CEB0F57-5AAB-4E4E-AB36-6B6A153AC0A1"),
                BarcodeString = "6351135735779",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d0bf8775-9d9a-4489-9b70-3acfb0d2126a"),
                ProductId = Guid.Parse("3D50A706-EAA4-46CA-93F4-B0F204022A9D"),
                ItemUnitId = Guid.Parse("20426CEE-01CF-40AE-AA30-8760B8FBC8C1"),
                BarcodeString = "9956951638973",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d14cf77b-0383-43e0-8790-05983156ec6a"),
                ProductId = Guid.Parse("D11CD853-1D91-46AE-95B4-B6F9F183E5CB"),
                ItemUnitId = Guid.Parse("E5EF573B-5129-4354-B021-BBFB6CEBF38B"),
                BarcodeString = "8518648669815",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d1ef791e-8a45-49cb-a5d1-ccd02ad8d2f6"),
                ProductId = Guid.Parse("D9A78239-FFF7-48C1-8538-C762C6E5C53E"),
                ItemUnitId = Guid.Parse("B8ED8999-D2DF-44AA-B035-3F0084152972"),
                BarcodeString = "8915137601518",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d2a82bb6-0feb-4986-848c-6a136b08412a"),
                ProductId = Guid.Parse("1681FBD9-A2C4-4EA0-B0C9-38439E239DE9"),
                ItemUnitId = Guid.Parse("069E0AD5-F015-4BE9-B7FE-DC61E5845815"),
                BarcodeString = "9190890769869",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d40b3c29-a026-40de-b502-308b1a4880bc"),
                ProductId = Guid.Parse("75EC2DA5-CFC2-4577-B640-AA37870330B4"),
                ItemUnitId = Guid.Parse("864EC55D-59C6-462E-B60B-AD33FE82F842"),
                BarcodeString = "8897966784801",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d5f8fa7d-d0ee-43ca-9384-01baaf527ef7"),
                ProductId = Guid.Parse("DD0805D2-84A1-4FA1-89B0-2BF012924EC8"),
                ItemUnitId = Guid.Parse("95B0A158-AF96-4FDF-914A-735E5A0B42A8"),
                BarcodeString = "8944152809933",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d65345aa-561c-42e2-8c3c-f52ea0e164e4"),
                ProductId = Guid.Parse("F20C1167-4751-46F0-9A33-AC3D8D00A991"),
                ItemUnitId = Guid.Parse("2A63FB0D-1D0E-4FC5-AC09-705F99AB970A"),
                BarcodeString = "8774569861785",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d655d204-464b-4fde-8c83-ac27f3340117"),
                ProductId = Guid.Parse("71DE705A-489C-480A-9A03-8E112B787307"),
                ItemUnitId = Guid.Parse("21FABEF7-7209-4D20-A11D-EF961E1A1745"),
                BarcodeString = "6315563827605",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d783b195-73df-403d-8e9b-f177fff7e8b6"),
                ProductId = Guid.Parse("C1E9C300-DFB2-4D59-B24B-D325E73EED61"),
                ItemUnitId = Guid.Parse("03C90EE2-E782-4519-9FBE-1F1041093147"),
                BarcodeString = "9800000633923",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d7dffc18-458f-48f6-9856-d69aa2268fba"),
                ProductId = Guid.Parse("1564475B-EBCA-4BB3-8DE1-328AF49C0E1F"),
                ItemUnitId = Guid.Parse("E1E28CA9-8312-4E72-9228-EE9253ABC6BD"),
                BarcodeString = "6824245602814",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d86db41f-a056-4920-bc22-7ffcda213845"),
                ProductId = Guid.Parse("F253EF01-2818-42E7-AE46-66ABC537E5C0"),
                ItemUnitId = Guid.Parse("10B8047A-E230-41A4-9D96-B940F884B114"),
                BarcodeString = "6988110845395",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d894244a-30f6-491d-96b7-4d1bcb938c24"),
                ProductId = Guid.Parse("AE325DB7-B0EA-4C72-9FCA-59B680C4209A"),
                ItemUnitId = Guid.Parse("DEA0342F-6DF6-4109-A731-D9BD1A2D9412"),
                BarcodeString = "8629485647764",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d9418dc6-af50-46be-90b2-cb7e2761980f"),
                ProductId = Guid.Parse("068E8333-8AA7-4AC2-A944-FF96434F6AC2"),
                ItemUnitId = Guid.Parse("926AFBBD-7010-41B5-88DC-3985C2E60C74"),
                BarcodeString = "7075563859211",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d98efa03-9d47-451c-977d-6e75a084337d"),
                ProductId = Guid.Parse("1CD42C42-00E0-4C41-A7D4-61BC7F52644D"),
                ItemUnitId = Guid.Parse("4B76900F-E041-4100-B5DD-5BFE49927717"),
                BarcodeString = "7870988975926",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("d9e29a4c-887d-41ef-9850-162912d1beb1"),
                ProductId = Guid.Parse("DA0CF148-968C-40CE-8D00-70A13D8642CC"),
                ItemUnitId = Guid.Parse("F54BB47F-F7A1-41B9-8CE2-C8DD14048066"),
                BarcodeString = "9163838865009",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("db009521-e2e9-4195-adf5-5bbb33f5b22e"),
                ProductId = Guid.Parse("D07EC644-37F0-416B-9323-AA25D1A819B4"),
                ItemUnitId = Guid.Parse("BD99FDC7-BEB4-4FB5-AE54-4B90FBAB4C48"),
                BarcodeString = "8441886901445",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("db09ba66-c645-4091-8672-1d398cb77460"),
                ProductId = Guid.Parse("4F64A707-DE84-471A-BC9D-D3A890C59F55"),
                ItemUnitId = Guid.Parse("4AF29841-AF65-408C-AB6B-B39C9B0C63B6"),
                BarcodeString = "7774089690144",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("db0bd448-81a8-4147-a52e-6dcb7ee52e77"),
                ProductId = Guid.Parse("D9A78239-FFF7-48C1-8538-C762C6E5C53E"),
                ItemUnitId = Guid.Parse("9AF3C5A6-CCFD-4FFD-90A5-DED3CCEA3D58"),
                BarcodeString = "6664222800130",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("db11623b-bff2-4692-abcd-fbdd942bbe96"),
                ProductId = Guid.Parse("B910CBE5-F014-4E8D-92A0-9199C2206D7A"),
                ItemUnitId = Guid.Parse("406489A7-6BC1-4892-904D-AD83074B4A9B"),
                BarcodeString = "8386448740833",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("db2f8e3f-16c3-464f-994b-00cc0a00e109"),
                ProductId = Guid.Parse("368D3792-52AE-4CBF-A3E1-FFB70A867E0B"),
                ItemUnitId = Guid.Parse("10BD9EE8-878C-473C-9D10-560A26B997A9"),
                BarcodeString = "6516825928827",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("db572d83-76ad-4ffe-8e44-175653212529"),
                ProductId = Guid.Parse("9959BACC-1C42-4791-8854-2285E471D4B3"),
                ItemUnitId = Guid.Parse("7C19662D-BB5C-4921-ACEB-12AFB6FA1E19"),
                BarcodeString = "9948226856893",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("dc4ffa33-3592-47ee-983f-9459171664c9"),
                ProductId = Guid.Parse("87538842-18E0-41E5-AD77-9E3E7F998C40"),
                ItemUnitId = Guid.Parse("75517A97-7876-4A7E-B20F-4E37C99468D5"),
                BarcodeString = "7636942711975",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("dd507a59-5da8-466c-8369-851ebc3a2163"),
                ProductId = Guid.Parse("93B43571-A79A-4FFE-9112-4C48B400A8A9"),
                ItemUnitId = Guid.Parse("146DF446-ED3B-435B-8E11-9D4E57EBC025"),
                BarcodeString = "8623617622502",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("df013542-2276-4dc2-8e05-94748f050b0f"),
                ProductId = Guid.Parse("BA6FEE82-E105-4A56-9365-A497C570A174"),
                ItemUnitId = Guid.Parse("99BFF122-E390-45ED-A1AB-CC225A1C00C3"),
                BarcodeString = "8458508856753",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("df0e055e-e7bd-4df6-8615-194d159ddfc7"),
                ProductId = Guid.Parse("71DE705A-489C-480A-9A03-8E112B787307"),
                ItemUnitId = Guid.Parse("00491241-3E02-406A-B058-026DDAFF9F26"),
                BarcodeString = "9843380668308",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("dfa30c22-3137-4f23-be6c-b3e44e025ebd"),
                ProductId = Guid.Parse("1CD42C42-00E0-4C41-A7D4-61BC7F52644D"),
                ItemUnitId = Guid.Parse("51C982C4-BD4E-463C-9C89-4571C25EB294"),
                BarcodeString = "7017554979580",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e01bc939-8814-4a0f-b7e1-b67ac350fd4f"),
                ProductId = Guid.Parse("AAFDBACD-4121-476B-AEF6-84DB6462BE82"),
                ItemUnitId = Guid.Parse("234B6173-4C04-48D4-8D87-11F5C69D47FF"),
                BarcodeString = "6089029804824",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e148ec8a-35f5-4aa8-bb37-d9347d58a5ed"),
                ProductId = Guid.Parse("D07EC644-37F0-416B-9323-AA25D1A819B4"),
                ItemUnitId = Guid.Parse("B2309A86-EF74-4263-9FD6-66BE385FD5E7"),
                BarcodeString = "7531321739370",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e1b06976-b831-4278-8c76-31aee5b638e6"),
                ProductId = Guid.Parse("2C7AFEDF-7D80-4486-861A-9EA50DBEE9FC"),
                ItemUnitId = Guid.Parse("C56B2047-372A-4E57-B5E0-52C16F0D6E79"),
                BarcodeString = "9211133978434",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e21cbe29-ab3d-400a-bc4a-5d2876dd08e9"),
                ProductId = Guid.Parse("75EC2DA5-CFC2-4577-B640-AA37870330B4"),
                ItemUnitId = Guid.Parse("92146032-6A20-4808-BD5C-B405CC24A462"),
                BarcodeString = "6309502653199",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e25c2bad-188b-4de3-9f03-08116c0e22f0"),
                ProductId = Guid.Parse("0E991364-5F84-4C85-AE72-F6E9404F1366"),
                ItemUnitId = Guid.Parse("F21EEA46-8DBE-402E-A651-7555312279B8"),
                BarcodeString = "9371998994372",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e33e1043-69aa-47ff-909e-3998e2898764"),
                ProductId = Guid.Parse("05F16EE5-B3E2-4EA7-B5BF-16ED86D84CCE"),
                ItemUnitId = Guid.Parse("220DECE4-D93E-49E5-9207-93CA3C03A68A"),
                BarcodeString = "8847794881871",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e3cd24b9-55d5-4910-af2b-e16612f2c67d"),
                ProductId = Guid.Parse("C567F6F5-0D4A-4B9F-A537-9EF9BF4FB92D"),
                ItemUnitId = Guid.Parse("299416C9-CE42-4D44-801C-C0EAF7E95B4F"),
                BarcodeString = "7702986894332",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e41b13b3-f078-4a76-ad35-26b12663c87f"),
                ProductId = Guid.Parse("A276616B-F023-4D6F-87EA-DF5574BD4F9C"),
                ItemUnitId = Guid.Parse("DCFE694A-1ABD-4567-AF23-75925EBD1AF7"),
                BarcodeString = "9940609761478",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e582701d-7e0b-4fa3-b9b5-3fc34ef989b4"),
                ProductId = Guid.Parse("09187E90-5E30-43AB-BD28-FA869EBBA906"),
                ItemUnitId = Guid.Parse("9859D458-6E4D-4211-8067-989EF403AF86"),
                BarcodeString = "9459369778955",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e603ad56-1f54-4c02-bad2-bc41afff8c3b"),
                ProductId = Guid.Parse("B1E0AE2B-B271-4613-89D8-8575564A6944"),
                ItemUnitId = Guid.Parse("5ADCD688-797D-455F-86A1-599BB1680C7D"),
                BarcodeString = "7190234668017",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e6308df1-9fb0-45d0-9239-d71068345322"),
                ProductId = Guid.Parse("9959BACC-1C42-4791-8854-2285E471D4B3"),
                ItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
                BarcodeString = "6959239619131",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e6bb20b0-d9ca-4ce2-b693-6a15b1ad31d3"),
                ProductId = Guid.Parse("AAFDBACD-4121-476B-AEF6-84DB6462BE82"),
                ItemUnitId = Guid.Parse("D56442E3-5858-4A1B-86D7-4A76F09A030A"),
                BarcodeString = "8413291904841",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e7353c1b-9caf-450a-be4b-d284bb848e29"),
                ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
                ItemUnitId = Guid.Parse("C1D7F2B5-E47A-40A0-9DC1-84DBCD6365F3"),
                BarcodeString = "7592932757224",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e780b463-2733-4fe5-9012-4a0b26ebbbaf"),
                ProductId = Guid.Parse("B40836D7-6A05-4D61-B2F2-B8344D6996F3"),
                ItemUnitId = Guid.Parse("0E583039-7028-4AA7-A47D-2E99C2AD5471"),
                BarcodeString = "6196836953273",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e8ee89c5-a5af-4053-b745-847f8811cfdd"),
                ProductId = Guid.Parse("28622BA9-527F-43A3-BC64-241A40E319C0"),
                ItemUnitId = Guid.Parse("5FF76D80-E2F3-47F5-B8D4-4F4FED175FFB"),
                BarcodeString = "8772736746424",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("e9dd1fa5-47cf-493d-8f8b-8eaceba62cf5"),
                ProductId = Guid.Parse("09B413E9-02B8-4FE7-9646-75B7ACDF1FEF"),
                ItemUnitId = Guid.Parse("452C3E2B-225C-4A15-BD5D-136220415A89"),
                BarcodeString = "6300772615468",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("eb371d58-4a52-4d87-87f0-559410fc6b6e"),
                ProductId = Guid.Parse("6028ABF9-2149-4CD5-9B16-CECC80146029"),
                ItemUnitId = Guid.Parse("065BC0C2-CCA7-4568-ACC9-9F7F8BE2109F"),
                BarcodeString = "7785967713261",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("ecae5476-bc85-4c88-a1fe-25f39d6cb1dd"),
                ProductId = Guid.Parse("F8D487BD-A119-4E92-B443-1358B58C995F"),
                ItemUnitId = Guid.Parse("7586CC1B-7E0F-4FF0-B593-38483D04FBD7"),
                BarcodeString = "7336602773210",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("ed7bec85-2820-4763-997c-6c3903abdafc"),
                ProductId = Guid.Parse("3D50A706-EAA4-46CA-93F4-B0F204022A9D"),
                ItemUnitId = Guid.Parse("EFE00027-DB73-4A93-B9C1-2A696FA2167D"),
                BarcodeString = "9364743676749",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("edb06b42-0d90-4339-bdbb-cd13d8873624"),
                ProductId = Guid.Parse("4007CA39-2AAA-45E2-BD6C-ECB16E0A69CE"),
                ItemUnitId = Guid.Parse("8D93EC54-CC09-4E41-A503-B454D72AD405"),
                BarcodeString = "7148544990933",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("eea8bfe2-5915-4514-8b7a-18550d609e43"),
                ProductId = Guid.Parse("A276616B-F023-4D6F-87EA-DF5574BD4F9C"),
                ItemUnitId = Guid.Parse("A32B5522-B666-489A-8751-F36E35F329B6"),
                BarcodeString = "6287854924555",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("eec6f684-dee1-4005-8989-141a73f0178a"),
                ProductId = Guid.Parse("E49EFDEA-46E2-4E3E-9E1D-CB8F2BD81CEB"),
                ItemUnitId = Guid.Parse("504F2844-C89B-4193-AF3A-1E4D1DC2C4F7"),
                BarcodeString = "6855944936472",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("ef243c6d-e182-47b1-aad2-2c55b4f96338"),
                ProductId = Guid.Parse("6BB36A77-5E53-4681-95E0-B693453F1E19"),
                ItemUnitId = Guid.Parse("7BDE1C28-7CBA-417B-BCDC-CFB7771C22E1"),
                BarcodeString = "8661572782381",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f00fef62-5142-4b50-a374-8715c496ac1c"),
                ProductId = Guid.Parse("FBF09C48-C1D5-4A16-BDAF-3E5535D983AF"),
                ItemUnitId = Guid.Parse("A541FF24-A58B-40C0-A052-B679D1578CF1"),
                BarcodeString = "8916869782904",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f08f596a-0252-429e-9faa-7ac5632d737d"),
                ProductId = Guid.Parse("B910CBE5-F014-4E8D-92A0-9199C2206D7A"),
                ItemUnitId = Guid.Parse("A7F0B97C-8659-458E-84DB-0BDC430EB2CE"),
                BarcodeString = "7779561905839",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f1ba7299-7260-48ca-a5f6-6e8b80cddbdb"),
                ProductId = Guid.Parse("40667126-379B-4BFC-A9F3-88F74C17EE8A"),
                ItemUnitId = Guid.Parse("C8F0ACE9-5CAA-4F83-ACE2-42E56751711D"),
                BarcodeString = "8643661886687",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f1cb6eb7-d637-460d-9992-9a89dcc50918"),
                ProductId = Guid.Parse("28622BA9-527F-43A3-BC64-241A40E319C0"),
                ItemUnitId = Guid.Parse("5C079C15-5568-4888-8E15-38E0CCEB9BC0"),
                BarcodeString = "9418315886778",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f2332da6-92aa-4b0b-b3b8-0979193bc599"),
                ProductId = Guid.Parse("F1E438F5-778D-42F8-A81E-0F0B3D97EFB4"),
                ItemUnitId = Guid.Parse("B8D66B8A-80FA-45C8-80ED-8262F4680DF9"),
                BarcodeString = "6026841940931",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f34352f4-0c10-48df-85a2-d31461a8eda3"),
                ProductId = Guid.Parse("3B66B603-5535-44E6-82C6-320E73575328"),
                ItemUnitId = Guid.Parse("7D4EA8DB-E517-4DD1-A191-2470C89FA98F"),
                BarcodeString = "9375656706920",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f3a0b08c-b331-4ad2-9773-12b3116db23c"),
                ProductId = Guid.Parse("40667126-379B-4BFC-A9F3-88F74C17EE8A"),
                ItemUnitId = Guid.Parse("C207000F-488E-45D5-AB13-14A66DAFC60B"),
                BarcodeString = "7798114777504",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f4364abc-eb65-4da2-908b-1b045f00f066"),
                ProductId = Guid.Parse("10D533B7-CC9E-4A60-B65D-109F90D86E7D"),
                ItemUnitId = Guid.Parse("43CF57F9-52F2-4F8F-83AF-E9EC0ABFC63D"),
                BarcodeString = "8683504832699",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f4d04324-be5e-4620-ad6f-01c62ae9e0b2"),
                ProductId = Guid.Parse("09F106A7-DFFC-4868-97D4-9EE24B244B0C"),
                ItemUnitId = Guid.Parse("7F93FB7D-BA39-4782-9355-06AA989554E8"),
                BarcodeString = "9776622696516",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f53d3aa9-26db-477c-a2be-6ee90d7ba2ef"),
                ProductId = Guid.Parse("47278DB5-239B-43BE-81AE-89AF3AAF0443"),
                ItemUnitId = Guid.Parse("CC1E36DA-AB81-4444-8A66-54920522BFF2"),
                BarcodeString = "7019029963767",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f55a7139-ae9b-404c-9101-5f4128f5a69b"),
                ProductId = Guid.Parse("F1E438F5-778D-42F8-A81E-0F0B3D97EFB4"),
                ItemUnitId = Guid.Parse("01E70A0E-FF21-4850-8DFA-23456E708931"),
                BarcodeString = "6887651925705",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f5e24a5b-6c9b-473e-9fc4-bd6810eac152"),
                ProductId = Guid.Parse("65E8B711-3862-4588-8317-1E182BEB9655"),
                ItemUnitId = Guid.Parse("143E5844-ED13-4B43-BD9F-BACD99E072D8"),
                BarcodeString = "7856395781015",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f621e22b-d771-4d41-8cbd-fce01e213c31"),
                ProductId = Guid.Parse("84974822-B09E-4AE5-A793-AE8D52091647"),
                ItemUnitId = Guid.Parse("47AF2EB3-2E03-4DD2-A0BF-07AACA4A59C5"),
                BarcodeString = "6524395600850",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f6f4dc9f-fad0-4d0a-a735-9f768ce1f33a"),
                ProductId = Guid.Parse("02369CE6-745F-471D-9862-976C6344927B"),
                ItemUnitId = Guid.Parse("DEA1B296-7034-47D3-9E33-640EEBFC82A6"),
                BarcodeString = "7758797825617",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f71f474e-7c46-432f-802b-4812d47a39b3"),
                ProductId = Guid.Parse("DD0805D2-84A1-4FA1-89B0-2BF012924EC8"),
                ItemUnitId = Guid.Parse("A5915C84-800C-4B1E-B991-0D931B9285C6"),
                BarcodeString = "7913649737179",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f771b5e9-9836-4af4-a7c5-000ef9981ded"),
                ProductId = Guid.Parse("D07EC644-37F0-416B-9323-AA25D1A819B4"),
                ItemUnitId = Guid.Parse("8CE82425-296E-41C2-82FD-0A36DEEB6023"),
                BarcodeString = "9918247940257",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f796cf5e-9db2-4015-9adf-b997933323db"),
                ProductId = Guid.Parse("B6353454-059E-409D-85E4-B273F1D9A032"),
                ItemUnitId = Guid.Parse("B78537DF-D669-44A5-9EF0-6A4075E54CF2"),
                BarcodeString = "7244195780710",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f7fe05ca-34e4-4639-bd10-83f8150b95ad"),
                ProductId = Guid.Parse("1987A609-D7FC-4EF9-8175-04A08D371015"),
                ItemUnitId = Guid.Parse("8E23D72A-CECA-4086-9677-E00D62FE558D"),
                BarcodeString = "8503151726568",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f80202a0-af8d-4c1a-b1e7-6548737abcdf"),
                ProductId = Guid.Parse("1535C81D-E2E1-43F4-B7DA-5F102896277D"),
                ItemUnitId = Guid.Parse("C4ED4D4A-C179-4278-82A3-2C9822371BB4"),
                BarcodeString = "8594656615937",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f8631374-8df0-45a7-9bb0-2981b17e2ef3"),
                ProductId = Guid.Parse("D091159E-92EE-4F55-AAA0-BC489A719E22"),
                ItemUnitId = Guid.Parse("72F83A28-97C7-443B-A914-14FE8D5D2D6A"),
                BarcodeString = "9783814944757",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f88ccb68-d619-427e-bb07-c86a43583616"),
                ProductId = Guid.Parse("39A9C0D5-F8B3-43AB-8A05-4F94DCE7AA10"),
                ItemUnitId = Guid.Parse("E399E6E9-8987-4A0D-B134-424BF8FA3836"),
                BarcodeString = "8038457925962",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f90ea7b0-6299-4112-8d96-0762dc249912"),
                ProductId = Guid.Parse("91276161-7358-4680-8FD6-A45FA83C3413"),
                ItemUnitId = Guid.Parse("9D8A6A00-D80D-4131-BB9E-DF10AFD44BCA"),
                BarcodeString = "9756020731976",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("f9b3f7c9-4307-4c34-9a7b-104cbf0bb798"),
                ProductId = Guid.Parse("A276616B-F023-4D6F-87EA-DF5574BD4F9C"),
                ItemUnitId = Guid.Parse("51161258-7E59-42E0-AA59-35BCE966F7DE"),
                BarcodeString = "8831180653619",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("fb070a40-472c-410b-9998-8353a9c70efc"),
                ProductId = Guid.Parse("09B413E9-02B8-4FE7-9646-75B7ACDF1FEF"),
                ItemUnitId = Guid.Parse("0AA0545F-D7C7-42BF-844F-B05CC117199A"),
                BarcodeString = "9180875758564",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("fd250ac1-ae54-4508-81af-92ff903de05f"),
                ProductId = Guid.Parse("BA3F09BD-A0E1-4026-9F8E-48FA01B1E97E"),
                ItemUnitId = Guid.Parse("1A0160CC-09BF-403E-B53B-474D8CB00DFE"),
                BarcodeString = "6451666680826",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("fdbebf95-9540-4ee7-ae72-b71b787182bf"),
                ProductId = Guid.Parse("F7439C76-4855-465F-832F-D2B3A845A25D"),
                ItemUnitId = Guid.Parse("6656AB3D-F7E5-4A43-BC04-E16B582A6E19"),
                BarcodeString = "6126459643753",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("fe094b5b-24f9-40bf-a850-4a92e406c17e"),
                ProductId = Guid.Parse("09187E90-5E30-43AB-BD28-FA869EBBA906"),
                ItemUnitId = Guid.Parse("C81EFF75-5756-446E-9881-6C7CCA16EA58"),
                BarcodeString = "7119211966711",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("fe0bde9d-49a8-4146-84da-8e0189ca82a5"),
                ProductId = Guid.Parse("93B43571-A79A-4FFE-9112-4C48B400A8A9"),
                ItemUnitId = Guid.Parse("B0D16F0A-F693-4429-B31F-ED50B9EF7CDC"),
                BarcodeString = "8022286865866",
                CreatedDate = DateTime.Now,
            },
            new ProductBarcode
            {
                Id = Guid.Parse("ffd1b15e-daf9-44bd-aea4-47e3e6a02da3"),
                ProductId = Guid.Parse("04202692-9052-4977-B297-683369796EE6"),
                ItemUnitId = Guid.Parse("F4134AF3-DC5B-42A4-A620-19085DA0F87E"),
                BarcodeString = "8359752666364",
                CreatedDate = DateTime.Now,
            }


            );
    }
}
