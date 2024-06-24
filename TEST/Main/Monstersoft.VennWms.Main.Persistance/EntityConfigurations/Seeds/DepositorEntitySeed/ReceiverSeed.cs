using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.DepositorEntitySeed;

public class ReceiverSeed : IEntityTypeConfiguration<Receiver>
{
    public void Configure(EntityTypeBuilder<Receiver> builder)
    {
        builder.HasData(
            new Receiver
            {
                Id = Guid.Parse("001230ff-2e3d-4050-b6a6-477ec6c3bb10"),
                Code = "14084",
                Name = "Randolf Francesconi",
                CustomerId = Guid.Parse("49b8870f-cabb-46a5-95ac-b50552260db6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("77353a89-62ce-49b1-9a2c-9f187a3b3093")
            },

            new Receiver
            {
                Id = Guid.Parse("009eaf44-da2e-4e0a-87c5-acabe6524770"),
                Code = "34571",
                Name = "Candace Trelevan",
                CustomerId = Guid.Parse("8c760b1e-4834-4fc5-8ab6-767621a799b6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("3073c063-2e5e-4648-8354-fde2a04b026c")
            },

            new Receiver
            {
                Id = Guid.Parse("02538740-d641-4b92-bd29-13e4d6615aed"),
                Code = "26506",
                Name = "Kaleb Adamski",
                CustomerId = Guid.Parse("d58d12f7-5e64-424d-ad62-6fd0ff60ebbc"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("8ac8cde7-58e3-43c1-803a-57a86f981bc3")
            },

            new Receiver
            {
                Id = Guid.Parse("042b0f20-0f13-48c1-913d-d9c49aa116fc"),
                Code = "24541",
                Name = "Alic Earwaker",
                CustomerId = Guid.Parse("e6e72b41-fb7d-48a1-b11b-8cd316a43c51"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("eb91cdbe-34ab-4dfd-bdcc-2dcc1bc4f37b")
            },

            new Receiver
            {
                Id = Guid.Parse("0462b59b-f674-428a-a1d9-1220ba63fe0e"),
                Code = "20629",
                Name = "Wallie Sheddan",
                CustomerId = Guid.Parse("1e36ca18-687b-49a6-9e76-1632136ecd1b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("79bd7524-5917-4b16-93b9-d8e84dc4475f")
            },

            new Receiver
            {
                Id = Guid.Parse("048905c6-b41c-46d8-8484-ae95ef423e45"),
                Code = "24914",
                Name = "Pearline Truin",
                CustomerId = Guid.Parse("308733d1-b6f1-433a-9897-33c0b8df51d7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5f72b61e-55c6-46e0-81a2-7f86f0686649")
            },

            new Receiver
            {
                Id = Guid.Parse("06675fdb-c344-4106-be16-7c827682c46c"),
                Code = "18222",
                Name = "Kahlil Josskoviz",
                CustomerId = Guid.Parse("13f2f8e0-f20e-4b1d-bc24-60dbc82d60d6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("44193b9e-2e5b-4908-8466-bc6ac7cde10a")
            },

            new Receiver
            {
                Id = Guid.Parse("06bf7cb4-5fc5-4fe3-a58c-d636957afb9d"),
                Code = "29880",
                Name = "Faulkner Tilliard",
                CustomerId = Guid.Parse("059af8fc-a739-4de9-a375-b4ab609baa03"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("39c2b54f-5f57-482a-b1f3-58e5ea4d72a1")
            },

            new Receiver
            {
                Id = Guid.Parse("072bc30a-a41c-49c7-a568-ad2e6367c695"),
                Code = "35424",
                Name = "Toddie Pinnigar",
                CustomerId = Guid.Parse("e6e72b41-fb7d-48a1-b11b-8cd316a43c51"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("479668ab-709e-4ae0-9514-407c7c74882a")
            },

            new Receiver
            {
                Id = Guid.Parse("08278fc7-d7c7-4861-8b5b-bcee41a6d425"),
                Code = "21841",
                Name = "Addy Tomaini",
                CustomerId = Guid.Parse("1d4d1808-f8dc-42ed-8107-592beb55c4ea"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("aa4c8f28-849e-4684-b96f-e5b3b6620f66")
            },

            new Receiver
            {
                Id = Guid.Parse("08644063-cce2-4041-9959-cbef198f8bb5"),
                Code = "19892",
                Name = "Dalia Breward",
                CustomerId = Guid.Parse("3bb9cd5d-39ed-4294-b674-44141f3bafef"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("059ad44e-afb8-4a16-b7ba-2176fc83c8f2")
            },

            new Receiver
            {
                Id = Guid.Parse("087dfb07-6978-4777-a242-8bbf97f0536a"),
                Code = "31829",
                Name = "Dixie Bigham",
                CustomerId = Guid.Parse("ae9a67c6-6908-490c-b777-a9e2c03781af"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5f3c26b8-6f30-4825-aadc-8719234b987a")
            },

            new Receiver
            {
                Id = Guid.Parse("08c2cec0-c79c-41de-801d-9d86f834a271"),
                Code = "30650",
                Name = "Boyce Blakiston",
                CustomerId = Guid.Parse("55820f2f-28ea-41d5-b978-47c630bc045f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("baff58c7-26b4-4ebd-993f-bde7913c7eb9")
            },

            new Receiver
            {
                Id = Guid.Parse("0a4ca4a0-5a35-4360-b285-1e99aa621335"),
                Code = "12449",
                Name = "Arman Dignan",
                CustomerId = Guid.Parse("059af8fc-a739-4de9-a375-b4ab609baa03"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("3a155d93-39c1-4d3f-8605-f461d9d6dab0")
            },

            new Receiver
            {
                Id = Guid.Parse("0b1d3715-1075-47f7-aacb-4c08f4385279"),
                Code = "36748",
                Name = "Lenore Haggerstone",
                CustomerId = Guid.Parse("225085b3-a668-4c78-85c7-5653ce668fc0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("b4534614-3fbb-445d-97e5-d16ee7d3ab98")
            },

            new Receiver
            {
                Id = Guid.Parse("0da18aa4-9e9d-42fe-b9ec-638acc348578"),
                Code = "12102",
                Name = "Honor Heigold",
                CustomerId = Guid.Parse("fa579f31-2357-4b1c-9eff-6248bb88217a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("39b0e46e-e58f-40f9-a39e-7bba98f0b63b")
            },

            new Receiver
            {
                Id = Guid.Parse("1235e6aa-333e-4874-9f93-c3488b8c12f5"),
                Code = "35298",
                Name = "Estele Witherdon",
                CustomerId = Guid.Parse("bdfdb0ea-9991-4ed7-a174-7a359f21438c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("b970a89a-aad0-402d-9c45-d6d7bd4bf1ac")
            },

            new Receiver
            {
                Id = Guid.Parse("14e5655a-6772-46e0-a2b9-fe757d09b880"),
                Code = "13847",
                Name = "Currie Rearie",
                CustomerId = Guid.Parse("49b8870f-cabb-46a5-95ac-b50552260db6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("864f0c8b-33e9-4b18-ad1a-48d95016e1c4")
            },

            new Receiver
            {
                Id = Guid.Parse("1578b7ec-3aa7-4208-9e39-e0403d8a5a0c"),
                Code = "33913",
                Name = "Isabelita Slowgrove",
                CustomerId = Guid.Parse("3d96e6b6-9528-4fbf-a099-7871a4efffd4"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("d83acb07-507f-46b9-9a7b-dad73c810b19")
            },

            new Receiver
            {
                Id = Guid.Parse("1753c2ec-9c72-4fbb-a744-7b74cfedb5a1"),
                Code = "21275",
                Name = "Mommy Cecil",
                CustomerId = Guid.Parse("7d025447-65b1-42ac-bc7e-2eb3296e1b46"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("25130799-eb2a-4fc1-874a-4bb514f7fa1f")
            },

            new Receiver
            {
                Id = Guid.Parse("176db1b5-4e18-4f52-ab42-ed1449a8f662"),
                Code = "37531",
                Name = "Goddart Sowood",
                CustomerId = Guid.Parse("4015c417-b3ad-4431-ad37-0f692495ac2c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("d0f9c0e3-b1ad-4020-8912-e7233675e8e6")
            },

            new Receiver
            {
                Id = Guid.Parse("19ad3020-3852-49b0-888b-0f53cdd6bcdd"),
                Code = "19363",
                Name = "Cathie Jahnig",
                CustomerId = Guid.Parse("07798ff4-c448-4701-8375-8aeff6b0e06c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2875143e-a928-4d5a-b583-cd735a15b9c1")
            },

            new Receiver
            {
                Id = Guid.Parse("19c9ab2c-c478-4842-b9c8-8a1612f3a38c"),
                Code = "28647",
                Name = "Byran Mannooch",
                CustomerId = Guid.Parse("90ed16c5-179b-4213-94c6-945b84ee15dc"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("356c87ce-92cc-4a05-95ab-5db7af6596e8")
            },

            new Receiver
            {
                Id = Guid.Parse("1a980e63-56e5-4dcd-b9f9-7f1bef7e7df0"),
                Code = "24360",
                Name = "Alistair Tibbits",
                CustomerId = Guid.Parse("e8964b4d-c59e-4a55-a958-fc43955a289d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("7c842399-b958-42ab-97df-78a24aeaff7e")
            },

            new Receiver
            {
                Id = Guid.Parse("1e0b9bd4-4d73-450a-97a9-9294b8fa383c"),
                Code = "20028",
                Name = "Juan Dumberell",
                CustomerId = Guid.Parse("59066941-930d-4916-99e6-edeb59e31117"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("b77062cd-0b6f-4f78-823a-06fec1cf030c")
            },

            new Receiver
            {
                Id = Guid.Parse("1ed817dc-758e-4e2f-8947-fc3c46852873"),
                Code = "37194",
                Name = "Arabela Torregiani",
                CustomerId = Guid.Parse("d0af86a4-5472-461c-b6a1-17067bd8c0d2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("d70ebdfa-e4ed-4a97-827c-c5c49a1d16c9")
            },

            new Receiver
            {
                Id = Guid.Parse("1f4b5335-8eb3-4cc9-80c6-5f822718d79a"),
                Code = "32008",
                Name = "Sofia Rosensaft",
                CustomerId = Guid.Parse("cfa000cc-7914-4c56-83b3-03750858f9a8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("4e51c05c-06bf-4fc8-bb58-9eed7981f88c")
            },

            new Receiver
            {
                Id = Guid.Parse("1f7f8280-66ff-4860-9fbf-daaecc01d83a"),
                Code = "16098",
                Name = "Cecilla Jurgensen",
                CustomerId = Guid.Parse("db0937ae-73b4-4083-9b34-44c2db59bd12"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("fde272d9-3821-4297-a876-832fab0fc149")
            },

            new Receiver
            {
                Id = Guid.Parse("1f9249ea-4433-4005-bccb-a2455ff8382c"),
                Code = "31513",
                Name = "Marleah Sauven",
                CustomerId = Guid.Parse("bc6dac41-b19e-4742-a9a8-aef33933a349"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("7f986e69-b96d-4dfc-aab8-c48419ffec0b")
            },

            new Receiver
            {
                Id = Guid.Parse("206cb9ba-592a-4797-8e0c-879f7078e780"),
                Code = "16492",
                Name = "Johnathan Terzo",
                CustomerId = Guid.Parse("e963e674-af77-4991-b10a-4d33c3b48a78"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("80492754-a5e1-4cef-ba75-4149eb6422a2")
            },

            new Receiver
            {
                Id = Guid.Parse("208a13a8-af31-4db0-a427-8d2bbb02b5f3"),
                Code = "31629",
                Name = "Hillyer Draco",
                CustomerId = Guid.Parse("8514324c-dd15-4d06-8998-ee60c9971164"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("63021fd7-2443-4869-8609-8c7c2c5215c1")
            },

            new Receiver
            {
                Id = Guid.Parse("20c0449a-e124-457b-a2b8-052eaf24c04b"),
                Code = "23261",
                Name = "Gaile Garnsey",
                CustomerId = Guid.Parse("8cb8d455-ff46-420c-a5f3-8d45586e3b78"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("67928c39-1eb1-47c7-ba23-fe44803e5e3e")
            },

            new Receiver
            {
                Id = Guid.Parse("223e20d9-527e-4925-9ed5-6eb11e6c96f3"),
                Code = "13312",
                Name = "Helen-elizabeth Hampshaw",
                CustomerId = Guid.Parse("f70b159f-0469-4887-8abf-ffce8c645616"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("b5850106-3f73-4acd-82ae-4a08eb6173cb")
            },

            new Receiver
            {
                Id = Guid.Parse("22bd54e0-3391-47af-8ca8-e8bd5870f8a8"),
                Code = "18595",
                Name = "Kareem Cahn",
                CustomerId = Guid.Parse("3db5de6b-423d-44c1-872c-e493dfba8ea0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("1a28eec4-809c-46c8-b66a-7f6d8efd1645")
            },

            new Receiver
            {
                Id = Guid.Parse("249051e1-aa29-4402-8ab9-1a4b24d2ccd0"),
                Code = "15312",
                Name = "Beaufort Bumphries",
                CustomerId = Guid.Parse("db7c0d56-72f0-43be-93f0-0fd8d123c081"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("3a2300f2-d261-4f8a-bada-292fb9c89b68")
            },

            new Receiver
            {
                Id = Guid.Parse("27522d10-8e1e-4f86-94b9-902c112e9f97"),
                Code = "13397",
                Name = "Kelcey MacVay",
                CustomerId = Guid.Parse("d84aa82d-fd2b-452a-a9fd-c5928fae0829"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("ce25cbe4-e8d9-46b1-b30c-9f82cdc1d83b")
            },

            new Receiver
            {
                Id = Guid.Parse("288f5ada-c5c5-41f2-9590-e3aca7514c13"),
                Code = "37164",
                Name = "Cosimo Leguay",
                CustomerId = Guid.Parse("e78b1196-21ec-47b3-a82c-9a1854c4ba2c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("c546354e-53da-4325-842c-d7578bbcd050")
            },

            new Receiver
            {
                Id = Guid.Parse("2986ce55-40fc-41c5-b6ce-9e46aa6633a5"),
                Code = "15955",
                Name = "Orazio Rulton",
                CustomerId = Guid.Parse("bdfdb0ea-9991-4ed7-a174-7a359f21438c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("1d8921e8-66df-4d4a-accf-96be57a51435")
            },

            new Receiver
            {
                Id = Guid.Parse("2a3ae156-db06-417c-9d2a-d1c991b6bba3"),
                Code = "15078",
                Name = "Calla Ablitt",
                CustomerId = Guid.Parse("5dc8f138-d4db-4514-a2d9-9b8581720970"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("53b3d189-b837-473e-8d43-affba7e863a3")
            },

            new Receiver
            {
                Id = Guid.Parse("2ade6e08-166c-4215-920b-32834627d346"),
                Code = "21857",
                Name = "Theadora Alessandrini",
                CustomerId = Guid.Parse("bc23c63d-be8c-4960-a6dc-f5164c9e0a0b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("3970e6ee-1756-41a7-839b-db34376b5dff")
            },

            new Receiver
            {
                Id = Guid.Parse("2b22dd36-9ad6-44f9-9e81-5a0b57244b0f"),
                Code = "29774",
                Name = "Travis Nitti",
                CustomerId = Guid.Parse("f6603a4e-ae80-45e4-984e-c80f64420f3c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("e30663b8-3e0c-41bd-a03b-e006cae48273")
            },

            new Receiver
            {
                Id = Guid.Parse("2ecbb3d6-e731-4ecc-824e-122f9bf9d40a"),
                Code = "16712",
                Name = "Reggi Gleadhall",
                CustomerId = Guid.Parse("c6aff869-d2ea-420f-b381-1cc66820fa5c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("c5db34c2-ed40-4702-9ea4-b19e1a058f1e")
            },

            new Receiver
            {
                Id = Guid.Parse("2f6c6a17-40c0-4962-bcbb-93767f8fcde0"),
                Code = "12855",
                Name = "Betti Claessens",
                CustomerId = Guid.Parse("d6b3a066-520a-43ff-983c-4e4cd579c9e9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("6f15928b-16c9-482e-9722-f31db7faa039")
            },

            new Receiver
            {
                Id = Guid.Parse("30b5c363-7214-4b18-adf5-695b7292fe94"),
                Code = "17493",
                Name = "Karin Gerriets",
                CustomerId = Guid.Parse("b245d236-015c-4050-aaa4-c586da91f72a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("a3979dc7-669f-49da-a2c4-e159a33021e5")
            },

            new Receiver
            {
                Id = Guid.Parse("316d7104-7ea2-4fd7-8d4e-df0d175df888"),
                Code = "24924",
                Name = "Estelle Killshaw",
                CustomerId = Guid.Parse("6ccca5e5-27e2-4f03-be82-29a27dbe7f05"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("73f3d9d5-3c42-4c73-9c34-24a242b621b6")
            },

            new Receiver
            {
                Id = Guid.Parse("32714dbf-f963-429f-8bd9-b00f6b753678"),
                Code = "28473",
                Name = "Welbie Costi",
                CustomerId = Guid.Parse("e72c9a27-6ac1-47f4-a66a-d65e9e0d46d1"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2635f54a-74c5-4b3a-b25d-daa65a13abec")
            },

            new Receiver
            {
                Id = Guid.Parse("3356c131-159e-4079-8825-4903ca9cb73a"),
                Code = "30764",
                Name = "Edwin Skain",
                CustomerId = Guid.Parse("a269ada2-6ddc-4acd-9c27-ec9b9e742fcb"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("d7925ae5-2801-4778-9e8a-c9326ee53ca2")
            },

            new Receiver
            {
                Id = Guid.Parse("336e32e2-d628-4e24-8369-a14b69198818"),
                Code = "13971",
                Name = "Boonie Esch",
                CustomerId = Guid.Parse("c36607cf-976c-4a2e-a09c-67c18af70d72"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("3add312b-094f-479c-94a7-a465622b9eca")
            },

            new Receiver
            {
                Id = Guid.Parse("34ad003a-0000-4500-bfbd-c1723a5eba9e"),
                Code = "26853",
                Name = "Burk MacAlaster",
                CustomerId = Guid.Parse("3283ee28-6a2a-468e-b813-55a330bc39a4"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5a105afd-2bea-4ead-a9a8-0930412dcc5a")
            },

            new Receiver
            {
                Id = Guid.Parse("35f7a194-4a5d-47a3-a75b-55839aea2df8"),
                Code = "28331",
                Name = "Brennen Stovine",
                CustomerId = Guid.Parse("9947af67-db7d-4626-b91c-5b0ba6de9be9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("8b891893-4325-44ad-bcd8-75f28673c80a")
            },

            new Receiver
            {
                Id = Guid.Parse("38704cd9-b14a-4134-8e61-af16d7bc9099"),
                Code = "21052",
                Name = "Billy Mennell",
                CustomerId = Guid.Parse("9536c8eb-8485-449c-b966-36f2b05921a3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("ec572ecd-e561-417b-bbeb-4264b3e5f9d7")
            },

            new Receiver
            {
                Id = Guid.Parse("392a6c36-a091-4dc3-a07f-f12b58109fac"),
                Code = "14344",
                Name = "Franciskus Perez",
                CustomerId = Guid.Parse("59066941-930d-4916-99e6-edeb59e31117"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("443b1ac8-1618-4667-b7a7-bca06be7df7c")
            },

            new Receiver
            {
                Id = Guid.Parse("3c43296d-bac7-4cc4-b2e0-a1884a4fab98"),
                Code = "20437",
                Name = "Niven McGloughlin",
                CustomerId = Guid.Parse("66672f51-767f-48af-be15-65abbeb9a9fd"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("33ed845f-4bbd-407b-a211-b13a621255a2")
            },

            new Receiver
            {
                Id = Guid.Parse("3c578a6d-a995-467c-b454-b013296574e1"),
                Code = "36656",
                Name = "Liana Janiszewski",
                CustomerId = Guid.Parse("3d96e6b6-9528-4fbf-a099-7871a4efffd4"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("0c6417b5-c72a-44e5-8212-bb63793eef13")
            },

            new Receiver
            {
                Id = Guid.Parse("3e0f9207-f01a-4a94-8083-a6b5b5429df5"),
                Code = "16321",
                Name = "Skelly Donaghie",
                CustomerId = Guid.Parse("dbad4020-7ad7-4d55-b4a9-a29a378c9414"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("25fc9069-eeef-436d-946d-6038c4c51056")
            },

            new Receiver
            {
                Id = Guid.Parse("3efaa48e-a64f-4849-95ef-8b79bdd7f7c5"),
                Code = "24579",
                Name = "Charline Powrie",
                CustomerId = Guid.Parse("90ed16c5-179b-4213-94c6-945b84ee15dc"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2365666d-a4e0-43b8-bc35-ccb58dc2b994")
            },

            new Receiver
            {
                Id = Guid.Parse("3f398d7b-b9e7-468d-8167-dd03be9c0938"),
                Code = "34702",
                Name = "Robinson Stockau",
                CustomerId = Guid.Parse("f45d434b-9376-48eb-a77b-f873d7f23d2e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("a9871d46-3469-40d4-a4b2-0827b0fc8429")
            },

            new Receiver
            {
                Id = Guid.Parse("41e38754-cb2a-4a12-b829-2154cded4116"),
                Code = "21553",
                Name = "Donnie Reavell",
                CustomerId = Guid.Parse("8347ef80-c2d1-4d8d-ad09-a008fc1bb184"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("45c71c07-f6e6-4d98-ae83-37cc40ff375b")
            },

            new Receiver
            {
                Id = Guid.Parse("428ac83b-4f7e-4592-8180-250a27fd7d88"),
                Code = "30039",
                Name = "Gabriell Stearndale",
                CustomerId = Guid.Parse("f70b159f-0469-4887-8abf-ffce8c645616"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("1d9d4a05-90d2-4a48-85cb-19d635ae9df2")
            },

            new Receiver
            {
                Id = Guid.Parse("431de8c0-ed14-4903-8485-5217d7e4ec98"),
                Code = "31591",
                Name = "Kimberlee Lilian",
                CustomerId = Guid.Parse("14f2d70d-1880-4de5-8e80-65a4233e5bd0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("45824f7b-76aa-43df-bee1-8479e998ede1")
            },

            new Receiver
            {
                Id = Guid.Parse("453f2711-b6ea-4e8b-bef7-b4a59239125d"),
                Code = "28689",
                Name = "Waldemar Marven",
                CustomerId = Guid.Parse("8a1222e2-ec4f-4a61-b8bb-178b81209b97"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5db517e1-e7c1-4561-b7d9-b697d2b0e948")
            },

            new Receiver
            {
                Id = Guid.Parse("45de0cad-0190-4218-9566-abab6486285b"),
                Code = "17867",
                Name = "Katleen Oxe",
                CustomerId = Guid.Parse("db7c0d56-72f0-43be-93f0-0fd8d123c081"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("26dab0ea-03bc-4f7e-98c7-3f36799e94f7")
            },

            new Receiver
            {
                Id = Guid.Parse("46938af6-5bbc-44f5-a77e-5f1a7dff57a5"),
                Code = "33886",
                Name = "Vonnie Rowbrey",
                CustomerId = Guid.Parse("3943f9fe-f31b-4e0d-aab0-c4355a83d28b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("b6554b94-0959-4a16-9f63-4463e98bbf9f")
            },

            new Receiver
            {
                Id = Guid.Parse("4b4e9a6d-bf23-4e15-9155-a3b7e3dcc3a6"),
                Code = "32799",
                Name = "Leeanne Dumbreck",
                CustomerId = Guid.Parse("f33edc88-1eb1-4de4-90bb-178dc2113af5"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("119d3da8-0b7f-497f-856a-49f337c2e314")
            },

            new Receiver
            {
                Id = Guid.Parse("4bafaf6f-0de9-4e7c-9e97-e6891fcc2cb1"),
                Code = "28107",
                Name = "Verile Cottham",
                CustomerId = Guid.Parse("db0937ae-73b4-4083-9b34-44c2db59bd12"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("bbaa4c1e-5ed1-45bc-934e-4873405f0e23")
            },

            new Receiver
            {
                Id = Guid.Parse("4bb0e6aa-8c03-4d2c-9323-6d3979ce3682"),
                Code = "17140",
                Name = "Marys Seefus",
                CustomerId = Guid.Parse("c1decd45-dfdc-49be-8769-e562ff5e33a0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("066d13b3-a3ae-487a-bd7f-b9abe43fd9f0")
            },

            new Receiver
            {
                Id = Guid.Parse("4c0e1117-62b4-4fa8-976a-6e4102ed51df"),
                Code = "32265",
                Name = "Josepha Place",
                CustomerId = Guid.Parse("4015c417-b3ad-4431-ad37-0f692495ac2c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("6b92cebf-9be6-4ce4-9279-b50f2dc5d03b")
            },

            new Receiver
            {
                Id = Guid.Parse("4c462360-a919-4851-abc6-5c93dcd87220"),
                Code = "13948",
                Name = "Pansy Brightman",
                CustomerId = Guid.Parse("5223bcf7-3c0b-4001-95e1-3b221de97cca"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("337b26f8-b78d-4432-abd0-d105270d7f0a")
            },

            new Receiver
            {
                Id = Guid.Parse("4c808bac-20fa-43c8-8aa0-211d5326a31d"),
                Code = "31693",
                Name = "Ruddie Carlsson",
                CustomerId = Guid.Parse("fa579f31-2357-4b1c-9eff-6248bb88217a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("03778aff-6f9f-46d9-99ff-ad3b36395cd6")
            },

            new Receiver
            {
                Id = Guid.Parse("4d54c059-8d5f-4a82-b21e-0b9202d2a7b7"),
                Code = "37202",
                Name = "Hildegarde Collibear",
                CustomerId = Guid.Parse("83580d7e-a3f6-43bf-8847-f99b3e04a26d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5fde0ce5-63ed-450c-a8fa-78ec131f5963")
            },

            new Receiver
            {
                Id = Guid.Parse("4d843755-82db-43cf-84c9-301ae539a1b8"),
                Code = "13709",
                Name = "Florencia Beauchamp",
                CustomerId = Guid.Parse("34ab1552-c97e-4728-863d-d0b6a455bf8d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5b73453b-eb4d-4464-ba0d-104e50b80cca")
            },

            new Receiver
            {
                Id = Guid.Parse("4da271fb-4958-4e8d-ab30-d98a6b0c34f6"),
                Code = "37190",
                Name = "Patton Mochar",
                CustomerId = Guid.Parse("245ba7b1-9089-48b5-bb3a-1839ccafc2be"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("54b4a0c3-d3e6-4892-aec8-c18d41121189")
            },

            new Receiver
            {
                Id = Guid.Parse("4e66e1b2-1807-42c2-83e5-7e9069ba9efb"),
                Code = "37718",
                Name = "Erinn Tonkin",
                CustomerId = Guid.Parse("f6e86569-69a8-4c10-b1c2-3cb4e74eeb64"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("99093bc9-3c46-4b19-b2d2-420ae745f114")
            },

            new Receiver
            {
                Id = Guid.Parse("4eb6f250-568d-4620-a133-842f6776fb7c"),
                Code = "13123",
                Name = "Skippie Filipczynski",
                CustomerId = Guid.Parse("c36607cf-976c-4a2e-a09c-67c18af70d72"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("d18461d3-2ef2-474a-b7ca-091d224ed0bc")
            },

            new Receiver
            {
                Id = Guid.Parse("5044d442-759c-43f2-9950-bb84600eb945"),
                Code = "24923",
                Name = "Quintana Parfitt",
                CustomerId = Guid.Parse("c6b19fb0-d82b-4dc1-8a9b-e0d0d1079dff"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("c3e6415e-7e8a-47bb-9206-eb1cc9801df2")
            },

            new Receiver
            {
                Id = Guid.Parse("50b5d559-b04f-4e14-882e-5e0e91ac2108"),
                Code = "33389",
                Name = "Hill Venning",
                CustomerId = Guid.Parse("3db5de6b-423d-44c1-872c-e493dfba8ea0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("20ab905a-49b2-4c7f-a1a2-ae097171ae9f")
            },

            new Receiver
            {
                Id = Guid.Parse("524fef1a-3708-4a27-89be-e69fc7474d90"),
                Code = "35674",
                Name = "Isaac Brockelsby",
                CustomerId = Guid.Parse("66672f51-767f-48af-be15-65abbeb9a9fd"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("8b78dc68-94db-48f9-b0e6-330a60040749")
            },

            new Receiver
            {
                Id = Guid.Parse("5335b674-8049-469d-8d7e-e385316375ba"),
                Code = "19362",
                Name = "Saraann Parkinson",
                CustomerId = Guid.Parse("f9555fc5-f1d4-42e4-8ff6-47683bf26e97"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("39351f4e-11eb-4c76-bed1-1d19bee3a851")
            },

            new Receiver
            {
                Id = Guid.Parse("545616b5-12be-4e2e-b642-63206165ad98"),
                Code = "37004",
                Name = "Ginni Pirie",
                CustomerId = Guid.Parse("d0af86a4-5472-461c-b6a1-17067bd8c0d2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("8612b26e-18c2-4d13-8c32-0d8721829312")
            },

            new Receiver
            {
                Id = Guid.Parse("5483b333-510e-4e61-a6b5-c40b069e4434"),
                Code = "38462",
                Name = "Kendrick Conibeer",
                CustomerId = Guid.Parse("6ccca5e5-27e2-4f03-be82-29a27dbe7f05"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("4fd68936-7177-4afb-b188-36d21d6816fc")
            },

            new Receiver
            {
                Id = Guid.Parse("54c3f2a7-e32b-4edc-b02b-012d7e767201"),
                Code = "36448",
                Name = "Rowe Walentynowicz",
                CustomerId = Guid.Parse("f9555fc5-f1d4-42e4-8ff6-47683bf26e97"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("bef8b2ab-3126-4c9c-93e7-3ca7899925be")
            },

            new Receiver
            {
                Id = Guid.Parse("55dcc641-48a7-4be3-ae63-f50fe43a9e13"),
                Code = "36218",
                Name = "Lammond McIlvaney",
                CustomerId = Guid.Parse("70f3c785-e3d2-4808-a572-0510b703068f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("a07401a9-f0c7-4c8b-aa4c-ff7d4ab9a280")
            },

            new Receiver
            {
                Id = Guid.Parse("57b1b147-1da0-462b-99cc-eda318b86ba0"),
                Code = "12121",
                Name = "Olvan Songer",
                CustomerId = Guid.Parse("308733d1-b6f1-433a-9897-33c0b8df51d7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("e071c1a2-fa27-4d5e-ab18-2d70b982d325")
            },

            new Receiver
            {
                Id = Guid.Parse("57e869dc-9bae-4860-bfef-9915ae9d0933"),
                Code = "14156",
                Name = "Wilona Sigmund",
                CustomerId = Guid.Parse("e9fa68d5-9792-42c8-8d5c-e15e7018648b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2aec1230-da06-4dc4-a632-308317c37e59")
            },

            new Receiver
            {
                Id = Guid.Parse("5846fea9-4dfd-4946-b184-5d921f567618"),
                Code = "13690",
                Name = "Katha Funcheon",
                CustomerId = Guid.Parse("7740204d-b255-46df-8b36-25ef1449f550"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("9d048d07-09bf-4830-9360-7a53cc7b089f")
            },

            new Receiver
            {
                Id = Guid.Parse("5912960e-ccad-40c5-baec-7b3f13206acd"),
                Code = "29359",
                Name = "Bowie Hedworth",
                CustomerId = Guid.Parse("abe3e8c7-b8d3-4d04-9027-ee7ef2e5ed8e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("df429c1d-388d-4335-87a2-fe9f079e2fab")
            },

            new Receiver
            {
                Id = Guid.Parse("5c3cb48a-3a06-4186-9827-07113d4883da"),
                Code = "15472",
                Name = "Almira Birwhistle",
                CustomerId = Guid.Parse("4484aa9b-1cb4-48e6-9861-e2a44e538abb"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("49291ab9-9d2b-4c3f-8d34-d9781914f65f")
            },

            new Receiver
            {
                Id = Guid.Parse("5e73a5f8-e322-4295-95b4-10012d2b4e00"),
                Code = "18621",
                Name = "Vinnie Urling",
                CustomerId = Guid.Parse("9429b285-9974-4a31-a719-77cd420a083e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("cc2e4827-7b3c-4c8d-952b-ac65ec01b442")
            },

            new Receiver
            {
                Id = Guid.Parse("60794ad5-5880-4203-81bf-70313e5a619f"),
                Code = "12449",
                Name = "Jena Ratnege",
                CustomerId = Guid.Parse("14f2d70d-1880-4de5-8e80-65a4233e5bd0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("4b0dac15-1ef2-4c6e-b332-8bd227a60da1")
            },

            new Receiver
            {
                Id = Guid.Parse("65c9df38-fc02-4007-ab68-0fb2a8039b35"),
                Code = "23368",
                Name = "Briano Waber",
                CustomerId = Guid.Parse("4e313173-56b2-4be0-83d9-8edbed68c7bc"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("34acdb49-d3cf-4f4d-b895-8b0bc36cef89")
            },

            new Receiver
            {
                Id = Guid.Parse("671527b8-79b8-49a1-aebf-03997428f713"),
                Code = "32700",
                Name = "Erl Steinson",
                CustomerId = Guid.Parse("7740204d-b255-46df-8b36-25ef1449f550"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5dd83be2-e0d9-4adf-ab1b-50c2b988c65f")
            },

            new Receiver
            {
                Id = Guid.Parse("67c1dfb9-88bc-485f-8eda-1afacf21d6b5"),
                Code = "24747",
                Name = "Coreen Sturror",
                CustomerId = Guid.Parse("83580d7e-a3f6-43bf-8847-f99b3e04a26d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("20f1b2a7-166e-4f8e-b157-8073547560b1")
            },

            new Receiver
            {
                Id = Guid.Parse("69a89f56-19a0-410e-bbab-534c21a63c1e"),
                Code = "29524",
                Name = "Reid Gerrets",
                CustomerId = Guid.Parse("d84aa82d-fd2b-452a-a9fd-c5928fae0829"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("8c4fc3c8-68c5-4c93-b295-e04b917e14c2")
            },

            new Receiver
            {
                Id = Guid.Parse("69e344bd-0f13-4b72-b644-ba1d0bec0e54"),
                Code = "22346",
                Name = "Carolan Wynett",
                CustomerId = Guid.Parse("3bb9cd5d-39ed-4294-b674-44141f3bafef"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("89a68fd1-1530-4402-9326-a8ca5c1c7760")
            },

            new Receiver
            {
                Id = Guid.Parse("6b014b9d-fc3e-40bc-bc17-8c445a98bbba"),
                Code = "30785",
                Name = "Addi Velti",
                CustomerId = Guid.Parse("35153e46-3435-4261-978f-a6ea1ec09701"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("c1d19caa-17b9-4a4f-8406-aad1a97b6dab")
            },

            new Receiver
            {
                Id = Guid.Parse("6da7865b-6cc8-4430-bc73-c0fea5451bf9"),
                Code = "31271",
                Name = "Hinze MacDunleavy",
                CustomerId = Guid.Parse("faa54a0d-497b-4323-93f8-e54d7b5b0cc9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("035732c9-a7b4-4448-8eeb-6fea7ea88a7f")
            },

            new Receiver
            {
                Id = Guid.Parse("6db961e5-2cd0-443c-9286-e4c661cca80f"),
                Code = "23634",
                Name = "Hinda Perrott",
                CustomerId = Guid.Parse("f6603a4e-ae80-45e4-984e-c80f64420f3c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("655519d8-d05a-4f54-9d80-acd6828fd62d")
            },

            new Receiver
            {
                Id = Guid.Parse("6ec8988a-3735-4a1f-8bf5-bbc4c96e33d6"),
                Code = "36086",
                Name = "Marion Newsham",
                CustomerId = Guid.Parse("35153e46-3435-4261-978f-a6ea1ec09701"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("dc74495b-18cc-41dc-9391-186af36183a3")
            },

            new Receiver
            {
                Id = Guid.Parse("6ff72f77-5084-498f-91a8-10453f1dbb90"),
                Code = "16963",
                Name = "Jocko Lewendon",
                CustomerId = Guid.Parse("8c760b1e-4834-4fc5-8ab6-767621a799b6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("f1309077-1873-43b4-9a94-69c3f725469a")
            },

            new Receiver
            {
                Id = Guid.Parse("70949e51-3527-488e-bc42-601b862a858c"),
                Code = "31082",
                Name = "Tara Emeny",
                CustomerId = Guid.Parse("b73b96d6-036c-4c25-8726-a00a96f7037d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("6607fc03-3a6f-4242-8ed8-18ae7f979c3f")
            },

            new Receiver
            {
                Id = Guid.Parse("74b3d3ca-979b-4165-afe5-09290f3975dc"),
                Code = "37197",
                Name = "Marline Heibl",
                CustomerId = Guid.Parse("f33edc88-1eb1-4de4-90bb-178dc2113af5"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2db4c929-0877-40f2-99f2-7e23b77f537f")
            },

            new Receiver
            {
                Id = Guid.Parse("758432dc-cfbc-43c1-ae39-64544fe92e40"),
                Code = "29893",
                Name = "Abelard Smout",
                CustomerId = Guid.Parse("550ee83b-8bc9-49e4-bfbb-ca753abdd735"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5fcadcb3-232f-4475-bb64-7af39bc0441b")
            },

            new Receiver
            {
                Id = Guid.Parse("7601cbe1-42fb-41ee-95d0-f599fd141592"),
                Code = "18028",
                Name = "Elaine MacAleese",
                CustomerId = Guid.Parse("b295a3e0-0cf4-4ee2-ae90-0d964f149434"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("4af64231-8870-48c5-9352-4be1e68442be")
            },

            new Receiver
            {
                Id = Guid.Parse("7a9d998e-e1f3-4e1a-8115-fdd35c9de0ad"),
                Code = "20155",
                Name = "Dorris Stobbie",
                CustomerId = Guid.Parse("f4bccb1a-fb5b-40ba-b682-57737477ecb3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5a4f63cb-c90c-47c0-95a9-6942aa9f2f32")
            },

            new Receiver
            {
                Id = Guid.Parse("7b807668-5e87-4ca2-9291-407c63ab1bd5"),
                Code = "21295",
                Name = "Bea Keighley",
                CustomerId = Guid.Parse("859c3d1f-f33a-4f13-a6e6-8a4d26270a68"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("0f4c6282-8989-48a4-ae1c-a4470379740d")
            },

            new Receiver
            {
                Id = Guid.Parse("7bfb9b18-6e85-406e-a365-e36e72ee2a1d"),
                Code = "22325",
                Name = "Emmet Dower",
                CustomerId = Guid.Parse("70f3c785-e3d2-4808-a572-0510b703068f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("dab90d16-1ccc-4102-bf8c-f9c453f12682")
            },

            new Receiver
            {
                Id = Guid.Parse("7dc6c1ed-07da-4508-b506-047a24069ef4"),
                Code = "14445",
                Name = "Charmion Drabble",
                CustomerId = Guid.Parse("b245d236-015c-4050-aaa4-c586da91f72a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("6fa6d7ee-f789-413f-930b-9985a1513f20")
            },

            new Receiver
            {
                Id = Guid.Parse("7de6c36c-f18d-4d56-b1b8-672ebd36e473"),
                Code = "23179",
                Name = "Yvonne Wildish",
                CustomerId = Guid.Parse("af722a07-2934-4171-9e26-9611620a5d4a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("476ca697-e730-497f-81db-cacffe59aad0")
            },

            new Receiver
            {
                Id = Guid.Parse("7e5b186b-bcf2-446f-8035-ec1a2ed7c26c"),
                Code = "22558",
                Name = "Eada McCree",
                CustomerId = Guid.Parse("af722a07-2934-4171-9e26-9611620a5d4a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("c2e0fe22-0b52-491d-accf-ded2c2dafc3a")
            },

            new Receiver
            {
                Id = Guid.Parse("7f47fc00-7e43-41ff-91ab-c4898484ead2"),
                Code = "25660",
                Name = "Alayne Aldrich",
                CustomerId = Guid.Parse("51060419-3c9e-4dc5-b13a-d5ccaacb0276"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("13e035a8-646c-4636-9d50-f565603c7fb9")
            },

            new Receiver
            {
                Id = Guid.Parse("80858181-9a59-48f6-8990-f86162a158c1"),
                Code = "28875",
                Name = "Minna Trundell",
                CustomerId = Guid.Parse("c6aff869-d2ea-420f-b381-1cc66820fa5c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("e9fb63d1-c9d3-4c1d-abe0-5ddd74863cc9")
            },

            new Receiver
            {
                Id = Guid.Parse("82bf7a64-b780-4ac7-8d02-fce812a254dd"),
                Code = "27484",
                Name = "Marieann Darlington",
                CustomerId = Guid.Parse("55820f2f-28ea-41d5-b978-47c630bc045f"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("acdde399-727d-4718-8f02-02b9d22ab477")
            },

            new Receiver
            {
                Id = Guid.Parse("830bcb06-5a55-43b3-86fb-435a9ac9a068"),
                Code = "14125",
                Name = "Hedda Faulkes",
                CustomerId = Guid.Parse("8a520f1b-e857-495a-ba68-d3efe0d04513"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("def14cae-ecb0-43a5-aa88-fca141e69c66")
            },

            new Receiver
            {
                Id = Guid.Parse("84a387c7-f6dd-4266-901a-5fd30f9c0b74"),
                Code = "24456",
                Name = "Marillin Willes",
                CustomerId = Guid.Parse("13cf070d-5ff6-4745-9ef7-575af5f35b2b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("da71f397-3751-4e48-8919-8e4843181a1c")
            },

            new Receiver
            {
                Id = Guid.Parse("861557d7-fadc-4184-9f70-2929d4fc611c"),
                Code = "16186",
                Name = "Kristine Highway",
                CustomerId = Guid.Parse("c36607cf-976c-4a2e-a09c-67c18af70d72"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("7b31b1ac-99fb-4d86-995c-d05a43af5bfe")
            },

            new Receiver
            {
                Id = Guid.Parse("86eb8493-2efd-4b44-b555-7ec290dc8dff"),
                Code = "27574",
                Name = "Nicolai Morales",
                CustomerId = Guid.Parse("db7c0d56-72f0-43be-93f0-0fd8d123c081"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("e4beec47-e5bb-4ec3-8866-2bd0b333dda8")
            },

            new Receiver
            {
                Id = Guid.Parse("894b4596-2bd9-4244-817d-ce767390107f"),
                Code = "25228",
                Name = "Barron Mitskevich",
                CustomerId = Guid.Parse("13cf070d-5ff6-4745-9ef7-575af5f35b2b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("65720e48-caab-4425-a7f2-6dcb1d40d608")
            },

            new Receiver
            {
                Id = Guid.Parse("8ab58f46-a862-48ed-bd07-aa6314877123"),
                Code = "12556",
                Name = "Roseanna Softley",
                CustomerId = Guid.Parse("d84aa82d-fd2b-452a-a9fd-c5928fae0829"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("d59cb584-3b8e-427b-9855-93d8032e89f0")
            },

            new Receiver
            {
                Id = Guid.Parse("8b0d6793-46ce-481a-b016-e7c35558611d"),
                Code = "27520",
                Name = "Windham Allsobrook",
                CustomerId = Guid.Parse("225085b3-a668-4c78-85c7-5653ce668fc0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("e893fd34-3659-46ed-9267-96bfe3eabf85")
            },

            new Receiver
            {
                Id = Guid.Parse("8b7a115a-45bc-4f6c-a76c-ede0d9ba8d25"),
                Code = "31309",
                Name = "Gene McGaughey",
                CustomerId = Guid.Parse("e8d55a90-f1d1-4935-9cb4-d2cd6a73cd88"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("9ba4b9cb-3d82-4ead-ace3-ed112d884898")
            },

            new Receiver
            {
                Id = Guid.Parse("8c4807b2-5044-40fb-972d-eac2183ea1c4"),
                Code = "32452",
                Name = "Leandra Janiak",
                CustomerId = Guid.Parse("49b8870f-cabb-46a5-95ac-b50552260db6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("9b0c06ba-9129-4329-83d7-d0417b3703a6")
            },

            new Receiver
            {
                Id = Guid.Parse("8cd3ed92-ab8e-4600-a61c-d46812c91fdf"),
                Code = "32878",
                Name = "Rivi Knowling",
                CustomerId = Guid.Parse("f4b38069-4ed4-41e9-8fab-b5297c2946df"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("10027d12-be14-47e2-b2a7-cb98d0d28708")
            },

            new Receiver
            {
                Id = Guid.Parse("8d84e78d-7d64-494b-827d-daf588a88182"),
                Code = "18096",
                Name = "Daune Hosier",
                CustomerId = Guid.Parse("e9fa68d5-9792-42c8-8d5c-e15e7018648b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("12205437-39e6-415a-b99f-f5cd06c13f64")
            },

            new Receiver
            {
                Id = Guid.Parse("8ec3c3f2-303b-4c63-b944-527e92fccd46"),
                Code = "36718",
                Name = "Elianora Mann",
                CustomerId = Guid.Parse("8cb8d455-ff46-420c-a5f3-8d45586e3b78"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("3a057a58-cba4-4c8b-9b3d-3c2c6da962be")
            },

            new Receiver
            {
                Id = Guid.Parse("8f0b3395-05a4-46a0-ac12-75599c068e57"),
                Code = "33064",
                Name = "Carson Edwins",
                CustomerId = Guid.Parse("ba9c006d-b9dc-4aae-90a3-861027f8bf28"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("77e0f210-b417-4b14-ae57-a9b5a949a146")
            },

            new Receiver
            {
                Id = Guid.Parse("904bc249-bf2a-4fa2-83b1-48b7cc76e41e"),
                Code = "32066",
                Name = "Wyn Perrett",
                CustomerId = Guid.Parse("3db5de6b-423d-44c1-872c-e493dfba8ea0"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("707d4bbe-a5ed-4f0b-b0e2-8f5bb8d3b3ad")
            },

            new Receiver
            {
                Id = Guid.Parse("91ce5e28-ad90-40e6-b2df-c8c65b559b9f"),
                Code = "13527",
                Name = "Francis Nineham",
                CustomerId = Guid.Parse("6f90fc99-0ff8-4d69-9f8b-faa72fc6b8cd"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("4e1165e8-e3de-4444-843f-a57872e51a8e")
            },

            new Receiver
            {
                Id = Guid.Parse("932da148-ae81-4bfa-8a95-386c6f7fa4fe"),
                Code = "29183",
                Name = "Baryram Yanukhin",
                CustomerId = Guid.Parse("ec4cf749-24cd-45b4-9285-bc1f22b52204"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2d2f4951-5b21-442d-a571-6c00977896c6")
            },

            new Receiver
            {
                Id = Guid.Parse("93a9ad1d-c52e-45ff-95fe-2a9a67f49c7e"),
                Code = "32566",
                Name = "Linoel Olivey",
                CustomerId = Guid.Parse("5223bcf7-3c0b-4001-95e1-3b221de97cca"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("6bc7b776-7ffd-450f-9509-59aac19f3d27")
            },

            new Receiver
            {
                Id = Guid.Parse("950edcbc-3cae-44d5-8906-76797fea5a99"),
                Code = "31302",
                Name = "Emmy Farmar",
                CustomerId = Guid.Parse("bba75ae0-fbe9-4083-b887-70236f2da58b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("44bf4feb-4559-4a83-828c-c093f4965633")
            },

            new Receiver
            {
                Id = Guid.Parse("9589cf45-025e-413a-8ce8-1066ae078c69"),
                Code = "30765",
                Name = "Chrissy Uzielli",
                CustomerId = Guid.Parse("d1389037-dc3a-4938-abb1-74dead5e1b53"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("05243ef3-3f01-44b2-b175-52fffb36ec63")
            },

            new Receiver
            {
                Id = Guid.Parse("961abb7d-19d3-426f-9782-21b710e436ee"),
                Code = "27385",
                Name = "Sydney Arnatt",
                CustomerId = Guid.Parse("07798ff4-c448-4701-8375-8aeff6b0e06c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("b870b9d3-b528-4a73-b043-53b475fe9069")
            },

            new Receiver
            {
                Id = Guid.Parse("979f44dd-8aae-49cd-8669-4ee78588de9a"),
                Code = "35304",
                Name = "Vanni De la Yglesias",
                CustomerId = Guid.Parse("308733d1-b6f1-433a-9897-33c0b8df51d7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("a2eac29a-b869-4c93-b080-25d95f1f3462")
            },

            new Receiver
            {
                Id = Guid.Parse("986aab1d-77af-46cd-90e9-e6fb424b5319"),
                Code = "30011",
                Name = "Ileane Cuncarr",
                CustomerId = Guid.Parse("b295a3e0-0cf4-4ee2-ae90-0d964f149434"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("52a2aee0-0074-450c-b963-493ae6c6d8b0")
            },

            new Receiver
            {
                Id = Guid.Parse("9a09e096-72a0-4380-a958-8582b7235b57"),
                Code = "35856",
                Name = "Ruddie Drage",
                CustomerId = Guid.Parse("e8964b4d-c59e-4a55-a958-fc43955a289d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("0de5db77-7827-4c3e-9c59-de33f222e53d")
            },

            new Receiver
            {
                Id = Guid.Parse("9a291059-bfe0-4386-98d0-1951d04861d7"),
                Code = "16801",
                Name = "Connie Culshew",
                CustomerId = Guid.Parse("859c3d1f-f33a-4f13-a6e6-8a4d26270a68"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2b3bc27d-e9f7-458e-af46-2c36d14f7185")
            },

            new Receiver
            {
                Id = Guid.Parse("9a30271c-7bfc-4bfc-a762-f62cc1d7760c"),
                Code = "19932",
                Name = "Mar Montel",
                CustomerId = Guid.Parse("f4bccb1a-fb5b-40ba-b682-57737477ecb3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("9d9fa0bd-4f4a-4c06-a97c-956a706ede32")
            },

            new Receiver
            {
                Id = Guid.Parse("9cd9ed44-89cc-4720-aacf-ce7293dd4b61"),
                Code = "37412",
                Name = "Gabbey Pindred",
                CustomerId = Guid.Parse("fe409812-db1d-496c-8c4d-fa77e173db51"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("c9cb79f6-e82f-462f-a658-2458c92e7052")
            },

            new Receiver
            {
                Id = Guid.Parse("a3ddca07-8871-4a40-9ead-7ababc3a41f9"),
                Code = "35225",
                Name = "Hurley Silmon",
                CustomerId = Guid.Parse("6f90fc99-0ff8-4d69-9f8b-faa72fc6b8cd"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("541324d1-5bee-4d8c-91e5-ce1dc2c4038a")
            },

            new Receiver
            {
                Id = Guid.Parse("a81948d7-3421-4213-ae59-9888c632942b"),
                Code = "37557",
                Name = "Alexis Granville",
                CustomerId = Guid.Parse("9536c8eb-8485-449c-b966-36f2b05921a3"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("e519456c-68b8-4a82-a8b8-ed1888502e04")
            },

            new Receiver
            {
                Id = Guid.Parse("a8603c18-faae-46e1-953c-6ae80c059700"),
                Code = "33915",
                Name = "Yulma Agron",
                CustomerId = Guid.Parse("8347ef80-c2d1-4d8d-ad09-a008fc1bb184"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("a2f10e9a-e20b-4f25-873f-9607c7d4ed87")
            },

            new Receiver
            {
                Id = Guid.Parse("a899607c-c40a-4601-b0f5-791f87e51237"),
                Code = "24940",
                Name = "Clarke Pelchat",
                CustomerId = Guid.Parse("13f2f8e0-f20e-4b1d-bc24-60dbc82d60d6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("6e44e339-67c3-48cd-985e-2cfc79876424")
            },

            new Receiver
            {
                Id = Guid.Parse("a94f4358-ee0c-4e9d-bb54-a48672f12a1d"),
                Code = "24267",
                Name = "Daven Hair",
                CustomerId = Guid.Parse("181cb261-3832-4ee7-9c79-727be4a880f6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("870de510-9cf7-4a5e-8855-f33fa445192f")
            },

            new Receiver
            {
                Id = Guid.Parse("abd4fa9e-8bdc-41d4-8e28-7556b25fc189"),
                Code = "33139",
                Name = "Therese Jannaway",
                CustomerId = Guid.Parse("550ee83b-8bc9-49e4-bfbb-ca753abdd735"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("b9938475-6ad8-49d2-a3c1-aa70e107ab44")
            },

            new Receiver
            {
                Id = Guid.Parse("ad4b8648-d30a-4983-a6ad-e5522e239c63"),
                Code = "37194",
                Name = "Adel Hellier",
                CustomerId = Guid.Parse("451f87e0-23d5-442a-8826-6e2f1f1f2ac8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("351f1ad8-3519-44aa-b7d5-24451a9d1260")
            },

            new Receiver
            {
                Id = Guid.Parse("ae1e457a-2dd0-4275-849f-155903b85d9a"),
                Code = "19709",
                Name = "Salvatore Quincee",
                CustomerId = Guid.Parse("f45d434b-9376-48eb-a77b-f873d7f23d2e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("02b5a9a5-8b9b-4d38-b1f7-b587811d6a6c")
            },

            new Receiver
            {
                Id = Guid.Parse("b1043d36-8851-4393-bf00-8a64e088e3ab"),
                Code = "29460",
                Name = "Gypsy Sommer",
                CustomerId = Guid.Parse("aaeabf37-11e7-4195-87d6-08957002c8b1"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("bd18b93c-870d-4b8c-ad0d-162825959318")
            },

            new Receiver
            {
                Id = Guid.Parse("b1a2d982-7d56-4966-8ea8-0eb84b07daae"),
                Code = "31408",
                Name = "Dorette Stockill",
                CustomerId = Guid.Parse("e8d55a90-f1d1-4935-9cb4-d2cd6a73cd88"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("7981da33-a5f1-4b83-bf0d-d4999e7426df")
            },

            new Receiver
            {
                Id = Guid.Parse("b31005cc-1ff5-4b4f-a8a7-9e84d3eca198"),
                Code = "38834",
                Name = "Ches Twidle",
                CustomerId = Guid.Parse("15129ab9-882d-456b-af1a-22668ce33a22"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("086eb164-baa8-4fc4-b101-1ffa00d8ed72")
            },

            new Receiver
            {
                Id = Guid.Parse("b313961f-6f1c-4fbf-96c2-b8ef101ebd64"),
                Code = "27852",
                Name = "Marmaduke Bixley",
                CustomerId = Guid.Parse("f6e86569-69a8-4c10-b1c2-3cb4e74eeb64"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5c52464e-85b2-47b9-a911-a11b6c134975")
            },

            new Receiver
            {
                Id = Guid.Parse("b3636cbd-97f1-4c24-8a74-95a795369ca4"),
                Code = "14563",
                Name = "Jakob Hessle",
                CustomerId = Guid.Parse("70578706-855a-42a6-8422-50d45c21841d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2e510420-5df0-4868-b86c-5241f0bc0a67")
            },

            new Receiver
            {
                Id = Guid.Parse("ba755106-ebdf-462e-b2aa-e4c7e1ff697e"),
                Code = "13576",
                Name = "Ingeborg Agius",
                CustomerId = Guid.Parse("faa54a0d-497b-4323-93f8-e54d7b5b0cc9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("40d22f52-d0f0-4b72-ae07-66a59cf46e4d")
            },

            new Receiver
            {
                Id = Guid.Parse("bae227e9-bee8-4595-a28e-94f056934e8a"),
                Code = "38983",
                Name = "Jule Cotter",
                CustomerId = Guid.Parse("51060419-3c9e-4dc5-b13a-d5ccaacb0276"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("7e96d308-2a5c-4e74-a75f-9ff147ee4483")
            },

            new Receiver
            {
                Id = Guid.Parse("bbc1b7f7-404d-47c6-a441-77bbcb48a562"),
                Code = "32685",
                Name = "Chandler Crim",
                CustomerId = Guid.Parse("bc23c63d-be8c-4960-a6dc-f5164c9e0a0b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2e0d8f8c-172b-480d-8239-32a18f646e4a")
            },

            new Receiver
            {
                Id = Guid.Parse("bc9b16fd-69d8-403d-92d3-e4f41efcf833"),
                Code = "15125",
                Name = "Simmonds Bavester",
                CustomerId = Guid.Parse("ec4cf749-24cd-45b4-9285-bc1f22b52204"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("2fef7a01-4038-484f-8a21-0dbd3537ba4b")
            },

            new Receiver
            {
                Id = Guid.Parse("bd3d09c1-c66d-45fa-8c7c-9571d85b4084"),
                Code = "19245",
                Name = "Sharron Rewbottom",
                CustomerId = Guid.Parse("fecc825d-31ed-419b-8aa7-bf7eb4a13a19"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("fceb4e29-8b84-4aa5-886f-914dd7a660cb")
            },

            new Receiver
            {
                Id = Guid.Parse("bdb5dfe1-943f-461b-a155-817366f5d459"),
                Code = "32275",
                Name = "Barnard Tuddall",
                CustomerId = Guid.Parse("fecc825d-31ed-419b-8aa7-bf7eb4a13a19"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("4ee13e23-f45c-4e59-87d9-43f0f9477650")
            },

            new Receiver
            {
                Id = Guid.Parse("be128615-f8e5-4223-9bc1-e7bea7c7ce72"),
                Code = "13255",
                Name = "Lona Oxlee",
                CustomerId = Guid.Parse("10a3d9ec-6411-48c4-ae15-62776c9ee8f2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("8271e484-32ed-40cb-a8b1-2aaea16cf422")
            },

            new Receiver
            {
                Id = Guid.Parse("bf7239ac-5a46-4d40-8973-bc849999021b"),
                Code = "22575",
                Name = "Nathalia Shilstone",
                CustomerId = Guid.Parse("3943f9fe-f31b-4e0d-aab0-c4355a83d28b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("ac09b7da-bc82-4dbf-a123-2eb93b124b9c")
            },

            new Receiver
            {
                Id = Guid.Parse("bf7ce1ea-274c-4392-84dc-43a335bc2f52"),
                Code = "17776",
                Name = "Roderick Pena",
                CustomerId = Guid.Parse("faa54a0d-497b-4323-93f8-e54d7b5b0cc9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("a8cf5410-65e8-4fab-98db-51c142b7a5ad")
            },

            new Receiver
            {
                Id = Guid.Parse("c036826a-6d08-4ca5-aa64-df0c1836a400"),
                Code = "16859",
                Name = "Esta Hehnke",
                CustomerId = Guid.Parse("b73b96d6-036c-4c25-8726-a00a96f7037d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("8b012c1c-ed55-4ed9-bb13-12f99e180e5f")
            },

            new Receiver
            {
                Id = Guid.Parse("c340611e-aefd-4e54-8aab-3aba9e4a4d18"),
                Code = "36083",
                Name = "Jennilee Royds",
                CustomerId = Guid.Parse("1e36ca18-687b-49a6-9e76-1632136ecd1b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("0e9d2926-6841-41f2-a7e7-95e67b5f402b")
            },

            new Receiver
            {
                Id = Guid.Parse("c5bd2362-542f-4d71-9b64-bd3360c46aff"),
                Code = "20272",
                Name = "Gayel Tomankowski",
                CustomerId = Guid.Parse("a269ada2-6ddc-4acd-9c27-ec9b9e742fcb"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("e2aa9aae-e3fd-4530-96e3-ae016cc8135b")
            },

            new Receiver
            {
                Id = Guid.Parse("c788351d-15a6-42d4-b08d-c0246219c025"),
                Code = "29473",
                Name = "Cristine Sutheran",
                CustomerId = Guid.Parse("9b4502fb-2925-444e-8a6e-e3fef0c064a7"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("7e6754ed-ce05-4914-9262-ec06204a7b62")
            },

            new Receiver
            {
                Id = Guid.Parse("cad9a033-defb-450d-8f44-000e67496623"),
                Code = "36082",
                Name = "Jocelyne Knightsbridge",
                CustomerId = Guid.Parse("9947af67-db7d-4626-b91c-5b0ba6de9be9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("751bf468-1636-4576-a36e-e2eb3c6c72e7")
            },

            new Receiver
            {
                Id = Guid.Parse("cb116cff-5ade-48a0-ad09-30f36f3bd7bb"),
                Code = "32211",
                Name = "Troy Bigham",
                CustomerId = Guid.Parse("f70b159f-0469-4887-8abf-ffce8c645616"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("fc7404c2-7c0a-471a-bf8f-5359c6671f6b")
            },

            new Receiver
            {
                Id = Guid.Parse("cb7e100f-517d-4c04-9b19-c856f2b9e402"),
                Code = "38007",
                Name = "Patrizius Gardner",
                CustomerId = Guid.Parse("abe3e8c7-b8d3-4d04-9027-ee7ef2e5ed8e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("42542411-ee35-4625-8da0-f4dcffc907c2")
            },

            new Receiver
            {
                Id = Guid.Parse("cc6890dd-6da9-4f2a-a54a-f9fe65a7a961"),
                Code = "26613",
                Name = "Kerri Tift",
                CustomerId = Guid.Parse("d1389037-dc3a-4938-abb1-74dead5e1b53"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("c8512edf-7f3b-49d2-80cf-5baec51b8741")
            },

            new Receiver
            {
                Id = Guid.Parse("ccae450e-f851-4583-ab70-fbb010bedf2b"),
                Code = "26532",
                Name = "Angeline MacCartney",
                CustomerId = Guid.Parse("8514324c-dd15-4d06-8998-ee60c9971164"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("af7c2192-f77e-40d9-bd8b-ed32e9c7a3a3")
            },

            new Receiver
            {
                Id = Guid.Parse("cd66f4e4-10cd-4709-8b13-fd2ec527d85b"),
                Code = "36284",
                Name = "Angelico Daile",
                CustomerId = Guid.Parse("fecc825d-31ed-419b-8aa7-bf7eb4a13a19"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("945d469e-f23f-47be-a33c-f9e7961d8dbf")
            },

            new Receiver
            {
                Id = Guid.Parse("d198c433-012a-4c6a-987c-3c5c40f84c70"),
                Code = "24582",
                Name = "Dale Fleischmann",
                CustomerId = Guid.Parse("ba9c006d-b9dc-4aae-90a3-861027f8bf28"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("7732d4f8-2fef-4bcb-93ba-2cd49e16d903")
            },

            new Receiver
            {
                Id = Guid.Parse("d2cc8da3-a7e5-4991-b0b7-9e47b59c9b0e"),
                Code = "32438",
                Name = "Pauline Curuclis",
                CustomerId = Guid.Parse("4e313173-56b2-4be0-83d9-8edbed68c7bc"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("0df24069-09b8-4f38-a0a7-c59443ebcf57")
            },

            new Receiver
            {
                Id = Guid.Parse("d395b8ee-3759-47c5-bb73-80ce8cd46403"),
                Code = "15039",
                Name = "Major Ellissen",
                CustomerId = Guid.Parse("abafe08a-3bb8-46cd-86c9-63b793922a39"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("953dbd57-4ab6-4faf-b1b7-26c27b9d63b5")
            },

            new Receiver
            {
                Id = Guid.Parse("d972051b-05c8-4874-bba1-a90708e6f817"),
                Code = "28353",
                Name = "Laurena Ropkins",
                CustomerId = Guid.Parse("240351f3-95b1-4124-bac3-eb8d0fca1b7e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("af1a538a-b7bb-413e-9923-be384cbf4f42")
            },

            new Receiver
            {
                Id = Guid.Parse("dbd8af6d-9eb9-4a24-b0eb-c2b37f42fd69"),
                Code = "26071",
                Name = "Christal Rosenblum",
                CustomerId = Guid.Parse("181cb261-3832-4ee7-9c79-727be4a880f6"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("bb56c645-bd8a-4dc5-b759-21f80cbec269")
            },

            new Receiver
            {
                Id = Guid.Parse("dbfcf0cd-df22-46e5-b17c-fe6e978d1b3a"),
                Code = "33974",
                Name = "Emory Hatry",
                CustomerId = Guid.Parse("cfa000cc-7914-4c56-83b3-03750858f9a8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("74f343f4-ae50-4d2e-8d36-174d03ee5889")
            },

            new Receiver
            {
                Id = Guid.Parse("dcee41a0-974c-43dc-8f60-7885a5602919"),
                Code = "24509",
                Name = "Becka Leile",
                CustomerId = Guid.Parse("245ba7b1-9089-48b5-bb3a-1839ccafc2be"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("b16f7bb9-e72b-448d-ab6d-5df87a468872")
            },

            new Receiver
            {
                Id = Guid.Parse("dfd558e3-8fee-465e-bea9-109000555271"),
                Code = "33253",
                Name = "Israel Dryburgh",
                CustomerId = Guid.Parse("8a520f1b-e857-495a-ba68-d3efe0d04513"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("6691ce19-0271-4c8d-9e1a-5b6cb6ad9beb")
            },

            new Receiver
            {
                Id = Guid.Parse("e02e2d75-537e-4191-b5e6-73eda6614aa9"),
                Code = "14324",
                Name = "Borg Scrowson",
                CustomerId = Guid.Parse("f4b38069-4ed4-41e9-8fab-b5297c2946df"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("71ad0e3c-5024-4bbd-ba13-5b0d4abb7f15")
            },

            new Receiver
            {
                Id = Guid.Parse("e05b2219-95ef-430b-a3f9-937e77af6b3d"),
                Code = "37785",
                Name = "Rolfe de Villier",
                CustomerId = Guid.Parse("e963e674-af77-4991-b10a-4d33c3b48a78"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("4cbb6e3b-d959-4508-80aa-fe8abd8c928e")
            },

            new Receiver
            {
                Id = Guid.Parse("e0e7c336-0966-4a73-88e5-45426a99a449"),
                Code = "32875",
                Name = "Louella Kristoffersson",
                CustomerId = Guid.Parse("4015c417-b3ad-4431-ad37-0f692495ac2c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("4fcc9e59-8973-469f-a29c-420fc7ff4e8c")
            },

            new Receiver
            {
                Id = Guid.Parse("e113a03b-ca64-4a04-a44b-985a6ac2a35b"),
                Code = "16145",
                Name = "Charmane Strothers",
                CustomerId = Guid.Parse("f4b38069-4ed4-41e9-8fab-b5297c2946df"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("f4016e88-7709-498d-8747-43c6dc5c2bbe")
            },

            new Receiver
            {
                Id = Guid.Parse("e2c36fce-824b-4b1e-9d2f-bb3d9f83f2b1"),
                Code = "33702",
                Name = "Caryl Berkeley",
                CustomerId = Guid.Parse("f6e86569-69a8-4c10-b1c2-3cb4e74eeb64"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("1243a0a9-82ca-4fab-840b-add93489c99d")
            },

            new Receiver
            {
                Id = Guid.Parse("e31d2130-9d88-4404-b47e-e57c4f8785c4"),
                Code = "15050",
                Name = "Maddy Abramamovh",
                CustomerId = Guid.Parse("5dc8f138-d4db-4514-a2d9-9b8581720970"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("e488f390-7a4a-4097-ac88-b3c9c7ec6d0e")
            },

            new Receiver
            {
                Id = Guid.Parse("e48a8ee1-1d8d-47f3-b252-79a4df99a3ad"),
                Code = "18803",
                Name = "Lindsey Dussy",
                CustomerId = Guid.Parse("bba75ae0-fbe9-4083-b887-70236f2da58b"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("357d0aaf-0b72-4675-b490-06707c5fecaf")
            },

            new Receiver
            {
                Id = Guid.Parse("e7c808a1-8ec1-4410-8e6c-2bc0250c9677"),
                Code = "36539",
                Name = "Sandie MacDunlevy",
                CustomerId = Guid.Parse("d6b3a066-520a-43ff-983c-4e4cd579c9e9"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("34c86aab-a097-49d6-831c-88509f3b9de9")
            },

            new Receiver
            {
                Id = Guid.Parse("e9ea8555-e15f-43e6-802a-82581f0523df"),
                Code = "36652",
                Name = "Barthel Aylmer",
                CustomerId = Guid.Parse("e72c9a27-6ac1-47f4-a66a-d65e9e0d46d1"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("0ecdfa73-ff3f-4cf6-9d41-5c3580d2b24b")
            },

            new Receiver
            {
                Id = Guid.Parse("ead53e6f-578c-4577-9e81-00c4e479cd1d"),
                Code = "14742",
                Name = "Catlin O'Heagertie",
                CustomerId = Guid.Parse("15129ab9-882d-456b-af1a-22668ce33a22"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("d8ca0911-ac4a-4fad-b26c-0aea96560fcf")
            },

            new Receiver
            {
                Id = Guid.Parse("ebf8667b-9ee1-4726-aadf-2580651bea4a"),
                Code = "14078",
                Name = "Elenore Larway",
                CustomerId = Guid.Parse("af722a07-2934-4171-9e26-9611620a5d4a"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("5bb3d043-558f-456c-aa8a-71fb185c43ba")
            },

            new Receiver
            {
                Id = Guid.Parse("ecc34752-55ea-4a98-b3dc-b8971e3da412"),
                Code = "27716",
                Name = "Hunfredo Prine",
                CustomerId = Guid.Parse("34ab1552-c97e-4728-863d-d0b6a455bf8d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("8403acaa-0dad-4c4e-9cb3-9b525aa660ab")
            },

            new Receiver
            {
                Id = Guid.Parse("ed8a4171-8215-4fc3-9f3c-956398d7e43a"),
                Code = "15219",
                Name = "Lorenza Frossell",
                CustomerId = Guid.Parse("e78b1196-21ec-47b3-a82c-9a1854c4ba2c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("d729ac60-7953-4c8c-8dc6-d4f79a2c325f")
            },

            new Receiver
            {
                Id = Guid.Parse("ee1ebae9-59dd-4959-85bf-84cf5f64ea11"),
                Code = "17489",
                Name = "Faina Mapston",
                CustomerId = Guid.Parse("e72c9a27-6ac1-47f4-a66a-d65e9e0d46d1"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("22189e4e-9c1e-4c43-bd78-73c04fd53602")
            },

            new Receiver
            {
                Id = Guid.Parse("f088ed17-63ad-4175-bda2-e546d40c533b"),
                Code = "25754",
                Name = "Bertha Baysting",
                CustomerId = Guid.Parse("e68839c8-1b05-40a2-8e7d-0bff9162462c"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("bb32856f-91ea-4756-8cfc-4d1347577b5a")
            },

            new Receiver
            {
                Id = Guid.Parse("f38d0e89-d37c-4e4c-8773-119b23afd0b9"),
                Code = "33073",
                Name = "Luigi Sherrock",
                CustomerId = Guid.Parse("dbad4020-7ad7-4d55-b4a9-a29a378c9414"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("c17e9d5f-6c0b-478c-89b8-93b8e0848467")
            },

            new Receiver
            {
                Id = Guid.Parse("f3fd3a9c-b4a8-41f9-ad42-7479e63fe229"),
                Code = "33570",
                Name = "Marcelle Filmer",
                CustomerId = Guid.Parse("9429b285-9974-4a31-a719-77cd420a083e"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("8bd64cdd-5a1e-4753-b979-8e99f9b72fad")
            },

            new Receiver
            {
                Id = Guid.Parse("f4b49a42-e697-4b3a-8d3a-676505d1a458"),
                Code = "17127",
                Name = "Ryann Rapinett",
                CustomerId = Guid.Parse("8a1222e2-ec4f-4a61-b8bb-178b81209b97"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("596b4be4-a97e-4ecc-ae58-a9d9e0338f66")
            },

            new Receiver
            {
                Id = Guid.Parse("fc854a51-3a12-49a6-801c-23708cb627e2"),
                Code = "18368",
                Name = "Ty Bassingham",
                CustomerId = Guid.Parse("fe409812-db1d-496c-8c4d-fa77e173db51"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("e8c28ebd-396d-4940-aead-2da7084728b6")
            },

            new Receiver
            {
                Id = Guid.Parse("fcccd27f-6006-4469-b866-59873c820161"),
                Code = "15407",
                Name = "Jory Moyler",
                CustomerId = Guid.Parse("10a3d9ec-6411-48c4-ae15-62776c9ee8f2"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("d4ce18fd-d1b6-4609-a92b-504421e87948")
            },

            new Receiver
            {
                Id = Guid.Parse("fcd9c9de-0a11-498d-8451-92554facdca5"),
                Code = "15010",
                Name = "Alexandre Briscam",
                CustomerId = Guid.Parse("451f87e0-23d5-442a-8826-6e2f1f1f2ac8"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("0b4e3c7b-07df-4b0e-8671-a019a088ffb8")
            },

            new Receiver
            {
                Id = Guid.Parse("ff118b35-1467-4cc2-b91e-e8693c6eeff6"),
                Code = "27401",
                Name = "Ken Bullen",
                CustomerId = Guid.Parse("70578706-855a-42a6-8422-50d45c21841d"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
                AddressId = Guid.Parse("b947a4ed-2c88-4ab7-9119-5fc72c717423")
            }
            );
    }
}
