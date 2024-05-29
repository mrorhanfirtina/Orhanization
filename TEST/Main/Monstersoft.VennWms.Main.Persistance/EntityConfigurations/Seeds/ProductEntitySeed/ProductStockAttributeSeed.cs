using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ProductStockAttributeSeed : IEntityTypeConfiguration<ProductStockAttribute>
{
    public void Configure(EntityTypeBuilder<ProductStockAttribute> builder)
    {
        builder.HasData(
            new ProductStockAttribute
            {
                Id = Guid.Parse("000190b6-8f0a-4254-8cef-5fbf3f0e84f1"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("00405fc5-7968-42cb-bc76-731e324e4975"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("00704f9c-a661-45fb-83d0-a8ed44155085"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0193c2d3-fe15-45e6-9727-61b84cd7bbd0"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0200fa72-f474-44dd-84d9-41e3fb6b00c8"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("022e341a-bd5a-411c-ad60-2fb44c8d1897"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("03205d10-d7ec-4533-8e0b-5bf056cc17ba"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("03fd103b-fa53-42af-afb3-4f982f6dab1c"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("041b7fc9-957e-4554-8fa0-b2ebced77103"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0438c667-3a6a-4076-9bd0-2d076be4400e"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0521bd80-3947-4172-b5cc-2bcb966de15f"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("05223fa2-c557-4c80-b710-7754e527c23d"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("05ead9a5-d13d-4497-a1cd-4a03cdbd521d"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("05eb0b67-f691-4554-a881-a5411f2dfab9"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("062f4124-19a5-4a47-9183-daaf87ae4e90"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("079168d1-7682-48e3-b9c9-199a885ff694"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0800280d-fba0-4b4e-9268-464a4f3cdacc"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("081424b2-ae72-4fcb-b24d-4827c16d68d2"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("081b7beb-fe26-4253-af66-546ee829f026"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0944f51d-7cb1-4e44-9f38-e72f545ae5f5"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0b1ce846-cf04-4151-8ac7-ef48d08ed5bf"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0c6c6948-40d2-4e9a-baa6-43499ebf4e14"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0d8038e3-3aef-4330-b2ec-23cd3580aa32"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0d8ab733-6224-492c-a75d-2553804d9dca"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0d9b8fcc-713c-4dfd-920b-b2c92480a1ca"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0dd2392c-7b47-4aeb-b24b-93c867e9deba"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0e1135ab-4b95-4b9a-9104-69fde5b35aa9"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0e7a8e6c-52ed-416b-b7b5-4ed46db92389"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0efb6a44-d616-4dc1-96fa-fe14a3c37b6d"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0f211928-6d37-47d1-b0a2-ed5bfbc6a310"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0f9fb2b6-d3e0-4e22-9c15-cedd67bccc1c"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("0fc347a3-1fb2-48dd-b53b-e3caa84ee927"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("105733f2-99cf-4448-a28b-76db8484d473"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1140d09d-d00f-4b4b-98fd-04f09cf67f08"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("123224b3-1c01-4272-b8f1-e970a4aae358"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("12634704-ff84-4167-a157-52cda5ffa97c"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("12fb0482-9221-4a86-a476-af40015a8cb4"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("130c4dc1-5712-409c-8e89-52c83b2a7d68"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1421f1af-f697-4930-8aad-7d8042aedced"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("14fc4861-fe9b-46b1-88f1-fcee944f27b5"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("15e4251f-93df-4f44-b77d-18b0fa1768f2"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("167a7a85-ec51-488d-8e1f-05bfd7032313"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("16ae867d-34fb-4187-b757-e0b8102e8710"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("176ed201-05ed-4af6-b101-29e238a1aaab"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("18aa993a-dbbd-400b-82bd-e86d92651d15"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1a09e16b-5f8b-42c5-966c-dcac669ea1ab"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1a43b55a-6947-45d6-a433-07b28cdd57af"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1a9923d7-6219-4753-922e-a9a565086443"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1abc194e-99e3-4701-8412-609f41562f54"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1bfbde92-e62e-4f91-b0bc-8e378440d212"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1c34b181-d6df-4145-bfc7-8921e9772af6"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1c4be4d7-7044-4bc6-b3ac-30e39da537ad"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1c9ca288-9865-408d-8d7b-b35b155b5cc7"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1ca350f7-3234-4203-8720-2410552fc896"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1d331f55-e37c-47bc-aa66-e3a995131e29"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1dc2b895-f101-493a-9f3f-e069a54b302a"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1e1ceb4c-3e68-4345-9169-fa9852639578"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1e3eef83-4274-4b4c-ac88-142198cc524f"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1f754874-a695-4703-9771-2b21b70dbc6d"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("1fe1c7b5-3bc0-4a7d-b8f0-0dd556c0eeb1"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("201b9aac-eca7-4ca0-9e70-78c735e2b59c"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("208d89bd-153d-414d-ad8d-bac24af1ff46"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("21ce7319-b104-4690-a218-6fabc782f964"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("228cc558-c2da-4a1e-99dc-740a91353cf6"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2302a9c8-8bbc-455b-93f1-f9ad0c6fdf4f"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("23fc6bb4-5b01-46c7-8494-9a4f599b944f"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("240eb864-ab26-4e93-9d0d-03c6accfea74"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("245a3177-0e89-4209-b48f-147af8266b13"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("24d18359-c40c-4bb4-9e0a-1bff649732d7"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2562639c-c419-485d-a581-63f2c6e2ad9e"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("267a2c99-3786-433f-b135-ed36eb17f0c1"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("269f8d65-859f-4997-8687-67c14c35587e"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("275146d1-991b-4fc8-bfa9-9da3d4beff63"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("278cb6ca-33bf-4ba6-b036-b3de728a322f"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2795ec2a-d2ff-44ba-9a6e-ca2503d09c4d"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2874e3e2-209c-4a0f-a2b7-3bc78b0f6570"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2b1dddbc-cf1f-4da9-bf4f-122dc4372956"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2c0bb77d-3c06-4566-8c83-5db13fb8938c"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2cedfc55-3455-4288-8c2f-372d2a175131"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2cf49ec2-9b0a-4e2b-9908-6e234139f554"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2d2b9daa-a93b-46a2-985b-07cfecb228d8"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2d682065-f2ef-4141-9616-18588ed98985"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2da88d9b-3b08-440e-95eb-3067fe3e255c"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2de72e49-18c8-4a93-a7b1-946203f92119"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2e1ea3e8-310b-4f36-a8a3-3aa539202b44"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2e1f9ee5-3a11-43f0-b872-04537b6ffa80"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2f3ab467-5ed8-44eb-b1e3-28fe3a4c3900"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("2f61adb5-0494-420a-a551-12de0846c044"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("30cc118e-2469-4d89-a32c-737f1a12cfcb"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("3226fc5c-9519-4819-9608-94e00778dc86"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("32717ef0-5a8b-463b-bd2b-7097bb067147"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("32feca86-3a3a-4283-9da2-a8efa180838b"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("334e501c-e479-4eeb-bd04-aec2366641f3"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("3371a439-41c6-447f-9b93-58df4df7f700"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("33906f95-2655-4caf-bb08-535a45f2d243"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("3608647b-eff5-43a1-b7c5-32d6e680f2cd"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("361e1009-7e5d-4f71-ac00-6da5ba5e859c"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("365406e1-d9ae-4f25-8d3c-fb18c4eb4656"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("36b1545e-3efb-43fa-bf43-9d1f408b4aa8"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("37d5440e-2cf7-4ed3-9521-d390644d6ec0"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("37f0746b-4b51-43d8-b21d-f5ae3b863568"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("38397be6-6c7e-4471-b55d-acd9f9b4ee50"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("388894ea-47fe-4c3c-bc3c-96dcbbb38c52"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("38a10ee9-653b-464a-baf7-fe26f4bac7ab"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("39957ae5-6c00-442f-b861-debaa1a40560"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("39a79908-3d44-4d48-b9a8-b7bd36bd1841"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("3a56cb80-fef0-4d58-b5f5-c70abe6688fc"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("3b083b03-4a55-4514-8e4e-4f6ece37eb44"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("3cbe3b51-2a03-44de-a37e-92c43140502e"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("3cefdc98-22d8-400d-bdfa-f416d36c00b6"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("3d6736e5-0bcc-4e8a-ba47-30f64d2bc26a"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("401aa469-fb66-4f80-85d9-6da22c1c650c"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("4087b3ee-8a77-4665-ab5f-74f975454ed7"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("41272df6-4d65-4891-b799-b47fcfbdd9db"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("42b51315-9e68-4b57-b708-9264c08616b9"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("42f6b602-bea4-490d-b379-23a3f1adc6c4"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("437bfc58-511c-43d0-9689-033208985e39"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("43d35fc6-e41c-4e44-877e-60278244cace"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("43ecab36-7208-4f33-96c2-43cc7f352c0d"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("442705ab-e9e9-46fa-ae21-32355ee3ac63"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("461aa81d-71bf-48db-a09a-9d3729c467a1"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("463332b2-9454-4677-9b61-e21bac5c49d5"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("466c8cde-2662-447b-9d24-5fa6cef8d006"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("49a53061-c744-4c0c-b673-82c25a7be97e"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("49e038e0-a5c8-4224-90c5-c95e0ef5a076"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("49f67cad-054f-4a74-a2fb-9fb28b673d23"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("49f700e2-b667-44e5-af07-e5613352ea23"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("4ad15fcb-831e-437e-8df5-1288fb10742e"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("4b36ce68-1f58-4710-b5df-4d4990d04160"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("4b9f5fca-a118-4c05-a1a2-b89b64f8d66c"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("4cf9ff22-ba17-4c95-b56c-586143c6bdd3"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("4db45f3d-c277-4caa-ae3d-87313d53cd57"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("4e4dc6d4-480d-42e6-a03e-d0b156bb4806"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("4faceb4e-8449-4a56-bc09-36b9d36eeb72"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("50e47a71-0b6c-40c7-b073-2644670478e7"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("510f3a9c-6bd1-42e6-979b-e8cc9ab011b2"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("54251129-7803-4349-b11a-9d8f1a73691e"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5426fd04-166c-4976-9850-4bc8f25722fc"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5437225d-87cb-4a46-9034-83babf9b14c3"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("551d3658-1938-46ee-aa7c-d8a3e8d78d0c"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5577af35-0889-4ab7-bcf1-a470781e395a"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("559b421e-4ca6-4134-beb8-0ba2698105f0"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("576e0a0b-1d49-4fa6-a413-7012d52ff292"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("589d1ca5-a9f7-433d-aa02-509ab6b81221"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("58e2fe7e-3b6b-47b6-bceb-306e9e252626"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("59cc0ece-c696-4e70-a151-48041f8e07e2"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5abe81a7-8daf-4fc2-ad24-c2a1e1ddf5b0"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5b4eaaf7-6972-47f2-b265-d0212ecdd402"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5d411901-a4cf-43d5-a819-d72a157b8b9a"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5e2b43b2-3aa9-4445-8a9e-02d74fea8ccb"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5e31023a-e7a7-43c1-86b5-7d1c98718aa2"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5ed929d0-b368-4c8b-864c-354f437cc812"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5edfe7ad-90cc-4cb1-ba47-e87b2155d7a0"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5ee832bf-ef40-496c-b797-b32eb317acb2"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5fb4bfd9-b4b3-44d0-841f-30c81e6eaa6f"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("5fe1485f-d7bf-4164-8788-c6abf7e94219"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("60cefbee-01db-4b04-b0ed-68170a1a72a4"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("61204d5a-12bf-4ced-9f86-63cc66a29897"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("612ba616-0c84-4674-918f-b8de9859ce49"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("6209e560-7e28-46c3-a111-e7af1a137a38"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("625d0de5-957e-4391-b9b5-8e7d7f0bfba3"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("62b4640b-109c-4383-ac79-b72e3f84c9db"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("62baa4c7-51f4-42da-99fd-b40193b893c3"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("62de11f9-6a4a-4060-8753-fb4b6684297e"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("635d8b68-f134-4df1-bdf4-bcf0ea2a2b73"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("64b5f606-6d96-4420-a814-e85887dcb2c3"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("655c42c1-263c-4c18-bc32-62719aa1fad2"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("659fbbce-dc51-4ff3-8f89-2e117d4b8602"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("662593ec-8997-4ba8-ad14-1b8b6d3b7856"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("663fcf0f-4cbe-47ea-aad5-39d450352ca4"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("6723d03a-102a-4f77-9877-cab6efecc7f2"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("67b025b5-4436-4bce-be34-17a5463c80ad"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("685a59e9-4472-43e5-bbba-ce555deb2ec7"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("69721d75-fbb3-439d-b27b-07f28e4bc7c0"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("69f9f925-b00f-4f72-bba0-e08a42c34e3d"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("6a4ed123-d10f-49a6-bb4c-3fbc3057b576"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("6ec87af2-6545-438d-a3c6-90ec1fb1e653"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("6f602107-e17c-4347-9ac8-92a8d699e145"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("6f63adb3-10c3-414c-9738-6291123b76b0"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("6fe78374-785a-4957-afdd-4a6d080b0e4c"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("6fe8e3b7-61b2-4d66-9622-7b6ea90dc06e"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7109b219-f5b6-4a7a-a789-9135f911d1e7"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("718ad3b9-362b-409f-87be-bb3508eb6bd2"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("71a12a94-41bc-4b03-949f-c9e6bddccd98"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("71ca7fd4-3283-4c5b-8bd7-fec8e8155109"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("71e1a806-94a6-4986-bd2a-c0e7b0e99622"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("72422452-97ec-40ea-9d4f-ff5ca175c575"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7381f8c5-6b37-4591-974c-eb89f9789891"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("73b7ee09-166a-44b9-a224-82018176d54f"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("740e1af3-542f-4d14-bc33-5b87f907dc43"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("743c972f-b899-4b87-bff3-bb94ef69ae5f"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("74c9c240-9d30-49b2-94c1-4e59b8b2d3f3"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("75e35cdc-ccaf-4819-be90-8a766b1c2537"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("76945bff-f83d-4f5b-9ec7-ec0d1c106e0f"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("76cecd27-6b4a-4f55-a3e6-b53a07228507"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("76df2b39-8ece-45a5-9c7b-c20c3de68534"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7710581b-bc8c-46e2-b9b4-05453d9beab2"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7774096c-4f76-46be-8114-64dd584f546d"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("779f602d-6bfe-4c39-89bb-17a4e1809465"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("77fc37b0-78b3-4798-88da-2610e995445a"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7891b98c-1ad7-4d0c-a5a9-6045a0e67cf0"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("78cdebac-762e-4816-b193-fa68c12bf3de"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("78ede664-3f2a-47a9-aec4-1a7f408fd8ae"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7a58701d-7904-4955-8b8d-b7de070d3733"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7aeef6aa-be30-40c4-a826-48eadf933247"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7bf88727-354c-4a21-8d6a-47de80ecee28"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7ce9e7f2-118d-4118-8a40-52b77a0566a6"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7d141607-ea83-442d-b255-07baaf3fe839"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7d58e688-65d9-40a9-9e4f-105f1d9c5261"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7de5f13a-14df-4581-b9f0-c2a14f7ab6d9"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7dff7b4c-5069-4d47-8eda-ce9df81849ca"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("7f5c62d5-7d64-49af-a8ca-0a15472d5dde"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("81709f99-e4aa-4a0a-bf7d-cdbfa6479ac7"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("82732aef-f846-4669-bd75-cff2209541d6"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("838ac51e-560d-4db3-bb57-59d65b8b7936"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8452ae0a-f71d-4a9f-9254-5fde31db0bfe"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("85a2cba5-7815-4c5b-a9ad-8eac8285e36a"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("88a0dcd7-6235-4fb2-ba46-e00ade272b73"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("88ea8c65-1cc8-4964-b35a-164ebcc49f10"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("89040df7-84f2-4ff7-80d5-746b2f5f812c"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("89f07cab-7128-438e-b860-fe7a7ef1f671"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8a4b0fb2-f2fd-406c-a50f-5e81e624706d"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8af58e5e-d13c-40ac-91bf-871a9497c188"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8c3371fa-5ca9-4755-9c1c-5a9e57ea5e2f"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8c4a5ce9-7c13-4350-91e1-ed38bb9a914d"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8d63bb7b-a1e5-4371-9ca2-e510415b5e65"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8e4a4fc3-b18f-44a4-8e45-b72dc7955fc3"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8f37b6f8-4587-42b8-9235-fb13bde97edd"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8f6082fb-d8e9-4e26-8286-fd1da70820f5"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("8fe5d161-a87a-4180-8890-38c81a4d307c"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9091b593-f947-48f4-9460-8df01d4b2f1b"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("910b39ae-6d48-40b9-b631-cc353f369ba7"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("911c680c-ed35-4e00-b613-43a8c91a7f8d"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("912feec5-e861-4a52-beb3-1af26d4e3e1c"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("91696768-500e-4914-89ab-691565b81faf"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("92b52abc-b430-4ef0-af6a-e9c7b56dd979"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("92ce6a3a-5fdf-443b-94ee-24d89126b708"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("93a74d59-e78f-48ea-8ba9-88fda365e003"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("93dc9d3b-d91c-4371-b8d3-dc2437989d36"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("95c6b67b-8d55-48ac-a1b5-97eb113864c3"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("95fdbf61-e5f9-432b-9b1d-47a09b8b2798"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("963ad0e3-e40d-4bb7-92d6-1237ab1cb517"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("96d82d47-e6ae-4d08-86d6-37315091f6b8"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("97f74203-d1f4-4783-a9fd-8772d98edf5d"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("980f57a2-7cfe-4c3f-85fd-1be6ea57adf4"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("986784d4-d4cd-4e8d-b406-42ff95493d1a"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("98c80fbe-350a-434c-98f5-6ecdbbfc8394"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("98d089a7-ea30-4156-a51f-4544f4691181"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9aa8b4b4-bc13-42b5-afef-53448d92db49"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9ac21a82-90fd-4e8f-a7d8-46020a6f9f3c"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9b44a1fb-0b20-49c4-8214-7b5f874f0db9"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9bcc4add-3fd1-4c80-b3a8-97f04bebe5a7"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9be57336-0f23-4e2a-a2b6-4d19879a1aa8"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9bef2139-45e8-43e0-9754-83472661d737"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9c6dd6de-90cc-4096-b047-a35ad5d21568"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9cd3b791-e28d-4955-82e1-980926904fab"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9d669a0f-0e7f-40fa-81c5-6a97dc4242f2"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9d792d97-fc0a-4589-b0b6-1929684460b4"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9ddb81d8-ed56-4205-8c6c-090c84e82df3"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("9ef9be80-2802-4bee-b767-859f49bfcc79"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a34df7db-9cbb-4fc2-96f2-4ebe2fb70147"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a45aafd3-c0bb-4c5a-ba67-bd3689c41cd8"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a5a01877-5d68-495a-bbda-d2e97625b9d0"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a63306f0-302f-4d08-91ff-4b7058533d56"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a78cc63a-2b6d-4db5-be36-f50cd9d43084"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a7a392b0-a814-4bb1-99fa-ac5ed3fa3438"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a7c6dc17-ba37-4aec-b1ce-3826b276c60a"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a805e958-78c2-4e3a-a670-7e1623992fcd"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a807eba4-fa32-40bf-8346-54e6737160ef"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("a98b3fcd-cfad-4d3e-8199-099577137533"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("aaf730eb-65c8-4eb5-aa9f-a10f3dfec1fd"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("ab230f18-db3b-4d98-bdd4-e1cb8ce0b95f"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("ab4fe8f2-2558-4a9f-9a13-43e2ae84f284"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("ad28d202-e9ed-4a4d-95e6-b426b9f5f81c"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("adcd177a-bce5-4897-a7d5-ddada763654d"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("ae95f6df-3ea9-4092-9407-ef3254fd7457"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("af5bdee3-55e8-4195-ab72-0fa969e92533"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("afd3232f-3566-417f-ab6d-eb64d39c19a8"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b05bd07e-ea8b-4909-b01e-48ca276c5f9d"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b12513cd-19fc-4aa1-8c0a-7d61fba58284"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b1264bd6-630a-4111-b7fc-8a7bd0f2b551"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b14bb6cc-99b9-47bf-8472-4261e66ec34d"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b14bedab-8739-4548-b280-55c142cef654"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b21f279f-9683-4414-9aa4-38a3541d8454"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b2c192a4-850d-4b51-9261-cffacd8b043f"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b30c68ad-4c1d-433a-83fd-9a4bccf493b6"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b3973e4c-5f32-4584-ad03-232b3da8c017"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b4174439-600e-465a-a121-4a5be9915a9d"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b45f4b6a-60dd-4085-9fe5-47bd5e28f394"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b4d89ab5-7af3-49e3-a06c-f4aeb10a185b"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b4ff1c97-7e9e-4f68-ad2a-4b214d3e8575"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b5ac1143-a120-4e6e-8f0c-556284251275"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b61822c4-d098-498d-aab1-2de37f468bd2"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b61cb1bb-9b16-4084-9b9a-80f583f589b3"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b6c7da8c-6501-402d-af46-6f17f6c31c3d"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b6cde796-9d66-41f5-9bb5-255871ede24d"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b6de38a7-4e0b-457d-88c9-b0f34ea8d68f"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b6eb7464-f590-48ef-8d85-0fed210aa894"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b7ab5081-26a0-40cf-84cf-9c65bb7d37c7"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b7b3aae4-d9eb-45b7-a1af-263317c9bc9f"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b8127d63-04ed-436f-9bdd-46eb057ce35b"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b847cfff-1d5c-4bdd-a09c-044c40e5dfe1"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b882ef70-7df0-4743-8beb-d0997049a3ce"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("b90ff16a-dd5b-4dca-88b0-83b2b6f6c548"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("ba24f6ad-a094-4457-aa36-1fca3ed59c04"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bb03a5f8-d6f9-4241-8e5d-ec5cb6c24a09"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bb15f7fc-b944-449b-97d9-5934d1330c0a"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bb738c3b-0d96-4e0d-a302-213a2761b4d6"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bb908ba2-5e0f-43ba-b4de-c699e59d4322"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bcb06d23-4ec9-48ff-ae85-60e375378c5d"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bdd887e8-10fa-4805-82e1-b3cf81aef107"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bde87b95-ea0d-4b34-8219-3888c3c5afd2"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bf1379ed-f73e-4874-8e90-0a0fa751e87a"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bf4af5de-8bb9-4833-9ab3-0e30cbb16cf9"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bf79dc04-a8b7-46fe-a46a-4db57c71040b"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("bf8934fe-8cd6-4d26-b24f-20b1788e066e"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c07de51a-96d7-42e2-bb16-c690f1c23ae3"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c1ee8ab3-df18-4c02-ba7c-70f1d6b120cb"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c330be08-de25-44c0-82db-51be983b0775"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c4bca24d-76c0-4245-8379-edec58f604f9"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c4ef1734-56b5-4bf4-903e-c462fb512ff5"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c559ed32-0e3e-4965-9f96-d2c679a94d81"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c59c2c1d-8909-4d16-902c-a93dc4521c6c"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c753f235-273f-4890-9e97-690502a50162"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c76f638f-8e56-45ca-991d-498a765499c7"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c7c52d02-5072-49c9-8e2d-49818d5cf698"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c7c96766-fbec-4a77-a261-09c6a54b1acd"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c83bd1cf-136a-4465-9396-ffd184ec9fe2"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c9db97f6-572b-4069-8175-f059292619d5"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("c9fef469-9f5a-45bf-8a08-0de685a5b3cb"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("cadde62b-3d69-48f9-ae5d-bfdf82bc93bf"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("cbfb33d0-e446-4f1a-9161-b06d0eb67ef6"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("cdb36e82-cc05-43cf-9ccb-d0de2c374a77"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("cdca72d6-7889-4a4a-a04c-fe4a9a79c694"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("ce8a0426-975c-4056-8876-5e80d101b5b2"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("cf45ed8e-eb3d-4bc4-92fa-3f5c5e393b0a"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("cff8080f-7ee0-4af9-9d0d-c85b311d7168"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d02b6571-f462-4e1c-b12a-ab7c4aa2f73a"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d0a30688-4be9-4a7f-a7da-67dea07aaeaf"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d0ba78a8-759e-4375-98d3-061260ae72b1"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d0d55294-1d81-48d1-a5d5-c86683e4bbbb"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d2095a65-33c9-41b6-810c-20fed925954c"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d2526c2d-0333-4178-8891-3031f457ab3b"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d2f26798-68d6-47b7-a90b-a4908a8cf58f"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d35d68cd-b262-4cf7-a707-dfa010e9229a"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d3ee807f-1faa-4a0a-a98c-36cf2ead11f2"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d3f352ad-cf1d-4ed3-b5b8-ccb225f1c3a4"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d43c90b7-2901-4f0d-8cb9-63ed5047666b"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d52ca848-8cca-4533-9806-bd5417eee9f6"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d5c7b120-62e0-42bc-9b68-2b6804ffd803"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d5e8c48b-267e-4f4e-9b4d-1bfd2d41184f"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d6dcf384-2f13-4019-b6d1-cac04d5be3bf"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d6f64191-83a9-4c4d-9d90-7939446f7fca"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d761d4c8-b566-4211-8abe-c561e751bbc4"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d7be11ba-b851-4015-83d0-118e7b19e6d5"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d7d40702-f098-4e50-bd44-911039a264a8"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d89b7167-652c-4758-ba45-eb94f96af931"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d8bce9b5-7fd7-4449-8827-7d70b6b46f69"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("d98b5222-2b6d-4b47-a668-b73950e70201"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("dbab8a70-7c8b-46b0-8c73-380df724a1e3"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("dbc65ec1-6e5b-46cd-b21c-d72fbbcd9826"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("dd14b781-6404-4563-9c8c-25c263c5abf5"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("de243b8e-fc69-4b95-b004-60658a8a31ca"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("df964cdf-60b2-48f9-b4a1-e79659df01b0"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e03f1016-4c64-496e-b254-558ebb4ecc17"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e19ebae8-2492-47bf-9bf6-8763bd535d86"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e218cdce-832c-4bc2-9fe6-7d445825eb80"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e2bc5da9-51e0-4b27-a86d-29ef12df30f6"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e4414508-55e9-4dae-bb72-43e9ae6dd170"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e48f5b41-d4ae-4d36-9c3f-fed1e23a8bd4"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e61a8084-7648-4df7-bf30-d971d1997bc7"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e751a4e9-34ec-4c21-8ff2-d47dcac6ae7b"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e78fb14f-d3dd-449b-ba00-3a3a6161052c"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e87e1aeb-d419-4a08-9ce9-b028e5c5c9c9"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e9194dc9-932c-4de8-b23b-8aecf3f3c7d5"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("e9daec12-0b9e-4454-90ce-bac64559a461"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("ea9b5fa7-aa6b-48a9-8a5c-47dfded157e2"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("eb3698ad-5ff8-45f6-bf59-d4b19c03abab"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("edd11764-45b1-4577-9501-7ac413be8689"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("edf433f6-c7d9-4488-af50-07c0c975f340"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f140224e-ffc8-4866-9a0b-f6cf0514ed83"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f157f601-8742-47c0-987b-71ef79953435"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f1870af1-e3cf-4bd6-bbbd-6bfd3d0f10cc"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f1883c39-bcd8-4642-826e-8d6be721b705"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f1a9d365-cc52-44a6-b8bc-4a0b6c25a9dd"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f1ba3916-8632-4699-81f9-a6f0e50a2b3f"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f28799a7-ef87-423f-b885-e44bdcded5d4"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f2b5b480-8da3-4b0b-8e4e-f2e0e8d58678"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f33084bd-4915-479e-9066-ffca1a594469"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f4d053fc-88b6-4b53-a2f5-c10e7c57236b"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f4d0ed7c-c42b-46ba-a4c9-41e830e8f94f"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f4e46d5d-d08a-4613-8b5c-66607079a960"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f5ce42d2-7413-4725-a60a-f0a549aedaa3"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f62aa72f-51ac-4e7f-8622-d05069e268d5"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f6f86858-4e59-423f-8b76-a01e2c57812c"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f887da1a-c30a-4262-a296-a3e3d5e57b1e"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f9278d1c-0388-4ca6-a9ec-bf0a0bbfdce5"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f9752434-5908-4cda-890f-76b6e8e36b05"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f992ff9b-5c7d-40c6-bd1c-982cb40656b6"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("f9963149-d363-42c6-b94a-60d4674bda0a"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("fa19438f-b6ef-46a6-9027-1d4bb09b0f41"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("fa26e58c-bdcc-420b-8965-22189ef8dc65"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("fa5f4b1e-d4d5-45b2-bedf-e239665c0e9b"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                StockAttributeId = Guid.Parse("88F35BFA-2FE6-4DB3-B40A-1D0C3563E1CC"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("faa8c6db-41eb-431d-af61-b4f2a2b68039"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("fb238f96-eeed-4b80-8741-3aa1ee6c554e"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("fb99563a-0b32-4843-8d0c-c058433346fe"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("fc066179-f8ee-448c-93d7-1d2225f9633c"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("fca6bd98-5267-4fa8-a8f0-97777a03bc9d"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                StockAttributeId = Guid.Parse("424D8C1F-4501-4C38-A539-0CC877716563"),
                IsNecessary = false,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("fd603f42-120e-48fd-8a81-bdba2e53c948"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                StockAttributeId = Guid.Parse("EACD5B95-2E35-4B2E-8A9A-33DA04BFDB76"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            },
            new ProductStockAttribute
            {
                Id = Guid.Parse("ff196947-295e-4fd6-8fbc-5e8bd984c498"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                StockAttributeId = Guid.Parse("7C2D8D28-90EF-458A-83A0-A1D80D0AC975"),
                IsNecessary = true,
                CreatedDate = DateTime.Now,
            }



        );
    }
}
