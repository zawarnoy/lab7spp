using StoreApplication.Store.CashBox.ProductsDataStorage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Store.CashBox.CheckPrinter
{
    public class ConsoleCheckPrinter : ICheckPrinter
    {

        private BaseStorage productsDataStorage;
        private Hashtable codeAmountTable = new Hashtable();

        public double printPrice()
        {
            double price = 0;

            foreach(DictionaryEntry codeAmount in codeAmountTable)
            {
                price += this.getProductPriceByBarcodeAmount( (string)codeAmount.Key, (int)codeAmount.Value);
            }

            codeAmountTable.Clear();

            return price;

        }


        private double getProductPriceByBarcodeAmount(string barcode, int amount)
        {
            Hashtable productInfo = (Hashtable)productsDataStorage.storage[barcode];
            if (amount >= (int)productInfo["amountForDiscount"])
                return amount * (int)productInfo["price"] * (1 - (double)productInfo["discountValue"]) ;
            else
                return amount * (int)productInfo["price"];
        }

        public ConsoleCheckPrinter()
        {
            this.productsDataStorage = new BarcodeAmountPriceStrorage();
        }

        public void addProductToCheck(string barcode)
        {
            if(codeAmountTable.Contains(barcode))
            {
                codeAmountTable[barcode] = (int)codeAmountTable[barcode]+1 ;

            } else
            {
                codeAmountTable.Add(barcode, 1);
            }
        }





    }
}
