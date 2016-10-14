using System;
using System.Collections.Generic;

namespace StockMarket
{
    internal class SimpleDataContext
    {
        public static SimpleDataContext DemoData = new SimpleDataContext
        {
            Users = new List<User>
            {
                new User(Guid.Parse("8FF41875-16DA-4B54-9F2E-77E748BADE8F"), "Joe", "1"),
                new User(Guid.Parse("D1CE5DD0-2CF6-44F9-A2E4-237B2C63F2E3"), "Bob", "2")
            }
        };

        public List<User> Users { get; set; }
    }
}