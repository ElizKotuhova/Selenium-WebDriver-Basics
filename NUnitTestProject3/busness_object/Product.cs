using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace NUnitTestProject3.busness_object
{
    public class Product
    {      
        public string sendkeysProductName { get; set; }
        public string sendkeysUnitPrice { get; set; }
        public string sendkeysQuantityPerUnit { get; set; }
        public string sendkeysUnitInStock { get; set; }
        public string sendkeysUnitsOnOrder { get; set; }
        public string sendkeysReorderLevel { get; set; }

        public Product(
                        string sendkeysProductName,
                        string sendkeysUnitPrice,
                        string sendkeysQuantityPerUnit,
                        string sendkeysUnitInStock,
                        string sendkeysUnitsOnOrder,
                        string sendkeysReorderLevel)
        {
            this.sendkeysProductName = sendkeysProductName;
            this.sendkeysUnitPrice = sendkeysUnitPrice;
            this.sendkeysQuantityPerUnit = sendkeysQuantityPerUnit;
            this.sendkeysUnitInStock = sendkeysUnitInStock;
            this.sendkeysUnitsOnOrder = sendkeysUnitsOnOrder;
            this.sendkeysReorderLevel = sendkeysReorderLevel;
        }
    }
}
