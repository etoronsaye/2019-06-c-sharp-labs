using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab_69_XML_from_Northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            // product list
            List<Product> products = new List<Product>();                          // Northwind
            Products productsFromXML = new Products();                             // from XML, deserialize

            using (var db = new Northwind())
            {
                // select all products; fill out list
                products = db.Products.ToList();

            }

            // find first product (use Entity and .FirstOrDefault or Take(1)
            var firProduct = products.FirstOrDefault();
            // print to screen
            Console.WriteLine($"{firProduct.ProductID} {firProduct.ProductName} {firProduct.UnitPrice}");

            // output to XML
            Console.WriteLine("\n\n Single XML Product");
            var xmlProduct = new XElement("Products",
                new XElement("Product",
                    new XElement("ProductID", firProduct.ProductID),
                    new XElement("ProductName", firProduct.ProductName),
                    new XElement("UnitPrice", firProduct.UnitPrice)
                ));

            Console.WriteLine("\n\n First 5 PRoducts\n");
            // Use linq syntax
            var XMLFiveProducts = new XElement("Products",
                from p in products.Take(5) select new XElement("Product",
                    new XElement("ProductID", p.ProductID),
                    new XElement("ProductName", p.ProductName),
                    new XElement("UnitPrice", p.UnitPrice)
                ));
            Console.WriteLine(XMLFiveProducts);

            Console.WriteLine("\n\n All Products\n");
            // Use linq syntax
            var XMLAllProducts = new XElement("Products",
                from p in products select new XElement("Product",
                    new XElement("ProductID", p.ProductID),
                    new XElement("ProductName", p.ProductName),
                    new XElement("UnitPrice", p.UnitPrice)
                ));
            Console.WriteLine(XMLAllProducts);

            // Save
            var xmlDoc = new XDocument(xmlProduct);
            xmlDoc.Save("products.xml");
            // Print
            Console.WriteLine(File.ReadAllText("products.xml"));

            // Send our Products XML List across the world to our supplier
            Console.WriteLine("\n\n====== Products to Suppliers===\n");
                                /*var formatter = new SoapFormatter();
                                using (var filestream = new FileStream("data.xml", FileMode.Create, FileAccess.Write, FileShare.None))
                                {
                                    // send data
                                    formatter.Serialize(filestream, XMLAllProducts);
                                }
                                Console.WriteLine(File.ReadAllText("data.xml"));*/

            // At the other side of the world, now deserialize file back into C# Products
                                // Product productFromXML;
            // streamread into memory first
            using (var reader = new StreamReader("Products.xml"))
            {
                // deserialize stream
                var serializer = new XmlSerializer(typeof(Products));
                productsFromXML = (Products)serializer.Deserialize(reader);
            } 
            productsFromXML.ProductList.ForEach(p => Console.WriteLine($"{p.ProductID}{p.ProductName}{p.UnitPrice}"));
                                /*using (var streamreader = File.OpenRead("data.xml"))
                                {
                                    // deserialize back into instance of class
                                    productFromXML = formatter.Deserialize(streamreader) as Product;
                                }*/

                                //Console.WriteLine($"Reconstructed Products {productFromXML.ProductID, -5}{productFromXML.ProductName, -20}{productFromXML.UnitPrice}");
        }
    }


    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> ProductList { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            this.Products = new List<Product>();
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
        //public virtual Category Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; } = 0;
        public short? UnitsInStock { get; set; } = 0;
        public short? UnitsOnOrder { get; set; } = 0;
        public short? ReorderLevel { get; set; } = 0;
        public bool Discontinued { get; set; } = false;
    }
    
    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" +
                   "Initial Catalog=Northwind;" + "Integrated Security = true;" +
                   "MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            // define a one-to-many relationship
            /*modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category);*/

            modelBuilder.Entity<Product>()
                .Property(c => c.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            /*modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products);*/

        }
    }
}

