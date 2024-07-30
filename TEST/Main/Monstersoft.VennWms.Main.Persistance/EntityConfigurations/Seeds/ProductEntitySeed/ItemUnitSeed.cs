using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ItemUnitSeed : IEntityTypeConfiguration<ItemUnit>
{
    public void Configure(EntityTypeBuilder<ItemUnit> builder)
    {
        builder.HasData(
            new ItemUnit
            {
                Id = Guid.Parse("00491241-3e02-406a-b058-026ddaff9f26"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                UnitId = 34,
                IsConsumerUnit = false, 
                HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("00c9d6ea-c404-4eed-9b2b-eabef1305dc1"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                UnitId = 33,
                IsConsumerUnit =true,
                HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("00dcc232-dd8b-4744-851b-7254d0126787"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("01a25038-ae16-4225-ad1a-a2bdb35f1055"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("01e70a0e-ff21-4850-8dfa-23456e708931"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("0222a6d5-371b-4e3b-a03b-affeb37b3d1e"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("03c90ee2-e782-4519-9fbe-1f1041093147"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("04752347-c443-4303-b576-c78027d8a0d9"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("057d7a7f-f8df-47c6-8994-1feaa76d5528"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("065bc0c2-cca7-4568-acc9-9f7f8be2109f"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("069e0ad5-f015-4be9-b7fe-dc61e5845815"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("07076d2c-efce-4cb2-a31e-a3dbf7fe4a97"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("07c214ec-18e4-48a0-bde5-ac3b54e23d47"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("087849b0-cbcd-4ab7-82df-6966ec353f84"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("08e1ce19-21b3-4743-98f6-068b73c15fd4"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("091ce400-09e4-44f7-a99e-3872722edd3e"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("0a393751-b7e7-49d5-8133-1828e9f8145b"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("0aa0545f-d7c7-42bf-844f-b05cc117199a"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("0d2d0f4a-d498-4b03-8d4a-42f430acfd33"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("0d3ace8e-04d3-4733-a359-76e13191e054"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("0e583039-7028-4aa7-a47d-2e99c2ad5471"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("0f00739d-b298-4263-8597-2b8b9d6d5d24"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("104cd401-3899-4ee5-ab09-9d3c7d3f37b9"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("10b8047a-e230-41a4-9d96-b940f884b114"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("10bd9ee8-878c-473c-9d10-560a26b997a9"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("10fafc6b-81eb-431a-a991-bb4a5aa1d566"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1145c680-a8bd-42df-a0b5-daa7e297d5e4"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("11b79889-ec4d-4407-83b6-9a8993a65791"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1288c5d8-7798-4a0e-8bd8-6b36736dda82"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("13bcdda6-2fba-4848-bf3c-ef01094a296e"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("143e5844-ed13-4b43-bd9f-bacd99e072d8"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("146df446-ed3b-435b-8e11-9d4e57ebc025"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("15a4b699-e45e-4f3e-a732-f71e76591e36"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("15abd40d-51fb-4f6f-b47f-50161380f45c"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("15b3dc37-3e41-43b5-b224-7a1eaf9eae72"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("18986d68-d567-4913-ac20-81ad61722368"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("18b4ec5f-1a35-4b55-ac7b-22c0112ee28e"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("19192c15-01ea-4c21-9d8b-ad77d51e6a84"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1946be1b-160c-4313-8660-b081a6e4264d"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1a0160cc-09bf-403e-b53b-474d8cb00dfe"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1afbe70c-9ef6-4fcc-bbfd-9b2f49ba9365"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1b309b2a-0de4-41d5-97b7-4bb88affb97f"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1bd20a9a-a2cd-4f99-8d1b-9cee18992d9e"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1c40b21e-8f56-497b-81f1-a6932c8d1fcd"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1cb2e917-4a39-48a5-ad33-d6ba092e4f55"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1f5f3187-bc0d-40f5-bb2c-299fdad3d4ab"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("1ff483aa-3f32-4bd1-a87f-66c56dc2ef5e"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("20426cee-01cf-40ae-aa30-8760b8fbc8c1"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("21d74012-e7db-4f96-8d00-773f320c8dce"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("21fabef7-7209-4d20-a11d-ef961e1a1745"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("220dece4-d93e-49e5-9207-93ca3c03a68a"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("22b2e013-e927-4ba1-a445-b249a2339599"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("22ee5c1b-54bd-4638-b5c0-b5928b8e937f"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("233bdfde-2403-42a2-830b-abfca5fcb53e"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("234b6173-4c04-48d4-8d87-11f5c69d47ff"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("23fdb184-90e6-4470-8b17-d884e95d7475"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("24b8e5cb-16cd-40dd-8c7b-a088a1a9a05c"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("24da9af2-cc2e-48c2-94e3-472545da88b9"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("25ca555f-9369-44fa-98b2-b36961c3de97"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("25faacbb-b5ba-41ab-af2c-0b31ab76ac92"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("26bdb59a-b61e-4575-a656-b3b68b14d28a"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("271a11c0-82b3-4d01-82c3-067a48646031"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("2879c596-0102-42a2-a7f5-e9ae3fa82700"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("28b400b1-b09e-4a12-9cf7-41a75dccf413"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("299416c9-ce42-4d44-801c-c0eaf7e95b4f"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("29bf5e71-0e11-4d2d-8dd3-c6061bb6e02a"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("2a63fb0d-1d0e-4fc5-ac09-705f99ab970a"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("2d62f3ea-7666-4446-9025-327725defe8d"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("2ee47897-d499-451b-aeb0-09ec28451fa6"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("2efbbf5c-c20b-4d0c-a09d-7b64ff9aed59"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("2fce987b-cf13-4f53-b46b-c0f7916e0af4"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("315ccd12-0db8-4d8e-8c03-98a6547aea70"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("32e98be2-6ce7-4059-8d91-9efc106ee97f"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3300c267-dae4-40d7-bd3c-c6d9b4f6a0aa"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("33b554ff-7599-4710-a3ff-0eb1d8c52259"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("33e21fb8-7645-4314-8b08-4599c7e3e25a"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("347a4a6f-de76-4fbe-baa1-8a9bd2eb69a1"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("353ae184-1737-408d-8da3-a9a52a3281d7"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3645c383-3582-40b5-9223-b2475b556fa4"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("36d55f2c-567a-498d-ae16-521531bec943"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("36d858f1-b76c-4c53-b724-a6fc39b9b62d"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("39385dc7-a950-48d8-a2f2-d13ab91aee10"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("39da5472-7cbf-45f4-b607-14f223f61bad"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3a44e9c6-ed85-45bc-ab43-25b00f12360b"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3a741da9-0b50-4946-8032-5cacc8a568db"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3b7a2e3c-653d-4abf-b137-a953c66a03cb"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3c355087-ccb3-4ca4-a097-4083c27495e8"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3ceb0f57-5aab-4e4e-ab36-6b6a153ac0a1"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3d591290-fc42-4958-817c-93907aa54857"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3e453fc6-d8f0-4b28-82ea-6ac95fa6e1b5"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3f381194-3520-4ee5-8920-5747e19e2505"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3f4d10f0-ed24-4a87-9f2e-44bbb582cc7b"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3f90ea94-6c91-4073-bf97-5d0de5811e6d"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("3f93fcc4-3241-4e1d-b04a-3f6efec6d15e"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("406489a7-6bc1-4892-904d-ad83074b4a9b"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("406c7fd9-5ac6-4bdb-b2fb-af62f8bba872"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("40bebf59-6ebf-4014-b1b9-baed653ae9ab"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4109ac2d-acce-4348-83b7-d87088ce5a03"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("41aa2304-20b7-4ec8-a45a-2d215be887fc"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("41de7a60-8689-4f76-80df-ffb67e6b8d45"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("421dca12-76c0-48e1-9b87-c93391e1bef8"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4249aa34-95f5-4564-b2cb-720d56c89f0e"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("437ce102-dacb-4310-bcdc-ba8f0057799c"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("43cf57f9-52f2-4f8f-83af-e9ec0abfc63d"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("43d4f2dc-db42-4040-8ef2-edc0c2759c8b"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("43d556a6-5b4b-4179-93d5-278a45f2c38a"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("44329e0a-f233-4698-831c-99c84438ceba"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("44c6db6a-3f47-402c-9a07-b7361e7b2d87"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("452c3e2b-225c-4a15-bd5d-136220415a89"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("47af2eb3-2e03-4dd2-a0bf-07aaca4a59c5"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("482f08f0-7654-4784-a21f-21b4cc567cad"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4913e935-6abc-48b6-aa09-c52919875b0c"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("49bd3834-b727-4977-98cf-61a2766eba37"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4a3f580f-0cd5-451e-a8ea-c727daac134d"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4aaa2fbc-b7d9-451a-bce3-8eb95edf18f6"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4abb1d3d-bfdf-4b8a-b90e-2f5bbea1c4ad"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4ae1d97c-5420-4cba-85c8-01d2dcc101c2"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4af29841-af65-408c-ab6b-b39c9b0c63b6"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4af4ea54-f270-4d88-9548-66611a805381"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4b19f9ec-51e7-4019-9eb2-ee1ef4075482"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4b5e24aa-08cb-4f66-a738-57f0e648bf3c"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4b76900f-e041-4100-b5dd-5bfe49927717"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4c24c671-a9c3-47bc-918e-e1d3080461f6"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4c63a204-9a6c-41d6-88da-912d635cda06"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4e8326b4-07d3-4c1d-8014-9fc57ae686f2"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4e87f9f4-fcc9-4656-8abb-244974e67cfe"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4f0bd153-b4f7-4606-a8f3-882845317a71"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("4fca6e54-1479-4b32-91e2-3ca485b920eb"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("504f2844-c89b-4193-af3a-1e4d1dc2c4f7"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("51161258-7e59-42e0-aa59-35bce966f7de"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("516344f8-74f2-4b34-a39e-fd6acfad4422"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("51c982c4-bd4e-463c-9c89-4571c25eb294"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("51d5dd5c-c9f5-4730-9435-3d182c4c5d99"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("52884777-2380-4c27-b2a3-59ff9dfb6b7d"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("52e17caa-f50b-4cc6-b889-b95e3ac39f41"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("532cbef2-a0b1-41a7-95a8-a5f46197c793"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("539c9a7a-d5ac-490a-898a-c1741daeaa3f"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("549e4987-498f-44b8-b9f3-37c702c28f99"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("552dc968-2375-4f80-9dd4-365d64d54d1c"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5533182d-8197-40e7-8036-f3d891d36fa1"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("55349ca6-285a-4b10-8ed2-3bc2246f319b"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5591eabe-8166-4fff-a790-05d1a32f4e58"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("56bfd555-e5dd-459a-b6df-e8fe4442ff3b"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("56ec3e91-b530-43bb-a6f2-dd5cd2dffa98"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("57bd0e35-c672-4bba-9f69-5ea5d8378d8d"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("595e62f0-ec10-41db-b460-901119a806e0"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("59e156ea-3fae-4f56-8a3a-7b9337633c00"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5adcd688-797d-455f-86a1-599bb1680c7d"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5af133e0-178e-4c74-a9ba-6b2303e34b54"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5bbfd066-c55f-4c4e-aff2-76eaba2b41b6"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5bd53cfd-f2ef-42fd-ae8c-70c6b0e69b36"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5c079c15-5568-4888-8e15-38e0cceb9bc0"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5c4a7f79-21a2-424b-b3f5-805636293f84"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5db21f4d-70c4-41da-9047-0a2b11f4af8a"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5e11e7e2-03a9-429b-9583-0877c2f4c31f"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5ee8d5db-caaf-4fc7-8469-4b2213255bca"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5f7f3874-f751-49ef-9a38-9eafbf8fa241"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5f9e7e3a-dd89-4517-b7fb-c7780e6640a9"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("5ff76d80-e2f3-47f5-b8d4-4f4fed175ffb"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6044db36-eb67-4b67-bee4-b94fbf241300"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("622150f3-8917-4bf3-a484-710bdd0a7ea5"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6357b0ce-4935-4570-96f5-26e3dbcba645"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("64ad60fd-fc18-461c-9fd0-c3f882e3ca93"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("64d6f7a6-4f18-4d57-967e-a63fe656d903"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("65a3264c-1740-4153-8aaa-53b729b47c46"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6653fc81-f2af-4d12-9a81-5da3e9c896a9"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6656ab3d-f7e5-4a43-bc04-e16b582a6e19"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("66cd2c6a-77c4-4203-a671-e6beccd5a6ba"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("670bb366-373a-491d-afff-38a3eb1d5983"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("68527238-83b6-468a-b57f-47c51e8cf400"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6880cfc3-ebe9-41f4-ac06-12bc0b7fce7b"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("698c29d2-6893-4c29-a0b3-6eb41fc5a542"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6a1eec39-1ec4-4554-bc31-5082cfc7ae8f"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6b59ee3e-774a-4bf3-90b1-539e6fa0c6de"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6d6f4058-d76f-4efe-ac48-f70024d0692c"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6d80f23d-43ad-4764-bcd1-b107b2da659f"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6ddb5a9d-3fd4-4095-88cf-730ba89d3c06"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("6e97a116-9d7a-41ed-b273-b85f798c1ec0"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("7016d365-ee5d-4c28-b139-1c418cc1fa07"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("701d0b0c-7e41-4efd-a64f-b2a79a6860bc"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("70915cd3-8277-432f-9568-be72c8ea8d0d"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("70df4295-57ea-4beb-a9fc-5fd2e39440dc"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("71034c39-8d15-45b1-9d16-3af9f2406bd8"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("72f83a28-97c7-443b-a914-14fe8d5d2d6a"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("745fef1b-7686-4b6b-9842-23f4ebfdd4bf"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("751a2f31-8cb8-4b2f-9211-83c2a33bfab4"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("75517a97-7876-4a7e-b20f-4e37c99468d5"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("7563b910-54dd-402b-8e87-12b3a6ccf85c"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("7586cc1b-7e0f-4ff0-b593-38483d04fbd7"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("75eab908-2ffc-4806-8b63-e64503190dbb"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("774afa26-3d7e-4571-b312-6ccf23b6aacc"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("77cb5bef-0aad-470e-b697-06c6f1587787"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("77e57e27-2959-4833-8d36-b4369158b207"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("77f13e21-dde4-4c37-8179-f3ee440947fa"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("794042c0-5bfa-4a9f-b39f-0f7b78f1c813"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("79a9294f-62ec-4313-a081-b8c5fd8169fe"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("7a81f8b7-1a42-4006-b193-e61878b07c77"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("7b35130b-3186-472b-b9e5-174e5882aecc"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("7bde1c28-7cba-417b-bcdc-cfb7771c22e1"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("7c19662d-bb5c-4921-aceb-12afb6fa1e19"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("7d4ea8db-e517-4dd1-a191-2470c89fa98f"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("7f93fb7d-ba39-4782-9355-06aa989554e8"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("80912782-eded-4be0-b6b7-dd33e6005c3a"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("80d5986f-742c-4a2c-86b4-258b1b10f808"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("816236dd-9bc4-4c3b-8fb2-08247e598803"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8416e77a-759a-4e64-90ef-eda8361e8d54"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("84706888-935d-45f8-bda5-41e669068887"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("84a25647-6938-49f8-bf14-6311f925a965"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("850b5e1b-17f3-4675-9983-e2ba146898f9"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("864ec55d-59c6-462e-b60b-ad33fe82f842"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("888e6e0f-f467-49aa-a67f-217a7628525d"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("88fe955a-bd24-4b62-ade3-be9e7cf0e085"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8941560b-98ed-4291-b0f1-bf5ccbaeeee7"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("89521651-316a-4649-8fe7-df19fb1926d2"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("89919f4a-7851-40b1-bf16-be6c537d10ef"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("89cd1acd-4df4-4e40-9dbc-c7151cf83209"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8a3d8964-f891-40f3-974c-84ee07b1afa0"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8a43504a-5825-4c88-a356-658c71219457"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8ace3c2c-b2cf-41fc-a8d2-17acaddb17c9"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8b4b0f5d-856f-49d2-82af-61a87dfc10d1"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8ce82425-296e-41c2-82fd-0a36deeb6023"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8d305ebd-45d9-4094-88e8-db4c148f11d2"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8d93ec54-cc09-4e41-a503-b454d72ad405"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8daac8e8-0784-4ae3-8cd5-aae250a2d185"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8db6cd59-4ba4-49e2-9992-b025a7895da4"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8e23d72a-ceca-4086-9677-e00d62fe558d"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("8e6965d3-fbce-422f-a478-b61d691bdf74"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9178b870-cb05-40f5-a31a-d44493322b87"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("91de61f9-069b-442a-8ac6-48a111741589"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("92146032-6a20-4808-bd5c-b405cc24a462"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("926afbbd-7010-41b5-88dc-3985c2e60c74"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("953e01fc-9a34-4b26-b93d-094d4a918549"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("95787353-61b6-4c1c-a55c-3024506ec7a5"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("95b0a158-af96-4fdf-914a-735e5a0b42a8"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9616d06c-67c7-4e8e-92e7-163e5f31d5bf"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("97413815-e200-4dbd-b68f-ade348ccec4f"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("97db5a39-c55e-4f3c-8694-d97421ab1eb9"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9859d458-6e4d-4211-8067-989ef403af86"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9949262b-93b5-4597-b878-a11fb00ba7c4"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("99addb6a-fbb1-409a-9353-b35e4d712b63"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("99bff122-e390-45ed-a1ab-cc225a1c00c3"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9a112c35-d62d-4f38-8c60-c7ffcbf29d3d"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9af3c5a6-ccfd-4ffd-90a5-ded3ccea3d58"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9bf1b741-98fe-4238-944f-71808d7e91c1"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9c5795cd-26b2-4856-801d-65ebda067997"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9cacbc01-d505-4fa2-a678-2a43dc0398e3"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9cd12fc2-dca8-4e42-9dfb-c7347f4ab963"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9d8a6a00-d80d-4131-bb9e-df10afd44bca"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9e13c0e0-7b1f-463c-ac3f-750b3f8e389f"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9e915514-2ecb-48f9-b893-131869e73c0d"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("9f4a273b-9be3-4e32-8a2f-85cc1cc25100"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a072a88b-3f5f-46da-a721-cee61389ed33"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a09abbe2-abde-4142-8258-a697731daedb"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a1f216aa-ff63-4239-904a-d111b57095ef"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a32b5522-b666-489a-8751-f36e35f329b6"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a40f6b6e-164c-46fe-9db9-e53f55ebae37"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a44fe6be-06f6-43e6-811f-36a801925f6f"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a541ff24-a58b-40c0-a052-b679d1578cf1"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a5915c84-800c-4b1e-b991-0d931b9285c6"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a5e5b942-a590-4d31-b218-4af6940013ea"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a6689121-2a94-49ef-b5a7-3be915beb1ef"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a6ce04c3-871c-4c69-9be6-10544155248e"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a731510c-392a-4475-93e3-465f9ea1c4f1"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a78b4fef-b67e-44ae-837a-defc6248136b"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a7f0b97c-8659-458e-84db-0bdc430eb2ce"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a81b257e-ecf2-4c1c-9467-d20f881dd310"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("a9162521-4028-4929-ad83-1c4ee4c4c481"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("aa7c8c4e-11d0-42da-988d-fd9741e10be5"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("aad4e1f2-2a51-43f3-bd92-f6eb5989f8e0"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("aafba082-5f08-4c01-9472-92e15b338558"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ab35d516-0b5c-4c8b-b97e-2b07a455056b"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ab567010-71f7-4bfc-a47f-fb113a4b1186"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ad3f08f6-9d46-44dd-9356-684ba8345428"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ae1a4504-488d-40f8-92d1-9b0e842949fa"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("af248035-cc6f-4874-89fb-5ecec665b1cb"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("af6a38cc-0881-45aa-8c4c-dc058f6c3b3b"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("aff23a32-2fed-4f83-9ee4-2fbe167c5d82"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b0d16f0a-f693-4429-b31f-ed50b9ef7cdc"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b12eec56-02a5-4622-a2de-17ad7e8551b7"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b144e9e4-d99f-4e90-b2b6-a3e04317c8d9"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b165aafa-90a7-41fa-9508-1c56fce5c1af"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b1ada7c9-a36c-4d6c-b1d1-f3480f24d67c"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b1d8be28-84ea-447e-b816-e8e8c17166f4"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b209e432-760b-4e30-a74e-f9398fe7dd4a"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b2309a86-ef74-4263-9fd6-66be385fd5e7"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b276767c-7c6e-49ca-8c54-9a19ee4f6a8e"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b3a652d7-5ce5-42fd-a776-880294446dea"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b4a48062-2ba7-49c2-ac33-e16665ab418f"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b63935f6-79f4-4020-8a92-8784afc2a427"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b6936861-6a3c-435a-9412-648e8d338c00"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b745b05e-3ca7-4e8e-a500-b266834849e9"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b78537df-d669-44a5-9ef0-6a4075e54cf2"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b8d66b8a-80fa-45c8-80ed-8262f4680df9"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b8ed8999-d2df-44aa-b035-3f0084152972"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b91a27a4-ccff-4c41-8fc9-20245974ad72"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("b9718dfc-e464-4471-ba96-b8241d58f34c"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ba33699a-cb08-462a-8068-25d6971d9855"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ba49df58-42ea-45b4-a108-c8dc454b77e5"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ba5bd9ba-0c24-4085-ab2c-b88b1becee74"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("baad74f2-af6c-47b3-b9b5-c057bf315e40"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("bb748e97-88b8-41f9-978c-a95c434553ab"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("bba68587-f66c-4f25-aae4-7e286021f666"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("bcd8966a-878a-4c12-9682-f8e27319c013"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("bd7756c9-a5e9-424e-9ed5-ce8c61ec8504"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("bd99fdc7-beb4-4fb5-ae54-4b90fbab4c48"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("bf935c1a-370a-4535-918a-5b1958392ac7"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("bfa5c78d-25c3-4b51-9384-6e6d519edd5c"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c001f089-7dca-4afa-a940-bb3cb3b3cf49"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c1d7f2b5-e47a-40a0-9dc1-84dbcd6365f3"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c1fa3983-7828-40bb-bc99-8966654f5757"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c207000f-488e-45d5-ab13-14a66dafc60b"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c2b7d00b-8560-4cdf-aeab-e27324124643"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c2bfcd25-5116-4e4b-a182-9917cb13559f"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c360a841-3358-424f-8b97-2ad2d6d9d06c"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c3e03ea0-9425-4112-9821-328d9ebcb114"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c4ed4d4a-c179-4278-82a3-2c9822371bb4"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c50970c8-6b18-4ddf-985b-0c5c2ba7034a"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c56b2047-372a-4e57-b5e0-52c16f0d6e79"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c59235b4-34f8-420d-b545-a8627636b557"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c6be66b8-4bf9-4a31-bb53-333e483eb10b"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c70f2fe6-40e6-42e5-a92f-5b3fab5e62d7"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c81eff75-5756-446e-9881-6c7cca16ea58"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c8e56560-8bb9-4e82-89bb-fe482eaef9c3"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c8f0ace9-5caa-4f83-ace2-42e56751711d"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c8f363cc-d1f2-45f5-8c95-c0507b45d4b9"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("c925ab6d-6f03-42ab-89fb-c1e3c7ce02eb"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("cadbc882-35a4-4136-8c46-5a2aeeecc334"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("cc1e36da-ab81-4444-8a66-54920522bff2"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ccfacefc-73af-46c8-bf6b-ee93a5445a67"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("cdde7fe2-9106-4c11-94c8-b16c4d61bdb0"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ce835918-80aa-4818-a79d-1a58bc084af1"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("cf0f63c9-bc5c-4b46-adb1-42af5d7c48fa"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("cfc16836-b3cd-401e-a148-cc6b1107ae01"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d15267bb-d7f5-438c-b194-847032c8513b"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d22aca86-16b4-4fd9-b728-6633293344d2"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d330eaed-1555-4e56-a18a-e5c73120a559"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d3ea4f84-0fb7-4135-abe9-4e06b5cd8db1"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d51035b6-4328-4909-8b8d-9ddb8107eb01"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d527d700-3a9a-4f63-9aa0-3abec4a62a43"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d56442e3-5858-4a1b-86d7-4a76f09a030a"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d5dacf21-9245-41bc-8220-22e8a0f33650"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d744201b-4638-41ef-9f67-4d3b2e4bb858"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d8deca9c-e6d5-456f-8460-d0610ca2ad57"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d96e008a-1476-43bf-b74b-c6ca9e90b64e"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d9dd70e1-a7f9-47bd-ba23-187580117730"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("d9f8b3d1-07dd-4555-b220-d80565f42913"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("db2de84f-51f3-4d91-a380-e22d49140092"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("dba2fa1d-9e09-4647-ac2b-91d01f761394"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("dcd0617c-f8de-49bc-9022-6dbccffe86a5"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("dcfe694a-1abd-4567-af23-75925ebd1af7"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("dda3d5ce-d040-4c0c-9158-647dda5ae480"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("de03ebe6-b011-404b-8838-660ded9394b2"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("de50e31b-1e36-4801-92a3-3f1ccc22b6cb"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("dea0342f-6df6-4109-a731-d9bd1a2d9412"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("dea1b296-7034-47d3-9e33-640eebfc82a6"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("dfc1cc60-b199-4d05-ab23-0ed7113ac974"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e1d0d58b-7e94-4620-841e-8e0076d2a23e"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e1e28ca9-8312-4e72-9228-ee9253abc6bd"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e31be447-1e2d-4f55-b8ad-03cb7371914b"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e399e6e9-8987-4a0d-b134-424bf8fa3836"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e3d128df-2c79-4905-8ab2-3f75105e3196"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e5ef573b-5129-4354-b021-bbfb6cebf38b"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e6122f5c-ca8a-48c8-b223-f1abe656e906"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e61d6dc4-7a4b-45da-8015-2fba4a03c8c2"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e6dc91ca-3b06-4ebd-b58c-22e771a41568"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("e8483812-85ff-49ac-835d-59a16dd9dc81"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ea168a90-f837-414a-b03e-793713afae9b"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ec369480-42d1-4ab0-ba86-5031bd5b5805"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ecd9cbfd-0ef3-4588-a1c4-183f0e162bfb"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ed97d761-bdf6-42d3-bf5e-1e9b5994e95b"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("edde5b4e-f2af-4888-a50c-e2096fd84e3b"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("edeab2b4-f651-4bd3-90e3-16187d795af9"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("edff47b4-e29b-453c-a05c-f9a67bae939e"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ee39e74a-4801-431a-83c8-793c6776e999"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ef442921-a207-4c18-9a5f-c67029b36b69"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("ef6648f0-c724-46af-a4a8-6443c2f83922"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("efe00027-db73-4a93-b9c1-2a696fa2167d"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f100828f-56e8-44ca-9f62-72716c2048f6"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f21eea46-8dbe-402e-a651-7555312279b8"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f22c4828-d705-4fa8-93dc-e309bb229c7f"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f383c241-545d-4a45-8188-1e5cba359e3f"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f3d8c3d5-835d-4f5f-ac83-9900615f344a"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f4134af3-dc5b-42a4-a620-19085da0f87e"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f4af1877-493c-4d46-a2ae-bbace0ffe337"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f54134d0-0774-481e-bcab-b502f57aaee4"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f54bb47f-f7a1-41b9-8ce2-c8dd14048066"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f5f4fc1b-9527-49cd-bee1-2b3cb29bc43e"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f83248e6-da20-4df2-97fc-69cda3d1dad4"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("f86f5b6e-d11e-41da-a6df-621569b49fa8"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fa36d4f9-7f0c-43b3-bbf2-0e44b0f124a5"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fa3a5c5e-1905-4a69-9963-2b4e7fea790d"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fa58f9c3-25c0-4580-b1ec-1fc48b7eb57f"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fad081ff-9c48-4162-8293-29868005cdea"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fbba1f14-9e14-4211-ba6a-468ff571e3b4"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fc33c8c9-02dc-47c3-8e08-5ede6bc6dd46"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fc7e96a4-9490-46d6-9fb8-a43a3e4cf53c"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                UnitId = 36,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fc843637-9e15-43e2-a2c8-39aaba7cc9a1"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                UnitId = 33,
                IsConsumerUnit =true, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fcfc55d9-a0bd-44c6-a5e0-d4d427f13a2e"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fd53ad02-db0d-4f82-b541-a1bf4e16b870"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                UnitId = 34,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            },
            new ItemUnit
            {
                Id = Guid.Parse("fe7e6d03-80c2-4704-9bdf-c389b73f6ab9"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                UnitId = 35,
                IsConsumerUnit = false, HasSerial = false,
                CreatedDate = DateTime.Now,
            }


        );
    }
}
