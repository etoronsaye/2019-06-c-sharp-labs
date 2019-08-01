using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;


namespace lab_64_serialize_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01, "tim", "3 high street", "NT213B57");

            // XML Serialise into FILE STREAM
            var formatter = new SoapFormatter();
            using (var filestream = new FileStream("data.xml",FileMode.Create,FileAccess.Write,FileShare.None))
            {
                // send data
                formatter.Serialize(filestream, c01);
            }
            Console.WriteLine(File.ReadAllText("data.xml"));

            // imagine on another computer : can we reconstruct instance?
            Customer customerFromXML;
            using (var streamreader = File.OpenRead("data.xml"))
            {
                // deserialize back into instance of class
                customerFromXML = formatter.Deserialize(streamreader) as Customer;
            }

            Console.WriteLine($"Reconstructed customer : {customerFromXML.CustomerID} {customerFromXML.CustomerName} {customerFromXML.Address}");
            Console.WriteLine($"NINO is blank!!!  {customerFromXML.GetNINO()}");
        }
    }

    [Serializable]
    class Customer
    {
        public int CustomerID { get; set; }
        public string  CustomerName { get; set; }
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
