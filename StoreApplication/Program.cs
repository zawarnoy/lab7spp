using StoreApplication.Store.CashBox;
using StoreApplication.Store.CashBox.CheckPrinter;
using StoreApplication.Store.Products.MilkProducts.Milk;
using StoreApplication.Store.Products.Sweets.Candies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            CashBox pri = new CashBox();

            pri.addProductToCheck(new CandyBelochka());
            pri.addProductToCheck(new CandyBelochka());
            pri.addProductToCheck(new CandyBelochka());
            pri.addProductToCheck(new CandyBelochka());
            pri.addProductToCheck(new CandyBelochka());
            pri.addProductToCheck(new CandyBelochka());
            pri.addProductToCheck(new MilkProstokvashino());

            Console.WriteLine(pri.getPrice());

            Console.ReadLine();
        }
    }
}
