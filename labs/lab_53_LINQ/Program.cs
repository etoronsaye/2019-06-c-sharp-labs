using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_53_LINQ
{
    class Program
    {
        static List<Customer> customers;
        static List<Employee> employees;

        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities())
            {

                // Chaining Where
                // var x = db..... .where ( => ) .where ( => )
                // count of order_details where discount not null and price > x
                Console.WriteLine("==== Chaining Where====\n");
                var orderOverFifty = db.Order_Details.Where(od => od.UnitPrice > 50).Where(od => od.Quantity > 3).ToList();
                orderOverFifty.ForEach(o => Console.Write($"{o.OrderID} "));

                Console.WriteLine("\n\n=== Clone without null array ===");
                var array1 = new string[] { "one", "two", null, null, "five" };
                // for each => code it
                // create new array from old using traditioal foreach loop (old way)
                var array2 = new List<string>();
                foreach (var i in array1.Where(a => a != null))
                {
                    array2.Add(i);  //Console.WriteLine(i + " ");
                }
                var finalArray2 = array2.ToArray();
                foreach(var i in finalArray2)
                {
                    Console.Write($"{i} ");
                }
                // new way
                Console.WriteLine("\nNew Way: ");
                var array2b = array1.Where(i => i != null).ToList();
                array2b.ForEach(i => Console.Write($"{i} "));

                // get customers where region not null
                Console.WriteLine("\n\n=== Customer Region not null and count===");
                var regionNotNull = db.Customers.ToList().Where(r => r.Region != null).ToList();
                Console.WriteLine(regionNotNull.Count());
                Console.WriteLine($"{regionNotNull}\n\n");

                Console.WriteLine("=== Order By Then By ===");
                // Orderby.... Then by    // country and city
                customers = db.Customers.ToList();
                employees = db.Employees.ToList();
                var customersOrdered = customers.OrderBy(c => c.ContactName).ThenBy(c => c.Country).ThenBy(c => c.City).ToList();
                    customersOrdered.ForEach(c => Console.WriteLine($"{c.ContactName,-20}{c.Country,-20}{c.City}"));
                // employee title then surname
                var employeesOrdered = employees.OrderBy(e => e.Title).ThenBy(e => e.LastName);
                // Skip(10)
                // Take(10)
                Console.WriteLine("\n\n Subset of custoemrs");
                var subsetOfCustomers = db.Customers.OrderBy(c => c.ContactName).Skip(10).Take(10).ToList();
                subsetOfCustomers.ForEach(c => Console.WriteLine(c.CustomerID));

                // can you build an app to print all customers but just 10 every second
                Console.WriteLine("\n\n=== 10 Customers a second");

                for(int i = 0; i < customers.Count; i+=10)
                {
                    var tenCustomers = db.Customers.OrderBy(c => c.ContactName).Skip(i).Take(10).ToList();
                    tenCustomers.ForEach(c => Console.WriteLine($"{c.ContactName} from {c.City}"));
                    Console.WriteLine("\n\n");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}


/* 
 * Console.WriteLine("\n\n=========Categories=======\n\n");
                categories = db.Categories.ToList();
                products = db.Products.ToList();
                foreach(var c in categories)
                {
                    Console.WriteLine($"\n\t\t{c.CategoryID}) {c.CategoryName,-15} has {c.Products.Count} products\n");
                    Console.WriteLine("\t\t\t\t====== Products====");
                    foreach(var p in c.Products)
                    {
                        Console.WriteLine($"\t\t\t\t{p.ProductID} is {p.ProductName}");
                    }
                }
*/