using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.PurchaseHistory
{
    public class PurchaseHistoryDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public EntityType Type { get; set; }

        public float Price { get; set; }
    }
    
}
