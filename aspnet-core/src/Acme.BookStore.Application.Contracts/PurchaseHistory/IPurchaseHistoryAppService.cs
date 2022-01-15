using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;

namespace Acme.BookStore.PurchaseHistory
{
    public interface IPurchaseHistoryAppService : IApplicationService
    {
        Task<List<PurchaseHistoryDto>> GetListAsync();
        Task<PurchaseHistoryDto> CreateAsync(string name, float price, DateTime time, EntityType entityType);
        Task DeleteAsync(Guid id);
    }

}
