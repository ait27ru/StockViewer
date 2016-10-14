using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockMarket
{
    public class SimpleStockPortfolioService : IStockPortfolioService
    {
        public async Task<List<StockHolding>> GetPortfolioAsync(Guid userId)
        {
            return new List<StockHolding>();
        }
    }
}