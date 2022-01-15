using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.PurchaseHistory
{
    public class Purchase : AuditedEntity<Guid>
    {
        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public EntityType Type { get; set; }

        public float Price { get; set; }
    }
}
