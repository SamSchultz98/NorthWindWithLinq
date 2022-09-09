using NorthWindWithLinq;
using NorthWindWithLinq.Models;


NorthwindContext _context = new();
var suppliers = _context.Suppliers.ToList();
var products = _context.Products.ToList();



var SupplierProd = from S in _context.Suppliers
                   join P in _context.Products
                   on S.SupplierId equals P.SupplierId
                   orderby S.CompanyName
                   select new       //Select new: Pick a property from the table you are joining together
                   {
                       Supplier = S.CompanyName, Product = P.ProductName        //Putting this as a new alias in oder to call later
                   };

foreach (var S in SupplierProd)
{
    Console.WriteLine($"{S.Supplier} {S.Product}"); 
}
/*
var products = _context.Products.ToList();

products.ForEach(p => Console.WriteLine(p));

*/

/*

var employees = from Empl in _context.Employees
                where !Empl.Country.ToUpper().Equals("USA".ToUpper()) 
                orderby Empl.LastName descending
                select Empl;

foreach(var employee in employees)
{
    Console.WriteLine($"{employee.EmployeeId} | {employee.FirstName} | {employee.LastName} | {employee.Country}");
}


*/