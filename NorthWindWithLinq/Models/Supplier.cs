using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWithLinq.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }     //PK
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? HomePage { get; set; }

        public override string ToString()               //When you overide this, it'll be the default when you do a writeline
        {
            return $"Company Name : {CompanyName}\n" +      // the \n will put it on a new line
                $"SupplierId : {SupplierId}\n";
        }

    }
}
