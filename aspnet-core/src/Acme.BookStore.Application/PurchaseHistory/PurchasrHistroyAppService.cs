using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.PurchaseHistory
{
    public class PurchasrHistroyAppService : ApplicationService, IPurchaseHistoryAppService
    {
        private readonly IRepository<Purchase,Guid> _purchaseHistoryRepository;

        public PurchasrHistroyAppService(IRepository<Purchase,Guid> purchaseHistoryRepository)
        {
            _purchaseHistoryRepository = purchaseHistoryRepository;
        }

        //获取数据
        public async Task<List<PurchaseHistoryDto>> GetListAsync()
        {
            var items = await _purchaseHistoryRepository.GetListAsync();
            return items
                .Select(item => new PurchaseHistoryDto
                {
                    Name = item.Name,
                    DateTime = DateTime.Now,
                    Type = item.Type,
                    Price = item.Price,
                }).ToList();
        }

        //添加数据
        public async Task<PurchaseHistoryDto> CreateAsync(string name,float price,DateTime time,EntityType entityType)
        {
            var item =await _purchaseHistoryRepository.InsertAsync(
                new Purchase { Name = name,DateTime=time,Price=price,Type= entityType });
           
            return new PurchaseHistoryDto {
                Name = item.Name,
                DateTime = item.DateTime,
                Type = item.Type,
                Price = item.Price,
            };

        }

        public async Task DeleteAsync(Guid id)
        {
            await _purchaseHistoryRepository.DeleteAsync (id);
        }
    }

}
