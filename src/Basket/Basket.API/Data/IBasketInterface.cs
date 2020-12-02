using StackExchange.Redis;

namespace Basket.API.Data
{
    public interface IBasketContext
    {
        IDatabase Redis { get; }
    }
}
