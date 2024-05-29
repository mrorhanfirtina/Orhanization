using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ProductCategorySeed : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasData(
                new ProductCategory
                {
                    Id = Guid.Parse("04c20c25-559e-49c6-908d-3a57de9b16af"),
                    ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },

                new ProductCategory
                {
                    Id = Guid.Parse("07ced0c8-b988-41f3-9df5-456346455ccc"),
                    ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("0c3acb76-3a28-44d4-b02f-d209acca0eb4"),
                    ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("0f646c3a-0bf4-4e87-8639-be4424960e35"),
                    ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("0f870902-dd27-490c-86c1-326e79cfca9e"),
                    ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("113648c0-49fe-4a41-8ed5-cf94bd76957e"),
                    ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("12997f7e-f29e-4638-8199-5154789aca2c"),
                    ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("14308968-fcef-45fe-b0fe-69361dbb679a"),
                    ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("152bad44-65e3-4028-b479-970ffd0e61aa"),
                    ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("17d97554-acdc-4a14-9c2f-658e2a478866"),
                    ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("18fce8f8-6017-49b6-b09a-15366240a9c9"),
                    ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("1f2be9dd-6d81-46e1-9089-acece21674bc"),
                    ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("20bbf4c8-bf02-4ccb-9afd-48c993f15d54"),
                    ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("224a5230-8648-48bb-826e-dbb0accf1d87"),
                    ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("25284b89-0b83-4b1e-8ac1-d6eec3cff43d"),
                    ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("269b3754-4f30-41c0-91f8-620f47b4f73c"),
                    ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("26e45f6e-ff01-47d1-95ad-88ad4fd1be4e"),
                    ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("27ca0a45-13ef-4eeb-92ea-3667cc427eb0"),
                    ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("2e849d04-3898-49c1-b711-bc9057589d98"),
                    ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("3053442e-be7e-43ff-8be1-6bfef0187db6"),
                    ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("318e2c67-58f0-45f2-a8e7-d7aafd62477f"),
                    ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("36657a25-980c-4d32-ac1d-b18e7e910802"),
                    ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("3d7614cd-7a5e-4dcd-b3f3-3503b7ad49d0"),
                    ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("3fdc9632-de16-4b7b-8e59-fb530a7c8347"),
                    ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("403367ba-e3f4-4101-890f-d2ec4124967a"),
                    ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("41ea1d4a-ebd0-41b1-bc99-00f17332f5c7"),
                    ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("46cd9ead-a87e-40ca-bc7c-b84ab59b322b"),
                    ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("4c08bcb9-26e4-4a91-b6bd-ff98e7648c93"),
                    ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("4c97338d-189e-47c5-b20b-585cd24495e0"),
                    ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("4f1aeafb-d5ed-4cbe-aee5-f525055affaf"),
                    ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("523f4c16-c067-4cb8-abd0-3b8862666768"),
                    ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("53031f67-c92d-43d0-9c7d-fb4575dd6360"),
                    ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("547b86fc-da0f-4932-a80d-6a594b22296f"),
                    ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("56f45280-166b-49d4-933f-31138de81174"),
                    ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("5c943ebd-d2c4-41ab-b73b-0b8b637c2418"),
                    ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("5df69be2-cb35-4e22-a0b3-0f3edcc50ab4"),
                    ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("630d76cf-19aa-4ec8-8f2e-829f42183ca8"),
                    ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("68683b8e-c160-4673-abf6-73f90852bae6"),
                    ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("69818be5-ce25-4a33-aae8-09ee12c0e177"),
                    ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("6b6a70aa-0313-416d-be3d-fe69aaa616ba"),
                    ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("7220ae24-e00d-4b20-8d55-34d208486fbb"),
                    ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("744fce0d-d56f-4ebd-885f-518fca9293f5"),
                    ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("75e6da29-7edf-40f2-8e6c-9691bf72b876"),
                    ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("786d51aa-c51b-4e02-adee-83aa652ea9c9"),
                    ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("78bcdd81-874f-4e16-9ce7-0c381fabc698"),
                    ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("7941591a-bf5f-438b-bcde-7cca817ed1ac"),
                    ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("798f6ed5-9719-4de5-9e15-a850d4b22f98"),
                    ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("7bfcb08f-2ce5-496e-897c-38f4db295673"),
                    ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("7c00dbe1-3a4e-481b-9d90-5d60f0e928e9"),
                    ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("7c4eef02-cdd3-4d8f-b061-2dbeca0f0a45"),
                    ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("7c8ea5ac-3f96-4696-91d6-17bdc0e53ffd"),
                    ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("805cbe7d-f546-48cb-8540-0712a59b548c"),
                    ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("80f38861-335b-4dac-9acf-f080959f7d24"),
                    ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("81275274-4807-4dfe-b098-cf96b8884248"),
                    ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("81b3647b-d0a7-441a-a006-da54a80ff773"),
                    ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("82f61b7e-61cf-4837-b67c-6fb69b5037e4"),
                    ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("8465997c-c80f-49ca-9a11-e9b73423cb86"),
                    ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("8dba9d58-1c3f-4718-acd2-606e725bbbd6"),
                    ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("9022fc1f-6558-47c1-85de-867380c7a0f5"),
                    ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("92481505-a3f7-4249-acfd-72b40a3401d8"),
                    ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("93ba5eb1-1916-46b6-a3d5-c673c2c31f21"),
                    ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("9644a7ff-d746-4291-9a11-ac44509a13f3"),
                    ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("987b2bb5-71a5-4f98-9f8b-28d8f655c097"),
                    ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("9ae00827-2309-4a17-8152-28ee5bab4e0a"),
                    ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("9d126de4-50f4-4d94-81f1-5f025418ce9f"),
                    ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("a54de1f9-5c73-418f-8a62-ebedf63ed34a"),
                    ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("a58a136b-f7b6-4085-bcda-b10ca89fc901"),
                    ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("a6040cea-427b-4863-a566-60e81a98cd91"),
                    ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("b382d0b6-5b44-4094-802c-a0a912e286b6"),
                    ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("b655139d-2157-4dd8-9b10-04fc99bbb80b"),
                    ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("b66f43b8-648d-4fdc-9175-b4c9bb1044ac"),
                    ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("b7e293da-21a1-48fb-8c55-d43250bd8fc8"),
                    ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("b8bda8d8-2d53-4615-a93f-7e68f6624faf"),
                    ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("b922fa03-1c7e-402e-9354-e6b5bd7c01b5"),
                    ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("bf8ddae3-0443-4a87-8c7d-0b97ea0d9e22"),
                    ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("c0771688-24dd-4a33-9d76-ac4d3cf69da3"),
                    ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("c1b97ef8-52c3-425a-b26a-aad2a302db81"),
                    ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("c2aacb81-b5ee-4c02-994e-2e864f931160"),
                    ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("c64d46ba-a9cd-4e9a-99c6-b321357cfe5b"),
                    ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("cde30640-5ea2-4481-b459-2127f738ba70"),
                    ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("cfd928cf-cbf8-4cf7-a9e2-b6fd604d0b03"),
                    ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("d2ab371f-c521-4d83-a9f0-13dbd7bdeb6d"),
                    ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("d46e052f-9d0b-4404-82b1-cabf1c0e230e"),
                    ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("d78acdbe-736f-4ad4-b3db-4cc49dfac68d"),
                    ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("da604467-8bbe-44b4-8c07-cbef83d80121"),
                    ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("e30b3367-55fb-4e0b-80ee-3690bb8909be"),
                    ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("e4d3197b-293e-4655-9f7d-5dfab5c592bb"),
                    ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("e5b9ba87-880a-4f3b-a780-37092ac51b24"),
                    ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("e5e3ddd5-b0e0-487c-8a81-9fa438c91638"),
                    ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("e6acfe17-1c0a-483c-b676-ed1abe0ec56f"),
                    ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("ea284714-6c0e-4cfe-9774-4c45685a1e4d"),
                    ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("ea6389cd-8242-482b-b806-608fb5c54408"),
                    ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("ec14729b-7728-466c-a4b3-dfaeb43feed5"),
                    ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("ed562b61-64b5-490a-9791-c02701586f6c"),
                    ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("f0e025b7-a2a5-4111-a84e-dc75d0b44dec"),
                    ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("f5123011-ec29-4203-9e36-8e411cdd4a1e"),
                    ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("f68bc682-77d4-4108-aa7e-97b4ca268fc9"),
                    ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("fb216c2d-fd83-4aa2-b562-bc331d65bf35"),
                    ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("fb7f6979-fe01-40fd-99ed-5398a8254809"),
                    ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                },
                
                new ProductCategory
                {
                    Id = Guid.Parse("fe2c8896-be1b-4368-9955-484b0fbff54e"),
                    ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                }
            );
    }
}
