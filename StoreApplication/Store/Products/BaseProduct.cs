using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Store.Products
{
    public abstract class BaseProduct
    {

        public string name { get; protected set; }
        public string barcode { get; protected set; }
        
    }
}
