﻿using StoreApplication.Store.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Store.CashBox.Scanner
{
    public interface IScanner
    {
        string scanProduct(BaseProduct product);
    }
}