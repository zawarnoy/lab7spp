using StoreApplication.Store.CashBox.ProductsDataStorage;
using StoreApplication.Store.CashBox.Scanner;
using StoreApplication.Store.CashBox.CheckPrinter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using StoreApplication.Store.Products;

namespace StoreApplication.Store.CashBox
{
    public class CashBox
    {
        IScanner productScanner;
        ICheckPrinter checkPrinter;

        public CashBox() : this( new BarcodeScanner(), new ConsoleCheckPrinter() )
        {
        }

        public CashBox( IScanner productScanner, ICheckPrinter checkPrinter)
        {
            this.productScanner = productScanner;
            this.checkPrinter = checkPrinter;
        }

        public void addProductToCheck(BaseProduct product)
        {
            string barcode = productScanner.scanProduct(product);
            checkPrinter.addProductToCheck(barcode);
        }

        public double getPrice()
        {
            return checkPrinter.printPrice();
        }

    }
}
