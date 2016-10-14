using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockMarket
{
    public interface IStockPortfolioService
    {
        Task<List<StockHolding>> GetPortfolioAsync(Guid userId);
    }
}