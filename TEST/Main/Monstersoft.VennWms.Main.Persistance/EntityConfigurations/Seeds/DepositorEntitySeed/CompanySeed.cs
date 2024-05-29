using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class CompanySeed : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasData(
                new Company
                {
                    Id = Guid.Parse("db4ba7ff-6c0a-4587-b740-2a002581eb2b"),
                    Code = "SEUR",
                    Name = "Sony Eurasia Pazarlama A.Ş.",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Sony Eurasia Pazarlama A.Ş.",
                    FaxNumber = "0216 444 7 669",
                    PhoneNumber = "0216 444 7 670",
                    TaxNumber = "4569856327",
                    TaxOffice = "Kadıköy VD",
                    AddressId = Guid.Parse("a848aef0-3877-4d4c-88b7-7b1f547b7b9d"),
                },
                new Company
                {
                    Id = Guid.Parse("c8d73b99-f35a-4a13-8f9d-0a35fcbba268"),
                    Code = "SME",
                    Name = "SONY MUSIC ENTERTAINMENT TÜRKİYE TİC. A.Ş.",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "SONY MUSIC ENTERTAINMENT TÜRKİYE TİC. A.Ş.",
                    FaxNumber = "0216 444 7 671",
                    PhoneNumber = "0216 444 7 672",
                    TaxNumber = "7740031516",
                    TaxOffice = "BEŞİKTAŞ VERGİ DAİRESİ MÜD.",
                    AddressId = Guid.Parse("2f200482-4212-4b30-a49a-3de7117dac8a"),
                },

                new Company
                {
                    Id = Guid.Parse("024f9d3f-90c4-43fe-b5f4-1a418a0f1067"),
                    Code = "3425",
                    Name = "Abatz",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Abatz Co.",
                    FaxNumber = "+30 (931) 210-3059",
                    PhoneNumber = "+249 (125) 994-4024",
                    TaxNumber = "73304275",
                    TaxOffice = "Pyrgetós",
                    AddressId = Guid.Parse("e6bcd9b5-8fc4-4a68-9489-ab6c0b67c4d0"),
                },

                new Company
                {
                    Id = Guid.Parse("03c2eac3-0b4a-4e61-9095-a7a64f0bf5d2"),
                    Code = "3235",
                    Name = "Innojam",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Innojam Co.",
                    FaxNumber = "+86 (473) 666-2089",
                    PhoneNumber = "+86 (426) 853-6226",
                    TaxNumber = "74485342",
                    TaxOffice = "Yisuhe",
                    AddressId = Guid.Parse("6b01d8aa-d168-4bb5-9678-c878522246d7"),
                },

                new Company
                {
                    Id = Guid.Parse("0f968ae8-6dd0-47a1-8235-a13210c20cb7"),
                    Code = "1061",
                    Name = "Latz",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Latz Co.",
                    FaxNumber = "+260 (987) 512-6204",
                    PhoneNumber = "+221 (199) 679-6883",
                    TaxNumber = "77061802",
                    TaxOffice = "Livingstone",
                    AddressId = Guid.Parse("57976e4c-d3f6-4fa6-b01d-4831cb778869"),
                },

                new Company
                {
                    Id = Guid.Parse("11db830d-92eb-477d-80a7-935fb88d56f0"),
                    Code = "2571",
                    Name = "Voonte",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Voonte Co.",
                    FaxNumber = "+1 (570) 699-6963",
                    PhoneNumber = "+55 (901) 216-7443",
                    TaxNumber = "70010447",
                    TaxOffice = "Juan Santiago",
                    AddressId = Guid.Parse("e90a6694-9a26-43e3-9311-4740cf20ae52"),
                },

                new Company
                {
                    Id = Guid.Parse("1558c239-22e9-431a-bce6-3d8f2d076151"),
                    Code = "2844",
                    Name = "Innojam",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Innojam Co.",
                    FaxNumber = "+502 (145) 243-0468",
                    PhoneNumber = "+7 (736) 803-2346",
                    TaxNumber = "74096095",
                    TaxOffice = "San Juan Ixcoy",
                    AddressId = Guid.Parse("baee3140-f3db-4e23-a4a9-bd3e27f37d1e"),
                },

                new Company
                {
                    Id = Guid.Parse("19144cba-6104-4217-b260-233e3e294988"),
                    Code = "3135",
                    Name = "Oyondu",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Oyondu Co.",
                    FaxNumber = "+86 (187) 798-9338",
                    PhoneNumber = "+84 (229) 403-1284",
                    TaxNumber = "72673337",
                    TaxOffice = "Chunjing",
                    AddressId = Guid.Parse("adcdd6e2-2789-40e9-8a0c-45a0445ce907"),
                },

                new Company
                {
                    Id = Guid.Parse("20622618-5b1e-4cf3-a976-ec0ef7ede585"),
                    Code = "1706",
                    Name = "Jaxworks",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Jaxworks Co.",
                    FaxNumber = "+420 (822) 682-9194",
                    PhoneNumber = "+62 (102) 751-1157",
                    TaxNumber = "74106288",
                    TaxOffice = "Bořitov",
                    AddressId = Guid.Parse("618b572b-52f0-4f97-a452-3c20f0562dcb"),
                },

                new Company
                {
                    Id = Guid.Parse("240610da-4cb9-4735-b19e-a13a65c47771"),
                    Code = "4247",
                    Name = "Wordware",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Wordware Co.",
                    FaxNumber = "+359 (153) 177-2063",
                    PhoneNumber = "+63 (403) 383-9542",
                    TaxNumber = "76660921",
                    TaxOffice = "Asenovgrad",
                    AddressId = Guid.Parse("363f66b5-51e5-4fe6-a330-1abb6f1b7a92"),
                },

                new Company
                {
                    Id = Guid.Parse("26be9beb-f4dc-47bd-b682-6c9b216446a8"),
                    Code = "3248",
                    Name = "Tambee",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Tambee Co.",
                    FaxNumber = "+93 (387) 468-5603",
                    PhoneNumber = "+86 (899) 132-5775",
                    TaxNumber = "75320303",
                    TaxOffice = "Khulm",
                    AddressId = Guid.Parse("216960b4-e3b4-4c98-bfd8-3f25957576e4"),
                },

                new Company
                {
                    Id = Guid.Parse("34ed5a6a-16b2-4124-a60e-391394cfe2cf"),
                    Code = "4046",
                    Name = "Pixoboo",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Pixoboo Co.",
                    FaxNumber = "+86 (892) 553-5646",
                    PhoneNumber = "+33 (914) 164-1380",
                    TaxNumber = "78163736",
                    TaxOffice = "Sicheng",
                    AddressId = Guid.Parse("728d917a-10dc-4980-9703-ab77f45c4483"),
                },

                new Company
                {
                    Id = Guid.Parse("39b50de2-aac0-4880-a0b1-3f6f548eb8f9"),
                    Code = "3823",
                    Name = "Thoughtworks",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Thoughtworks Co.",
                    FaxNumber = "+502 (636) 716-0000",
                    PhoneNumber = "+7 (444) 333-6613",
                    TaxNumber = "76126139",
                    TaxOffice = "Santa Cruz Balanyá",
                    AddressId = Guid.Parse("90ec990e-2059-4414-8a41-c7781fe45aa7"),
                },

                new Company
                {
                    Id = Guid.Parse("3de5fc99-7bfa-4f96-b49c-93e94f53cc0b"),
                    Code = "4827",
                    Name = "Kazio",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Kazio Co.",
                    FaxNumber = "+86 (748) 400-7632",
                    PhoneNumber = "+48 (384) 532-6198",
                    TaxNumber = "70229906",
                    TaxOffice = "Dougang",
                    AddressId = Guid.Parse("4f97060c-a616-45f5-b800-2190f9894f17"),
                },

                new Company
                {
                    Id = Guid.Parse("3f2d66ce-6f4b-4181-acb1-09a4412e1c6a"),
                    Code = "4730",
                    Name = "Ntag",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Ntag Co.",
                    FaxNumber = "+237 (744) 748-7048",
                    PhoneNumber = "+7 (663) 735-0111",
                    TaxNumber = "71615797",
                    TaxOffice = "Obala",
                    AddressId = Guid.Parse("290975ee-8a6b-4a0f-a318-d924ae8dd9c2"),
                },

                new Company
                {
                    Id = Guid.Parse("4484da07-52db-4fb3-b453-b312d4a9c56d"),
                    Code = "4570",
                    Name = "Pixonyx",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Pixonyx Co.",
                    FaxNumber = "+62 (817) 939-7248",
                    PhoneNumber = "+86 (208) 951-3290",
                    TaxNumber = "75795178",
                    TaxOffice = "Lawepakam",
                    AddressId = Guid.Parse("20ff4a1f-22f6-49a7-be36-3eb1a74aaf16"),
                },

                new Company
                {
                    Id = Guid.Parse("45ccd43b-b187-4e25-aa5f-dc723b429a3f"),
                    Code = "2836",
                    Name = "Livefish",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Livefish Co.",
                    FaxNumber = "+55 (401) 566-0845",
                    PhoneNumber = "+420 (107) 206-4006",
                    TaxNumber = "75479330",
                    TaxOffice = "Vitória",
                    AddressId = Guid.Parse("988052c3-601a-469d-bd6e-c7be74fe96a4"),
                },

                new Company
                {
                    Id = Guid.Parse("472cd981-c3a6-4e52-b9bc-9abaaa811450"),
                    Code = "1493",
                    Name = "Thoughtsphere",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Thoughtsphere Co.",
                    FaxNumber = "+55 (503) 229-5557",
                    PhoneNumber = "+62 (579) 395-6602",
                    TaxNumber = "72388548",
                    TaxOffice = "Itanhandu",
                    AddressId = Guid.Parse("835bb7e9-b7d8-4df4-8866-d1a26082d9b5"),
                },

                new Company
                {
                    Id = Guid.Parse("49a06b5a-f90f-45c1-8bc0-940220657870"),
                    Code = "4532",
                    Name = "Dynabox",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Dynabox Co.",
                    FaxNumber = "+380 (104) 835-9474",
                    PhoneNumber = "+358 (770) 971-7849",
                    TaxNumber = "76884691",
                    TaxOffice = "Dzvinogrud",
                    AddressId = Guid.Parse("fbdca189-0ef5-4887-8935-c45638586eeb"),
                },

                new Company
                {
                    Id = Guid.Parse("5b1baf2b-f44d-4c93-b9da-578605f19a26"),
                    Code = "2853",
                    Name = "Browsebug",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Browsebug Co.",
                    FaxNumber = "+86 (798) 828-2069",
                    PhoneNumber = "+237 (916) 858-7752",
                    TaxNumber = "75329472",
                    TaxOffice = "Wangmo",
                    AddressId = Guid.Parse("2adc34ec-0be9-4dcc-95b1-63d4d65211e3"),
                },

                new Company
                {
                    Id = Guid.Parse("5dd948b7-66fd-456a-8361-3ad980dcb426"),
                    Code = "2291",
                    Name = "LiveZ",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "LiveZ Co.",
                    FaxNumber = "+55 (986) 849-3760",
                    PhoneNumber = "+961 (531) 858-7942",
                    TaxNumber = "76505209",
                    TaxOffice = "Lagoa Vermelha",
                    AddressId = Guid.Parse("65b7b8d0-a629-4482-a55d-ac404146a0f1"),
                },

                new Company
                {
                    Id = Guid.Parse("5fe5f7a9-3946-4c93-b289-0db320cd9f57"),
                    Code = "3689",
                    Name = "Realfire",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Realfire Co.",
                    FaxNumber = "+94 (781) 104-2335",
                    PhoneNumber = "+86 (401) 107-2494",
                    TaxNumber = "72007974",
                    TaxOffice = "Puttalam",
                    AddressId = Guid.Parse("c844738f-f512-49f8-a0dc-9c7c820ba7ef"),
                },

                new Company
                {
                    Id = Guid.Parse("608abfba-ab92-4fb5-a2cc-31e3603b8094"),
                    Code = "1609",
                    Name = "Babblestorm",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Babblestorm Co.",
                    FaxNumber = "+62 (917) 966-9581",
                    PhoneNumber = "+351 (711) 281-2796",
                    TaxNumber = "71406627",
                    TaxOffice = "Cimenga",
                    AddressId = Guid.Parse("8a691cfd-e833-4ade-9843-2cbabcdd0fd2"),
                },

                new Company
                {
                    Id = Guid.Parse("85f54b14-e554-40de-bee8-5363fe291085"),
                    Code = "1280",
                    Name = "Chatterbridge",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Chatterbridge Co.",
                    FaxNumber = "+359 (986) 959-8565",
                    PhoneNumber = "+7 (957) 773-1510",
                    TaxNumber = "78624385",
                    TaxOffice = "Sozopol",
                    AddressId = Guid.Parse("fbe15b94-967a-4ef3-9fab-1bcbbd396bc9"),
                },

                new Company
                {
                    Id = Guid.Parse("9851bd4a-8bef-44ab-a209-73650f97d9fa"),
                    Code = "1431",
                    Name = "Yodel",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Yodel Co.",
                    FaxNumber = "+63 (611) 879-1186",
                    PhoneNumber = "+92 (918) 273-4485",
                    TaxNumber = "78215444",
                    TaxOffice = "Calumpang",
                    AddressId = Guid.Parse("aeb06a44-cc42-4425-bb9b-5cd669323546"),
                },

                new Company
                {
                    Id = Guid.Parse("a6bf5d8a-bf77-490b-b797-83400ed5bec3"),
                    Code = "1999",
                    Name = "Meezzy",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Meezzy Co.",
                    FaxNumber = "+48 (290) 690-8891",
                    PhoneNumber = "+504 (625) 139-9221",
                    TaxNumber = "72243950",
                    TaxOffice = "Milówka",
                    AddressId = Guid.Parse("15d2b1e7-8921-4573-9720-fa4a4b424009"),
                },

                new Company
                {
                    Id = Guid.Parse("b990cf60-ea2f-4951-a523-b28f18cc0a1a"),
                    Code = "2839",
                    Name = "Avamm",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Avamm Co.",
                    FaxNumber = "+55 (411) 743-2357",
                    PhoneNumber = "+55 (444) 374-8399",
                    TaxNumber = "76628869",
                    TaxOffice = "Cacequi",
                    AddressId = Guid.Parse("a4acf787-932c-44e9-8325-26ce46ce605a"),
                },

                new Company
                {
                    Id = Guid.Parse("c3ea73fe-ffa4-4f12-9586-7f2cfc58dc30"),
                    Code = "1996",
                    Name = "Buzzshare",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Buzzshare Co.",
                    FaxNumber = "+212 (317) 636-7484",
                    PhoneNumber = "+44 (894) 458-4451",
                    TaxNumber = "75542188",
                    TaxOffice = "Adar",
                    AddressId = Guid.Parse("0aef8f49-06ef-4c44-ad4c-314e08f8ac46"),
                },

                new Company
                {
                    Id = Guid.Parse("cda28308-b871-4fe6-b0c8-a6bb93ad242b"),
                    Code = "3713",
                    Name = "Voonix",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Voonix Co.",
                    FaxNumber = "+62 (113) 123-2828",
                    PhoneNumber = "+46 (257) 758-6525",
                    TaxNumber = "71714761",
                    TaxOffice = "Ngujuran",
                    AddressId = Guid.Parse("de6d3509-46b1-4a1d-b2ee-3940343bc322"),
                },

                new Company
                {
                    Id = Guid.Parse("dbfa5faa-fdc6-4aae-80d2-0a218a13f64f"),
                    Code = "1211",
                    Name = "Teklist",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Teklist Co.",
                    FaxNumber = "+7 (967) 987-7178",
                    PhoneNumber = "+86 (554) 750-3956",
                    TaxNumber = "79483291",
                    TaxOffice = "Gornyye Klyuchi",
                    AddressId = Guid.Parse("371c7369-024e-4d87-82af-a434e7291e39"),
                },

                new Company
                {
                    Id = Guid.Parse("e67e09ee-355f-457b-aa2e-e35165b45355"),
                    Code = "4338",
                    Name = "Dabjam",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Dabjam Co.",
                    FaxNumber = "+49 (941) 395-0058",
                    PhoneNumber = "+48 (133) 981-4556",
                    TaxNumber = "79224733",
                    TaxOffice = "Reutlingen",
                    AddressId = Guid.Parse("1ad2f037-6a76-421b-b3c5-5d42a3783a20"),
                },

                new Company
                {
                    Id = Guid.Parse("f00689d9-ad10-49e4-8746-5f31b38a7c89"),
                    Code = "1540",
                    Name = "Tagpad",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Tagpad Co.",
                    FaxNumber = "+351 (706) 999-2615",
                    PhoneNumber = "+86 (642) 894-9619",
                    TaxNumber = "78754060",
                    TaxOffice = "Santa Cruz das Flores",
                    AddressId = Guid.Parse("cfc3674f-2ac1-4f48-87ca-d0c5d2745238"),
                },

                new Company
                {
                    Id = Guid.Parse("f091f2cb-e1a9-411a-95ef-878c571447c2"),
                    Code = "3499",
                    Name = "Yakijo",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Yakijo Co.",
                    FaxNumber = "+55 (106) 399-7684",
                    PhoneNumber = "+86 (203) 256-9752",
                    TaxNumber = "78777239",
                    TaxOffice = "Irecê",
                    AddressId = Guid.Parse("2d946b47-8914-4d7d-81a6-35dcf1a06f65"),
                },

                new Company
                {
                    Id = Guid.Parse("fb76815d-8288-4919-9cde-04f4701ab99e"),
                    Code = "3658",
                    Name = "Divanoodle",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Divanoodle Co.",
                    FaxNumber = "+55 (962) 201-7600",
                    PhoneNumber = "+62 (533) 675-1461",
                    TaxNumber = "74509940",
                    TaxOffice = "Guarabira",
                    AddressId = Guid.Parse("59ca2ca9-d0db-4ea7-bb52-7cac3c4c330e"),
                },

                new Company
                {
                    Id = Guid.Parse("fba018ff-62de-4a0e-ab1a-bdcff8982b30"),
                    Code = "1942",
                    Name = "Oba",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Oba Co.",
                    FaxNumber = "+94 (681) 215-7679",
                    PhoneNumber = "+598 (399) 516-4639",
                    TaxNumber = "73475107",
                    TaxOffice = "Nuwara Eliya",
                    AddressId = Guid.Parse("82c577fa-3dc4-496d-a4f8-6549ffff8ec0"),
                },

                new Company
                {
                    Id = Guid.Parse("fd477cbb-dbef-400d-8193-26bcf35a3403"),
                    Code = "2787",
                    Name = "Minyx",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Minyx Co.",
                    FaxNumber = "+55 (724) 496-1157",
                    PhoneNumber = "+359 (854) 207-9665",
                    TaxNumber = "71181483",
                    TaxOffice = "Posse",
                    AddressId = Guid.Parse("65578bc9-10a4-40cc-a199-1e789cc4b64d"),
                },

                new Company
                {
                    Id = Guid.Parse("fddc81ff-866b-408c-86c3-bb43b18c556b"),
                    Code = "4013",
                    Name = "Devpoint",
                    CreatedDate = DateTime.Now,
                    DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                    Description = "Devpoint Co.",
                    FaxNumber = "+371 (315) 288-3853",
                    PhoneNumber = "+351 (777) 259-6005",
                    TaxNumber = "74726331",
                    TaxOffice = "Daugavpils",
                    AddressId = Guid.Parse("39465ea2-3fa1-435d-bc59-b1a366d4683f"),
                }

                );
    }
}
