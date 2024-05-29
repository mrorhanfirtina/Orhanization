using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReceiptEntitySeed;

public class ReceiptItemSeed : IEntityTypeConfiguration<ReceiptItem>
{
    public void Configure(EntityTypeBuilder<ReceiptItem> builder)
    {
        builder.HasData(
        new ReceiptItem
        {
            Id = Guid.Parse("01308b60-13a2-4995-85c7-39634f619fe9"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("C1E9C300-DFB2-4D59-B24B-D325E73EED61"),
            ItemUnitId = Guid.Parse("68527238-83B6-468A-B57F-47C51E8CF400"),
            ExpectedQuantity = 2592m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },

        new ReceiptItem
        {
            Id = Guid.Parse("01ba01d9-8733-41b2-a4ad-b2ba7c2c3538"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ProductId = Guid.Parse("E49EFDEA-46E2-4E3E-9E1D-CB8F2BD81CEB"),
            ItemUnitId = Guid.Parse("BD7756C9-A5E9-424E-9ED5-CE8C61EC8504"),
            ExpectedQuantity = 2160m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("01bbc949-f813-42c5-8014-331ae798e283"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("55EA8E5F-76F7-4F52-BBE8-2DF4D1D522E8"),
            ItemUnitId = Guid.Parse("8DAAC8E8-0784-4AE3-8CD5-AAE250A2D185"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("0279858e-d92d-4dc4-b0f1-150b893ffe06"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("09187E90-5E30-43AB-BD28-FA869EBBA906"),
            ItemUnitId = Guid.Parse("C81EFF75-5756-446E-9881-6C7CCA16EA58"),
            ExpectedQuantity = 240m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("07540211-7e5d-4fdd-8c30-2de711b4f548"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("30943E74-2644-4848-B12A-B385EBE76F3E"),
            ItemUnitId = Guid.Parse("D96E008A-1476-43BF-B74B-C6CA9E90B64E"),
            ExpectedQuantity = 288m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("0875db8c-3ed1-4b52-91ac-0b5b8b32daea"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("4B679760-1072-4A69-B0CD-B7F0B54E13A0"),
            ItemUnitId = Guid.Parse("88FE955A-BD24-4B62-ADE3-BE9E7CF0E085"),
            ExpectedQuantity = 1080m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("0af5bc3d-0b4f-48e5-bfe7-468356967c6a"),
            ReceiptId = Guid.Parse("9a1b66f5-520b-40b6-b556-6c24f894f284"),
            ProductId = Guid.Parse("0C20D2A3-0ECB-497C-B963-D8AA4E88B2D8"),
            ItemUnitId = Guid.Parse("4B5E24AA-08CB-4F66-A738-57F0E648BF3C"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("11863482-b66d-493d-8d20-32b14ba88f8a"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("CC92C663-85C3-4BCA-8333-66B04380979B"),
            ItemUnitId = Guid.Parse("07076D2C-EFCE-4CB2-A31E-A3DBF7FE4A97"),
            ExpectedQuantity = 1728m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("11888bb6-d26a-4ad3-8d8e-73f525ca8b37"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ProductId = Guid.Parse("E89EFE13-8CE5-45B1-BD6F-747695519A84"),
            ItemUnitId = Guid.Parse("51D5DD5C-C9F5-4730-9435-3D182C4C5D99"),
            ExpectedQuantity = 288m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("1526285f-3289-4d87-9a62-8d5468d4bf78"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("FBF09C48-C1D5-4A16-BDAF-3E5535D983AF"),
            ItemUnitId = Guid.Parse("A6CE04C3-871C-4C69-9BE6-10544155248E"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("157c9a94-f8b0-4e53-b481-3d52036e7253"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ProductId = Guid.Parse("B40836D7-6A05-4D61-B2F2-B8344D6996F3"),
            ItemUnitId = Guid.Parse("64AD60FD-FC18-461C-9FD0-C3F882E3CA93"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("15c30cde-cc4a-4881-bd73-9b3fe0824bc6"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("1D0FBE6C-D3CC-4D0F-A20A-122A1EE25190"),
            ItemUnitId = Guid.Parse("D15267BB-D7F5-438C-B194-847032C8513B"),
            ExpectedQuantity = 480m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("17757419-96b4-4a21-bd55-9284f807eb5e"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ProductId = Guid.Parse("D11CD853-1D91-46AE-95B4-B6F9F183E5CB"),
            ItemUnitId = Guid.Parse("C360A841-3358-424F-8B97-2AD2D6D9D06C"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("19fce1e2-7f78-40b3-a868-999cc75ff1e0"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("E19B56EF-BC63-4376-A258-247B51C2AC3A"),
            ItemUnitId = Guid.Parse("DFC1CC60-B199-4D05-AB23-0ED7113AC974"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("1b0d5558-e1c9-44cf-ac9b-232305288069"),
            ReceiptId = Guid.Parse("9a1b66f5-520b-40b6-b556-6c24f894f284"),
            ProductId = Guid.Parse("C1E9C300-DFB2-4D59-B24B-D325E73EED61"),
            ItemUnitId = Guid.Parse("68527238-83B6-468A-B57F-47C51E8CF400"),
            ExpectedQuantity = 864m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("1f2bae30-5d7a-4779-b929-7012f489851c"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ProductId = Guid.Parse("47278DB5-239B-43BE-81AE-89AF3AAF0443"),
            ItemUnitId = Guid.Parse("19192C15-01EA-4C21-9D8B-AD77D51E6A84"),
            ExpectedQuantity = 120m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("21b38e80-6bc3-4427-8575-080c23c5a1e5"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("47278DB5-239B-43BE-81AE-89AF3AAF0443"),
            ItemUnitId = Guid.Parse("19192C15-01EA-4C21-9D8B-AD77D51E6A84"),
            ExpectedQuantity = 360m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("21f3fefc-0b49-4e6a-abc1-08199ff3f001"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("FBF09C48-C1D5-4A16-BDAF-3E5535D983AF"),
            ItemUnitId = Guid.Parse("A6CE04C3-871C-4C69-9BE6-10544155248E"),
            ExpectedQuantity = 240m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("238b0c69-5407-4e01-b105-d9e04f90f015"),
            ReceiptId = Guid.Parse("9a9b98fa-80b9-4e94-93c6-aaa7bfb1262e"),
            ProductId = Guid.Parse("1D0FBE6C-D3CC-4D0F-A20A-122A1EE25190"),
            ItemUnitId = Guid.Parse("D15267BB-D7F5-438C-B194-847032C8513B"),
            ExpectedQuantity = 480m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("24572484-cbb5-426a-bbe8-f764e302bca2"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("09F106A7-DFFC-4868-97D4-9EE24B244B0C"),
            ItemUnitId = Guid.Parse("C2B7D00B-8560-4CDF-AEAB-E27324124643"),
            ExpectedQuantity = 960m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("25e631b7-37f5-4ff4-a214-3779b0a534b7"),
            ReceiptId = Guid.Parse("c0e64256-e82e-408f-8084-386d91381e5b"),
            ProductId = Guid.Parse("3B66B603-5535-44E6-82C6-320E73575328"),
            ItemUnitId = Guid.Parse("CCFACEFC-73AF-46C8-BF6B-EE93A5445A67"),
            ExpectedQuantity = 288m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("27be7659-43b1-41ff-b24e-61a8b3b65695"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("F8D487BD-A119-4E92-B443-1358B58C995F"),
            ItemUnitId = Guid.Parse("84A25647-6938-49F8-BF14-6311F925A965"),
            ExpectedQuantity = 2160m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("2c33aaab-c1ab-4a28-ba53-32317c0bdb54"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ProductId = Guid.Parse("71DE705A-489C-480A-9A03-8E112B787307"),
            ItemUnitId = Guid.Parse("549E4987-498F-44B8-B9F3-37C702C28F99"),
            ExpectedQuantity = 864m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("2e45cb9c-c542-4c97-8691-c490efe4e8dd"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("C493BB30-902F-4F54-830F-A3D6B1683A2B"),
            ItemUnitId = Guid.Parse("F83248E6-DA20-4DF2-97FC-69CDA3D1DAD4"),
            ExpectedQuantity = 2592m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("302f0c83-701b-4bed-9077-1f0335634628"),
            ReceiptId = Guid.Parse("dad42b46-2e25-4262-8463-718722488bb0"),
            ProductId = Guid.Parse("04202692-9052-4977-B297-683369796EE6"),
            ItemUnitId = Guid.Parse("BCD8966A-878A-4C12-9682-F8E27319C013"),
            ExpectedQuantity = 384m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("31e7b7b8-35f1-49e4-a61d-620dc92923b4"),
            ReceiptId = Guid.Parse("9a1b66f5-520b-40b6-b556-6c24f894f284"),
            ProductId = Guid.Parse("09187E90-5E30-43AB-BD28-FA869EBBA906"),
            ItemUnitId = Guid.Parse("C81EFF75-5756-446E-9881-6C7CCA16EA58"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("3649f54e-fd96-4846-923c-3f55df3783b3"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ProductId = Guid.Parse("1CD42C42-00E0-4C41-A7D4-61BC7F52644D"),
            ItemUnitId = Guid.Parse("51C982C4-BD4E-463C-9C89-4571C25EB294"),
            ExpectedQuantity = 360m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("379317c4-00a8-4dcc-b189-da66ec86592b"),
            ReceiptId = Guid.Parse("9a1b66f5-520b-40b6-b556-6c24f894f284"),
            ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
            ItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
            ExpectedQuantity = 432m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("37b406ba-783d-4b12-a0eb-5b41ff629256"),
            ReceiptId = Guid.Parse("fe6f7f97-5430-4bb8-b884-b54de4d30942"),
            ProductId = Guid.Parse("47278DB5-239B-43BE-81AE-89AF3AAF0443"),
            ItemUnitId = Guid.Parse("19192C15-01EA-4C21-9D8B-AD77D51E6A84"),
            ExpectedQuantity = 240m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("39d52d29-98df-4921-b5f6-d762cf5e4686"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("87538842-18E0-41E5-AD77-9E3E7F998C40"),
            ItemUnitId = Guid.Parse("7016D365-EE5D-4C28-B139-1C418CC1FA07"),
            ExpectedQuantity = 1296m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("39f0898c-aead-4ccd-8f35-0fb74ff5eff0"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ProductId = Guid.Parse("91276161-7358-4680-8FD6-A45FA83C3413"),
            ItemUnitId = Guid.Parse("9D8A6A00-D80D-4131-BB9E-DF10AFD44BCA"),
            ExpectedQuantity = 2592m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("3b027351-86f9-4d6a-a640-349b823f1975"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("E19B56EF-BC63-4376-A258-247B51C2AC3A"),
            ItemUnitId = Guid.Parse("DFC1CC60-B199-4D05-AB23-0ED7113AC974"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("3b4a46ba-dacb-4882-a9f8-a06c84c53c95"),
            ReceiptId = Guid.Parse("f6c46bf8-28c9-4ae4-b42c-1d1893e68e0d"),
            ProductId = Guid.Parse("70E20C31-085B-4BA1-97C6-76951BDE1A86"),
            ItemUnitId = Guid.Parse("FC33C8C9-02DC-47C3-8E08-5EDE6BC6DD46"),
            ExpectedQuantity = 2160m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("3ca803ab-fdfb-4823-9676-8cfa63fa218f"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ProductId = Guid.Parse("17497A0A-8F97-42E5-909C-AA52D0853A51"),
            ItemUnitId = Guid.Parse("AE1A4504-488D-40F8-92D1-9B0E842949FA"),
            ExpectedQuantity = 1080m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("3d6eff03-be37-4766-8f30-cdb6694bf96e"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("1D0FBE6C-D3CC-4D0F-A20A-122A1EE25190"),
            ItemUnitId = Guid.Parse("D15267BB-D7F5-438C-B194-847032C8513B"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("3e94ed12-9500-451b-b183-114ec90a69f3"),
            ReceiptId = Guid.Parse("9a9b98fa-80b9-4e94-93c6-aaa7bfb1262e"),
            ProductId = Guid.Parse("9959BACC-1C42-4791-8854-2285E471D4B3"),
            ItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
            ExpectedQuantity = 2160m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("3f9ae05b-1b93-47fe-94b6-a15e571453d1"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ProductId = Guid.Parse("04202692-9052-4977-B297-683369796EE6"),
            ItemUnitId = Guid.Parse("BCD8966A-878A-4C12-9682-F8E27319C013"),
            ExpectedQuantity = 1152m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("406ac959-8cc8-4ecd-848d-26c4365ddc2d"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ProductId = Guid.Parse("0F355ACB-83A6-459E-8E5B-8CEDF1BE204A"),
            ItemUnitId = Guid.Parse("AA7C8C4E-11D0-42DA-988D-FD9741E10BE5"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("4366b965-4d40-44c4-88e2-8f472bcca761"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("17497A0A-8F97-42E5-909C-AA52D0853A51"),
            ItemUnitId = Guid.Parse("AE1A4504-488D-40F8-92D1-9B0E842949FA"),
            ExpectedQuantity = 1080m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("50bd0536-bd8c-4d6b-85ac-d9c000da377f"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("9959BACC-1C42-4791-8854-2285E471D4B3"),
            ItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("51296444-8e18-44b3-b475-b5d5c4a43901"),
            ReceiptId = Guid.Parse("9a9b98fa-80b9-4e94-93c6-aaa7bfb1262e"),
            ProductId = Guid.Parse("F8D487BD-A119-4E92-B443-1358B58C995F"),
            ItemUnitId = Guid.Parse("84A25647-6938-49F8-BF14-6311F925A965"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("51ec9a80-2d3c-4fe8-99ce-28d3c09f8c80"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("E49EFDEA-46E2-4E3E-9E1D-CB8F2BD81CEB"),
            ItemUnitId = Guid.Parse("BD7756C9-A5E9-424E-9ED5-CE8C61EC8504"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("53ffed4d-a02e-453d-aa5d-6a8f459458b9"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("71DE705A-489C-480A-9A03-8E112B787307"),
            ItemUnitId = Guid.Parse("549E4987-498F-44B8-B9F3-37C702C28F99"),
            ExpectedQuantity = 1296m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("54cb9c1d-b65c-4c58-b978-53edf4f0eadf"),
            ReceiptId = Guid.Parse("c0e64256-e82e-408f-8084-386d91381e5b"),
            ProductId = Guid.Parse("0CAE18A2-B990-4DB5-9EC2-54E081D3F378"),
            ItemUnitId = Guid.Parse("4FCA6E54-1479-4B32-91E2-3CA485B920EB"),
            ExpectedQuantity = 240m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("5742661f-1206-44c9-a232-0dcd0d1f6c92"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("05F16EE5-B3E2-4EA7-B5BF-16ED86D84CCE"),
            ItemUnitId = Guid.Parse("EA168A90-F837-414A-B03E-793713AFAE9B"),
            ExpectedQuantity = 2304m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("58066098-73ec-42ec-b936-26fa38b0ce05"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("70E20C31-085B-4BA1-97C6-76951BDE1A86"),
            ItemUnitId = Guid.Parse("FC33C8C9-02DC-47C3-8E08-5EDE6BC6DD46"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("59813531-694e-4774-8b78-bf970a2d439d"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ProductId = Guid.Parse("5868A3DF-C076-4DAE-88ED-A763A8E2C2D9"),
            ItemUnitId = Guid.Parse("39DA5472-7CBF-45F4-B607-14F223F61BAD"),
            ExpectedQuantity = 1080m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("59f51594-ebb3-4cf5-85ee-608e980fe4c6"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ProductId = Guid.Parse("2C7AFEDF-7D80-4486-861A-9EA50DBEE9FC"),
            ItemUnitId = Guid.Parse("E8483812-85FF-49AC-835D-59A16DD9DC81"),
            ExpectedQuantity = 288m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("5c20986d-a18e-4634-8668-91ad409c3329"),
            ReceiptId = Guid.Parse("dad42b46-2e25-4262-8463-718722488bb0"),
            ProductId = Guid.Parse("AE325DB7-B0EA-4C72-9FCA-59B680C4209A"),
            ItemUnitId = Guid.Parse("B165AAFA-90A7-41FA-9508-1C56FCE5C1AF"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("5ca4ea40-9bb8-4c91-9e3e-ece1432b35e4"),
            ReceiptId = Guid.Parse("f6c46bf8-28c9-4ae4-b42c-1d1893e68e0d"),
            ProductId = Guid.Parse("E89EFE13-8CE5-45B1-BD6F-747695519A84"),
            ItemUnitId = Guid.Parse("51D5DD5C-C9F5-4730-9435-3D182C4C5D99"),
            ExpectedQuantity = 864m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("5e4ec5a7-4678-49f0-b8f0-64967b3686cb"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("836FA41A-AEB7-4C7C-9CE3-5BD1A99A1B46"),
            ItemUnitId = Guid.Parse("D9F8B3D1-07DD-4555-B220-D80565F42913"),
            ExpectedQuantity = 1728m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("665e4994-0efb-4ef3-8018-e4396eadbf7a"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("AE325DB7-B0EA-4C72-9FCA-59B680C4209A"),
            ItemUnitId = Guid.Parse("B165AAFA-90A7-41FA-9508-1C56FCE5C1AF"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("66aa3171-d81c-4cb1-a0cb-7ca3ed21314f"),
            ReceiptId = Guid.Parse("9a9b98fa-80b9-4e94-93c6-aaa7bfb1262e"),
            ProductId = Guid.Parse("05F16EE5-B3E2-4EA7-B5BF-16ED86D84CCE"),
            ItemUnitId = Guid.Parse("EA168A90-F837-414A-B03E-793713AFAE9B"),
            ExpectedQuantity = 1152m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("6dd94c7e-8b3f-4f24-80fa-fbab7d5640c6"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("04610291-8C35-4655-BA9B-48198D0D6457"),
            ItemUnitId = Guid.Parse("DBA2FA1D-9E09-4647-AC2B-91D01F761394"),
            ExpectedQuantity = 1152m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("6e224add-b8f8-4a60-b12e-5d6b3255cb20"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ProductId = Guid.Parse("4B679760-1072-4A69-B0CD-B7F0B54E13A0"),
            ItemUnitId = Guid.Parse("88FE955A-BD24-4B62-ADE3-BE9E7CF0E085"),
            ExpectedQuantity = 360m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("6ff947f7-46fc-45c9-8fb2-2a287bd80e71"),
            ReceiptId = Guid.Parse("c0e64256-e82e-408f-8084-386d91381e5b"),
            ProductId = Guid.Parse("FBF09C48-C1D5-4A16-BDAF-3E5535D983AF"),
            ItemUnitId = Guid.Parse("A6CE04C3-871C-4C69-9BE6-10544155248E"),
            ExpectedQuantity = 480m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("7291ac0f-9e46-4fec-85e7-db3eec4a1e4f"),
            ReceiptId = Guid.Parse("f6c46bf8-28c9-4ae4-b42c-1d1893e68e0d"),
            ProductId = Guid.Parse("09B413E9-02B8-4FE7-9646-75B7ACDF1FEF"),
            ItemUnitId = Guid.Parse("452C3E2B-225C-4A15-BD5D-136220415A89"),
            ExpectedQuantity = 480m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("72e92d80-2096-4f80-aaf2-fb8f65376e2c"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("00D22996-340A-46CC-8D64-2C103CB59ACF"),
            ItemUnitId = Guid.Parse("4913E935-6ABC-48B6-AA09-C52919875B0C"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("75385552-a45f-4368-bd8b-c7aaa24d56a3"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ProductId = Guid.Parse("09B413E9-02B8-4FE7-9646-75B7ACDF1FEF"),
            ItemUnitId = Guid.Parse("452C3E2B-225C-4A15-BD5D-136220415A89"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("790b811c-5a7b-4c0f-be39-64b1dfa0d200"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("96F39E35-716A-4424-B45C-E3E9F9540034"),
            ItemUnitId = Guid.Parse("7563B910-54DD-402B-8E87-12B3A6CCF85C"),
            ExpectedQuantity = 360m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("79223dbb-390e-45b3-826f-1fc2a3ba77d8"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("55EA8E5F-76F7-4F52-BBE8-2DF4D1D522E8"),
            ItemUnitId = Guid.Parse("8DAAC8E8-0784-4AE3-8CD5-AAE250A2D185"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("796d339e-8b3f-4d2c-bf95-7ad74c099839"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("09B413E9-02B8-4FE7-9646-75B7ACDF1FEF"),
            ItemUnitId = Guid.Parse("452C3E2B-225C-4A15-BD5D-136220415A89"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("7bbda0fa-dc88-4819-a8a8-31cbfb0fe98e"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ProductId = Guid.Parse("87538842-18E0-41E5-AD77-9E3E7F998C40"),
            ItemUnitId = Guid.Parse("7016D365-EE5D-4C28-B139-1C418CC1FA07"),
            ExpectedQuantity = 2592m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("7c138893-376c-407a-b64b-6c17fad3708f"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("3B66B603-5535-44E6-82C6-320E73575328"),
            ItemUnitId = Guid.Parse("CCFACEFC-73AF-46C8-BF6B-EE93A5445A67"),
            ExpectedQuantity = 432m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("7d4d58ce-6a29-4eff-b998-ecb4b40e0184"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ProductId = Guid.Parse("C493BB30-902F-4F54-830F-A3D6B1683A2B"),
            ItemUnitId = Guid.Parse("F83248E6-DA20-4DF2-97FC-69CDA3D1DAD4"),
            ExpectedQuantity = 1728m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("8319ebae-e9f3-41a7-8f99-85f3ad297683"),
            ReceiptId = Guid.Parse("9a1b66f5-520b-40b6-b556-6c24f894f284"),
            ProductId = Guid.Parse("A276616B-F023-4D6F-87EA-DF5574BD4F9C"),
            ItemUnitId = Guid.Parse("A32B5522-B666-489A-8751-F36E35F329B6"),
            ExpectedQuantity = 1080m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("86660057-cd58-4686-a7e7-ba929f2db9ed"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("93B43571-A79A-4FFE-9112-4C48B400A8A9"),
            ItemUnitId = Guid.Parse("146DF446-ED3B-435B-8E11-9D4E57EBC025"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("88324f82-2e3e-4184-ac79-c2b0fa06fef9"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ProductId = Guid.Parse("09F106A7-DFFC-4868-97D4-9EE24B244B0C"),
            ItemUnitId = Guid.Parse("C2B7D00B-8560-4CDF-AEAB-E27324124643"),
            ExpectedQuantity = 480m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("8879bef1-ef86-4569-a72d-424a8b90553c"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("0CAE18A2-B990-4DB5-9EC2-54E081D3F378"),
            ItemUnitId = Guid.Parse("4FCA6E54-1479-4B32-91E2-3CA485B920EB"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("89616fec-780f-4e8d-b0f0-6fcf551cf0d1"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("E0268B02-2174-40CB-8630-4911D407C52A"),
            ItemUnitId = Guid.Parse("56BFD555-E5DD-459A-B6DF-E8FE4442FF3B"),
            ExpectedQuantity = 960m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("8a35f3fb-89cf-49dd-b806-eac0749d1610"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("42D23B7E-70C4-49A7-BB2A-6D27D2F727D6"),
            ItemUnitId = Guid.Parse("CFC16836-B3CD-401E-A148-CC6B1107AE01"),
            ExpectedQuantity = 288m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("8a5d8f22-9767-4412-a9b4-f9b37ea15c83"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("836FA41A-AEB7-4C7C-9CE3-5BD1A99A1B46"),
            ItemUnitId = Guid.Parse("D9F8B3D1-07DD-4555-B220-D80565F42913"),
            ExpectedQuantity = 2592m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("8c1eb527-e529-407a-a50a-f83ae4d422af"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("F8D487BD-A119-4E92-B443-1358B58C995F"),
            ItemUnitId = Guid.Parse("84A25647-6938-49F8-BF14-6311F925A965"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("94dcf0fd-ba58-4c1c-b11d-027fcc117dfa"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("04610291-8C35-4655-BA9B-48198D0D6457"),
            ItemUnitId = Guid.Parse("DBA2FA1D-9E09-4647-AC2B-91D01F761394"),
            ExpectedQuantity = 3456m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("99025625-6309-4072-b7e2-559797f07d7b"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("ED170CD5-03F5-4872-8D09-7C562DEE0E1C"),
            ItemUnitId = Guid.Parse("00C9D6EA-C404-4EED-9B2B-EABEF1305DC1"),
            ExpectedQuantity = 864m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("9b2866af-8ce7-464c-9389-65ea2d7ea502"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("B40836D7-6A05-4D61-B2F2-B8344D6996F3"),
            ItemUnitId = Guid.Parse("64AD60FD-FC18-461C-9FD0-C3F882E3CA93"),
            ExpectedQuantity = 2160m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("9cea954f-5ce3-4aec-9325-9f3a8d66ef68"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ProductId = Guid.Parse("259EEC3C-C5CA-4715-8D64-9423EF301586"),
            ItemUnitId = Guid.Parse("B4A48062-2BA7-49C2-AC33-E16665AB418F"),
            ExpectedQuantity = 240m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("9d8c9b6e-44d7-4cd8-9787-c816a40cc1fd"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("B1E0AE2B-B271-4613-89D8-8575564A6944"),
            ItemUnitId = Guid.Parse("5ADCD688-797D-455F-86A1-599BB1680C7D"),
            ExpectedQuantity = 2160m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("9dd1ce2a-3176-4757-8f47-74aec938cfe4"),
            ReceiptId = Guid.Parse("dad42b46-2e25-4262-8463-718722488bb0"),
            ProductId = Guid.Parse("836FA41A-AEB7-4C7C-9CE3-5BD1A99A1B46"),
            ItemUnitId = Guid.Parse("D9F8B3D1-07DD-4555-B220-D80565F42913"),
            ExpectedQuantity = 1728m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("9ef9ded1-1748-4658-b201-2381a4b52e37"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("3B66B603-5535-44E6-82C6-320E73575328"),
            ItemUnitId = Guid.Parse("CCFACEFC-73AF-46C8-BF6B-EE93A5445A67"),
            ExpectedQuantity = 432m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("a5ebae5c-dc23-436a-a68b-77c9f93d2e03"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("E7CB3414-C0B4-4884-B9EA-A10E13C49337"),
            ItemUnitId = Guid.Parse("FC843637-9E15-43E2-A2C8-39AABA7CC9A1"),
            ExpectedQuantity = 2592m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("a85b210e-1dca-41b5-944f-34a0a1d29651"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("A276616B-F023-4D6F-87EA-DF5574BD4F9C"),
            ItemUnitId = Guid.Parse("A32B5522-B666-489A-8751-F36E35F329B6"),
            ExpectedQuantity = 1080m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("a957a879-7b32-4654-a4fb-ef6fa6ab8e58"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ProductId = Guid.Parse("B1E0AE2B-B271-4613-89D8-8575564A6944"),
            ItemUnitId = Guid.Parse("5ADCD688-797D-455F-86A1-599BB1680C7D"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("aa1821f7-d422-4b30-9745-67105a6a23ea"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("91276161-7358-4680-8FD6-A45FA83C3413"),
            ItemUnitId = Guid.Parse("9D8A6A00-D80D-4131-BB9E-DF10AFD44BCA"),
            ExpectedQuantity = 1296m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("abf80b24-b6aa-43fd-9b9a-17ba7ceb728e"),
            ReceiptId = Guid.Parse("9a9b98fa-80b9-4e94-93c6-aaa7bfb1262e"),
            ProductId = Guid.Parse("00D22996-340A-46CC-8D64-2C103CB59ACF"),
            ItemUnitId = Guid.Parse("4913E935-6ABC-48B6-AA09-C52919875B0C"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("ac891a79-75cf-40fb-9ee3-46495941cbb2"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("0CAE18A2-B990-4DB5-9EC2-54E081D3F378"),
            ItemUnitId = Guid.Parse("4FCA6E54-1479-4B32-91E2-3CA485B920EB"),
            ExpectedQuantity = 240m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("ad538429-0fe7-42e9-9403-88d7e5fc04dd"),
            ReceiptId = Guid.Parse("c0e64256-e82e-408f-8084-386d91381e5b"),
            ProductId = Guid.Parse("04610291-8C35-4655-BA9B-48198D0D6457"),
            ItemUnitId = Guid.Parse("DBA2FA1D-9E09-4647-AC2B-91D01F761394"),
            ExpectedQuantity = 2304m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("b21abf65-90ff-4dc8-aa53-93c54f5e7e82"),
            ReceiptId = Guid.Parse("9a9b98fa-80b9-4e94-93c6-aaa7bfb1262e"),
            ProductId = Guid.Parse("55EA8E5F-76F7-4F52-BBE8-2DF4D1D522E8"),
            ItemUnitId = Guid.Parse("8DAAC8E8-0784-4AE3-8CD5-AAE250A2D185"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("b69f496d-3a29-4314-aad3-e33b0e9c8d05"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("0F355ACB-83A6-459E-8E5B-8CEDF1BE204A"),
            ItemUnitId = Guid.Parse("AA7C8C4E-11D0-42DA-988D-FD9741E10BE5"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("b6d16842-f3e8-4c60-83a6-177aba2c9081"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("0C20D2A3-0ECB-497C-B963-D8AA4E88B2D8"),
            ItemUnitId = Guid.Parse("4B5E24AA-08CB-4F66-A738-57F0E648BF3C"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("b742f7ef-768a-41bf-9f78-67abfcd89186"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("93B43571-A79A-4FFE-9112-4C48B400A8A9"),
            ItemUnitId = Guid.Parse("146DF446-ED3B-435B-8E11-9D4E57EBC025"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("b756fe9b-57f3-4609-8e1d-ae2693a086d3"),
            ReceiptId = Guid.Parse("c0e64256-e82e-408f-8084-386d91381e5b"),
            ProductId = Guid.Parse("93B43571-A79A-4FFE-9112-4C48B400A8A9"),
            ItemUnitId = Guid.Parse("146DF446-ED3B-435B-8E11-9D4E57EBC025"),
            ExpectedQuantity = 2160m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("b8ce3e16-b005-4efa-87b0-37907657050b"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("E89EFE13-8CE5-45B1-BD6F-747695519A84"),
            ItemUnitId = Guid.Parse("51D5DD5C-C9F5-4730-9435-3D182C4C5D99"),
            ExpectedQuantity = 576m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("ba1a34f9-3d45-462c-b8d7-7786a291fbff"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ProductId = Guid.Parse("D091159E-92EE-4F55-AAA0-BC489A719E22"),
            ItemUnitId = Guid.Parse("816236DD-9BC4-4C3B-8FB2-08247E598803"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("bb55c7d4-7bea-4ca1-b2fa-8b82d54799cd"),
            ReceiptId = Guid.Parse("c0e64256-e82e-408f-8084-386d91381e5b"),
            ProductId = Guid.Parse("A33AAA45-B6D5-48B6-ACFC-37B79BA4BBC2"),
            ItemUnitId = Guid.Parse("B3A652D7-5CE5-42FD-A776-880294446DEA"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("bc780339-49a8-4ea4-bab1-d91439dd2680"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("A33AAA45-B6D5-48B6-ACFC-37B79BA4BBC2"),
            ItemUnitId = Guid.Parse("B3A652D7-5CE5-42FD-A776-880294446DEA"),
            ExpectedQuantity = 360m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("bdf3ac3a-dc45-4ec0-81ff-921a543e3648"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("9959BACC-1C42-4791-8854-2285E471D4B3"),
            ItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
            ExpectedQuantity = 2160m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("c56c1c95-188d-4d2d-9056-bfa0aa7be45c"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("1CD42C42-00E0-4C41-A7D4-61BC7F52644D"),
            ItemUnitId = Guid.Parse("51C982C4-BD4E-463C-9C89-4571C25EB294"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("c60ed205-e1d1-4eb6-b531-33b4d0b16a99"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("00D22996-340A-46CC-8D64-2C103CB59ACF"),
            ItemUnitId = Guid.Parse("4913E935-6ABC-48B6-AA09-C52919875B0C"),
            ExpectedQuantity = 480m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("cc10b138-4c8f-448a-bc06-9df1e89718fb"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ProductId = Guid.Parse("CC92C663-85C3-4BCA-8333-66B04380979B"),
            ItemUnitId = Guid.Parse("07076D2C-EFCE-4CB2-A31E-A3DBF7FE4A97"),
            ExpectedQuantity = 2592m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("cde3cfe2-f9cc-48d9-8951-cecbde788614"),
            ReceiptId = Guid.Parse("dad42b46-2e25-4262-8463-718722488bb0"),
            ProductId = Guid.Parse("42D23B7E-70C4-49A7-BB2A-6D27D2F727D6"),
            ItemUnitId = Guid.Parse("CFC16836-B3CD-401E-A148-CC6B1107AE01"),
            ExpectedQuantity = 864m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("d1790a4f-fa8d-421f-b649-9a1023b2d353"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
            ItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
            ExpectedQuantity = 1296m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("d227f901-e508-4884-af00-614e5a2a3c53"),
            ReceiptId = Guid.Parse("dad42b46-2e25-4262-8463-718722488bb0"),
            ProductId = Guid.Parse("CC92C663-85C3-4BCA-8333-66B04380979B"),
            ItemUnitId = Guid.Parse("07076D2C-EFCE-4CB2-A31E-A3DBF7FE4A97"),
            ExpectedQuantity = 1728m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("d2bb0b41-1a6a-4e09-aab7-1e38d5e231da"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
            ItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
            ExpectedQuantity = 864m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("d67c28b3-5ba1-4c7f-afaa-c13c6375d14f"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("0C916C7A-F3E0-4E0A-B9BA-F61D2816861D"),
            ItemUnitId = Guid.Parse("C6BE66B8-4BF9-4A31-BB53-333E483EB10B"),
            ExpectedQuantity = 480m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("d95a0a7c-9fa1-408f-89bc-b5d3a7695869"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("E0268B02-2174-40CB-8630-4911D407C52A"),
            ItemUnitId = Guid.Parse("56BFD555-E5DD-459A-B6DF-E8FE4442FF3B"),
            ExpectedQuantity = 960m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("dc858b83-dc42-4eff-b824-8ee7d05d1018"),
            ReceiptId = Guid.Parse("9a1b66f5-520b-40b6-b556-6c24f894f284"),
            ProductId = Guid.Parse("96F39E35-716A-4424-B45C-E3E9F9540034"),
            ItemUnitId = Guid.Parse("7563B910-54DD-402B-8E87-12B3A6CCF85C"),
            ExpectedQuantity = 1080m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("ddd20ead-c142-4c53-9648-90b5155b10aa"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ProductId = Guid.Parse("05F16EE5-B3E2-4EA7-B5BF-16ED86D84CCE"),
            ItemUnitId = Guid.Parse("EA168A90-F837-414A-B03E-793713AFAE9B"),
            ExpectedQuantity = 3456m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("de5a6a1c-c4a3-4130-80a8-a9bd10bbd1c2"),
            ReceiptId = Guid.Parse("9a1b66f5-520b-40b6-b556-6c24f894f284"),
            ProductId = Guid.Parse("0C916C7A-F3E0-4E0A-B9BA-F61D2816861D"),
            ItemUnitId = Guid.Parse("C6BE66B8-4BF9-4A31-BB53-333E483EB10B"),
            ExpectedQuantity = 480m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("dee5210c-bb9d-4740-8106-9a8ac2d35353"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ProductId = Guid.Parse("A33AAA45-B6D5-48B6-ACFC-37B79BA4BBC2"),
            ItemUnitId = Guid.Parse("B3A652D7-5CE5-42FD-A776-880294446DEA"),
            ExpectedQuantity = 360m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("e0395064-3257-4081-9e88-d87ddf4c387b"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ProductId = Guid.Parse("30943E74-2644-4848-B12A-B385EBE76F3E"),
            ItemUnitId = Guid.Parse("D96E008A-1476-43BF-B74B-C6CA9E90B64E"),
            ExpectedQuantity = 288m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("e2c6e822-9e67-4a27-a59e-c925de53eb9e"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("2C7AFEDF-7D80-4486-861A-9EA50DBEE9FC"),
            ItemUnitId = Guid.Parse("E8483812-85FF-49AC-835D-59A16DD9DC81"),
            ExpectedQuantity = 288m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("e4a48e74-6b3f-4752-8701-0d5d5b8344cd"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ProductId = Guid.Parse("42D23B7E-70C4-49A7-BB2A-6D27D2F727D6"),
            ItemUnitId = Guid.Parse("CFC16836-B3CD-401E-A148-CC6B1107AE01"),
            ExpectedQuantity = 576m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("e6cf7f19-314b-4d26-ae07-28176d30778e"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ProductId = Guid.Parse("ED170CD5-03F5-4872-8D09-7C562DEE0E1C"),
            ItemUnitId = Guid.Parse("00C9D6EA-C404-4EED-9B2B-EABEF1305DC1"),
            ExpectedQuantity = 864m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("e71f4bcf-a596-45f7-96d0-1635037d5cf9"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("259EEC3C-C5CA-4715-8D64-9423EF301586"),
            ItemUnitId = Guid.Parse("B4A48062-2BA7-49C2-AC33-E16665AB418F"),
            ExpectedQuantity = 240m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("ec064940-45fa-40f3-944d-ffcaced559b8"),
            ReceiptId = Guid.Parse("dad42b46-2e25-4262-8463-718722488bb0"),
            ProductId = Guid.Parse("1CD42C42-00E0-4C41-A7D4-61BC7F52644D"),
            ItemUnitId = Guid.Parse("51C982C4-BD4E-463C-9C89-4571C25EB294"),
            ExpectedQuantity = 360m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("f1c29ac4-a1a9-4523-bd7b-36d535157f01"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("5868A3DF-C076-4DAE-88ED-A763A8E2C2D9"),
            ItemUnitId = Guid.Parse("39DA5472-7CBF-45F4-B607-14F223F61BAD"),
            ExpectedQuantity = 1080m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("f24e946d-ee4d-4bf4-ae5e-9f2ea27c8622"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ProductId = Guid.Parse("70E20C31-085B-4BA1-97C6-76951BDE1A86"),
            ItemUnitId = Guid.Parse("FC33C8C9-02DC-47C3-8E08-5EDE6BC6DD46"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("f2d93541-01f3-4da4-ab9d-1ef9ab49a5f3"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ProductId = Guid.Parse("04202692-9052-4977-B297-683369796EE6"),
            ItemUnitId = Guid.Parse("BCD8966A-878A-4C12-9682-F8E27319C013"),
            ExpectedQuantity = 768m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("f3eeb179-f6ef-4829-81de-69d2768a4e2f"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("D091159E-92EE-4F55-AAA0-BC489A719E22"),
            ItemUnitId = Guid.Parse("816236DD-9BC4-4C3B-8FB2-08247E598803"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("f5d85401-a97d-4dae-ba7b-82c7cf0bd0ac"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ProductId = Guid.Parse("D11CD853-1D91-46AE-95B4-B6F9F183E5CB"),
            ItemUnitId = Guid.Parse("C360A841-3358-424F-8B97-2AD2D6D9D06C"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("f88203e6-25e3-4bf0-b2fe-e8651b0cc37f"),
            ReceiptId = Guid.Parse("c0e64256-e82e-408f-8084-386d91381e5b"),
            ProductId = Guid.Parse("E0268B02-2174-40CB-8630-4911D407C52A"),
            ItemUnitId = Guid.Parse("56BFD555-E5DD-459A-B6DF-E8FE4442FF3B"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("facd0fb1-9f54-4644-b11f-2e294181e35c"),
            ReceiptId = Guid.Parse("9a9b98fa-80b9-4e94-93c6-aaa7bfb1262e"),
            ProductId = Guid.Parse("E19B56EF-BC63-4376-A258-247B51C2AC3A"),
            ItemUnitId = Guid.Parse("DFC1CC60-B199-4D05-AB23-0ED7113AC974"),
            ExpectedQuantity = 240m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("fb0e86b6-4452-49d0-a199-ce4e5c8d29f4"),
            ReceiptId = Guid.Parse("fe6f7f97-5430-4bb8-b884-b54de4d30942"),
            ProductId = Guid.Parse("B1E0AE2B-B271-4613-89D8-8575564A6944"),
            ItemUnitId = Guid.Parse("5ADCD688-797D-455F-86A1-599BB1680C7D"),
            ExpectedQuantity = 1440m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("fc2abee4-d220-434f-91f8-0b401fbbb52a"),
            ReceiptId = Guid.Parse("fe6f7f97-5430-4bb8-b884-b54de4d30942"),
            ProductId = Guid.Parse("ED170CD5-03F5-4872-8D09-7C562DEE0E1C"),
            ItemUnitId = Guid.Parse("00C9D6EA-C404-4EED-9B2B-EABEF1305DC1"),
            ExpectedQuantity = 864m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("fc3bcdd5-3d4d-4bc7-91d5-0bc1c8959604"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ProductId = Guid.Parse("E7CB3414-C0B4-4884-B9EA-A10E13C49337"),
            ItemUnitId = Guid.Parse("FC843637-9E15-43E2-A2C8-39AABA7CC9A1"),
            ExpectedQuantity = 2592m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        
        new ReceiptItem
        {
            Id = Guid.Parse("fe6c15a8-920f-416b-8120-241189e273d8"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ProductId = Guid.Parse("AE325DB7-B0EA-4C72-9FCA-59B680C4209A"),
            ItemUnitId = Guid.Parse("B165AAFA-90A7-41FA-9508-1C56FCE5C1AF"),
            ExpectedQuantity = 720m,
            ActualQuantity = 0m,
            StatusId = 1,
            CreatedDate = DateTime.Now,
        }
        );
    }
}
