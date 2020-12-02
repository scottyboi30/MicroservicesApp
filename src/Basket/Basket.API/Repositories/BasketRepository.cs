using Basket.API.Entities;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Basket.API.Data;

namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IBasketContext _context;

        public BasketRepository(IBasketContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<BasketCart> GetBasket(string userName)
        {
            var basket = await _context
                .Redis
                .StringGetAsync(userName);
            
            return basket.IsNullOrEmpty ? null : JsonConvert.DeserializeObject<BasketCart>(basket);
        }

        public async Task<BasketCart> UpdateBasket(BasketCart basket)
        {
            var updated = await _context
                .Redis
                .StringSetAsync(basket.UserName, JsonConvert.SerializeObject(basket));
            
            return !updated ? null : await GetBasket(basket.UserName);
        }

        public async Task<bool> DeleteBasket(string userName)
        {
            return await _context
                .Redis
                .KeyDeleteAsync(userName);
        }
    }
}
