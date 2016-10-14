using System;
using System.Windows.Forms;
using StockMarket;

namespace StockViewer.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StockViewerForm(
                new SimpleAuthenticationService(),
                new SimpleStockPortfolioService(),
                new SimpleStockPriceService()));
        }
    }
}