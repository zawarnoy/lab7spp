using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Store.CashBox.ProductsDataStorage
{
    public class BarcodeAmountPriceStrorage : BaseStorage
    {
        public BarcodeAmountPriceStrorage()
        {

            Hashtable candyBelochkaInfo = new Hashtable();
            candyBelochkaInfo.Add("price", 10);
            candyBelochkaInfo.Add("amountForDiscount", 5);
            candyBelochkaInfo.Add("discountValue", 0.5);
            this.storage.Add("100", candyBelochkaInfo);

            Hashtable milkProstokvashinoInfo = new Hashtable();
            milkProstokvashinoInfo.Add("price", 20);
            milkProstokvashinoInfo.Add("amountForDiscount", 3);
            milkProstokvashinoInfo.Add("discountValue", 0.2);
            this.storage.Add("200", milkProstokvashinoInfo);
        }
    }
}
