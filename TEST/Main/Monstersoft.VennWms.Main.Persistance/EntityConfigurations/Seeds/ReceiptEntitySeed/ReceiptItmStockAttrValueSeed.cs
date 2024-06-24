using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReceiptEntitySeed;

public class ReceiptItmStockAttrValueSeed : IEntityTypeConfiguration<ReceiptItmStockAttrValue>
{
    public void Configure(EntityTypeBuilder<ReceiptItmStockAttrValue> builder)
    {
        builder.HasData(
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("016ca324-8717-42e9-834c-fb96d62f7f24"),
            ReceiptItemId = Guid.Parse("53ffed4d-a02e-453d-aa5d-6a8f459458b9"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "156279008",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("028b3335-9038-49b5-9126-9949677bd91d"),
            ReceiptItemId = Guid.Parse("ba1a34f9-3d45-462c-b8d7-7786a291fbff"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "118977159",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("035fe813-db19-498c-af52-afb74f8bd6d4"),
            ReceiptItemId = Guid.Parse("f3eeb179-f6ef-4829-81de-69d2768a4e2f"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "120873070",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("0953397c-bfbc-4691-9112-5180fd88575f"),
            ReceiptItemId = Guid.Parse("89616fec-780f-4e8d-b0f0-6fcf551cf0d1"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "142875116",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("0bb4bc31-4827-4548-9f4a-0a1cd02ebf81"),
            ReceiptItemId = Guid.Parse("aa1821f7-d422-4b30-9745-67105a6a23ea"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "167946968",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("0dda6ffd-2d59-412a-8b43-0907ef0c7bf0"),
            ReceiptItemId = Guid.Parse("facd0fb1-9f54-4644-b11f-2e294181e35c"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "127344578",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("0e0690bd-6fdb-4202-acc1-829e4312a8a1"),
            ReceiptItemId = Guid.Parse("51ec9a80-2d3c-4fe8-99ce-28d3c09f8c80"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "163421492",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("1862b827-bb51-4970-a01f-a9ea28b1a39e"),
            ReceiptItemId = Guid.Parse("19fce1e2-7f78-40b3-a868-999cc75ff1e0"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "105528544",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("1898421f-b002-434a-b1a8-a9449df59de5"),
            ReceiptItemId = Guid.Parse("79223dbb-390e-45b3-826f-1fc2a3ba77d8"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "102439420",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("194499bb-8ed1-42f3-97c0-8d84edb16e6c"),
            ReceiptItemId = Guid.Parse("b8ce3e16-b005-4efa-87b0-37907657050b"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "197111047",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("1a68b15b-af77-47b7-836f-77fae6f8f6af"),
            ReceiptItemId = Guid.Parse("8c1eb527-e529-407a-a50a-f83ae4d422af"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "185074376",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("1e1f6425-0ba6-44da-ac4d-592b598aafcf"),
            ReceiptItemId = Guid.Parse("8319ebae-e9f3-41a7-8f99-85f3ad297683"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "163315139",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("200dd2fe-932b-4c73-9e1a-1fa709cc1f0a"),
            ReceiptItemId = Guid.Parse("50bd0536-bd8c-4d6b-85ac-d9c000da377f"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "171750526",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("247576bd-db14-4d5a-b254-aabab947c5b2"),
            ReceiptItemId = Guid.Parse("9ef9ded1-1748-4658-b201-2381a4b52e37"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "186348482",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("2a58c009-e9eb-47dc-af6e-6b91d9df0b71"),
            ReceiptItemId = Guid.Parse("157c9a94-f8b0-4e53-b481-3d52036e7253"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "130709688",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("36ae0e73-effc-4f6e-b0a8-44505a21b89a"),
            ReceiptItemId = Guid.Parse("01bbc949-f813-42c5-8014-331ae798e283"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "103159258",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("381621f1-fa34-4737-a5a1-c6ac44d87a77"),
            ReceiptItemId = Guid.Parse("9d8c9b6e-44d7-4cd8-9787-c816a40cc1fd"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "119401034",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("382e232f-3520-4b4b-b1a9-ac3fb93b768c"),
            ReceiptItemId = Guid.Parse("fc3bcdd5-3d4d-4bc7-91d5-0bc1c8959604"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "194535036",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("3cc1da93-72bb-40d5-b03a-8ba9228c1c40"),
            ReceiptItemId = Guid.Parse("7d4d58ce-6a29-4eff-b998-ecb4b40e0184"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "127238561",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("45bc559f-2765-436e-b4c6-7707f5700095"),
            ReceiptItemId = Guid.Parse("2e45cb9c-c542-4c97-8691-c490efe4e8dd"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "114323669",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("48208e83-eebc-406b-b587-75db5cc45d24"),
            ReceiptItemId = Guid.Parse("86660057-cd58-4686-a7e7-ba929f2db9ed"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "130175801",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("4d144df3-cde7-4092-b427-47b304e820db"),
            ReceiptItemId = Guid.Parse("39f0898c-aead-4ccd-8f35-0fb74ff5eff0"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "181730517",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("4d9ab74b-1f54-4a89-90be-799a5a8d5f2b"),
            ReceiptItemId = Guid.Parse("9dd1ce2a-3176-4757-8f47-74aec938cfe4"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "140753178",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("4dfcce66-e73a-4112-93a6-ab46f82ac1bd"),
            ReceiptItemId = Guid.Parse("1526285f-3289-4d87-9a62-8d5468d4bf78"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "129216211",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("4e453a15-cc01-46d0-aee0-e6a881343dec"),
            ReceiptItemId = Guid.Parse("51296444-8e18-44b3-b475-b5d5c4a43901"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "134844680",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("501b87ab-5994-445d-be0c-eadd4949982e"),
            ReceiptItemId = Guid.Parse("379317c4-00a8-4dcc-b189-da66ec86592b"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "108914946",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("505dcdf1-82bb-44a0-a691-414c34e126ae"),
            ReceiptItemId = Guid.Parse("37b406ba-783d-4b12-a0eb-5b41ff629256"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "127038872",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("5426bd12-bbad-427c-8e79-7c6254b5abbe"),
            ReceiptItemId = Guid.Parse("8a35f3fb-89cf-49dd-b806-eac0749d1610"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "115594328",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("549715e1-0924-4fcd-9dfe-76e9040ebdd2"),
            ReceiptItemId = Guid.Parse("58066098-73ec-42ec-b936-26fa38b0ce05"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "182024038",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("563c986b-e799-4727-befd-e47cf5141324"),
            ReceiptItemId = Guid.Parse("39d52d29-98df-4921-b5f6-d762cf5e4686"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "191127124",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("57fed275-bb96-48f0-a3fc-1f5027309a7c"),
            ReceiptItemId = Guid.Parse("d1790a4f-fa8d-421f-b649-9a1023b2d353"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "122156781",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("594c29fd-9b3e-488f-84de-148a55dd0116"),
            ReceiptItemId = Guid.Parse("6e224add-b8f8-4a60-b12e-5d6b3255cb20"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "149454630",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("59df3da3-8b27-4c62-8b02-dbad739b665e"),
            ReceiptItemId = Guid.Parse("2c33aaab-c1ab-4a28-ba53-32317c0bdb54"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "116389951",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("5bd846f4-d3f0-4ae0-a5b6-e32d34c2757a"),
            ReceiptItemId = Guid.Parse("0875db8c-3ed1-4b52-91ac-0b5b8b32daea"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "153209023",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("65988321-26a2-4a7a-af52-2f8a9ecda37a"),
            ReceiptItemId = Guid.Parse("dee5210c-bb9d-4740-8106-9a8ac2d35353"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "173269598",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("68540f3d-dac0-46d8-888d-7abede3c4559"),
            ReceiptItemId = Guid.Parse("1f2bae30-5d7a-4779-b929-7012f489851c"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "128443145",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("6aee211b-0121-4707-8e3d-d3e18ff25ddf"),
            ReceiptItemId = Guid.Parse("b742f7ef-768a-41bf-9f78-67abfcd89186"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "133089130",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("6cb01d23-5da2-4571-9074-c9d9853a8139"),
            ReceiptItemId = Guid.Parse("5e4ec5a7-4678-49f0-b8f0-64967b3686cb"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "159434008",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("6d937a50-772f-4a8b-b88e-2d30f1f440da"),
            ReceiptItemId = Guid.Parse("1b0d5558-e1c9-44cf-ac9b-232305288069"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "154543042",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("75e43877-4b2b-4b92-ba3f-c82d4717b53f"),
            ReceiptItemId = Guid.Parse("b21abf65-90ff-4dc8-aa53-93c54f5e7e82"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "110254055",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("761e7853-e56b-4e18-84d8-3da8bd783945"),
            ReceiptItemId = Guid.Parse("fe6c15a8-920f-416b-8120-241189e273d8"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "125534373",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("76a2e15b-d291-488e-abea-22e89817e92e"),
            ReceiptItemId = Guid.Parse("bc780339-49a8-4ea4-bab1-d91439dd2680"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "104546611",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("7cad30c0-e7bf-4268-9976-e6a79b6f7738"),
            ReceiptItemId = Guid.Parse("3b4a46ba-dacb-4882-a9f8-a06c84c53c95"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "168521860",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("7d974e1e-8a9a-46e1-943e-dbc15e2574d7"),
            ReceiptItemId = Guid.Parse("27be7659-43b1-41ff-b24e-61a8b3b65695"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "194068439",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("7e5fc6c7-671e-4106-b78f-9ad072791c2e"),
            ReceiptItemId = Guid.Parse("59813531-694e-4774-8b78-bf970a2d439d"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "153707242",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("80eb6670-5f85-4fa8-b68f-e400b225962c"),
            ReceiptItemId = Guid.Parse("21b38e80-6bc3-4427-8575-080c23c5a1e5"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "115710385",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("827f36a9-86e4-4e33-9393-76910e4319b5"),
            ReceiptItemId = Guid.Parse("99025625-6309-4072-b7e2-559797f07d7b"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "152344057",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("877078fb-0d51-4b33-a4c8-44bff7b0d898"),
            ReceiptItemId = Guid.Parse("6ff947f7-46fc-45c9-8fb2-2a287bd80e71"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "100699009",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("8d423c74-f73e-44a6-9dcc-9c7649685f44"),
            ReceiptItemId = Guid.Parse("bdf3ac3a-dc45-4ec0-81ff-921a543e3648"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "131565285",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("8d970710-2b18-4a4d-839e-bb0951eb86a6"),
            ReceiptItemId = Guid.Parse("d227f901-e508-4884-af00-614e5a2a3c53"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "169742716",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("9551bfbf-bdfb-44d7-b159-0e9870ac0365"),
            ReceiptItemId = Guid.Parse("bb55c7d4-7bea-4ca1-b2fa-8b82d54799cd"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "180746816",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("97e9bc4b-4138-45d6-8c6f-50243b19cc40"),
            ReceiptItemId = Guid.Parse("3b027351-86f9-4d6a-a640-349b823f1975"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "192117855",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("9a20d4a8-f0f8-4bb2-a472-4fdbb4be8b92"),
            ReceiptItemId = Guid.Parse("11888bb6-d26a-4ad3-8d8e-73f525ca8b37"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "111257061",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("a282ac43-8da1-49c1-8a1b-05a81a4e9e80"),
            ReceiptItemId = Guid.Parse("a957a879-7b32-4654-a4fb-ef6fa6ab8e58"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "187884967",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("a3ee8e40-540e-4a5b-87d2-34a9a58bd455"),
            ReceiptItemId = Guid.Parse("665e4994-0efb-4ef3-8018-e4396eadbf7a"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "165375334",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("a5a798fb-ec61-4b48-ab19-6f67a8deb9e7"),
            ReceiptItemId = Guid.Parse("f88203e6-25e3-4bf0-b2fe-e8651b0cc37f"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "147906786",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("a7898f35-f9b8-4cb8-9b3a-55397a0cbddb"),
            ReceiptItemId = Guid.Parse("3e94ed12-9500-451b-b183-114ec90a69f3"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "183844437",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("a7fc3021-5a01-4757-821d-95c7a5efc86f"),
            ReceiptItemId = Guid.Parse("d2bb0b41-1a6a-4e09-aab7-1e38d5e231da"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "198270719",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("ad1389f6-9a22-4414-8a3f-d72d86eeac79"),
            ReceiptItemId = Guid.Parse("17757419-96b4-4a21-bd55-9284f807eb5e"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "140597150",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("b01b2c68-ec76-41a7-836f-752e3b3099e6"),
            ReceiptItemId = Guid.Parse("8a5d8f22-9767-4412-a9b4-f9b37ea15c83"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "179658602",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("b0a27508-5276-4dcc-a2c8-13929607cd4d"),
            ReceiptItemId = Guid.Parse("e4a48e74-6b3f-4752-8701-0d5d5b8344cd"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "160436971",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("b2bc60aa-1d03-4da2-a9eb-4b024fa80f7c"),
            ReceiptItemId = Guid.Parse("fc2abee4-d220-434f-91f8-0b401fbbb52a"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "173570090",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("b42f067b-e5f5-436b-8371-cb1a20fcc861"),
            ReceiptItemId = Guid.Parse("01ba01d9-8733-41b2-a4ad-b2ba7c2c3538"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "155124666",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("c125a6a4-595f-4f3f-a15d-18db80ef2499"),
            ReceiptItemId = Guid.Parse("9b2866af-8ce7-464c-9389-65ea2d7ea502"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "124822965",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("c2492c3d-a64f-44d9-95da-b571ff637d21"),
            ReceiptItemId = Guid.Parse("f5d85401-a97d-4dae-ba7b-82c7cf0bd0ac"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "185552470",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("c26b550f-52b1-4479-a006-9fb38360c248"),
            ReceiptItemId = Guid.Parse("25e631b7-37f5-4ff4-a214-3779b0a534b7"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "197479110",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("c433dd22-1931-4033-89b2-8b541eb3fced"),
            ReceiptItemId = Guid.Parse("f1c29ac4-a1a9-4523-bd7b-36d535157f01"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "163094344",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("cd69ce7b-9269-483e-a87b-6fec12ee0ef3"),
            ReceiptItemId = Guid.Parse("5c20986d-a18e-4634-8668-91ad409c3329"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "116154088",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("cd9e68fa-21e3-4718-9910-554d229abc5f"),
            ReceiptItemId = Guid.Parse("cde3cfe2-f9cc-48d9-8951-cecbde788614"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "199931270",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("d1bcccdc-8e60-4320-b8c2-92aa90879614"),
            ReceiptItemId = Guid.Parse("a85b210e-1dca-41b5-944f-34a0a1d29651"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "143392773",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("d2b47b71-3f12-49dd-9af7-7fe6c5eb96b3"),
            ReceiptItemId = Guid.Parse("01308b60-13a2-4995-85c7-39634f619fe9"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "197356803",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("db811941-a4ad-4909-983e-41a1534b048e"),
            ReceiptItemId = Guid.Parse("cc10b138-4c8f-448a-bc06-9df1e89718fb"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "152689819",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("dc539217-a9ea-4062-8b92-4fda8e06b996"),
            ReceiptItemId = Guid.Parse("a5ebae5c-dc23-436a-a68b-77c9f93d2e03"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "146983489",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("de1c0db2-a85b-45bf-838b-e35a49aef297"),
            ReceiptItemId = Guid.Parse("e6cf7f19-314b-4d26-ae07-28176d30778e"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "160785038",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("de557576-8340-4aba-b91b-48e339f2e6bc"),
            ReceiptItemId = Guid.Parse("fb0e86b6-4452-49d0-a199-ce4e5c8d29f4"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "109249968",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("df77c2f2-b767-4ecd-afbd-b91ee8783a73"),
            ReceiptItemId = Guid.Parse("21f3fefc-0b49-4e6a-abc1-08199ff3f001"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "114152802",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("e6ebecf5-d5c9-4d18-b4f4-a55025086a3e"),
            ReceiptItemId = Guid.Parse("7bbda0fa-dc88-4819-a8a8-31cbfb0fe98e"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "172244781",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("e86ab306-3049-4990-9434-263c77b0e3a0"),
            ReceiptItemId = Guid.Parse("f24e946d-ee4d-4bf4-ae5e-9f2ea27c8622"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "114717254",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("e9957360-0230-4974-a55e-4e709b96901b"),
            ReceiptItemId = Guid.Parse("dc858b83-dc42-4eff-b824-8ee7d05d1018"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "169492617",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("eaa82ce8-596c-440c-96f5-b14099cf6b05"),
            ReceiptItemId = Guid.Parse("b756fe9b-57f3-4609-8e1d-ae2693a086d3"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "168137789",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("ee4ccba5-ed0f-4db4-ac07-b4bd0dfc5f69"),
            ReceiptItemId = Guid.Parse("790b811c-5a7b-4c0f-be39-64b1dfa0d200"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "182359480",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("f1d5f9d8-5dfa-429b-95e7-64145e455e17"),
            ReceiptItemId = Guid.Parse("7c138893-376c-407a-b64b-6c17fad3708f"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "120069850",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("f86d8ab1-0051-4dab-941d-007b0c5b65eb"),
            ReceiptItemId = Guid.Parse("11863482-b66d-493d-8d20-32b14ba88f8a"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "151063887",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("fa39858b-34e7-423f-a3f6-c8260ffbb86d"),
            ReceiptItemId = Guid.Parse("d95a0a7c-9fa1-408f-89bc-b5d3a7695869"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "134803088",
            CreatedDate = DateTime.Now,
        },
        new ReceiptItmStockAttrValue
        {
            Id = Guid.Parse("fba492c6-cb3f-40d1-bf1c-f8f1e7bc5895"),
            ReceiptItemId = Guid.Parse("5ca4ea40-9bb8-4c91-9e3e-ece1432b35e4"),
            StockAttributeId = Guid.Parse("821EAF46-CD9B-4DAA-BF16-BE5025687DA1"),
            Value = "171694832",
            CreatedDate = DateTime.Now,
        }

        );
    }
}
