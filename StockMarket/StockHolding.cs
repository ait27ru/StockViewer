namespace StockMarket
{
    public class StockHolding
    {
        public StockHolding(string ticker, int quantity)
        {
            Ticker = ticker;
            Quantity = quantity;
        }

        public string Ticker { get; private set; }
        public int Quantity { get; private set; }
    }
}