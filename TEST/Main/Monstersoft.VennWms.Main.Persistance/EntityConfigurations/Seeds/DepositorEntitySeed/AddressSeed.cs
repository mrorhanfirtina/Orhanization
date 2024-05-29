using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class AddressSeed : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasData(

         new Address
         {
             Id = Guid.Parse("1224c606-3856-4a03-bb00-ed897ce47098"),
             City = "Tokyo",
             Country = "Japan",
             CreatedDate = DateTime.Now,
             Province = "Minato-ku",
             Description = "Headquarters",
             AddressText = "141-8610 and Sony Corporation, 1-7-1, Konan",
             ZipCode = "141-8610",
             Longitude = 139.74366m,
             Latitude = 35.63125m
         },

         new Address
         {
             Id = Guid.Parse("a848aef0-3877-4d4c-88b7-7b1f547b7b9d"),
             City = "Istanbul",
             Country = "Turkey",
             CreatedDate = DateTime.Now,
             Province = "Umraniye",
             Description = "Sony Eurasia Hq",
             AddressText = "Saray, Onur Ofis Park Plaza, Ahmet Tevfik İleri Cd No:10",
             ZipCode = "34768",
             Longitude = 41.02860m,
             Latitude = 29.11715m
         },

         new Address
         {
             Id = Guid.Parse("2f200482-4212-4b30-a49a-3de7117dac8a"),
             City = "Istanbul",
             Country = "Turkey",
             CreatedDate = DateTime.Now,
             Province = "BEŞİKTAŞ",
             Description = "SONY MUSIC ENTERTAINMENT TÜRKİYE TİC. A.Ş.",
             AddressText = "LEVAZIM MAH. KORU SK. KORUKENT SİTESİ D BLOK Z1 / 32",
             ZipCode = "34340",
             Longitude = 41.059926m,
             Latitude = 29.021640m
         },

         new Address
         {
             Id = Guid.Parse("0aef8f49-06ef-4c44-ad4c-314e08f8ac46"),
             City = "Adar",
             Country = "United Kingdom",
             CreatedDate = DateTime.Now,
             Province = "Adar",
             Description = "Room 122",
             AddressText = "0017 New Castle Drive",
             ZipCode = "LS6",
             Longitude = 1.56285m,
             Latitude = 53.8145m,
         },

         new Address
         {
             Id = Guid.Parse("15d2b1e7-8921-4573-9720-fa4a4b424009"),
             City = "Milówka",
             Country = "Honduras",
             CreatedDate = DateTime.Now,
             Province = "Milówka",
             Description = "Apt 1971",
             AddressText = "061 Stephen Place",
             ZipCode = "33214",
             Longitude = 88.3263603m,
             Latitude = 14.9415552m,
         },

         new Address
         {
             Id = Guid.Parse("1ad2f037-6a76-421b-b3c5-5d42a3783a20"),
             City = "Reutlingen",
             Country = "Poland",
             CreatedDate = DateTime.Now,
             Province = "Reutlingen",
             Description = "Apt 176",
             AddressText = "4755 Menomonie Place",
             ZipCode = "89-320",
             Longitude = 17.0835566m,
             Latitude = 53.180879m,
         },

         new Address
         {
             Id = Guid.Parse("20ff4a1f-22f6-49a7-be36-3eb1a74aaf16"),
             City = "Lawepakam",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Lawepakam",
             Description = "PO Box 11080",
             AddressText = "2 Vernon Lane",
             ZipCode = "32398",
             Longitude = 110.442349m,
             Latitude = 29.588771m,
         },

         new Address
         {
             Id = Guid.Parse("216960b4-e3b4-4c98-bfd8-3f25957576e4"),
             City = "Khulm",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Khulm",
             Description = "Room 888",
             AddressText = "0048 Mendota Avenue",
             ZipCode = "34692",
             Longitude = 130.375062m,
             Latitude = 46.814102m,
         },

         new Address
         {
             Id = Guid.Parse("290975ee-8a6b-4a0f-a318-d924ae8dd9c2"),
             City = "Obala",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Obala",
             Description = "Apt 556",
             AddressText = "1 Hoffman Circle",
             ZipCode = "363503",
             Longitude = 43.9157627m,
             Latitude = 43.1971197m,
         },

         new Address
         {
             Id = Guid.Parse("2adc34ec-0be9-4dcc-95b1-63d4d65211e3"),
             City = "Wangmo",
             Country = "Cameroon",
             CreatedDate = DateTime.Now,
             Province = "Wangmo",
             Description = "Suite 41",
             AddressText = "5 Oxford Crossing",
             ZipCode = "31078",
             Longitude = 9.9101915m,
             Latitude = 2.9405941m,
         },

         new Address
         {
             Id = Guid.Parse("2d946b47-8914-4d7d-81a6-35dcf1a06f65"),
             City = "Irecê",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Irecê",
             Description = "Room 740",
             AddressText = "42 Hoffman Plaza",
             ZipCode = "26314",
             Longitude = 116.00193m,
             Latitude = 29.705077m,
         },

         new Address
         {
             Id = Guid.Parse("363f66b5-51e5-4fe6-a330-1abb6f1b7a92"),
             City = "Asenovgrad",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Asenovgrad",
             Description = "Suite 50",
             AddressText = "18274 Erie Junction",
             ZipCode = "2113",
             Longitude = 120.9638841m,
             Latitude = 14.6874444m,
         },

         new Address
         {
             Id = Guid.Parse("371c7369-024e-4d87-82af-a434e7291e39"),
             City = "Gornyye Klyuchi",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Gornyye Klyuchi",
             Description = "PO Box 4884",
             AddressText = "7388 Sage Circle",
             ZipCode = "26759",
             Longitude = 113.140004m,
             Latitude = 40.255866m,
         },

         new Address
         {
             Id = Guid.Parse("39465ea2-3fa1-435d-bc59-b1a366d4683f"),
             City = "Daugavpils",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Daugavpils",
             Description = "PO Box 96938",
             AddressText = "3 Dexter Lane",
             ZipCode = "3105-222",
             Longitude = 8.7086605m,
             Latitude = 39.8476302m,
         },

         new Address
         {
             Id = Guid.Parse("4f97060c-a616-45f5-b800-2190f9894f17"),
             City = "Dougang",
             Country = "Poland",
             CreatedDate = DateTime.Now,
             Province = "Dougang",
             Description = "16th Floor",
             AddressText = "005 Cody Pass",
             ZipCode = "37-114",
             Longitude = 22.3570583m,
             Latitude = 50.1063169m,
         },

         new Address
         {
             Id = Guid.Parse("57976e4c-d3f6-4fa6-b01d-4831cb778869"),
             City = "Livingstone",
             Country = "Senegal",
             CreatedDate = DateTime.Now,
             Province = "Livingstone",
             Description = "20th Floor",
             AddressText = "057 Mcbride Circle",
             ZipCode = "32357",
             Longitude = 16.9638997m,
             Latitude = 14.7790314m,
         },

         new Address
         {
             Id = Guid.Parse("59ca2ca9-d0db-4ea7-bb52-7cac3c4c330e"),
             City = "Guarabira",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Guarabira",
             Description = "PO Box 40538",
             AddressText = "339 Di Loreto Terrace",
             ZipCode = "33563",
             Longitude = 110.374855m,
             Latitude = 7.7823871m,
         },

         new Address
         {
             Id = Guid.Parse("618b572b-52f0-4f97-a452-3c20f0562dcb"),
             City = "Bořitov",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Bořitov",
             Description = "Suite 83",
             AddressText = "69165 Esch Crossing",
             ZipCode = "27490",
             Longitude = 113.7993m,
             Latitude = 8.1081m,
         },

         new Address
         {
             Id = Guid.Parse("65578bc9-10a4-40cc-a199-1e789cc4b64d"),
             City = "Posse",
             Country = "Bulgaria",
             CreatedDate = DateTime.Now,
             Province = "Posse",
             Description = "PO Box 66071",
             AddressText = "25 Haas Trail",
             ZipCode = "8890",
             Longitude = 25.8960346m,
             Latitude = 42.7015624m,
         },

         new Address
         {
             Id = Guid.Parse("65b7b8d0-a629-4482-a55d-ac404146a0f1"),
             City = "Lagoa Vermelha",
             Country = "Lebanon",
             CreatedDate = DateTime.Now,
             Province = "Lagoa Vermelha",
             Description = "Suite 73",
             AddressText = "4462 Derek Street",
             ZipCode = "25915",
             Longitude = 35.5889282m,
             Latitude = 33.3594755m,
         },

         new Address
         {
             Id = Guid.Parse("6b01d8aa-d168-4bb5-9678-c878522246d7"),
             City = "Yisuhe",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Yisuhe",
             Description = "16th Floor",
             AddressText = "54412 Hanson Junction",
             ZipCode = "34900",
             Longitude = 118.439554m,
             Latitude = 26.09765m,
         },

         new Address
         {
             Id = Guid.Parse("728d917a-10dc-4980-9703-ab77f45c4483"),
             City = "Sicheng",
             Country = "France",
             CreatedDate = DateTime.Now,
             Province = "Sicheng",
             Description = "Room 495",
             AddressText = "0 Myrtle Alley",
             ZipCode = "29102 CEDEX",
             Longitude = 4.1020654m,
             Latitude = 47.9962116m,
         },

         new Address
         {
             Id = Guid.Parse("82c577fa-3dc4-496d-a4f8-6549ffff8ec0"),
             City = "Nuwara Eliya",
             Country = "Uruguay",
             CreatedDate = DateTime.Now,
             Province = "Nuwara Eliya",
             Description = "Suite 39",
             AddressText = "21 Eagan Center",
             ZipCode = "26419",
             Longitude = 56.7075141m,
             Latitude = 34.3486042m,
         },

         new Address
         {
             Id = Guid.Parse("835bb7e9-b7d8-4df4-8866-d1a26082d9b5"),
             City = "Itanhandu",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Itanhandu",
             Description = "15th Floor",
             AddressText = "34 Meadow Valley Center",
             ZipCode = "31084",
             Longitude = 113.7870822m,
             Latitude = 8.4412858m,
         },

         new Address
         {
             Id = Guid.Parse("8a691cfd-e833-4ade-9843-2cbabcdd0fd2"),
             City = "Cimenga",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Cimenga",
             Description = "Room 1150",
             AddressText = "46618 Maple Pass",
             ZipCode = "5470-206",
             Longitude = 7.7878704m,
             Latitude = 41.82663m,
         },

         new Address
         {
             Id = Guid.Parse("90ec990e-2059-4414-8a41-c7781fe45aa7"),
             City = "Santa Cruz Balanyá",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Santa Cruz Balanyá",
             Description = "Suite 58",
             AddressText = "9 Spohn Park",
             ZipCode = "460999",
             Longitude = 55.11302m,
             Latitude = 51.768362m,
         },

         new Address
         {
             Id = Guid.Parse("988052c3-601a-469d-bd6e-c7be74fe96a4"),
             City = "Vitória",
             Country = "Czech Republic",
             CreatedDate = DateTime.Now,
             Province = "Vitória",
             Description = "Suite 3",
             AddressText = "19 Mayfield Court",
             ZipCode = "756 06",
             Longitude = 18.309005m,
             Latitude = 49.3649919m,
         },

         new Address
         {
             Id = Guid.Parse("a4acf787-932c-44e9-8325-26ce46ce605a"),
             City = "Cacequi",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Cacequi",
             Description = "Apt 1842",
             AddressText = "1095 Springview Hill",
             ZipCode = "86165-000",
             Longitude = 51.3906526m,
             Latitude = 22.8664464m,
         },

         new Address
         {
             Id = Guid.Parse("adcdd6e2-2789-40e9-8a0c-45a0445ce907"),
             City = "Chunjing",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Chunjing",
             Description = "Room 1484",
             AddressText = "16784 Clove Center",
             ZipCode = "29227",
             Longitude = 105.0060673m,
             Latitude = 10.6231047m,
         },

         new Address
         {
             Id = Guid.Parse("aeb06a44-cc42-4425-bb9b-5cd669323546"),
             City = "Calumpang",
             Country = "Pakistan",
             CreatedDate = DateTime.Now,
             Province = "Calumpang",
             Description = "5th Floor",
             AddressText = "220 Spohn Terrace",
             ZipCode = "67410",
             Longitude = 68.3132182m,
             Latitude = 26.4486465m,
         },

         new Address
         {
             Id = Guid.Parse("baee3140-f3db-4e23-a4a9-bd3e27f37d1e"),
             City = "San Juan Ixcoy",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "San Juan Ixcoy",
             Description = "Room 1402",
             AddressText = "5 Sunfield Point",
             ZipCode = "429052",
             Longitude = 46.13865m,
             Latitude = 55.68871m,
         },

         new Address
         {
             Id = Guid.Parse("c844738f-f512-49f8-a0dc-9c7c820ba7ef"),
             City = "Puttalam",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Puttalam",
             Description = "Suite 58",
             AddressText = "173 Elgar Trail",
             ZipCode = "31512",
             Longitude = 118.347831m,
             Latitude = 27.415632m,
         },

         new Address
         {
             Id = Guid.Parse("cfc3674f-2ac1-4f48-87ca-d0c5d2745238"),
             City = "Santa Cruz das Flores",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Santa Cruz das Flores",
             Description = "Room 1547",
             AddressText = "8903 Debs Lane",
             ZipCode = "28583",
             Longitude = 84.3596m,
             Latitude = 46.75486m,
         },

         new Address
         {
             Id = Guid.Parse("de6d3509-46b1-4a1d-b2ee-3940343bc322"),
             City = "Ngujuran",
             Country = "Sweden",
             CreatedDate = DateTime.Now,
             Province = "Ngujuran",
             Description = "Room 1391",
             AddressText = "2 Heath Trail",
             ZipCode = "792 27",
             Longitude = 14.57173m,
             Latitude = 61.00862m,
         },

         new Address
         {
             Id = Guid.Parse("e6bcd9b5-8fc4-4a68-9489-ab6c0b67c4d0"),
             City = "Pyrgetós",
             Country = "Sudan",
             CreatedDate = DateTime.Now,
             Province = "Pyrgetós",
             Description = "Apt 1918",
             AddressText = "76 Lake View Alley",
             ZipCode = "27883",
             Longitude = 30.3839017m,
             Latitude = 10.6377926m,
         },

         new Address
         {
             Id = Guid.Parse("e90a6694-9a26-43e3-9311-4740cf20ae52"),
             City = "Juan Santiago",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Juan Santiago",
             Description = "Room 855",
             AddressText = "07147 Leroy Terrace",
             ZipCode = "87140-000",
             Longitude = 52.0423373m,
             Latitude = 23.4554707m,
         },

         new Address
         {
             Id = Guid.Parse("fbdca189-0ef5-4887-8935-c45638586eeb"),
             City = "Dzvinogrud",
             Country = "Finland",
             CreatedDate = DateTime.Now,
             Province = "Dzvinogrud",
             Description = "Apt 1565",
             AddressText = "01 Quincy Terrace",
             ZipCode = "90020",
             Longitude = 24.904004m,
             Latitude = 60.2025952m,
         },

         new Address
         {
             Id = Guid.Parse("fbe15b94-967a-4ef3-9fab-1bcbbd396bc9"),
             City = "Sozopol",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Sozopol",
             Description = "Room 1281",
             AddressText = "43468 Bellgrove Way",
             ZipCode = "601808",
             Longitude = 39.6602235m,
             Latitude = 56.4459712m,
         },

         new Address
         {
             Id = Guid.Parse("0016eba5-f55a-4c0c-85e3-b54d36b53ed6"),
             City = "Rulenge",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Rulenge",
             Description = "PO Box 23307",
             AddressText = "74153 Derek Terrace",
             ZipCode = "6534",
             Longitude = 122.0553349m,
             Latitude = 12.8074809m,
         },

         new Address
         {
             Id = Guid.Parse("03fe453f-c684-4ad8-a7e8-919fa4365ebc"),
             City = "Ōtawara",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Ōtawara",
             Description = "PO Box 18170",
             AddressText = "93926 Memorial Court",
             ZipCode = "63466",
             Longitude = 111.5736596m,
             Latitude = 6.7084401m,
         },

         new Address
         {
             Id = Guid.Parse("05586327-805f-4d18-a758-5fc468bf31c9"),
             City = "Baru Timur",
             Country = "Argentina",
             CreatedDate = DateTime.Now,
             Province = "Baru Timur",
             Description = "Room 1503",
             AddressText = "1659 Fieldstone Lane",
             ZipCode = "3454",
             Longitude = 66.3381678m,
             Latitude = 33.2843846m,
         },

         new Address
         {
             Id = Guid.Parse("05612d3c-3128-47f4-8216-3ca565ebf0c7"),
             City = "Pyhäranta",
             Country = "Kenya",
             CreatedDate = DateTime.Now,
             Province = "Pyhäranta",
             Description = "PO Box 18221",
             AddressText = "2484 Pleasure Avenue",
             ZipCode = "60849",
             Longitude = 36.080026m,
             Latitude = 0.3030988m,
         },

         new Address
         {
             Id = Guid.Parse("0b8ac0c9-cf50-43e9-99b6-9d9c6368b763"),
             City = "Mundybash",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Mundybash",
             Description = "Suite 90",
             AddressText = "267 Scott Pass",
             ZipCode = "18500-000",
             Longitude = 47.838004m,
             Latitude = 23.0510503m,
         },

         new Address
         {
             Id = Guid.Parse("0d39a99a-894e-4ad3-854e-2227071761e2"),
             City = "Woodstock",
             Country = "Poland",
             CreatedDate = DateTime.Now,
             Province = "Woodstock",
             Description = "Room 1475",
             AddressText = "6320 Towne Junction",
             ZipCode = "47-411",
             Longitude = 18.1543922m,
             Latitude = 50.1327056m,
         },

         new Address
         {
             Id = Guid.Parse("0f6c02d0-d6e4-4d51-a58e-1baecd3f2c1f"),
             City = "Lintingkou",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Lintingkou",
             Description = "PO Box 28827",
             AddressText = "495 Dwight Trail",
             ZipCode = "61657",
             Longitude = 106.71167m,
             Latitude = 21.3971282m,
         },

         new Address
         {
             Id = Guid.Parse("0ffa059c-f272-40e6-abf0-06cfff66ae6e"),
             City = "Preko",
             Country = "United States",
             CreatedDate = DateTime.Now,
             Province = "Preko",
             Description = "5th Floor",
             AddressText = "42574 Thackeray Road",
             ZipCode = "73142",
             Longitude = 97.6385368m,
             Latitude = 35.6131551m,
         },

         new Address
         {
             Id = Guid.Parse("10a82bf5-fdce-4ff1-9e59-22b8cba9d6dc"),
             City = "Tovarnik",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Tovarnik",
             Description = "Room 152",
             AddressText = "2 Arizona Pass",
             ZipCode = "63013",
             Longitude = 117.500558m,
             Latitude = 40.417358m,
         },

         new Address
         {
             Id = Guid.Parse("144ee5b8-1dfd-4583-a1e2-4cd9852e5537"),
             City = "Petřvald",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Petřvald",
             Description = "15th Floor",
             AddressText = "4242 Cody Circle",
             ZipCode = "55083",
             Longitude = 80.3038321m,
             Latitude = 41.1846097m,
         },

         new Address
         {
             Id = Guid.Parse("14f05196-5ed4-4700-95ac-38fe4920bd97"),
             City = "Nanyang",
             Country = "Ukraine",
             CreatedDate = DateTime.Now,
             Province = "Nanyang",
             Description = "15th Floor",
             AddressText = "51078 Jay Alley",
             ZipCode = "59635",
             Longitude = 36.9329429m,
             Latitude = 50.284234m,
         },

         new Address
         {
             Id = Guid.Parse("1be04f68-5773-460d-8b2f-b1472b27b57b"),
             City = "Annapolis",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Annapolis",
             Description = "4th Floor",
             AddressText = "22139 4th Point",
             ZipCode = "64983",
             Longitude = 124.8072165m,
             Latitude = 1.4162396m,
         },

         new Address
         {
             Id = Guid.Parse("21365c0a-ba0c-4e5a-9782-fea8e05bef87"),
             City = "Xinhua",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Xinhua",
             Description = "11th Floor",
             AddressText = "603 Magdeline Terrace",
             ZipCode = "59659",
             Longitude = 103.202869m,
             Latitude = 34.799642m,
         },

         new Address
         {
             Id = Guid.Parse("27077033-cb64-4490-a6be-a7f9c9cf77e3"),
             City = "Axili",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Axili",
             Description = "Suite 91",
             AddressText = "2 Shopko Plaza",
             ZipCode = "57299",
             Longitude = 113.823135m,
             Latitude = 23.296786m,
         },

         new Address
         {
             Id = Guid.Parse("29c4737e-2d24-415a-b98d-a0f1afb4f485"),
             City = "Corona",
             Country = "Madagascar",
             CreatedDate = DateTime.Now,
             Province = "Corona",
             Description = "Apt 125",
             AddressText = "937 5th Trail",
             ZipCode = "56925",
             Longitude = 47.8699039m,
             Latitude = 18.4001194m,
         },

         new Address
         {
             Id = Guid.Parse("2ca8d613-15fe-40cc-964f-4ae33d840136"),
             City = "Anserma",
             Country = "Mexico",
             CreatedDate = DateTime.Now,
             Province = "Anserma",
             Description = "Apt 933",
             AddressText = "266 Sycamore Center",
             ZipCode = "86350",
             Longitude = 93.2212883m,
             Latitude = 18.2574908m,
         },

         new Address
         {
             Id = Guid.Parse("2e8ed6fc-df1e-4a3e-bded-a3a258499397"),
             City = "Youlongchuan",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Youlongchuan",
             Description = "Suite 86",
             AddressText = "2 Esch Pass",
             ZipCode = "59968",
             Longitude = 117.4086488m,
             Latitude = 0.6349893m,
         },

         new Address
         {
             Id = Guid.Parse("309ec385-ff1b-4d6a-9bc5-8e1df2cf1fc7"),
             City = "Sanjwāl",
             Country = "Cuba",
             CreatedDate = DateTime.Now,
             Province = "Sanjwāl",
             Description = "19th Floor",
             AddressText = "81350 Messerschmidt Avenue",
             ZipCode = "56395",
             Longitude = 81.5322149m,
             Latitude = 23.0303395m,
         },

         new Address
         {
             Id = Guid.Parse("35a98089-3d0e-4c5e-8f9b-695a7fd3ec20"),
             City = "Sam Phran",
             Country = "Canada",
             CreatedDate = DateTime.Now,
             Province = "Sam Phran",
             Description = "Apt 1200",
             AddressText = "23469 Summer Ridge Lane",
             ZipCode = "J5W",
             Longitude = 73.4310787m,
             Latitude = 45.8377021m,
         },

         new Address
         {
             Id = Guid.Parse("363c7844-a5d7-4317-ad94-7c948f069892"),
             City = "Tujing",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Tujing",
             Description = "11th Floor",
             AddressText = "79895 Nevada Hill",
             ZipCode = "62282",
             Longitude = 113.149693m,
             Latitude = 40.005404m,
         },

         new Address
         {
             Id = Guid.Parse("36684879-b996-428d-bcd8-6dacc0e67f3a"),
             City = "Nelspruit",
             Country = "South Korea",
             CreatedDate = DateTime.Now,
             Province = "Nelspruit",
             Description = "Room 1081",
             AddressText = "6 Crescent Oaks Alley",
             ZipCode = "63901",
             Longitude = 126.9836808m,
             Latitude = 37.8246038m,
         },

         new Address
         {
             Id = Guid.Parse("38b4b958-51f1-4a00-a258-e67df7696110"),
             City = "Khorramābād",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Khorramābād",
             Description = "Apt 1383",
             AddressText = "121 North Drive",
             ZipCode = "692980",
             Longitude = 134.1872425m,
             Latitude = 45.9735653m,
         },

         new Address
         {
             Id = Guid.Parse("3a493cbb-75da-4826-bff0-42b9ab1becc6"),
             City = "Murmashi",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Murmashi",
             Description = "10th Floor",
             AddressText = "69838 Merrick Court",
             ZipCode = "63655",
             Longitude = 110.88907m,
             Latitude = 37.429832m,
         },

         new Address
         {
             Id = Guid.Parse("404e41d2-9817-42f0-9b42-05fa55ffa116"),
             City = "Hortolândia",
             Country = "Mauritius",
             CreatedDate = DateTime.Now,
             Province = "Hortolândia",
             Description = "9th Floor",
             AddressText = "0673 Hoard Terrace",
             ZipCode = "64308",
             Longitude = 57.4895998m,
             Latitude = 20.2418916m,
         },

         new Address
         {
             Id = Guid.Parse("40c7aa57-0f17-4e2e-a9d9-2ab2d32fef8a"),
             City = "Dadukou",
             Country = "Greece",
             CreatedDate = DateTime.Now,
             Province = "Dadukou",
             Description = "7th Floor",
             AddressText = "4563 Nelson Circle",
             ZipCode = "56456",
             Longitude = 21.9202642m,
             Latitude = 37.0038961m,
         },

         new Address
         {
             Id = Guid.Parse("423d2b95-19af-42d8-aab9-4d4fc10cd2b8"),
             City = "Banpu",
             Country = "Micronesia",
             CreatedDate = DateTime.Now,
             Province = "Banpu",
             Description = "Apt 1811",
             AddressText = "7 Morningstar Place",
             ZipCode = "61939",
             Longitude = 153.7133333m,
             Latitude = 5.5047222m,
         },

         new Address
         {
             Id = Guid.Parse("436e77da-29c6-4779-98e9-0b893dfba318"),
             City = "Marignane",
             Country = "Japan",
             CreatedDate = DateTime.Now,
             Province = "Marignane",
             Description = "Room 604",
             AddressText = "26611 Farwell Crossing",
             ZipCode = "966-0033",
             Longitude = 139.8857687m,
             Latitude = 37.6579018m,
         },

         new Address
         {
             Id = Guid.Parse("452ea8ba-acdb-4e7f-817d-e100d5843467"),
             City = "Guodu",
             Country = "Madagascar",
             CreatedDate = DateTime.Now,
             Province = "Guodu",
             Description = "Suite 95",
             AddressText = "79 Ramsey Center",
             ZipCode = "58309",
             Longitude = 47.4392352m,
             Latitude = 19.3836846m,
         },

         new Address
         {
             Id = Guid.Parse("46921eed-7ef5-471f-85df-1f6eb55ddc2c"),
             City = "Sidomulyo",
             Country = "Bolivia",
             CreatedDate = DateTime.Now,
             Province = "Sidomulyo",
             Description = "13th Floor",
             AddressText = "75997 Roxbury Terrace",
             ZipCode = "62674",
             Longitude = 64.3223726m,
             Latitude = 19.123139m,
         },

         new Address
         {
             Id = Guid.Parse("477fc83f-120a-4c0d-b7ef-2d36985a37ab"),
             City = "Zheleznodorozhnyy",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Zheleznodorozhnyy",
             Description = "Apt 1624",
             AddressText = "5942 Meadow Ridge Terrace",
             ZipCode = "57759",
             Longitude = 117.562238m,
             Latitude = 27.568278m,
         },

         new Address
         {
             Id = Guid.Parse("486c26b1-7222-4f28-bbb1-a818e81f2ed4"),
             City = "Bồng Sơn",
             Country = "Albania",
             CreatedDate = DateTime.Now,
             Province = "Bồng Sơn",
             Description = "Suite 48",
             AddressText = "414 Scofield Parkway",
             ZipCode = "56102",
             Longitude = 20.065066m,
             Latitude = 41.7186852m,
         },

         new Address
         {
             Id = Guid.Parse("4b51e6b3-1790-4c31-84ce-d689b931200c"),
             City = "Ternate",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Ternate",
             Description = "PO Box 43444",
             AddressText = "2 Schlimgen Drive",
             ZipCode = "8509",
             Longitude = 125.9551406m,
             Latitude = 8.0708562m,
         },

         new Address
         {
             Id = Guid.Parse("509f0c00-fe14-4620-9c2f-ac04f0e2290e"),
             City = "Osielec",
             Country = "Panama",
             CreatedDate = DateTime.Now,
             Province = "Osielec",
             Description = "Apt 1993",
             AddressText = "26778 Dayton Plaza",
             ZipCode = "62764",
             Longitude = 81.0423429m,
             Latitude = 7.9819981m,
         },

         new Address
         {
             Id = Guid.Parse("51713fc8-1dd1-44bc-972b-efad9127b800"),
             City = "Kunwi",
             Country = "Malaysia",
             CreatedDate = DateTime.Now,
             Province = "Kunwi",
             Description = "Suite 39",
             AddressText = "099 Bunting Park",
             ZipCode = "25200",
             Longitude = 103.2901816m,
             Latitude = 3.8353843m,
         },

         new Address
         {
             Id = Guid.Parse("51dc24ec-d8bf-426e-9897-61a127025545"),
             City = "Canchayllo",
             Country = "Palestinian Territory",
             CreatedDate = DateTime.Now,
             Province = "Canchayllo",
             Description = "Suite 26",
             AddressText = "04016 Eagan Trail",
             ZipCode = "59437",
             Longitude = 35.120362m,
             Latitude = 31.685608m,
         },

         new Address
         {
             Id = Guid.Parse("537f807c-6fc2-496f-a01f-ee23b456db5e"),
             City = "Horodok",
             Country = "Chad",
             CreatedDate = DateTime.Now,
             Province = "Horodok",
             Description = "9th Floor",
             AddressText = "05 Debra Hill",
             ZipCode = "63669",
             Longitude = 19.1107114m,
             Latitude = 17.9236623m,
         },

         new Address
         {
             Id = Guid.Parse("542646ea-5dc8-4b69-906c-f9a351a9b444"),
             City = "Gulod",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Gulod",
             Description = "Suite 11",
             AddressText = "19718 Lighthouse Bay Way",
             ZipCode = "8313",
             Longitude = 121.1325639m,
             Latitude = 14.5640576m,
         },

         new Address
         {
             Id = Guid.Parse("5a02f8f1-3ee1-476b-a02a-f4a6e973993a"),
             City = "Kamieniec Wrocławski",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Kamieniec Wrocławski",
             Description = "PO Box 2402",
             AddressText = "322 Straubel Way",
             ZipCode = "618206",
             Longitude = 57.783316m,
             Latitude = 58.249304m,
         },

         new Address
         {
             Id = Guid.Parse("5aa52277-f819-4f56-a44e-fdf1d95db911"),
             City = "Dogarmo",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Dogarmo",
             Description = "Suite 19",
             AddressText = "2652 Portage Lane",
             ZipCode = "9650-015",
             Longitude = 25.1607541m,
             Latitude = 37.7616723m,
         },

         new Address
         {
             Id = Guid.Parse("5ae892f8-2f88-4b22-af31-c120533bcb06"),
             City = "Trindade",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Trindade",
             Description = "Suite 46",
             AddressText = "528 Sunfield Drive",
             ZipCode = "64651",
             Longitude = 113.696298m,
             Latitude = 30.777355m,
         },

         new Address
         {
             Id = Guid.Parse("5d062e93-d81d-4b38-824d-330f4dcfc3f7"),
             City = "Qixia",
             Country = "Kuwait",
             CreatedDate = DateTime.Now,
             Province = "Qixia",
             Description = "18th Floor",
             AddressText = "6 Marquette Parkway",
             ZipCode = "64312",
             Longitude = 48.079379m,
             Latitude = 29.2964866m,
         },

         new Address
         {
             Id = Guid.Parse("5e745049-a00e-4d8a-bdd6-9d62d6eca0c4"),
             City = "Kitcharao",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Kitcharao",
             Description = "PO Box 67149",
             AddressText = "44068 Red Cloud Point",
             ZipCode = "62914",
             Longitude = 118.9353968m,
             Latitude = 29.5530941m,
         },

         new Address
         {
             Id = Guid.Parse("62898a13-30e2-4ae2-8fc5-d3d83bcf8ba8"),
             City = "Fagersta",
             Country = "Canada",
             CreatedDate = DateTime.Now,
             Province = "Fagersta",
             Description = "Room 1803",
             AddressText = "5028 Pepper Wood Parkway",
             ZipCode = "S4A",
             Longitude = 83.66654m,
             Latitude = 49.68351m,
         },

         new Address
         {
             Id = Guid.Parse("62e99530-f94f-41b2-88ac-44876d28b8ef"),
             City = "Haymā’",
             Country = "Czech Republic",
             CreatedDate = DateTime.Now,
             Province = "Haymā’",
             Description = "Suite 66",
             AddressText = "8 Ohio Circle",
             ZipCode = "507 32",
             Longitude = 15.2702996m,
             Latitude = 50.3308509m,
         },

         new Address
         {
             Id = Guid.Parse("67811665-9c99-459e-a52e-516e984da037"),
             City = "Fort Worth",
             Country = "Japan",
             CreatedDate = DateTime.Now,
             Province = "Fort Worth",
             Description = "PO Box 70975",
             AddressText = "97 Roxbury Pass",
             ZipCode = "986-2344",
             Longitude = 141.4219969m,
             Latitude = 38.3508588m,
         },

         new Address
         {
             Id = Guid.Parse("6791823e-7eb4-4d05-b5c3-dc34f86ffcab"),
             City = "Kota Kinabalu",
             Country = "Bangladesh",
             CreatedDate = DateTime.Now,
             Province = "Kota Kinabalu",
             Description = "10th Floor",
             AddressText = "182 Northview Circle",
             ZipCode = "6680",
             Longitude = 89.61457m,
             Latitude = 24.076563m,
         },

         new Address
         {
             Id = Guid.Parse("69455ac8-557d-4af5-9409-51d72910e252"),
             City = "Xinbao",
             Country = "Sweden",
             CreatedDate = DateTime.Now,
             Province = "Xinbao",
             Description = "Suite 94",
             AddressText = "703 Arapahoe Crossing",
             ZipCode = "818 92",
             Longitude = 17.0082511m,
             Latitude = 60.6430311m,
         },

         new Address
         {
             Id = Guid.Parse("69e920c3-3654-453a-af1a-a5b7663b2069"),
             City = "Máncora",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Máncora",
             Description = "Apt 1943",
             AddressText = "01893 Donald Trail",
             ZipCode = "85950-000",
             Longitude = 53.7803147m,
             Latitude = 24.2570411m,
         },

         new Address
         {
             Id = Guid.Parse("6b5b43a5-0837-437e-b06b-1d8b911bc218"),
             City = "Chābahār",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Chābahār",
             Description = "PO Box 82229",
             AddressText = "17 Sugar Plaza",
             ZipCode = "2333",
             Longitude = 121.047062m,
             Latitude = 14.5586303m,
         },

         new Address
         {
             Id = Guid.Parse("6bcb42a6-6a58-4595-aeab-8396284c6a17"),
             City = "Gabasumdo",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Gabasumdo",
             Description = "Apt 1998",
             AddressText = "747 Nevada Point",
             ZipCode = "63521",
             Longitude = 110.363649m,
             Latitude = 7.783297m,
         },

         new Address
         {
             Id = Guid.Parse("6fa38310-f481-448c-af90-8e8e4f8d6e1b"),
             City = "Qiaobian",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Qiaobian",
             Description = "17th Floor",
             AddressText = "541 Merrick Place",
             ZipCode = "55153",
             Longitude = 113.1029629m,
             Latitude = 39.8116909m,
         },

         new Address
         {
             Id = Guid.Parse("71778327-c312-4ffe-a4a5-31ae788dedb7"),
             City = "Birni N Konni",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Birni N Konni",
             Description = "Suite 90",
             AddressText = "088 Sunbrook Point",
             ZipCode = "57232",
             Longitude = 107.752611m,
             Latitude = 28.39571m,
         },

         new Address
         {
             Id = Guid.Parse("757d48cd-6c16-4b22-83bb-2981797544c4"),
             City = "München",
             Country = "Hungary",
             CreatedDate = DateTime.Now,
             Province = "München",
             Description = "Apt 1308",
             AddressText = "981 Saint Paul Alley",
             ZipCode = "9704",
             Longitude = 17.7845904m,
             Latitude = 46.3743832m,
         },

         new Address
         {
             Id = Guid.Parse("79c61139-a3a0-466f-98a8-5e3c8bf9c639"),
             City = "Yeysk",
             Country = "Egypt",
             CreatedDate = DateTime.Now,
             Province = "Yeysk",
             Description = "Room 1367",
             AddressText = "150 Maryland Lane",
             ZipCode = "55874",
             Longitude = 31.1252135m,
             Latitude = 31.4292388m,
         },

         new Address
         {
             Id = Guid.Parse("7f744e80-7615-46ee-85d6-f650a5dfd7d1"),
             City = "Täby",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Täby",
             Description = "Apt 856",
             AddressText = "07 Northport Parkway",
             ZipCode = "61821",
             Longitude = 106.0169971m,
             Latitude = 20.8525711m,
         },

         new Address
         {
             Id = Guid.Parse("81055bbc-6552-45fd-877a-d7f1a6f9a00e"),
             City = "Popovi",
             Country = "Sweden",
             CreatedDate = DateTime.Now,
             Province = "Popovi",
             Description = "Room 1336",
             AddressText = "2645 Coleman Street",
             ZipCode = "101 37",
             Longitude = 18.056792m,
             Latitude = 59.3326658m,
         },

         new Address
         {
             Id = Guid.Parse("817f5b4e-9812-4f56-9bee-0c08700a7352"),
             City = "Capâo Bonito",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Capâo Bonito",
             Description = "Suite 83",
             AddressText = "9006 Maywood Junction",
             ZipCode = "3003",
             Longitude = 120.7906666m,
             Latitude = 14.8835125m,
         },

         new Address
         {
             Id = Guid.Parse("81f7705b-70e1-467a-aa47-f18130e03b39"),
             City = "Jinsha",
             Country = "Cambodia",
             CreatedDate = DateTime.Now,
             Province = "Jinsha",
             Description = "19th Floor",
             AddressText = "5 Mariners Cove Parkway",
             ZipCode = "62826",
             Longitude = 105.8290298m,
             Latitude = 11.142722m,
         },

         new Address
         {
             Id = Guid.Parse("84141d53-c4cc-49be-86a1-04992c0ec1fd"),
             City = "Cantoria",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Cantoria",
             Description = "Room 50",
             AddressText = "9157 Lake View Center",
             ZipCode = "75480-000",
             Longitude = 49.3247147m,
             Latitude = 16.115743m,
         },

         new Address
         {
             Id = Guid.Parse("86297851-0110-4eab-8bec-8bfcb462c65f"),
             City = "Kawasaki",
             Country = "Poland",
             CreatedDate = DateTime.Now,
             Province = "Kawasaki",
             Description = "Room 1109",
             AddressText = "987 Burrows Lane",
             ZipCode = "98-105",
             Longitude = 19.1490758m,
             Latitude = 51.718833m,
         },

         new Address
         {
             Id = Guid.Parse("864db008-67ba-4bc5-b96e-258f0ffa4e16"),
             City = "Kolomanu",
             Country = "United States",
             CreatedDate = DateTime.Now,
             Province = "Kolomanu",
             Description = "Suite 59",
             AddressText = "76 Victoria Crossing",
             ZipCode = "40205",
             Longitude = 85.6794434m,
             Latitude = 38.2214782m,
         },

         new Address
         {
             Id = Guid.Parse("898edfcd-47bc-4788-be5e-191b2efcdc09"),
             City = "Machang",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Machang",
             Description = "Suite 64",
             AddressText = "209 Oakridge Trail",
             ZipCode = "60128",
             Longitude = 118.6422409m,
             Latitude = 24.9372186m,
         },

         new Address
         {
             Id = Guid.Parse("8cb517bb-9bd2-48f5-b18f-e480c9d25bea"),
             City = "Živinice",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Živinice",
             Description = "3rd Floor",
             AddressText = "79386 Stang Hill",
             ZipCode = "57190",
             Longitude = 106.8738909m,
             Latitude = 6.8497345m,
         },

         new Address
         {
             Id = Guid.Parse("8eb72077-2a86-4b9d-9a29-5c894b22c3fe"),
             City = "Saint-Priest-en-Jarez",
             Country = "Croatia",
             CreatedDate = DateTime.Now,
             Province = "Saint-Priest-en-Jarez",
             Description = "7th Floor",
             AddressText = "0 Browning Plaza",
             ZipCode = "49218",
             Longitude = 15.7509093m,
             Latitude = 46.1649072m,
         },

         new Address
         {
             Id = Guid.Parse("8f506ef0-dcb1-4118-bc6a-67d21b409876"),
             City = "San Miguel",
             Country = "Czech Republic",
             CreatedDate = DateTime.Now,
             Province = "San Miguel",
             Description = "Suite 61",
             AddressText = "003 Del Sol Park",
             ZipCode = "281 44",
             Longitude = 15.0305859m,
             Latitude = 49.954706m,
         },

         new Address
         {
             Id = Guid.Parse("8fdf671b-cc88-4d3a-962b-29debd0487cd"),
             City = "Progreso",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Progreso",
             Description = "Room 1519",
             AddressText = "2533 Gulseth Street",
             ZipCode = "64097",
             Longitude = 115.955191m,
             Latitude = 22.814304m,
         },

         new Address
         {
             Id = Guid.Parse("93b6a176-7f67-4783-8381-6977b709f342"),
             City = "Dalong",
             Country = "Greece",
             CreatedDate = DateTime.Now,
             Province = "Dalong",
             Description = "Apt 1365",
             AddressText = "01 Hansons Avenue",
             ZipCode = "62488",
             Longitude = 24.4173321m,
             Latitude = 37.3933984m,
         },

         new Address
         {
             Id = Guid.Parse("9769802f-564e-4560-ac72-580b73a76405"),
             City = "Inazawa",
             Country = "Germany",
             CreatedDate = DateTime.Now,
             Province = "Inazawa",
             Description = "Room 668",
             AddressText = "31446 Summit Park",
             ZipCode = "9123",
             Longitude = 12.8945945m,
             Latitude = 50.7868675m,
         },

         new Address
         {
             Id = Guid.Parse("99bdf581-646d-4635-b7ec-1c85ae21caf5"),
             City = "Poponcol",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Poponcol",
             Description = "Apt 38",
             AddressText = "93249 Sutherland Street",
             ZipCode = "59472",
             Longitude = 108.6877976m,
             Latitude = 13.1956813m,
         },

         new Address
         {
             Id = Guid.Parse("9fc2ffac-797c-41aa-80dc-8ada4b5e3268"),
             City = "Parakanpanjang",
             Country = "Haiti",
             CreatedDate = DateTime.Now,
             Province = "Parakanpanjang",
             Description = "4th Floor",
             AddressText = "039 Texas Pass",
             ZipCode = "64789",
             Longitude = 72.8663173m,
             Latitude = 18.8340566m,
         },

         new Address
         {
             Id = Guid.Parse("a0bffa02-bb8c-45ab-9e98-f088741f63f5"),
             City = "Bayt ‘Adhāqah",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Bayt ‘Adhāqah",
             Description = "Apt 1254",
             AddressText = "084 Lukken Point",
             ZipCode = "678350",
             Longitude = 131.152863m,
             Latitude = 62.679165m,
         },

         new Address
         {
             Id = Guid.Parse("a5b5b248-fb20-4859-a017-da8ebfaabc2d"),
             City = "Ourentã",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Ourentã",
             Description = "20th Floor",
             AddressText = "98 Dunning Trail",
             ZipCode = "352552",
             Longitude = 40.6203439m,
             Latitude = 44.3204868m,
         },

         new Address
         {
             Id = Guid.Parse("ac4b9936-4cec-4add-a0d0-3cb3506c8e50"),
             City = "Bergen op Zoom",
             Country = "Sweden",
             CreatedDate = DateTime.Now,
             Province = "Bergen op Zoom",
             Description = "PO Box 46853",
             AddressText = "4560 Stang Point",
             ZipCode = "590 73",
             Longitude = 15.5029738m,
             Latitude = 58.4922889m,
         },

         new Address
         {
             Id = Guid.Parse("b1644ebb-604e-4d65-b29a-bbf58d78eba8"),
             City = "Huangtan",
             Country = "Uruguay",
             CreatedDate = DateTime.Now,
             Province = "Huangtan",
             Description = "Apt 1670",
             AddressText = "53731 Cody Drive",
             ZipCode = "60545",
             Longitude = 55.6287206m,
             Latitude = 34.4867748m,
         },

         new Address
         {
             Id = Guid.Parse("b1f94972-6da9-4b98-8baa-f0222dc5722a"),
             City = "Al Ghayl",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Al Ghayl",
             Description = "Room 1710",
             AddressText = "76763 Welch Park",
             ZipCode = "4700-837",
             Longitude = 8.4638232m,
             Latitude = 41.5823573m,
         },

         new Address
         {
             Id = Guid.Parse("b3428fc3-470c-4f3e-b3a3-4bd768807cc0"),
             City = "Kirgili",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Kirgili",
             Description = "Room 12",
             AddressText = "0303 Maple Wood Parkway",
             ZipCode = "57120",
             Longitude = 113.778639m,
             Latitude = 26.480043m,
         },

         new Address
         {
             Id = Guid.Parse("b4078667-3951-4c38-9b8a-636d7088c746"),
             City = "Dipayal",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Dipayal",
             Description = "Room 735",
             AddressText = "4668 Memorial Place",
             ZipCode = "58945",
             Longitude = 119.6364468m,
             Latitude = 29.1082924m,
         },

         new Address
         {
             Id = Guid.Parse("bb3b70c2-d2a0-49fe-a5c9-5e90cf2d31e9"),
             City = "Burgas",
             Country = "Thailand",
             CreatedDate = DateTime.Now,
             Province = "Burgas",
             Description = "Apt 1431",
             AddressText = "34 Bartelt Parkway",
             ZipCode = "74120",
             Longitude = 100.1031202m,
             Latitude = 13.5924758m,
         },

         new Address
         {
             Id = Guid.Parse("c41a8995-b0f6-4138-8646-aa74ab98ddfe"),
             City = "Sobreira",
             Country = "Guatemala",
             CreatedDate = DateTime.Now,
             Province = "Sobreira",
             Description = "Suite 100",
             AddressText = "33857 Hagan Place",
             ZipCode = "9015",
             Longitude = 91.6341489m,
             Latitude = 15.0690612m,
         },

         new Address
         {
             Id = Guid.Parse("c7128d7f-9621-42e2-bb42-40c91615e13e"),
             City = "Donghe",
             Country = "South Korea",
             CreatedDate = DateTime.Now,
             Province = "Donghe",
             Description = "Suite 96",
             AddressText = "38 Fairview Way",
             ZipCode = "58034",
             Longitude = 128.2989526m,
             Latitude = 36.2429169m,
         },

         new Address
         {
             Id = Guid.Parse("c8802699-b296-4f27-a07e-7e82eb6727cc"),
             City = "Argentan",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Argentan",
             Description = "15th Floor",
             AddressText = "393 Thackeray Court",
             ZipCode = "2860-010",
             Longitude = 9.0096184m,
             Latitude = 38.6559826m,
         },

         new Address
         {
             Id = Guid.Parse("caa0eea6-8ebe-47ea-bdbd-222e4cee5d9a"),
             City = "Fratar",
             Country = "Ecuador",
             CreatedDate = DateTime.Now,
             Province = "Fratar",
             Description = "Apt 1807",
             AddressText = "2 Sage Lane",
             ZipCode = "64029",
             Longitude = 79.4366324m,
             Latitude = 2.176347m,
         },

         new Address
         {
             Id = Guid.Parse("cb810fe1-9ea5-49f2-afac-8860fc8911a6"),
             City = "Negotino",
             Country = "United States",
             CreatedDate = DateTime.Now,
             Province = "Negotino",
             Description = "Apt 1619",
             AddressText = "78073 Pawling Parkway",
             ZipCode = "48912",
             Longitude = 84.5169757m,
             Latitude = 42.7376689m,
         },

         new Address
         {
             Id = Guid.Parse("cedf3806-2a44-44b1-bce0-4e1e05319d00"),
             City = "Plumbon",
             Country = "Mongolia",
             CreatedDate = DateTime.Now,
             Province = "Plumbon",
             Description = "PO Box 66997",
             AddressText = "12 Kropf Point",
             ZipCode = "63466",
             Longitude = 101.7525358m,
             Latitude = 47.4389969m,
         },

         new Address
         {
             Id = Guid.Parse("d2c239ad-fc52-47b4-870e-9a58d134e69e"),
             City = "Messina",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Messina",
             Description = "11th Floor",
             AddressText = "0 Commercial Lane",
             ZipCode = "64078",
             Longitude = 111.6124134m,
             Latitude = 6.8952768m,
         },

         new Address
         {
             Id = Guid.Parse("d3868b3e-8cda-493a-a08b-c80a02d327d6"),
             City = "Ojo de Agua",
             Country = "Yemen",
             CreatedDate = DateTime.Now,
             Province = "Ojo de Agua",
             Description = "Suite 56",
             AddressText = "09622 Golf Road",
             ZipCode = "59732",
             Longitude = 43.9436788m,
             Latitude = 16.2569214m,
         },

         new Address
         {
             Id = Guid.Parse("d6cf8692-ca3e-4e7a-a2f1-00e946716cad"),
             City = "Huangxi",
             Country = "Burkina Faso",
             CreatedDate = DateTime.Now,
             Province = "Huangxi",
             Description = "Room 793",
             AddressText = "95792 Crownhardt Alley",
             ZipCode = "62048",
             Longitude = 4.9091329m,
             Latitude = 10.9808313m,
         },

         new Address
         {
             Id = Guid.Parse("d7291aa8-3b54-4fd3-b0dd-df93a873af10"),
             City = "Washington",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Washington",
             Description = "Room 1250",
             AddressText = "60 New Castle Alley",
             ZipCode = "57680",
             Longitude = 120.088953m,
             Latitude = 27.478357m,
         },

         new Address
         {
             Id = Guid.Parse("dc4850b4-554b-4878-8af5-48488d8d9d65"),
             City = "Umeå",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Umeå",
             Description = "Room 1033",
             AddressText = "582 Ohio Street",
             ZipCode = "55277",
             Longitude = 107.7710234m,
             Latitude = 7.258661m,
         },

         new Address
         {
             Id = Guid.Parse("dd6c4688-c2d5-488e-b0a4-5871ba989b54"),
             City = "Dukuh Kaler",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Dukuh Kaler",
             Description = "PO Box 74645",
             AddressText = "04275 Anzinger Trail",
             ZipCode = "652250",
             Longitude = 88.6780253m,
             Latitude = 56.0764809m,
         },

         new Address
         {
             Id = Guid.Parse("ddaebdde-84c9-4405-9515-1038152c583e"),
             City = "Xinquan",
             Country = "Belarus",
             CreatedDate = DateTime.Now,
             Province = "Xinquan",
             Description = "Apt 1015",
             AddressText = "9 Carberry Pass",
             ZipCode = "64497",
             Longitude = 27.5393261m,
             Latitude = 53.905048m,
         },

         new Address
         {
             Id = Guid.Parse("def2e733-1424-43f0-b6bd-a5b919d5b136"),
             City = "Buzen",
             Country = "Thailand",
             CreatedDate = DateTime.Now,
             Province = "Buzen",
             Description = "Room 1915",
             AddressText = "8 Drewry Drive",
             ZipCode = "31120",
             Longitude = 103.0241726m,
             Latitude = 15.5678638m,
         },

         new Address
         {
             Id = Guid.Parse("e4128b3d-61e8-4c90-a074-4b8526f7d69b"),
             City = "Ashcroft",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Ashcroft",
             Description = "Room 669",
             AddressText = "458 Reinke Pass",
             ZipCode = "56397",
             Longitude = 115.717179m,
             Latitude = 25.627549m,
         },

         new Address
         {
             Id = Guid.Parse("e4f9808a-f0c7-4b4d-b871-c463f1eabb74"),
             City = "Potiskum",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Potiskum",
             Description = "Apt 522",
             AddressText = "71316 Colorado Terrace",
             ZipCode = "63591",
             Longitude = 108.7303974m,
             Latitude = 7.6617749m,
         },

         new Address
         {
             Id = Guid.Parse("e6ef7275-7641-4c52-84f8-d0edc480ed3f"),
             City = "Molde",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Molde",
             Description = "PO Box 81129",
             AddressText = "31124 Bayside Point",
             ZipCode = "55409",
             Longitude = 115.614437m,
             Latitude = 25.487867m,
         },

         new Address
         {
             Id = Guid.Parse("ea96345a-01c3-4cdb-8fc3-0fad4833bb2f"),
             City = "Libao",
             Country = "Ukraine",
             CreatedDate = DateTime.Now,
             Province = "Libao",
             Description = "Suite 60",
             AddressText = "61 Morningstar Center",
             ZipCode = "57125",
             Longitude = 34.3179269m,
             Latitude = 45.0543662m,
         },

         new Address
         {
             Id = Guid.Parse("edf465c3-2e42-4c6e-8281-822d9505d30f"),
             City = "Sali",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Sali",
             Description = "Room 280",
             AddressText = "61 Dwight Terrace",
             ZipCode = "4690-711",
             Longitude = 8.1697329m,
             Latitude = 41.0032627m,
         },

         new Address
         {
             Id = Guid.Parse("f3f745b5-98c8-4016-888b-1625db7666f5"),
             City = "Wailiang",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Wailiang",
             Description = "6th Floor",
             AddressText = "54661 Mitchell Hill",
             ZipCode = "63604",
             Longitude = 106.7057733m,
             Latitude = 6.2057964m,
         },

         new Address
         {
             Id = Guid.Parse("f4935e2d-ea1e-4c65-8ff7-791dd9d8ed22"),
             City = "Hengjiang",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Hengjiang",
             Description = "Apt 1502",
             AddressText = "511 Cherokee Place",
             ZipCode = "62808",
             Longitude = 115.519278m,
             Latitude = 38.234501m,
         },

         new Address
         {
             Id = Guid.Parse("ff7a7c2d-b5d6-4035-acff-b2bf5ecc5f4a"),
             City = "Pisarzowice",
             Country = "Belarus",
             CreatedDate = DateTime.Now,
             Province = "Pisarzowice",
             Description = "Room 703",
             AddressText = "87049 Myrtle Terrace",
             ZipCode = "58772",
             Longitude = 27.6842905m,
             Latitude = 55.1391321m,
         },

         new Address
         {
             Id = Guid.Parse("02b5a9a5-8b9b-4d38-b1f7-b587811d6a6c"),
             City = "Vendychany",
             Country = "Ukraine",
             CreatedDate = DateTime.Now,
             Province = "Vendychany",
             Description = "Room 1412",
             AddressText = "8702 Del Mar Point",
             ZipCode = "35027",
             Longitude = 27.8023025m,
             Latitude = 48.6184003m,
         },

         new Address
         {
             Id = Guid.Parse("035732c9-a7b4-4448-8eeb-6fea7ea88a7f"),
             City = "Torez",
             Country = "Ukraine",
             CreatedDate = DateTime.Now,
             Province = "Torez",
             Description = "1st Floor",
             AddressText = "74001 Lotheville Avenue",
             ZipCode = "56239",
             Longitude = 38.6545257m,
             Latitude = 48.0201627m,
         },

         new Address
         {
             Id = Guid.Parse("03778aff-6f9f-46d9-99ff-ad3b36395cd6"),
             City = "Yangzhong",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Yangzhong",
             Description = "5th Floor",
             AddressText = "6506 Aberg Street",
             ZipCode = "22110",
             Longitude = 119.797634m,
             Latitude = 32.23483m,
         },

         new Address
         {
             Id = Guid.Parse("05243ef3-3f01-44b2-b175-52fffb36ec63"),
             City = "Xinyu",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Xinyu",
             Description = "Room 174",
             AddressText = "8 Bayside Lane",
             ZipCode = "69208",
             Longitude = 114.917346m,
             Latitude = 27.817808m,
         },

         new Address
         {
             Id = Guid.Parse("059ad44e-afb8-4a16-b7ba-2176fc83c8f2"),
             City = "Cái Nhum",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Cái Nhum",
             Description = "Room 123",
             AddressText = "0 Merrick Pass",
             ZipCode = "38659",
             Longitude = 106.1125201m,
             Latitude = 10.1775604m,
         },

         new Address
         {
             Id = Guid.Parse("066d13b3-a3ae-487a-bd7f-b9abe43fd9f0"),
             City = "Ibagué",
             Country = "Colombia",
             CreatedDate = DateTime.Now,
             Province = "Ibagué",
             Description = "Suite 45",
             AddressText = "92 Vernon Point",
             ZipCode = "76980",
             Longitude = 75.2245693m,
             Latitude = 4.5120691m,
         },

         new Address
         {
             Id = Guid.Parse("086eb164-baa8-4fc4-b101-1ffa00d8ed72"),
             City = "Don Mueang",
             Country = "Thailand",
             CreatedDate = DateTime.Now,
             Province = "Don Mueang",
             Description = "Apt 999",
             AddressText = "0 Gulseth Junction",
             ZipCode = "14734",
             Longitude = 100.5635071m,
             Latitude = 13.8513777m,
         },

         new Address
         {
             Id = Guid.Parse("0b4e3c7b-07df-4b0e-8671-a019a088ffb8"),
             City = "Daying",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Daying",
             Description = "PO Box 23045",
             AddressText = "89245 Pine View Court",
             ZipCode = "22141",
             Longitude = 105.236903m,
             Latitude = 30.594336m,
         },

         new Address
         {
             Id = Guid.Parse("0c6417b5-c72a-44e5-8212-bb63793eef13"),
             City = "Porto Alto",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Porto Alto",
             Description = "PO Box 40618",
             AddressText = "997 Arrowood Alley",
             ZipCode = "63904",
             Longitude = 8.8779873m,
             Latitude = 38.919391m,
         },

         new Address
         {
             Id = Guid.Parse("0de5db77-7827-4c3e-9c59-de33f222e53d"),
             City = "Quatro Barras",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Quatro Barras",
             Description = "Apt 1663",
             AddressText = "97130 Oneill Crossing",
             ZipCode = "80190",
             Longitude = 49.0801588m,
             Latitude = 25.3631459m,
         },

         new Address
         {
             Id = Guid.Parse("0df24069-09b8-4f38-a0a7-c59443ebcf57"),
             City = "Mungo",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Mungo",
             Description = "PO Box 33509",
             AddressText = "0 Bobwhite Road",
             ZipCode = "32542",
             Longitude = 121.4674111m,
             Latitude = 17.7302207m,
         },

         new Address
         {
             Id = Guid.Parse("0e9d2926-6841-41f2-a7e7-95e67b5f402b"),
             City = "Sarandë",
             Country = "Albania",
             CreatedDate = DateTime.Now,
             Province = "Sarandë",
             Description = "Suite 74",
             AddressText = "583 Melby Crossing",
             ZipCode = "24398",
             Longitude = 20.0271001m,
             Latitude = 39.8592119m,
         },

         new Address
         {
             Id = Guid.Parse("0ecdfa73-ff3f-4cf6-9d41-5c3580d2b24b"),
             City = "Praia de Mira",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Praia de Mira",
             Description = "Room 875",
             AddressText = "75834 Derek Point",
             ZipCode = "28855",
             Longitude = 8.8018715m,
             Latitude = 40.4583824m,
         },

         new Address
         {
             Id = Guid.Parse("0f4c6282-8989-48a4-ae1c-a4470379740d"),
             City = "Ninh Giang",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Ninh Giang",
             Description = "3rd Floor",
             AddressText = "2 Gulseth Plaza",
             ZipCode = "65481",
             Longitude = 106.3699271m,
             Latitude = 20.7491091m,
         },

         new Address
         {
             Id = Guid.Parse("10027d12-be14-47e2-b2a7-cb98d0d28708"),
             City = "Tangzang",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Tangzang",
             Description = "16th Floor",
             AddressText = "94 Corben Lane",
             ZipCode = "51999",
             Longitude = 106.585112m,
             Latitude = 34.08611m,
         },

         new Address
         {
             Id = Guid.Parse("119d3da8-0b7f-497f-856a-49f337c2e314"),
             City = "Nurmo",
             Country = "Finland",
             CreatedDate = DateTime.Now,
             Province = "Nurmo",
             Description = "Suite 8",
             AddressText = "12 Mcguire Hill",
             ZipCode = "13867",
             Longitude = 22.910026m,
             Latitude = 62.8291624m,
         },

         new Address
         {
             Id = Guid.Parse("12205437-39e6-415a-b99f-f5cd06c13f64"),
             City = "Liuji",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Liuji",
             Description = "Apt 1120",
             AddressText = "2601 Columbus Terrace",
             ZipCode = "74292",
             Longitude = 112.228897m,
             Latitude = 32.460037m,
         },

         new Address
         {
             Id = Guid.Parse("1243a0a9-82ca-4fab-840b-add93489c99d"),
             City = "Modřice",
             Country = "Czech Republic",
             CreatedDate = DateTime.Now,
             Province = "Modřice",
             Description = "Apt 678",
             AddressText = "57240 Fulton Hill",
             ZipCode = "31932",
             Longitude = 16.613233m,
             Latitude = 49.1278721m,
         },

         new Address
         {
             Id = Guid.Parse("13e035a8-646c-4636-9d50-f565603c7fb9"),
             City = "Lilio",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Lilio",
             Description = "Suite 16",
             AddressText = "65 Butternut Junction",
             ZipCode = "53958",
             Longitude = 123.4102597m,
             Latitude = 9.3172545m,
         },

         new Address
         {
             Id = Guid.Parse("1a28eec4-809c-46c8-b66a-7f6d8efd1645"),
             City = "Pyshchug",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Pyshchug",
             Description = "Room 573",
             AddressText = "185 Evergreen Street",
             ZipCode = "49001",
             Longitude = 45.709456m,
             Latitude = 58.8882592m,
         },

         new Address
         {
             Id = Guid.Parse("1d8921e8-66df-4d4a-accf-96be57a51435"),
             City = "Arendal",
             Country = "Norway",
             CreatedDate = DateTime.Now,
             Province = "Arendal",
             Description = "Suite 35",
             AddressText = "46998 Anzinger Point",
             ZipCode = "40343",
             Longitude = 8.7649767m,
             Latitude = 58.4603072m,
         },

         new Address
         {
             Id = Guid.Parse("1d9d4a05-90d2-4a48-85cb-19d635ae9df2"),
             City = "Iwata",
             Country = "Japan",
             CreatedDate = DateTime.Now,
             Province = "Iwata",
             Description = "Suite 43",
             AddressText = "3815 Magdeline Street",
             ZipCode = "80865",
             Longitude = 136.7851365m,
             Latitude = 36.9692865m,
         },

         new Address
         {
             Id = Guid.Parse("20ab905a-49b2-4c7f-a1a2-ae097171ae9f"),
             City = "Lühua",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Lühua",
             Description = "Room 1502",
             AddressText = "174 Rusk Avenue",
             ZipCode = "37096",
             Longitude = 106.186518m,
             Latitude = 38.577099m,
         },

         new Address
         {
             Id = Guid.Parse("20f1b2a7-166e-4f8e-b157-8073547560b1"),
             City = "Goiatuba",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Goiatuba",
             Description = "PO Box 86543",
             AddressText = "891 Maywood Road",
             ZipCode = "34907",
             Longitude = 49.6503106m,
             Latitude = 17.9659326m,
         },

         new Address
         {
             Id = Guid.Parse("22189e4e-9c1e-4c43-bd78-73c04fd53602"),
             City = "Beima",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Beima",
             Description = "Room 1523",
             AddressText = "32 Lake View Street",
             ZipCode = "32582",
             Longitude = 120.395988m,
             Latitude = 37.617937m,
         },

         new Address
         {
             Id = Guid.Parse("2365666d-a4e0-43b8-bc35-ccb58dc2b994"),
             City = "Ludvika",
             Country = "Sweden",
             CreatedDate = DateTime.Now,
             Province = "Ludvika",
             Description = "5th Floor",
             AddressText = "3037 Milwaukee Avenue",
             ZipCode = "65003",
             Longitude = 15.0265478m,
             Latitude = 60.0785015m,
         },

         new Address
         {
             Id = Guid.Parse("25130799-eb2a-4fc1-874a-4bb514f7fa1f"),
             City = "San Francisco",
             Country = "Argentina",
             CreatedDate = DateTime.Now,
             Province = "San Francisco",
             Description = "PO Box 67420",
             AddressText = "789 Westridge Plaza",
             ZipCode = "23828",
             Longitude = 58.4103552m,
             Latitude = 34.7932249m,
         },

         new Address
         {
             Id = Guid.Parse("25fc9069-eeef-436d-946d-6038c4c51056"),
             City = "Urrô",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Urrô",
             Description = "Apt 194",
             AddressText = "39 Fuller Pass",
             ZipCode = "45840",
             Longitude = 8.330057m,
             Latitude = 41.1897615m,
         },

         new Address
         {
             Id = Guid.Parse("2635f54a-74c5-4b3a-b25d-daa65a13abec"),
             City = "Fu’an",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Fu’an",
             Description = "20th Floor",
             AddressText = "76731 Shoshone Drive",
             ZipCode = "22269",
             Longitude = 119.647769m,
             Latitude = 27.088049m,
         },

         new Address
         {
             Id = Guid.Parse("26dab0ea-03bc-4f7e-98c7-3f36799e94f7"),
             City = "Offa",
             Country = "Nigeria",
             CreatedDate = DateTime.Now,
             Province = "Offa",
             Description = "Suite 100",
             AddressText = "4 Glendale Trail",
             ZipCode = "32630",
             Longitude = 4.7174062m,
             Latitude = 8.1393408m,
         },

         new Address
         {
             Id = Guid.Parse("2875143e-a928-4d5a-b583-cd735a15b9c1"),
             City = "Mikulčice",
             Country = "Czech Republic",
             CreatedDate = DateTime.Now,
             Province = "Mikulčice",
             Description = "Room 74",
             AddressText = "63 Elka Hill",
             ZipCode = "53618",
             Longitude = 17.0510711m,
             Latitude = 48.8164264m,
         },

         new Address
         {
             Id = Guid.Parse("2aec1230-da06-4dc4-a632-308317c37e59"),
             City = "Massaranduba",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Massaranduba",
             Description = "Apt 340",
             AddressText = "2 Norway Maple Way",
             ZipCode = "49176",
             Longitude = 49.0075714m,
             Latitude = 26.6119534m,
         },

         new Address
         {
             Id = Guid.Parse("2b3bc27d-e9f7-458e-af46-2c36d14f7185"),
             City = "La Unión",
             Country = "Peru",
             CreatedDate = DateTime.Now,
             Province = "La Unión",
             Description = "Apt 1598",
             AddressText = "0006 South Road",
             ZipCode = "69585",
             Longitude = 76.785759m,
             Latitude = 9.7744129m,
         },

         new Address
         {
             Id = Guid.Parse("2d2f4951-5b21-442d-a571-6c00977896c6"),
             City = "Obeliai",
             Country = "Lithuania",
             CreatedDate = DateTime.Now,
             Province = "Obeliai",
             Description = "Room 1966",
             AddressText = "440 Montana Terrace",
             ZipCode = "77315",
             Longitude = 25.15m,
             Latitude = 55.96667m,
         },

         new Address
         {
             Id = Guid.Parse("2db4c929-0877-40f2-99f2-7e23b77f537f"),
             City = "Lukashin",
             Country = "Armenia",
             CreatedDate = DateTime.Now,
             Province = "Lukashin",
             Description = "8th Floor",
             AddressText = "3 Heath Junction",
             ZipCode = "72264",
             Longitude = 44.0033056m,
             Latitude = 40.1851386m,
         },

         new Address
         {
             Id = Guid.Parse("2e0d8f8c-172b-480d-8239-32a18f646e4a"),
             City = "Žalec",
             Country = "Slovenia",
             CreatedDate = DateTime.Now,
             Province = "Žalec",
             Description = "Room 1127",
             AddressText = "4 Superior Way",
             ZipCode = "33638",
             Longitude = 15.1650282m,
             Latitude = 46.251984m,
         },

         new Address
         {
             Id = Guid.Parse("2e510420-5df0-4868-b86c-5241f0bc0a67"),
             City = "Madrid",
             Country = "Colombia",
             CreatedDate = DateTime.Now,
             Province = "Madrid",
             Description = "PO Box 80604",
             AddressText = "6696 Miller Place",
             ZipCode = "62927",
             Longitude = 74.2627569m,
             Latitude = 4.733779m,
         },

         new Address
         {
             Id = Guid.Parse("2fef7a01-4038-484f-8a21-0dbd3537ba4b"),
             City = "Fangyan",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Fangyan",
             Description = "14th Floor",
             AddressText = "90 Eliot Center",
             ZipCode = "46731",
             Longitude = 120.8214721m,
             Latitude = 27.9242858m,
         },

         new Address
         {
             Id = Guid.Parse("3073c063-2e5e-4648-8354-fde2a04b026c"),
             City = "Las Ánimas",
             Country = "Honduras",
             CreatedDate = DateTime.Now,
             Province = "Las Ánimas",
             Description = "19th Floor",
             AddressText = "443 Eagle Crest Pass",
             ZipCode = "43275",
             Longitude = 86.6069287m,
             Latitude = 14.2054868m,
         },

         new Address
         {
             Id = Guid.Parse("337b26f8-b78d-4432-abd0-d105270d7f0a"),
             City = "Banjar Dharmasemedi",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Banjar Dharmasemedi",
             Description = "Room 788",
             AddressText = "0 Sullivan Parkway",
             ZipCode = "43701",
             Longitude = 115.0596m,
             Latitude = 8.1462m,
         },

         new Address
         {
             Id = Guid.Parse("33ed845f-4bbd-407b-a211-b13a621255a2"),
             City = "Mazowe",
             Country = "Zimbabwe",
             CreatedDate = DateTime.Now,
             Province = "Mazowe",
             Description = "Apt 60",
             AddressText = "14 Bluestem Lane",
             ZipCode = "69513",
             Longitude = 30.9747258m,
             Latitude = 17.5069121m,
         },

         new Address
         {
             Id = Guid.Parse("34acdb49-d3cf-4f4d-b895-8b0bc36cef89"),
             City = "Pasirdalem",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Pasirdalem",
             Description = "Room 1652",
             AddressText = "57549 Bashford Trail",
             ZipCode = "73338",
             Longitude = 107.0687079m,
             Latitude = 7.2357344m,
         },

         new Address
         {
             Id = Guid.Parse("34c86aab-a097-49d6-831c-88509f3b9de9"),
             City = "Petropavlovsk",
             Country = "Kazakhstan",
             CreatedDate = DateTime.Now,
             Province = "Petropavlovsk",
             Description = "Apt 887",
             AddressText = "12356 Jenna Plaza",
             ZipCode = "79175",
             Longitude = 69.1505479m,
             Latitude = 54.8732209m,
         },

         new Address
         {
             Id = Guid.Parse("351f1ad8-3519-44aa-b7d5-24451a9d1260"),
             City = "Brisbane",
             Country = "Australia",
             CreatedDate = DateTime.Now,
             Province = "Brisbane",
             Description = "PO Box 80204",
             AddressText = "4284 Norway Maple Place",
             ZipCode = "39467",
             Longitude = 153.0251235m,
             Latitude = 27.4697707m,
         },

         new Address
         {
             Id = Guid.Parse("356c87ce-92cc-4a05-95ab-5db7af6596e8"),
             City = "Dongle",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Dongle",
             Description = "PO Box 96694",
             AddressText = "70841 Cordelia Road",
             ZipCode = "55507",
             Longitude = 84.520832m,
             Latitude = 30.736899m,
         },

         new Address
         {
             Id = Guid.Parse("357d0aaf-0b72-4675-b490-06707c5fecaf"),
             City = "Debeljača",
             Country = "Serbia",
             CreatedDate = DateTime.Now,
             Province = "Debeljača",
             Description = "Suite 66",
             AddressText = "2 Schmedeman Court",
             ZipCode = "57757",
             Longitude = 20.6338361m,
             Latitude = 45.0730425m,
         },

         new Address
         {
             Id = Guid.Parse("39351f4e-11eb-4c76-bed1-1d19bee3a851"),
             City = "Henghe",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Henghe",
             Description = "20th Floor",
             AddressText = "76613 Morrow Court",
             ZipCode = "33758",
             Longitude = 121.507191m,
             Latitude = 29.756501m,
         },

         new Address
         {
             Id = Guid.Parse("3970e6ee-1756-41a7-839b-db34376b5dff"),
             City = "Isniq",
             Country = "Kosovo",
             CreatedDate = DateTime.Now,
             Province = "Isniq",
             Description = "Room 331",
             AddressText = "6 Melrose Court",
             ZipCode = "55345",
             Longitude = 20.3027502m,
             Latitude = 42.5572675m,
         },

         new Address
         {
             Id = Guid.Parse("39b0e46e-e58f-40f9-a39e-7bba98f0b63b"),
             City = "Musan-ŭp",
             Country = "North Korea",
             CreatedDate = DateTime.Now,
             Province = "Musan-ŭp",
             Description = "Suite 1",
             AddressText = "251 Bartelt Circle",
             ZipCode = "74897",
             Longitude = 129.20776m,
             Latitude = 42.22609m,
         },

         new Address
         {
             Id = Guid.Parse("39c2b54f-5f57-482a-b1f3-58e5ea4d72a1"),
             City = "Plavy",
             Country = "Czech Republic",
             CreatedDate = DateTime.Now,
             Province = "Plavy",
             Description = "Suite 48",
             AddressText = "39399 Ruskin Place",
             ZipCode = "50378",
             Longitude = 15.3203304m,
             Latitude = 50.7054502m,
         },

         new Address
         {
             Id = Guid.Parse("3a057a58-cba4-4c8b-9b3d-3c2c6da962be"),
             City = "Karangasem",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Karangasem",
             Description = "PO Box 24736",
             AddressText = "13534 Coleman Alley",
             ZipCode = "46486",
             Longitude = 115.5207358m,
             Latitude = 8.3465933m,
         },

         new Address
         {
             Id = Guid.Parse("3a155d93-39c1-4d3f-8605-f461d9d6dab0"),
             City = "Fálanna",
             Country = "Greece",
             CreatedDate = DateTime.Now,
             Province = "Fálanna",
             Description = "PO Box 55134",
             AddressText = "14035 Grover Junction",
             ZipCode = "45192",
             Longitude = 22.3956933m,
             Latitude = 39.7219085m,
         },

         new Address
         {
             Id = Guid.Parse("3a2300f2-d261-4f8a-bada-292fb9c89b68"),
             City = "Karangtengah Lor",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Karangtengah Lor",
             Description = "6th Floor",
             AddressText = "15044 Menomonie Circle",
             ZipCode = "22709",
             Longitude = 106.7057733m,
             Latitude = 6.2057964m,
         },

         new Address
         {
             Id = Guid.Parse("3add312b-094f-479c-94a7-a465622b9eca"),
             City = "San Bernardino",
             Country = "Guatemala",
             CreatedDate = DateTime.Now,
             Province = "San Bernardino",
             Description = "Room 1915",
             AddressText = "63232 School Drive",
             ZipCode = "45486",
             Longitude = 91.4587127m,
             Latitude = 14.5427102m,
         },

         new Address
         {
             Id = Guid.Parse("40d22f52-d0f0-4b72-ae07-66a59cf46e4d"),
             City = "Nanxing",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Nanxing",
             Description = "1st Floor",
             AddressText = "45 Buena Vista Park",
             ZipCode = "77813",
             Longitude = 121.33638m,
             Latitude = 30.798775m,
         },

         new Address
         {
             Id = Guid.Parse("42542411-ee35-4625-8da0-f4dcffc907c2"),
             City = "Malonty",
             Country = "Czech Republic",
             CreatedDate = DateTime.Now,
             Province = "Malonty",
             Description = "Apt 1731",
             AddressText = "61 Debs Street",
             ZipCode = "13033",
             Longitude = 14.5775257m,
             Latitude = 48.6768262m,
         },

         new Address
         {
             Id = Guid.Parse("44193b9e-2e5b-4908-8466-bc6ac7cde10a"),
             City = "San Martín de los Andes",
             Country = "Argentina",
             CreatedDate = DateTime.Now,
             Province = "San Martín de los Andes",
             Description = "5th Floor",
             AddressText = "2612 Sachs Street",
             ZipCode = "47665",
             Longitude = 71.3377934m,
             Latitude = 40.1500467m,
         },

         new Address
         {
             Id = Guid.Parse("443b1ac8-1618-4667-b7a7-bca06be7df7c"),
             City = "Ngasinan",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Ngasinan",
             Description = "Room 1347",
             AddressText = "3 Hallows Lane",
             ZipCode = "26887",
             Longitude = 111.4723041m,
             Latitude = 7.9620331m,
         },

         new Address
         {
             Id = Guid.Parse("44bf4feb-4559-4a83-828c-c093f4965633"),
             City = "Kaiapoi",
             Country = "New Zealand",
             CreatedDate = DateTime.Now,
             Province = "Kaiapoi",
             Description = "PO Box 14663",
             AddressText = "78 Scofield Parkway",
             ZipCode = "52904",
             Longitude = 172.6519706m,
             Latitude = 43.417615m,
         },

         new Address
         {
             Id = Guid.Parse("45824f7b-76aa-43df-bee1-8479e998ede1"),
             City = "Liutan",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Liutan",
             Description = "Room 1154",
             AddressText = "2684 Elmside Street",
             ZipCode = "75144",
             Longitude = 114.404754m,
             Latitude = 15.488092m,
         },

         new Address
         {
             Id = Guid.Parse("45c71c07-f6e6-4d98-ae83-37cc40ff375b"),
             City = "Barajevo",
             Country = "Serbia",
             CreatedDate = DateTime.Now,
             Province = "Barajevo",
             Description = "Room 240",
             AddressText = "9049 Brown Trail",
             ZipCode = "48770",
             Longitude = 20.45241m,
             Latitude = 44.6034915m,
         },

         new Address
         {
             Id = Guid.Parse("476ca697-e730-497f-81db-cacffe59aad0"),
             City = "Almere Haven",
             Country = "Netherlands",
             CreatedDate = DateTime.Now,
             Province = "Almere Haven",
             Description = "9th Floor",
             AddressText = "777 7th Court",
             ZipCode = "35533",
             Longitude = 5.2172366m,
             Latitude = 52.3382178m,
         },

         new Address
         {
             Id = Guid.Parse("479668ab-709e-4ae0-9514-407c7c74882a"),
             City = "Yongning",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Yongning",
             Description = "13th Floor",
             AddressText = "133 Grayhawk Plaza",
             ZipCode = "51040",
             Longitude = 108.487368m,
             Latitude = 22.75839m,
         },

         new Address
         {
             Id = Guid.Parse("49291ab9-9d2b-4c3f-8d34-d9781914f65f"),
             City = "Runaway Bay",
             Country = "Jamaica",
             CreatedDate = DateTime.Now,
             Province = "Runaway Bay",
             Description = "Suite 19",
             AddressText = "2041 Lakewood Gardens Pass",
             ZipCode = "48904",
             Longitude = 77.3266991m,
             Latitude = 18.4562829m,
         },

         new Address
         {
             Id = Guid.Parse("4af64231-8870-48c5-9352-4be1e68442be"),
             City = "Mtsensk",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Mtsensk",
             Description = "Room 1737",
             AddressText = "9 International Alley",
             ZipCode = "32126",
             Longitude = 36.5904759m,
             Latitude = 53.286578m,
         },

         new Address
         {
             Id = Guid.Parse("4b0dac15-1ef2-4c6e-b332-8bd227a60da1"),
             City = "San Pedro Ayampuc",
             Country = "Guatemala",
             CreatedDate = DateTime.Now,
             Province = "San Pedro Ayampuc",
             Description = "Suite 31",
             AddressText = "84 Melody Place",
             ZipCode = "79223",
             Longitude = 90.4537748m,
             Latitude = 14.7833743m,
         },

         new Address
         {
             Id = Guid.Parse("4cbb6e3b-d959-4508-80aa-fe8abd8c928e"),
             City = "Pubu",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Pubu",
             Description = "Suite 85",
             AddressText = "02224 Fremont Trail",
             ZipCode = "63816",
             Longitude = 87.762163m,
             Latitude = 29.060527m,
         },

         new Address
         {
             Id = Guid.Parse("4e1165e8-e3de-4444-843f-a57872e51a8e"),
             City = "Masindi Port",
             Country = "Uganda",
             CreatedDate = DateTime.Now,
             Province = "Masindi Port",
             Description = "Suite 36",
             AddressText = "8 Lukken Place",
             ZipCode = "15394",
             Longitude = 32.0733109m,
             Latitude = 1.699532m,
         },

         new Address
         {
             Id = Guid.Parse("4e51c05c-06bf-4fc8-bb58-9eed7981f88c"),
             City = "Larangan",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Larangan",
             Description = "Apt 1257",
             AddressText = "68 Calypso Court",
             ZipCode = "32075",
             Longitude = 108.9264524m,
             Latitude = 7.0606502m,
         },

         new Address
         {
             Id = Guid.Parse("4ee13e23-f45c-4e59-87d9-43f0f9477650"),
             City = "Xiangshi",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Xiangshi",
             Description = "Room 1144",
             AddressText = "3 Pankratz Road",
             ZipCode = "12432",
             Longitude = 110.840021m,
             Latitude = 29.514498m,
         },

         new Address
         {
             Id = Guid.Parse("4fcc9e59-8973-469f-a29c-420fc7ff4e8c"),
             City = "Nerópolis",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Nerópolis",
             Description = "12th Floor",
             AddressText = "1 Lillian Terrace",
             ZipCode = "28872",
             Longitude = 49.1828385m,
             Latitude = 16.4078661m,
         },

         new Address
         {
             Id = Guid.Parse("4fd68936-7177-4afb-b188-36d21d6816fc"),
             City = "Levallois-Perret",
             Country = "France",
             CreatedDate = DateTime.Now,
             Province = "Levallois-Perret",
             Description = "17th Floor",
             AddressText = "30 David Point",
             ZipCode = "77807",
             Longitude = 2.8814002m,
             Latitude = 49.2272998m,
         },

         new Address
         {
             Id = Guid.Parse("52a2aee0-0074-450c-b963-493ae6c6d8b0"),
             City = "Saari",
             Country = "Finland",
             CreatedDate = DateTime.Now,
             Province = "Saari",
             Description = "Room 1940",
             AddressText = "8390 Graedel Terrace",
             ZipCode = "53799",
             Longitude = 26.1741559m,
             Latitude = 61.2318649m,
         },

         new Address
         {
             Id = Guid.Parse("53b3d189-b837-473e-8d43-affba7e863a3"),
             City = "Yola",
             Country = "Nigeria",
             CreatedDate = DateTime.Now,
             Province = "Yola",
             Description = "Suite 8",
             AddressText = "2 Green Avenue",
             ZipCode = "77279",
             Longitude = 12.4953899m,
             Latitude = 9.2034963m,
         },

         new Address
         {
             Id = Guid.Parse("541324d1-5bee-4d8c-91e5-ce1dc2c4038a"),
             City = "Bistrinci",
             Country = "Croatia",
             CreatedDate = DateTime.Now,
             Province = "Bistrinci",
             Description = "PO Box 66348",
             AddressText = "11 Kipling Trail",
             ZipCode = "65400",
             Longitude = 18.4041894m,
             Latitude = 45.6878582m,
         },

         new Address
         {
             Id = Guid.Parse("54b4a0c3-d3e6-4892-aec8-c18d41121189"),
             City = "Mujães",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Mujães",
             Description = "Room 1144",
             AddressText = "9 Holy Cross Circle",
             ZipCode = "16322",
             Longitude = 8.7184577m,
             Latitude = 41.6550179m,
         },

         new Address
         {
             Id = Guid.Parse("596b4be4-a97e-4ecc-ae58-a9d9e0338f66"),
             City = "Usicayos",
             Country = "Peru",
             CreatedDate = DateTime.Now,
             Province = "Usicayos",
             Description = "PO Box 64623",
             AddressText = "59495 Ramsey Hill",
             ZipCode = "27217",
             Longitude = 69.9661586m,
             Latitude = 14.1254679m,
         },

         new Address
         {
             Id = Guid.Parse("5a105afd-2bea-4ead-a9a8-0930412dcc5a"),
             City = "Lucun",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Lucun",
             Description = "Apt 1589",
             AddressText = "282 Darwin Trail",
             ZipCode = "29011",
             Longitude = 84.3150822m,
             Latitude = 33.9230243m,
         },

         new Address
         {
             Id = Guid.Parse("5a4f63cb-c90c-47c0-95a9-6942aa9f2f32"),
             City = "Detchino",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Detchino",
             Description = "9th Floor",
             AddressText = "23 Moose Court",
             ZipCode = "57386",
             Longitude = 36.3116274m,
             Latitude = 54.8098373m,
         },

         new Address
         {
             Id = Guid.Parse("5b73453b-eb4d-4464-ba0d-104e50b80cca"),
             City = "Chum Phuang",
             Country = "Thailand",
             CreatedDate = DateTime.Now,
             Province = "Chum Phuang",
             Description = "Room 1852",
             AddressText = "4937 Browning Crossing",
             ZipCode = "43991",
             Longitude = 102.8514837m,
             Latitude = 15.2679414m,
         },

         new Address
         {
             Id = Guid.Parse("5bb3d043-558f-456c-aa8a-71fb185c43ba"),
             City = "Hīt",
             Country = "Iraq",
             CreatedDate = DateTime.Now,
             Province = "Hīt",
             Description = "PO Box 74329",
             AddressText = "3588 Grayhawk Road",
             ZipCode = "53473",
             Longitude = 42.8253662m,
             Latitude = 33.6435199m,
         },

         new Address
         {
             Id = Guid.Parse("5c52464e-85b2-47b9-a911-a11b6c134975"),
             City = "Chamical",
             Country = "Argentina",
             CreatedDate = DateTime.Now,
             Province = "Chamical",
             Description = "PO Box 89043",
             AddressText = "8 Sloan Court",
             ZipCode = "59135",
             Longitude = 64.1257463m,
             Latitude = 31.4411018m,
         },

         new Address
         {
             Id = Guid.Parse("5db517e1-e7c1-4561-b7d9-b697d2b0e948"),
             City = "Severomorsk",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Severomorsk",
             Description = "PO Box 97372",
             AddressText = "0289 Ridge Oak Place",
             ZipCode = "65644",
             Longitude = 33.4168559m,
             Latitude = 69.0603424m,
         },

         new Address
         {
             Id = Guid.Parse("5dd83be2-e0d9-4adf-ab1b-50c2b988c65f"),
             City = "Adorjan",
             Country = "Serbia",
             CreatedDate = DateTime.Now,
             Province = "Adorjan",
             Description = "Apt 1057",
             AddressText = "39426 Raven Street",
             ZipCode = "73936",
             Longitude = 20.0278794m,
             Latitude = 45.9956745m,
         },

         new Address
         {
             Id = Guid.Parse("5f3c26b8-6f30-4825-aadc-8719234b987a"),
             City = "Grenoble",
             Country = "France",
             CreatedDate = DateTime.Now,
             Province = "Grenoble",
             Description = "Room 656",
             AddressText = "8065 Schlimgen Hill",
             ZipCode = "29470",
             Longitude = 5.7218985m,
             Latitude = 45.1934857m,
         },

         new Address
         {
             Id = Guid.Parse("5f72b61e-55c6-46e0-81a2-7f86f0686649"),
             City = "Ceuta",
             Country = "Spain",
             CreatedDate = DateTime.Now,
             Province = "Ceuta",
             Description = "Apt 562",
             AddressText = "98971 Gateway Point",
             ZipCode = "40907",
             Longitude = 5.2919563m,
             Latitude = 35.8941687m,
         },

         new Address
         {
             Id = Guid.Parse("5fcadcb3-232f-4475-bb64-7af39bc0441b"),
             City = "Outjo",
             Country = "Namibia",
             CreatedDate = DateTime.Now,
             Province = "Outjo",
             Description = "11th Floor",
             AddressText = "0810 Fisk Crossing",
             ZipCode = "39357",
             Longitude = 16.1610343m,
             Latitude = 20.1127536m,
         },

         new Address
         {
             Id = Guid.Parse("5fde0ce5-63ed-450c-a8fa-78ec131f5963"),
             City = "Corticeiro de Baixo",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Corticeiro de Baixo",
             Description = "Apt 201",
             AddressText = "5 Kingsford Drive",
             ZipCode = "45601",
             Longitude = 8.6947028m,
             Latitude = 40.427682m,
         },

         new Address
         {
             Id = Guid.Parse("63021fd7-2443-4869-8609-8c7c2c5215c1"),
             City = "Ron Phibun",
             Country = "Thailand",
             CreatedDate = DateTime.Now,
             Province = "Ron Phibun",
             Description = "6th Floor",
             AddressText = "378 Raven Hill",
             ZipCode = "36259",
             Longitude = 99.8348146m,
             Latitude = 8.16682m,
         },

         new Address
         {
             Id = Guid.Parse("655519d8-d05a-4f54-9d80-acd6828fd62d"),
             City = "Tabora",
             Country = "Tanzania",
             CreatedDate = DateTime.Now,
             Province = "Tabora",
             Description = "Room 870",
             AddressText = "929 Oxford Junction",
             ZipCode = "51872",
             Longitude = 32.8197329m,
             Latitude = 5.0424945m,
         },

         new Address
         {
             Id = Guid.Parse("65720e48-caab-4425-a7f2-6dcb1d40d608"),
             City = "Sangari",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Sangari",
             Description = "Apt 463",
             AddressText = "10 Talisman Lane",
             ZipCode = "51452",
             Longitude = 119.0109502m,
             Latitude = 8.5294459m,
         },

         new Address
         {
             Id = Guid.Parse("6607fc03-3a6f-4242-8ed8-18ae7f979c3f"),
             City = "Cibeusi",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Cibeusi",
             Description = "Room 381",
             AddressText = "20 Buhler Hill",
             ZipCode = "76996",
             Longitude = 107.6896073m,
             Latitude = 6.752982m,
         },

         new Address
         {
             Id = Guid.Parse("6691ce19-0271-4c8d-9e1a-5b6cb6ad9beb"),
             City = "Viradouro",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Viradouro",
             Description = "Suite 26",
             AddressText = "7 Forster Court",
             ZipCode = "27668",
             Longitude = 48.299098m,
             Latitude = 20.8740173m,
         },

         new Address
         {
             Id = Guid.Parse("67928c39-1eb1-47c7-ba23-fe44803e5e3e"),
             City = "Mabayo",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Mabayo",
             Description = "Apt 90",
             AddressText = "581 Sundown Lane",
             ZipCode = "48897",
             Longitude = 120.4786045m,
             Latitude = 14.641705m,
         },

         new Address
         {
             Id = Guid.Parse("6b92cebf-9be6-4ce4-9279-b50f2dc5d03b"),
             City = "Tippi",
             Country = "Ethiopia",
             CreatedDate = DateTime.Now,
             Province = "Tippi",
             Description = "PO Box 86961",
             AddressText = "89447 Springview Place",
             ZipCode = "68382",
             Longitude = 35.4288797m,
             Latitude = 7.1966596m,
         },

         new Address
         {
             Id = Guid.Parse("6bc7b776-7ffd-450f-9509-59aac19f3d27"),
             City = "Mossendjo",
             Country = "Republic of the Congo",
             CreatedDate = DateTime.Now,
             Province = "Mossendjo",
             Description = "Apt 847",
             AddressText = "71879 Vera Point",
             ZipCode = "19719",
             Longitude = 12.7278766m,
             Latitude = 2.9655267m,
         },

         new Address
         {
             Id = Guid.Parse("6e44e339-67c3-48cd-985e-2cfc79876424"),
             City = "Wilkowice",
             Country = "Poland",
             CreatedDate = DateTime.Now,
             Province = "Wilkowice",
             Description = "PO Box 63470",
             AddressText = "636 Sullivan Court",
             ZipCode = "49812",
             Longitude = 19.0904515m,
             Latitude = 49.7624347m,
         },

         new Address
         {
             Id = Guid.Parse("6f15928b-16c9-482e-9722-f31db7faa039"),
             City = "Baratan",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Baratan",
             Description = "PO Box 68722",
             AddressText = "51464 Melby Lane",
             ZipCode = "22746",
             Longitude = 113.7305569m,
             Latitude = 8.1324515m,
         },

         new Address
         {
             Id = Guid.Parse("6fa6d7ee-f789-413f-930b-9985a1513f20"),
             City = "Kebonan",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Kebonan",
             Description = "19th Floor",
             AddressText = "73447 Boyd Street",
             ZipCode = "58343",
             Longitude = 110.6422198m,
             Latitude = 7.355927m,
         },

         new Address
         {
             Id = Guid.Parse("707d4bbe-a5ed-4f0b-b0e2-8f5bb8d3b3ad"),
             City = "Novokuz’minki",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Novokuz’minki",
             Description = "5th Floor",
             AddressText = "4121 Coleman Road",
             ZipCode = "64246",
             Longitude = 87.4792556m,
             Latitude = 53.1294318m,
         },

         new Address
         {
             Id = Guid.Parse("71ad0e3c-5024-4bbd-ba13-5b0d4abb7f15"),
             City = "Murmino",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Murmino",
             Description = "PO Box 37481",
             AddressText = "28 Vidon Park",
             ZipCode = "17844",
             Longitude = 40.0487656m,
             Latitude = 54.6053915m,
         },

         new Address
         {
             Id = Guid.Parse("73f3d9d5-3c42-4c73-9c34-24a242b621b6"),
             City = "Ujungpangkah",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Ujungpangkah",
             Description = "Suite 11",
             AddressText = "20 Summerview Junction",
             ZipCode = "35528",
             Longitude = 112.548349m,
             Latitude = 6.9353179m,
         },

         new Address
         {
             Id = Guid.Parse("74f343f4-ae50-4d2e-8d36-174d03ee5889"),
             City = "Syracuse",
             Country = "United States",
             CreatedDate = DateTime.Now,
             Province = "Syracuse",
             Description = "Apt 993",
             AddressText = "278 Esch Terrace",
             ZipCode = "12998",
             Longitude = 76.1377935m,
             Latitude = 42.9979838m,
         },

         new Address
         {
             Id = Guid.Parse("751bf468-1636-4576-a36e-e2eb3c6c72e7"),
             City = "Uluarang",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Uluarang",
             Description = "Apt 1895",
             AddressText = "478 Garrison Road",
             ZipCode = "28581",
             Longitude = 106.0452m,
             Latitude = 6.1473m,
         },

         new Address
         {
             Id = Guid.Parse("7732d4f8-2fef-4bcb-93ba-2cd49e16d903"),
             City = "Landázuri",
             Country = "Colombia",
             CreatedDate = DateTime.Now,
             Province = "Landázuri",
             Description = "Suite 43",
             AddressText = "088 Stang Trail",
             ZipCode = "51234",
             Longitude = 73.809258m,
             Latitude = 6.2194589m,
         },

         new Address
         {
             Id = Guid.Parse("77353a89-62ce-49b1-9a2c-9f187a3b3093"),
             City = "Ebene",
             Country = "Mauritius",
             CreatedDate = DateTime.Now,
             Province = "Ebene",
             Description = "Apt 1326",
             AddressText = "10503 Miller Drive",
             ZipCode = "21252",
             Longitude = 57.4895998m,
             Latitude = 20.2418916m,
         },

         new Address
         {
             Id = Guid.Parse("77e0f210-b417-4b14-ae57-a9b5a949a146"),
             City = "Souto do Meio",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Souto do Meio",
             Description = "Suite 70",
             AddressText = "60 Larry Place",
             ZipCode = "46978",
             Longitude = 8.7234791m,
             Latitude = 39.7424454m,
         },

         new Address
         {
             Id = Guid.Parse("7981da33-a5f1-4b83-bf0d-d4999e7426df"),
             City = "Cerro Corá",
             Country = "Argentina",
             CreatedDate = DateTime.Now,
             Province = "Cerro Corá",
             Description = "PO Box 6452",
             AddressText = "68 Summerview Terrace",
             ZipCode = "27595",
             Longitude = 64.2142976m,
             Latitude = 31.43337m,
         },

         new Address
         {
             Id = Guid.Parse("79bd7524-5917-4b16-93b9-d8e84dc4475f"),
             City = "Jinja",
             Country = "Uganda",
             CreatedDate = DateTime.Now,
             Province = "Jinja",
             Description = "Room 463",
             AddressText = "06 Mesta Lane",
             ZipCode = "41173",
             Longitude = 33.2026122m,
             Latitude = 0.4478566m,
         },

         new Address
         {
             Id = Guid.Parse("7b31b1ac-99fb-4d86-995c-d05a43af5bfe"),
             City = "Balakhninskiy",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Balakhninskiy",
             Description = "Suite 40",
             AddressText = "4 Fallview Point",
             ZipCode = "34436",
             Longitude = 114.2615751m,
             Latitude = 57.995662m,
         },

         new Address
         {
             Id = Guid.Parse("7c842399-b958-42ab-97df-78a24aeaff7e"),
             City = "Alvarães",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Alvarães",
             Description = "Room 805",
             AddressText = "96180 Spohn Alley",
             ZipCode = "58157",
             Longitude = 65.3807101m,
             Latitude = 3.7751449m,
         },

         new Address
         {
             Id = Guid.Parse("7e6754ed-ce05-4914-9262-ec06204a7b62"),
             City = "Mouhijärvi",
             Country = "Finland",
             CreatedDate = DateTime.Now,
             Province = "Mouhijärvi",
             Description = "PO Box 40779",
             AddressText = "88 Columbus Pass",
             ZipCode = "13956",
             Longitude = 23.0108503m,
             Latitude = 61.5095512m,
         },

         new Address
         {
             Id = Guid.Parse("7e96d308-2a5c-4e74-a75f-9ff147ee4483"),
             City = "Shuinanxu",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Shuinanxu",
             Description = "Room 484",
             AddressText = "3505 Sutteridge Park",
             ZipCode = "46752",
             Longitude = 116.490286m,
             Latitude = 26.83411m,
         },

         new Address
         {
             Id = Guid.Parse("7f986e69-b96d-4dfc-aab8-c48419ffec0b"),
             City = "Goranboy",
             Country = "Azerbaijan",
             CreatedDate = DateTime.Now,
             Province = "Goranboy",
             Description = "Room 142",
             AddressText = "3403 Northport Hill",
             ZipCode = "43698",
             Longitude = 46.7807131m,
             Latitude = 40.6073164m,
         },

         new Address
         {
             Id = Guid.Parse("80492754-a5e1-4cef-ba75-4149eb6422a2"),
             City = "Lebak",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Lebak",
             Description = "Apt 1696",
             AddressText = "694 Veith Point",
             ZipCode = "17418",
             Longitude = 106.2522143m,
             Latitude = 6.5643956m,
         },

         new Address
         {
             Id = Guid.Parse("8271e484-32ed-40cb-a8b1-2aaea16cf422"),
             City = "Yunfu",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Yunfu",
             Description = "Apt 1724",
             AddressText = "6 Talmadge Way",
             ZipCode = "65882",
             Longitude = 112.044491m,
             Latitude = 22.915094m,
         },

         new Address
         {
             Id = Guid.Parse("8403acaa-0dad-4c4e-9cb3-9b525aa660ab"),
             City = "Huangtan",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Huangtan",
             Description = "Room 1813",
             AddressText = "37329 Atwood Hill",
             ZipCode = "71570",
             Longitude = 121.261886m,
             Latitude = 28.650072m,
         },

         new Address
         {
             Id = Guid.Parse("8612b26e-18c2-4d13-8c32-0d8721829312"),
             City = "Göteborg",
             Country = "Sweden",
             CreatedDate = DateTime.Now,
             Province = "Göteborg",
             Description = "PO Box 34148",
             AddressText = "44166 Corry Alley",
             ZipCode = "34271",
             Longitude = 12.0793963m,
             Latitude = 57.7330292m,
         },

         new Address
         {
             Id = Guid.Parse("864f0c8b-33e9-4b18-ad1a-48d95016e1c4"),
             City = "Tešanj",
             Country = "Bosnia and Herzegovina",
             CreatedDate = DateTime.Now,
             Province = "Tešanj",
             Description = "PO Box 59702",
             AddressText = "5173 Ludington Hill",
             ZipCode = "22030",
             Longitude = 17.9914718m,
             Latitude = 44.6166027m,
         },

         new Address
         {
             Id = Guid.Parse("870de510-9cf7-4a5e-8855-f33fa445192f"),
             City = "Ocumare del Tuy",
             Country = "Venezuela",
             CreatedDate = DateTime.Now,
             Province = "Ocumare del Tuy",
             Description = "Room 1263",
             AddressText = "03 Hoepker Crossing",
             ZipCode = "41999",
             Longitude = 66.784376m,
             Latitude = 10.0897999m,
         },

         new Address
         {
             Id = Guid.Parse("89a68fd1-1530-4402-9326-a8ca5c1c7760"),
             City = "Ol’gino",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Ol’gino",
             Description = "Room 1463",
             AddressText = "35 Bay Place",
             ZipCode = "66886",
             Longitude = 36.770859m,
             Latitude = 56.718213m,
         },

         new Address
         {
             Id = Guid.Parse("8ac8cde7-58e3-43c1-803a-57a86f981bc3"),
             City = "Castilla",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Castilla",
             Description = "Apt 1505",
             AddressText = "99 Eggendart Street",
             ZipCode = "52254",
             Longitude = 121.0334173m,
             Latitude = 14.6087807m,
         },

         new Address
         {
             Id = Guid.Parse("8b012c1c-ed55-4ed9-bb13-12f99e180e5f"),
             City = "La Romana",
             Country = "Dominican Republic",
             CreatedDate = DateTime.Now,
             Province = "La Romana",
             Description = "Room 623",
             AddressText = "41 Grim Court",
             ZipCode = "28087",
             Longitude = 70.4070779m,
             Latitude = 18.9313146m,
         },

         new Address
         {
             Id = Guid.Parse("8b78dc68-94db-48f9-b0e6-330a60040749"),
             City = "Biscucuy",
             Country = "Venezuela",
             CreatedDate = DateTime.Now,
             Province = "Biscucuy",
             Description = "Room 1905",
             AddressText = "11132 New Castle Place",
             ZipCode = "20433",
             Longitude = 69.9877879m,
             Latitude = 9.3595215m,
         },

         new Address
         {
             Id = Guid.Parse("8b891893-4325-44ad-bcd8-75f28673c80a"),
             City = "El Pardo",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "El Pardo",
             Description = "Room 703",
             AddressText = "26 Vermont Street",
             ZipCode = "28320",
             Longitude = 123.85681m,
             Latitude = 10.277766m,
         },

         new Address
         {
             Id = Guid.Parse("8bd64cdd-5a1e-4753-b979-8e99f9b72fad"),
             City = "Arroio do Meio",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Arroio do Meio",
             Description = "Suite 16",
             AddressText = "512 Manley Park",
             ZipCode = "23841",
             Longitude = 51.9580164m,
             Latitude = 29.3652193m,
         },

         new Address
         {
             Id = Guid.Parse("8c4fc3c8-68c5-4c93-b295-e04b917e14c2"),
             City = "Pomahan",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Pomahan",
             Description = "5th Floor",
             AddressText = "06774 Bayside Junction",
             ZipCode = "55018",
             Longitude = 111.4067217m,
             Latitude = 6.8217678m,
         },

         new Address
         {
             Id = Guid.Parse("945d469e-f23f-47be-a33c-f9e7961d8dbf"),
             City = "Albertville",
             Country = "France",
             CreatedDate = DateTime.Now,
             Province = "Albertville",
             Description = "Suite 94",
             AddressText = "50219 Vera Terrace",
             ZipCode = "57901",
             Longitude = 6.3760602m,
             Latitude = 45.6629694m,
         },

         new Address
         {
             Id = Guid.Parse("953dbd57-4ab6-4faf-b1b7-26c27b9d63b5"),
             City = "Krrabë",
             Country = "Albania",
             CreatedDate = DateTime.Now,
             Province = "Krrabë",
             Description = "PO Box 85379",
             AddressText = "3372 Wayridge Hill",
             ZipCode = "74840",
             Longitude = 19.969783m,
             Latitude = 41.2177603m,
         },

         new Address
         {
             Id = Guid.Parse("99093bc9-3c46-4b19-b2d2-420ae745f114"),
             City = "Wufeng",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Wufeng",
             Description = "Apt 597",
             AddressText = "42 Lakewood Gardens Junction",
             ZipCode = "61226",
             Longitude = 110.674706m,
             Latitude = 30.199688m,
         },

         new Address
         {
             Id = Guid.Parse("9b0c06ba-9129-4329-83d7-d0417b3703a6"),
             City = "Butwāl",
             Country = "Nepal",
             CreatedDate = DateTime.Now,
             Province = "Butwāl",
             Description = "PO Box 67937",
             AddressText = "58 Buena Vista Park",
             ZipCode = "78713",
             Longitude = 83.4323375m,
             Latitude = 27.6873608m,
         },

         new Address
         {
             Id = Guid.Parse("9ba4b9cb-3d82-4ead-ace3-ed112d884898"),
             City = "Almere Haven",
             Country = "Netherlands",
             CreatedDate = DateTime.Now,
             Province = "Almere Haven",
             Description = "Apt 440",
             AddressText = "0901 Russell Drive",
             ZipCode = "41232",
             Longitude = 5.7187546m,
             Latitude = 52.842561m,
         },

         new Address
         {
             Id = Guid.Parse("9d048d07-09bf-4830-9360-7a53cc7b089f"),
             City = "Baishui",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Baishui",
             Description = "4th Floor",
             AddressText = "075 Jenifer Lane",
             ZipCode = "71971",
             Longitude = 109.590671m,
             Latitude = 35.177451m,
         },

         new Address
         {
             Id = Guid.Parse("9d9fa0bd-4f4a-4c06-a97c-956a706ede32"),
             City = "Bogra",
             Country = "Bangladesh",
             CreatedDate = DateTime.Now,
             Province = "Bogra",
             Description = "4th Floor",
             AddressText = "8 Pawling Alley",
             ZipCode = "56487",
             Longitude = 89.3701078m,
             Latitude = 24.8435589m,
         },

         new Address
         {
             Id = Guid.Parse("a07401a9-f0c7-4c8b-aa4c-ff7d4ab9a280"),
             City = "Cipaku",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Cipaku",
             Description = "PO Box 5287",
             AddressText = "1358 West Alley",
             ZipCode = "58932",
             Longitude = 107.7843483m,
             Latitude = 7.0631844m,
         },

         new Address
         {
             Id = Guid.Parse("a2eac29a-b869-4c93-b080-25d95f1f3462"),
             City = "Kulunda",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Kulunda",
             Description = "PO Box 84389",
             AddressText = "332 Forest Crossing",
             ZipCode = "37005",
             Longitude = 78.9472223m,
             Latitude = 52.5666667m,
         },

         new Address
         {
             Id = Guid.Parse("a2f10e9a-e20b-4f25-873f-9607c7d4ed87"),
             City = "Naukot",
             Country = "Pakistan",
             CreatedDate = DateTime.Now,
             Province = "Naukot",
             Description = "Room 682",
             AddressText = "07403 Pond Park",
             ZipCode = "17710",
             Longitude = 69.4620073m,
             Latitude = 24.8388207m,
         },

         new Address
         {
             Id = Guid.Parse("a3979dc7-669f-49da-a2c4-e159a33021e5"),
             City = "Concepción",
             Country = "Guatemala",
             CreatedDate = DateTime.Now,
             Province = "Concepción",
             Description = "Suite 25",
             AddressText = "5 Jenifer Junction",
             ZipCode = "62564",
             Longitude = 91.133737m,
             Latitude = 14.7673116m,
         },

         new Address
         {
             Id = Guid.Parse("a8cf5410-65e8-4fab-98db-51c142b7a5ad"),
             City = "Klos",
             Country = "Albania",
             CreatedDate = DateTime.Now,
             Province = "Klos",
             Description = "Suite 86",
             AddressText = "51698 Cordelia Parkway",
             ZipCode = "47618",
             Longitude = 20.0859109m,
             Latitude = 41.5063062m,
         },

         new Address
         {
             Id = Guid.Parse("a9871d46-3469-40d4-a4b2-0827b0fc8429"),
             City = "Challhuahuacho",
             Country = "Peru",
             CreatedDate = DateTime.Now,
             Province = "Challhuahuacho",
             Description = "PO Box 14375",
             AddressText = "91813 Hooker Trail",
             ZipCode = "67897",
             Longitude = 72.2475967m,
             Latitude = 14.1187849m,
         },

         new Address
         {
             Id = Guid.Parse("aa4c8f28-849e-4684-b96f-e5b3b6620f66"),
             City = "Qobustan",
             Country = "Azerbaijan",
             CreatedDate = DateTime.Now,
             Province = "Qobustan",
             Description = "2nd Floor",
             AddressText = "80 Rowland Parkway",
             ZipCode = "71281",
             Longitude = 49.4030218m,
             Latitude = 40.0877962m,
         },

         new Address
         {
             Id = Guid.Parse("ac09b7da-bc82-4dbf-a123-2eb93b124b9c"),
             City = "Qiziltepa Shahri",
             Country = "Uzbekistan",
             CreatedDate = DateTime.Now,
             Province = "Qiziltepa Shahri",
             Description = "8th Floor",
             AddressText = "57 Messerschmidt Lane",
             ZipCode = "43653",
             Longitude = 64.82885m,
             Latitude = 40.0254m,
         },

         new Address
         {
             Id = Guid.Parse("acdde399-727d-4718-8f02-02b9d22ab477"),
             City = "Cái Nhum",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Cái Nhum",
             Description = "Room 1378",
             AddressText = "0441 Orin Terrace",
             ZipCode = "74056",
             Longitude = 106.1125201m,
             Latitude = 10.1775604m,
         },

         new Address
         {
             Id = Guid.Parse("af1a538a-b7bb-413e-9923-be384cbf4f42"),
             City = "Šenkovec",
             Country = "Croatia",
             CreatedDate = DateTime.Now,
             Province = "Šenkovec",
             Description = "Room 62",
             AddressText = "8123 Pleasure Terrace",
             ZipCode = "18553",
             Longitude = 16.4201451m,
             Latitude = 46.4054155m,
         },

         new Address
         {
             Id = Guid.Parse("af7c2192-f77e-40d9-bd8b-ed32e9c7a3a3"),
             City = "Samashki",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Samashki",
             Description = "Apt 1880",
             AddressText = "1 Victoria Park",
             ZipCode = "72380",
             Longitude = 45.3024464m,
             Latitude = 43.2900441m,
         },

         new Address
         {
             Id = Guid.Parse("b16f7bb9-e72b-448d-ab6d-5df87a468872"),
             City = "Agdzhabedy",
             Country = "Azerbaijan",
             CreatedDate = DateTime.Now,
             Province = "Agdzhabedy",
             Description = "Room 1903",
             AddressText = "333 Tennessee Trail",
             ZipCode = "28644",
             Longitude = 47.3290937m,
             Latitude = 40.0257239m,
         },

         new Address
         {
             Id = Guid.Parse("b4534614-3fbb-445d-97e5-d16ee7d3ab98"),
             City = "Sebina",
             Country = "Botswana",
             CreatedDate = DateTime.Now,
             Province = "Sebina",
             Description = "4th Floor",
             AddressText = "4480 Alpine Hill",
             ZipCode = "80894",
             Longitude = 27.2029363m,
             Latitude = 20.8097593m,
         },

         new Address
         {
             Id = Guid.Parse("b5850106-3f73-4acd-82ae-4a08eb6173cb"),
             City = "Loboniki",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Loboniki",
             Description = "PO Box 92211",
             AddressText = "668 Sullivan Point",
             ZipCode = "35398",
             Longitude = 121.9131761m,
             Latitude = 8.5146254m,
         },

         new Address
         {
             Id = Guid.Parse("b6554b94-0959-4a16-9f63-4463e98bbf9f"),
             City = "Lau",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Lau",
             Description = "Room 1724",
             AddressText = "09 Maryland Trail",
             ZipCode = "55196",
             Longitude = 8.8036223m,
             Latitude = 38.6099176m,
         },

         new Address
         {
             Id = Guid.Parse("b77062cd-0b6f-4f78-823a-06fec1cf030c"),
             City = "Shishi",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Shishi",
             Description = "Apt 1946",
             AddressText = "2 Everett Junction",
             ZipCode = "57547",
             Longitude = 118.648066m,
             Latitude = 24.732204m,
         },

         new Address
         {
             Id = Guid.Parse("b870b9d3-b528-4a73-b043-53b475fe9069"),
             City = "Krajan C Wonorejo",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Krajan C Wonorejo",
             Description = "PO Box 68803",
             AddressText = "421 Redwing Avenue",
             ZipCode = "31947",
             Longitude = 110.2498957m,
             Latitude = 6.9561332m,
         },

         new Address
         {
             Id = Guid.Parse("b947a4ed-2c88-4ab7-9119-5fc72c717423"),
             City = "Gueset",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Gueset",
             Description = "Suite 59",
             AddressText = "309 Browning Terrace",
             ZipCode = "21204",
             Longitude = 120.9855937m,
             Latitude = 14.5713332m,
         },

         new Address
         {
             Id = Guid.Parse("b970a89a-aad0-402d-9c45-d6d7bd4bf1ac"),
             City = "Gominhães",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Gominhães",
             Description = "PO Box 64966",
             AddressText = "97707 Butterfield Center",
             ZipCode = "29625",
             Longitude = 8.2776432m,
             Latitude = 41.4821084m,
         },

         new Address
         {
             Id = Guid.Parse("b9938475-6ad8-49d2-a3c1-aa70e107ab44"),
             City = "Dolores",
             Country = "Uruguay",
             CreatedDate = DateTime.Now,
             Province = "Dolores",
             Description = "2nd Floor",
             AddressText = "1 Graedel Pass",
             ZipCode = "67745",
             Longitude = 58.2177722m,
             Latitude = 33.5339107m,
         },

         new Address
         {
             Id = Guid.Parse("baff58c7-26b4-4ebd-993f-bde7913c7eb9"),
             City = "Nangewer",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Nangewer",
             Description = "Apt 1167",
             AddressText = "7 Prairieview Crossing",
             ZipCode = "16983",
             Longitude = 107.4765594m,
             Latitude = 6.7146375m,
         },

         new Address
         {
             Id = Guid.Parse("bb32856f-91ea-4756-8cfc-4d1347577b5a"),
             City = "Pétionville",
             Country = "Haiti",
             CreatedDate = DateTime.Now,
             Province = "Pétionville",
             Description = "13th Floor",
             AddressText = "62 Meadow Valley Point",
             ZipCode = "37844",
             Longitude = 72.2881907m,
             Latitude = 18.5138139m,
         },

         new Address
         {
             Id = Guid.Parse("bb56c645-bd8a-4dc5-b759-21f80cbec269"),
             City = "Al Qarmadah",
             Country = "Tunisia",
             CreatedDate = DateTime.Now,
             Province = "Al Qarmadah",
             Description = "Room 1827",
             AddressText = "8 Dakota Road",
             ZipCode = "64368",
             Longitude = 10.78333m,
             Latitude = 34.75m,
         },

         new Address
         {
             Id = Guid.Parse("bbaa4c1e-5ed1-45bc-934e-4873405f0e23"),
             City = "Ålesund",
             Country = "Norway",
             CreatedDate = DateTime.Now,
             Province = "Ålesund",
             Description = "PO Box 77742",
             AddressText = "168 Sheridan Pass",
             ZipCode = "31319",
             Longitude = 6.2512238m,
             Latitude = 62.4658095m,
         },

         new Address
         {
             Id = Guid.Parse("bd18b93c-870d-4b8c-ad0d-162825959318"),
             City = "Nancy",
             Country = "France",
             CreatedDate = DateTime.Now,
             Province = "Nancy",
             Description = "PO Box 98922",
             AddressText = "91956 Hollow Ridge Center",
             ZipCode = "41731",
             Longitude = 6.17445m,
             Latitude = 48.689836m,
         },

         new Address
         {
             Id = Guid.Parse("bef8b2ab-3126-4c9c-93e7-3ca7899925be"),
             City = "Dawuhan",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Dawuhan",
             Description = "Apt 160",
             AddressText = "8499 Vahlen Center",
             ZipCode = "32603",
             Longitude = 109.2638245m,
             Latitude = 7.5201771m,
         },

         new Address
         {
             Id = Guid.Parse("c17e9d5f-6c0b-478c-89b8-93b8e0848467"),
             City = "Malitbog",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Malitbog",
             Description = "Room 1077",
             AddressText = "4245 Briar Crest Trail",
             ZipCode = "46812",
             Longitude = 122.5270677m,
             Latitude = 11.1946369m,
         },

         new Address
         {
             Id = Guid.Parse("c1d19caa-17b9-4a4f-8406-aad1a97b6dab"),
             City = "Ximafang",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Ximafang",
             Description = "19th Floor",
             AddressText = "0439 Surrey Park",
             ZipCode = "58385",
             Longitude = 112.032036m,
             Latitude = 38.665105m,
         },

         new Address
         {
             Id = Guid.Parse("c2e0fe22-0b52-491d-accf-ded2c2dafc3a"),
             City = "Praia de Mira",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Praia de Mira",
             Description = "Room 1917",
             AddressText = "148 Forest Dale Terrace",
             ZipCode = "21329",
             Longitude = 8.8018715m,
             Latitude = 40.4583824m,
         },

         new Address
         {
             Id = Guid.Parse("c3e6415e-7e8a-47bb-9206-eb1cc9801df2"),
             City = "Kut Chap",
             Country = "Thailand",
             CreatedDate = DateTime.Now,
             Province = "Kut Chap",
             Description = "Apt 483",
             AddressText = "507 Coolidge Circle",
             ZipCode = "65894",
             Longitude = 102.5642447m,
             Latitude = 17.4214483m,
         },

         new Address
         {
             Id = Guid.Parse("c546354e-53da-4325-842c-d7578bbcd050"),
             City = "Balinad",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Balinad",
             Description = "PO Box 58700",
             AddressText = "00 Miller Center",
             ZipCode = "40874",
             Longitude = 123.9133184m,
             Latitude = 10.3492919m,
         },

         new Address
         {
             Id = Guid.Parse("c5db34c2-ed40-4702-9ea4-b19e1a058f1e"),
             City = "Shishang",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Shishang",
             Description = "Apt 834",
             AddressText = "4 Crowley Lane",
             ZipCode = "37266",
             Longitude = 118.9353968m,
             Latitude = 29.5530941m,
         },

         new Address
         {
             Id = Guid.Parse("c8512edf-7f3b-49d2-80cf-5baec51b8741"),
             City = "Oslo",
             Country = "Norway",
             CreatedDate = DateTime.Now,
             Province = "Oslo",
             Description = "PO Box 61217",
             AddressText = "0593 Jackson Trail",
             ZipCode = "76663",
             Longitude = 10.727404m,
             Latitude = 59.922175m,
         },

         new Address
         {
             Id = Guid.Parse("c9cb79f6-e82f-462f-a658-2458c92e7052"),
             City = "Hénin-Beaumont",
             Country = "France",
             CreatedDate = DateTime.Now,
             Province = "Hénin-Beaumont",
             Description = "PO Box 14763",
             AddressText = "68 Sherman Center",
             ZipCode = "49847",
             Longitude = 2.801236m,
             Latitude = 50.3171905m,
         },

         new Address
         {
             Id = Guid.Parse("cc2e4827-7b3c-4c8d-952b-ac65ec01b442"),
             City = "Zhangcaizhuang",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Zhangcaizhuang",
             Description = "Room 1194",
             AddressText = "97 Northridge Road",
             ZipCode = "40047",
             Longitude = 112.340495m,
             Latitude = 39.289991m,
         },

         new Address
         {
             Id = Guid.Parse("ce25cbe4-e8d9-46b1-b30c-9f82cdc1d83b"),
             City = "Saky",
             Country = "Ukraine",
             CreatedDate = DateTime.Now,
             Province = "Saky",
             Description = "15th Floor",
             AddressText = "7230 Westport Drive",
             ZipCode = "12411",
             Longitude = 33.5941067m,
             Latitude = 45.1310529m,
         },

         new Address
         {
             Id = Guid.Parse("d0f9c0e3-b1ad-4020-8912-e7233675e8e6"),
             City = "Gangmian",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Gangmian",
             Description = "9th Floor",
             AddressText = "0 Hanson Hill",
             ZipCode = "59219",
             Longitude = 112.018204m,
             Latitude = 23.438818m,
         },

         new Address
         {
             Id = Guid.Parse("d18461d3-2ef2-474a-b7ca-091d224ed0bc"),
             City = "Charleston",
             Country = "United States",
             CreatedDate = DateTime.Now,
             Province = "Charleston",
             Description = "PO Box 23699",
             AddressText = "5150 Eggendart Parkway",
             ZipCode = "78522",
             Longitude = 81.63m,
             Latitude = 38.35m,
         },

         new Address
         {
             Id = Guid.Parse("d4ce18fd-d1b6-4609-a92b-504421e87948"),
             City = "Katabu",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Katabu",
             Description = "PO Box 4449",
             AddressText = "7253 Old Gate Drive",
             ZipCode = "62124",
             Longitude = 122.5167m,
             Latitude = 4.9333m,
         },

         new Address
         {
             Id = Guid.Parse("d59cb584-3b8e-427b-9855-93d8032e89f0"),
             City = "Castanheira",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Castanheira",
             Description = "Room 1822",
             AddressText = "394 Del Mar Junction",
             ZipCode = "57482",
             Longitude = 8.151597m,
             Latitude = 41.3119638m,
         },

         new Address
         {
             Id = Guid.Parse("d70ebdfa-e4ed-4a97-827c-c5c49a1d16c9"),
             City = "T’azagyugh",
             Country = "Armenia",
             CreatedDate = DateTime.Now,
             Province = "T’azagyugh",
             Description = "Apt 1272",
             AddressText = "62 Merchant Road",
             ZipCode = "47508",
             Longitude = 45.1876561m,
             Latitude = 40.1367469m,
         },

         new Address
         {
             Id = Guid.Parse("d729ac60-7953-4c8c-8dc6-d4f79a2c325f"),
             City = "Bagumbayan",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Bagumbayan",
             Description = "Apt 870",
             AddressText = "0 Darwin Park",
             ZipCode = "65736",
             Longitude = 121.0228804m,
             Latitude = 14.5919106m,
         },

         new Address
         {
             Id = Guid.Parse("d7925ae5-2801-4778-9e8a-c9326ee53ca2"),
             City = "Ceres",
             Country = "Argentina",
             CreatedDate = DateTime.Now,
             Province = "Ceres",
             Description = "6th Floor",
             AddressText = "120 Green Trail",
             ZipCode = "32370",
             Longitude = 60.6682209m,
             Latitude = 32.9578112m,
         },

         new Address
         {
             Id = Guid.Parse("d83acb07-507f-46b9-9a7b-dad73c810b19"),
             City = "Kediren",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Kediren",
             Description = "Apt 1991",
             AddressText = "1 Montana Terrace",
             ZipCode = "62471",
             Longitude = 111.3739309m,
             Latitude = 7.7599015m,
         },

         new Address
         {
             Id = Guid.Parse("d8ca0911-ac4a-4fad-b26c-0aea96560fcf"),
             City = "pamas",
             Country = "Iran",
             CreatedDate = DateTime.Now,
             Province = "pamas",
             Description = "14th Floor",
             AddressText = "6 Chinook Terrace",
             ZipCode = "39340",
             Longitude = 48.4631098m,
             Latitude = 34.0375944m,
         },

         new Address
         {
             Id = Guid.Parse("da71f397-3751-4e48-8919-8e4843181a1c"),
             City = "Sens",
             Country = "France",
             CreatedDate = DateTime.Now,
             Province = "Sens",
             Description = "Room 681",
             AddressText = "392 Comanche Point",
             ZipCode = "76848",
             Longitude = 3.2995005m,
             Latitude = 48.1903349m,
         },

         new Address
         {
             Id = Guid.Parse("dab90d16-1ccc-4102-bf8c-f9c453f12682"),
             City = "Cawalo",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Cawalo",
             Description = "PO Box 37568",
             AddressText = "12155 Oak Valley Parkway",
             ZipCode = "12618",
             Longitude = 121.6978m,
             Latitude = 8.3115m,
         },

         new Address
         {
             Id = Guid.Parse("dc74495b-18cc-41dc-9391-186af36183a3"),
             City = "Devon",
             Country = "Canada",
             CreatedDate = DateTime.Now,
             Province = "Devon",
             Description = "PO Box 2361",
             AddressText = "7791 Michigan Place",
             ZipCode = "28729",
             Longitude = 113.7233907m,
             Latitude = 53.3547991m,
         },

         new Address
         {
             Id = Guid.Parse("def14cae-ecb0-43a5-aa88-fca141e69c66"),
             City = "Okulovka",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Okulovka",
             Description = "Suite 91",
             AddressText = "5691 Schiller Plaza",
             ZipCode = "20149",
             Longitude = 33.3074607m,
             Latitude = 58.3495477m,
         },

         new Address
         {
             Id = Guid.Parse("df429c1d-388d-4335-87a2-fe9f079e2fab"),
             City = "Majagual",
             Country = "Colombia",
             CreatedDate = DateTime.Now,
             Province = "Majagual",
             Description = "Apt 1519",
             AddressText = "36591 Amoth Junction",
             ZipCode = "80165",
             Longitude = 74.7571147m,
             Latitude = 8.5087615m,
         },

         new Address
         {
             Id = Guid.Parse("e071c1a2-fa27-4d5e-ab18-2d70b982d325"),
             City = "Asia",
             Country = "Peru",
             CreatedDate = DateTime.Now,
             Province = "Asia",
             Description = "Suite 57",
             AddressText = "12 North Terrace",
             ZipCode = "46737",
             Longitude = 76.5257007m,
             Latitude = 12.8010669m,
         },

         new Address
         {
             Id = Guid.Parse("e2aa9aae-e3fd-4530-96e3-ae016cc8135b"),
             City = "Baruny",
             Country = "Belarus",
             CreatedDate = DateTime.Now,
             Province = "Baruny",
             Description = "Suite 6",
             AddressText = "0 Longview Point",
             ZipCode = "56232",
             Longitude = 147.2679116m,
             Latitude = 43.3937074m,
         },

         new Address
         {
             Id = Guid.Parse("e30663b8-3e0c-41bd-a03b-e006cae48273"),
             City = "Marevo",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Marevo",
             Description = "Room 638",
             AddressText = "47 Dapin Parkway",
             ZipCode = "56194",
             Longitude = 32.0880477m,
             Latitude = 57.3132065m,
         },

         new Address
         {
             Id = Guid.Parse("e488f390-7a4a-4097-ac88-b3c9c7ec6d0e"),
             City = "Qelëz",
             Country = "Albania",
             CreatedDate = DateTime.Now,
             Province = "Qelëz",
             Description = "Room 1403",
             AddressText = "41 Kensington Road",
             ZipCode = "52753",
             Longitude = 19.909723m,
             Latitude = 42.095742m,
         },

         new Address
         {
             Id = Guid.Parse("e4beec47-e5bb-4ec3-8866-2bd0b333dda8"),
             City = "Ifon",
             Country = "Nigeria",
             CreatedDate = DateTime.Now,
             Province = "Ifon",
             Description = "Suite 72",
             AddressText = "136 Arizona Plaza",
             ZipCode = "38244",
             Longitude = 5.7773898m,
             Latitude = 6.9234906m,
         },

         new Address
         {
             Id = Guid.Parse("e519456c-68b8-4a82-a8b8-ed1888502e04"),
             City = "Villa Ocampo",
             Country = "Argentina",
             CreatedDate = DateTime.Now,
             Province = "Villa Ocampo",
             Description = "Apt 656",
             AddressText = "394 Texas Hill",
             ZipCode = "62113",
             Longitude = 59.3540025m,
             Latitude = 28.4866323m,
         },

         new Address
         {
             Id = Guid.Parse("e893fd34-3659-46ed-9267-96bfe3eabf85"),
             City = "Weixin",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Weixin",
             Description = "PO Box 25276",
             AddressText = "2514 Nevada Way",
             ZipCode = "18257",
             Longitude = 105.049027m,
             Latitude = 27.8469m,
         },

         new Address
         {
             Id = Guid.Parse("e8c28ebd-396d-4940-aead-2da7084728b6"),
             City = "San Lorenzo",
             Country = "Argentina",
             CreatedDate = DateTime.Now,
             Province = "San Lorenzo",
             Description = "Suite 3",
             AddressText = "0 Brown Center",
             ZipCode = "65494",
             Longitude = 60.652833m,
             Latitude = 32.9413658m,
         },

         new Address
         {
             Id = Guid.Parse("e9fb63d1-c9d3-4c1d-abe0-5ddd74863cc9"),
             City = "Ocumare de la Costa",
             Country = "Venezuela",
             CreatedDate = DateTime.Now,
             Province = "Ocumare de la Costa",
             Description = "Suite 39",
             AddressText = "7047 Northfield Place",
             ZipCode = "70936",
             Longitude = 67.7690497m,
             Latitude = 10.4600937m,
         },

         new Address
         {
             Id = Guid.Parse("eb91cdbe-34ab-4dfd-bdcc-2dcc1bc4f37b"),
             City = "Kuressaare",
             Country = "Estonia",
             CreatedDate = DateTime.Now,
             Province = "Kuressaare",
             Description = "Apt 930",
             AddressText = "8134 Meadow Valley Way",
             ZipCode = "42644",
             Longitude = 22.4850409m,
             Latitude = 58.2529231m,
         },

         new Address
         {
             Id = Guid.Parse("ec572ecd-e561-417b-bbeb-4264b3e5f9d7"),
             City = "Aytos",
             Country = "Bulgaria",
             CreatedDate = DateTime.Now,
             Province = "Aytos",
             Description = "Suite 58",
             AddressText = "625 Summit Pass",
             ZipCode = "38788",
             Longitude = 23.3067353m,
             Latitude = 42.7066497m,
         },

         new Address
         {
             Id = Guid.Parse("f1309077-1873-43b4-9a94-69c3f725469a"),
             City = "Laascaanood",
             Country = "Somalia",
             CreatedDate = DateTime.Now,
             Province = "Laascaanood",
             Description = "Apt 800",
             AddressText = "15 Schlimgen Place",
             ZipCode = "13399",
             Longitude = 47.3657603m,
             Latitude = 8.475987m,
         },

         new Address
         {
             Id = Guid.Parse("f4016e88-7709-498d-8747-43c6dc5c2bbe"),
             City = "Radā‘",
             Country = "Yemen",
             CreatedDate = DateTime.Now,
             Province = "Radā‘",
             Description = "Room 378",
             AddressText = "12 Starling Street",
             ZipCode = "19522",
             Longitude = 44.836578m,
             Latitude = 14.41225m,
         },

         new Address
         {
             Id = Guid.Parse("fc7404c2-7c0a-471a-bf8f-5359c6671f6b"),
             City = "Tinampo",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Tinampo",
             Description = "Suite 49",
             AddressText = "3482 Eagle Crest Alley",
             ZipCode = "42217",
             Longitude = 124.0576816m,
             Latitude = 12.7145722m,
         },

         new Address
         {
             Id = Guid.Parse("fceb4e29-8b84-4aa5-886f-914dd7a660cb"),
             City = "Kawangu Satu",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Kawangu Satu",
             Description = "PO Box 22770",
             AddressText = "06 Rigney Circle",
             ZipCode = "32841",
             Longitude = 120.3322404m,
             Latitude = 9.6923735m,
         },

         new Address
         {
             Id = Guid.Parse("fde272d9-3821-4297-a876-832fab0fc149"),
             City = "Thiès Nones",
             Country = "Senegal",
             CreatedDate = DateTime.Now,
             Province = "Thiès Nones",
             Description = "12th Floor",
             AddressText = "49629 Carpenter Avenue",
             ZipCode = "39213",
             Longitude = 16.9638997m,
             Latitude = 14.7790314m,
         },

         new Address
         {
             Id = Guid.Parse("13a8cffa-ff13-4ab0-9ee4-40e834a221cf"),
             City = "Kashar",
             Country = "Albania",
             CreatedDate = DateTime.Now,
             Province = "Kashar",
             Description = "PO Box 44913",
             AddressText = "158 Burning Wood Avenue",
             ZipCode = "10863",
             Longitude = 19.7234519m,
             Latitude = 41.3445243m,
         },

         new Address
         {
             Id = Guid.Parse("21b1bd76-a1f9-4094-a734-d016f23500bb"),
             City = "Ghayl Bā Wazīr",
             Country = "Yemen",
             CreatedDate = DateTime.Now,
             Province = "Ghayl Bā Wazīr",
             Description = "19th Floor",
             AddressText = "61407 Blue Bill Park Crossing",
             ZipCode = "11591",
             Longitude = 49.3805473m,
             Latitude = 14.773124m,
         },

         new Address
         {
             Id = Guid.Parse("54d3dbf2-2d6a-4222-9c29-81f17ca6d8c5"),
             City = "Pereleshino",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Pereleshino",
             Description = "Apt 996",
             AddressText = "644 Kipling Alley",
             ZipCode = "37450",
             Longitude = 40.1348656m,
             Latitude = 51.7386378m,
         },

         new Address
         {
             Id = Guid.Parse("59e90322-5bcb-40bb-ac45-2e61c72fd703"),
             City = "Sanlicheng",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Sanlicheng",
             Description = "Suite 34",
             AddressText = "62190 Donald Way",
             ZipCode = "37506",
             Longitude = 113.2773942m,
             Latitude = 22.6229329m,
         },

         new Address
         {
             Id = Guid.Parse("be1a65c2-717c-4b63-a65c-6c89c5eed280"),
             City = "Colombo",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Colombo",
             Description = "PO Box 78065",
             AddressText = "517 Magdeline Alley",
             ZipCode = "30298",
             Longitude = 49.2266344m,
             Latitude = 25.2929784m,
         },

         new Address
         {
             Id = Guid.Parse("c5119dae-6a3b-402e-9e88-79551cf86b80"),
             City = "Majunying",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Majunying",
             Description = "Suite 87",
             AddressText = "9 West Point",
             ZipCode = "48791",
             Longitude = 113.249246m,
             Latitude = 40.094835m,
         },

         new Address
         {
             Id = Guid.Parse("d6e6cd52-cdcf-49f5-9ee7-ef374facaff2"),
             City = "San Juan del Cesar",
             Country = "Colombia",
             CreatedDate = DateTime.Now,
             Province = "San Juan del Cesar",
             Description = "18th Floor",
             AddressText = "87 Holy Cross Circle",
             ZipCode = "14072",
             Longitude = 73.0021534m,
             Latitude = 10.7698637m,
         },

         new Address
         {
             Id = Guid.Parse("e409cda7-a8a6-4019-8fda-9af53839715f"),
             City = "Sibulan",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Sibulan",
             Description = "Room 1211",
             AddressText = "16 Melody Avenue",
             ZipCode = "36850",
             Longitude = 123.291063m,
             Latitude = 9.338682m,
         },

         new Address
         {
             Id = Guid.Parse("ecf88e85-43af-4536-b3d2-a5a865dec1df"),
             City = "Cikiruh Wetan",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Cikiruh Wetan",
             Description = "PO Box 63326",
             AddressText = "217 South Hill",
             ZipCode = "47249",
             Longitude = 105.5532993m,
             Latitude = 7.0071351m,
         },

         new Address
         {
             Id = Guid.Parse("fac641c9-7635-41e2-b884-483f161bf440"),
             City = "San Fernando",
             Country = "Honduras",
             CreatedDate = DateTime.Now,
             Province = "San Fernando",
             Description = "Room 49",
             AddressText = "2 Del Mar Street",
             ZipCode = "17658",
             Longitude = 89.1128205m,
             Latitude = 14.6826072m,
         },

         new Address
         {
             Id = Guid.Parse("0a5711ef-36b6-4fab-bb16-9eddb85740fb"),
             City = "Cañuelas",
             Country = "Argentina",
             CreatedDate = DateTime.Now,
             Province = "Cañuelas",
             Description = "Room 1891",
             AddressText = "212 Stang Trail",
             ZipCode = "54518",
             Longitude = 58.6433296m,
             Latitude = 34.5875578m,
         },

         new Address
         {
             Id = Guid.Parse("2d4a8ebf-1d35-461c-ac03-04049f49be62"),
             City = "Rio Pardo",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Rio Pardo",
             Description = "Apt 924",
             AddressText = "62883 Loomis Avenue",
             ZipCode = "54898",
             Longitude = 52.3760103m,
             Latitude = 29.984393m,
         },

         new Address
         {
             Id = Guid.Parse("43e6aa4d-1152-4737-803d-af8c5887c43b"),
             City = "Karlstad",
             Country = "Sweden",
             CreatedDate = DateTime.Now,
             Province = "Karlstad",
             Description = "10th Floor",
             AddressText = "18 Anniversary Hill",
             ZipCode = "54867",
             Longitude = 13.5143586m,
             Latitude = 59.3720912m,
         },

         new Address
         {
             Id = Guid.Parse("50d5b675-9b6a-481e-be9e-a2ef64d79125"),
             City = "Kaloyanovo",
             Country = "Bulgaria",
             CreatedDate = DateTime.Now,
             Province = "Kaloyanovo",
             Description = "Room 369",
             AddressText = "86 Declaration Circle",
             ZipCode = "54585",
             Longitude = 23.2572455m,
             Latitude = 42.671377m,
         },

         new Address
         {
             Id = Guid.Parse("7d896232-affb-406c-b2ed-c60a97685675"),
             City = "Sumbergedong",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Sumbergedong",
             Description = "PO Box 4600",
             AddressText = "038 Roxbury Place",
             ZipCode = "54097",
             Longitude = 111.7167504m,
             Latitude = 8.0563346m,
         },

         new Address
         {
             Id = Guid.Parse("8de661d7-c8a1-47a7-bdbd-f48e87824735"),
             City = "Rongelap",
             Country = "Marshall Islands",
             CreatedDate = DateTime.Now,
             Province = "Rongelap",
             Description = "Apt 1400",
             AddressText = "1 Hayes Street",
             ZipCode = "54245",
             Longitude = 166.887052m,
             Latitude = 11.1572834m,
         },

         new Address
         {
             Id = Guid.Parse("96a9a8a2-1d5f-455f-b22d-50d382f82b52"),
             City = "Thị Trấn Nước Hai",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Thị Trấn Nước Hai",
             Description = "PO Box 60944",
             AddressText = "00 Village Green Circle",
             ZipCode = "54152",
             Longitude = 106.1536828m,
             Latitude = 22.7370366m,
         },

         new Address
         {
             Id = Guid.Parse("97c33e9c-1454-4996-94bc-e9147529a202"),
             City = "Saint-Jean-de-Braye",
             Country = "France",
             CreatedDate = DateTime.Now,
             Province = "Saint-Jean-de-Braye",
             Description = "6th Floor",
             AddressText = "150 Forest Court",
             ZipCode = "54538",
             Longitude = 1.9638715m,
             Latitude = 47.9035673m,
         },

         new Address
         {
             Id = Guid.Parse("a1e2998c-9c91-4002-a58c-18fe7f585aa8"),
             City = "Tianqian",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Tianqian",
             Description = "11th Floor",
             AddressText = "1563 Pennsylvania Center",
             ZipCode = "54315",
             Longitude = 117.3616476m,
             Latitude = 39.3433574m,
         },

         new Address
         {
             Id = Guid.Parse("a2ca3e6a-57a7-4555-805d-339807edff7f"),
             City = "Tambo Grande",
             Country = "Peru",
             CreatedDate = DateTime.Now,
             Province = "Tambo Grande",
             Description = "Suite 28",
             AddressText = "871 Columbus Trail",
             ZipCode = "54004",
             Longitude = 80.3408061m,
             Latitude = 4.9295129m,
         },

         new Address
         {
             Id = Guid.Parse("d1e044ed-59f1-4ea4-bdd3-ca8e7daada23"),
             City = "Ciengang",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Ciengang",
             Description = "3rd Floor",
             AddressText = "3519 Hoepker Road",
             ZipCode = "54314",
             Longitude = 107.0007987m,
             Latitude = 7.0181673m,
         },

         new Address
         {
             Id = Guid.Parse("d6396c04-3f35-401c-b39d-e071ef59da2a"),
             City = "Wuhao",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Wuhao",
             Description = "8th Floor",
             AddressText = "5 West Circle",
             ZipCode = "54522",
             Longitude = 116.3169416m,
             Latitude = 39.7601611m,
         },

         new Address
         {
             Id = Guid.Parse("dcfe2448-1d99-45c3-841a-cb8090df25dd"),
             City = "Kontagora",
             Country = "Nigeria",
             CreatedDate = DateTime.Now,
             Province = "Kontagora",
             Description = "PO Box 51314",
             AddressText = "896 Lillian Trail",
             ZipCode = "54732",
             Longitude = 5.4699173m,
             Latitude = 10.407146m,
         },

         new Address
         {
             Id = Guid.Parse("decd1596-bcba-478a-b8f3-0ba1243d0ced"),
             City = "Misheronskiy",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Misheronskiy",
             Description = "PO Box 66376",
             AddressText = "629 Menomonie Trail",
             ZipCode = "54655",
             Longitude = 39.7362416m,
             Latitude = 55.7184184m,
         },

         new Address
         {
             Id = Guid.Parse("ff90032b-647e-466c-b143-b6c0eee9652b"),
             City = "Taiping",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Taiping",
             Description = "Apt 1311",
             AddressText = "4159 Bonner Avenue",
             ZipCode = "54139",
             Longitude = 6.2634596m,
             Latitude = 53.3004898m,
         },

         new Address
         {
             Id = Guid.Parse("01f6b460-e0f2-4415-81cd-d131c562bb96"),
             City = "Kribi",
             Country = "Cameroon",
             CreatedDate = DateTime.Now,
             Province = "Kribi",
             Description = "Apt 906",
             AddressText = "90 Glendale Center",
             ZipCode = "25866",
             Longitude = 9.9101915m,
             Latitude = 2.9405941m,
         },

         new Address
         {
             Id = Guid.Parse("0322111e-295b-4823-ab25-fcf940bcd06c"),
             City = "Sindangjati",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Sindangjati",
             Description = "Apt 327",
             AddressText = "0 8th Road",
             ZipCode = "25497",
             Longitude = 102.6934048m,
             Latitude = 3.4964316m,
         },

         new Address
         {
             Id = Guid.Parse("057fecef-eaf9-4f73-b399-a5a09c45a197"),
             City = "Xiaolongmen",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Xiaolongmen",
             Description = "Suite 74",
             AddressText = "3 Maryland Terrace",
             ZipCode = "22895",
             Longitude = 117.103146m,
             Latitude = 40.412369m,
         },

         new Address
         {
             Id = Guid.Parse("0a719d43-6ede-474c-9427-67ac89363640"),
             City = "Székesfehérvár",
             Country = "Hungary",
             CreatedDate = DateTime.Now,
             Province = "Székesfehérvár",
             Description = "Suite 99",
             AddressText = "0229 Almo Way",
             ZipCode = "24069",
             Longitude = 18.4095578m,
             Latitude = 47.1910839m,
         },

         new Address
         {
             Id = Guid.Parse("15c657e5-8516-41e1-9aa3-60c949796e38"),
             City = "Oranmore",
             Country = "Ireland",
             CreatedDate = DateTime.Now,
             Province = "Oranmore",
             Description = "PO Box 47446",
             AddressText = "1 Lakeland Place",
             ZipCode = "25779",
             Longitude = 9.7359765m,
             Latitude = 54.1433253m,
         },

         new Address
         {
             Id = Guid.Parse("1dc76ef3-6be1-4759-b965-c1706927e19d"),
             City = "Oulmes",
             Country = "Morocco",
             CreatedDate = DateTime.Now,
             Province = "Oulmes",
             Description = "15th Floor",
             AddressText = "186 Reinke Circle",
             ZipCode = "21567",
             Longitude = 6.0017674m,
             Latitude = 33.425066m,
         },

         new Address
         {
             Id = Guid.Parse("1efbc072-d038-4a08-b9d4-ad03371c2eb2"),
             City = "Wudan",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Wudan",
             Description = "Apt 968",
             AddressText = "6 Loomis Street",
             ZipCode = "24657",
             Longitude = 106.750625m,
             Latitude = 26.630845m,
         },

         new Address
         {
             Id = Guid.Parse("25e189ae-3906-4b91-8a9a-504508841b12"),
             City = "Santa Clara La Laguna",
             Country = "Guatemala",
             CreatedDate = DateTime.Now,
             Province = "Santa Clara La Laguna",
             Description = "Apt 1600",
             AddressText = "66844 Spaight Center",
             ZipCode = "24087",
             Longitude = 91.3019094m,
             Latitude = 14.7174829m,
         },

         new Address
         {
             Id = Guid.Parse("2af3ecb9-279b-47e9-b1a7-e1e9a54dd412"),
             City = "Cafe",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Cafe",
             Description = "Room 388",
             AddressText = "484 Ramsey Place",
             ZipCode = "23036",
             Longitude = 121.0460866m,
             Latitude = 14.554384m,
         },

         new Address
         {
             Id = Guid.Parse("2e2e7392-632c-4985-9dfe-57550bba809a"),
             City = "Ciherang",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Ciherang",
             Description = "Apt 1665",
             AddressText = "466 Forest Dale Street",
             ZipCode = "26724",
             Longitude = 106.7441048m,
             Latitude = 6.5864219m,
         },

         new Address
         {
             Id = Guid.Parse("466ffbbe-d5a7-43d5-9e8f-7d0b1fbd8045"),
             City = "Krasnoznamensk",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Krasnoznamensk",
             Description = "15th Floor",
             AddressText = "27749 Lerdahl Avenue",
             ZipCode = "21003",
             Longitude = 37.0361031m,
             Latitude = 55.597144m,
         },

         new Address
         {
             Id = Guid.Parse("4bbb47b0-d2b7-4363-bae5-abd88b8262c5"),
             City = "Chiquimulilla",
             Country = "Guatemala",
             CreatedDate = DateTime.Now,
             Province = "Chiquimulilla",
             Description = "Room 1695",
             AddressText = "7 Northridge Trail",
             ZipCode = "26998",
             Longitude = 90.3793599m,
             Latitude = 14.0804623m,
         },

         new Address
         {
             Id = Guid.Parse("5068c7a7-eb3d-4453-953b-46293a9a2232"),
             City = "Indianapolis",
             Country = "United States",
             CreatedDate = DateTime.Now,
             Province = "Indianapolis",
             Description = "5th Floor",
             AddressText = "83456 Fieldstone Lane",
             ZipCode = "27284",
             Longitude = 86.1700894m,
             Latitude = 39.7794767m,
         },

         new Address
         {
             Id = Guid.Parse("52699924-e389-4495-a509-56347e49561a"),
             City = "Trondheim",
             Country = "Norway",
             CreatedDate = DateTime.Now,
             Province = "Trondheim",
             Description = "Apt 1495",
             AddressText = "7507 Cody Street",
             ZipCode = "24820",
             Longitude = 10.4677043m,
             Latitude = 63.4251464m,
         },

         new Address
         {
             Id = Guid.Parse("56659f7c-ad1f-4dc4-a97a-63ff7b8b09f1"),
             City = "Ganjur",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Ganjur",
             Description = "8th Floor",
             AddressText = "10 Sutteridge Drive",
             ZipCode = "27916",
             Longitude = 110.6909294m,
             Latitude = 7.0954176m,
         },

         new Address
         {
             Id = Guid.Parse("5afebc81-436a-420c-9581-6f15384755b1"),
             City = "Mlaka pri Kranju",
             Country = "Slovenia",
             CreatedDate = DateTime.Now,
             Province = "Mlaka pri Kranju",
             Description = "Room 1839",
             AddressText = "66 Eagan Way",
             ZipCode = "26313",
             Longitude = 14.349659m,
             Latitude = 46.2840425m,
         },

         new Address
         {
             Id = Guid.Parse("62f52efd-1eb2-4363-ab16-27862d772b16"),
             City = "Bến Cầu",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Bến Cầu",
             Description = "Suite 29",
             AddressText = "4535 Clyde Gallagher Alley",
             ZipCode = "26915",
             Longitude = 106.0875326m,
             Latitude = 11.1506368m,
         },

         new Address
         {
             Id = Guid.Parse("6a8aa20a-cdf4-4f98-be07-7add14dcfdc6"),
             City = "Bocana de Paiwas",
             Country = "Nicaragua",
             CreatedDate = DateTime.Now,
             Province = "Bocana de Paiwas",
             Description = "PO Box 54505",
             AddressText = "2861 Merrick Street",
             ZipCode = "27809",
             Longitude = 85.1233m,
             Latitude = 12.7878653m,
         },

         new Address
         {
             Id = Guid.Parse("6c3981aa-5409-467a-adba-fb1ae96e9721"),
             City = "Banjar Dukuh",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Banjar Dukuh",
             Description = "Suite 69",
             AddressText = "69 Johnson Park",
             ZipCode = "21779",
             Longitude = 108.5693704m,
             Latitude = 7.3552614m,
         },

         new Address
         {
             Id = Guid.Parse("6d1093be-383e-401f-86b0-af3dfe867d76"),
             City = "Sosnovka",
             Country = "Russia",
             CreatedDate = DateTime.Now,
             Province = "Sosnovka",
             Description = "4th Floor",
             AddressText = "66300 Kenwood Terrace",
             ZipCode = "25092",
             Longitude = 33.2921685m,
             Latitude = 54.1347287m,
         },

         new Address
         {
             Id = Guid.Parse("716931f1-2f4c-4a40-9323-8c94f74dca4f"),
             City = "Kut Bak",
             Country = "Thailand",
             CreatedDate = DateTime.Now,
             Province = "Kut Bak",
             Description = "PO Box 37063",
             AddressText = "20 Lighthouse Bay Terrace",
             ZipCode = "21492",
             Longitude = 103.8680047m,
             Latitude = 16.9535975m,
         },

         new Address
         {
             Id = Guid.Parse("75f80a41-8749-4703-ac19-dae165ed94d9"),
             City = "Triolet",
             Country = "Mauritius",
             CreatedDate = DateTime.Now,
             Province = "Triolet",
             Description = "20th Floor",
             AddressText = "401 North Parkway",
             ZipCode = "24125",
             Longitude = 57.5504453m,
             Latitude = 20.0583696m,
         },

         new Address
         {
             Id = Guid.Parse("82619502-d1cd-43bd-9502-eb69056ed157"),
             City = "Huandiqiao",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Huandiqiao",
             Description = "Room 882",
             AddressText = "33873 Armistice Alley",
             ZipCode = "27433",
             Longitude = 118.6422409m,
             Latitude = 24.9372186m,
         },

         new Address
         {
             Id = Guid.Parse("872d0c2b-64bd-4c98-b19d-05eb65ab95b1"),
             City = "Rio Piracicaba",
             Country = "Brazil",
             CreatedDate = DateTime.Now,
             Province = "Rio Piracicaba",
             Description = "Apt 320",
             AddressText = "1083 Blackbird Center",
             ZipCode = "27634",
             Longitude = 43.1359542m,
             Latitude = 19.9661142m,
         },

         new Address
         {
             Id = Guid.Parse("8bb17f41-ecfd-4a71-9492-4aed0bcb9a34"),
             City = "Heishan",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Heishan",
             Description = "Suite 68",
             AddressText = "176 Rowland Parkway",
             ZipCode = "26168",
             Longitude = 122.1234429m,
             Latitude = 41.666028m,
         },

         new Address
         {
             Id = Guid.Parse("981cf038-2919-4993-81bc-fedaa9cb8384"),
             City = "Kebonagung",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Kebonagung",
             Description = "11th Floor",
             AddressText = "5856 Saint Paul Road",
             ZipCode = "23046",
             Longitude = 113.6770012m,
             Latitude = 8.1611036m,
         },

         new Address
         {
             Id = Guid.Parse("996828f8-ffda-4975-beae-0f4b620d7243"),
             City = "Gio Linh",
             Country = "Vietnam",
             CreatedDate = DateTime.Now,
             Province = "Gio Linh",
             Description = "Room 1733",
             AddressText = "5390 Riverside Lane",
             ZipCode = "22863",
             Longitude = 107.0303221m,
             Latitude = 16.9165711m,
         },

         new Address
         {
             Id = Guid.Parse("a2bf3192-a73b-49f2-94e5-7633be31cb25"),
             City = "Xuefu",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Xuefu",
             Description = "Room 1720",
             AddressText = "607 Manitowish Trail",
             ZipCode = "26505",
             Longitude = 120.6648587m,
             Latitude = 28.043902m,
         },

         new Address
         {
             Id = Guid.Parse("a677664d-848e-441d-b802-2f1b64164892"),
             City = "Nogueira do Cravo",
             Country = "Portugal",
             CreatedDate = DateTime.Now,
             Province = "Nogueira do Cravo",
             Description = "PO Box 98896",
             AddressText = "9476 Raven Plaza",
             ZipCode = "24194",
             Longitude = 7.883045m,
             Latitude = 40.3356039m,
         },

         new Address
         {
             Id = Guid.Parse("a6cc3703-1dd5-4d82-95aa-8059ca166a88"),
             City = "Xinglong",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Xinglong",
             Description = "PO Box 56721",
             AddressText = "9321 Spenser Alley",
             ZipCode = "21461",
             Longitude = 117.500558m,
             Latitude = 40.417358m,
         },

         new Address
         {
             Id = Guid.Parse("a7a4992f-7fb3-4e3f-bdd8-b058393514cc"),
             City = "Houston",
             Country = "United States",
             CreatedDate = DateTime.Now,
             Province = "Houston",
             Description = "Suite 66",
             AddressText = "294 Carberry Avenue",
             ZipCode = "25936",
             Longitude = 95.4935119m,
             Latitude = 29.6464527m,
         },

         new Address
         {
             Id = Guid.Parse("a8e883c4-563f-46b2-8e1e-884aaf9987e3"),
             City = "Borino",
             Country = "Bulgaria",
             CreatedDate = DateTime.Now,
             Province = "Borino",
             Description = "Apt 419",
             AddressText = "552 Hovde Center",
             ZipCode = "27682",
             Longitude = 24.2930311m,
             Latitude = 41.6840477m,
         },

         new Address
         {
             Id = Guid.Parse("b26b937b-837c-4bce-9cd3-ad3dab0ab11e"),
             City = "Sembakung",
             Country = "Indonesia",
             CreatedDate = DateTime.Now,
             Province = "Sembakung",
             Description = "PO Box 78075",
             AddressText = "7 Truax Court",
             ZipCode = "24413",
             Longitude = 117.2205771m,
             Latitude = 3.8024611m,
         },

         new Address
         {
             Id = Guid.Parse("bfa601ce-4e72-465f-aead-4dc3b4334c09"),
             City = "Bukal Sur",
             Country = "Philippines",
             CreatedDate = DateTime.Now,
             Province = "Bukal Sur",
             Description = "15th Floor",
             AddressText = "78191 Barby Circle",
             ZipCode = "21475",
             Longitude = 121.421617m,
             Latitude = 13.928808m,
         },

         new Address
         {
             Id = Guid.Parse("c2483137-9079-4301-9268-bfeac88cfe52"),
             City = "Hengjie",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Hengjie",
             Description = "Suite 73",
             AddressText = "4765 Saint Paul Avenue",
             ZipCode = "21308",
             Longitude = 119.659553m,
             Latitude = 31.031933m,
         },

         new Address
         {
             Id = Guid.Parse("c9b4747c-bdb6-49ba-b57a-61e4a2611b40"),
             City = "Hartford",
             Country = "United States",
             CreatedDate = DateTime.Now,
             Province = "Hartford",
             Description = "Suite 8",
             AddressText = "538 Troy Trail",
             ZipCode = "22908",
             Longitude = 72.7038047m,
             Latitude = 41.7721061m,
         },

         new Address
         {
             Id = Guid.Parse("d0ba6d2c-c317-42cd-ab9f-78273efe46f3"),
             City = "Menghe",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Menghe",
             Description = "Suite 52",
             AddressText = "937 Sachs Street",
             ZipCode = "21242",
             Longitude = 119.847051m,
             Latitude = 32.006965m,
         },

         new Address
         {
             Id = Guid.Parse("d3110ae5-500d-47db-afaf-d2e30cad13b5"),
             City = "Yangqing",
             Country = "China",
             CreatedDate = DateTime.Now,
             Province = "Yangqing",
             Description = "3rd Floor",
             AddressText = "07 Banding Junction",
             ZipCode = "25644",
             Longitude = 115.974848m,
             Latitude = 40.456951m,
         },

         new Address
         {
             Id = Guid.Parse("d9fb36bd-83c4-4edb-b47e-cb50740429d8"),
             City = "Karlstad",
             Country = "Sweden",
             CreatedDate = DateTime.Now,
             Province = "Karlstad",
             Description = "PO Box 2849",
             AddressText = "42521 Kropf Trail",
             ZipCode = "27555",
             Longitude = 13.499827m,
             Latitude = 59.3800269m,
         },

         new Address
         {
             Id = Guid.Parse("de0e49c0-477e-49fd-a8b9-8245d73d1a01"),
             City = "Tsagaan-Ovoo",
             Country = "Mongolia",
             CreatedDate = DateTime.Now,
             Province = "Tsagaan-Ovoo",
             Description = "PO Box 38678",
             AddressText = "5 Shopko Center",
             ZipCode = "24368",
             Longitude = 113.2344326m,
             Latitude = 48.5686975m,
         },

         new Address
         {
             Id = Guid.Parse("ee4bb937-6e8c-4e7c-9784-e600ebff9f3b"),
             City = "Ambohitrolomahitsy",
             Country = "Madagascar",
             CreatedDate = DateTime.Now,
             Province = "Ambohitrolomahitsy",
             Description = "Apt 1729",
             AddressText = "1 Waxwing Terrace",
             ZipCode = "21978",
             Longitude = 47.683333m,
             Latitude = 18.7m,
         },

         new Address
         {
             Id = Guid.Parse("ef807d91-2b60-40dc-a60a-6c5b1e78286c"),
             City = "Newmarket on Fergus",
             Country = "Ireland",
             CreatedDate = DateTime.Now,
             Province = "Newmarket on Fergus",
             Description = "Room 1980",
             AddressText = "338 East Place",
             ZipCode = "21865",
             Longitude = 8.8950821m,
             Latitude = 52.7604883m,
         },

         new Address
         {
             Id = Guid.Parse("ef8c0bcd-6d38-4789-b519-172378dbfb88"),
             City = "Kuchinarai",
             Country = "Thailand",
             CreatedDate = DateTime.Now,
             Province = "Kuchinarai",
             Description = "Room 872",
             AddressText = "786 Pennsylvania Parkway",
             ZipCode = "24368",
             Longitude = 104.0304535m,
             Latitude = 16.504382m,
         },

         new Address
         {
             Id = Guid.Parse("f5630a8b-bf84-416e-9eab-e1d86d8edb0d"),
             City = "Punkalaidun",
             Country = "Finland",
             CreatedDate = DateTime.Now,
             Province = "Punkalaidun",
             Description = "10th Floor",
             AddressText = "3 Michigan Court",
             ZipCode = "23876",
             Longitude = 23.0468306m,
             Latitude = 61.127495m,
         },

         new Address
         {
             Id = Guid.Parse("f5f75d64-367f-4072-9adf-7566310ffec3"),
             City = "Beit Jann",
             Country = "Israel",
             CreatedDate = DateTime.Now,
             Province = "Beit Jann",
             Description = "Suite 44",
             AddressText = "38 Holmberg Hill",
             ZipCode = "25171",
             Longitude = 35.381268m,
             Latitude = 32.965655m,
         }





         );
    }
}