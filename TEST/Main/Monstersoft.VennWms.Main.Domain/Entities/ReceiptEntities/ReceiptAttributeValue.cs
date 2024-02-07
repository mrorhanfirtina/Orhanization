using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities
{
    public class ReceiptAttributeValue : Entity<Guid>
    {
        public Guid ReceiptId { get; set; }
        public Guid ReceiptAttributeId { get; set; }
        public string Value { get; set; }
        public virtual Receipt? Receipt { get; set; }
        public virtual ReceiptAttribute? ReceiptAttribute { get; set; }

        public ReceiptAttributeValue()
        {
        }

        public ReceiptAttributeValue(Guid id, Guid receiptId, Guid receiptAttributeId, string value) : this()
        {
            Id = id;
            ReceiptId = receiptId;
            ReceiptAttributeId = receiptAttributeId;
            Value = value;
        }
    }
}
