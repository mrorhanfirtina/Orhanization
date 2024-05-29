using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ProductAbcCategorySeed : IEntityTypeConfiguration<ProductAbcCategory>
{
    public void Configure(EntityTypeBuilder<ProductAbcCategory> builder)
    {
        builder.HasData(
            new ProductAbcCategory
            {
                Id = Guid.Parse("7246bd9c-dbff-4da7-a7c0-9879c41f04d5"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("b794c273-611b-4782-b41f-e0bddb5871ad"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("70129a23-1abf-4a52-950d-fc2616b66346"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("7b78bc61-433d-4de3-bfbc-e533dc880524"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("05b6dc5b-6c6c-4942-883a-9a81fef97dcf"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("45716d87-7c70-456e-803e-ab4014e9bd95"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("9c708a9a-d2fa-4500-9d70-2764dc7a6784"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("def81da1-5a49-43e9-8b0f-728a9b6bab6f"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("4748fc12-8004-4279-a152-92b59ec50499"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("ee8df733-1795-400d-bed3-338b85d7db4f"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("1a3059fb-3b68-4bb4-a962-00258009ca1d"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("5367d0b0-1d81-49b6-8410-a2aebc1d08d2"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("142fdfd5-39dd-4149-94b1-4d54c8c03d1c"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("fb606d8a-4d69-4ea7-bdb2-e385c4c4b162"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("f957fdc4-422a-4102-99e0-2b029279ef37"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("354af166-ff74-4d2a-b1c3-be968b327396"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("097144bd-821b-4e8e-b21d-d4d5657811ae"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("9a986916-84a4-4a3f-b080-5ec823055471"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("c7666057-de70-4b4f-a92d-6cdf1864c528"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("02df6eac-dac1-4781-87f1-dff3f7b76402"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("b5bc53df-e4a5-46c3-81d5-7b1315dcf77a"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("63f16368-7b86-4e1e-bb72-1ad4650287f0"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("30f92a27-1cbc-4e6f-9397-db5afb871ad2"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("a6ee3dcd-4db4-4d42-a195-43336f09a797"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("fb648bc4-5e5d-4c94-beb0-93880b7ca0a3"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("64acd33c-02c0-419f-acb7-4eecb5fc7ca4"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("231b28d3-840b-4391-85e4-8eeb989b4d10"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("0881c825-8b89-4c51-aa9f-72ac8178b103"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("23612a47-a8d7-48d0-ac16-3898faf3ce76"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("04a3f8ff-a5ff-4bee-9194-799c946b2f14"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("22934213-b27c-464f-a196-0c4e2377362b"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("cbb7a5a7-db10-4ec1-93b0-9ad345b2ae52"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("10f6fd97-33f4-4db5-b20f-7ccabf4a047b"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("fc26dcd2-c070-458f-9b7c-abd483a3dedb"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("3cd0d88b-e468-4162-925f-07480e589ca9"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("19393e42-e635-49e9-a05b-23cd905eac69"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("ec2f6bca-b90d-4a93-bf14-d6b6487e9465"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("1277c338-7f7f-45a5-80dd-1013cdb2b7a1"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("b43593f0-7843-4084-84c8-3108cf3a76b4"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("5d7ee950-acc4-43f4-bedb-5b2065e87521"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("c0a0df7a-2316-4ac9-ae5d-f7c33f289603"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("49ff1b30-2679-461b-afda-47396e29960b"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("eae628b8-2c89-4ac8-9e8f-2c19ef50bd56"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("ab6b1bcd-a677-460b-adda-a797a0627f22"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("ffaa640f-65f2-4d1e-97e3-b543f069f011"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("fcc795dd-2604-4773-9ddc-077ec7ed7d4b"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("be141d7b-7d57-4164-b8ce-a2476efdb995"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("103de27f-ac63-43e7-8a57-d476181e75a6"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("4e1d512a-0247-4a5d-8176-11e8a5e7cc41"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("07439b33-720a-44ef-b190-121e4a5ee492"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("8ba137e8-1af5-4b30-8fc1-5c90a61dae8a"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("1d6a3792-490b-4d13-bed0-f9d42c18c079"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("c6f6c360-6074-487c-85ed-cde2e37ee79c"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("10c3bbe7-9f64-4f61-af56-f26948341a0e"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("01a8b8d0-6388-49bc-8c86-bc4e92b74c60"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("5723482a-6551-40ab-adb0-e16c6c5dbe7b"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("2e69b7ac-2f21-48e2-bf98-99759d97e3e9"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("a3c04b72-7ad9-49db-b604-4225ea77bae7"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("1605ac1c-e81e-48f3-882c-9449546e3ed4"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("29541647-f528-4868-9e0e-cfacd6153a12"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("05d9359a-c791-4baa-b5cb-44b242004236"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("1ccac83a-fcd5-4c19-8247-c77c35efb4a3"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("38150e1f-1491-4920-aeee-91c250fad0ad"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("0938b454-c621-4f89-a3e2-b39679471b48"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("e466898a-40de-4c45-a9d4-ee0437642042"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("f6471331-9dcc-4371-90e1-00fffacb71ff"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("b190b8d7-a6df-4c2a-87c5-37bae8340da6"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("f87dbd48-4684-4340-9499-74755e0361c2"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("f79d135b-f1a9-4f51-9398-f467159df8e1"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("8a3b426b-5c22-4369-97ca-1882847841b4"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("8df92b82-6e16-4555-afc5-1be949ddedb1"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("263d7e4e-3233-49cb-b201-17bbd09b8822"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("f3bd3fba-48ce-4d3e-a9df-4963edea178e"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("24791582-0b8a-401e-b308-d08dc38ba88b"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("0ac15f4c-63d1-413c-bf22-d8df2a10c0f3"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("0d130d49-f9e3-4bfc-91a4-70417e166c13"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("a397da71-0ba3-43de-9197-771cece1fff4"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("47298d20-9efa-44fc-9f34-2a2cabe44a88"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("b88062fe-2838-417d-96bc-62ef818d05c3"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("a85db70e-50e3-427d-8bc7-849b4c5f5ffc"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("10cf9fd4-075f-4f9e-9165-2360a89ea8cd"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("4e04648d-d047-40fb-a6ad-b0740a140974"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("dfce3b57-f15a-40c5-b093-a91daf664558"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("967715cf-6edf-4fb8-a70a-e16669acbfdf"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("a9bc900e-098b-45ed-be2e-fc11681e4c9f"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("df302fd0-5531-4f9a-80a1-1cad8ca9926d"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("a6919761-ce45-45ad-b4fc-a4c45eed3138"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("2402444b-28ce-4a1c-aca4-9164e6f0e38c"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("b24f3f8d-8e00-425e-a3e4-71c7ff1ed3c3"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("8b44e41c-686e-42c2-b606-a614e768791b"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("d08f862c-d940-402b-8dd1-33002d168599"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("f2ed8f6a-609d-4b32-841d-504ad71d6e17"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("2965d3a9-bb45-4a55-8ced-9e9dfde07f72"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("dd8d6dec-6b53-4279-aa27-2b9bc8227e92"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("202fb514-8a0f-4b98-a3e0-7b86b2bea810"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("4e269c56-5811-4e1d-925f-8ea45b995bfd"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("8bd94c1c-e53b-4498-acb4-7a6027618f97"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("8c979a81-fedb-4d76-8e41-efc8d82ee188"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                AbcCategoryId = 3,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("b99dbe62-19ef-47b7-b8fd-787b0bbe2d0c"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                AbcCategoryId = 2,
                CreatedDate = DateTime.Now,
            },
            new ProductAbcCategory
            {
                Id = Guid.Parse("246c99e5-5eac-4a2d-b86b-d1e039c5870f"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                AbcCategoryId = 1,
                CreatedDate = DateTime.Now,
            }

        );
    }
}
