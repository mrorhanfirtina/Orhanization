using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.LocationEntitySeed;

public class LocationPickingTypeSeed : IEntityTypeConfiguration<LocationPickingType>
{
    public void Configure(EntityTypeBuilder<LocationPickingType> builder)
    {
        builder.HasData(
            new LocationPickingType
            {
                Id = Guid.Parse("0036fa3c-db48-4bac-a30e-4c4a7c0ff420"),
                LocationId = Guid.Parse("5819EC60-213B-446B-9605-F73E4E2C0415"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0054d61f-7e93-4614-83c4-1bf09d015e15"),
                LocationId = Guid.Parse("F7D706C5-8AE4-4AFB-8316-A25150885E9F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("009244b3-b144-42d9-a726-e020937f7d17"),
                LocationId = Guid.Parse("65472328-CBA1-4948-9A30-82490DE3383C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("00b35895-bfab-4aa4-8fe2-8e794084f8c9"),
                LocationId = Guid.Parse("87426395-54C6-421E-A62B-A43CFB53432A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("00b4b199-a9d7-4ed2-bbed-6ac435727246"),
                LocationId = Guid.Parse("5CB81E9A-0519-470F-9B6E-9F83AD2CA0E4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("015580bd-1b6e-4907-ba3e-074ea0077da4"),
                LocationId = Guid.Parse("D93BADC3-C255-4932-AC8F-17410EC92C41"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("01bed393-ccb0-45b8-a779-9988656a4384"),
                LocationId = Guid.Parse("B72DFD4B-19BA-4E7F-8684-B7420A9012E0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("01cd479e-2c3a-4847-8bd4-2d28d1c89ce4"),
                LocationId = Guid.Parse("7CA93ED9-65E3-40DA-A8E5-FCC5298277A9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("01d38a1b-55b3-4fca-bcfc-cebe01957e82"),
                LocationId = Guid.Parse("9F6287EE-0B3B-48B3-A3B7-6ACE7D914F49"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("01d6fac2-bafc-4c59-9dcd-0445bfbc6e50"),
                LocationId = Guid.Parse("7D881881-E983-403E-88FC-FB70F7DD6A34"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("01dbe106-7fc1-4941-9272-98746ba136aa"),
                LocationId = Guid.Parse("7CA1A88F-DCD1-4F4A-A4E1-721664F8AE47"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0207097e-e6d2-4371-9de3-82e82d61a915"),
                LocationId = Guid.Parse("7766DDAE-3CD9-4574-82ED-3D7D2ECD48DB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0258ed28-4be2-4a08-a047-357c1d644cdf"),
                LocationId = Guid.Parse("E37AE645-A1A4-417E-BCA3-F5327BBBB36A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("029ec900-1f84-4f0d-99dc-8fac59dd129d"),
                LocationId = Guid.Parse("5484A1BD-B0FC-4AD5-BBFE-ADFFF0B88EC8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("02c0895b-7bdf-448d-989d-14e8808d7fc0"),
                LocationId = Guid.Parse("542799CB-1124-410E-85F1-BA593EE5A0A7"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("02efe9fe-f828-4777-9b5c-7c6cbbbc6314"),
                LocationId = Guid.Parse("8E71B940-8F17-4A2F-A9D9-0715754CD1A1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("02f94005-489e-45f5-af06-7a10e37902c7"),
                LocationId = Guid.Parse("2895F5EB-F72C-4CAF-B60D-FDDBCA4CC26E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0348ccad-42bb-44ab-bfd0-a66ebb031f12"),
                LocationId = Guid.Parse("CC2B3FF3-50CA-4976-A7BF-AFCF2E42B1D0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("037ecc99-9905-495c-9014-b91ee64f18d4"),
                LocationId = Guid.Parse("870BF8CA-BBDA-4B0E-BACD-0FD06BA69FF4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("044f5164-1f17-4aba-a01c-9acd6a64ccff"),
                LocationId = Guid.Parse("BE3DDD65-CBBE-4807-8B3D-6304C30FB034"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("046151e1-81cc-4f79-92bd-3c8c95b08cfe"),
                LocationId = Guid.Parse("0AAB0CF6-10AB-49F9-A977-904A54D71FB4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("046d7026-ae92-46e7-9c67-d5cc19557dcb"),
                LocationId = Guid.Parse("84AF8044-D1BF-4F26-A6AE-A1BBE7A7024E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("04ccf263-00ec-4e97-af0f-f95490a28f4d"),
                LocationId = Guid.Parse("FB89E9BE-C20C-45FA-A37B-4576CB39C76F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("05231ff7-0a2d-4b5a-a227-6dcaa477f06d"),
                LocationId = Guid.Parse("7DB0738F-00D8-4113-A5FD-0A4565A1E9FF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("05385540-b1ff-4441-8866-c7e08ebf7900"),
                LocationId = Guid.Parse("D5A6FA1A-F112-40A2-A8C2-A4CF08872374"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0559fe8b-3203-4084-bbc3-67a766c9ef61"),
                LocationId = Guid.Parse("06E34A1B-A351-4E0C-9E33-C5B375BCEE29"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("056fca55-8308-49d5-b154-15476abc709e"),
                LocationId = Guid.Parse("A88040C2-F46C-4155-AE84-DF61E1D99E97"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0581cef4-8fc8-4003-9167-15bbc2a6f5ae"),
                LocationId = Guid.Parse("6C189587-F758-4828-AE14-2282A5D987E1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("05ac443d-faf7-47e8-a0ba-23c56ff7c6d0"),
                LocationId = Guid.Parse("70946B36-7088-4BC6-AC72-B24F32952938"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("05bdef9b-9467-4d89-b2e1-8ad398d5bd25"),
                LocationId = Guid.Parse("6F37CFFD-36C9-4158-9F9C-648F1AE3EAF8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("05f3fa60-a509-49c1-921b-1a65929f32d3"),
                LocationId = Guid.Parse("2547A01B-519B-4A5C-9DFA-4530479A749D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("06529968-5c2d-40d5-a949-4d5f912967aa"),
                LocationId = Guid.Parse("0CA6BFB4-D9AA-4270-8990-BF88F89AFD31"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("06a163e2-ab7a-4ba6-8f0c-4dba554a0d97"),
                LocationId = Guid.Parse("9EBC52DE-22B5-4048-A4EA-E498936ABA05"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("06eebb71-d855-4969-9e8d-42d1c4cdcb55"),
                LocationId = Guid.Parse("4D3F024B-0E54-4F20-B9CB-0ED98824BE71"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("07963d5c-c287-4d90-8f8b-bf21b2f50ade"),
                LocationId = Guid.Parse("2400A1CE-8D9F-4157-B8DE-43EF6A7E9A1A"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("07afd684-4069-4e93-a2d3-6dc11e75ba14"),
                LocationId = Guid.Parse("D49024E5-3A11-4293-AA55-3ED4D5795C61"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("089b7249-b9a3-4f1c-a44d-f57d7fd779a2"),
                LocationId = Guid.Parse("28760806-36F2-4684-B18E-8D8F62B25896"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0911f4e0-63fb-4d97-acd8-28ccd0a0477a"),
                LocationId = Guid.Parse("37A0D29B-83F4-4C7F-8328-627A25503592"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("09c20242-7555-4a5c-b07b-960f1c0b1bd3"),
                LocationId = Guid.Parse("D116567B-ECA2-403F-B856-459ED69233BA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("09d8c4b6-8c82-42cc-8439-d0aa6c155fb1"),
                LocationId = Guid.Parse("C9E0D628-39FF-4673-8876-C04F3C8B49EB"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0a5a1bc8-7f8f-401a-b8c9-74777292ab2d"),
                LocationId = Guid.Parse("6369BC0C-381C-4E67-92A7-81C94F3F8260"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0aa473ba-84d4-4f28-873a-bd3be137c995"),
                LocationId = Guid.Parse("B9954F5E-2AF7-4199-AD45-B6525DC107E5"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0ab42659-2002-49d1-9c98-41e18e5758e9"),
                LocationId = Guid.Parse("C904F2C8-D611-4817-BF0B-FCC335168173"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0b1ddf11-3a8f-4149-b70d-9d572bc74f9b"),
                LocationId = Guid.Parse("BFF89121-7372-4FA2-9128-A9F7506C8205"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0b27aa1d-92df-4970-9b3e-b6c7ab3a1c5c"),
                LocationId = Guid.Parse("BB04AC25-FA8E-443E-A780-9C93854379A2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0b77d40f-1299-48c3-bef9-d6c081f5f1e3"),
                LocationId = Guid.Parse("4A4BDC07-ED9F-4929-94B1-D10EAEB95536"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0b895aa5-c2c1-41d9-9c2b-d3fd318cb45b"),
                LocationId = Guid.Parse("F261016D-FCB3-4EDD-BA9D-DE5E3ED85AA7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0c3fed1d-d36b-49dd-867b-448499884331"),
                LocationId = Guid.Parse("4F2A0D23-58C0-4F14-9F0C-BAB18B46A9A5"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0cae1e20-8616-4a9a-b26b-064497b548f5"),
                LocationId = Guid.Parse("DC1A550C-42D4-4FF0-B0FE-046DE3043931"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0d7e72c7-1718-4299-a4aa-fc0394358d58"),
                LocationId = Guid.Parse("0E835AB7-2E8D-42DD-8CF3-1DDBEA7F0477"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0de36927-821d-48bd-830c-4c1c78246000"),
                LocationId = Guid.Parse("C4BA865E-A08D-48AA-A72D-433A30A49185"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0df55d78-aef0-4e73-b163-cde09daf6130"),
                LocationId = Guid.Parse("1D285A1E-59EC-45C5-A516-8322B07816BF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0e44d36b-11ef-4a84-83c6-c9d59596589a"),
                LocationId = Guid.Parse("A83B8E11-3325-4E37-A2F4-E6F55475035D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0e58154e-8072-4d78-8881-3608c32a044c"),
                LocationId = Guid.Parse("C115EAAC-F40F-47F6-85B9-66386A03C016"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0e68100b-fc57-456e-8bc9-273f77d5d651"),
                LocationId = Guid.Parse("3E5D5B64-5184-472D-8B00-904E6D19884C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0f1b70b6-9f23-4893-a8e6-fdfd3ec80d5e"),
                LocationId = Guid.Parse("4F241A92-D523-4661-8604-0079F002008A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("0f33a7e9-2601-4830-86a9-060f4e4b59f8"),
                LocationId = Guid.Parse("B937F620-1653-45C3-9026-0D61CFC3D518"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("101f7c75-c4ca-49f3-8224-668d7c49bc5e"),
                LocationId = Guid.Parse("DB59859D-50F4-4431-BCD1-24B8EE65D2CE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("102f4f05-33bd-422b-8752-d74c9087cfa7"),
                LocationId = Guid.Parse("2AD20429-6726-4B08-ACCC-48CA689D03D9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("10e4dfe4-311a-4fca-bad7-17b06340c5b9"),
                LocationId = Guid.Parse("31FD185F-607A-4486-9123-39EA39AE5CD8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("11854937-279a-4ebf-b5b5-a1200a59bc62"),
                LocationId = Guid.Parse("3E9C8BC6-C560-41E2-A0FA-65C733518CF2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("11c70087-96a6-468b-9cee-adc6b36b8002"),
                LocationId = Guid.Parse("F344F99C-923A-4BB2-A9B8-019AB3059BED"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("11da616f-0406-4064-b7b1-da24707359d1"),
                LocationId = Guid.Parse("433AD73B-0853-48AE-ABBB-6994FE37C804"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("123b8281-a3d7-4aef-896e-7ac486795c61"),
                LocationId = Guid.Parse("F4FE04A5-224D-4D6C-A29C-293E636685B2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("12b2857d-02fc-4789-a22a-832274d2e3e3"),
                LocationId = Guid.Parse("58C8AA4D-A85F-40DC-9C22-33E520385D4D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("12eb8d1d-6f60-4a89-837c-5318a820e6a5"),
                LocationId = Guid.Parse("01C6A392-12B7-4712-8711-43E3B4D9ACEA"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("131f366f-156a-486a-aded-3cce8bb0f128"),
                LocationId = Guid.Parse("4A2B7271-65D3-41CE-ACBE-ACEBE26F4804"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1348e5b7-75da-4b33-a119-fad7904c5f70"),
                LocationId = Guid.Parse("CDE1CC2A-A6E1-4070-BAEF-F64584CB386F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("13712b0f-835a-407a-b552-9ea18ab9bfa1"),
                LocationId = Guid.Parse("2F868614-B887-420A-82F4-829B375C998E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("141e01c0-5c9d-4b90-bc14-157801d22400"),
                LocationId = Guid.Parse("98BDF824-9A8B-40E0-A59C-0F8F67301EE2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("145ea07e-ea76-450c-9d40-60a7f5786aa2"),
                LocationId = Guid.Parse("A53DB7AA-48F1-462F-BDF1-9FDEFC5F2BC4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("14870914-6018-485c-9e12-188f17ef192e"),
                LocationId = Guid.Parse("37973337-3EB5-4A7C-961D-18FE6E24589D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1492880a-aaac-455c-a911-9aa889b7e5ab"),
                LocationId = Guid.Parse("4B921B8F-D3C5-497F-AEBE-7B9BA05E2ABB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("14abce3a-01e4-4224-b50b-2c92fadb115f"),
                LocationId = Guid.Parse("E85117E6-D664-459F-876C-C4E4802EE14A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("14bdb652-47d2-42ea-8a30-f7ae74c3365b"),
                LocationId = Guid.Parse("EAFAA6E9-FB9C-4896-8932-27E89141579A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("158bcad0-b875-4ef8-9fa1-ca0491d8ba7f"),
                LocationId = Guid.Parse("01FE675D-797A-48F2-A5FA-88B45BD54855"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("158d721b-4900-4fe0-be8f-93a41e881590"),
                LocationId = Guid.Parse("7677A671-91B3-4B61-B10C-F0E9DD8D8583"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("15d65596-fd2e-4439-933b-dff41ef513e4"),
                LocationId = Guid.Parse("DE8C2D47-DF2D-42F3-91F2-6DE87A5F54AF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("160b3d1b-48a8-4e21-9aae-dfa5f5a8b7f9"),
                LocationId = Guid.Parse("C933DA53-58E9-46B0-B68C-A561E27A7F62"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("16251655-80fa-4afc-8ddc-ec9be244121b"),
                LocationId = Guid.Parse("C4D0458C-91C5-4532-9D5C-086E69CA697E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("16ac4285-9954-4335-ac5d-31095d2e880b"),
                LocationId = Guid.Parse("5824A8CD-F3F3-48F5-B6E7-608E2B1B4F0C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("16dfa850-2807-4157-aff0-d7e43246065f"),
                LocationId = Guid.Parse("AADE6D2D-4FC1-4209-8F5D-F076439A894C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("16ffd9a2-b62c-4de0-8586-8e4678f4a0d2"),
                LocationId = Guid.Parse("7B7C987A-8A18-4DCA-B71C-F5E51B518D69"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1708e15b-f1fa-41e3-b57b-15cba6eb28a3"),
                LocationId = Guid.Parse("1623AC56-6058-4D90-AF88-391C438931A2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("173dbe59-e6e7-4dca-ba46-0d8482893517"),
                LocationId = Guid.Parse("45BF7E06-3B66-4383-9FAA-B709E9FF7B47"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("17949320-32e1-4847-9339-354606befe14"),
                LocationId = Guid.Parse("37D94B3C-9242-4E59-B4FB-18BAB6A7B77B"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1836cba9-6e10-4bbe-9884-c136fc312b63"),
                LocationId = Guid.Parse("08600ACE-38BE-48DD-9A6E-37C165F2938A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("18495839-a689-47f8-8dbe-304249d8b6c8"),
                LocationId = Guid.Parse("8BFA249D-345B-4CD5-A6AA-F70E7FAC6EEB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("18527ddb-886c-4b91-8ef8-cd40627d74bc"),
                LocationId = Guid.Parse("65521AC9-7FEB-4AC2-B68F-92F7B5295EC2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("18a2f0cf-7fef-43a1-9e90-e866397070d6"),
                LocationId = Guid.Parse("0CEA5D3B-C27F-41F2-ABF5-EBF578C835AC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("18deaa49-f92c-42e0-81eb-41f37063945a"),
                LocationId = Guid.Parse("C5D2D529-425A-4AFF-8501-D60400C5AF80"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("197dc561-2a6f-488a-8bfe-cf4d07980b7a"),
                LocationId = Guid.Parse("0CCF039F-855D-40BA-8CF3-6F8330AF1AB7"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("19ab2efc-7104-444f-9e3e-5af8ac3a1c21"),
                LocationId = Guid.Parse("E6D65AFC-A22D-4149-8327-C1B5F1226547"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1a02f0c2-bdc9-467a-b78b-d9eff2cdbaa9"),
                LocationId = Guid.Parse("2469C682-CF4B-446B-9FAD-76C94321A74E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1a7b2154-8670-45b6-bc9e-db6e85d42b2c"),
                LocationId = Guid.Parse("EA6BA8F9-5424-4EB7-865E-6B6A054283FD"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1a93736b-702b-4825-853b-73af351aa443"),
                LocationId = Guid.Parse("C069E7CA-89DC-4CEE-AC5A-170300852625"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1a94e9e0-fb90-4b73-9e3a-cc261cf00a49"),
                LocationId = Guid.Parse("B9C2C1B4-AB00-47EB-B0DC-69761553855E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1aab6553-1a9e-48e1-9df3-8342c6e0086b"),
                LocationId = Guid.Parse("45393795-8BFF-44BE-B8FA-A87DFE02CC41"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1ab8bac2-389f-4cdf-b03e-13327ad5c6aa"),
                LocationId = Guid.Parse("6019CB17-657B-41D1-8936-799A728AB0C6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1ada8470-9db4-4fd7-b08f-3ce63084a3f3"),
                LocationId = Guid.Parse("85E574E5-871B-4A7C-A6A0-912D978AA876"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1b78f918-25c7-49a0-aa03-10650c9f66cc"),
                LocationId = Guid.Parse("7B9229C5-88A1-496E-992F-BA887AFE0BF8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1b815878-def3-49ef-9a59-7e2922c0d981"),
                LocationId = Guid.Parse("D5F97054-8B88-4D21-BE42-8ECAFFCC3E26"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1b837ccf-359b-48e5-9f81-fbea4b851351"),
                LocationId = Guid.Parse("48538912-2E19-4268-ADE8-F10BD97F27EF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1bb3a4b7-15f0-4587-af22-9d4e9cc8d965"),
                LocationId = Guid.Parse("10993DCA-FF75-4616-A226-A41F2117F7BE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1c551dc9-fd7b-4c9b-bf82-c5d63c48d363"),
                LocationId = Guid.Parse("5B8C341E-E660-4796-B4F3-2E7BAE6266D7"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1c827d73-4a96-421e-bab8-b4cb8d75b691"),
                LocationId = Guid.Parse("58A75A0D-DE86-49BF-B195-E10811492658"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1c9d9a7b-e6ad-4166-908e-94dba33d854a"),
                LocationId = Guid.Parse("AE888DA9-3357-4043-9DC8-7F75531A60AE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1ccf9e25-8e51-45cd-874d-2bd2caaf4ad1"),
                LocationId = Guid.Parse("5808139F-5FED-4D9A-806F-11F7259FDD11"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1d24934a-675b-462d-8c69-43981b65cec0"),
                LocationId = Guid.Parse("1FFB53C3-0811-46AF-BADF-F2FFA3AB3803"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1d6fbf61-3158-486f-a479-9a9730bb8b0c"),
                LocationId = Guid.Parse("30801C7C-4A19-42C2-992D-F35E73EACFD1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1e2f078b-cedc-4891-a186-e246571563ed"),
                LocationId = Guid.Parse("43336C29-8B2A-4B47-A4F3-2B74EB18A7D5"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1ec3e8b2-5ab8-4c4e-877b-c60c874bdd24"),
                LocationId = Guid.Parse("018FF9E4-7A40-4E98-A22C-96B6FD44A7A1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1ed3e2a3-b0d6-4034-951d-c202695b850c"),
                LocationId = Guid.Parse("29A0064E-D901-48B0-BB6C-74F87AF1519A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1edbe465-b094-4058-8ae1-1e23b33ee150"),
                LocationId = Guid.Parse("0EFC4F0A-52A3-4B1C-BF12-50CD20DAD3CB"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1f79111c-a52e-40d7-9fb4-0c95b0b7fc04"),
                LocationId = Guid.Parse("A936855C-EA0E-45EE-9FE2-8EF772067BC1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1fb4523d-a941-473b-8fd5-738c44c748d7"),
                LocationId = Guid.Parse("9C34BF02-6E1C-4617-942B-C2895444BC4D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("1ff4f67d-7ee1-4de5-863e-582bae562c9b"),
                LocationId = Guid.Parse("39505CF5-DF22-4CE4-B570-4064A7D53E2D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("20046d7f-e635-4303-93c3-2765cc6fb130"),
                LocationId = Guid.Parse("43A0554E-6464-4393-B9F7-4049D528BA42"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("205562e8-0eb9-4a97-8c94-abe6ea6628af"),
                LocationId = Guid.Parse("8C719712-91C4-4A4C-8140-125DCA14430C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2098d4c8-9369-4aa0-b748-54b0383da644"),
                LocationId = Guid.Parse("6FCC47B7-677D-41F7-B7B5-6FD4CD47DB11"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("20dbd825-c708-4258-9b2e-684beefe89d4"),
                LocationId = Guid.Parse("342A4AB3-6D0C-4DE5-AC65-D608A0EBEB99"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("20de71d8-0400-4ade-9904-8ae50c160f25"),
                LocationId = Guid.Parse("951C4193-A262-49D5-BD04-3618BCD87A79"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("21381970-e1c7-4809-aee7-6370b9ef60c5"),
                LocationId = Guid.Parse("B6FE9A68-70DE-48D6-8A8E-944E344698BF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("21545f7a-924a-4f7f-a0b9-cef92e7baafc"),
                LocationId = Guid.Parse("62387834-44EB-4420-A7DA-CD49A139335D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2196f986-a969-41f7-a7fa-651663f5e445"),
                LocationId = Guid.Parse("1D874D38-573B-4A35-8878-4A116597EA84"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("219e1dbd-227d-47fa-9337-c49238e2e603"),
                LocationId = Guid.Parse("A472088F-B78D-4125-93E7-0205E3928D0D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("21de0d26-c6dd-4e16-af5b-f83b604298dd"),
                LocationId = Guid.Parse("E1310210-3B3C-4D86-99D0-532D0D6F5C79"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("222286e9-9561-4d2f-92f2-601814380498"),
                LocationId = Guid.Parse("8811E420-489A-4BCD-B16F-98629EB9EAB3"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("23a36024-b7cf-4bc5-b5c9-cc78de662568"),
                LocationId = Guid.Parse("3DFE2DA7-3DA3-4CDF-A6D7-94D5AE00CE80"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("23dd8345-38d6-4650-a4aa-51294efd4a01"),
                LocationId = Guid.Parse("D994B067-6BA1-48FB-AC11-E4D9CDA790FD"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("23e9afcc-00cd-428a-bea8-ca1735bf8241"),
                LocationId = Guid.Parse("B3FB89E5-363C-4FBD-A978-1D23F191A2BC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("244d23ce-51a0-4004-b73e-f27128be4a01"),
                LocationId = Guid.Parse("EC1F52F5-70BD-46FD-BA0F-6B62716BB55A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("245e495e-02e1-4323-8530-52ba3c0b3ece"),
                LocationId = Guid.Parse("C4E8063A-0FEB-496E-9A5E-6F8A0FF6B845"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("250cdb8d-5d2c-4833-a0e1-cdee18f1108a"),
                LocationId = Guid.Parse("D658EE1C-3504-4D7B-B0D1-E9D844DEC5C0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2558cdc1-91a7-44c3-87db-bccb839a16f1"),
                LocationId = Guid.Parse("916C6B67-2790-4A3C-872F-39E80FC3E195"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2568efe9-7048-41c2-8f7a-a597128bd388"),
                LocationId = Guid.Parse("9232D026-A6DC-450B-A445-D252C01F0959"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("261ca168-929f-47d4-81b5-c8b1cd320830"),
                LocationId = Guid.Parse("3DDDC968-A475-456F-8E78-7121321CA048"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("26295799-164b-41c6-9b74-b85f38349767"),
                LocationId = Guid.Parse("E7D021F2-3E6B-419A-9E5E-1690C2C7B3C9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("262c7f08-f66b-4c6a-bc93-41692979537c"),
                LocationId = Guid.Parse("8BFE786D-3C66-49CB-B720-88DE86DB872C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("26d10264-31d2-4266-8892-e81c3ce12449"),
                LocationId = Guid.Parse("1A9DAD23-9299-4671-931E-CB08C1E49E10"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("26d4594c-b6d7-45e2-a851-4d37cd20fca2"),
                LocationId = Guid.Parse("C1C10C8A-D575-49FB-AC51-1C54A1AC01FB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("278c2839-6285-404a-96c0-df464ea33afc"),
                LocationId = Guid.Parse("F5F4908D-8F63-4F33-AD49-685C90046798"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2795f26b-bf12-43fd-8a47-8d49e6af432f"),
                LocationId = Guid.Parse("DA36052E-DA7E-4581-8EE7-B9358F11A0B2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("27c6ec37-ca8c-47ed-9e4f-6c18ed01fbf3"),
                LocationId = Guid.Parse("15420D23-38C6-40E7-9C6C-12474ADB71A2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("282b1f9f-17c9-4df4-8176-4e8e18cc27ea"),
                LocationId = Guid.Parse("7BEF9224-C19B-4951-B3F0-5D622302F502"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2866b297-e0ea-42c5-aad1-2e7df281e06c"),
                LocationId = Guid.Parse("D8B89A7A-69C7-44E8-A66F-6EBBAE260293"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("28671464-3814-4b70-a06c-9b441bffb1e6"),
                LocationId = Guid.Parse("B7533350-4B1D-466D-AC01-20FB0A4C259B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("28957e09-00b5-4ad1-b862-b149a5b9aef8"),
                LocationId = Guid.Parse("2A58FE31-856B-4010-93DA-53DEEFDE4ADD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("28967a36-cd00-404b-bc6b-fdbc624c00a3"),
                LocationId = Guid.Parse("83C950A3-EA62-41F1-9EB9-FF90F92DD15C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2906ec01-d9fe-4383-8d7c-d38f73327671"),
                LocationId = Guid.Parse("B2AF8BBF-59D4-413B-84F2-54FEB51ED6EB"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("290d07ed-89e5-4479-8ac1-ab7a7464c3d2"),
                LocationId = Guid.Parse("20F92890-3774-4091-A98C-E8C40972354D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2954aa05-33be-4fe3-94e0-19a6d33777ce"),
                LocationId = Guid.Parse("0A761667-A949-4207-86DC-EAE73E8FE291"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("29789c16-648a-4c91-b0a5-8bda19adaa50"),
                LocationId = Guid.Parse("534B4B6F-AF38-457A-91A5-84E291468028"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("29879899-14bb-49b7-9407-0d22020f4890"),
                LocationId = Guid.Parse("FCB11A58-0A7D-4EC0-93CE-04D4A61F9F19"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("29b7bb17-60d6-48c1-a727-10e4c87ac669"),
                LocationId = Guid.Parse("4CC8DB36-8C93-4AB9-B71E-629D57732079"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2a3c3c1e-d540-4de0-9e78-648d213eec9b"),
                LocationId = Guid.Parse("6ECD12E5-E5FB-4BF8-9E70-820885AF4C0F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2a6b7cd1-abfe-4038-83af-24ce76ad4289"),
                LocationId = Guid.Parse("50FE98D0-0D62-4B2D-A799-91D7C4343D3F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2a7d8973-ff6c-4954-beda-97ba6e37f66f"),
                LocationId = Guid.Parse("EDE82731-F972-4C94-B0B3-A63EE6439149"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2a9400d1-c3d1-4974-a45f-052e47f0b698"),
                LocationId = Guid.Parse("F8AF3840-DCC3-48B4-ADE8-4EBFBEA921F8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2ad5efd4-7fb1-477c-9ee9-ceed6cd1a4d7"),
                LocationId = Guid.Parse("5444594E-80E5-43C9-B4B9-45E1A2F3C106"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2af027f1-c691-4423-9d50-91b4d3de7af8"),
                LocationId = Guid.Parse("B96CB111-3B4A-48D9-94B2-D5AE7B28B134"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2b204e7a-1177-4296-a8bf-6ab135a5b3f9"),
                LocationId = Guid.Parse("CBC0A569-A95E-4903-AC34-A6184196D42E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2b20c01d-211c-43f8-9541-d5839144a352"),
                LocationId = Guid.Parse("30E57503-8E1B-466A-B037-FE93EEE0C7BC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2b587b46-ced3-4811-92ef-12373d92c637"),
                LocationId = Guid.Parse("0DD5E0F0-FC93-4D1B-B7F1-95954442ECD8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2b5dc57e-434b-4ae2-8892-c1f1cfa052bc"),
                LocationId = Guid.Parse("F560D34F-7BC8-4E72-85FE-CF1700B41D06"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2bda02d8-46c6-431c-9a34-4393f1c312e6"),
                LocationId = Guid.Parse("25C4071B-EDCA-455E-9ECC-9BDF9F2DFB77"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2c4c3bd6-46fd-45f4-8d07-7bbc194626a9"),
                LocationId = Guid.Parse("02284D23-3AE8-4900-BB14-D5A1F728DE43"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2cb0062f-c06a-426a-b01c-a981bb3fe689"),
                LocationId = Guid.Parse("07069E49-04EA-4A65-819B-1FAA890DB93E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2d39c126-f070-4b07-9c34-a893f0ac6d67"),
                LocationId = Guid.Parse("0369C9E7-9052-4334-A330-651904E3D5F6"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2d8f515b-ec14-490b-b9a5-163c5bc5d0ee"),
                LocationId = Guid.Parse("11F4FFE5-AEAC-4708-91A2-873503910271"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2de27624-8c29-4bf1-ac7f-9745721ba908"),
                LocationId = Guid.Parse("ED32593B-972A-4C30-AA7A-A86CC197665F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2e00de17-6e8a-42d4-928a-86b7402fd48a"),
                LocationId = Guid.Parse("21BD5634-DC69-4A22-B743-B6C015D9BB2D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2e4b6f72-385b-4b59-b3f5-223e0310b25a"),
                LocationId = Guid.Parse("62CA6FC7-87E1-43F4-B173-0972C7859A33"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2f18a0d4-b50d-4efb-aa58-25438268b015"),
                LocationId = Guid.Parse("820562DE-CEBD-46DE-A729-7433F7C3D76D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2f90fd39-a7dd-4ab4-ac6f-ea07cd42e1a4"),
                LocationId = Guid.Parse("2EB0EF3D-5723-4DA2-B112-BF0D4E33E4CE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("2ff968e2-51b6-4281-8877-fc993f6710a5"),
                LocationId = Guid.Parse("64912443-D586-4744-806D-EE947D2945E7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("300e3046-744e-4f41-b838-ec3ab1b10cce"),
                LocationId = Guid.Parse("DC8C6EC5-05B1-4089-B872-DFBFD8BC88C5"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3060d549-fe45-4c6b-8723-ce704e253198"),
                LocationId = Guid.Parse("146F1C82-6B22-410E-8D46-A36F797B2F56"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("306fd423-b8d2-40be-8a54-7b0d4b6394c9"),
                LocationId = Guid.Parse("95D257E7-7ADF-4F8E-ADAD-04AF89F74BCB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3076561f-ce68-4048-a160-15ad36f775b4"),
                LocationId = Guid.Parse("70A3B1AD-0380-4D2D-BAD7-5555B3FDFC25"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("30c642a6-db1d-4f29-9206-c9ec86e75202"),
                LocationId = Guid.Parse("9BDA4EBB-49B5-4AC7-9B0F-6CABBC4A12AA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("30fefd37-4cdb-46b1-93aa-428da9b4f7c6"),
                LocationId = Guid.Parse("DF34862E-5CF5-4829-8DD1-AB9E0ACA4F06"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("31233722-5198-43d0-9517-553f043b3035"),
                LocationId = Guid.Parse("F2D0E15E-FDE1-4CE8-8530-E3A629DD25C6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("312d8c50-3a51-4dc4-b843-b85b1f43f69b"),
                LocationId = Guid.Parse("40AD9B0F-9097-417F-A124-8B0425D77EB0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("313df002-ffff-44fc-a49b-8a1f85e90e69"),
                LocationId = Guid.Parse("CE9467D6-BBC2-411A-94E7-13FB0EB67190"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3150d7c4-28c1-4f54-a99f-200c673e0af0"),
                LocationId = Guid.Parse("559A14E6-F482-44CB-BEB9-15F0D7B76897"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("31658263-6ba3-4f8d-b16b-7f8f159c0e12"),
                LocationId = Guid.Parse("DA645152-DC1F-43D8-8483-25E9E4AF5ECE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("316cab60-2bc6-4505-a99f-9e5151a98022"),
                LocationId = Guid.Parse("7CE72209-193E-4122-AF20-F79F9E33B911"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3192b1f7-326a-425e-ac1b-73d0a732217f"),
                LocationId = Guid.Parse("142B6FFA-FDA6-4279-AC0D-52E7657D2D94"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("319cb82a-3515-4ed0-9eb5-e2a9d3986209"),
                LocationId = Guid.Parse("4AA27177-D240-4986-BCD1-1209C5C89D75"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3225b083-dc0c-4625-8d9b-56a882ea4c57"),
                LocationId = Guid.Parse("962EC7A4-552B-4502-AFF9-C4E7E00D6E6E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3229bb7f-b84f-40cb-a0dd-fa4124935201"),
                LocationId = Guid.Parse("051DCE8E-5D80-45D0-8BD4-B284A68387E9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("327c9ddc-f58d-4f6b-9b0d-35e99124d4cc"),
                LocationId = Guid.Parse("1EE2CA7E-9ADB-4EA7-B47D-DAF5AF2DCE93"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("330a944e-aac7-44eb-ac38-296b9f7adadd"),
                LocationId = Guid.Parse("6C40644B-AED2-4A22-9D03-7912B65CED3F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("330b998c-ab0c-4e11-8029-525150fc840f"),
                LocationId = Guid.Parse("AF462FAF-E46E-4D4D-92CB-A91656784F75"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("334af89b-1072-4a8f-8edb-070bb47eb2db"),
                LocationId = Guid.Parse("E20D799C-7387-4583-83AD-A0105CC2185A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("33bc0244-3ec5-4755-bad6-10f2632d8bf2"),
                LocationId = Guid.Parse("FD4C1BCB-2C66-4CD1-B246-13CE29DDFD1C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("344a4212-5b38-489e-8979-ee599037fab6"),
                LocationId = Guid.Parse("B51FE85C-B0DB-48D5-A6CA-20A96AE491CB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3455601a-c2ed-4144-b82b-74da73f8fe55"),
                LocationId = Guid.Parse("7BFFC99A-7806-4E4B-A3DC-A07D3A1D551F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("346beca0-c0b7-43a7-8820-649a44959672"),
                LocationId = Guid.Parse("774A2B5C-8BEB-41CC-AC19-14E7D6D2476C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("346ecf2c-37ce-4de3-b91f-8866dd7e8445"),
                LocationId = Guid.Parse("56FF3BEE-B5AA-4E17-8FFF-D74FE222FCDF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("34da57e7-3c38-4e6d-a60b-463ce0599eeb"),
                LocationId = Guid.Parse("EA9769E1-56E8-48E2-BE77-10A63172A04B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("34e079b3-6900-4e0b-a217-c5275e3030e9"),
                LocationId = Guid.Parse("63B9312E-CEB1-4443-9F60-4AF7BA7F70A5"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("351e62c5-765e-480b-b5ef-0e7014148ae8"),
                LocationId = Guid.Parse("3AC946AD-B42A-48FA-A2CC-1CBA951D5A01"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3533b7b3-33fa-4319-a8a8-39737f7fb009"),
                LocationId = Guid.Parse("E2B903F0-015A-40AF-B56C-9FD400DDBD72"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3575a567-bc5b-44f9-9f8c-723c701a2e72"),
                LocationId = Guid.Parse("538E2399-2AD7-4BE6-B577-81EC30DB4B2F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("35998d82-9d60-4164-a6db-177f2d8407db"),
                LocationId = Guid.Parse("4A61D3D1-8F1A-475B-84E9-5FE22F13978D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("35f1a4da-8e51-4613-b722-d7cfd16c707c"),
                LocationId = Guid.Parse("1F995D36-E7CD-4813-974D-0A7CF8788970"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3617ad18-44a4-432d-9b88-cd6064ddb7dd"),
                LocationId = Guid.Parse("D1302E33-0FAA-40E5-9B44-A27E246B6AC8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3634d492-d0a7-4c64-b28c-3f34764a9aa6"),
                LocationId = Guid.Parse("308D895D-45CC-487B-948F-8DBC88F3641D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3650aae0-fa74-4632-a30d-f3c43cb350ab"),
                LocationId = Guid.Parse("94AD1168-126B-4866-967B-366E2790BEA2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("365cf255-6ea9-492f-82db-a587b98d8de0"),
                LocationId = Guid.Parse("C96CC2BD-6A99-432B-9ABE-834FD254EFFD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("36746269-b765-4311-a00f-f3453a73596a"),
                LocationId = Guid.Parse("D7095F15-AC80-4957-92F1-DC5D3B51634E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("36964eab-d34e-4483-9ed7-48dc00dac7de"),
                LocationId = Guid.Parse("66E368E4-4446-42EA-9076-42A448EE36A0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("36aca0cb-d90f-4399-a5f4-e2f7f7f19ad0"),
                LocationId = Guid.Parse("D11F43A5-51B1-4505-92F2-C36491C9BF92"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("36d36051-839b-4d26-9b98-b222e3831444"),
                LocationId = Guid.Parse("3EE00D12-A451-4636-AAC9-08D4DD60CA49"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("36d85e05-3c30-4780-a4ce-0fc5ba485e94"),
                LocationId = Guid.Parse("3C555109-F8EE-41D1-BD97-C74AF8CE3C35"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("36f7753b-8bd3-4c60-a260-bba2ce9fde3c"),
                LocationId = Guid.Parse("34FB6E12-EF54-4DC0-A1C6-9A08E3CBA375"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("37187e6e-7413-4727-9083-dcab7aa5ec2b"),
                LocationId = Guid.Parse("24D82ED3-A5AE-42E1-B4DE-20DED4E60D88"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("375843c5-7828-4377-8381-5650820bd79f"),
                LocationId = Guid.Parse("A9A62AF4-10D0-4750-A60D-29B445C8A147"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("37981d64-a233-46b5-b416-b906d3a9a3d0"),
                LocationId = Guid.Parse("37F055CC-74EF-4AA6-B45B-68168DBB4FFD"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3801b271-a126-4afc-b21e-39b2c1a36df8"),
                LocationId = Guid.Parse("DEF10E5A-802C-43E7-ACE8-2AB1377D87A4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("380abeac-24f5-4d87-a2e8-51be4246095d"),
                LocationId = Guid.Parse("A49C401A-C36D-4818-8270-899E33CF331E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("383aefd1-11ac-41a0-97ff-a024a47c051d"),
                LocationId = Guid.Parse("0564C707-A89C-47BB-9986-C8F7730EFB56"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("38e02121-22ba-485e-8599-669c58e691ae"),
                LocationId = Guid.Parse("C39C13B0-952E-47A7-AC34-3671088C85E8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("38fc3244-72a1-4c13-9241-a19d7fb7956f"),
                LocationId = Guid.Parse("40C5BFC2-8B17-42A5-94A5-7950EA7B0541"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("391835fb-31a8-4a5b-9c0c-d6b7a88f9ee9"),
                LocationId = Guid.Parse("7B95C2D7-E2C4-447A-9667-D2A50802B385"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3938aa77-6f15-4d86-8502-fde5cb0e54d6"),
                LocationId = Guid.Parse("529BD98E-6758-4901-99C5-3C8710636221"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("39549489-b2da-40b1-a113-b0f937b99a6d"),
                LocationId = Guid.Parse("E87A9F3C-660E-4D0A-A41B-4CF92415D6F8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("396d4495-b90c-438b-8a95-00c526ee251b"),
                LocationId = Guid.Parse("2261E48B-97DA-44AC-A7A5-CA1BDAD42E60"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3974fbd3-7dd8-4295-b9a8-46d47c11a7eb"),
                LocationId = Guid.Parse("085ED696-23CE-4DDD-90FA-75838C06DB10"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3a36dc3e-c008-4b86-8090-c98c8ef3a508"),
                LocationId = Guid.Parse("5A76F4B9-3896-4069-BD36-A0B224B3DED2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3a5605a2-c722-46b0-86a9-2dcfd0912d74"),
                LocationId = Guid.Parse("57B9DE7F-6173-4EC1-87B3-540A3FB7FDA9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3a74cf86-47c1-4ed6-9213-36f46a9b49c4"),
                LocationId = Guid.Parse("B7D19175-DE32-421C-BF70-4749BC560886"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3a9347f0-00f2-4ffc-bef4-8df8d3d40d62"),
                LocationId = Guid.Parse("B4E1CED0-C7A2-4566-A8C4-739F8A94F98C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3a939d1b-13a0-4f50-b2ff-7e07fd3f4a0b"),
                LocationId = Guid.Parse("933825BC-9178-423C-91D1-4118BD400B6E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3ab9700b-782d-4882-a579-19ebffa6a1c1"),
                LocationId = Guid.Parse("3EDB4AEC-268D-49D2-B697-E15FB5D3CB46"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3b0a571e-9cba-433f-9f32-e7a78239d702"),
                LocationId = Guid.Parse("50AD7707-117E-4504-9570-AA879C9B2F34"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3b8e7a01-e6dd-4511-b78e-743b8e881683"),
                LocationId = Guid.Parse("6CBFFB60-9CA7-4D32-8C24-E49F14AF0281"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3bc92747-3c0a-4168-b38d-4895bcbf0b7b"),
                LocationId = Guid.Parse("DDAB77D2-F5B6-4496-86B7-D244B5DC3939"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3bdf67d0-39d7-4e9c-a914-83427ede5868"),
                LocationId = Guid.Parse("1931AF6E-CC0E-4D66-AF19-8953E9742A66"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3be687f1-a465-455a-99f3-b594b76c91ac"),
                LocationId = Guid.Parse("AAE67FFB-E930-42E3-A9CE-626883C58183"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3bf729c0-9744-47d4-a2a2-2923e7ddbd77"),
                LocationId = Guid.Parse("029379BD-7EAB-4FFB-B2E4-1DAEE26B98F6"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3c5b2ccf-e9fe-4573-937c-2aad9932e2f5"),
                LocationId = Guid.Parse("661C6B76-A58B-4272-A08B-22306ED378F3"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3c6f7b83-92d0-4f7d-b141-fd05608e8a4c"),
                LocationId = Guid.Parse("52D4F420-722D-4377-AF01-D23F0497FDF7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3c75c036-9678-4260-a772-a70c0a77f37d"),
                LocationId = Guid.Parse("6C4EB2F8-86CD-4ED6-AD91-4E286B6FE9EE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3c8f1b52-346e-45af-8d5f-2de6bc82b490"),
                LocationId = Guid.Parse("A68A2CAD-5B4B-4C6A-A906-62743C176C41"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3cc0f201-ab0f-440f-bdf1-2c5dce4b8aff"),
                LocationId = Guid.Parse("9BB9CC28-9DCF-44C0-9CB8-58D8F717BA5D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3d327eff-03b2-4ffc-b4d1-32cdf8e3bd9f"),
                LocationId = Guid.Parse("805A2639-EF7C-4159-B6AE-F9ABC4F0284A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3d5885ad-3b57-4d52-8484-5ff7a859d5a3"),
                LocationId = Guid.Parse("5C8B2BCC-BFE7-45FB-A7FC-4F90248CD208"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3d758c77-4d5e-486c-a3b2-486edfd7239a"),
                LocationId = Guid.Parse("9055D2C5-A6FD-4DDE-9E6A-6B4077F19B88"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3ddc5c1c-aa27-41ee-a89d-8be317004fce"),
                LocationId = Guid.Parse("5378522C-6E81-4360-AE17-C72FA95611B0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3e28bdc0-4338-4143-b848-c23452453ee1"),
                LocationId = Guid.Parse("7E42E88E-D4CE-4258-9921-3912A465D78E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3e343b9f-55f2-418f-899a-941f1e9b9108"),
                LocationId = Guid.Parse("C2D7698B-E5F0-4E60-9CE0-D3AED4703367"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3e3f9241-cc70-4125-9a34-b3ad5bf1da32"),
                LocationId = Guid.Parse("EA3A8A7F-5AAD-4FA9-8E8E-36A138D48234"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3e4dad1f-1a5c-4629-a8c3-29e495033bc7"),
                LocationId = Guid.Parse("28D0682C-24E6-4CC6-BFF0-68D743D90577"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3e6da67a-446a-4bd3-8890-bb0ddb1dd03e"),
                LocationId = Guid.Parse("F12D784C-5C1D-4BC9-A0E5-513C6A0C7CF7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3f02dff8-0d75-4b92-a214-9d3e73ae3880"),
                LocationId = Guid.Parse("67461BD6-BF93-4AFF-A33B-26F67AC1397A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("3f0ab412-b228-4ff4-a63d-ae7c4e4b97df"),
                LocationId = Guid.Parse("8903E7CE-9604-4BC4-8C3E-17FDCBD51328"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("40552143-a8d5-43ba-836d-d235a3eaf617"),
                LocationId = Guid.Parse("FEBBC9F5-D98F-4E05-8045-7E07BBBC29F4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4078b7be-4f8a-46e8-a5f4-f12fce581139"),
                LocationId = Guid.Parse("27DCFE30-7E43-419C-86DF-B228AAAB8D4E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("40ddd561-5f90-423a-b989-93c93de5ddd0"),
                LocationId = Guid.Parse("EDEAEB06-9BC7-47F5-A25F-54E43A0EB697"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4112b791-ef6d-4f0f-8e05-2a7623518ea2"),
                LocationId = Guid.Parse("08F12C54-4BAD-4367-8137-5695865313AB"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4149b9d5-cf36-4f37-801e-6351120dde2d"),
                LocationId = Guid.Parse("333A5A72-DD9B-40B9-A584-9880AB5FF3C3"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4161a465-7719-4343-9b7d-66ba2e04b273"),
                LocationId = Guid.Parse("61E44A08-1DC7-4841-B51B-0A9CDC7792AF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("41896a8c-4924-4fd8-9003-5b66a56a8afd"),
                LocationId = Guid.Parse("1095D6AD-B942-4299-A19F-5E456E46FF37"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("41fcb9d3-a6b6-4637-8eb1-16587c323ef3"),
                LocationId = Guid.Parse("DC93B4C6-983A-498D-BBC5-3BEBDADD0FED"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4216c291-0242-4085-ae68-82c1f94d4683"),
                LocationId = Guid.Parse("9E08B94E-30A5-4E74-8B4F-54EC70E3B7D4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("422c0741-8ba7-4dfa-afbd-216c348fb999"),
                LocationId = Guid.Parse("E9BE0BCA-B22B-41B9-869D-728C1679E1AF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("42405024-f483-4db7-8eac-7b1a465c1230"),
                LocationId = Guid.Parse("596E8780-D572-475A-8FBF-BFE76AFC293D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("42ae46cf-0fbe-44c1-a818-0a900f60734c"),
                LocationId = Guid.Parse("51194498-8A1A-4850-870B-4B48A4973AB6"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("436d14d5-5af1-4302-9ed5-db54a28e3e18"),
                LocationId = Guid.Parse("33B2FCE5-1F47-4C84-84B7-19D15628C410"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("43f7a326-4222-4a71-a4ad-3b75a44a6c22"),
                LocationId = Guid.Parse("FB8BBFFA-4A2B-49C9-B84A-F5AEFEB07EDC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("44040432-f6cf-49bf-83ac-75e3c07c3f65"),
                LocationId = Guid.Parse("9782C259-4B29-444E-9190-FAE035B08ACE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("445d648b-8e87-4587-a172-fc3e276f9a74"),
                LocationId = Guid.Parse("4316C38D-FE4B-4203-8CD1-59815FE66A29"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("44a22a85-c8b8-4ede-89d3-d9b86cf81dfd"),
                LocationId = Guid.Parse("5B2DC006-940E-4C09-8309-51F020968A89"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("450d471e-41ce-4cf4-9ab6-87ff7f015866"),
                LocationId = Guid.Parse("AB88E1E7-B259-487B-82C4-5F7A81224170"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("45163f6c-11fd-4acd-8e0e-24562c0e854d"),
                LocationId = Guid.Parse("2F24C9A4-95E3-4220-A12D-ED30CC0332BB"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4552b212-776a-47a4-9eab-44f018a39c81"),
                LocationId = Guid.Parse("218C693A-9F45-4D62-BED7-9D124AE3FEAB"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("455e8c09-0d70-4ccc-964c-eaff234f1ce5"),
                LocationId = Guid.Parse("7CFC276E-590D-4AE2-BC3C-1F6EF5DEE447"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("45b63eff-e510-4198-8709-c69419ebd404"),
                LocationId = Guid.Parse("AC4D20E8-B910-42ED-91A7-1179094AE7FA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("45ee0981-b5ea-4587-ad87-aefaf90cf6b7"),
                LocationId = Guid.Parse("96BBB7CB-6C4F-45C1-B1FF-9D192E6DDE39"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("45f86584-a502-4fa2-bf2f-3da5958f6185"),
                LocationId = Guid.Parse("179C5A49-4270-4D1E-A8F3-9D7AB05C8AD7"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4633e2e0-21bf-459c-88df-600fee95b277"),
                LocationId = Guid.Parse("E8FE0A03-1D29-4A16-92C5-CC87526162EF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("46af9161-d7a4-4cee-970c-b0844f4db0a9"),
                LocationId = Guid.Parse("B9B76C44-D266-48F0-8BC7-DEF8404E6806"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("46d25c28-145c-4ce7-81d6-03f1a34344bd"),
                LocationId = Guid.Parse("BC309166-1803-4A09-B813-F79F8E37ABCD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("46e3c829-6855-4c44-b652-76cf6723eddf"),
                LocationId = Guid.Parse("60028149-1BD9-4118-8B4D-7FE42FCCF79D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("46e6d561-2098-4b87-b7b7-83acdcd06d19"),
                LocationId = Guid.Parse("B9A21AC6-86FF-4B10-9FDA-0D5F84D401EF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4738b110-189b-47a5-831a-feb120f9651d"),
                LocationId = Guid.Parse("A2F02DB1-74AE-4D80-B923-24446A6A015C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4779b108-b93c-45ea-b6f2-a6a61ee45a51"),
                LocationId = Guid.Parse("25F74914-E324-4A9B-B454-6D512E0CB978"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("47baeddf-819c-47ab-8ddf-9c6a8cced557"),
                LocationId = Guid.Parse("E83B1E0A-1AC3-4588-982A-EACF5DB21727"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("48e8d464-eb14-4a40-b914-9d5e6fca7064"),
                LocationId = Guid.Parse("B91E2CC4-46FA-4C2F-A004-BC97E6421D84"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("49186661-e759-47b5-8b40-cdab34ab0f9d"),
                LocationId = Guid.Parse("8BEB918F-04BA-4BA0-93B9-F87BA4D9206E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4964bd4a-355b-47a5-92e8-61d682666597"),
                LocationId = Guid.Parse("2E178E58-43AA-4631-ACCD-42088A0320FD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("498cc71c-b7c1-4f42-bcf9-f7ad589925f0"),
                LocationId = Guid.Parse("180DF9D6-C0B0-4B3E-AD02-E3C4E4792097"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("49bd4dac-6626-4c42-90e1-112da47524e7"),
                LocationId = Guid.Parse("1386C7A7-98EE-460E-88BA-7E3A19CD167E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("49df9d43-d448-4b70-85fb-eacad88cd60a"),
                LocationId = Guid.Parse("1E77FD02-25E6-41B0-B38F-F92D7BDEB2D8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("49fc3a77-7667-4e47-b850-571bd9842a9b"),
                LocationId = Guid.Parse("85336727-F4A1-497B-BE9E-E3B53D2A82DF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4a279029-0fa3-448b-97e6-d3de96e250c2"),
                LocationId = Guid.Parse("53428BEF-3F4B-4540-B509-9D4A340BBF71"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4a938654-6c02-4c9a-97db-cc9c6aecf4e5"),
                LocationId = Guid.Parse("7008609A-4212-46CD-859F-098B8A338246"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4add6db1-839a-45b4-b435-9bfedec43092"),
                LocationId = Guid.Parse("967CEE9A-20E3-40A2-8763-2E3A29501DEF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4b1a78f9-f1bb-415d-a767-5771d5ed5ff3"),
                LocationId = Guid.Parse("03C097A6-F658-4836-9353-4C84D845E827"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4b27a6c6-c162-4461-91c3-00d3e2b9e4ed"),
                LocationId = Guid.Parse("614459A6-4602-4E8E-932F-98C2A9403AD1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4b4a32fb-706f-4e23-af1e-8880097cad5f"),
                LocationId = Guid.Parse("2E3F0C6C-959C-4E15-B910-CDD0AD22CA1B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4b530072-1b85-461d-b85f-b21eec98e687"),
                LocationId = Guid.Parse("90354D6B-092F-401D-AF69-8C601BB1C49E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4b564ba9-5d33-4c32-a867-00fce139b6c9"),
                LocationId = Guid.Parse("2A8C91B9-2A44-4A60-BC68-019F3039348A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4b77ec44-15ff-4a4e-ad07-8c538097801a"),
                LocationId = Guid.Parse("4BCA6AEA-CD6D-4D04-ABDC-0445BC92554E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4b8d9295-56b5-41b8-aeb2-da981f090c6c"),
                LocationId = Guid.Parse("1D0FCB24-255A-431F-AE80-CA8C33BE5F1F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4beb7268-11c6-4296-9e9f-1ef0eb19ced8"),
                LocationId = Guid.Parse("50F6CB89-3A77-4D1C-A7E2-78C475A5B58E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4c519e52-a412-4c6d-b59a-b6eb5359c633"),
                LocationId = Guid.Parse("D515492D-72C2-46B9-8060-B61C4339FD6A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4cee646f-45ee-4ceb-894a-58e221d7e442"),
                LocationId = Guid.Parse("92142BBC-FA32-446F-A62E-0A6087D3129D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4d085e4a-ecf5-4418-b273-4ca462246a95"),
                LocationId = Guid.Parse("064DF2BE-FE05-4259-90F2-EB95378BD53E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4d1b0ad8-1fbd-4d1a-a6c9-9c10da1170f3"),
                LocationId = Guid.Parse("163687B1-6EFE-49AC-BF30-41619B626B67"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4d89114b-27b7-4d91-8cad-c3bdf5d20687"),
                LocationId = Guid.Parse("1DD6C54F-86A4-437D-A354-1347D2B6FDF3"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4d8b2b36-537b-41a8-98c2-00b9ec6e04ff"),
                LocationId = Guid.Parse("E88B418F-3191-4E5E-A19E-D48611CE04CC"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4da2abd2-4107-46ef-bbec-506111cf5351"),
                LocationId = Guid.Parse("B6699048-100C-48BD-B34C-F4BDFF31A156"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4dc1956a-8ed9-4ce8-9964-1561aebd057f"),
                LocationId = Guid.Parse("0F650255-8AF5-4492-AC90-415CE6EF3453"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4ddf09c4-f55c-482c-85be-8234f5f85730"),
                LocationId = Guid.Parse("FEBD0A7D-C048-4A92-8039-347CCE2828B0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4e02e0b7-4d9d-42a6-936a-4787aa2b907b"),
                LocationId = Guid.Parse("A518B657-DDFF-4588-A8D5-C86D931A6E86"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4e0d957d-b1d6-4e4d-86ae-072b33f28a8f"),
                LocationId = Guid.Parse("DBD6804E-37A0-4935-8617-F7E45A0AD0C8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4e127e7b-20a0-4977-b654-6356398c5932"),
                LocationId = Guid.Parse("502CC069-FB1F-4AA7-ADAF-BE2A71888215"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4e8d1748-6ffd-4f50-b3a5-84cd396077cc"),
                LocationId = Guid.Parse("5053318E-6D3C-4D2B-9B13-009A42700B96"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4ec1f367-81e3-45e8-b2c0-075cc15d4de6"),
                LocationId = Guid.Parse("4FC4FC25-0073-4B25-AB26-4D2214CD967D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4f0ced61-3ef6-4721-bde1-4db051d9487c"),
                LocationId = Guid.Parse("4AEB6EF0-C53A-4AAC-AF44-98F896BA2924"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4f1ed326-7234-4f1f-af39-40845b5087bb"),
                LocationId = Guid.Parse("14A17C74-EA45-43D9-AF82-E2FED309D072"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4f21ff14-8529-4632-809f-c027b070d087"),
                LocationId = Guid.Parse("C355684A-1B93-4A71-BF2E-D4A5C383ED63"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4f8c7ad3-c527-4d4e-a0a1-aa576ffcfd31"),
                LocationId = Guid.Parse("FCCF700C-6F1E-404C-AC6D-2C97E19C1893"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("4fd3576a-bb26-4ad8-93e6-d064e3ccb8a7"),
                LocationId = Guid.Parse("B661943E-4D13-45B9-AE23-64A2BED3DCF2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("502bd191-4759-4131-a55e-353441bdac88"),
                LocationId = Guid.Parse("8B7E2C49-6C4B-4C2C-B786-D480A4ED3BD2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("50b9d7e3-63ad-4cfa-9974-2485e71914e7"),
                LocationId = Guid.Parse("1C266AA5-9FBD-4E60-A5D0-CA4A942769F5"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("50d6e2c2-a843-4481-87c9-1ef0fccb0817"),
                LocationId = Guid.Parse("5D73712E-AC35-47CD-B70C-3BC7B5DE4A8D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5170c86e-1f84-41a8-ae9a-c9c52df57427"),
                LocationId = Guid.Parse("7EFBE599-DB08-4E7C-9178-BB45FD3774E6"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("51a40591-f54d-44d4-b3d3-f3bc92f0a1d3"),
                LocationId = Guid.Parse("E6B22EFB-6C7B-4096-86FE-68FE70BD8C9F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("521b2296-ef04-40e9-86be-9bf93664c714"),
                LocationId = Guid.Parse("56ACD4F4-B248-441D-92BF-794F01EAE077"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("529602e6-118e-46cf-9131-1425514a341c"),
                LocationId = Guid.Parse("15D02309-65AD-48BC-BCBC-34D32EEC9E14"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5330f36c-6403-4386-a898-2cf847ff2312"),
                LocationId = Guid.Parse("C4697D7C-AADC-4D69-B5C6-CDC0E8BDB9E0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("53695416-aa90-4721-a6bc-4dcee21e6402"),
                LocationId = Guid.Parse("1749E9A1-6441-46EB-9686-DBF6F34C8931"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("540cc25c-081d-4076-a638-17ba13cd8841"),
                LocationId = Guid.Parse("29F89297-359D-4EAB-9882-B7BB744EAFA8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5465e9a9-ae03-4164-8268-9112ea782f41"),
                LocationId = Guid.Parse("90D8B493-16B1-4567-96D3-110E68107BA3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("546c8e80-8b07-4066-a493-08f6840d8c0f"),
                LocationId = Guid.Parse("1215F106-DA1B-4EA9-8286-D6086F614DB0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5492f868-074b-4737-a4a1-aac3f9a7da51"),
                LocationId = Guid.Parse("DFCA1992-6F93-498C-8389-F05FDFB4C584"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("54c3091d-6f9f-47f6-92dc-68fb19a6c49d"),
                LocationId = Guid.Parse("B783C6C7-902B-4F52-9366-2782DBB09A32"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("553bd836-bb09-4327-8c55-60c42b1f0611"),
                LocationId = Guid.Parse("B2CBB791-7D21-4DF6-8DF5-923DC4CE8F2B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("55417fb3-33f6-4f78-966c-1146c889f529"),
                LocationId = Guid.Parse("64886229-FF05-4E1A-9D51-2BF8C1A6ECCC"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("555a8321-14d9-46fd-b8fa-d1b582187c3e"),
                LocationId = Guid.Parse("53400AEA-12CB-418C-A278-6DCF31D04E63"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("55cc8aaf-ef4f-4cb1-8cab-6e04789c3387"),
                LocationId = Guid.Parse("53A695CC-2160-4703-91E3-762FE5960607"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("55d3d4a6-c252-4a4f-9e2f-3aa3441e38d5"),
                LocationId = Guid.Parse("7CBC6DD2-1D03-4E37-9870-9586D3878C44"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("56044814-0851-4f38-a495-54eba62a6125"),
                LocationId = Guid.Parse("3C401E9F-75DD-45D5-B756-F9A6CAFD2B0D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("56dffcf2-e457-4067-b0a1-2b3e08b7dd52"),
                LocationId = Guid.Parse("0559D6D7-E065-410B-A576-6E0B0A5607ED"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("571ab307-014f-411e-acf2-78cc450f8640"),
                LocationId = Guid.Parse("21E39A8A-F254-466B-A4D6-8FFE13F36A5C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("575f1705-4dc5-46e8-a511-e0831610844d"),
                LocationId = Guid.Parse("045DB41F-058F-4F23-84E3-5F4666C4FF1F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("57751f99-3529-42a6-afd4-792f8eb19ecd"),
                LocationId = Guid.Parse("D89BCB17-1C67-476A-A769-9DE34EC93F3C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("57a0d0c1-1934-40ce-829d-edf50167b342"),
                LocationId = Guid.Parse("8B938948-E002-4713-9799-65657223D45A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("57fefeb1-a9e5-4a99-a752-d0e01eee87f6"),
                LocationId = Guid.Parse("0BC9D1AD-A1E3-4271-96EC-3810C969EE11"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5818c454-fa32-4c48-af52-4a6c11a0a1ca"),
                LocationId = Guid.Parse("BB2F7D53-6749-488F-A3B5-40DE5F14D004"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("587ec1e2-a169-4454-bbe3-bfc8dde0fc8e"),
                LocationId = Guid.Parse("49333D20-304E-4D2A-BEBC-A42F47B651EA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("58834c53-27bd-45b0-9f0a-98fbf782157a"),
                LocationId = Guid.Parse("FD7AB4AE-4E8A-4A12-BCBD-C89B90A893D2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("58a4a98a-b03a-474c-ba1e-5c0a6355bfe1"),
                LocationId = Guid.Parse("8420F8AB-BDC0-45EA-A780-FBA9374AAD30"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("58aaab7f-2247-4d00-abd0-6a059e887474"),
                LocationId = Guid.Parse("76E69F6B-CAFE-4509-AE43-E6FF2748A3AA"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("58e322fe-5db1-460c-b1c8-cae3d85c8ac2"),
                LocationId = Guid.Parse("9C16B072-6A56-403B-8929-44EF89B0143D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5903638d-e10c-4af2-825c-3fadaa2e7955"),
                LocationId = Guid.Parse("53D534E5-C02D-42A7-96CE-F258A63C7A85"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5947d323-59b1-444b-bf7b-41ec05f728cd"),
                LocationId = Guid.Parse("4C7AD03C-7405-4716-B790-E2BCE28C9211"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("59a140a4-cec5-46fc-8fd8-1bc43d365c09"),
                LocationId = Guid.Parse("6C6AFF65-EDF9-4E0B-B8C5-2FFAFCF4D1EA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("59ae9bc4-6044-4023-9e94-93d5eb38eb7b"),
                LocationId = Guid.Parse("E378F174-BAD4-4A0C-8DE4-FE03D0640647"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5a3671cc-b218-4f50-91ed-9e2434289c1d"),
                LocationId = Guid.Parse("FD6765A5-526E-4D7E-AB92-13273D341C88"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5a861ca8-0dc1-4fc2-8577-807f6fc07cc8"),
                LocationId = Guid.Parse("F1592FE8-CEFB-4CA0-AE05-A20F17F97457"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5abccdc2-eb72-4c06-a91d-858032c75e6d"),
                LocationId = Guid.Parse("165891F0-24D4-45D4-93AA-6B4ABCD02EAF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5b035270-dedd-42ec-8b2f-c7e08081df77"),
                LocationId = Guid.Parse("A711984F-A02C-4DFA-A558-425E7E7C7440"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5b2b5791-55b1-4e71-aecb-fb7a389d4c73"),
                LocationId = Guid.Parse("B190DBA5-5A59-4FE4-86E6-2F36B3B3B79F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5bb83cfd-342e-4598-b0f9-5d0b6fd1c2ef"),
                LocationId = Guid.Parse("E175E037-1BD1-4B37-AFAB-60D98F0382C1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5be1ae96-d393-482b-be97-10103e0e3f2a"),
                LocationId = Guid.Parse("80C2219A-D192-482A-A698-E730A3C91B52"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5bffc89b-88b8-457d-983f-f5f7864eecf5"),
                LocationId = Guid.Parse("F9F31F13-49B5-437D-97B4-8AEA709A9E12"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5c6208f8-9693-4eb4-91e7-8049c8114ca5"),
                LocationId = Guid.Parse("6914F079-1170-45A2-80B7-3E79A6208AF0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5c7bb98e-6909-4046-a042-1354b1064678"),
                LocationId = Guid.Parse("F792599E-D8E5-4AE9-AFC4-431C62B6B5DB"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5c886749-4e82-49f7-9208-20eb9fe88eb3"),
                LocationId = Guid.Parse("98531D93-0EAF-4070-8C8D-5296AB84F845"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5cbb839e-4ca7-4656-b31b-7ee711d630a7"),
                LocationId = Guid.Parse("8BCE4C38-B993-4064-8B8C-B925F6F3BFAC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5cc85d46-5f37-4305-b2e6-e931763fb186"),
                LocationId = Guid.Parse("E9DE6C79-B88F-4180-813E-BEEDBFB179D5"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5d28f11f-271a-423e-b11a-dce5c75e24ca"),
                LocationId = Guid.Parse("969004C5-8A29-43A7-91F8-3F46C55413A3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5d79ee2a-6466-48f6-a725-a32aab3eb5de"),
                LocationId = Guid.Parse("A4618B23-B8BD-4F52-958F-CDD3FD79BE1C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5d944af3-34d7-4d2d-b335-ad936a100688"),
                LocationId = Guid.Parse("CE9B62EE-1A09-4DBB-A1A0-F0932FB67006"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5e14f60c-b800-456d-afdd-20df741794af"),
                LocationId = Guid.Parse("27D5D1E8-581B-4BFE-BDCD-62AE32EAA500"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5e54aa32-d939-4a7d-9deb-a5463157c634"),
                LocationId = Guid.Parse("E2AEED7D-15AA-4244-A530-9483C62CD69D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5ea91e80-81f3-4ea0-987b-d0e465fbf086"),
                LocationId = Guid.Parse("F2553C74-B325-4DBE-A288-02B48519D039"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5f0fa646-9963-4e64-84ef-d97b4db93bd6"),
                LocationId = Guid.Parse("5D72BE2A-32CA-4220-8010-CC664DD02350"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5f69ab4e-56b8-4738-a190-6fa2325bcde5"),
                LocationId = Guid.Parse("24A848F6-B384-4D1F-A462-AB4699E3B0E9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5f6cca66-f59a-464f-94a7-e24a6d552640"),
                LocationId = Guid.Parse("89DB6CCA-7A1B-4EC0-B961-DCA5CD490407"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5fb48841-eeb9-43a0-bbb7-f9cbd2958871"),
                LocationId = Guid.Parse("321CB066-D735-4893-B47B-5E55A1B6BD52"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("5fe8eb2f-2bbb-47f0-a945-e29052eab85b"),
                LocationId = Guid.Parse("914E1211-FCEA-44E9-882F-DFDF1801BF66"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6064eb59-c50f-4dd1-8664-3dfb3ea50c85"),
                LocationId = Guid.Parse("068ED621-1202-490C-BB4A-EBF3C2DA3BEE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("60a30641-8765-43a0-b132-c5dbb65ace19"),
                LocationId = Guid.Parse("6A3B7866-338C-4BDD-A930-E69C13384E36"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("60ac9e27-44cc-4678-a0bc-18850bd0eca3"),
                LocationId = Guid.Parse("0817CC45-4BA6-4AB9-B6EB-E9E33A58F100"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6123ac69-fcbb-4b3c-875a-63a5db129b46"),
                LocationId = Guid.Parse("FE3AB564-4334-418F-9A95-703DC013493D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("619d45a4-a691-49cf-bc62-fc4af9ed7b69"),
                LocationId = Guid.Parse("726B5B2F-8AC1-457D-ADB9-53003E078E30"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("61e5399e-49c6-44f4-b92d-bc736d1fdcaa"),
                LocationId = Guid.Parse("1F89D904-BB7B-43FA-B96E-6391830F32F8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("62705ab5-d819-4dbe-9f3b-b480fea38c99"),
                LocationId = Guid.Parse("299D7E08-57D7-47FA-98E9-EFD0878F8A25"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("636c8d94-f466-48b1-bca1-387e1994dfc0"),
                LocationId = Guid.Parse("898DD080-39F9-4944-86D8-7D74DA0B8E30"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6371ad4f-18b0-491a-80e2-b29f588d87da"),
                LocationId = Guid.Parse("4DCBF2E7-C97D-4551-9C72-73096A726483"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("63d75ac9-b2a8-4a59-ac3e-61e1d58eb099"),
                LocationId = Guid.Parse("2332661F-DB93-4372-8E0A-99757A446730"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("63f11f9d-eb78-477b-8f6e-d468584b0c9f"),
                LocationId = Guid.Parse("09BB9EAE-7A41-4655-8AEE-026089F36BB5"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("645175e6-fff4-44f2-8756-67c293c23d2f"),
                LocationId = Guid.Parse("67CB0669-FA40-4859-9572-293677577F9F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6475110a-c6e6-4048-a183-58f957d364b2"),
                LocationId = Guid.Parse("F560CBCA-D749-420A-80BA-8AAB02628F66"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("647fe520-8d64-4875-8394-6cd82e651810"),
                LocationId = Guid.Parse("99659BE1-D0DC-4E92-BAC1-8186B6A29840"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("647ffe28-45e8-4a51-b9bc-284f47bc1cf8"),
                LocationId = Guid.Parse("14670726-D69E-4D3B-9578-D49A45D8B1C8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("64a590bc-a494-4af3-9f45-942f4a24da6d"),
                LocationId = Guid.Parse("C0B8F30C-F29B-42AC-8629-AFCA77D0820F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("64b78b9e-e0c8-4274-8986-08a8a56455db"),
                LocationId = Guid.Parse("34845879-8C11-4101-BFD5-4CB92081BE64"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6506750a-e515-419f-91c2-fb7cd26c3b50"),
                LocationId = Guid.Parse("F1EE0A65-9441-4333-8F84-763EC74A15BD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("65faf221-cd6c-43b4-87b3-9d2de73cc443"),
                LocationId = Guid.Parse("091245F7-359D-4DFA-ADDA-A6AD7D2B364C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6626a2a1-66aa-4a6a-a089-9c5b664e9c07"),
                LocationId = Guid.Parse("EA80F2EE-4B48-4B62-AD74-021BDEF06A97"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("66561ed1-10cb-469d-967d-5df11f9a0763"),
                LocationId = Guid.Parse("E3D812CE-7D9B-4EF9-B32A-E8D8B3BE32A8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6666ec8c-1cd8-453e-b5c7-d271c00ed208"),
                LocationId = Guid.Parse("0D26FD04-E6D7-48D5-8B04-23CA8F6736E7"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("66912198-959f-4afe-9e1b-a48784e9f59f"),
                LocationId = Guid.Parse("31819F07-8281-40CE-87D6-9F27AE1285A6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6720a972-6d61-47b8-b791-a5f11cf50216"),
                LocationId = Guid.Parse("77C6EEC4-E81E-4858-9AE7-AD21FFDDFDD0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("67250ad5-e7e2-447e-a972-7975cfed8565"),
                LocationId = Guid.Parse("6808CB5D-6061-4375-AB1C-E2D53385B202"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("672f140f-ef25-4065-9f2e-12177842399f"),
                LocationId = Guid.Parse("75186127-4644-4BC5-B9C8-0CBD2E13EDE7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("680c41e1-6451-4422-a571-05a6b11bb192"),
                LocationId = Guid.Parse("65BA67E2-BB04-4D42-8F7F-72E891AD84CD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("689733d6-63a5-437d-b84c-92cfbbc953bd"),
                LocationId = Guid.Parse("D7CED2C5-3C57-4B18-8642-D88D1911DE4E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6910ab31-2b5d-4447-8696-2f0639354121"),
                LocationId = Guid.Parse("FEAFF5D8-3891-4ED1-A75B-483BEDEC7505"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("691e9999-4306-44c7-a69a-a1751e2a36a2"),
                LocationId = Guid.Parse("FF341B33-78E4-4DCA-BAD7-89722B6274CD"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("694c084f-80d9-454c-8371-f548639a288b"),
                LocationId = Guid.Parse("EB4967D0-8479-426C-B8A3-FFA96085A5DA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6951358d-bd83-41d7-a431-52c67b5737b3"),
                LocationId = Guid.Parse("8A1B3040-6893-4048-A132-7BDD80C675EF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6976825a-ed4c-48cb-96b6-c84c72f62937"),
                LocationId = Guid.Parse("02F9F410-04D0-4161-93D4-B15EAF5B6379"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6b0c021c-8044-4183-b90f-d0c6a1df9597"),
                LocationId = Guid.Parse("DA334E5C-E10D-42A2-8BA9-A3D407A39AD0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6b62ca7a-5372-4a86-91c5-e40eab5f085d"),
                LocationId = Guid.Parse("01690442-3312-4AF3-B6B7-485F6246E5E6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6bbd41d1-2839-40ba-91ae-fc6dcbabbeed"),
                LocationId = Guid.Parse("DB7D84DE-8B14-4289-BA00-0FE07E3EAF4B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6bcb7a76-f6f8-4a11-85c5-dd5d0ac63101"),
                LocationId = Guid.Parse("547B3D7C-2E2E-4288-BA3A-D10E4D62E726"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6bd032aa-5449-444e-9f69-e866f84b0294"),
                LocationId = Guid.Parse("28B4D0E3-48E5-47B0-8003-1FC780F1959E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6bfdbcd5-4eeb-469d-ad3e-b22be1cbd8e2"),
                LocationId = Guid.Parse("10A3042C-BBDF-47A5-A456-B75D367AE846"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6c5c74cc-686c-432b-bdcf-d2ef5f281653"),
                LocationId = Guid.Parse("F451F47B-39A0-4434-AA35-EC403F274139"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6ca62bce-4424-4595-b347-337d113c197e"),
                LocationId = Guid.Parse("4484BF82-E40D-4BF9-92F5-8E3A7C3C1663"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6ceb6b83-7215-4662-8359-52accce99fb5"),
                LocationId = Guid.Parse("1C6A4AB9-D4F9-4D34-BA49-E2F4B1DA9945"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6cec21cb-f56f-43d5-bc81-99520dcd77cb"),
                LocationId = Guid.Parse("4AED0EF7-37F7-4689-A4D2-53243C9F07D2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6d67264b-e9c3-4682-8b7d-0e0547272a9f"),
                LocationId = Guid.Parse("09CB7B29-24A5-44D5-8994-0A1170EE0179"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6d75f29a-cf68-45e2-84ed-83e66ec50ea6"),
                LocationId = Guid.Parse("E8472247-D628-4946-B626-513F42891850"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6d781181-7d93-47db-9d6d-50a77c78dc1d"),
                LocationId = Guid.Parse("0E40E16E-3B62-4543-BE47-A6C949F53C4E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6d806847-ac7f-4406-857e-94cc6f747060"),
                LocationId = Guid.Parse("1D3046B4-DDD8-43BF-AF08-6182BF34DCB2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6d9c00fa-cb04-4cf2-aa08-656c3501ea11"),
                LocationId = Guid.Parse("498D2CCB-3A08-4099-B38E-C3564B84E16F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6db4ed67-2919-42f1-b949-936865fcbe24"),
                LocationId = Guid.Parse("6ED0C6B2-531A-4122-8137-83D3CE401426"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6e288e74-97b1-4c19-993b-e807021c8618"),
                LocationId = Guid.Parse("78E6B748-6242-4415-9133-B65DE0F76784"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6e5bd54a-d41d-4ee2-923d-578f514e6ff8"),
                LocationId = Guid.Parse("2857A1B2-6385-4BC0-83D1-38AB382D7073"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6e625330-601e-4979-9a70-411ac0bcbec6"),
                LocationId = Guid.Parse("7D255CB1-6D87-47AA-8260-CC0C74737B6A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6eace97d-29e3-4fef-9612-16ea1a456ca0"),
                LocationId = Guid.Parse("A148D044-2562-452E-8A78-E9ABCEFA8F77"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6ef48c6f-dd1c-48ee-8326-785bd06aa4f6"),
                LocationId = Guid.Parse("57E6329C-08B0-4CAE-A5E1-0AE8FBABD3D0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6efbdfb5-1edc-41d3-ac42-05590a51cc48"),
                LocationId = Guid.Parse("D6BBC568-4056-44C1-B1BE-AAD63DF987E1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("6f19281c-e50c-47d9-a1a4-57984f1dfa2f"),
                LocationId = Guid.Parse("C8806F5A-DF3C-42D7-AF01-B27F76CFF65C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("700034fd-9ff4-495b-95af-f202ee68eb3b"),
                LocationId = Guid.Parse("46B572A6-B083-4C33-9039-EA3941C6CCD4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("710d1b22-3296-45d0-8039-e4470987be50"),
                LocationId = Guid.Parse("69519D77-4997-439D-A5FA-767C5B8EF042"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7115dcc4-3602-402f-aa5d-fafb96d1c5e4"),
                LocationId = Guid.Parse("BF8B854C-76B2-4626-96E6-4EAA2BB425C0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("714193a8-3d2e-487c-b7a0-e0c14045e792"),
                LocationId = Guid.Parse("8158465E-2CB9-4546-A272-9E9E2FB5C33A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("71617b23-5e7f-4a61-9f3f-e93ae31df1e4"),
                LocationId = Guid.Parse("D78056AE-1032-4195-B701-F7FFDDC10A91"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("71b0ae73-5685-45f3-80ec-348d237f845f"),
                LocationId = Guid.Parse("86F22D47-2A2E-4225-BECE-49ED14E5D859"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("71e9b652-272e-48ef-ac66-6318e2fb5b5f"),
                LocationId = Guid.Parse("8395A6ED-93B9-412E-BB17-24817F28478A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("722b7ba7-f03a-4916-a263-cc8b097d7553"),
                LocationId = Guid.Parse("83EAEE5F-FECC-4639-9EB8-C3512A2A6D1E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("72359268-ba17-4ebc-b3aa-592fdd151f6e"),
                LocationId = Guid.Parse("95E67FA9-0142-4B8C-83AB-B7401A3300ED"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("72b63fef-cc8d-42c6-a33e-dd39ad76864d"),
                LocationId = Guid.Parse("647EC1B3-3037-42FF-B7C0-0E4210970578"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("72ccd00f-19b6-449b-a8cb-a4d847e294a0"),
                LocationId = Guid.Parse("541FF304-1887-4386-85F4-AE64979F79A7"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("72ea1c8f-eddd-455f-bf7e-6619234fad23"),
                LocationId = Guid.Parse("5BE7309B-E9A7-4EC0-882C-3BD890642B10"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("731ee7a5-f912-47e9-8658-e8971c73d215"),
                LocationId = Guid.Parse("8E24BD56-B514-455F-875A-9C08B5FB9420"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("735aa07e-8364-4423-98e3-b6e52b49bb87"),
                LocationId = Guid.Parse("4ED73D7F-34E9-4398-ABF0-99203076474D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("73631f52-b067-4067-9abc-49f67fbd421f"),
                LocationId = Guid.Parse("2B064761-C9A5-4427-B5B1-289FAE287D61"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("74d1309b-cb8f-40bd-a533-90b606a38f7c"),
                LocationId = Guid.Parse("53700A31-EA7E-48AE-A7AA-9BA0EC329998"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("74da80e1-ced3-4c94-acd8-faad7e2c9be7"),
                LocationId = Guid.Parse("6F8CCA66-8966-41DD-B29D-FF42E35541B3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("756cd287-f79f-4219-bbd6-3db9474aa014"),
                LocationId = Guid.Parse("C28554DC-D7E0-4633-A413-FF81990AAA86"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("756e688f-c508-4658-b3b6-425997559e75"),
                LocationId = Guid.Parse("10048E66-067E-4205-9104-7ABC758A6FC6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("757a7ca2-e30b-49ff-b5da-18eb3fcf1f9f"),
                LocationId = Guid.Parse("10E9D135-3A44-4BDD-A7A9-7F0488267A5E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("75dd9b22-10b1-474b-beb5-21432c2e38ec"),
                LocationId = Guid.Parse("3662DBBD-8D58-4A3F-ADDF-2227375082D4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("765c6fec-19ea-4cf7-bb69-a8f4df1c97ef"),
                LocationId = Guid.Parse("5EF18BA8-B63F-4E28-9926-50FD508EFF56"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("766bf423-ffdf-48d5-afe5-277541c4b868"),
                LocationId = Guid.Parse("E743905F-9FCA-4596-8D3C-418657D6E979"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("768b667d-89e2-4c23-b411-a5db491d17eb"),
                LocationId = Guid.Parse("0C7550C1-365C-4CA9-80C5-89616A45AF5E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("76d2d6ef-a865-4737-8074-f4021789479c"),
                LocationId = Guid.Parse("C505D7E2-31C4-42B6-867C-A7EF922E3F5C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("76efd6c3-1f0f-4a13-9ac7-1c8e1e6f554d"),
                LocationId = Guid.Parse("922118B8-49C6-4EC8-BE3C-1FA7B7B03B57"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("784a90d3-704b-44ef-9c47-b4ac7c332c38"),
                LocationId = Guid.Parse("B240EFE4-AAF2-4DEC-994C-F97C2D7CFFEF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("78617d34-6975-4e34-abee-f7427b234495"),
                LocationId = Guid.Parse("7DF94896-CD28-4DE5-B713-CA2BE25AB179"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("789770fe-47a2-4bdb-ad5f-b75d62bd952f"),
                LocationId = Guid.Parse("A51E30BF-16D2-4B23-837B-DA0087AEAF50"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("78dbeeef-317f-4d24-a554-1fb2ba4d1e1c"),
                LocationId = Guid.Parse("452E5EFE-ADAE-46A9-972A-94E970BAF290"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("796d639a-334e-46dd-8139-33e00e041b47"),
                LocationId = Guid.Parse("0E585062-8837-4FAD-9DC4-083781326350"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("79a135fd-333c-4eb3-b502-f45d91816250"),
                LocationId = Guid.Parse("4C6EA125-CB8E-49E6-BE1D-A67D2ADF42FD"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("79bc73d9-fcb6-4e71-873c-6ac487751d7e"),
                LocationId = Guid.Parse("871F2A40-59FE-4F9A-8749-78F374F1DD22"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("79f76d9b-f127-4a1e-9274-17317d038a6f"),
                LocationId = Guid.Parse("DCA3AEE0-2A18-42ED-BF73-18377F44C7A7"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7a8a3bbe-40ad-4094-819f-f1e1583c5989"),
                LocationId = Guid.Parse("85B889FD-F5E1-4ABA-8A92-8AD71CD41AF4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7aa90adc-30cc-4f03-926c-af3a187f189f"),
                LocationId = Guid.Parse("759578D9-2EF3-4B41-BDA6-91766B4D74F1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7ae19e53-3a9b-47fd-b9bb-52fae1251b2d"),
                LocationId = Guid.Parse("D6B8F2F1-7E1E-4C53-B4E6-AF192E683559"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7bcae195-e9b5-4cfb-9836-d8271234e159"),
                LocationId = Guid.Parse("CF39F252-D10B-43F2-AFE2-2E43F9080EBD"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7be7f1f8-4490-4506-8115-c41928c5c0c4"),
                LocationId = Guid.Parse("74211777-5409-4D47-A7A7-DC98B2752C99"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7c0c04e5-21d7-470e-abed-fd1d87b7c8ba"),
                LocationId = Guid.Parse("0594F79D-A905-4FB1-9D6A-2F1458815C4F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7c1529a9-236d-4773-9f6e-7a8c03e0b39f"),
                LocationId = Guid.Parse("16E55DE8-AF21-4E29-8752-DC036D12331F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7c2d742e-dc4b-4d68-95f6-dea76c6aecc3"),
                LocationId = Guid.Parse("940F2CE2-4024-4EDB-9DDC-62A00FA0F654"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7c39501c-ba5c-4d6f-81ec-37f40cb783ae"),
                LocationId = Guid.Parse("E35CBE4F-55B7-45FA-8908-03C607DC779C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7c3d8a6a-d0b7-4f42-a5f3-9d10b5d3982d"),
                LocationId = Guid.Parse("8F6E4816-C4FE-4E4B-AA5F-BEC4DAA59B61"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7d3f1616-7d35-4813-98a9-6ca4300854cc"),
                LocationId = Guid.Parse("FD18F0DC-EE3D-48C9-AD3D-786FEAA09AD0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7d4d0f95-11bd-45cc-a918-b9ef1da52ba9"),
                LocationId = Guid.Parse("03946599-1758-46B0-AF46-6AA6D0C5C919"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7d4eb01d-8938-4e5f-9012-a2bc3612bc5d"),
                LocationId = Guid.Parse("2525632D-84E1-4132-B0A3-89EA47493C21"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7d6d9ecc-6be2-48a8-be9b-53a2aa0846e7"),
                LocationId = Guid.Parse("1F4B2FA7-A9F0-4DF0-B899-BF2FBD03CFA1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7d821f70-f2f2-4cbb-8f08-34abc81955c8"),
                LocationId = Guid.Parse("32A25CAA-A275-4AD7-8B1B-F569AE4A3724"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7ded5c89-cabb-464a-9a60-57edab3a6a3d"),
                LocationId = Guid.Parse("D603B2F4-70DC-4C9F-944F-79CA587E1E38"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7e38bf2d-e0d0-46e7-9111-bf77958c5956"),
                LocationId = Guid.Parse("C76712A3-8F1A-4C08-AA62-FF89E4028ECC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7e3e2cfc-7a2e-45a6-8adf-c701ce74ba4a"),
                LocationId = Guid.Parse("21B2CBD3-03BA-4043-A159-993E9B3E7A9D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7e5212b0-c11c-49ee-a33a-3339077f4b6e"),
                LocationId = Guid.Parse("701FAB68-183E-4E0A-A7E8-E3A4507FBA8D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7e6ef6f5-f7f8-405b-8d04-33ae19cacdf8"),
                LocationId = Guid.Parse("698B8807-DC6A-47F3-902C-3CC3363A314E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7e757546-1f6a-4a8c-9bca-9e5a2de2e6b4"),
                LocationId = Guid.Parse("82440856-C826-4D1C-A3D1-AC12C1414D22"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7e8cba1b-2015-4faa-9855-5e02f2424471"),
                LocationId = Guid.Parse("DFD0D59D-C650-4D30-9DCE-D18AFEDDBEFE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7edb9976-0d98-44ef-98a6-66dae6adc64a"),
                LocationId = Guid.Parse("F20C4E65-FCB3-47BB-BBA0-127F036DAACC"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7edfe4bf-3bf7-4a94-a9c4-0a3c27bc7284"),
                LocationId = Guid.Parse("AD678213-3CD3-4660-A6F6-71673A5F73FD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7f0617be-7b61-49c5-a775-93c4a1f612c5"),
                LocationId = Guid.Parse("F0960F87-BCFA-4264-82EC-8F7B00694DBF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("7f0b3d41-0119-434b-8ac1-83bdcf233b39"),
                LocationId = Guid.Parse("8B849040-2901-4790-85B5-5CA19C1CCE07"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("801fc79b-93e7-4b46-9c74-6f1d199aa82c"),
                LocationId = Guid.Parse("C2FD2AF3-20ED-4C34-87D7-5E5AF74103CF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("80aef8a8-022a-4bf4-b313-96eeca5fd8e4"),
                LocationId = Guid.Parse("F4402EC8-5BBA-46C2-9280-5F3CA001DD36"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("80cb42a8-2bc9-4d6f-9dc6-ce1bd65a85ea"),
                LocationId = Guid.Parse("9277B4B2-7C31-436C-98A9-D9A1930FBCCE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("80e62251-b3af-4ddd-86c8-2c66c115d197"),
                LocationId = Guid.Parse("BB2D6930-A524-4BD6-B893-87AC7BFDC6E2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("811a7de7-9bd7-40fa-8355-c41d0b9e28a2"),
                LocationId = Guid.Parse("CBF8C644-6857-41D2-9590-6483F87E581D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8195f8fb-95a5-4496-b6bf-5af78f71a365"),
                LocationId = Guid.Parse("0DEA6F6E-F1D3-4D37-B675-803371C3E260"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("81c91706-ad6a-4d4e-8d8f-fecda7103759"),
                LocationId = Guid.Parse("3E2094B5-D31B-4BAF-9E0D-0B91C54F7000"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("820a45ea-4360-4946-a6bf-1ec05ac02ce4"),
                LocationId = Guid.Parse("89319188-673D-488F-B8FF-7D28A31F72F8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8246c5d3-40a0-4171-9ce2-57fa240c63b1"),
                LocationId = Guid.Parse("F26A63D4-49D6-4133-81EB-975FBD343576"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("82e82a38-6c6a-4f20-becd-8be8ebb48bd4"),
                LocationId = Guid.Parse("1F143097-B1BB-4018-8C0E-95165AB3320C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8352f4e3-2b03-4834-bdb2-af8108e49c1a"),
                LocationId = Guid.Parse("86867DC0-4575-44EE-BDE0-2F9DE986BF4E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("83782ce2-80da-4d67-92af-dc62ed9c51f5"),
                LocationId = Guid.Parse("76430393-B4E7-4188-8FED-67871854FFAA"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("83987d10-732e-4f77-a922-3dd04a13435f"),
                LocationId = Guid.Parse("1968F81D-9454-4607-B26C-8938D2CB5BBE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("83c27c1a-18b1-4906-9dca-3e197cad39c8"),
                LocationId = Guid.Parse("95467DC2-DD7F-4D85-85D1-F178D346A637"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("83e359fb-8659-4380-adb1-240f1ca9f5e4"),
                LocationId = Guid.Parse("023AC259-B641-4A72-9E96-F5BB2D165D27"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8400d375-f2fd-437a-9e6c-7440bd81f265"),
                LocationId = Guid.Parse("9F371A09-5DA4-40A7-AA37-93FBF230A167"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("84640fa9-5b0e-40f8-a57d-c1567ffc5a17"),
                LocationId = Guid.Parse("77BE4A0B-7554-49AB-8636-43CAFDFF6396"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("84af181e-bd35-4474-b36a-56f367a02353"),
                LocationId = Guid.Parse("968B938A-04C8-4791-A6B0-DC2AAB910477"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("85408079-f6fa-4e7b-b429-0eb2fb6ba35a"),
                LocationId = Guid.Parse("1F833821-F59C-4B29-B8D9-194547611709"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("857103bf-a893-48d2-be22-01e6866b42ad"),
                LocationId = Guid.Parse("B8C28602-86B4-4976-9B1E-4BF0DA4C6A62"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("858f3d75-36d4-4344-b2da-0cc295dd07df"),
                LocationId = Guid.Parse("671709C0-EA23-4FA5-971A-96C3738FACD6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("85bd54f7-ee45-4b8f-8826-046caab8a86f"),
                LocationId = Guid.Parse("F9065451-6C74-4B3A-BD43-A723FE444D6E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("861ec133-7183-4648-9648-76c3f6346e4b"),
                LocationId = Guid.Parse("594718C4-07F8-4130-946A-AE3E0F9ACD08"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("867a19f5-cf2f-408e-a154-a945222bff8c"),
                LocationId = Guid.Parse("B6423B06-1A1E-4762-8378-0D82B2864D54"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("870d12a2-5d6f-48d8-b97c-389637ea892c"),
                LocationId = Guid.Parse("A3D2EC8B-B260-48B5-AE3D-5CE6D635ECA3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("87928dc3-ccc2-4080-a340-17ca0543a116"),
                LocationId = Guid.Parse("15D2DB31-3ED5-4F2B-BEAB-667B6F53B256"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8831fe94-4aef-46c9-80ca-d87f68618159"),
                LocationId = Guid.Parse("8C12BEAF-051C-4E1E-B60A-0B90E2A9936E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8855671d-c801-4cd7-9166-a0f45598adad"),
                LocationId = Guid.Parse("8B76BE47-8A87-4C47-8C92-C4AF88377F42"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("88a45d0f-6032-43f6-b1de-8644962a25bb"),
                LocationId = Guid.Parse("C2CAF7FC-28B6-4CE3-A98F-D400370A2133"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("88c93d29-0fa3-408e-8edc-9b1b2f552766"),
                LocationId = Guid.Parse("5FA06894-1A20-47F4-BE26-DBC829F3A1FA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("88cb082e-4143-457c-ac5d-7715e1901369"),
                LocationId = Guid.Parse("21FE749C-A2B5-42DD-A7D3-64C498889301"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8910c919-beeb-4643-aeca-3708c74ab583"),
                LocationId = Guid.Parse("F468A76A-A400-4179-986D-CBF1F3F6EDE6"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8951d89e-b6a8-409f-b902-24691eb8d109"),
                LocationId = Guid.Parse("B79DD67A-45A7-4CAF-846A-6936834F2021"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8a9794bd-05c7-4eda-a2ac-1c9b1c562ab6"),
                LocationId = Guid.Parse("12EA1B8A-380E-4018-8B19-D074584325C6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8ab1b8e4-9be3-4e6f-8de3-8e8fb39aeccb"),
                LocationId = Guid.Parse("F6073E5C-3A13-44AD-A522-E8BA6DED8D11"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8ad94323-5b04-48be-b69a-f5c1493b7ec4"),
                LocationId = Guid.Parse("29BEBD68-0394-44B2-A20D-8811C4C1F1E0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8aed2d26-19a3-4ff6-8e42-6945249584ce"),
                LocationId = Guid.Parse("B6295887-87B1-4B86-855B-95DD4A7189F2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8af2e0f1-729b-48e6-807e-5d914c63638e"),
                LocationId = Guid.Parse("4F3878B9-467B-4855-86F8-23E8BDDBFEA1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8b1ada00-4d43-44b9-8288-1cf7cc4fc533"),
                LocationId = Guid.Parse("33A86E41-C2F3-4655-8CCD-FA2C61060143"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8b31f657-f53e-4d36-9ce1-fb1d2db10969"),
                LocationId = Guid.Parse("851207AA-881C-4152-95E9-5E83F027D243"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8b73df8b-9a3f-4163-93da-a52b57bef951"),
                LocationId = Guid.Parse("6F8A3520-FEFD-44EE-BA55-00755BDBC80A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8c5ce08b-138b-47d9-8e26-eb3bbccc6e98"),
                LocationId = Guid.Parse("95CACAB0-99F8-42E6-AA8F-F49EEFB42776"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8cc1ba8a-0791-41a3-849d-47427586444b"),
                LocationId = Guid.Parse("2B123CAE-D980-4620-986A-D6C3AFE28B98"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8ccf3754-ae31-414e-8bdc-e1098e9af0ce"),
                LocationId = Guid.Parse("26C18BB0-0D66-4D0E-9DF0-227628A30392"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8cd49e29-9eae-4c97-b440-d0845c3864c6"),
                LocationId = Guid.Parse("08DB910A-6205-446C-89A7-72B2615E0248"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8d775412-1924-4414-a3cd-00a7ec07d0da"),
                LocationId = Guid.Parse("983657AF-8ED8-440C-84D9-C3FD236243F1"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8d929b95-4b6b-436a-8f72-465896679aac"),
                LocationId = Guid.Parse("7A378FB6-6362-47F8-AEEA-7809B258FC3B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8d9b0e5c-2ec7-490e-af1d-f296b765c1e9"),
                LocationId = Guid.Parse("734FFEBE-7D34-4815-81D5-0C0E1B160DE4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8da7a197-6a54-4973-b5b6-b760356b7857"),
                LocationId = Guid.Parse("C64EB7BB-BD45-4118-BEF0-9045D7A15C96"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8e0d6ef9-74ac-41b7-ab48-f0962b119d27"),
                LocationId = Guid.Parse("4A67A504-A790-4CA1-B6D7-F23C0C25371D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8edc1283-1015-4afb-87ce-461e7ccaa5d7"),
                LocationId = Guid.Parse("4C3AC6FE-2E7F-4A7C-ABF7-129E491F6390"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8f0bfa82-5c2c-475d-9505-7c100c382bc6"),
                LocationId = Guid.Parse("55B51956-D4F2-48C9-BE4F-5C074937B3D3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8fd061f0-7e9d-4983-8c94-7812721b5a91"),
                LocationId = Guid.Parse("9E6990B3-3FD7-4207-91D4-3C20483E4089"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8fd6b0c2-250c-4984-bfd3-64e774085778"),
                LocationId = Guid.Parse("785143DD-735F-4217-B3AB-779FB0D6D6E9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("8ffa7833-0eb6-4f4d-a4c3-61df28264544"),
                LocationId = Guid.Parse("33FD64A7-D37F-4538-8F48-03923089C108"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("90074398-35f4-4aaf-928b-c3148fdd71d2"),
                LocationId = Guid.Parse("16B56E45-4720-49AE-AB43-2BADC4F41ABE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9030544d-5d18-4b28-b2b5-111236c25d42"),
                LocationId = Guid.Parse("35B46911-4A55-410C-9611-9DAED52023C1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("906e32dd-2a74-4e80-afd4-d0e934f6b222"),
                LocationId = Guid.Parse("E98A7580-2008-454C-9B59-F931C453EA17"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9085731c-2d88-49ba-87f1-a459a186686d"),
                LocationId = Guid.Parse("88EABC6F-77A4-4C18-8863-1B4CC96927BF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("911fc4ed-4f5f-40e1-8633-1b99019c662b"),
                LocationId = Guid.Parse("DCEBCBF6-855A-4441-A7BF-95CA6C340470"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9138c46f-4e49-4f27-8872-6d93b821ab85"),
                LocationId = Guid.Parse("EA4C8E3E-E974-4C44-A911-3472C46A2DB3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("91805883-dea8-4d53-887d-46f5de3829d4"),
                LocationId = Guid.Parse("DB74725F-07AC-4BB4-B148-ECF3D6AC90D9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("91a153fb-c7eb-4ee9-80ae-f747818ed0a6"),
                LocationId = Guid.Parse("CAB347F6-DD06-4A6E-8672-80EC556A4E41"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9213bb1f-d5b6-4a9f-a5bb-d7311f81b61c"),
                LocationId = Guid.Parse("C4B1ECC9-38DF-4115-8ABF-D7E4113CF205"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("92aff40f-bcf0-46b1-9726-26e6cdd0af1c"),
                LocationId = Guid.Parse("3568CA04-2FF7-4609-8863-17BD00FCB6BE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("92e21659-50e1-42cb-9da0-6f71609cfff8"),
                LocationId = Guid.Parse("746651C7-474A-4AC7-A1B6-2419B96D99CC"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("93227c43-7948-4c00-b195-6972fbeea161"),
                LocationId = Guid.Parse("00A8AA0E-C5FD-499C-8063-76B3058F1D09"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("93674702-75c7-4250-af94-1df9883c1c3c"),
                LocationId = Guid.Parse("7695C7CB-4217-464A-99DB-45CE4BA667B3"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9373a925-50fa-41f2-9e8c-c6531700387d"),
                LocationId = Guid.Parse("9CFFE146-C8B1-4379-B188-5B9B6BDF7023"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9374e60f-efd2-44d4-9f51-a390cd225072"),
                LocationId = Guid.Parse("789A1DB9-8E2F-452A-A3F0-7065AB4AA20E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("93b4f618-18de-47f0-a60b-384a75a84f81"),
                LocationId = Guid.Parse("12A36991-33DB-422E-8982-75BA8C6CB2EE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("93c841c8-9998-4ecb-a84b-039a3ccf4ed5"),
                LocationId = Guid.Parse("B97DCAFC-E05E-45C4-9C93-20157E4266E7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("93d58b77-639f-4507-b67d-ac49b48241ef"),
                LocationId = Guid.Parse("D0B49AFB-211E-47DA-A05E-08EE3F92B44E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9445b9cd-986c-4a55-9a2e-f1407654fdcd"),
                LocationId = Guid.Parse("E94F238F-A60D-43F3-86D3-E43FC7B2E6B9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("944db143-dd75-405a-bfc1-f0b9a4e08ed1"),
                LocationId = Guid.Parse("29BB3A42-8005-4BDC-A455-872790352574"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("94785e3a-306f-4de6-80c8-629aa7ab4549"),
                LocationId = Guid.Parse("C90D2F0C-D0B3-414D-A015-E20EFE4CDEE6"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("949aaf05-efbb-40aa-8a9c-d80e43126f15"),
                LocationId = Guid.Parse("C3F39EB5-A8D4-45A6-8FC4-F37C1EA42E7C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("94a73e8d-5a58-4d57-9a9b-14ecad06d762"),
                LocationId = Guid.Parse("CDBD1C39-E3D9-4913-B39B-E6D319859EB6"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("94de433e-3856-4186-b660-77204090e44f"),
                LocationId = Guid.Parse("2F827F70-8E9C-4720-ADFD-F29A7D25A3E4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("951f3d70-062b-46e8-ba9d-c081eafe132c"),
                LocationId = Guid.Parse("61C049BF-5637-4E2E-B89B-D53F345A9284"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("95e21772-cf2a-4117-b8f8-374ac91ef494"),
                LocationId = Guid.Parse("B97CCAA6-79C6-4AD1-BA77-34A4BECA3156"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("96868e18-745c-4628-a355-d2e8177d40ea"),
                LocationId = Guid.Parse("1AE75553-2888-47CD-BE49-EF057493E648"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9697b76b-47f1-4a3f-a99d-a540178f8352"),
                LocationId = Guid.Parse("551974BB-0B32-48EF-BE1A-B92348B9C987"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("96bd0959-94b5-4ddc-b4b5-dc61bc2e5575"),
                LocationId = Guid.Parse("2F923A4E-0DEA-4051-8A28-A124A2FC30D7"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("97230f87-4a77-4c36-ac06-0aaf2a49b4bb"),
                LocationId = Guid.Parse("4CDBB4BC-3CE7-46EC-BEDA-223876D22DAD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("973045bb-0420-45a6-9bd5-474c7e3d064b"),
                LocationId = Guid.Parse("1D7BC5DE-5511-4715-B77F-2834C04B8F51"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("97355dae-8a44-4a22-9e00-75dc0af1a86e"),
                LocationId = Guid.Parse("F83B9011-383F-4922-A773-E3F8F6C2ABBC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("977963d7-4f02-49f1-a008-355257c72872"),
                LocationId = Guid.Parse("F5FD6A14-5E4E-4852-B883-5D714E23B7B4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("98465d96-f665-4e43-84d0-4b9a1c75680c"),
                LocationId = Guid.Parse("AFEAEE09-916A-46B4-8C9D-50F907ABE9AD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("98d76dd4-866a-4756-9aeb-049b708631d9"),
                LocationId = Guid.Parse("3F35D8E7-6025-4BE0-ACDD-B967374595B5"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("98e63d12-27a3-4954-8a02-16405f5f250c"),
                LocationId = Guid.Parse("6D7C4D5A-B403-4C6A-BF4C-A5FA63B7E5D1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("98e7c651-1703-4eca-aae1-0674219db562"),
                LocationId = Guid.Parse("C2F7C7CB-B609-4E2D-8CB5-9DA45ECC2AC7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("99343386-d59b-4378-9e86-090640a1f516"),
                LocationId = Guid.Parse("9AB14C2E-6FD0-4C4E-98DE-D8E576B2668E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("99b5a467-e0fe-4672-9e81-4f7b029fbd80"),
                LocationId = Guid.Parse("BC5B881E-B3E6-4264-BF24-E603AB36382C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("99c79153-92d6-4c34-8808-1c6a03dcd201"),
                LocationId = Guid.Parse("B0165826-58B8-4077-B4BF-3027E2841691"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("99d6254b-b055-4e9a-a38d-4aad84b7d62e"),
                LocationId = Guid.Parse("17135D1E-E9F5-474D-885F-1A7E931B99CB"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9a075cf2-f2d9-4b3b-857e-9577a7d294f5"),
                LocationId = Guid.Parse("283AD546-A85F-4255-81AB-50E98637E3E2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9abd1626-eadd-4e79-940a-c8c1210e571a"),
                LocationId = Guid.Parse("E9FA3839-7F98-421B-B04E-3A173334B838"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9ad28014-b48d-4c5d-8e89-0c5813c7f176"),
                LocationId = Guid.Parse("869F437D-49F8-4AEC-94F2-21267F7BFAF9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9ad5698c-54e4-47d9-b17b-5fba2d6d199e"),
                LocationId = Guid.Parse("DC8B0DDA-8044-465C-9275-EE6A43B77A83"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9b26426c-11b3-4429-b86a-75d9271fd3a7"),
                LocationId = Guid.Parse("04714C80-D35F-4AD6-96BC-706A13D86EE7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9b5055f5-3e46-4339-a183-16e58e9fec42"),
                LocationId = Guid.Parse("D57C5F10-9BA9-4AD8-B6CD-09EE15DF598A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9b5db5f4-54cd-4280-85cd-f08cb28952d1"),
                LocationId = Guid.Parse("BDCC457C-3F2C-4F30-9B79-36051365ABFD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9bcdeddf-4495-42e6-b793-7c37a0ee68c3"),
                LocationId = Guid.Parse("7ED7935C-E0B3-456B-A20E-5D4F22345F13"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9bf61ff7-4cad-4290-87c0-be2c90d20b42"),
                LocationId = Guid.Parse("6C3FD444-B14E-42FF-8658-DB585E6B0CC4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9c2057aa-837a-4fb2-b3f9-33442b0176bd"),
                LocationId = Guid.Parse("683FF656-0AE5-4E19-ADF8-B1E087D3AF12"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9ce8d471-54f5-47ae-93b4-0ba2a7368dd3"),
                LocationId = Guid.Parse("175DFDAF-0C13-4D0E-A800-2B564681E885"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9cf7a9ed-95b0-4d49-a1be-d7baf8eb8478"),
                LocationId = Guid.Parse("425315EB-59D5-41B0-9A2B-646115A3F190"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9e457b8c-9e30-45ea-a60b-3e51734128bb"),
                LocationId = Guid.Parse("18468C1C-EA00-469C-A68E-C77B84AFB15D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9e59945e-def3-4122-8556-ec4f3d477e04"),
                LocationId = Guid.Parse("4A314551-2F4F-4FD2-9274-AF1D234C6374"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9e6f5626-bf74-41f4-b650-291e74e4d576"),
                LocationId = Guid.Parse("DA61DC84-F1D3-491C-A652-A53952AD8252"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9f1c2f7b-05a6-4afa-a0bc-f454603c0203"),
                LocationId = Guid.Parse("0E4C6007-95D5-441A-86EE-0EB71CFAB417"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9f86b27d-a343-45be-8e58-79bf551fd3b6"),
                LocationId = Guid.Parse("68BE3CE8-6174-43D4-A145-2A97DD7DE349"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9fc814a1-c08c-4508-89e6-ddd29649b0e8"),
                LocationId = Guid.Parse("EAAFFB34-5B41-4098-B6FE-C5DA1F825218"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("9fffa147-216c-4362-9b29-f3a52e0a3124"),
                LocationId = Guid.Parse("FFCB6B9F-9DD1-4E85-AF2B-7E5651F4951A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a02c8e9f-2b96-474e-afba-c1388da14263"),
                LocationId = Guid.Parse("53EBD698-B02D-4BF9-B1C5-FB4D3F5F5B6F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a0c4aefe-adf4-48ba-8ce1-64cca1ab738d"),
                LocationId = Guid.Parse("05EF9450-AB58-4D58-B55C-53C79B56EA70"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a0d665c4-b76c-49cf-85cc-8e01aa31f935"),
                LocationId = Guid.Parse("EE52516D-0C4C-4294-910A-9914BB303C78"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a104b004-801c-4cfa-a8ef-8366fd2388df"),
                LocationId = Guid.Parse("DB52CCE2-8083-4B7C-94C0-6D1595336B75"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a13e0069-d886-463f-8502-c64c813f53d1"),
                LocationId = Guid.Parse("DFEAB1A4-8A08-45DF-A00F-67F335265B52"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a141defd-c36e-4cd0-b35c-3db51c6915f4"),
                LocationId = Guid.Parse("B96B5DCF-AE22-4055-B0E0-CE9510152711"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a1623073-5754-4940-bb65-81474e4597e3"),
                LocationId = Guid.Parse("57C812A8-3216-486E-B6A3-7D20A165CC20"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a1a2d57f-c0cf-4f4f-b88d-3b23eb02dc0f"),
                LocationId = Guid.Parse("62C5F384-C3E7-4643-B76A-56DD54441201"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a1ab65ff-791f-4cd6-ac25-06f6a3f5f4e8"),
                LocationId = Guid.Parse("6C236AFF-D08F-4FD9-A2DC-05BC24F86858"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a1d6e5ae-643c-4f9c-b7f1-14b99d80d3e9"),
                LocationId = Guid.Parse("5CF9203A-AE22-4073-960F-60E346CCF30C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a2267482-3987-467b-99e8-123a8c74fca3"),
                LocationId = Guid.Parse("B20C7142-BFB6-4D9B-B36D-5BDAF276B397"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a22b431a-8eae-4668-adde-2a95a57a3775"),
                LocationId = Guid.Parse("238692EB-EC32-41AE-87D9-02EB2C31352D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a24043b3-f9f6-468e-a4a9-71eda48d9ebd"),
                LocationId = Guid.Parse("C18027B4-7BAA-4A08-A975-A993B0D0A11C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a26c0a96-acb5-4020-b98e-f246ebd67ee8"),
                LocationId = Guid.Parse("23675227-94DE-447F-B0DA-EE69200F0AA2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a315c1a9-4aaa-4894-94ba-7da3b359f100"),
                LocationId = Guid.Parse("F6B40402-4C6B-4712-B919-47A2ED8962BF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a3d3febc-51fb-41bd-9851-1b77786493ec"),
                LocationId = Guid.Parse("C94ED920-EE11-4585-9B89-6B8514640C75"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a3efeceb-6ec4-4b13-b811-337ad3f19d18"),
                LocationId = Guid.Parse("72A0EA89-815F-49F5-8ABA-D1EB519D042B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a470a607-26bc-49b4-8121-96003900709b"),
                LocationId = Guid.Parse("C280EC1C-0C0A-4F4C-9458-F767F3C6F4DC"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a4a8ce20-2793-4aec-bbc0-12fe416b6380"),
                LocationId = Guid.Parse("135C9E37-8E46-400C-9367-84B40016A4BE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a4fdd4ef-89d4-4508-8ce4-4cf4f8affb09"),
                LocationId = Guid.Parse("AE4475A7-41EE-467F-99D2-241AC7057CE1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a51d7b6c-ae91-48cf-83ba-321cb30829ee"),
                LocationId = Guid.Parse("ECED1B0F-DE75-43F7-BB8E-C9326EC2CAB8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a536b2d1-190b-4580-9507-f91a61a6b2fa"),
                LocationId = Guid.Parse("2B66E5E0-453C-42BB-BB7E-89255D6215A9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a5a5e71d-58a6-4802-a5e2-d778b607285a"),
                LocationId = Guid.Parse("6C3D94E4-30A5-40A0-B386-5E6CFF161807"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a63a46b5-0dd3-4573-b187-a01ce4b4bfb9"),
                LocationId = Guid.Parse("A0DC3D2F-E01C-44CD-BD85-FA11349AFBD4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a6e84793-bd18-4ec3-9697-f2a6228757e5"),
                LocationId = Guid.Parse("FE66203B-2C95-492D-8CBE-036EC1A709F5"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a71c6f68-8d44-4aa3-aedb-224f40d11b90"),
                LocationId = Guid.Parse("D3244AD1-BE8B-461A-A969-A99D05AAAFEF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a82d40e4-60ae-4ca8-90c6-3f5f2bc7edad"),
                LocationId = Guid.Parse("35430B56-66B0-427D-9387-6AB9CB65E0E7"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a83eddaa-16c0-4df6-aaba-a23504c30f0c"),
                LocationId = Guid.Parse("90E1F8FC-6F33-4D43-9454-89854B224362"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a8434305-1761-44cd-b776-76ff91c84b2a"),
                LocationId = Guid.Parse("49DCB7F5-E6C4-45E7-95F9-9BFAC03C6131"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a8998375-f6c1-458e-83e9-57bbc06953e3"),
                LocationId = Guid.Parse("340AD20A-4A98-4770-AACF-091754EF5812"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a8d5f6c1-75b1-4125-9f8b-d2783e215c91"),
                LocationId = Guid.Parse("709E8DFB-74DF-48B8-BD08-70259CBAB9C9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a8f7e0c9-2bd7-4d34-84e6-86e4221ac2f7"),
                LocationId = Guid.Parse("0E1F234B-842C-4495-9FE6-35FD7C0A55FD"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a9211df9-6045-4677-a83e-926e79a68953"),
                LocationId = Guid.Parse("D5DC00C7-AB7A-4780-BEDC-8880649DF02B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a928e1a6-5447-49ab-b1c1-97997555d6a6"),
                LocationId = Guid.Parse("676869D0-C9F1-49F2-93FA-9C98051AF837"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a99c8ff4-4d42-4a58-996d-6c7821415ef7"),
                LocationId = Guid.Parse("FE141BAA-A39E-4570-A5B5-13ACCD75E0B3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a9bd0d1f-ab4d-4877-a3a8-aca2de93acf6"),
                LocationId = Guid.Parse("8D0714C7-0259-400C-9AF8-89EB8E19E959"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a9f4d2d6-4f3f-4dc9-8f56-407e29d48b4e"),
                LocationId = Guid.Parse("9DAAFD5A-C7C9-47CC-844A-5622E8C6AFA4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("a9f8dc09-320e-4be3-b1a7-96c73a79db3a"),
                LocationId = Guid.Parse("58857610-5CE3-4C56-B15A-09B6F95F65B4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("aa374fb5-5eed-4b4e-88ad-2aef2090f3ce"),
                LocationId = Guid.Parse("217E2410-5B43-47E1-8457-CEC31747A1E6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("aa418434-4d50-414f-8e26-fed6a53ef9c2"),
                LocationId = Guid.Parse("DABEA372-8D80-4CB8-AC93-41641AC89B9C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("aa75a7e1-1279-4f03-9299-a83c7afb9ade"),
                LocationId = Guid.Parse("434C5E33-3499-4620-BC79-152D927FC47F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ab546dbd-b582-4ae9-b4c0-e777ee98b5bb"),
                LocationId = Guid.Parse("01205D27-03C4-4A79-9919-161581A19728"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ab96ae2e-1707-40a6-a6ba-ba1d616eb640"),
                LocationId = Guid.Parse("7013DD51-F38F-4E1F-809F-5F704F238D23"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ac1bd6bf-6bae-4099-b6d9-22ff98911812"),
                LocationId = Guid.Parse("334EFB94-6F35-4C93-AF11-24AC5DC79D19"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ac32747e-d263-49ec-83d1-6beac62e426a"),
                LocationId = Guid.Parse("C93EE740-B29A-499A-A24B-0D4B3AFD5A57"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ac352ac9-30ba-47de-bbec-1943f5bdcea9"),
                LocationId = Guid.Parse("C4B4AAC9-37D7-4949-BB39-22FAA7CA5065"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ac75a710-6760-4b9a-8aa2-cd9892b24650"),
                LocationId = Guid.Parse("3B70B04D-EAFC-4C94-BBA0-1E088ED3C4AC"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ac90d83d-0bb4-4b1f-b4b4-87fedd983654"),
                LocationId = Guid.Parse("1DF0BBBA-CD92-4B32-9461-EDE68CDAA5DE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ad25aee1-1776-45b3-9898-6850f2f93e32"),
                LocationId = Guid.Parse("C6D66688-2E8E-4A32-927F-A3F245B72DEE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ada3ea69-74c6-40b2-84c6-d0adf7e481d4"),
                LocationId = Guid.Parse("EF2FCD19-2612-4ACF-8114-340349519480"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("add22f4e-f794-420b-8df6-20cd01757f20"),
                LocationId = Guid.Parse("F2B7CDCE-1746-47E2-BDF1-819C789018B0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ae084b71-4538-4904-ad9d-69e17e482c0d"),
                LocationId = Guid.Parse("935F7805-F97A-431A-82AB-D22B78360A22"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ae37c6c2-2ec5-4254-a530-dd8c023a4ea3"),
                LocationId = Guid.Parse("BECBD0D1-DF3B-4F2D-9D69-A773005960B4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("aeca1bc4-1584-4db8-9064-52088f8845ca"),
                LocationId = Guid.Parse("59578728-11BA-4731-A186-75BFAD46FDD8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("af19716a-cf3b-4145-b14a-95424ff061c7"),
                LocationId = Guid.Parse("2AFA0722-42D3-4724-9517-C30F4CDBB9F3"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("afa58d00-2aa8-471e-aef8-d60ee2462e19"),
                LocationId = Guid.Parse("999302D9-7AE0-4DE0-9B2C-15DCD91F75C0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("afc8f96c-8c73-419b-961e-5b5896fb5576"),
                LocationId = Guid.Parse("FEF27F67-590D-48C0-B131-0444768F8B2B"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b01c0c2c-d9cb-4328-8146-d49d541d623d"),
                LocationId = Guid.Parse("5472C4DF-4717-4841-9151-3BE69ED68B4E"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b0567cbe-a3eb-4136-bc2a-5601549584b0"),
                LocationId = Guid.Parse("B3237950-B52C-4241-93E5-CFBA89D81C51"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b0c893fe-00a1-4e6f-be81-643eb03b2c68"),
                LocationId = Guid.Parse("F486EBEA-3200-4979-BED0-426976786C7A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b0ef88e0-a8d1-4d2c-afae-76a810742ec7"),
                LocationId = Guid.Parse("1C5A573C-C9FE-4970-8F9F-51C3C9A3E67B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b1464ccf-96de-4a73-89b2-bbde9bf1b25d"),
                LocationId = Guid.Parse("5754D664-96A2-489A-B8B9-EFFF7EC62AFE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b1c78b0e-fac0-4166-9a63-264b063ab0bb"),
                LocationId = Guid.Parse("BD79357F-1F2B-4073-A2D3-27D3E14FD3CA"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b2548f7d-2b11-415f-8b00-ec91f3058f9e"),
                LocationId = Guid.Parse("BDF943B0-6934-4C34-BCF0-04C4C1042FCE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b28ecb3a-d12c-4ac3-aa5d-db499444c9b8"),
                LocationId = Guid.Parse("A3D4C3D6-D367-45A9-81CD-8C69DCF59134"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b2a8f6d6-43b7-41b3-a621-ceab054721d6"),
                LocationId = Guid.Parse("BDB8EB5E-B7F2-45A2-A6B8-350223580D3E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b2bf4eee-bbfb-47ea-a7fa-beeaa9f388e3"),
                LocationId = Guid.Parse("2D279747-62B7-44F7-8E85-A7D4E92F6204"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b2c0cb00-5e7c-483c-a84c-80f295c36dfc"),
                LocationId = Guid.Parse("5698B90F-B116-40D3-8BD3-D1EC5AF4D283"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b2c3f1bf-c07f-49a9-b87f-2b776c6ea9e1"),
                LocationId = Guid.Parse("3E0279F0-95F6-449A-BDF0-BB60DFCE87FC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b352a0e7-eed2-4805-95f1-4024835dcf12"),
                LocationId = Guid.Parse("C035BA4E-6A44-4464-95E1-E504A9645A02"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b3f97251-39d7-4b29-8d64-a501d8beada9"),
                LocationId = Guid.Parse("EE559CFC-1631-4091-B18F-AB1B4FDCAEA9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b3fe3f6f-7d4b-4cdc-98b9-fec76897e2dc"),
                LocationId = Guid.Parse("B4DBFF4E-0917-4DDF-AB0C-EB6B5A03F0E1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b44c20b0-a6e6-4827-a391-b384b6765deb"),
                LocationId = Guid.Parse("9D658B91-D666-40AC-A9D5-FCE51278D2D0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b4760d86-f2fa-46ff-bee8-7eb2504f507b"),
                LocationId = Guid.Parse("7AFBB739-96DD-449E-9EDB-CCC912CF236B"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b4baa4a4-61fa-4733-8e36-8f6dfdc4e3c8"),
                LocationId = Guid.Parse("B18D2B4A-CE2D-45A1-84FD-79D9A6107FB2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b5171037-77bf-4e6c-947e-e178bd32f353"),
                LocationId = Guid.Parse("A92FC2D0-3998-4340-956D-82CCCA1A76B5"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b53f1fe0-a40a-4d0b-b47d-bb99a4806a8e"),
                LocationId = Guid.Parse("9364B7D7-5BBF-40F5-B4D6-FD5A3C7B42D6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b5a13bb4-5d95-4396-b1c0-24f0c15781ea"),
                LocationId = Guid.Parse("29E6E644-EE1C-4814-A915-DD8A576DEB70"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b5e17725-286d-4406-bfef-aa41f7947a2b"),
                LocationId = Guid.Parse("3ABF96AB-618A-415F-908A-85456144AB14"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b5fad50d-7774-4169-bbd9-79ba6888ac47"),
                LocationId = Guid.Parse("F690F20F-2BB3-4B09-AA0D-97342E08B0C8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b6aa3405-de4d-4d5b-bdc2-cb6c0abf5422"),
                LocationId = Guid.Parse("FD395D8D-3495-4F6F-AF91-BB245C9BA19D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b6e43291-add5-440c-ac32-6f1fa3d6ffcf"),
                LocationId = Guid.Parse("ABB8D486-77F2-4DB2-9669-1735A3323B3E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b707e3fe-be11-4e97-a3c9-334214a66044"),
                LocationId = Guid.Parse("ACDCEBBC-867A-44E3-895A-1E5F2ED18C4E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b72f9efe-7b6f-443a-bcd6-882ad7ae2a2e"),
                LocationId = Guid.Parse("9CCDB865-C3AE-4C5D-8D7A-AEC604F53F12"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b7369bf6-3267-42d2-83eb-b3b69703b302"),
                LocationId = Guid.Parse("D0496B8B-921D-4027-8DB3-5BFCC241CBEA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b74b96cb-ac14-4db6-974d-f8b09b6ead21"),
                LocationId = Guid.Parse("754CE5F9-81C5-4AB5-A093-2695AEA1182B"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b768a78f-3462-4d3d-8ec8-9f3ff75aaf93"),
                LocationId = Guid.Parse("284099B3-1EB8-4BCD-B74D-90EE1CD5F74C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b7a9ad3e-89ad-4cde-a5ca-71b584d45559"),
                LocationId = Guid.Parse("E0E00F38-62F4-4420-91D3-1C2F80349AEF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b7c73118-8374-46f0-a0c6-185e6a09c821"),
                LocationId = Guid.Parse("4A1593C1-E0E6-46F0-BC41-05A018BA44CA"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b7e93331-eb2a-4eed-9589-6477784ec56e"),
                LocationId = Guid.Parse("9D0A52C1-7572-4AC5-B068-08B68DE01803"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b805d854-fbbf-4d3e-8bf5-96f823d0fa86"),
                LocationId = Guid.Parse("62E1997A-529E-42B3-B78C-69083345A8DB"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b83893b5-69dc-43a2-9538-de8fb9caa2b3"),
                LocationId = Guid.Parse("C32E7DDA-10B8-424D-BDD8-A4D1230437E9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b845f36e-5842-424c-93c8-a47d05d1e68d"),
                LocationId = Guid.Parse("32A659D9-5FF8-4B69-818D-3999C8CFBF51"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b8a9fa48-746a-4783-b56c-791ef6cad5e2"),
                LocationId = Guid.Parse("C5ADBD98-9F0A-407C-BD98-2038F73AF617"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b9ccea17-b2fa-4954-8b56-df836f20459c"),
                LocationId = Guid.Parse("329B8FC3-57BB-4E23-A255-97ADD2829260"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b9d01de2-6fc3-43c9-9603-b51c031d8177"),
                LocationId = Guid.Parse("37B57A50-3082-4935-A1F9-6982A2DBF719"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("b9f5a1e2-c72d-4199-929c-05f0682919b5"),
                LocationId = Guid.Parse("D70B344B-5761-41AC-A382-B22DCD89AB56"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ba17a18c-01ef-495b-94ec-b1947a0b360d"),
                LocationId = Guid.Parse("AFE679ED-4B44-478D-9B97-11692A81D384"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("babe2931-abdf-440b-a42b-f15cfb8632e9"),
                LocationId = Guid.Parse("14D381CE-243A-4CDA-B3C2-2F1648CE14D8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("baca7cd3-8a67-409f-8ee5-56880fd36edc"),
                LocationId = Guid.Parse("F0F61787-01D3-4161-B90B-F3142ED3567C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bb216fd9-1080-4e7b-8ef3-df4e4404e1ca"),
                LocationId = Guid.Parse("AE41D2CD-14DC-417D-BB36-001071CE5EF1"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bb51459e-9e99-4213-9649-b293b97ee1c8"),
                LocationId = Guid.Parse("537168DD-8762-4826-9EB9-EF9CBE0DE280"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bbcf0f52-6ad1-4892-8af4-0259b6af4c2d"),
                LocationId = Guid.Parse("0D9264A8-85B5-47CA-B3AA-E8FA318F2111"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bbf3ccae-8bea-447f-a3c0-b33943ddd5de"),
                LocationId = Guid.Parse("D150E4EB-FD7D-4995-B4F4-82B2C783CEE1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bbf717aa-b01b-4d12-bd71-6e2d028f7245"),
                LocationId = Guid.Parse("5153CD44-6DD5-44CE-B3A3-332D2F46D833"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bc0fc3ed-ca00-403d-997e-a433f58e7eb5"),
                LocationId = Guid.Parse("6631F94F-A42A-4C38-A7C9-11670FFDF351"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bc345a6a-0080-410c-bddb-db0ae19d7dff"),
                LocationId = Guid.Parse("4F3CFC68-EC33-4BCE-8FDC-B473470D6578"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bcdb0864-f5f1-4601-8086-3b5d9515ed05"),
                LocationId = Guid.Parse("7DD489C3-C276-4784-9374-26E21E751B17"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bd4c3975-7b9a-45b8-a20f-f09068400230"),
                LocationId = Guid.Parse("869C5980-6526-46A2-B04C-EC18D76BE5E1"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bd4d782d-8fd0-4905-9c79-590f8654adc1"),
                LocationId = Guid.Parse("3C9A85F3-950F-41C5-AAF9-7F2EF75C73AB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bd611180-1f6c-429a-ad94-1378e2b4fc09"),
                LocationId = Guid.Parse("D58B7501-C5F7-4E51-94B1-D282852BBFA7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bd6e32f0-f65b-4249-8a79-6b5e3546320d"),
                LocationId = Guid.Parse("2907E7DD-F6BC-498D-9245-525D0EA8E5C0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bdca6029-ef93-476f-b17f-3dca087da83c"),
                LocationId = Guid.Parse("465BD784-72E6-467D-917A-5F8F783512D0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bdd4308d-be1c-4107-b04e-82e47b77de3f"),
                LocationId = Guid.Parse("851C28CF-DD77-44FE-9A9D-65BB7CEDE506"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("be01f670-6f96-4907-8495-28e3423047d2"),
                LocationId = Guid.Parse("165FE15E-C955-4BD8-9321-1DC148C8896C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("be33715a-70ad-4ac4-aa8d-80baf4f7aedf"),
                LocationId = Guid.Parse("A7328B8B-581A-4F21-8AEA-964A52836B89"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("be3393ed-6778-4f15-bad2-87199a7e7b19"),
                LocationId = Guid.Parse("7143B41E-BFE1-441A-A822-9BCD45DBFEE6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("be56a62e-c541-4f61-8690-22670908f703"),
                LocationId = Guid.Parse("A118058A-E426-4FC9-86FE-1E6A3B021F3B"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("be72c247-b342-40c4-8107-b258c26ab50b"),
                LocationId = Guid.Parse("2249D9FE-746F-4BE1-8114-5D6C5BBF16B9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("beb9041e-21d7-4cdc-9a15-7cac576fe469"),
                LocationId = Guid.Parse("DCAB1110-6AB1-42A9-96BD-35152BC9F021"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bed0bb9e-1fd3-4e44-b958-c3046f5e138b"),
                LocationId = Guid.Parse("33103507-FD3B-4299-BC4D-45695385492B"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bef37972-4540-45c0-a059-83d0f6ee803c"),
                LocationId = Guid.Parse("37B46F8D-408A-4468-A510-C31F1D3D77D4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bf4b50f8-c246-4015-b9c1-3db0202d4d79"),
                LocationId = Guid.Parse("385F1ABA-1C6F-48F9-8551-CB47434E6200"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("bffb9eab-ed53-42a6-b5a4-209dd03300c4"),
                LocationId = Guid.Parse("0FB51854-59F5-4FBE-91B6-DC258B2F146A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c00c6d01-1d56-44fb-8edf-79f3f58cde7e"),
                LocationId = Guid.Parse("C982DF50-236D-4BD9-B7BF-464939701BDE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c05e7404-5bd7-4040-96e9-77e0d3a71a27"),
                LocationId = Guid.Parse("88D671F7-16B8-4811-B4B3-27EC75979F48"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c06520fe-6eb3-486a-a9da-228b430f22de"),
                LocationId = Guid.Parse("6D5C46E1-8A4A-44B2-B6DB-C21548AAF6C3"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c0e9db05-bc22-4162-8bf3-c25e078864a5"),
                LocationId = Guid.Parse("2F37D051-1B20-4836-8489-F0D3F2EBFC1F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c0ee1fda-7631-4aec-bde5-3c32cb5ecfa4"),
                LocationId = Guid.Parse("1675D1E8-D06D-45DA-B27D-FE99D5D3C2FB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c0fa5d64-76f0-4782-8aaa-250d0a29be09"),
                LocationId = Guid.Parse("DFCB244B-3BC8-4C76-8EB9-2369A11659A0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c10b9efb-48b8-4f55-b08d-4a90cee8b4e7"),
                LocationId = Guid.Parse("E21E268A-E8AD-4877-A5B2-BDDA10EA599E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c15487db-e05c-4e2d-9922-d514fd051549"),
                LocationId = Guid.Parse("86D2B9E8-3743-428D-A44F-366D221227B3"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c229a776-581b-4e0d-9af0-676615be0cde"),
                LocationId = Guid.Parse("B82FFE42-66D9-4AD3-899D-E0F38E7F8B11"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c235f5e9-d44c-4c8f-aa2a-a5a41a9d1975"),
                LocationId = Guid.Parse("B839638A-0B73-471F-8C75-6854AC760ED6"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c2514b82-6b7a-4a59-9c05-e2c833372c89"),
                LocationId = Guid.Parse("3E8B4F5E-CBB5-4ED7-A924-C1CC41AA2AF9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c2569a10-6927-4e17-a290-f4c90b962a42"),
                LocationId = Guid.Parse("08153064-0DCB-4F33-8559-9A16FFC35444"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c2c45998-1232-46e9-8706-5f59c64a3d2a"),
                LocationId = Guid.Parse("4D817D09-8458-4106-8578-3E527AB1F5D6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c2f698f4-5e77-4ab1-8a98-19d3e09e5b82"),
                LocationId = Guid.Parse("4FFDE7D1-1759-4A8C-B154-5C02D92E04F2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c34cb13c-38e2-4867-aed0-23b6b1e05b95"),
                LocationId = Guid.Parse("676373A8-6CB8-4CB5-B3C8-430845FB5644"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c4328e15-9eca-4682-a548-c28e093fdc71"),
                LocationId = Guid.Parse("9C17CF71-34D0-4613-9C0B-DA3C7C81998E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c474da1b-e46a-4fa8-9842-6e95f5e080d1"),
                LocationId = Guid.Parse("D0B3019D-F0BE-4582-9D54-575D0EFB6BFA"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c4d5b300-2baa-4dd4-abad-1a8e4b284f3d"),
                LocationId = Guid.Parse("D269E124-C9F1-4076-A4C1-C327DB95539B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c4daeba7-fc2b-4546-a9f8-315ea104abbf"),
                LocationId = Guid.Parse("5F5AE2A7-CE17-43F6-9630-455946BDC395"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c4f996d1-d5c8-4cef-9043-920156b34764"),
                LocationId = Guid.Parse("F797B580-E4D4-48D7-90D0-8B59F188BFD6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c54dd2f4-e9cb-43eb-ae22-a9d8f9b6fc69"),
                LocationId = Guid.Parse("E2985273-7435-46DF-AAFE-0BA0F8FA1246"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c55ec058-2208-4499-858e-3d7b358ca3a2"),
                LocationId = Guid.Parse("2FED08D6-888F-4B4F-AA11-78CF833AF7EE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c56b1925-bcd1-487d-9f3c-c19a8524ac47"),
                LocationId = Guid.Parse("CEE58723-48B6-403D-B03A-A4E17FED8426"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c57c4266-ae89-4200-a45c-d45c2348f1c3"),
                LocationId = Guid.Parse("E7447F79-08CB-4FC8-8711-B11716A65F67"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c5f0e8ee-cd84-44f7-8cd3-e1cc6a9908b2"),
                LocationId = Guid.Parse("B013E1A3-92C3-4020-810D-5DAF05182061"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c711ab9d-0dd7-4c5b-aa58-6a9a93780683"),
                LocationId = Guid.Parse("22841DC7-3DAF-4768-8D1B-B3B5A4B78D09"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c7b94e58-2e76-4404-b1c8-7b945af82d84"),
                LocationId = Guid.Parse("F348A56B-20C3-4C77-824A-226C2E223034"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c83a8220-7101-45ac-a301-4e57b66263ae"),
                LocationId = Guid.Parse("5E0157FE-E695-4BE7-9DCA-5674E533D1A8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c8a2ab1b-6abe-4ff5-840b-1a1e76b7cd92"),
                LocationId = Guid.Parse("ACFB16BE-FD66-4590-9871-ED398FC914CE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("c964f640-6e0c-49a6-a66f-67100c4e69d5"),
                LocationId = Guid.Parse("F5B067F1-D645-41F4-BA4C-F565F86E532F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ca12d865-212a-4eb9-95ef-849ff2f2c149"),
                LocationId = Guid.Parse("233E4ECA-8BAE-4FE7-B1F0-5678E862F364"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ca22daeb-7e17-46b9-b1b7-c0575805fb4c"),
                LocationId = Guid.Parse("2E79EC7F-4855-40E0-96E6-C2F479CFA901"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ca725cef-7f87-41fe-b7ae-a19491917ac2"),
                LocationId = Guid.Parse("A72B17F4-5741-4EFE-914A-25DDDB1A6818"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("caafb10b-0c26-4044-9a33-82b3b53a54ea"),
                LocationId = Guid.Parse("75C295A0-392E-47C1-B74C-52F88BA6DCBE"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cb081a8f-ee52-4522-8fe1-261f2c804635"),
                LocationId = Guid.Parse("615C7C59-C878-46A3-B6B7-C5A8C0FE4DFE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cb2444ae-aca2-48d1-b564-69ed2dd84228"),
                LocationId = Guid.Parse("BFAFE417-54B3-4E9F-ABE8-E9967A657D69"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cb50cc8a-ee5a-4440-a57f-cf3f2b2c74ba"),
                LocationId = Guid.Parse("8AD74B14-D0B5-4CFF-B9A2-45028A3634D4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cb74a68e-ce06-45f7-bb49-f8d9a316cbfb"),
                LocationId = Guid.Parse("718BB6AB-A0BF-413B-AC1C-8DE31CE2BD2D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cb91ac44-bfb1-4dd0-b50f-87fca98c4e45"),
                LocationId = Guid.Parse("6908B3B1-B0E8-43A3-975A-D97499131C4B"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cb98add1-f4f3-49c1-adf1-49f138b1a8ce"),
                LocationId = Guid.Parse("5C2758A6-5BAF-4F99-87CD-3912E7F5BE70"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cb9a3d0a-c5e1-4cc3-a600-b0fa1aa80047"),
                LocationId = Guid.Parse("80EC69B8-42CE-4A6F-BBF0-5FAAA081AC88"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cc1af9f5-4fa9-4330-83bd-24bb86faf761"),
                LocationId = Guid.Parse("0F3BA9E6-19B2-4591-90C8-C47581A328B9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cc25843d-99e4-405c-ae80-8da851b417d4"),
                LocationId = Guid.Parse("62F5D3F2-9B9C-4431-A774-B650899D55C6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cc62ce73-ffb4-493f-99d2-8946e4d9bfa0"),
                LocationId = Guid.Parse("412019A8-F9F2-4757-9F2A-A52B632C5B90"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cc661ee9-b535-47a6-95f3-dc4ccf317a06"),
                LocationId = Guid.Parse("54BE1CB4-FB59-44B7-9990-AEB6216F8F63"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cc967462-e7bc-42b9-a102-a6d8ea085f4b"),
                LocationId = Guid.Parse("96BCD218-37FD-4D84-9CD5-F038051F48E8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cce356a4-7c66-450b-8007-127faf0aced8"),
                LocationId = Guid.Parse("81E4223E-C9EA-4F11-9E50-6BC28549BC69"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cd16bec8-98f0-428f-83c9-6667f2e0dc09"),
                LocationId = Guid.Parse("61E41F8A-84DB-4B80-BE4D-3DD111DA523D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cd95f842-ff20-4d8f-affd-78d3952e70cd"),
                LocationId = Guid.Parse("69A7BE0E-B4B9-4A65-B0B8-51D68F34E14A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cd9d7086-8ba5-4cde-9648-494eb1f433ed"),
                LocationId = Guid.Parse("369AF6DA-F29C-470A-9AB3-609F6263B20E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ce4fc35d-70f7-4ebf-90d5-f59589bb58d5"),
                LocationId = Guid.Parse("E034AC20-2865-4466-9022-ACA88E52D372"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cea333c4-7d06-47af-b178-53e4dcf3904b"),
                LocationId = Guid.Parse("4F445D33-29F9-46CF-AB1F-04A3C139086A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cfacfa51-eaf3-4c25-9ec9-ab69d76cb7a0"),
                LocationId = Guid.Parse("E8E409D5-47C9-4C2C-958F-6A0255C4D131"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("cff3ee75-c4e7-4807-aa0d-feb3cd2cb30d"),
                LocationId = Guid.Parse("A50E87B3-CF3E-487F-92FB-39B190F852F6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d0037853-8baa-42d9-b4bc-ca74bd966b1f"),
                LocationId = Guid.Parse("D7F7D7EE-9E7C-4657-ACDC-F5CF97A398BF"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d061f4e9-e5b6-4181-9265-1867272b3543"),
                LocationId = Guid.Parse("663D7FE5-4CBC-4C15-B6E3-C256AF72B359"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d13dfdae-0e8e-4a3b-a3c6-2f52a16c33e5"),
                LocationId = Guid.Parse("FABA8C46-3F25-4CB4-A307-B60F2419C4B8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d17223d7-fcc6-4b43-98e7-a2418c7f3a9e"),
                LocationId = Guid.Parse("7B19D914-05BB-4008-8C99-10C0231FC4D1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d192a349-9bf5-49c9-9649-403fb27606e2"),
                LocationId = Guid.Parse("D7EBE506-8C6E-48C8-B4A8-6755E3000D76"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d21fac20-87d8-4f94-9c5d-a71824c712bd"),
                LocationId = Guid.Parse("409B3AF4-FBBF-4B3A-9F80-F9B93724A59B"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d23fba03-70b7-42bc-bb4b-d81cc99f9e4b"),
                LocationId = Guid.Parse("46E84B22-9A75-4614-8286-8BDEEB92054B"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d29ba7c9-a60a-4388-b518-58f3285f4895"),
                LocationId = Guid.Parse("1A1F8709-DC8F-4816-8129-7B5BF4E109E2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d2c249b0-0361-4b71-b394-31ff093c7b4a"),
                LocationId = Guid.Parse("7046D885-B56A-402B-BFFE-CDB73273437D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d2d0542b-c006-4778-9369-9cd1caf7f46b"),
                LocationId = Guid.Parse("5D4D060E-10B2-42FE-B23D-C5479ECED31A"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d2e80633-37fe-4377-bacd-cbc56a656641"),
                LocationId = Guid.Parse("E5AEF3F9-7A35-42B5-A5B7-272243F44D68"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d37d66d5-be77-4a68-be2e-a8e7d178dbc0"),
                LocationId = Guid.Parse("9C5112CF-79C4-4123-AC06-3E85CFE6E863"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d3e0cc28-0a0a-40d7-96e1-5d0182c9d077"),
                LocationId = Guid.Parse("1AD41CC5-A950-45C6-86C4-95221C7DF60B"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d408ba97-32fd-480d-a6da-958db4d6f92e"),
                LocationId = Guid.Parse("55A91AC2-7B75-44EF-BA6C-FFF19469DFC3"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d41b4b10-f439-43c0-9782-2a01a57e04d0"),
                LocationId = Guid.Parse("230CA735-73D0-424C-99BC-3DAA3AD62121"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d4301ca9-d617-4a09-a7aa-0985ef677dcf"),
                LocationId = Guid.Parse("8DE5956D-DC71-46FB-8800-7BB0F83ADC41"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d43a03a1-7686-453c-81e8-801ea68dfbf5"),
                LocationId = Guid.Parse("31DB0D77-1164-463A-B434-26781B144F14"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d5317a73-27fc-4348-87e2-b676f883781f"),
                LocationId = Guid.Parse("EC838EBF-700B-4341-84EA-D9326D18106C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d54a4b00-46bd-49a1-87b8-60b429f5e53f"),
                LocationId = Guid.Parse("74EAA616-C25E-40B6-8CB0-7C29549728CB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d5530595-5bad-4338-8d1b-aabd23d20110"),
                LocationId = Guid.Parse("E340AC92-5CAB-4B77-A9C9-8CE5071043BB"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d568f3e0-f664-419b-947e-260b4dc5c114"),
                LocationId = Guid.Parse("984981F8-8F9E-4A99-9AE2-A189D436249D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d5933dc8-7827-4db5-96d2-1a6fd56a9c1f"),
                LocationId = Guid.Parse("636D4B37-2651-4ED0-A651-DEDD57BCD3F2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d6415d89-37b5-4db3-814c-278ca09a1dfe"),
                LocationId = Guid.Parse("9CFDAF7F-F1E9-43C4-9F29-1DF22B2F6661"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d7216454-bdce-471b-bba0-b4c3a61e6726"),
                LocationId = Guid.Parse("EC67ECAB-7573-40AA-AC8F-17F23D2BE1D4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d75ed43a-99df-4288-b793-0e552fe426cb"),
                LocationId = Guid.Parse("4D7AE668-DE00-4846-A4E4-925A0211365F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d7aa808d-fee0-4d7a-914f-1bdc703b78a5"),
                LocationId = Guid.Parse("D0D69B94-AE03-432D-B899-2DBA6AA86992"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d7c9ea8d-2c2c-40e3-90be-13ff26c7b624"),
                LocationId = Guid.Parse("6B63A85B-6EC6-4CBA-A044-E3C0540467DE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d8de120a-0e8a-404e-83fd-79c7b1182294"),
                LocationId = Guid.Parse("2440ABFA-CE2F-4CAB-BE8A-EE37D353D105"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("d95d11ae-760d-4cdf-a17d-8faf40d1d951"),
                LocationId = Guid.Parse("27EE14B0-A3BD-40B2-8061-32D420F7409C"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("da078e4a-9931-46f3-8fe2-2ab44e4c814d"),
                LocationId = Guid.Parse("4646E3A1-B60C-4F60-B024-C0DB056D6DFF"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("da1a4dfc-4343-42a2-a83d-7f19012e8e61"),
                LocationId = Guid.Parse("DC9961EE-25C6-42F3-A448-69EB35D2B747"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("db02efea-94af-4b9c-8c62-37a39fbd1def"),
                LocationId = Guid.Parse("872FB59A-1A6C-479D-82BC-B523DE3055B6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("db27224d-5d00-4dfe-b969-221a5f880772"),
                LocationId = Guid.Parse("A8E4AB3D-AFB8-46B5-9ECD-D29D3BE0ECFC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("db4283dc-b2be-4f30-a5ba-6bf17eef1314"),
                LocationId = Guid.Parse("6F4EEE79-D7A9-46F2-8F6A-1C88ED656056"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("db501eb1-9d42-46f9-addb-cbdfaea74476"),
                LocationId = Guid.Parse("76B4D77B-0832-4769-82CA-F2034B066AA0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("dc50adac-2c82-4e26-881f-f74cb94f9fd3"),
                LocationId = Guid.Parse("205DCFA3-3385-4CBB-A978-B87BCD60957A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("dc81e25a-2a3b-45f4-a56f-b492b5fb6990"),
                LocationId = Guid.Parse("0651DF5E-FABA-4E8F-9281-797BD7009614"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("dcbd3f56-b13e-48dd-a582-36da656cdb01"),
                LocationId = Guid.Parse("E5D1C4CF-B04A-4961-87F6-CFF20A8F6B60"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("dce8f0d6-f7aa-4963-bf05-18d5291bd2a3"),
                LocationId = Guid.Parse("3A1757D8-1F1E-416E-8D4E-D2DF97E68EF9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("dd1b2668-e801-4751-8f1e-d27e25f79914"),
                LocationId = Guid.Parse("5B7664D8-0B62-490D-A666-CB373490B7DA"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("dd28e458-ca98-4b6a-840b-478ca26a45b1"),
                LocationId = Guid.Parse("1D6537ED-C4DC-4B98-AF1A-45B6C06FB35C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("dd3b96a0-4487-4e03-8878-375fb1009cd1"),
                LocationId = Guid.Parse("ADB65460-1CA3-497C-BA38-C4A61CAE2830"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("de0b089a-0b73-4727-b814-23a981b589ea"),
                LocationId = Guid.Parse("3DAEACD6-8A62-480D-BBE1-571FB74239C2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("de86bf2b-f9ee-4fb9-aa5a-47ea01cc6d4a"),
                LocationId = Guid.Parse("5C304231-5894-432A-BF7C-C3219F68B2A7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("df671080-7dc2-4b1a-afe7-4db91735044e"),
                LocationId = Guid.Parse("B630CCC4-D082-49B1-B66D-3E3F6AEB854E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("df9bfafd-1982-4e3f-9ef7-be4af76828c6"),
                LocationId = Guid.Parse("85E4BD86-37DE-4CF4-920C-D0EAE274FD60"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("dfb4fd1e-4996-4cff-9149-38d6bb689350"),
                LocationId = Guid.Parse("61F9767E-5C79-40D8-9025-021C08C7ACE1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("dfc6049e-9fb3-4807-8d7b-c40341fdddc4"),
                LocationId = Guid.Parse("77DE7C4F-A1CA-4CE0-9EED-2259DA541A48"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e02fdd37-1753-4886-9866-b9f6b14dffb2"),
                LocationId = Guid.Parse("605AEB26-A210-49F3-B324-015DAEEC249C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e03a93ff-4b51-4dde-b9d2-0c4663c4c288"),
                LocationId = Guid.Parse("EDD0D4D6-446C-4FB2-837A-80750B3C0E16"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e04858aa-b4f6-4c87-aedc-b5aa9e58d390"),
                LocationId = Guid.Parse("AB663B62-9719-41B7-96C9-CDA1597F831E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e08444d1-9d63-4ac9-9609-7e36458dd66e"),
                LocationId = Guid.Parse("708424AA-7AA2-44E4-A780-A6C8F2DB52DC"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e0f78e0f-59e5-4b52-80c4-ebe2a966af56"),
                LocationId = Guid.Parse("87CA442B-5182-48E1-8B33-996D4C86D808"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e0fd5c85-295f-4451-b941-a868dd97b1d2"),
                LocationId = Guid.Parse("DABDD3C4-DAEC-43EC-BB9E-B01C659FABB1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e14eceba-18bb-438f-ad3c-c8f57f108516"),
                LocationId = Guid.Parse("A6905CD2-D662-43B4-96FF-D9EE6EDFB6EB"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e17b0ad3-4625-43c8-a556-cdc1d978d917"),
                LocationId = Guid.Parse("638C11AC-CB06-4176-B17D-FFC54DBB03FE"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e193d0e7-70de-474e-87ca-f1db71615b07"),
                LocationId = Guid.Parse("0BC6A1A3-7D15-4C11-B605-0851F1921047"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e1b46f0d-c7a7-45fa-92c8-ec907f77c5ae"),
                LocationId = Guid.Parse("97200555-3F33-4FB7-8802-3ED5D135B384"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e253031f-c45d-4a56-8600-948f49cb518a"),
                LocationId = Guid.Parse("7DEBDCD6-B1C2-4A75-9E04-428AF73F5547"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e3516368-7b19-4b26-bc97-d1f42f673988"),
                LocationId = Guid.Parse("F810246A-7D82-42B5-9EF6-C7951EDAE851"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e3a0e052-287b-428c-b52f-89f25c50db19"),
                LocationId = Guid.Parse("7BF687BD-9674-477A-B5AC-BC65831C1190"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e3e12069-004b-4431-a4fd-ba975c5a5ee7"),
                LocationId = Guid.Parse("C338C9B2-1B4F-41E1-A875-A7B34FC2339E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e41f3f8f-5deb-464f-ace8-7c5ac322604d"),
                LocationId = Guid.Parse("60E6D6AF-F07B-4D5F-A4E1-792D782512CC"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e49a5ff1-e485-493d-8632-5d4a24ca73ed"),
                LocationId = Guid.Parse("0DC28C08-E1B4-41D5-AE76-90E7EE3119F1"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e559f31b-a927-42f5-b1f6-90d7a11ba673"),
                LocationId = Guid.Parse("94383D92-84A8-47C0-B680-F069C580C99E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e5809b7a-6482-467e-975f-5df4e8ea432e"),
                LocationId = Guid.Parse("05D8F377-E968-4819-8FA1-3688DC226F6C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e59d5eb2-45d9-4ee4-bd44-132b1748c64f"),
                LocationId = Guid.Parse("2AF54033-F0B9-4A99-9862-B9038859B12E"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e5d01667-fea0-414f-af4b-88b074eb76e6"),
                LocationId = Guid.Parse("5BA93416-FAE7-4820-A661-AC3463DA86FD"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e5dc3590-b58e-4ad5-8b04-2ab259e60275"),
                LocationId = Guid.Parse("C6A796FA-8B40-49EE-A643-2DD53ED49C71"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e652deaa-7383-4fde-8948-9d18202018ab"),
                LocationId = Guid.Parse("CD3BC38F-B778-426A-A068-EAA7726B05F0"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e6c9ac19-e153-4f81-8d39-5acda7ea2606"),
                LocationId = Guid.Parse("8966D478-61D2-48DB-9ADB-64503348DD41"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e6d882dd-f93f-47db-a13d-f45ed3e485d0"),
                LocationId = Guid.Parse("D4BB1111-9E95-458A-9B84-B45012AF1DF3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e6e53841-9cf0-4d8b-b269-b2c176eb5b69"),
                LocationId = Guid.Parse("F37BB961-4C20-4F70-8B72-5B8F6E2BE754"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e6f02c6b-b4af-47e9-ab96-c58ee17d9c92"),
                LocationId = Guid.Parse("D6938B7B-F463-4947-86B1-1BC9B86757E9"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e70d6825-833e-4346-9edf-eab7414ee348"),
                LocationId = Guid.Parse("F9E16321-B26B-48BE-A354-8101385BEC33"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e72d51d4-25e5-4837-a4d9-ca5884f00d5c"),
                LocationId = Guid.Parse("3563C69A-D6AC-499B-87C7-50825C97527E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e7643dbf-8f73-4901-bf4e-953042b1cd84"),
                LocationId = Guid.Parse("1DC6589B-7099-4A23-B268-8323C88E51D4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e76d4f32-f0e5-4cfb-8876-77f1de0c697b"),
                LocationId = Guid.Parse("59C9146D-9728-4D19-9984-3BC191AB9884"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e86e5e80-1f82-4418-bc19-8fde1a08c571"),
                LocationId = Guid.Parse("AC8085DD-73AF-4D1B-B404-D2E6824309C5"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e8f40501-482f-497b-b790-801ffc1eb701"),
                LocationId = Guid.Parse("9CB1B11C-E8E8-495B-B87D-65355AE198E5"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e9143cbf-1557-4cb1-badb-8b17fda1f84a"),
                LocationId = Guid.Parse("9DF47BBF-1A1D-46C5-B262-1100DAB117FA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e93eee35-75bb-4e26-8f9a-74707c5279b4"),
                LocationId = Guid.Parse("11400A33-855A-4E5E-9D98-A3A95FCABF3F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e9b5f529-c4db-49a4-860b-afc8f3ffa194"),
                LocationId = Guid.Parse("BE676A80-EAB3-4921-9C07-B2EF4F047030"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("e9d1452e-2f78-4924-9472-c90429589dcc"),
                LocationId = Guid.Parse("C49B90AE-5C4D-4533-B629-0779D663E49D"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ea2a79de-f66d-48b2-adbb-335784a16301"),
                LocationId = Guid.Parse("19DC5D42-40A7-463C-A095-E3077EF52568"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ea72d493-13ec-4afd-9f5f-c4a1d1226f5d"),
                LocationId = Guid.Parse("EF47E89F-3BFD-471A-B907-4E5534D95940"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ea8cec96-4e88-4a71-9bb4-dd13c003af75"),
                LocationId = Guid.Parse("6F629C35-0DB1-43A9-AE0B-88B697ECA217"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("eabcada7-44e5-413c-b796-28e91b78baef"),
                LocationId = Guid.Parse("3D88194E-D628-48DB-9A56-119F31EA4244"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("eacc204f-390c-49c2-ba8f-c9879b9fb6fd"),
                LocationId = Guid.Parse("EED54415-6ED5-4F27-9F35-86E237D41C66"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("eaede09a-c7e5-4652-bfc2-bd48ddd84b7e"),
                LocationId = Guid.Parse("7D9A365C-BFDC-4220-B29B-7C9B0DC76EE2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("eb315e2a-5b5f-4c9f-8ac6-bd0b08babe43"),
                LocationId = Guid.Parse("DD9A48A7-88E0-4442-A7F0-3A72901C7708"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("eb7f4376-590c-448c-95f5-9f30b4618f9f"),
                LocationId = Guid.Parse("2FFFD2FF-EE75-460D-B04C-7D63AFE3030F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("eba1df2c-310d-459c-b0a5-c7fd72dce6cc"),
                LocationId = Guid.Parse("08507726-5E9A-43B7-8B8D-3166F79626F2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ebd4a70e-7bc2-4fa2-99d4-d916fd83b1fa"),
                LocationId = Guid.Parse("66ADCA12-2FAF-4E22-A3AE-96772DB43002"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ebe96404-dce9-4fb7-b378-4bf1cf9d2d88"),
                LocationId = Guid.Parse("D51A42D6-85F2-46F4-88C8-88866F508668"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ec52ed36-5a89-4b0a-a878-a5a85f29d6a0"),
                LocationId = Guid.Parse("50D643FB-404B-421F-ABC2-D074C28BEB25"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ecbf0e43-6d1c-4013-b1d0-80aa9e2ed167"),
                LocationId = Guid.Parse("82D92CA8-B01F-4FC5-9EBC-EFB33B1091C7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ed237633-96c6-41cd-8f76-71ff6dcb94e0"),
                LocationId = Guid.Parse("1ACE08C2-6EAD-40D1-B18F-46880EB0F652"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ed94e5dd-2b92-4424-9474-9db770aac009"),
                LocationId = Guid.Parse("2F2DABE9-1963-45FE-9A62-167A8BCF64A5"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("edae6ef0-1a7d-498b-90b0-b92f1456e891"),
                LocationId = Guid.Parse("3EF1731F-3EA6-49C5-A4C5-C5AA48734C05"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("edd74b32-ff37-4702-8840-dac60b1a053c"),
                LocationId = Guid.Parse("A385AA13-3C1A-4068-86DF-882FA58C860A"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ee280c1b-8a66-4de1-86c5-47de6171f463"),
                LocationId = Guid.Parse("A11B39BF-8835-4331-8876-0C414E2899DA"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ee60c42b-96fd-4170-aa8b-55049f44455e"),
                LocationId = Guid.Parse("99F88BBE-00E6-441A-B735-1218FA039CC2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("eea4a110-e866-4ec7-9933-0491a0a3305c"),
                LocationId = Guid.Parse("1B0C4C8F-93D3-4F68-9025-9F902F601ABD"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("eeb61d0d-3724-482d-972c-6045cf63cfce"),
                LocationId = Guid.Parse("04C01181-6181-4B11-97E8-4D3159559534"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("eefc5e7b-68d8-4c5e-aa07-a5f52ac6e145"),
                LocationId = Guid.Parse("76200187-C46D-44D6-9B92-9869A5600CDD"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f06186c3-726f-45fe-b065-4996925e1e28"),
                LocationId = Guid.Parse("BDA1824D-D22D-4CA7-8D49-87A7AB6F8743"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f09937e5-a991-4b5b-9a7e-3cc9399f3fd1"),
                LocationId = Guid.Parse("A3150263-7237-4CB3-AADD-20F456B47B47"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f16d8543-263b-4bf4-aa50-df328c7764a2"),
                LocationId = Guid.Parse("18EB2141-F1D1-4AAA-B285-F8C87D082841"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f2351961-5666-4444-9025-e4601df5ce5b"),
                LocationId = Guid.Parse("2DA5F13F-7801-48DC-B88D-6F70C400C3D6"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f23fbfc3-054f-4e99-baeb-a7347a9a3a15"),
                LocationId = Guid.Parse("EA4845F3-36A9-4C11-A9F5-67ABC62D5C80"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f27f57f5-80d6-4aa7-a5e8-af854da0211a"),
                LocationId = Guid.Parse("99E264A6-F6F9-41C2-B012-3A68856905E7"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f2b0237f-8e5e-4012-bebf-2b274e2e0c5b"),
                LocationId = Guid.Parse("5501D1E8-42ED-4911-AD6A-7C8CF242A19E"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f2d59945-1747-4529-83b7-798f99d64aec"),
                LocationId = Guid.Parse("73D47496-48C9-44A6-95C7-7C676A7D11E3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f2dfe910-9bc1-4689-8f8e-784d12063256"),
                LocationId = Guid.Parse("B06D9241-D74E-423C-8C58-0A55C31464A8"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f2e17e95-3bf1-4559-9ad3-6175748c2cd9"),
                LocationId = Guid.Parse("D8F7D25F-62A6-448D-A5CD-C10489664F21"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f3a72956-7d4a-4b9c-bd98-439b7ca31052"),
                LocationId = Guid.Parse("B642FA39-01CD-4918-977B-7E417FA82F3F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f3d037b6-022f-49c2-bf0f-df9caa7df1e9"),
                LocationId = Guid.Parse("78D05AC9-89F5-4A31-896D-D1ACF1E92850"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f407ebc6-5a84-4060-956f-7cc9d3476739"),
                LocationId = Guid.Parse("DC3238AD-E330-44EA-B9A4-DCABAA4050D3"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f40fdb03-02a0-4838-ac06-e4cd333a3bee"),
                LocationId = Guid.Parse("55D8C424-DCD2-40C9-9F47-C561ABED57A5"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f46fc0e3-ed0f-459c-83cf-14676158ef0f"),
                LocationId = Guid.Parse("DBAD6DC1-95FF-4532-9012-404A3500A176"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f4cbf52d-9f17-43fc-aa1f-ec79521825df"),
                LocationId = Guid.Parse("8BCD15CE-74E2-4F6B-95EE-59CFC9FB1B36"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f4f04f0a-80bb-40f3-b71d-232919f2bf11"),
                LocationId = Guid.Parse("DB5D3208-9C41-4BC8-829C-09E839937170"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f4f9cda6-119a-427b-ac20-74590a966bc6"),
                LocationId = Guid.Parse("1EB23889-EB0E-47D9-83E6-A2D268DEC092"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f5160b21-28b8-4a66-8c01-843652323590"),
                LocationId = Guid.Parse("35614D9A-B356-4B8A-8390-3B519249DAF9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f51cbaba-6d2f-48e7-a251-76c43986701a"),
                LocationId = Guid.Parse("E8419BB8-0A39-4D16-9D1A-7BB1F3852F42"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f5910582-9049-43a7-810d-3a41f8e08847"),
                LocationId = Guid.Parse("5792B387-AB5B-4BE3-85A4-DD19BA38819D"),
                PickingTypeId = 3,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f5b908b5-6f6e-480a-82cf-b4fd467c1837"),
                LocationId = Guid.Parse("6CDCADD9-419B-488F-8ACC-70F5A22D9B31"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f6004504-5d00-4f59-a7bb-3a772b918975"),
                LocationId = Guid.Parse("7D620FEA-FD45-456B-B682-654821A95BE0"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f669d4d5-9019-4338-880a-f10ee97cb62b"),
                LocationId = Guid.Parse("F07F6166-1ED1-48ED-8321-8996821EE284"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f671be02-d0e1-4bb6-8271-94268551140c"),
                LocationId = Guid.Parse("F97DAD7A-F345-4E81-9E0C-44EE99C74E49"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f69d7b6b-b6d0-41b6-99d6-dac8d4070203"),
                LocationId = Guid.Parse("B62ED50F-894F-449D-89BD-18457492FAB5"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f704e2ea-1f39-4612-9c36-11c1ea66909e"),
                LocationId = Guid.Parse("CF00F37D-8D90-479D-BD3A-A147479609C4"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f717e0b4-0919-4f9c-a2c9-e9a9ed6c4b31"),
                LocationId = Guid.Parse("2454423B-16FC-48AC-B3FE-335947D7EC2F"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f750a629-12ff-49a1-8569-201b10a4aca7"),
                LocationId = Guid.Parse("540FF631-E684-4319-AA20-C6A0258493B2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f834819f-cf50-4dc9-a636-37edd8125b29"),
                LocationId = Guid.Parse("A7F072C9-4C1A-44C1-8624-543359B1D702"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f8c6a3a7-b8b6-4523-a5e4-45e2d9f02931"),
                LocationId = Guid.Parse("208B21C2-5C59-4163-A32B-49C7EAC24A07"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f8c8c7e4-e646-41fc-8b75-7012f1d260a0"),
                LocationId = Guid.Parse("C63696D0-5162-4CD9-A2AB-1487FACF7301"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f997a6a6-add6-41a3-9679-50b91ec2e96e"),
                LocationId = Guid.Parse("2B0FA252-15DB-4E66-B240-AB3C9BB8AC0F"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("f9eb2ea9-3a92-48f7-8776-0fcea4b1217d"),
                LocationId = Guid.Parse("D85CA8C5-5013-4A41-BCF5-B8518B47E123"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fa6e57b0-5f38-4a14-ac0b-f089ac35d90c"),
                LocationId = Guid.Parse("F1C732A2-2F5E-412F-A04B-96825E0E3015"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fad4ccc7-9ee9-44a0-93f3-4d72361ce3b6"),
                LocationId = Guid.Parse("249B7D6E-3D63-4CEF-9C77-09314F11FF3C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fb0c0bae-7ad6-4d85-bb30-df3e4a7af578"),
                LocationId = Guid.Parse("628558AE-BBFA-413B-874E-14A9588C5F75"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fb185f36-33d8-4b0a-b4aa-6a4a04b19014"),
                LocationId = Guid.Parse("3B832429-F3B7-43D2-9B63-690282250036"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fbc8cac7-d114-4185-a8db-f82d483bc9c5"),
                LocationId = Guid.Parse("917064AC-EF1E-49EC-8AA5-034EF79831C2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fbf9f0d0-0e27-4144-9829-16e8914c15a1"),
                LocationId = Guid.Parse("D765746A-8575-4659-A5C3-360294F5E021"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fc188c2c-6b5f-42b6-8d94-e8eae3cc7fbb"),
                LocationId = Guid.Parse("44C711C1-8FAA-48B4-9717-DC0F4FC7C8F2"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fc21c7d8-6bcc-4578-ba79-5e9512445c2a"),
                LocationId = Guid.Parse("43EB91BE-9859-402E-85E3-FA98142D105D"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fc264aca-f2b5-4fcc-8212-20f322de440f"),
                LocationId = Guid.Parse("E88E19A9-C3EE-45F3-9F14-9ACB9960A65C"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fc5014e7-208a-404a-8af1-1428c560390f"),
                LocationId = Guid.Parse("2A07D47C-2BAD-4583-B610-ECB6BF696455"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fc7daeb9-eb5c-4d9f-b15a-6207c3932f7b"),
                LocationId = Guid.Parse("B582A521-4703-4B17-A0A3-97AD2E416967"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fca11728-f705-4ae1-96cb-62acc7f376ca"),
                LocationId = Guid.Parse("8A39A45D-F29E-41C6-B570-7419FB271D41"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fcf416bb-ae4b-469e-a3fb-eda63ce2ce36"),
                LocationId = Guid.Parse("971C6BF6-C36D-422E-B116-E77C7D8F33B9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fd099d80-bc50-402b-b671-0e9350cf2af4"),
                LocationId = Guid.Parse("9A509E73-8004-4A5B-9EE9-6B41287DF8A5"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fd26e60a-f933-4a32-8b16-34c90f4dc254"),
                LocationId = Guid.Parse("7A1570E1-FDBC-4FB8-91F6-52F986C7F8E8"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fd9bfe19-3a2d-44cc-b601-8a5589782d8d"),
                LocationId = Guid.Parse("8C424ADC-2B63-440D-93CC-4BEF07D536A4"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fdab790f-c734-4e45-bae6-1f9f4b757e5f"),
                LocationId = Guid.Parse("5BF10913-E98D-4294-9436-45FFF9C5AEBA"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fdee2a2f-d684-478a-abe1-b374331fa595"),
                LocationId = Guid.Parse("79D3EC14-DA9E-446F-BE81-10E26870D8E1"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fe4db5f2-2d94-4aa2-9f96-8e959de00da5"),
                LocationId = Guid.Parse("DDE5354B-A4AA-4FB0-8DAD-2A24207F6F63"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fe5260ea-92ca-444e-93c5-6bbce2486664"),
                LocationId = Guid.Parse("FF12AC64-CD34-4893-BA47-D997D10E38C9"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("fec8adb4-673a-45b6-b56c-7f91dfebbc9a"),
                LocationId = Guid.Parse("95589BF0-BB04-4590-ABEF-69771955CACD"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ff0612b6-ebe2-465b-8f1c-211482bcf419"),
                LocationId = Guid.Parse("AA064122-D71A-418C-AA7E-F613D648BDC2"),
                PickingTypeId = 1,
                CreatedDate = DateTime.Now,
            },
            new LocationPickingType
            {
                Id = Guid.Parse("ff3096f8-b7d0-48be-82d0-987e487115c4"),
                LocationId = Guid.Parse("2FE77080-87F0-4588-A99B-5F0F58132F84"),
                PickingTypeId = 2,
                CreatedDate = DateTime.Now,
            }



            );
    }
}
