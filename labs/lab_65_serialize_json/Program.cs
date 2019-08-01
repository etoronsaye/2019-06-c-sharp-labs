using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Diagnostics;

namespace lab_65_serialize_json
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01, "tim", "3 high street", "NT213B57");
            var c02 = new Customer(01, "tim", "3 high street", "NT213B57");
            var c03 = new Customer(01, "tim", "3 high street", "NT213B57");
            var customers = new List<Customer>() { c01, c02, c03 };

            var JSONinstance01 = JsonConvert.SerializeObject(c01);
            File.WriteAllText("data.json", JSONinstance01);

            Console.WriteLine(File.ReadAllText("data.json"));

            var customerListAsJSON = JsonConvert.SerializeObject(customers);
            File.WriteAllText("customers.json", customerListAsJSON);

            Console.WriteLine(File.ReadAllText("customers.json"));

            // send data round world
            // at other end imagine now on different computer
            // read ONE CUSTOMER

            var customerFromJson = JsonConvert.DeserializeObject<Customer>(File.ReadAllText("data.json"));
            Console.WriteLine($"Reconstructed customer : {customerFromJson.CustomerID} {customerFromJson.CustomerName} {customerFromJson.Address}");
            Console.WriteLine($"NINO is blank!!!  {customerFromJson.GetNINO()}");

            // READ ARRAY OF CUSTOMERS
            Console.WriteLine("\n\n=== READ ARRAY OF CUSTOMERS==\n\n");
            var customerArrayFromJson = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("customers.json"));
            foreach(var c in customerArrayFromJson)
            {
                Console.WriteLine($"Reconstructed customer : {c.CustomerID} {c.CustomerName} {c.Address}");
            }

            // Pull Task
            // Uri philCustomerGit = new Uri("https://github.com/philanderson888/data/blob/master/customers.json");
            // download this file
            var downloadPhilCustomerGit = new WebClient { Proxy = null };
            var philCustomerGit = new Uri("https://raw.githubusercontent.com/philanderson888/data/master/customers.json");
            downloadPhilCustomerGit.DownloadFile(philCustomerGit, "philsCustomerGit.json");
            //Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\atom", "philsCustomerGit.json");
        }
    }

    [Serializable]
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }

        [NonSerialized]
        private string NINO;

        // constructor
        public Customer(int CustomerID, string CustomerName, string Address, string NINO)
        {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
            this.Address = Address;
            this.NINO = NINO;

        }
        // GetNINO(){}
        public string GetNINO()
        {
            return this.NINO;
        }
    }
}
