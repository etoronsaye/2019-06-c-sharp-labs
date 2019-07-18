using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_51_entity_CRUD_app
{
    class Program
    {
        static List<Customer> customers;
        static Customer customer;
        static void Main(string[] args)
        {

            AddCustomer();
            UpdateCustomer();
            DeleteCustomer();
            
        }

        static void AddCustomer()
        {
            // new Customer
            Console.WriteLine("\n\nAdding New Customer\n=============\n\n");
            var newCustomer = new Customer()
            {
                CustomerID = "ORETH",
                ContactTitle = "Miss",
                ContactName = "Theresa",
                CompanyName = "Ebuana",
                City = "London",
                Country = "UK"
            };
            /*
           var newCustomer1 = new Customer()
           {
               CustomerID = "ORETE",
               ContactTitle = "Miss",
               ContactName = "Theresa",
               CompanyName = "Ebuana",
               City = "London",
               Country = "UK"
           };
           */
            // add to db
            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(newCustomer);
                //db.Customers.Add(newCustomer1);
                int affected = db.SaveChanges();
                Console.WriteLine($"added {affected} records");
            }
        }
        static void UpdateCustomer()
        {
            // Find and update a customer
            Console.WriteLine("\n\nUpdating Customer\n=============\n\n");
            using (var db = new NorthwindEntities())
            {
                var customerUpdate = db.Customers.Find("ORETH");
                customerUpdate.City = "Sheffield";
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} records updates");
                ListAll(db.Customers.ToList());
            }
        }
        static void DeleteCustomer()
        {
            // Find and delete a customer
            Console.WriteLine("\n\nDeleting Customer\n=============\n\n");
            using (var db = new NorthwindEntities())
            {
                var customerToDelete = db.Customers.Find("ORETH");
                db.Customers.Remove(customerToDelete);
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} records deleted");
                ListAll(db.Customers.ToList());
            }
        }
        static void ListAll(List<Customer> listCustomers)
        {
            using (var db = new NorthwindEntities())
            {
                foreach (var c in db.Customers)
                {
                    Console.WriteLine($"{c.CustomerID,-10} {c.ContactName,-30} {c.Address,-30} {c.CompanyName, -20} {c.City}");
                }
            }
        }
    }
}
