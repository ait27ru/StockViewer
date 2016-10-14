using System.Threading.Tasks;

namespace StockMarket
{
    public class SimpleStockPriceService : IStockPriceService
    {
        public async Task<decimal?> LookupPriceAsync(string ticker)
        {
            return 0m;
        }
    }
}