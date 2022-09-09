using NorthWindWithLinq;




NorthwindContext _context = new NorthwindContext();
var employees = from Empl in _context.Employees
                select Empl;

foreach(var employee in employees)
{
    Console.WriteLine($"{employee.EmployeeId} {employee.FirstName} {employee.LastName}");
}

