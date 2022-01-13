using System;
using Volo.Abp.Domain.Entities;

namespace Acme.BookStore
{
    public class BookItem : BasicAggregateRoot<Guid>
    {
        public String Text { get; set; }
    }
}
