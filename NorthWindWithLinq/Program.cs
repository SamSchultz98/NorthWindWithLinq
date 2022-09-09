using NorthWindWithLinq;
using NorthWindWithLinq.Models;


NorthwindContext _context = new();
var products = _context.Products.ToList();

products.ForEach(p => Console.WriteLine(p.ToString()));



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