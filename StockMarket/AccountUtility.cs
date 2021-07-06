using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket
{
    class AccountUtility
    {

        public List<Account> AccountList { get; set; }

        public class Account
        {
            public string Stockholder { get; set; }
            public string StockName { get; set; }
            public int shares { get; set; }
            public int Price { get; set; }
        }
    }


}
