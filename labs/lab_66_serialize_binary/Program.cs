using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab_66_serialize_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01, "tim", "3 high street", "NT213B57");
            var c02 = new Customer(01, "tim", "3 high street", "NT213B57");
            var c03 = new Customer(01, "tim", "3 high street", "NT213B57");
            var customers = new List<Customer>() { c01, c02, c03 };
            
            // perform the serialization
            var binaryformatter = new BinaryFormatter();
            // stream serialized data - to a File in this case but could be web or RAM (Memory)
            using (var binarystream = new FileStream("data.bin", FileMode.Create,FileAccess.Write,FileShare.None))
            {
                // write data to file
                binaryformatter.Serialize(binarystream, customers);
            }

            Console.WriteLine(File.ReadAllText("data.bin"));

            // send data across world and de-serialize at the other end
            using (var reader = File.OpenRead("data.bin"))
            {
                var customersFromBinary = binaryformatter.Deserialize(reader) as List<Customer>;
                // iterater and print
                foreach (var c in customersFromBinary)
                {
                    Console.WriteLine($"Reconstructed customer : {c.CustomerID} {c.CustomerName} {c.Address}");
                }
            }

            
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
