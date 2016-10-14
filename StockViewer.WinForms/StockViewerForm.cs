using System;
using System.Windows.Forms;
using StockMarket;

namespace StockViewer.WinForms
{
    public partial class StockViewerForm : Form
    {
        private readonly IAuthenticationService authenticationService;
        private readonly IStockPortfolioService portfolioService;
        private readonly IStockPriceService priceService;

        // Preserved for the sake of the Windows Form designer
        public StockViewerForm() : this(null, null, null)
        {
        }

        public StockViewerForm(IAuthenticationService authenticationService, IStockPortfolioService portfolioService,
            IStockPriceService priceService)
        {
            this.authenticationService = authenticationService;
            this.portfolioService = portfolioService;
            this.priceService = priceService;
            InitializeComponent();
        }

        private async void FetchStocks(object sender, EventArgs e)
        {
            try
            {
                fetchButton.Enabled = false;
                passwordTextBox.Enabled = false;
                userTextBox.Enabled = false;
                debugLog.Clear();
                portfolioListView.Items.Clear();

                Log("Authenticating");
                var userId = await authenticationService.AuthenticateUserAsync(userTextBox.Text, passwordTextBox.Text);
                Log("Authenticated - GUID \n{0}", userId);
                if (userId == null)
                {
                    Log("Authentication failure - abort");
                    MessageBox.Show("User unknown, or incorrect password", "Authentication failure",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Log("Fetching holdings");
                var holdings = await portfolioService.GetPortfolioAsync(userId.Value);
                Log("Received {0} holdings", holdings.Count);

                Log("Fetching prices");
                var totalWorth = 0m;

                foreach (var holding in holdings)
                {
                    var price = await priceService.LookupPriceAsync(holding.Ticker);
                    Log("Price of {0}: {1}", holding.Ticker, price);
                    AddPortfolioEntry(holding.Ticker, holding.Quantity, price, holding.Quantity*price);
                    if (price != null)
                    {
                        totalWorth += holding.Quantity*price.Value;
                    }
                }

                Log("Fetched all prices");
                AddPortfolioEntry("TOTAL", null, null, totalWorth);
            }
            finally
            {
                fetchButton.Enabled = true;
                userTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
            }
        }

        private void AddPortfolioEntry(string ticker, int? quantity, decimal? price, decimal? value)
        {
            portfolioListView.Items.Add(
                new ListViewItem(new[] {ticker, quantity.ToString(), price.ToString(), value.ToString()}));
        }

        private void Log(string format, params object[] values)
        {
            var text = string.Format(format, values);
            string line = $"{DateTime.Now:HH:mm:ss.fff}: {text}{Environment.NewLine}";
            debugLog.AppendText(line);
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                FetchStocks(sender, e);
            }
        }
    }
}