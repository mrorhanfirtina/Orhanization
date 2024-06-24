using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product
            {
                Id = Guid.Parse("00d22996-340a-46cc-8d64-2c103cb59acf"),
                Code = "508460486-1",
                AlternativeCode = "118-71-2748",
                Description = "Mitsubishi Trium Aria",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },

            new Product
            {
                Id = Guid.Parse("02369ce6-745f-471d-9862-976c6344927b"),
                Code = "795053360-9",
                AlternativeCode = "389-22-2719",
                Description = "BLU Studio 5.0 C",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("04202692-9052-4977-b297-683369796ee6"),
                Code = "538501783-3",
                AlternativeCode = "893-39-7211",
                Description = "Samsung A127",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("04610291-8c35-4655-ba9b-48198d0d6457"),
                Code = "583183599-5",
                AlternativeCode = "235-19-4747",
                Description = "ZTE Blade V Plus",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("05f16ee5-b3e2-4ea7-b5bf-16ed86d84cce"),
                Code = "355216161-9",
                AlternativeCode = "674-50-5454",
                Description = "LG G4 Dual",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("068e8333-8aa7-4ac2-a944-ff96434f6ac2"),
                Code = "105835276-8",
                AlternativeCode = "704-41-8691",
                Description = "Philips Genie 2000",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("08e07219-c245-436e-bd33-86b05e2c6a26"),
                Code = "103390201-2",
                AlternativeCode = "618-22-6065",
                Description = "alcatel Orange Klif",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("09187e90-5e30-43ab-bd28-fa869ebba906"),
                Code = "409089306-2",
                AlternativeCode = "200-14-9544",
                Description = "Nokia 6131 NFC",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("09b413e9-02b8-4fe7-9646-75b7acdf1fef"),
                Code = "591068785-9",
                AlternativeCode = "312-47-1679",
                Description = "Ulefone Armor 8",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("09f106a7-dffc-4868-97d4-9ee24b244b0c"),
                Code = "557669427-9",
                AlternativeCode = "205-89-2421",
                Description = "Nokia 6720 classic",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("0c20d2a3-0ecb-497c-b963-d8aa4e88b2d8"),
                Code = "722256865-4",
                AlternativeCode = "212-84-9372",
                Description = "Ulefone T2 Pro",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("0c916c7a-f3e0-4e0a-b9ba-f61d2816861d"),
                Code = "227940125-8",
                AlternativeCode = "557-85-7806",
                Description = "Siemens CX65",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("0cae18a2-b990-4db5-9ec2-54e081d3f378"),
                Code = "235547675-6",
                AlternativeCode = "884-66-8859",
                Description = "Nokia 6233",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("0e991364-5f84-4c85-ae72-f6e9404f1366"),
                Code = "588293804-X",
                AlternativeCode = "655-70-8526",
                Description = "Lenovo K8",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("0f355acb-83a6-459e-8e5b-8cedf1be204a"),
                Code = "496686364-3",
                AlternativeCode = "823-47-8802",
                Description = "Allview V1 Viper S4G",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("10d533b7-cc9e-4a60-b65d-109f90d86e7d"),
                Code = "186778222-7",
                AlternativeCode = "502-29-7914",
                Description = "Motorola XT390",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("1169946b-7c0c-48e4-88a7-a47f7bd5ffa8"),
                Code = "480152673-X",
                AlternativeCode = "726-72-0351",
                Description = "vivo iQOO Z1",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("1535c81d-e2e1-43f4-b7da-5f102896277d"),
                Code = "249240595-8",
                AlternativeCode = "507-50-1774",
                Description = "Sony Ericsson K770",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("1564475b-ebca-4bb3-8de1-328af49c0e1f"),
                Code = "439173663-2",
                AlternativeCode = "321-97-5771",
                Description = "Prestigio MultiPad 2 Pro Duo 8.0 3G",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("1681fbd9-a2c4-4ea0-b0c9-38439e239de9"),
                Code = "550835127-2",
                AlternativeCode = "115-45-2881",
                Description = "Motorola WX395",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("17497a0a-8f97-42e5-909c-aa52d0853a51"),
                Code = "993390757-3",
                AlternativeCode = "334-23-8710",
                Description = "BLU Dash 4.5 (2016)",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("1987a609-d7fc-4ef9-8175-04a08d371015"),
                Code = "497950735-2",
                AlternativeCode = "873-20-6068",
                Description = "Meizu 16s",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("1cd42c42-00e0-4c41-a7d4-61bc7f52644d"),
                Code = "173223393-4",
                AlternativeCode = "660-42-1890",
                Description = "Icemobile Comet II",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("1d0fbe6c-d3cc-4d0f-a20a-122a1ee25190"),
                Code = "271231442-5",
                AlternativeCode = "464-15-7813",
                Description = "Garmin-Asus nuvifone M10",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("259eec3c-c5ca-4715-8d64-9423ef301586"),
                Code = "544048375-6",
                AlternativeCode = "312-67-9187",
                Description = "ZTE Grand S II",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("27b22f2a-5d8b-40d2-9f6e-3fec92de9a71"),
                Code = "194022682-1",
                AlternativeCode = "340-30-5950",
                Description = "Siemens Xelibri 4",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("28622ba9-527f-43a3-bc64-241a40e319c0"),
                Code = "810285249-6",
                AlternativeCode = "605-64-2565",
                Description = "Cat S40",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("2c7afedf-7d80-4486-861a-9ea50dbee9fc"),
                Code = "735826430-4",
                AlternativeCode = "776-13-9214",
                Description = "Apple iPhone SE (2020)",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("30943e74-2644-4848-b12a-b385ebe76f3e"),
                Code = "625815137-X",
                AlternativeCode = "417-19-4821",
                Description = "Samsung Galaxy Tab S 8.4 LTE",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("368d3792-52ae-4cbf-a3e1-ffb70a867e0b"),
                Code = "044048927-X",
                AlternativeCode = "121-68-0046",
                Description = "alcatel OT-380",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("39a9c0d5-f8b3-43ab-8a05-4f94dce7aa10"),
                Code = "246463897-8",
                AlternativeCode = "789-42-3769",
                Description = "QMobile Noir Z10",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("3b66b603-5535-44e6-82c6-320e73575328"),
                Code = "961097951-3",
                AlternativeCode = "247-23-0672",
                Description = "Philips 530",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("3c75d6d9-d389-4b0e-9943-133d7c0529dc"),
                Code = "135946048-9",
                AlternativeCode = "108-61-7361",
                Description = "Samsung Galaxy C5",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("3d50a706-eaa4-46ca-93f4-b0f204022a9d"),
                Code = "649115144-1",
                AlternativeCode = "347-51-0404",
                Description = "Icemobile Sol",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("4007ca39-2aaa-45e2-bd6c-ecb16e0a69ce"),
                Code = "249602324-3",
                AlternativeCode = "807-67-4762",
                Description = "Micromax Q391 Canvas Doodle 4",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("40667126-379b-4bfc-a9f3-88f74c17ee8a"),
                Code = "530555860-3",
                AlternativeCode = "557-94-9376",
                Description = "alcatel OT-206",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("42d23b7e-70c4-49a7-bb2a-6d27d2f727d6"),
                Code = "963148274-X",
                AlternativeCode = "509-63-2679",
                Description = "Sony Xperia E1",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("47278db5-239b-43be-81ae-89af3aaf0443"),
                Code = "591519102-9",
                AlternativeCode = "214-11-6618",
                Description = "Oppo K1",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("4787896c-3176-4aa1-b59f-dc435bda8ead"),
                Code = "787318539-7",
                AlternativeCode = "687-81-5704",
                Description = "Gionee S6s",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("4b679760-1072-4a69-b0cd-b7f0b54e13a0"),
                Code = "309345062-4",
                AlternativeCode = "195-95-3686",
                Description = "BlackBerry DTEK60",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("4f64a707-de84-471a-bc9d-d3a890c59f55"),
                Code = "102487484-2",
                AlternativeCode = "769-75-9956",
                Description = "Allview V3 Viper",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("514ed67a-e441-4a5c-809c-423eb99ebbcc"),
                Code = "169598507-9",
                AlternativeCode = "165-01-7307",
                Description = "Nokia Lumia 720",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("55ea8e5f-76f7-4f52-bbe8-2df4d1d522e8"),
                Code = "500809141-7",
                AlternativeCode = "109-98-7615",
                Description = "Amoi E850",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("5868a3df-c076-4dae-88ed-a763a8e2c2d9"),
                Code = "740403096-X",
                AlternativeCode = "485-96-7989",
                Description = "QMobile Noir LT150",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("6028abf9-2149-4cd5-9b16-cecc80146029"),
                Code = "111017106-4",
                AlternativeCode = "849-02-3518",
                Description = "Samsung J750",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("6041bbc6-de60-455c-9556-ca9dbbc95740"),
                Code = "803123915-0",
                AlternativeCode = "363-17-8988",
                Description = "Samsung A117",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("65e8b711-3862-4588-8317-1e182beb9655"),
                Code = "828952497-8",
                AlternativeCode = "551-31-7885",
                Description = "BenQ S660C",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("6bb36a77-5e53-4681-95e0-b693453f1e19"),
                Code = "017978988-0",
                AlternativeCode = "335-72-7213",
                Description = "alcatel Pixi 4 (6) 3G",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("70e20c31-085b-4ba1-97c6-76951bde1a86"),
                Code = "647403456-4",
                AlternativeCode = "782-26-9254",
                Description = "Motorola KRZR K1",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("71de705a-489c-480a-9a03-8e112b787307"),
                Code = "986915709-2",
                AlternativeCode = "134-37-7214",
                Description = "T-Mobile MDA Compact V",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("73a2eb51-7bf1-46ea-aeaa-08e771328bdd"),
                Code = "507046312-8",
                AlternativeCode = "202-61-1879",
                Description = "Samsung Breeze B209",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("75ec2da5-cfc2-4577-b640-aa37870330b4"),
                Code = "816805399-0",
                AlternativeCode = "200-33-1267",
                Description = "OnePlus 6T McLaren",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("774490da-ccc9-4754-acea-5e6754be7fdd"),
                Code = "437413445-X",
                AlternativeCode = "750-25-6867",
                Description = "XOLO Q1200",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("7b6b14e1-8014-4755-a20a-69ddad87a1b3"),
                Code = "240712740-4",
                AlternativeCode = "514-35-9177",
                Description = "Dell Venue 8",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("836fa41a-aeb7-4c7c-9ce3-5bd1a99a1b46"),
                Code = "125747526-6",
                AlternativeCode = "209-66-8281",
                Description = "Plum Compass",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("84974822-b09e-4ae5-a793-ae8d52091647"),
                Code = "518964130-9",
                AlternativeCode = "309-92-3155",
                Description = "BLU Life One",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("87538842-18e0-41e5-ad77-9e3e7f998c40"),
                Code = "412625753-5",
                AlternativeCode = "859-61-5098",
                Description = "Samsung U450 Intensity",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("91276161-7358-4680-8fd6-a45fa83c3413"),
                Code = "182124138-X",
                AlternativeCode = "240-22-5104",
                Description = "Lenovo Vibe X3 c78",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("91ebebfa-b2cb-4856-8292-5eb2333d4b82"),
                Code = "541545738-0",
                AlternativeCode = "115-10-5179",
                Description = "Samsung L810v Steel",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("93b43571-a79a-4ffe-9112-4c48b400a8a9"),
                Code = "988495687-1",
                AlternativeCode = "504-87-8161",
                Description = "Nokia 2.3",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("96f39e35-716a-4424-b45c-e3e9f9540034"),
                Code = "083001770-4",
                AlternativeCode = "821-21-1646",
                Description = "Samsung B320",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("9959bacc-1c42-4791-8854-2285e471d4b3"),
                Code = "757299469-5",
                AlternativeCode = "858-56-6665",
                Description = "T-Mobile Vairy Touch",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("a276616b-f023-4d6f-87ea-df5574bd4f9c"),
                Code = "323094499-2",
                AlternativeCode = "816-81-7212",
                Description = "Samsung Galaxy S20 Ultra",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("a33aaa45-b6d5-48b6-acfc-37b79ba4bbc2"),
                Code = "887253565-4",
                AlternativeCode = "551-05-0167",
                Description = "ZTE Zmax",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("aafdbacd-4121-476b-aef6-84db6462be82"),
                Code = "112315283-7",
                AlternativeCode = "603-12-5769",
                Description = "Nokia 7210",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("ab8b3752-727d-4fce-a139-d3e7f1e9664a"),
                Code = "269584774-2",
                AlternativeCode = "720-28-5807",
                Description = "Wiko Rainbow Jam 4G",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("ae325db7-b0ea-4c72-9fca-59b680c4209a"),
                Code = "371806087-6",
                AlternativeCode = "702-17-0792",
                Description = "Vodafone 858 Smart",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("b1e0ae2b-b271-4613-89d8-8575564a6944"),
                Code = "734988573-3",
                AlternativeCode = "648-97-8920",
                Description = "Ulefone Armor X8",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("b40836d7-6a05-4d61-b2f2-b8344d6996f3"),
                Code = "080563524-6",
                AlternativeCode = "142-37-3671",
                Description = "Panasonic T41",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("b6353454-059e-409d-85e4-b273f1d9a032"),
                Code = "023532891-X",
                AlternativeCode = "493-26-4204",
                Description = "Apple iPad mini 3",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("b910cbe5-f014-4e8d-92a0-9199c2206d7a"),
                Code = "620881670-X",
                AlternativeCode = "734-95-1275",
                Description = "Apple iPhone 12 Pro Max",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("ba3f09bd-a0e1-4026-9f8e-48fa01b1e97e"),
                Code = "484968568-4",
                AlternativeCode = "442-21-1916",
                Description = "Huawei Premia 4G M931",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("ba6fee82-e105-4a56-9365-a497c570a174"),
                Code = "984197047-3",
                AlternativeCode = "788-68-3066",
                Description = "Nokia 6.1",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("c1e9c300-dfb2-4d59-b24b-d325e73eed61"),
                Code = "837725130-2",
                AlternativeCode = "633-51-3003",
                Description = "Sony Xperia M2",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("c493bb30-902f-4f54-830f-a3d6b1683a2b"),
                Code = "660648581-9",
                AlternativeCode = "847-35-1441",
                Description = "Motorola MOTO MT716",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("c567f6f5-0d4a-4b9f-a537-9ef9bf4fb92d"),
                Code = "615508890-X",
                AlternativeCode = "247-56-8944",
                Description = "Micromax Infinity N11",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("cac2533d-31b1-402d-b093-b7152f88f7cf"),
                Code = "866502918-4",
                AlternativeCode = "531-36-6879",
                Description = "Allview P9 Energy Lite (2017)",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("cc92c663-85c3-4bca-8333-66b04380979b"),
                Code = "917762246-4",
                AlternativeCode = "533-59-2705",
                Description = "alcatel OT-V770",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("d07ec644-37f0-416b-9323-aa25d1a819b4"),
                Code = "818502736-6",
                AlternativeCode = "417-94-3630",
                Description = "NIU GO 80",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("d091159e-92ee-4f55-aaa0-bc489a719e22"),
                Code = "868262882-1",
                AlternativeCode = "795-31-0956",
                Description = "LG A100",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("d11cd853-1d91-46ae-95b4-b6f9f183e5cb"),
                Code = "697483393-8",
                AlternativeCode = "241-42-7307",
                Description = "Motorola V975",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("d46e2e23-5391-403d-9602-8caa1e769131"),
                Code = "627333637-7",
                AlternativeCode = "213-62-4277",
                Description = "Micromax Canvas Selfie 2 Q340",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("d9a78239-fff7-48c1-8538-c762c6e5c53e"),
                Code = "224441989-4",
                AlternativeCode = "715-72-8148",
                Description = "Micromax X225",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("da0cf148-968c-40ce-8d00-70a13d8642cc"),
                Code = "908264384-7",
                AlternativeCode = "468-57-4402",
                Description = "Amazon Fire HDX 8.9 (2014)",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("dd0805d2-84a1-4fa1-89b0-2bf012924ec8"),
                Code = "259697118-6",
                AlternativeCode = "871-01-5121",
                Description = "ZTE Blade",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("e0268b02-2174-40cb-8630-4911d407c52a"),
                Code = "478571939-7",
                AlternativeCode = "459-16-5922",
                Description = "Lenovo Tab S8",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("e19b56ef-bc63-4376-a258-247b51c2ac3a"),
                Code = "237971629-3",
                AlternativeCode = "671-09-2276",
                Description = "Xiaomi Redmi Note 3",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("e49efdea-46e2-4e3e-9e1d-cb8f2bd81ceb"),
                Code = "031684927-8",
                AlternativeCode = "801-06-4138",
                Description = "Nokia N82",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("e5005446-b5ed-4ad0-a835-c709636b15f8"),
                Code = "874356486-0",
                AlternativeCode = "726-14-4446",
                Description = "Samsung Galaxy A20",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("e7cb3414-c0b4-4884-b9ea-a10e13c49337"),
                Code = "946537191-2",
                AlternativeCode = "145-63-5883",
                Description = "Yezz Billy 5S LTE",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("e89efe13-8ce5-45b1-bd6f-747695519a84"),
                Code = "532342440-0",
                AlternativeCode = "644-11-6752",
                Description = "LG L1100",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("ed170cd5-03f5-4872-8d09-7c562dee0e1c"),
                Code = "340853211-7",
                AlternativeCode = "441-09-6903",
                Description = "vivo Y35",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("f1e438f5-778d-42f8-a81e-0f0b3d97efb4"),
                Code = "092403220-0",
                AlternativeCode = "605-24-2727",
                Description = "Micromax Canvas 6",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("f20c1167-4751-46f0-9a33-ac3d8d00a991"),
                Code = "851432596-5",
                AlternativeCode = "217-42-5704",
                Description = "Micromax A115 Canvas 3D",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("f253ef01-2818-42e7-ae46-66abc537e5c0"),
                Code = "099188871-5",
                AlternativeCode = "433-51-8352",
                Description = "Qtek 8080",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("f2e01cb2-9795-4c0e-9226-a3e3363bcf3f"),
                Code = "802177585-8",
                AlternativeCode = "239-03-8721",
                Description = "BLU J6",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("f7439c76-4855-465f-832f-d2b3a845a25d"),
                Code = "453327642-3",
                AlternativeCode = "655-20-1174",
                Description = "Samsung R200",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("f7d4db5b-c00f-4d8c-b9f8-ab85f5d04d0f"),
                Code = "915915661-9",
                AlternativeCode = "403-52-2916",
                Description = "Lenovo K10 Note",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("f8d487bd-a119-4e92-b443-1358b58c995f"),
                Code = "388600328-0",
                AlternativeCode = "135-48-0255",
                Description = "Celkon C567",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            },
            
            new Product
            {
                Id = Guid.Parse("fbf09c48-c1d5-4a16-bdaf-3e5535d983af"),
                Code = "480564489-3",
                AlternativeCode = "798-54-9525",
                Description = "Spice M-5115",
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            }



        );
    }
}
