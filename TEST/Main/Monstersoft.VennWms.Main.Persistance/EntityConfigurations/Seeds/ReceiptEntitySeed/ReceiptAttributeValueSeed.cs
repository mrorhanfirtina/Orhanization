using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReceiptEntitySeed;

public class ReceiptAttributeValueSeed : IEntityTypeConfiguration<ReceiptAttributeValue>
{
    public void Configure(EntityTypeBuilder<ReceiptAttributeValue> builder)
    {
        builder.HasData(
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("04a42924-2add-40f3-a42d-15c09ac0570d"),
            ReceiptId = Guid.Parse("c0e64256-e82e-408f-8084-386d91381e5b"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100011",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("1a05b394-77a9-446e-9c7a-c611b27a95ab"),
            ReceiptId = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100003",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("1a8bdcb4-28a6-4eca-9510-287d8865968b"),
            ReceiptId = Guid.Parse("f6c46bf8-28c9-4ae4-b42c-1d1893e68e0d"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100013",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("2351af35-2669-46c3-8ef1-afef0072e056"),
            ReceiptId = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100008",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("5d5facaa-b074-4a35-b5f9-56aaf8eeacc7"),
            ReceiptId = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100007",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("71728afc-9d41-4924-bbd2-f01e14e2f15b"),
            ReceiptId = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100004",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("75cd1994-1389-4e9f-b828-1d7ed98f57e1"),
            ReceiptId = Guid.Parse("9a9b98fa-80b9-4e94-93c6-aaa7bfb1262e"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100010",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("792a2339-d8b7-42be-b099-4b0beb0b6217"),
            ReceiptId = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100002",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("7f354c4d-7835-4b05-a0da-edc07b695b29"),
            ReceiptId = Guid.Parse("dad42b46-2e25-4262-8463-718722488bb0"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100012",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("860cc23c-37ef-46fc-838c-99088a43c123"),
            ReceiptId = Guid.Parse("fe6f7f97-5430-4bb8-b884-b54de4d30942"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100014",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("8a48e832-814f-42c5-9bc0-d1b266668b19"),
            ReceiptId = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100005",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("9d571772-7f05-415f-9dfe-02234c5fe45f"),
            ReceiptId = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100006",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("ae38ad06-544e-4c79-a002-2c61cb97fc4c"),
            ReceiptId = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100001",
            CreatedDate = DateTime.Now,
        },
        new ReceiptAttributeValue
        {
            Id = Guid.Parse("f3c04354-3821-4bd7-b2d9-b899724a2e34"),
            ReceiptId = Guid.Parse("9a1b66f5-520b-40b6-b556-6c24f894f284"),
            ReceiptAttributeId = Guid.Parse("b04a7ee2-3a80-4bd3-b45f-6cd88fa5dfda"),
            Value = "DES2024040100009",
            CreatedDate = DateTime.Now,
        }
        );
    }
}
