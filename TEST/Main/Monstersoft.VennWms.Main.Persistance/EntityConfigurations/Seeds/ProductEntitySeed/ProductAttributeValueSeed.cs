using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ProductAttributeValueSeed : IEntityTypeConfiguration<ProductAttributeValue>
{
    public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
    {
        builder.HasData(
            new ProductAttributeValue
            {
                Id = Guid.Parse("004074c9-2285-4003-9980-d4171159d343"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("00e396fa-f5cd-4287-9fbb-be7b8497767c"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-4-9",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("00e95abc-73af-4e34-a4a9-fa6d8124ca34"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-11-22",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("011eaeec-2696-4e3a-b925-91477e9b171b"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-1-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0277b09e-c3f9-4936-83a7-8f1491f3943b"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("02eb16bd-216b-4656-b49c-39727ec08061"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("03b7699e-7f78-43db-9e0b-0137d87f3624"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0424a45b-644c-4f89-861a-d96e1d0e91e7"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-3-21",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("058dcac3-5325-4783-bb9b-931441642a2f"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "37",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("05926d4d-2717-4e57-8547-d461ebec4b6b"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("059b1182-a15a-4e50-9c45-ed3b17128114"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("059f2fb5-7d04-4f9c-b9fa-ec7dbc3062cf"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("065308a9-0c17-471e-adc1-c0c2d5710f68"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-11-1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("06a92fcd-c24a-4f75-86c7-344c3de1a272"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-9-21",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("06dde1b0-0f11-41d5-bc7a-b7d769b096f2"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("06ed21b3-f7fe-491b-b485-cfdcb697e19a"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0764f030-8bf8-46e4-9545-f7e13cd68aaf"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "66",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0808f18d-937e-435f-b130-55cc145df5a8"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("08618f13-5f92-4258-9179-01364b2214a7"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("09abd7a7-d8bd-46e1-9757-dc77d91408a8"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("09e2116a-3f09-426d-8f4d-ef915d093d85"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0ae273e3-01ef-48a9-a7bd-179b7357be8c"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0b6f030d-2e64-484e-a18f-9293f59a4417"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0b8c7b4d-b673-41d6-bee5-1711762a3dd5"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0bf01bef-0b03-4b00-bd19-7994e6ef1c0a"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0c8f6c01-b895-4d1c-a4ca-da5f59fbbe8c"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0c93cc8b-8487-4fcd-bc92-8ddce6b604ff"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2015-1-26",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0d1bb0c9-129d-4ee7-840a-ad5c0c9809be"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0d6c56e6-0841-4d25-a143-423a48265da9"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "43",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0d9a6f9d-743b-405c-800a-4fb75aaedb96"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0e72a11e-0e14-4f06-9c7a-f6cb5ef6d858"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0e9b5ce2-2306-4390-bb76-4b7ce2a4ea95"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0ed53274-3051-4622-85bc-ed019ecab513"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-1-18",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0f579941-016d-4989-9725-a376b13e55b9"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0f700ebe-6d7b-4f35-a30b-bcf80d9ec1fa"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "59",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0f72f7a4-c65a-42a9-8f03-79d76b7a0fe5"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0f9d4503-29a2-45a0-8840-d73db325516b"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "54",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0fb7cb48-7192-41e8-a90d-a3f3f7356e7f"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("0fd81ad9-2779-44b4-b51d-99db9f10b9ca"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("109b99c0-c80b-4a16-9163-6220a4741237"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "68",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("10afdbaf-f5fe-4e09-98e2-9fb40b967d85"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("113b51c0-6098-48ce-a586-c9586b8435ea"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("114104ed-3043-4542-9993-3960bc06485e"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "76",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("11439a84-5d9a-4740-93b4-140f5f640fc7"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "56",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("134d5a31-41b8-4036-919c-dc77971d6707"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-1-5",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("13ac3f30-4c18-432e-b6f5-696d68c503b8"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("13efe41d-14fd-4527-85b2-db59e3263756"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("16055469-f3cd-4c44-954f-febf2b8a3a3a"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "54",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("163e5c3f-d70c-4407-8079-51726fa8f902"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("16cc364b-581c-4d41-8e5e-bb5bff9aa8aa"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("16d7418f-5ff0-41a6-99ad-62f17b8034d3"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("16ee3851-b339-4460-8f27-bdf9a5a1a5d9"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-6-13",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("172064d2-31f6-4be1-a03e-787103f06e01"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("17edbfec-4e5b-4fc2-88cc-afe54ad6684c"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "69",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1800ddbd-3734-48c7-a42a-99be9d89e501"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("18e6eacd-c9b5-4e69-a159-893a6f168c52"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("18fd2933-80f0-4991-a9b2-8d8ffac7526f"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("19512a3c-5809-4f3d-a51a-245b9a16254a"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "53",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1970f05f-9cb3-43ed-8200-8dc9f2f5917b"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("19a79c86-91a6-4368-8308-4789b631d454"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("19c080a0-1c47-4713-9c77-2ca0c603da28"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1a523fe8-581d-407c-973e-593c77305e39"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1a79017a-6ff5-47da-8aac-021d618a5927"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1ad48168-4413-4e74-bd90-310270dfe68b"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1b74064d-5d7c-4c50-8cf2-700fa656dacf"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1c715781-c06d-4021-9fb0-ad282946baff"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-4-8",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1cc91b85-530b-45c9-8c52-ccf645213be0"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1d33df94-10ec-4be0-a954-467e7e20d7e5"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1d4c0edf-586a-423f-a3f8-90839f9d7026"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-3-7",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1d7c9bfd-dabf-428a-8aca-8c8f1e36f22c"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1db34ccc-8e5d-4996-8629-6101c38e6e88"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1db5bea4-17a2-4370-97d1-f55b3d50617b"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1e184611-5e52-47dc-99a5-ada38d64509a"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1e5e9e2b-4ac0-4f5f-84ef-17db7afb2f0e"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-8-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1f01d0a5-93fa-48c3-a0cc-15418be17371"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-8-2",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1f0b0597-5c98-4136-b2a2-0c1f71d1d2d5"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1f0e9563-3d75-4140-8eae-6e884cacc5b6"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1f2c0e6a-3b10-4a0d-bdf8-5d6f3380615b"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "49",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1fda5379-3474-4fc8-bb70-3b2dcbde4ac2"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-5-5",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("1fec69d0-822d-46ed-8b68-9df616879c5e"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("20298b2e-8d04-4d3b-82cf-94770cc1655f"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("20bc84dc-a9db-4fd7-b7c4-ad72a32243b0"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("21e853d4-15ee-4010-8862-15dfeac96bda"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-3-13",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("222fb133-ce35-42e2-9ce2-6810b2faff85"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "71",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("23077328-c7a1-4d04-8a7c-075ee1dcdec4"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("23191be5-77ef-4719-863e-f3e6ff79cc25"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2015-9-9",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("236fd118-0dbf-48c8-89c5-289742e14d42"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("238653d8-e08d-42d1-805c-7efab6f42c46"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-10-17",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("24237fb2-adc8-4ecb-9893-af881ef5d450"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("25441abc-df6b-4ecb-9047-58a1170b1199"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-10-10",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("26262a74-1abd-4853-a398-4d93f03477ea"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2753e0d3-e3a3-4ff1-bf6c-c17bc0877947"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("27653122-7359-4849-857c-3cf49ba46e79"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("278225c5-37e0-4ec2-bba0-02bbd6b5db1b"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("280c167c-da03-4bca-b29e-22cbbb0ee047"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("28277e08-6095-4d7b-ac64-6de2d9454378"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("28722e49-6a98-4b6f-8635-9f4254c77fab"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("290cc1b5-7a18-4339-98eb-517e838428e6"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("29205afb-ba27-4c5b-9163-03c053911ea0"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("292b0da0-12d7-4036-8861-b10ad909f4e2"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("29498394-0867-4721-ac8b-35d090d63f25"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-10-3",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2961e092-e54c-4c78-a5a1-fbda9f190741"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2b9c2337-0b3d-426f-816b-689d3f414b0f"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2bdd1d2c-de9f-40e1-b7b3-9d0ac4d183dc"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2c37da99-4854-4720-aad4-7fc56d5106c2"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-3-25",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2c8a45a7-009e-41ee-bd3d-69392dcbef04"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2cbb4fbb-dca1-44c6-9073-7f7792002485"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2cbc78c8-2e16-4b6c-ba50-8b20fc51e5d9"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2d016a74-e575-4ba9-a7f2-a79ae784dcd0"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2e3dcb5d-e408-41ae-8215-cad17586e3d3"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2ea99970-1542-441e-ba9f-117658210ab7"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "57",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2f228e54-b348-4e74-88ad-0594e73b5c50"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-10-12",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2f293b14-4e7b-424c-8672-bc924eca783e"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "67",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2fb03fd4-d38d-4dbb-807c-16e5646a01ae"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "50",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("2feaffca-7373-4eb0-84c2-8110cd6e22f6"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("32040a54-2f99-431e-81eb-f509fe9f06d2"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-12-3",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("323cd61b-da18-4dff-a4a4-cc97972876c1"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("327bc77d-4233-4044-85ec-c58260ff7d0a"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("32a41bd8-4251-4dc4-a0fa-3a00151295eb"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "46",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("32c2480e-e5bd-4163-bb9f-87ab13f6b725"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("32c9067d-68af-4b1c-b746-cd96425fa249"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("32f37a46-d460-4806-9a44-6324fcaf9611"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("335b979b-f1c9-4498-9385-ae35737df4d5"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "65",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("33814b8b-476f-4173-a193-647061aa3ee3"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3405773a-f4a8-4020-b0b0-b4fc2eccd67d"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "63",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("343c223c-3b99-47d6-b6e3-8fc104d40b36"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-9-4",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3492cb25-a932-40dc-99c2-62ffbb630cd5"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-3-21",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("34b10996-2173-445e-851a-9c5c8f16befc"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "43",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("34de8e42-0df5-444e-ac95-5a6463ed2c42"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "35",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("353153b4-3858-468a-882a-41687e4f4316"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("35fa7ba9-3d36-4443-bd72-7792e79cc041"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "56",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("36166dac-feac-4356-8ac2-59bd11d5d449"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-7-27",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("36d37fff-68e8-40d9-9ade-6eded1ff9b78"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-9-20",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("37d03ad1-08d5-4f78-a8af-ba730e3b60b7"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-6-21",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("37dfadbf-8e8b-4bdd-ab18-77ceb8110f47"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("386f64d0-245d-4dad-b7c3-bb618bba174c"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "42",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("39de0979-443b-4d80-8da7-af4f67495e30"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("39e8b168-0aee-44e8-bade-2eb7acb11733"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-12-2",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3a72bca6-e3b6-4b91-acc2-fdb91522924f"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3bbb8d96-1426-4c3a-a236-02ca5386a3a6"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3c2704f4-e741-44c5-a4b5-ccad2160443e"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3c499d50-92be-482d-a7ac-833567998bb9"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3c5caa16-ca4d-4da6-abef-6e2f595f160c"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3cc14ac6-bf5a-4cd9-aecf-379e0f2227d0"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3d0ad22b-cab9-4358-b865-5aefa7a6674a"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3d44d0f1-2ecf-4eba-82af-20a035bb7dfc"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3d98a0d7-7ad2-4a5a-b964-c4e502be446d"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3e1c33b6-76d8-438b-9f01-fa7189b584d6"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3e55695a-e4fe-4bcd-81b1-c660dc82e98d"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3e990ec1-9a34-4e2f-8a3c-90558d73ebab"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "35",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3ebf7559-78a4-4ef0-bc01-678f087c5e03"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3ee3bc4a-3639-4ec4-b58f-13963519b643"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-10-22",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3f0c056f-e148-44dd-93b7-2a653a9b3c29"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3f4bae06-8dd3-42a7-b15d-512d8b00dadd"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3fa49b74-6e40-48cd-8238-b086f1b081f9"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("3ffc4d04-5a45-4c06-86a1-c2fa5eb753e7"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("40a939b5-58b9-45e5-82da-c69043444680"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("419c66eb-410b-43ae-8cec-913a9f0cb750"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "59",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("41b01c68-748a-4033-b57f-2ff60fe5efa4"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("41c8b070-d3c3-48a3-b03c-2afefa744f54"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-1-16",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("434168ed-fc5b-4505-b1c2-978af74d4cfd"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "41",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4359ee1f-26af-485f-91aa-fd05de710308"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-5-14",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("43bbef22-d2a4-4e03-820d-0366158d6f6c"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-5-2",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("43bef72f-acb4-46ff-aae0-61f89078905d"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "55",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("43c6499c-8115-4fed-9e4a-57dcff9fef27"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4444299d-b098-49e1-8596-0964d1d77681"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("447128dc-e775-4776-887e-1b21f8c80a44"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("454df749-e082-4908-aab2-86fa8e5c01b3"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("45879c3f-51a6-4389-94de-0da0ef4ca015"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "77",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("45d926c6-98e0-4d5d-8e9d-078f6bcc2f70"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-5-9",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4634c753-2f4c-4c7c-a2d7-59a8663bd5ac"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("46c4def7-405e-4241-b13c-0a5a06c6021f"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("471698db-e3bc-42e1-8782-61e7054f5720"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4718ba73-b1ea-415b-931a-33e29f6c6498"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-1-27",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("490bfe23-0f82-4942-8870-9f46e19f80cf"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-6-25",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("49c1edfe-c7a1-4a10-9d9e-097e7b528f45"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4a13d573-d7a4-48e1-9c2f-65396904f12f"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "78",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4a287926-4234-4bc5-b00b-6c243ebb4e1f"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "36",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4a5a0a26-4bc2-4735-b0f1-85d779a69136"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-10-4",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4a8941fd-bb24-4583-acf8-2c1ee6dbf714"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4a91ca46-3846-4e47-8fb7-0022445a3926"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4ab02b27-fa89-4805-8882-5c4828dc6d41"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4acb69fc-c592-400a-823d-f2705e87e69d"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4b62ccd9-0222-4bd3-9369-d2f7cdd97ad5"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4c30adbe-58ee-4a66-b2c7-3f5836a91d05"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4c857421-65af-453d-be92-3599be0b7b54"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "63",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4cd7744b-1ccc-4c72-9959-47be6ffd6a50"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4ce1f02b-2f32-4bd9-a00c-7309b70c2b2c"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4d8ea7ba-3171-4b13-90c4-9559f3eaf8b6"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4da4fea8-87c2-4807-a429-75437505d84c"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4de759bb-ce00-4da2-b790-e8a476980f93"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("4e26ab5d-de36-4983-8c58-4bc96565fbd0"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("50a52f67-d0ad-4081-a499-9fd49ee56114"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("511d4173-209f-451f-ac79-6c34b1aa5197"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-9-17",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("51aa0b6d-c6e8-4ed8-848a-23aea07d9b45"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("51aae56b-58cb-4f94-bd91-4373fdc0faf7"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-9-19",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("522dbe90-6d1d-4012-a1aa-3fb39aac7480"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("52ea3bd7-82ec-4d74-b83d-d9a5aba55daf"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("52fec076-ae45-4f06-b35b-7c4cdb3c1b0b"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5341b906-4957-4ebe-b4d8-0683c9494f32"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("53b609a4-630b-418a-af62-0f9302d8e79c"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("53d40cf7-f18e-469d-aa23-fd1fdb081ca4"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("53f38fbe-cc91-48b5-ac6a-34af7e766664"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("549667ae-c156-4269-9006-243bd6f6700b"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2015-11-9",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("55dae7dd-4782-4f09-8ae8-e4d3af46723b"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("55de6cc6-1ab4-42d4-b63a-ac61e05492fd"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("55fecc11-715c-4d7d-a8ff-2046ae5b2f42"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "49",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("560087ce-2049-4def-b89e-2632557e2849"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "48",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5667f002-a4da-4eef-a8c8-c80e5d26abc1"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-12-22",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("569e5d47-a4e4-487b-8db2-43b0d730e5c7"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("56ed591c-ebf9-40bf-bc72-6d21301ba18a"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("571d3280-5256-4a69-801d-613e51e985b1"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "38",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("57745059-4aca-4de0-b4a4-edb7b74a6674"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "81",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5793de4b-e51c-4f57-a461-f68899c5452b"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("579dea57-d8c9-4c2b-aa9a-f3e3200ccdfe"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("57d9da98-7409-4048-b3c8-60801c596fb8"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("57da67ce-18ae-4432-842e-01713b39aa87"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-9-18",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("59676a71-f3f6-46fd-9bd1-4457dc36e3d4"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5a2d85c9-6ba0-48a8-b54c-d158b63477d9"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5bed8c2a-1c5b-4d42-ad82-3ac20ea416a1"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5c219a9e-9f68-40d4-ba9b-40a0b4b388e5"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5c4216d3-1f6f-4ce8-8d04-44ebb8cb58ed"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5c44772a-bfbc-4756-aba6-789615f38ff0"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "48",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5c53b718-ad5a-4a8c-86ec-c0d815c5aab9"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5c60a049-1aee-4d00-b09d-1f0107c6d667"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5c81954f-c223-40a5-9e1a-744b101d4737"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5cf70b79-83f3-4450-a6b2-d06c1c74af6f"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5d0aee4a-fa15-4cda-b71d-380267ca054f"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "52",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5d7c0d54-66da-4340-b711-9006e9f40e23"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5e0da626-3038-40ce-9eb7-4122fc51a6e3"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "56",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("5e631a93-e101-4159-b123-de2c2910af1d"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("603376a1-cafe-4883-adc7-aa33ba7f7c39"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("60703543-2d9f-445d-9753-6557b1f046cd"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("60ab1c8e-a0fa-4255-9af1-10e178cf2d47"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-5-1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("60cb3030-181b-40e7-ac16-308cbf6a9eae"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("60f97f03-57a9-4453-9e0a-8531e6039557"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "38",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("61833d1e-bd0b-4b36-81f7-5680dda4d132"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("61c3e646-0bfb-4da1-829d-72c5ea2c1265"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-9-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6215bd22-afe7-4772-bab0-bc296a5d99d3"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("622fadd9-b322-40d7-b164-06239b7619dc"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "41",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("62823024-dc56-4b0b-a57e-fd7074041102"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("62e5e310-d666-41ce-80ad-c813c6f3ca31"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6360f3ba-c7e1-467f-958c-5d9a6a380329"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2015-2-11",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("63e85cbd-ca0b-46ee-b769-20d0c910c8ae"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("64009625-1f89-4866-9938-c67f9831389f"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("645dcc4d-467e-459a-a2e7-e61a59a8d728"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("64d3747f-f250-49b6-ab3f-a1aec22e2d5e"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "53",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("66386c0b-9133-4c16-be47-8d59a1e8d8d9"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "58",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("66729c5b-a871-4236-a17e-1c9d9b00c73d"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("667d436f-66b8-45d0-b6ee-f6eb5ade8370"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("66c92c85-72f1-49bd-bbd0-a61f22ec016e"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "45",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6749d2f6-dbe4-4833-bf32-7600932b1409"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("674bc429-d176-4233-ad0b-5d639d507267"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("677bc97a-9bc9-47d1-99cc-9324c7ab13d0"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("67cc3323-983d-42bd-b8dd-a41e3dcbf161"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("68d17e6e-14bc-4980-be5b-8e18fd3987bf"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("69198c39-ee3f-4734-8e7b-32e585456fff"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-8-18",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("69295e42-8bdb-497f-86ad-a695bd45f0a9"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("697c07d8-1251-452a-bdf7-3f141aa19177"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2015-12-19",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6a176eb7-30d1-4801-9207-1d2d36d4bb45"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "85",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6a8746e1-2792-4b43-b267-922a390734fe"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6b64326e-e0b0-4ab8-9fad-7de0bd09f5c4"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6cc09b9b-2260-4582-a879-260d8b8c6ca3"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-2-16",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6d36793a-df51-46c8-8854-251951f44d07"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "51",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6d6f87d6-f8b2-437b-a4c4-3923e48e669b"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6ea6dcb9-df77-4ba9-aabe-985290fad617"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6ec209f0-fb72-441d-9d44-54edb3c9d227"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6ec4d55f-26d7-49fe-a45b-b0a195ca3b3c"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6efdb6f2-479a-4a21-a817-9f1840383222"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "45",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("6fc72eef-c68d-4218-a3e8-499b6036dd3d"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-7-3",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("703aa576-19a1-4fef-9394-1b3db1cd3046"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("70c836ad-075b-4121-a610-06f4cfaa06a6"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7164a5df-1d40-48e1-9d2a-be2ff2fa92ec"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("71968233-a8de-4948-bb3a-d237c53151b0"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-3-10",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("71ab4d1b-23af-4ca1-a279-ece224bbe6bc"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "37",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("71cd1b04-18db-4442-9202-9e975da75dbe"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-8-8",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7262f978-88f8-49c8-a69d-03ad62aae0f3"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("72860eb7-a89b-4e75-b417-c2242dc9e569"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("72b7b396-e512-43b6-90d1-50b6ac579c76"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "41",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("73c6aa07-1214-40b9-9277-8d0cc6c4e7cb"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("75126851-1f61-4c71-82ce-efc1c04779ef"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("77a359d0-c9b5-4ae4-a603-673f407a0d2f"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7803b832-4306-429e-b9c5-7a6e612e7115"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("78123577-82b8-4dc1-ac54-f7ac29cad5e3"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "57",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("78161607-5915-4d2a-b5fc-378b8dfd7a3b"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-8-9",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("78253ac3-205c-4950-9135-0b5c1d6daa9b"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("78538261-6fee-4508-903d-930d822fbfa5"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-1-1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7894f904-5675-4074-aea1-681ba5db2538"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("78c2b318-b1ed-4ad1-865f-8545349d9cb0"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "83",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7913f1a3-46e8-480f-ba97-f644c6103d45"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7971a39e-63d9-4c80-862d-955ac2832d6d"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("79c014a3-0eca-4b03-9cc9-06c497792f86"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("79d2c992-f26f-42c2-b70d-55628e887062"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("79e7b66e-7688-492f-94e0-a831800e72ce"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7acf4ec1-ef82-459b-8249-226edbd4298f"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7bb7eb01-59f3-4786-8439-a9579f5ddac5"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "78",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7be2cc7e-ed46-4b91-937d-82b9f9f4ea34"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7cabfb8d-94d0-4533-adbd-0cdeebb2baea"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7cf87d39-3eb5-4c6e-8e11-b322c61f4a3b"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7daad342-0092-49bc-8319-afe88dae23bb"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7e6d1dbd-d730-47da-8895-5de0039c5985"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-11-9",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7e8f4f52-fed9-465f-8656-b22b7fe6bed8"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-11-3",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7f02e2ab-2b82-4bdb-8ca7-0fb93a5780f1"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-7-1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7f1910bd-de17-4575-a245-760ce08699cc"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("7f23dc00-32fa-42cc-b43c-a798dfe23ae3"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("803c531f-d38c-4e6a-836b-eb168c9cf981"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("805f9a44-7a57-4b2b-8dab-88bf053e2651"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-9-10",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("808296d1-e8c3-4999-9601-b0cb0c05856b"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("810cdda8-66cb-47d2-bdb8-1cc523b9f22e"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("824584ff-9950-4e40-bda0-26414f9302f1"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2015-8-11",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("82a6abb5-a099-4b20-8616-f2177732463f"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-11-2",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("831d5d78-9254-4792-88fe-6e8000d6e603"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("83380da0-f17e-4030-b510-fd6fc427c74d"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8346c23f-e03b-4ee8-822d-43e3ac63cbff"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8386a9f7-4fd7-4b45-9100-52e8a7b987cd"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "80",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("83d84fd1-96ca-42a1-bb6e-6bdcfd783e06"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-12-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8440f41c-3ada-4eab-9917-44a388546a30"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "62",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("844d3be8-2f28-437a-a7be-681653b6fffb"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-11-7",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("84ede10d-f700-4232-b924-149b869494a3"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-12-2",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("850db566-4af9-43cf-ba0b-78f5b4fbbcce"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-12-9",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("85463adb-8da3-42c9-8336-101f629fd1b5"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("855cefce-abf9-48a4-a2da-75bce528882f"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-12-3",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("858d24ab-b44f-4d32-bae5-fcbbb558a529"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-9-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("85ca4e26-eb24-4dcb-8954-7e8ba2d9bb43"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("85f20e9f-a881-421e-b41a-dafcc46bd31b"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("865c602b-1def-4cbb-8a5d-393e552b989e"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-9-28",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8853239e-7a09-4c10-98dd-926dffe6287a"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-9-1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("886ec6d9-7591-43aa-bccf-fd9af9314e49"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("89131cb7-2ab8-4f68-a520-2bc020e1e7e0"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-11-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("891dca9d-c7f8-454a-85ca-9d4fef765e7d"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("894091ee-5c72-4a77-b86c-a4cad95b16a9"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-7-21",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("89d32a4b-9e26-4e40-b525-711b553ea498"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8a957ba1-3818-4df3-8f0b-78be6eab4115"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "50",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8aa66e45-0c57-4b55-bb9d-b95439fe2a0a"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8aed1075-a9f1-4303-9128-ac9e8921d7d3"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8b625787-6a69-4777-a918-bad23dc99886"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "71",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8be8d437-ffa7-45e4-961c-3d1dac9b03c6"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "36",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8d8f03eb-4e64-420e-93b4-c6a464510b24"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8da829bb-faa2-402f-b3b2-3bb9a577f52f"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8e1b7457-8d44-4bcb-a092-41517e543cff"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8eb16a62-7905-4855-9e8d-1b0a3d99b79d"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "61",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8ef1e811-43d3-41b3-8a00-2250b74d4e82"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-10-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8f34d71e-8b97-4b3d-b679-13610e5a3b91"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8f57b166-1b12-498d-b5a4-962160c38020"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("8f78abd6-ad3e-45c8-9ea4-ec17eca29e03"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("90d8b8d6-41a4-4079-90f6-b181a6a0c30a"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9158141b-9b03-48be-a62a-276fb136c17f"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "44",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("92b6fd61-846f-4e4b-8e93-4bb093f21e6a"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "41",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("93103aaa-4bbd-4f72-ac82-7ff3a6581665"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "84",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("94c01af0-f431-4419-b281-40c5b74bd1eb"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9506c87e-d941-452f-94c4-8e5a1e90e05d"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9540d85b-f3d1-4b56-8dc2-3d6ec135a082"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("95468e4a-3f46-4b0c-91bc-6d0da4814f0e"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("962484bc-59bc-46af-a949-e1363e174e0c"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("967a2fdf-4aa4-4374-b18c-6b71b74b43f5"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("96a424f1-ac8d-47e7-ab61-9450d688756e"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("96c3642a-72ca-4e8b-9f3f-74b7f24efb8d"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("96cff596-3850-420d-b229-301808bc6d4a"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("97c2e52d-0ca2-4dbb-8802-65bb3f556731"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("97ce81f2-2875-43de-b0b0-27aa7e916d11"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-4-27",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("98c73757-6446-41e5-9de3-2a92665b5209"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-5-5",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("98dc5c3d-6eed-4024-871e-8a14dafb7f6c"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("99137d72-2267-452f-b04d-6ff0d0048065"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "66",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("999ffe6e-0fa7-40f4-b055-6a41f96fd132"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "50",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("99d6bf5b-542e-40e1-acd0-a9325a1ef6e2"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("99d8c351-e6a8-4e53-b7ef-d2ff58e124ba"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9a315f55-4b17-4545-883e-c607f77f4f10"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "68",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9b45cb20-7473-4293-b977-0bf78056f6d5"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9bcf180b-a4cf-40bd-ae26-86a34b7ad04e"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9cb1e58c-bdc5-4e28-a504-a28ca2452fd7"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9cbecf55-6ce7-40f2-967d-88a0d774c2e7"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9cd7c72d-34fe-4ad0-8333-bdd8325e7589"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9e19416a-9e28-4b46-9230-1b68a050fe6d"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "84",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9e1a2f59-d03e-4d54-934c-5e09b25ff169"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-12-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9ed08756-9cc8-4204-8a38-80e59a6bdd43"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "46",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("9f1b1897-ab5f-4f43-8c4c-198c85752370"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a0887200-c805-40f2-b8f9-b3e3ed9f3565"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a0c241e2-8dae-4c6a-a0fa-9845ac8acfcc"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a0fb8f6f-4da3-436c-aaba-de466c6bba6a"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a19dbeb7-c9b4-4ded-96d4-113aea506bc4"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a1f0c137-a08e-4253-9677-816a7c4d3c91"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "69",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a2d90c93-60bb-4f28-8a21-4281f48afcb4"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a4fde28f-3480-4723-bd71-887fc2c8e3c4"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a57952bf-30c3-4a02-8aaa-625e533581db"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a5966633-439d-4678-8406-5baf6cffead1"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a5b2f78d-9c72-4e95-af49-541e47269bb3"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "47",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a6212440-936a-48b0-ad58-de9f5bb3b18c"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "72",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a691de3b-6da6-4298-ae5c-021732db3ac6"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a69ad9e1-36f6-4bfd-9031-6f1fcadd37d2"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a6bdf9b8-16e3-47e2-8370-02d134864cc2"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a6d64d8a-6b8d-4b38-a9fb-beccc883ff98"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a6f2be2b-193d-4e29-829d-1abb3aac4a85"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a81eebb3-01db-4ebf-a069-ecedc740f667"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-9-26",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("a9b0c8a8-ee23-4cd3-8cd2-69fcb2bfc783"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("aa70978f-459a-452d-b64f-e31b56815272"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("aa7bef79-8331-4280-a5b8-99df87768dfb"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2015-3-18",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("aa7f6b28-69a8-461b-8ddd-ea1e5bd340d6"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("aa8f2c33-91ca-47b0-b8ed-d7e8ffe49ea0"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ab56f8cd-6dab-4db0-8533-1e296254f5c1"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ab5eba62-bbdd-4f44-8d8d-33763b1711e1"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ab699f79-2e68-49a5-8152-d0e3f470bd7d"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ab97792c-25e2-4333-938e-8db104c754bc"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("abc18a78-c864-4e48-a73f-5d654b697a9d"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("accb7b19-9e62-4f87-8f77-2fb5a86bb601"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ace560dd-26d0-43ec-b4dd-7b22d971c27b"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("adc273e5-70b1-4787-9345-36fc7727a504"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("addcf246-1b19-433a-9c8a-2f05379bd67d"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "77",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ae0564bf-7cd8-4c45-a82f-1ea41a51f803"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ae367c1b-10d4-4c74-9d63-e91221edcb9c"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ae63ad16-fa78-4f73-aa2e-91db3b58b6c2"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("aed0406f-91e0-4bbc-a444-e326c5f5c78d"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("af07f360-a60b-45f0-a4c8-bcb48c8dbe76"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("af931ee6-d971-4f12-8b32-99ad92b06007"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b014bfa1-3d77-4272-8e8e-1999fb6cd588"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-1-11",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b082f290-1d58-4dc5-803b-d4cb6ca5bd7d"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-1-27",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b0e0e552-05da-42d6-a2d0-d7a2686599ff"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b0fa0a73-f40a-4fb6-b287-04fcdd7e6a19"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b1a1280c-49aa-46d7-adf6-a343dfa3debb"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b2313891-13e9-4fe9-af9d-837ebd059dc8"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b2943d29-9fc8-4926-9dbd-c42996d14808"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b2a1c56a-6e0a-4a33-827c-e35cba2d5f02"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-1-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b2c14037-1b8a-4322-baf3-05f4220a4133"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b34a5d8c-690f-4d3d-8ee5-cffeadb416e6"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b388c64b-7bfe-4ff3-ac1f-c31df37c9fa2"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b3a9427b-12b5-46b9-84b0-7d25bdc9ba0d"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b4e9e59f-b87b-496c-ab55-44eb7d2fc516"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-10-16",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b5508be3-3499-4450-b86d-9b8234eac1a8"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b581cf4e-61fb-4991-a322-f97958e40a34"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b61d5a9b-2774-4ec8-81d6-b8b89d5aee9f"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b61fd7a3-fddc-4ead-934b-2a2af7cb33b9"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b65f5339-1588-4bfc-84d6-281602b2d056"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b670d4b5-116a-461a-8342-89e597bd4eb3"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b69b527c-5166-4742-a4ce-eec24c5b98e3"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-12-26",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b7f78200-34d2-4c48-a5da-412c86e1755f"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b8003e62-bb10-421e-881c-5657da8fbb95"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b89312cf-fcbd-40f2-b5b1-c2a49a873506"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "41",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b8e18334-38e7-48b1-a1c0-ddfe6605c206"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-4-16",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("b9f0869e-cd1b-4638-ac14-f6b9413f8416"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ba378743-dd97-41e4-b8ec-bd59ab726a88"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ba57383c-5ebf-4e77-9b7b-3cbcb1913471"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-9-24",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("baafc764-8a0b-4287-bc56-9a4f3b1ac749"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "45",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bb4ff618-3c6d-44de-abe5-5a4274ca26f8"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-12-21",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bba2306c-e997-4fe5-acbd-f02cc7b9e1ae"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-8-15",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bbc6f388-cac1-4fe9-9437-9bd78dd41c74"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bcec2e19-0619-4964-883b-f3eec18a02f3"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bd0222c4-ae2a-4240-94ab-143b457498b2"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bd128438-5282-49d5-97ae-c792f0af46c5"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bdf66873-36b4-4499-bb2b-a274c97c6520"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-5-16",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bdfc1db7-795c-4e0d-adb7-5cc9d858923e"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("be9edc10-90b8-4d9c-b6a4-9749125ce0de"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bf4dce25-5a34-46ab-b8c7-4633765e06b9"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bf9a6aba-948d-4665-ae23-2dae1788f7fe"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2020-8-18",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("bfd7581f-8a83-4375-993f-bead2bb23f87"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c08739bb-b3c6-41ec-8a95-2d53a77c75bd"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c094113b-b5b4-4771-8e55-7e19cafd509b"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c0f1fd74-58e0-4c1f-b81d-8c28e17d6663"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c113e188-eea3-44e2-ae86-04a3c8c4efc3"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-2-7",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c12c8e44-fa6d-4e9c-bc35-e132806c4c21"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c1756683-5fc7-4c14-8b53-e9064fbce2ee"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-9-24",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c1ac77bb-1094-40e5-af2e-d38cdbb4da0d"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "43",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c1c95840-1b3d-4403-a21a-0b1225298154"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c22a72f7-79b2-4e9e-a7c9-73640a5fd8f0"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c3294b15-3567-48ed-820d-d5ea4f9ae6e2"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "48",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c3bd7ad8-7c95-47b3-8349-47223b6bb6c4"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "77",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c3dd109d-285e-42b2-afa6-78321499b636"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c44a71f8-fc92-46e9-a174-fa3c70dd728e"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c45306e2-0d22-4f71-8a80-2987b4661572"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "39",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c4a58768-6a7b-47f3-a4bb-49d5e2e470c6"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "56",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c4bace68-93b3-4d93-9a6e-b121b2f4e54b"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c4cba708-019b-4cc5-8d24-a773abe2658b"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c529922f-5ea7-42a7-8d5e-918565bbe6b6"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "84",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c55dc4ca-80cc-46eb-b390-1c4e5a1ede68"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c5e438bd-e8cf-4b10-b37a-bbfc1193f847"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c5f031f0-e208-4af2-8893-3d724ce7b8b8"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c78ca90d-388b-4646-83f5-1427e630b554"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c7a665b8-3e6b-4403-bdc9-9dd1b04c9258"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c7eadfa7-59b1-4a25-b381-7b9862b240b6"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c817bda0-3aa0-4de4-afa1-cda744271268"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c9427eb2-5a0f-4009-ac25-ee6ecc633247"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "43",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("c94b62cc-8806-4f7f-a6e0-f05c1ee1da3d"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ca202513-c6ba-4093-91d1-cf138bdbe156"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-7-18",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ca4c6912-7c57-43f5-af96-0fc2aa632590"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("cb2be208-567c-4550-9b67-c281abb9cf95"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("cc6d6c73-e3cf-4c35-ae7a-aee83cbc9f31"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "38",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ccb1194c-d3da-4050-a0d7-7107c154570c"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("cd04a71d-5127-4df7-999b-1f904af3ca85"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("cd79c9d5-4ffc-461f-85fc-8ed435dac9ee"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-3-7",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("cdf228a6-f1cd-434b-8fc2-0477a1046660"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("cf0703cc-3edb-4b1b-9e6f-fbe6be4515a8"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d02da584-7b5d-4261-9763-d575b36207e6"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d08bb802-2623-4ae4-becb-c8337c81fbec"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d11bbaaf-fad7-486e-bd36-718ae176da98"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "75",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d129c7a7-f2a1-42a3-aad1-f10ba2ab3b5e"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d18589f2-14de-4286-b606-477ca338fdd1"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "53",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d1c7cd1e-358a-4a60-a035-4b4e5f9cd533"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d21afeac-cd6c-4b72-a46e-4a174a9925b1"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d2208ae0-3df0-4fc4-9707-396e20095d41"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d3344219-4102-49d5-a894-1f1755599397"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d34e2042-c7a6-4082-adfb-5d5f1efa773c"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d444fb74-57c0-45a9-97d8-051a27e7c92d"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d4886112-7294-4566-a711-117c9f675191"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d4f467c3-5ea6-4f32-a00d-b33a201b45a2"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d5b61980-34dc-42b4-9ede-5d2a525e2635"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d6ec15e3-9c1e-4ee2-81bf-fc6ab8a83e0f"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d801dd2c-83e4-4bba-9ee8-f5412c7b76ff"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "54",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d856f53f-3a1a-48fb-b7cf-1451532e6043"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d89df144-a7f1-4b1d-b90c-c17fa0f71204"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d8efa58f-6c5a-43d4-b235-ddedb169cb5f"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d8fbd228-de6b-47e9-9a11-6b6de229391f"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d911bc0b-89b2-4821-b0bc-ec7eb9d87495"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d9155ae5-3247-4e25-9d9b-86c700866447"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "52",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d92eeb85-d197-47f6-9b7b-01f20575efb6"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("d9374696-4890-4ead-9610-6b74569dd555"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2022",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("dab0d0ba-ed23-488d-bb0d-5be05e1f88ac"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("dad07b7f-3b02-473a-9818-40e1df43a5a4"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("db8c25cd-c9ca-41ec-9519-9906399f92d1"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("dbf7d1e1-4a79-47c1-abad-1b64fb9daa43"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2017-4-2",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("dc33a458-9dda-48a3-b21e-3015c69577f7"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("dc88f72e-2a45-4423-ba31-808d68fc9a11"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "56",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("dca81db0-1240-4621-a627-123a3cfa4ce9"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("dcdec8a8-9038-409b-8b69-edfcc3ccd610"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("dcfe29d4-612a-4b36-bb11-062db7b0f695"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ddd18694-2150-40a3-9535-e109003552b4"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-7-28",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ded328ab-cb65-4747-9a89-e9d1bf9bca07"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("df8a0952-c635-48b4-97f1-0d22ecccae5c"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "80",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e05656b9-99e5-452a-823c-535bdba994df"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e05bee57-77d1-473b-9a79-f444334cb719"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e067adaa-8797-441d-a598-3c700325b08b"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "49",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e077b022-5ac5-47a3-902c-dd7e66be3604"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e112a55e-d38b-41be-bd47-877073c50331"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e1501d2f-abef-4982-809a-14038951003f"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e16ca50a-3be4-4ce7-8cc3-76354f65084a"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e1977d50-3295-483a-a534-c5abd628dd2d"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e1a87bb3-7b7e-4499-bc4c-7c35e9835b28"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e2031d94-c16d-4a25-877f-5909881455f2"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e27642bc-97c4-425a-88f3-a0bedaf6f9d8"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2018-11-26",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e2839f3c-1d71-4720-b2b5-35dd1f2eb63b"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e2e95b52-c53e-4235-8dbb-09d02f8ad12f"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e36e8220-e94c-4263-8877-93810f7e2f9e"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "78",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e38b70d3-91bd-4710-84dc-37490db64eee"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e4dbcac4-5895-4c21-9c3f-fd47b8fc3405"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e50b249c-044c-4e86-8ea8-a18b3a5acd36"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "53",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e599652e-e0a8-4373-834c-bcd4a5940630"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e5be7fba-f50e-4a95-81bb-2e807adf2d2b"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "74",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e5e3a1d4-76de-48b8-84ab-29bac98773b3"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e6147494-c4da-4a3c-8b36-038d0716abe6"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2021-9-19",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e6b2c57e-ec09-4d66-8f1e-683e91feb3b0"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e6ec004f-6039-4030-baf9-5a0d6c6e19dd"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2016-3-26",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e7002f92-f4cf-425a-af62-cb9eec4ceadc"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "58",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e84a2aa0-69c3-45ea-b7f8-c41cab1a6c8d"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("e95de0b4-4cae-486d-bd06-488402f0b82d"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ea4800e5-c12a-47e8-855c-ad1db6f6da87"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "47",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ea6682b8-6235-45fe-8a3f-ea803c69e6e2"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("eb8f7256-fe25-4673-b896-97c0d46a753a"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ebc6fff2-7e40-4651-939c-6f17a9c23604"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ec854dd1-649f-4df4-92ba-376673990c54"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ecb1e964-1e8e-4b57-9bef-92912b63f92a"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "80",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ed25f9fb-81c3-4fad-a097-88f06aaf6e43"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ee1222b7-7506-4a47-b175-7a3ac1bd6c7d"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("eece1b66-8533-4666-aae5-53fceee737f2"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ef21f454-7298-4bba-902f-6b7b01d89799"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ef3d4733-7b3f-414c-b18b-96a0f15a0ddb"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f02a3a92-43f1-4667-b881-f70feafecc38"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f06ee308-1a3b-4f6a-9bac-2218ae305210"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f1766886-d6f5-4221-9bfa-34453993a976"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f1d1a6fa-d3b9-4738-93af-1dd83840d408"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f1dc813a-31a4-48e1-b4c3-0556bda99db4"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "47",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f21b8a83-fe6b-407a-99b3-5254661ce252"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "40",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f2e37610-2599-4b77-bd69-fb9ce04def2d"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2015-10-6",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f33d519a-c965-4744-afc5-d2bef5940ee4"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f341d06e-0b78-4e89-88f4-2b1564d5ada3"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2015-1-18",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f3e09860-bb9e-4368-9dda-1a034773387e"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f43d8f7e-e878-4ea6-98f9-430cf2e12e3b"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f5597d08-ef34-43f4-8fb6-bdc599894e10"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "71",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f5f47d62-6781-4384-a56d-d50faa25a85c"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f6130d1f-9d1b-4ada-b3a9-64d568826b8d"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f7d7d4ee-d8c5-4de6-aabe-01bc32879eec"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2024",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f861afd1-d640-444f-a72a-438149482ce1"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-12-11",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f8735e64-ea85-4e29-b38d-ac3769d3a24c"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f8c3be12-68a6-4337-8685-77939743cb30"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "58",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f8f0ccdf-7e46-4a44-a8d5-dc7d9dbce1ef"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "40",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f9074f2e-7592-4252-871c-48d0c872642d"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "59",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f925ce7d-362f-4a3b-8a64-52955747cf99"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f9d31cf9-202b-4e91-a1d1-4bacf0238b8c"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("f9e3b00a-ae2d-4cf1-9a31-f2e224ea815b"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-3-15",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fa477eca-8254-4caa-8b1c-da309a863a2a"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fabf7b6e-1571-4727-b9c9-cf094729b757"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                ProductAttributeId = Guid.Parse("C8628509-6A62-49F3-B6A6-8AC9E3FD3C13"),
                Value = "2019-5-21",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fb137fbd-5947-4796-80fd-8b7b5ed7522a"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fb686e26-824e-41ea-b6ef-b59d085c289f"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "0",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fb6e0623-c726-4255-9e81-f719761850ca"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                ProductAttributeId = Guid.Parse("39E6E6C2-5D91-40A8-923A-64500F4B14D7"),
                Value = "1",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fb83cd49-d608-45c9-b247-a0cc3b4109b0"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fbf03312-b342-4dd6-894f-c617cf272f4d"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fc242587-ad74-4d04-b020-15e2835031a3"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "55",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fc4cff76-1436-43fe-ae52-8ff96dfcd65e"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fccd9ef5-b652-4793-a8a8-34ab2ddb9470"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                ProductAttributeId = Guid.Parse("BF9DC74F-CEB2-43BE-B83E-7CDF3FE1CED3"),
                Value = "Four Season",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fd05f7dd-51fe-4a7f-bbf5-4d09fac567a6"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fd2e36ec-d590-4c66-b991-3189a26299da"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fd740d25-1760-4e9d-b3f0-95d60266a1b6"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                ProductAttributeId = Guid.Parse("A1FDC4C7-4DA2-496C-BB89-C969619D58B3"),
                Value = "Electronic",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("fd8012a0-cbb8-4044-aba9-fc79632cf1b0"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                ProductAttributeId = Guid.Parse("B515831F-3993-47DD-AFA4-333B00C6F4B7"),
                Value = "77",
                CreatedDate = DateTime.Now,
            },
            new ProductAttributeValue
            {
                Id = Guid.Parse("ff941176-a49a-49d6-9c2e-913cdb086861"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                ProductAttributeId = Guid.Parse("05C91892-1056-432A-BD8F-9E83DB4B2227"),
                Value = "2023",
                CreatedDate = DateTime.Now,
            }
        );
    }
}
