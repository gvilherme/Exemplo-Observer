using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExample.Entities
{
    class SaleProduct
    {
        public String ProductName { get; private set; }
        public int Product_Id { get; private set; }
        public double Unit_Value { get; private set; }
        public int Qnt { get; private set; }

        public SaleProduct(string productName, int product_Id, double unit_Value, int qnt)
        {
            ProductName = productName;
            Product_Id = product_Id;
            Unit_Value = unit_Value;
            Qnt = qnt;
        }
    }
}
