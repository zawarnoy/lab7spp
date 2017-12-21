using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Store.CashBox.CheckPrinter
{
    public interface ICheckPrinter
    {
        double printPrice();
        void addProductToCheck(string barcode);
    }
}
