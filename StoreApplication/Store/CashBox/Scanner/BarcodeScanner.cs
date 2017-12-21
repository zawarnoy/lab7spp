using StoreApplication.Store.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Store.CashBox.Scanner
{
    public class BarcodeScanner : IScanner
    {
        public string scanProduct(BaseProduct product)
        {
            return product.barcode;
        }
    }
}
