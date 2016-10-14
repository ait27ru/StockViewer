using System.Threading.Tasks;

namespace StockMarket
{
    public interface IStockPriceService
    {
        Task<decimal?> LookupPriceAsync(string ticker);
    }
}