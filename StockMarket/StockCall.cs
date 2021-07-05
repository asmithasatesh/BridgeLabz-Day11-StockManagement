using Newtonsoft.Json;
using System;
using System.IO;

namespace StockMarket
{
    class StockCall
    {
        static void Main(string[] args)
        {
            //Creating obj for StockManager
            StockManager stockManager = new StockManager();
            //getting path of json file
            string file = @"C:\Users\DELL\Desktop\StockMarket\StockMarket\Json.json";
            //DeserializeO Json file
            StockUtility stockUtility = JsonConvert.DeserializeObject<StockUtility>(File.ReadAllText(file));
            Console.WriteLine("Enter which operation to perform\n 1-Add a stock\n 2-Remove a stock\n3-Display Stocks");
            int num = Convert.ToInt32(Console.ReadLine());
            var fs = stockUtility.stocksList;
            switch (num)
            {
                case 1:
                    stockManager.AddStock(fs);
                    File.WriteAllText(file, JsonConvert.SerializeObject(stockUtility));
                    stockManager.DisplayStocks(fs);
                    break;
                case 2:
                    stockManager.DeleteInventory(fs);
                    File.WriteAllText(file, JsonConvert.SerializeObject(stockUtility));
                    stockManager.DisplayStocks(fs);
                    break;
                case 3:
                    stockManager.DisplayStocks(fs);
                    break;
            }

        }
    }
}
