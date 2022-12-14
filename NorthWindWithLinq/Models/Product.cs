using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWithLinq.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }            //Fk
        public int? CategoryId { get; set; }            //FK
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public override string ToString()               //When you overide this, it'll be the default when you do a writeline
        {
            return $"Product Id : {ProductId}\n" +      // the \n will put it on a new line
                $"Product Name : {ProductName}\n";
        }

    }
}
