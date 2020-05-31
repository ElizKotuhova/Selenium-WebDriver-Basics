using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject3.busness_object
{
    public class Product
    {
        public string clickProduct { get; set; }
        public string clickCreateNew { get; set; }
        public string sendkeysProductName { get; set; }
        public string clickCategory { get; set; }
        public string sendkeysCategory { get; set; }
        public string clickSupplier { get; set; }
        public string sendkeysSupplier { get; set; }
        public string sendkeysUnitPrice { get; set; }
        public string sendkeysQuantityPerUnit { get; set; }
        public string sendkeysUnitInStock { get; set; }
        public string sendkeysUnitsOnOrder { get; set; }
        public string sendkeysReorderLevel { get; set; }


        public Product(string clickProduct,
                        string clickCreateNew,
                        string sendkeysProductName,
                        string clickCategory,
                        string clickSupplier,
                        string sendkeysUnitPrice,
                        string sendkeysQuantityPerUnit,
                        string sendkeysUnitInStock,
                        string sendkeysUnitsOnOrder,
                        string sendkeysReorderLevel)
        {
            this.clickProduct = clickProduct;
            this.clickCreateNew = clickCreateNew;
            this.sendkeysProductName = sendkeysProductName;
            this.clickCategory = clickCategory;
            this.clickSupplier = clickSupplier;
            this.sendkeysUnitPrice = sendkeysUnitPrice;
            this.sendkeysQuantityPerUnit = sendkeysQuantityPerUnit;
            this.sendkeysUnitInStock = sendkeysUnitInStock;
            this.sendkeysUnitsOnOrder = sendkeysUnitsOnOrder;
            this.sendkeysReorderLevel = sendkeysReorderLevel;
        }
    }
}
