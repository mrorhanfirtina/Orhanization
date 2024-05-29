using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

internal class ProductDepositorSeed : IEntityTypeConfiguration<ProductDepositor>
{
    public void Configure(EntityTypeBuilder<ProductDepositor> builder)
    {
        builder.HasData(
            new ProductDepositor
            {
                Id = Guid.Parse("00ec6716-9908-4332-8603-5cb2da916157"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("0101ad92-b4f5-40ca-9a8c-b1d374438cb4"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("01bc3726-04ce-4cf6-bb3b-fcbe70e2825c"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("020285e8-328e-43af-9248-73bf0fdd5488"),
                ProductId = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("027dc457-836a-4da4-b928-03a51f7fc4c4"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("04b94297-be13-4f3e-933c-73f31afe8e84"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("08645c7e-674b-44c4-8e06-71af3f106041"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("090ec986-62f6-42a3-b477-20fb1cb47f43"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("0bef5726-4c12-46d1-8681-834d860f0707"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("0dbb3b26-2626-402f-8b3a-e5135e836e45"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("100ece17-7187-4a36-bfa7-ca09c9a34601"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("110250aa-b5a0-4a30-8469-b17b1c6402f7"),
                ProductId = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("1117c9fb-30fc-49bc-84fc-1483ba2c68b5"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("1df1edce-4b7c-4c1d-804c-a0df51825c09"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("1e3b259b-78f0-4e54-9824-52a2723ddd6f"),
                ProductId = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("1e5d848f-9f10-40db-826e-cf65481ca208"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("1fd0c4a6-fd66-4bc3-8036-f7408b950714"),
                ProductId = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("25074ba7-d43f-45bb-9210-1049a566fe5d"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("26e36525-8079-40bb-9014-75c48e153f7f"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("290ff4c1-2822-4425-b158-818aefab65fd"),
                ProductId = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("293cb738-3023-40fb-bc12-c8dba6d9fd60"),
                ProductId = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("2ac70526-a5ce-4534-b299-b40fba508a5b"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("2d1a0a2e-1c7b-43ee-b280-0e24d078ea68"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("2e3e2167-fa6b-4b28-8856-60e00e576ec8"),
                ProductId = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("30db093b-f63d-4f2f-8087-d29c45ebaafc"),
                ProductId = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("32db5e28-4e24-44a0-8b65-38b8884e05b2"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("34b405dc-2c79-435f-8f48-098bfdd400db"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("34ca034a-092b-4fb4-bc5a-ed444a507069"),
                ProductId = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("361c36b5-ec49-4fdb-9e1f-8cdd2b6c9a55"),
                ProductId = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("365f06a6-11ab-4110-9aaa-b3d35ace8b9a"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("3673553d-0b97-4f42-8073-9442fe958b93"),
                ProductId = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("372131b3-f313-4d50-84f3-7ee991755aa3"),
                ProductId = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("373b1a98-e460-4ddb-9eaf-9d190db103a6"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("376ec00c-5c42-4278-b701-ccad207694db"),
                ProductId = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("3787526e-ba3d-4474-a457-967aab2d526e"),
                ProductId = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("385e4025-b23d-44a9-afc6-ba0b1079c768"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("38db65f4-843a-4fc4-b574-5292f377d7f1"),
                ProductId = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("38f3f79d-0052-4be9-85e8-74068e8a68a3"),
                ProductId = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("40afb2c4-ada4-4108-9cb5-9161683150c5"),
                ProductId = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("4567014c-acfd-4134-81c3-f0dd40f37b3f"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("464cfdac-882e-49d4-92d7-dae4ac0da197"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("4aa2a0bb-25c8-4d9f-9682-e4cc4a382907"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("4ac5097e-3c73-4e30-af19-34c988862f84"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("4b86c25f-19b0-4b56-9ccb-ec86cb224549"),
                ProductId = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("4d18417d-ed85-4e9c-b7b3-ba67dc838a2c"),
                ProductId = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("51f1cb18-33ca-46ff-9891-8519d1fe6df9"),
                ProductId = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("5384b6fa-fdc4-4a0f-8f22-bdbb0782c959"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("54ab41af-fcee-40ee-975e-3fcc3f77ecfb"),
                ProductId = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("5582d717-3921-4b70-bfd7-14515d33e88f"),
                ProductId = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("56011bce-6adc-435e-ab7c-553977c307f9"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("5b3dc296-d9b5-448f-ab92-3ccabd02198f"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("5ec1a3f2-dba3-4932-8696-fe068c0ac32a"),
                ProductId = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("5fe2c260-2de5-461b-8073-b4636ffb13fa"),
                ProductId = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("631735df-d1c7-444e-81ef-81ef5e60dc8e"),
                ProductId = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("650dce06-d89c-4bd0-92eb-a8bcd285fe90"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("6633db33-920e-493d-9122-2bbbd8c2ec4a"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("681db6dd-b47f-4220-a5e8-5f593765cf34"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("6a801603-e015-49c0-b57b-466b7d116097"),
                ProductId = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("6ba7a003-94ff-441e-8ece-4ce501eccf0f"),
                ProductId = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("6c3a7a92-6ae9-4bc6-903e-af6ac7a252d8"),
                ProductId = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("6c3cf6b5-bad2-41e7-acac-c723fee5d8d8"),
                ProductId = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("6c6003e8-afc7-4bc1-8c05-59fb7f1387b2"),
                ProductId = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("6fb1c616-9c3e-4a43-bf43-c1fc1900ee3a"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("7065f0e5-12c4-4f9d-ad86-442647c46a77"),
                ProductId = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("71c3ef26-3abc-4129-b3cb-c277c74340d7"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("72391e51-27c3-4c0f-9be0-1d0d6283037a"),
                ProductId = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("777f60e8-bc25-4bee-9460-9c05841d03cd"),
                ProductId = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("77e9a2f1-9f72-4d34-8d85-7b19e83230a4"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("7955fa6d-d4e3-453f-85b3-58e952a8c54b"),
                ProductId = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("7e315e0b-e27b-4625-a63c-afa5d4a8e1ad"),
                ProductId = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("7eef1c3e-4aee-480e-80d6-7bf24cb94626"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("8173c59d-2858-4165-a9ce-b3f99eaff3b4"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("81a0229f-94d5-46ba-a7c4-eb97fd31f10c"),
                ProductId = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("829f4395-e1a1-4dc4-90b4-be7447f803d6"),
                ProductId = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("82c59a09-4104-46a4-857d-39ef2e53c5f5"),
                ProductId = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("832d3cde-7cae-4b17-9d73-90cd14d3cd00"),
                ProductId = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("87d6699c-b250-477c-9017-772130192a40"),
                ProductId = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("887af06e-daf5-4ff3-901a-8df08374933c"),
                ProductId = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("8b47195b-99c0-4c4a-9355-cd95d3c21394"),
                ProductId = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("8b6cf1bd-a595-4918-bf5e-0dbf27225e23"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("8bd1ea7b-ad69-401e-b747-643ce90816ee"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("8bdde812-919b-4b32-ae16-463e386041fc"),
                ProductId = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("8cde1f14-cd95-4ccf-8fbb-2cf56636a8be"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("8e13fdcd-2dc8-4d6b-96f2-324face82a3f"),
                ProductId = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("90ed28b6-8809-4923-ae31-c9f5839bd49a"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("91d99c55-9dad-4a00-b438-5b3349e19222"),
                ProductId = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("93853a82-7468-4184-bf61-b22f8f2af3f8"),
                ProductId = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("93a27f65-304e-456c-b0d0-a3e5d679c581"),
                ProductId = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("953519bb-d3c9-44a7-9681-5ad5f4816a94"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("95c492e6-dcb4-4608-b098-84195bec1288"),
                ProductId = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("99870bd3-f2e9-44d2-b4b6-2dc2d4653651"),
                ProductId = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("9aae1977-5737-4f4c-9405-f4d404bc7f44"),
                ProductId = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("9b650ee8-fe10-40a5-8e00-0f30a5258845"),
                ProductId = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("9d3787f5-a77c-44c3-8f6f-799c1c929745"),
                ProductId = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("9e34b109-ac5b-403a-ade2-23845dd42570"),
                ProductId = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("a29c1520-a7fd-49d6-953c-97f5f53dc52f"),
                ProductId = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("a34bf75b-30f5-4c4e-ab9d-bee97dca90ec"),
                ProductId = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("a56de725-8e23-4acd-a4b1-e9589323a7d1"),
                ProductId = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("a902f169-132b-4b7c-bfb1-8038e47ebc85"),
                ProductId = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("a93bf8e8-97de-47da-aa66-e40fa60e4959"),
                ProductId = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ac0c6b62-6a14-43ca-8c45-615dfeac780c"),
                ProductId = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ae358d3a-58b5-42ec-8edb-8cc47230b98a"),
                ProductId = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("afca70f2-6782-4010-93a4-bacbecb0ba0a"),
                ProductId = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("b2d1da72-dbaf-4176-8482-ff47807b855d"),
                ProductId = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("b4a55ad8-f007-4d17-adcf-b098105073a0"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("b505e201-edbd-478e-817b-75ca9da82961"),
                ProductId = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("b59c0ae2-4dd5-44be-bea8-0460c39d0b54"),
                ProductId = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("bbb0adfa-31ac-49b9-832d-dc8051cd7a53"),
                ProductId = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("bd1fb799-f685-4844-a4c5-3c7706c2e583"),
                ProductId = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("bdde7857-fa60-43e6-8330-c17ea851de6d"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("be9da06a-1e68-440b-b8c1-5dd88e443d8e"),
                ProductId = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("bea0d692-ff57-4c15-b105-f9824a11fded"),
                ProductId = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("bfa14ed3-af30-473f-811c-836565450eaa"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("bfeada00-1ba8-4cc2-8306-029c3caf323c"),
                ProductId = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("c2398f57-ba38-4f7a-a711-7775cc5908bb"),
                ProductId = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("c653a0cd-7ccd-4e6f-907c-d2062baee088"),
                ProductId = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("c6c505bc-4c44-4819-9685-f398821ffbef"),
                ProductId = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("c80af524-fe51-418f-b148-f3cb8b0168c5"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ca4ad0e3-8e5f-4b30-a7ff-2c1ce20a5280"),
                ProductId = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("caa48873-328b-4663-81d9-a51ffa67e4fb"),
                ProductId = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ce4384af-0362-445d-98b5-6b8a021b6409"),
                ProductId = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ceb0b073-f5d8-4827-afe3-5f9ff59de1d4"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("d04fe941-9d14-4e6b-815e-99889a905db7"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("d08d5c65-d00f-4ff1-baf1-3a4a891afbf8"),
                ProductId = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("d292e5de-50a4-4238-9a94-aeb281187821"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("d5e763c1-a94c-433b-b382-4393c412511b"),
                ProductId = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("d7de38c0-4c60-4b3f-879e-612a033275ed"),
                ProductId = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("d8692233-4d07-49da-9acc-b5eddd93218d"),
                ProductId = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("d88a1d1b-f12a-4049-bc40-24c746cf552e"),
                ProductId = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("da4d3817-f8fb-486a-a939-d7c5f8dc124d"),
                ProductId = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("da8083d7-b4e3-4840-b077-90de8db13dd2"),
                ProductId = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("daae2079-f074-4902-952f-e9ce784ce80d"),
                ProductId = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("dbd71311-9ed8-404a-9699-5473e82f463f"),
                ProductId = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("dd31a409-7ce1-4fbc-8dc9-2b483ea08e7d"),
                ProductId = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("dd6faaaa-b1ef-4ecc-a1a8-3a6f0296c093"),
                ProductId = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("e1bcd268-5e8c-48d3-a292-3a936187d02d"),
                ProductId = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("e351fbcd-a4a5-4b6b-915f-8bf2a67d8bfb"),
                ProductId = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("e6fb582a-4492-46fa-ba92-3aed13a02ac6"),
                ProductId = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("e8bf9bdf-02d1-4355-89f8-9c342e0c26ba"),
                ProductId = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("e8d10967-b6d7-4a1f-b105-c6332c3ab710"),
                ProductId = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ea7b4f6e-328a-4f09-9637-1fa3c5a1b325"),
                ProductId = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ec2d44b8-41ef-4c31-8c30-49638774a209"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ec9db3ca-2644-4718-9c30-109822458d6a"),
                ProductId = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ecc45587-a30b-4cd0-a7de-7bc7b7d91c6c"),
                ProductId = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ee4ed3b8-a007-467d-96ed-5ac2e8a4c4fc"),
                ProductId = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("f7450c2c-deed-401f-85c0-47c908af1dc4"),
                ProductId = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("f9760b0d-a1ab-4cd7-9be6-2f7d44db0958"),
                ProductId = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("fb6caed8-485f-47af-a6df-5528342a65f4"),
                ProductId = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ff97ecc8-8610-479b-94c3-2b25ee347038"),
                ProductId = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                DepositorId = Guid.Parse("202d64f3-4474-4b55-b30d-61c430799efa"),
                CreatedDate = DateTime.Now,
            },
            new ProductDepositor
            {
                Id = Guid.Parse("ffca3146-4c29-4577-8884-ba9087aa6a51"),
                ProductId = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                DepositorId = Guid.Parse("2f7e0d11-04a0-4111-a0c3-fa1dc049e823"),
                CreatedDate = DateTime.Now,
            }



            );
    }
}
